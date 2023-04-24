using CS3._0Project.Code.Utility.Classes;
using CS3._0Project.Code.Utility.Forms;
using CS3._0Project.EPOSDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CS3._0Project.Code.Management {
    public partial class frmListItemEditing : Form {

        private Size screenSize;
        private int userID;
        private string username;

        private int selectedIndex;

        private DBTools DBTools = new DBTools();
        private frmMessageBox frmMessageBox = new frmMessageBox();

        public frmListItemEditing(Size screenSize, int userID, string username) {
            InitializeComponent();
            this.screenSize = screenSize;
            this.userID = userID;
            this.username = username;
        }

        private void frmListItemEditing_Load(object sender, EventArgs e) { // frm load
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);
            this.tblEPOSListItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSListItems);

            this.Location = new Point(0, 0);
            this.Size = screenSize;
            lblUsername.Text = username;

            // Fill initial boxes
            fillListItemLb();
            fillItemComboBox();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void fillListItemLb() { // get all list items in the main list
            lbLists.Items.Clear();

            foreach (DataRow list in ePOSDBDataSet.tblEPOSListItems) {
                lbLists.Items.Add(list[1]);
            }
        }

        private void fillItemLB(int selectedIndex) { // Fill combo box
            lbListItems.Items.Clear();
            string listItemsS = ePOSDBDataSet.tblEPOSListItems.Rows[selectedIndex][2].ToString();
            string[] listItems = listItemsS.Split(',');

            foreach (string itemID in listItems) {
                if (itemID == "") { // Error catch for blank items
                    continue;
                }
                lbListItems.Items.Add(DBTools.getItemName(ePOSDBDataSet.tblEPOSItems, Convert.ToInt32(itemID)));
            }
        }

        private void fillItemComboBox() { // Fill cbx with all items
            cbxItemList.Items.Clear();
            foreach(DataRow item in ePOSDBDataSet.tblEPOSItems) {
                cbxItemList.Items.Add(item[1]);
            }
            cbxItemList.SelectedIndex = 0;
        }

        private void updateForm(int selectedIndex) { // Update the form when a new item is selected
            fillItemLB(selectedIndex);
            cbZeroPrice.Checked = Convert.ToBoolean(ePOSDBDataSet.tblEPOSListItems[selectedIndex][3]);
            txtName.Text = ePOSDBDataSet.tblEPOSListItems[selectedIndex][1].ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e) { // Removeing a list
            if (selectedIndex == -1) {
                return;
            }

            bool safeToDelete = true;
            string errorMessage = "Cannot delete when items are still using this list\nRemove the following items lists: ";

            DataRow deletionList = ePOSDBDataSet.tblEPOSListItems[selectedIndex]; // Checking if there are still items attached to this list, if so we cannot delte
            foreach(DataRow item in ePOSDBDataSet.tblEPOSItems) {
                if (Convert.ToInt32(item[14]) == Convert.ToInt32(deletionList[0])) {
                    safeToDelete = false;
                    errorMessage += item[1] + ",";
                }
            }

            if (!safeToDelete) { // If it is not safe to delete, show message and return
                frmMessageBox.ShowMessage(errorMessage.Substring(0, errorMessage.Length - 1));
                return;
            }

            // If okay to delete, go ahead
            ePOSDBDataSet.tblEPOSListItems[selectedIndex].Delete();
            tblEPOSListItemsTableAdapter.Update(ePOSDBDataSet.tblEPOSListItems);
            ePOSDBDataSet.tblEPOSListItems.AcceptChanges();

        }

        private void btnAdd_Click(object sender, EventArgs e) { // Adding a list
            // Create a new row with the minimum properties
            DataRow newListRow = ePOSDBDataSet.tblEPOSListItems.NewRow();
            newListRow[1] = "New List";
            newListRow[2] = "";
            newListRow[3] = false;

            ePOSDBDataSet.tblEPOSListItems.Rows.Add(newListRow); // Add row to datatable
            tblEPOSListItemsTableAdapter.Update(ePOSDBDataSet.tblEPOSListItems); // Update DB

            tblEPOSListItemsTableAdapter.Fill(ePOSDBDataSet.tblEPOSListItems);

        }

        private void btnItemAdd_Click(object sender, EventArgs e) { // Adding a list item
            if (cbxItemList.SelectedIndex == -1) {
                return;
            }
            string listItemsS = ePOSDBDataSet.tblEPOSListItems.Rows[selectedIndex][2].ToString(); // Get list string

            int selectedItemID = DBTools.getID(ePOSDBDataSet.tblEPOSItems, cbxItemList.SelectedIndex); // New item ID

            if (listItemsS == "") { // Add to list string
                listItemsS += selectedItemID; 
            } else {
                listItemsS += "," + selectedItemID; 
            }

            // Update DB
            ePOSDBDataSet.tblEPOSListItems.Rows[selectedIndex][2] = listItemsS;
            tblEPOSListItemsTableAdapter.Update(ePOSDBDataSet.tblEPOSListItems.Rows[selectedIndex]);

            tblEPOSListItemsTableAdapter.Fill(ePOSDBDataSet.tblEPOSListItems);
            updateForm(selectedIndex);
        }

        private void btnItemRemove_Click(object sender, EventArgs e) { // Removing a list item
            if (lbListItems.SelectedIndex == -1) {
                return;
            }
            string listItemsS = ePOSDBDataSet.tblEPOSListItems.Rows[selectedIndex][2].ToString(); // Get list string
            List<string> listItems = listItemsS.Split(',').ToList(); // Turn it into an iterable state

            listItems.RemoveAt(lbListItems.SelectedIndex); // remove wanted item

            listItemsS = "";
            foreach(string listItem in listItems) { // create new string
                listItemsS += listItem + ",";
            }
            listItemsS = listItemsS.Substring(0, listItemsS.Length - 1);

            // update DB
            ePOSDBDataSet.tblEPOSListItems.Rows[selectedIndex][2] = listItemsS;
            tblEPOSListItemsTableAdapter.Update(ePOSDBDataSet.tblEPOSListItems.Rows[selectedIndex]);

            tblEPOSListItemsTableAdapter.Fill(ePOSDBDataSet.tblEPOSListItems);
            updateForm(selectedIndex);

        }

        private void lbLists_SelectedIndexChanged(object sender, EventArgs e) { // If main item is changed
            if (lbLists.SelectedIndex == -1) {
                return;
            }
            selectedIndex = lbLists.SelectedIndex;
            updateForm(selectedIndex);
        }

        private void txtName_Click(object sender, EventArgs e) { // If text name needs to be inputted
            TextBox tb = (TextBox)sender;

            frmKeyboard frmKeyboard = new frmKeyboard(); // Open keyboard and get input
            string newText = frmKeyboard.getInput(tb.Text);

            bool isDataValid = true; // data validation
            string errorMessage = "";

            if (newText.Length > 254) {
                isDataValid = false;
                errorMessage += "Name: Too long, please limit to 254 characters\n";
            }
            if (newText.Length == 0) {
                isDataValid = false;
                errorMessage += "Name: Cannot be empty\n";
            }

            if (!isDataValid) { // report if data is not valid
                frmMessageBox.ShowMessage(errorMessage);
            }

            
            tb.Text = newText;
            // Update form elements
            ePOSDBDataSet.tblEPOSListItems.Rows[selectedIndex][1] = newText;
            tblEPOSListItemsTableAdapter.Update(ePOSDBDataSet.tblEPOSListItems.Rows[selectedIndex]);

            tblEPOSListItemsTableAdapter.Fill(ePOSDBDataSet.tblEPOSListItems);
            fillListItemLb();

        }

        private void cbZeroPrice_CheckedChanged(object sender, EventArgs e) { // update DB on checkbox change
            ePOSDBDataSet.tblEPOSListItems.Rows[selectedIndex][3] = cbZeroPrice.Checked;
            tblEPOSListItemsTableAdapter.Update(ePOSDBDataSet.tblEPOSListItems.Rows[selectedIndex]);

            tblEPOSListItemsTableAdapter.Fill(ePOSDBDataSet.tblEPOSListItems);
        }
    }
}
