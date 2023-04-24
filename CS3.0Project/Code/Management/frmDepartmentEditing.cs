using CS3._0Project.Code.Utility.Classes;
using CS3._0Project.Code.Utility.Forms;
using CS3._0Project.EPOSDBDataSetTableAdapters;
using CS3._0Project.Forms.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3._0Project.Code.Management {
    public partial class frmDepartmentEditing : Form {

        private Size screenSize;
        private int userID;
        private string username;

        private frmKeyboard keyboard = new frmKeyboard();
        private DBTools DBTools = new DBTools();
        private frmMessageBox cMessageBox = new frmMessageBox();

        public frmDepartmentEditing(Size screenSize, int userID, string username) {
            InitializeComponent();
            this.screenSize = screenSize;
            this.userID = userID;
            this.username = username;
        }


        private void frmDepartmentEditing_Load(object sender, EventArgs e) {
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);
            this.tblEPOSDepartmentsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSDepartments);

            this.Location = new Point(0, 0);
            this.Size = screenSize;
            lblUsername.Text = username;

            fillListBox();
        }

        private void fillListBox() { // Draw departmetns onto screen
            lbDepartments.Items.Clear();

            foreach (DataRow floor in ePOSDBDataSet.tblEPOSDepartments) {
                lbDepartments.Items.Add(floor[1]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e) { // Close this form
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) { // Add department
            DataRow newDepartment = ePOSDBDataSet.tblEPOSDepartments.NewRow();
            newDepartment[1] = "New Department";

            ePOSDBDataSet.tblEPOSDepartments.Rows.Add(newDepartment);
            tblEPOSDepartmentsTableAdapter.Update(ePOSDBDataSet.tblEPOSDepartments);

            tblEPOSDepartmentsTableAdapter.Fill(ePOSDBDataSet.tblEPOSDepartments);
            fillListBox();
        }

        private void btnRemove_Click(object sender, EventArgs e) { // Remove department (checking for items in them)
            if (lbDepartments.SelectedIndex == -1) {
                return;
            }

            bool safeToRemove = true;
            string unsafeItems = "";

            int departmentID = DBTools.getID(ePOSDBDataSet.tblEPOSDepartments, lbDepartments.SelectedIndex);

            foreach (DataRow item in ePOSDBDataSet.tblEPOSItems) { // See if there are an items in the department
                if (Convert.ToInt32(item[2]) == departmentID) {
                    unsafeItems += item[1] + ",";
                    safeToRemove = false;
                }
            }

            if (safeToRemove) { // If it is safe to remove the department, delete it
                ePOSDBDataSet.tblEPOSDepartments.Rows[lbDepartments.SelectedIndex].Delete();
                tblEPOSDepartmentsTableAdapter.Update(ePOSDBDataSet.tblEPOSDepartments);
                ePOSDBDataSet.tblEPOSDepartments.AcceptChanges();
                fillListBox();
            } else { // If unsafe to remove, dont and show error
                unsafeItems = unsafeItems.Substring(0, unsafeItems.Length - 1);
                cMessageBox.ShowMessage("Please remove all items before deleting the department.\n\nPlease remove the following items: " + unsafeItems);
            }
        }

        private void btnName_Click(object sender, EventArgs e) { // Edit department name
            if (lbDepartments.SelectedIndex == -1) {
                return;
            }

            string newName = keyboard.getInput();
            if (newName == "") {
                return;
            }

            ePOSDBDataSet.tblEPOSDepartments.Rows[lbDepartments.SelectedIndex][1] = newName.Trim();

            tblEPOSDepartmentsTableAdapter.Update(ePOSDBDataSet.tblEPOSDepartments.Rows[lbDepartments.SelectedIndex]);

            tblEPOSDepartmentsTableAdapter.Fill(ePOSDBDataSet.tblEPOSDepartments);
            fillListBox();
        }
    }
}
