using CS3._0Project.Code.Utility.Classes;
using CS3._0Project.Code.Utility.Forms;
using CS3._0Project.Forms.Utility;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CS3._0Project.Code.Management {
    public partial class frmTableFloorEditing : Form {

        private Size screenSize;
        private int userID;
        private string username;

        private frmKeyboard keyboard = new frmKeyboard();
        private frmNumPad numPad = new frmNumPad(3);
        private DBTools DBTools = new DBTools();
        private frmMessageBox cMessageBox = new frmMessageBox();

        public frmTableFloorEditing(Size screenSize, int userID, string username) {
            InitializeComponent();
            this.screenSize = screenSize;
            this.userID = userID;
            this.username = username;
        }

        private void frmTableFloorEditing_Load(object sender, EventArgs e) {
            this.tblEPOSTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSTables);
            this.tblEPOSTableFloorsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSTableFloors);

            this.Location = new Point(0, 0);
            this.Size = screenSize;
            lblUsername.Text = username;

            fillListBox();
        }

        private void fillListBox() { // Draw floors onto screen
            lbTablesFloors.Items.Clear();

            foreach(DataRow floor in ePOSDBDataSet.tblEPOSTableFloors) {
                lbTablesFloors.Items.Add(floor[2] + ": " + floor[1]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e) { // Go back to previous form
            this.Close();
        }

        private void btnName_Click(object sender, EventArgs e) { // Update bane
            if (lbTablesFloors.SelectedIndex == -1) {
                return;
            }

            string newName = keyboard.getInput();
            if (newName == "") {
                return;
            }
            ePOSDBDataSet.tblEPOSTableFloors.Rows[lbTablesFloors.SelectedIndex][2] = newName.Trim();

            tblEPOSTableFloorsTableAdapter.Update(ePOSDBDataSet.tblEPOSTableFloors.Rows[lbTablesFloors.SelectedIndex]);

            tblEPOSTableFloorsTableAdapter.Fill(ePOSDBDataSet.tblEPOSTableFloors);
            fillListBox();
        }

        private void btnAdd_Click(object sender, EventArgs e) { // Add new floor
            DataRow newFloor = ePOSDBDataSet.tblEPOSTableFloors.NewRow();
            newFloor[1] = 0;
            newFloor[2] = "New Floor";

            ePOSDBDataSet.tblEPOSTableFloors.Rows.Add(newFloor);
            tblEPOSTableFloorsTableAdapter.Update(ePOSDBDataSet.tblEPOSTableFloors);

            tblEPOSTableFloorsTableAdapter.Fill(ePOSDBDataSet.tblEPOSTableFloors);
            fillListBox();
        }

        private void btnRemove_Click(object sender, EventArgs e) { // Remove floor (checking for any tables still on it)
            if (lbTablesFloors.SelectedIndex == -1) {
                return;
            }

            bool safeToRemove = true;
            string unsafeTables = "";

            int floorID = DBTools.getID(ePOSDBDataSet.tblEPOSTableFloors, lbTablesFloors.SelectedIndex);

            foreach(DataRow table in ePOSDBDataSet.tblEPOSTables) { // See if there are an tabkes on the floor
                if (Convert.ToInt32(table[2]) == floorID) {
                    unsafeTables += table[1] + ",";
                    safeToRemove = false;
                }
            }

            if (safeToRemove) { // If it is safe to remove the table, delete it
                ePOSDBDataSet.tblEPOSTableFloors.Rows[lbTablesFloors.SelectedIndex].Delete();
                tblEPOSTableFloorsTableAdapter.Update(ePOSDBDataSet.tblEPOSTableFloors);
                ePOSDBDataSet.tblEPOSTableFloors.AcceptChanges();
                fillListBox();
            } else { // If unsafe to remove, dont and show error
                unsafeTables = unsafeTables.Substring(0, unsafeTables.Length - 1);
                cMessageBox.ShowMessage("Please remove all tables before deleting the floor.\n\nPlease Remove the following tables: " + unsafeTables);
            }
        }

        private void btnLocation_Click(object sender, EventArgs e) { // Edit location weight
            if (lbTablesFloors.SelectedIndex == -1) {
                return;
            }

            string input = numPad.getInput();

            if (input == "") {
                return;
            }

            int newWeight = Convert.ToInt32(input);

            ePOSDBDataSet.tblEPOSTableFloors.Rows[lbTablesFloors.SelectedIndex][1] = newWeight;
            tblEPOSTableFloorsTableAdapter.Update(ePOSDBDataSet.tblEPOSTableFloors);

            tblEPOSTableFloorsTableAdapter.Fill(ePOSDBDataSet.tblEPOSTableFloors);
        }
    }
}
