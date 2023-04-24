using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CS3._0Project.Code.Utility.Classes;

namespace CS3._0Project.Code.Management {
    public partial class frmClock : Form {

        private Size screenSize;
        private int userID;
        private int userIndex;
        private bool isManager;
        private List<int> userClockIndexs = new List<int>();

        private DBTools DBTools = new DBTools();

        public frmClock(Size screenSize, int userID, bool isManager) {
            InitializeComponent();
            cbxMngrSelectedUser.SelectedValue = userID;
            this.screenSize = screenSize;
            this.userID = userID;
            this.isManager = isManager;
        }

        private void frmClock_Load(object sender, EventArgs e) {
            DBInit();
            this.Size = screenSize;
            this.Location = new Point(0, 0);
            updateUser(userID);
            frmUpdate(userID);
        }

        private void frmMangerUpdate(int userID) { // Update all aspects of the form, then the manager side
            frmUpdate(userID); // Regular update
            if (!isManager) { // If is not a manger do not continue
                return;
            }

            cbxMngrSelectedUser.SelectedValue = userID; // Set userID

            if (isClockedIn(userID, userClockIndexs)) { // Check if clocked in form manager text
                lblMangrClocked.Text = "Clocked In";
            } else {
                lblMangrClocked.Text = "Clocked Out";
            }
        }

        private void frmUpdate(int userID) { // Form update
            userClockIndexs = getUserClockIndexs(ePOSDBDataSet.tblClockLog, userID); // Get anew users clock indexs to display in the dgv
            fillDGV();

        }

        private void updateUser(int userID) { // If the user is changed
            pnlManager.Hide(); // Hide the manager form

            userIndex = DBTools.getUserIndex(ePOSDBDataSet.tblEPOSUsers, userID); // Get the user index

            // Get names and add to form
            string username = ePOSDBDataSet.tblEPOSUsers.Rows[userIndex][1].ToString();
            string forename = ePOSDBDataSet.tblEPOSUsers.Rows[userIndex][5].ToString();
            string surname = ePOSDBDataSet.tblEPOSUsers.Rows[userIndex][6].ToString();
            lblNameText.Text = String.Format("User: {0}\nName: {1} {2}", username, forename, surname);

            if (isManager) { // If is manager, add the word manager underneath the name and show the panel and update the manager cbx
                lblNameText.Text += "\nManager";
                cbxMngrSelectedUser.SelectedValue = userID;
                pnlManager.Show();
            }
        }

        private void DBInit() { // Pull DB
            this.tblEPOSUsersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSUsers);
            this.tblEPOSUsersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSUsers);
            this.tblClockLogTableAdapter.Fill(this.ePOSDBDataSet.tblClockLog);
        }

        private void btnHome_Click(object sender, EventArgs e) { // Button Event
            this.Hide();
        }

        private List<int> getUserClockIndexs(DataTable tblClock, int userID) { // Get all the indexs in the DB of this users clocks
            List<int> userClockIndexs = new List<int>(); // New list
            for (int i = 0; i < tblClock.Rows.Count; i++) { // for evey item in the clock table, iterate through
                if (userID != Convert.ToInt32(tblClock.Rows[i][1])) { // If the user ID is not the current user, reset loop
                    continue;
                }
                userClockIndexs.Add(i); // If user match, add the current index to the list
            }
            return userClockIndexs;
        }

        private void fillDGV() { // Inserts all the information in the dgv
            dgvClockDisplay.Rows.Clear(); // Clear dgv

            DataRowCollection clockTableRows = ePOSDBDataSet.tblClockLog.Rows; // Get all the table rows
            foreach (int userClockIndex in userClockIndexs) { // For ever user clocked in index
                dgvClockDisplay.Rows.Add(1); // Add a new dgv row
                int newRowIndex = dgvClockDisplay.Rows.Count - 1; // Get the index of the row just added

                DateTime startTime = Convert.ToDateTime(clockTableRows[userClockIndex][2]);
                string notes = clockTableRows[userClockIndex][4].ToString();

                dgvClockDisplay[0, newRowIndex].Value = startTime.ToString(); // Insert Start Time

                if(clockTableRows[userClockIndex][3] != DBNull.Value) { // If there is no clock out time leave it blank
                    DateTime endTime = Convert.ToDateTime(clockTableRows[userClockIndex][3]);
                    TimeSpan duration = endTime - startTime;
                    dgvClockDisplay[1, newRowIndex].Value = endTime.ToString(); // Insert End Time
                    dgvClockDisplay[2, newRowIndex].Value = String.Format("{0}:{1}:{2}", Math.Truncate(duration.TotalHours).ToString("00"), duration.Minutes.ToString("00"), duration.Seconds.ToString("00"));//duration.ToString(@"hh\:mm\:ss"); // Insert End Time
                }
                if (clockTableRows[userClockIndex][4] != DBNull.Value) { // If there is no note leave it blank
                    dgvClockDisplay[3, newRowIndex].Value = notes; // Insert Notes
                }
            }
            dgvClockDisplay.ClearSelection();
        }

        public void clockIn(int userID, DateTime startTime) { // Clock in a specified user with a specified time
            if (isClockedIn(userID, userClockIndexs)) { // If is clocked in do not attempt to clock in
                return;
            }
            ePOSDBDataSet.tblClockLog.Rows.Add(); // Create a new row
            int newRowIndex = ePOSDBDataSet.tblClockLog.Rows.Count - 1; // Get the new row index

            ePOSDBDataSet.tblClockLog.Rows[newRowIndex][1] = userID; // Insert userID and start time
            ePOSDBDataSet.tblClockLog.Rows[newRowIndex][2] = startTime;

            tblClockLogTableAdapter.Update(ePOSDBDataSet.tblClockLog); // Update and fill table
            tblClockLogTableAdapter.Fill(ePOSDBDataSet.tblClockLog);

            frmMangerUpdate(userID); // Form update and redraw
            fillDGV();
        }

        private void clockInNow(int userID) { // Clock a specifeid user in now
            clockIn(userID, DateTime.Now);
        }

        public void clockOut(int userID, DateTime endTime) { // Clock out a specified user with a specified time
            if (!isClockedIn(userID, userClockIndexs)) { // If the user is not clocked in we cannot clock out so return
                return;
            }
            int userLastClockIndex = userClockIndexs[userClockIndexs.Count - 1]; // Get the last clocked in index
            ePOSDBDataSet.tblClockLog.Rows[userLastClockIndex][3] = endTime; // Insert the end time into the tab;e

            tblClockLogTableAdapter.Update(ePOSDBDataSet.tblClockLog); // Update and fill
            tblClockLogTableAdapter.Fill(ePOSDBDataSet.tblClockLog);

            frmMangerUpdate(userID); // Form update and redraw
            fillDGV();
        }

        private void clockOutNow(int userID) { // Clock a specifeid user out now
            clockOut(userID, DateTime.Now);
        }

        private bool isClockedIn(int userID, List<int> userClockIndexs) { // Clock a specifeid user out now
            bool isClockedIn = false;
            DataRowCollection clockTableRows = ePOSDBDataSet.tblClockLog.Rows;

            for(int i = userClockIndexs.Count - 1; i >= 0; i--) { // Iterated backwards from the bottom of the user clock indexs
                int userClockIndex = userClockIndexs[i];
                if (Convert.ToInt32(clockTableRows[userClockIndex][1]) != userID) { 
                    continue;
                } // If there is a user ID match (user could be clocked in or out)
                if (clockTableRows[userClockIndex][3] != DBNull.Value) {
                    continue;
                } // If the user has a clock in time but no clock out time
                // Then must be clocked in
                isClockedIn = true;
                break; // Break to avoid unnesesary looping
            }
            return isClockedIn;
        }

        private void btnClockIn_Click(object sender, EventArgs e) { // Button Event
            clockInNow(userID);
        }

        private void btnClockOut_Click(object sender, EventArgs e) { // Button Event
            clockOutNow(userID);
        }

        private void btnAddShift_Click(object sender, EventArgs e) { // Button Event
            frmShiftAddDialog frmShiftAddDialog = new frmShiftAddDialog(this, userID);
            frmShiftAddDialog.ShowDialog();
        }

        private void btnDeleteShift_Click(object sender, EventArgs e) { // Button Event
            if (dgvClockDisplay.SelectedRows.Count == 0) { // if no row is selected return
                return;
            }
            int removeIndex = userClockIndexs[dgvClockDisplay.SelectedRows[0].Index]; // Index to remove from

            ePOSDBDataSet.tblClockLog.Rows[removeIndex].Delete(); // Delete from DB
            tblClockLogTableAdapter.Update(ePOSDBDataSet.tblClockLog); 
            ePOSDBDataSet.tblClockLog.AcceptChanges(); 

            frmUpdate(userID); // Update from

        }

        private void cbxMngrSelectedUser_SelectionChangeCommitted(object sender, EventArgs e) {
            this.userID = Convert.ToInt32(cbxMngrSelectedUser.SelectedValue); // Get manager ID
            frmMangerUpdate(userID); // Update form and manager side
        }
    }
}
