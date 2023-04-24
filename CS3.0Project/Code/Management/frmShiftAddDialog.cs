using CS3._0Project.Code.Utility.Forms;
using CS3._0Project.Forms.Utility;
using CS3._0Project.Forms.Utility.Classes;
using System;
using System.Windows.Forms;

namespace CS3._0Project.Code.Management {
    public partial class frmShiftAddDialog : Form {

        // Variable Init

        private frmClock frmClock;
        private frmMessageBox cMessagebox = new frmMessageBox();
        private int userID;

        public DateTime startTime;
        public DateTime endTime;

        public frmShiftAddDialog(frmClock frmClock, int userID) { // Constructor
            InitializeComponent();
            this.frmClock = frmClock;
            this.userID = userID;
            new ControlDragger(this, false, false); // enable dragging
        }

        private void frmShiftAddDialog_Load(object sender, EventArgs e) { // On form load
            this.tblEPOSUsersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSUsers); // DB Users
            cbxUser.SelectedValue = userID; // Make the current user the logged in user
            setDateTimeNow(); // Set the text boxes date and time to now
        }

        private void btnAddShift_Click(object sender, EventArgs e) { // On add shift click

            // Ensureing differnece in times makes sence, if not then return the function
            if (startTime > endTime) {
                cMessagebox.ShowMessage("Start Time cannot be after the end time.");
                return;
            }
            if (startTime > DateTime.Now || endTime > DateTime.Now) { 
                cMessagebox.ShowMessage("Cannot create shifts in the future.");
                return;
            }

            // Clock the user in and out and a selected time
            frmClock.clockIn(userID, startTime);
            frmClock.clockOut(userID, endTime);
            this.Close(); // Close the dialog
        }

        private void OnTextChanged(Object sender, EventArgs e) {// IF Any text is chaged, update duration and check for errors
            TextBox tb = (TextBox)sender;

            // Format times into strings
            string start = String.Format("{0}/{1}/{2} {3}:{4}:00", txtStartDay.Text, txtStartMonth.Text, txtStartYear.Text, txtStartHour.Text, txtStartMin.Text);
            string end = String.Format("{0}/{1}/{2} {3}:{4}:00", txtEndDay.Text, txtEndMonth.Text, txtEndYear.Text, txtEndHour.Text, txtEndMin.Text);

            // Try except to catch conversion errors
            try {
                // Convert from string to time 
                startTime = Convert.ToDateTime(start);
                endTime = Convert.ToDateTime(end) + TimeSpan.FromMinutes(1); // Add 1 min so that we dont underpay anyone by up to 59 seconds (all added times start on the minute)
            } catch (System.FormatException) { // Catch the format exception
                cMessagebox.ShowMessage("Invalid date(s)/times(s)\nPlease ensure dates follow the UK layout (dd/mm/yyyy) and times follow the 24 hour layout (hh:mm)."); // Show message
                btnAddShift.Visible = false; // Disable button until passed
                return;
            }
            btnAddShift.Visible = true; // Once passed try/catch, enable button again


            TimeSpan timeDiff = endTime - startTime; // Get timeDiff

            // Update duration text to the calculated time with formatting
            lblDuration.Text = String.Format("Duration: {0}:{1}:{2}", Math.Truncate(timeDiff.TotalHours).ToString("00"), timeDiff.Minutes.ToString("00"), timeDiff.Seconds.ToString("00"));
        }

        private void btnReset_Click(object sender, EventArgs e) { // Reset time to now
            setDateTimeNow();
        }

        private void setDateTimeNow() {
            DateTime now = DateTime.Now; // Get datetime now
            // Set start & end times to now
            setStartDateTime(now);
            setEndDateTime(now);
        }

        private void setStartDateTime(DateTime startTime) { // Format each text box into the required format for start times
            txtStartDay.Text = startTime.Day.ToString("00");
            txtStartMonth.Text = startTime.Month.ToString("00");
            txtStartYear.Text = startTime.Year.ToString("0000");
            txtStartHour.Text = startTime.Hour.ToString("00");
            txtStartMin.Text = startTime.Minute.ToString("00");
        }

        private void setEndDateTime(DateTime endTime) { // Format each text box into the required format for end times
            txtEndDay.Text = endTime.Day.ToString("00");
            txtEndMonth.Text = endTime.Month.ToString("00");
            txtEndYear.Text = endTime.Year.ToString("0000");
            txtEndHour.Text = endTime.Hour.ToString("00");
            txtEndMin.Text = endTime.Minute.ToString("00");
        }

        private void cbxUser_SelectedIndexChanged(object sender, EventArgs e) { // If user changes, update userID
            userID = Convert.ToInt32(cbxUser.SelectedValue);
        }

        private void btnClose_Click(object sender, EventArgs e) { // Close
            this.Close();
        }

        private void txt2Chars_Click(object sender, EventArgs e) { // If a two char box is clicked, open a number pad, limited to 2 numbers
            TextBox tb = (TextBox)sender;

            frmNumPad frmNumPad = new frmNumPad(2);
            string getInput = frmNumPad.getInput(tb.Text);

            if (getInput.Length < 1) { // if input is empty, do not change time
                return;
            }
            tb.Text = Convert.ToInt32(getInput).ToString("00"); // Update text box with formatting
        }

        private void txt4Chars_Click(object sender, EventArgs e) { // If a four char box is clicked, open a number pad, limited to 4 numbers
            TextBox tb = (TextBox)sender;

            frmNumPad frmNumPad = new frmNumPad(4);
            string getInput = frmNumPad.getInput(tb.Text);
            if (getInput.Length < 1) { // if input is empty, do not change time
                return;
            }
            tb.Text = Convert.ToInt32(getInput).ToString("0000"); // Update text box with formatting
        }
    }
}
