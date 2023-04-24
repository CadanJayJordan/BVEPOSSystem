using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CS3._0Project.Forms.Utility.Classes;

namespace CS3._0Project.Code.Utility.Forms {
    public partial class frmListBox : Form {

        private int listIndex;
        private string listName;
        public bool forceZeroPrice;
        public int returnItem;

        private List<int> listItemIDs = new List<int>();
        private List<int> displyedListItemIDs = new List<int>();

        public frmListBox() {
            InitializeComponent();
            new ControlDragger(this, true, false);
        }

        public void showList(int listItemID) {
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems); // DB Pull
            this.tblEPOSListItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSListItems);

            // Clear all lists and items
            lbxListDisplay.Items.Clear();
            displyedListItemIDs.Clear();
            lblName.Text = "";
            returnItem = -1;
            forceZeroPrice = false;

            this.listItemIDs = getListItemIDs(listItemID); // Get all items in this list
            this.listName = ePOSDBDataSet.tblEPOSListItems.Rows[listIndex][1].ToString(); // get the list name
            this.forceZeroPrice = Convert.ToBoolean(ePOSDBDataSet.tblEPOSListItems.Rows[listIndex][3]); // force zero price check

            lblName.Text = listName;

            foreach(int itemID in listItemIDs) {
                foreach (DataRow item in ePOSDBDataSet.tblEPOSItems.Rows) {
                    if (Convert.ToInt32(item[0]) == itemID) {
                        lbxListDisplay.Items.Add(item[1]);
                        displyedListItemIDs.Add(itemID);
                        break;
                    }
                }
            }

            this.ShowDialog();
        }

        private List<int> getListItemIDs(int listItemID) {
            listIndex = 0;
            for (int i = 0; i < ePOSDBDataSet.tblEPOSListItems.Rows.Count; i++) { // Get the list index
                if (Convert.ToInt32(ePOSDBDataSet.tblEPOSListItems.Rows[i][0]) == listItemID) {
                    listIndex = i;
                    break;
                }
            }
            string[] listItems = ePOSDBDataSet.tblEPOSListItems.Rows[listIndex][2].ToString().Split(','); // Split the string out of the database
            List<int> listItemIDs = new List<int>(); // new int list

            foreach(string itemID in listItems) { // For each item in the string[] convert it to an int and add to the int list
                if (itemID == "") {
                    continue;
                }
                listItemIDs.Add(Convert.ToInt32(itemID));
            }

            return listItemIDs; // Return the in list
        }

        private void btnCancel_Click(object sender, EventArgs e) { // Close on cancel
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e) { // Return item ID on ok
            if (lbxListDisplay.SelectedIndex == -1) {
                return;
            }
            returnItem = listItemIDs[lbxListDisplay.SelectedIndex];
            this.Hide();
        }

        
    }
}
