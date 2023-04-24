using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CS3._0Project.Code.Utility.Classes;
using CS3._0Project.Code.Utility.Forms;
using CS3._0Project.Forms.Utility;

namespace CS3._0Project.Code.Management {
    public partial class frmItemEditing : Form {

        private int userID;
        private string username;
        private int itemIndex = -1;

        private List<int> itemParentFolderIndexsT = new List<int>();
        private List<int> itemParentFolderLocationsT = new List<int>();

        private DBTools DBTools = new DBTools();
        private frmKeyboard keyboard = new frmKeyboard();
        private frmNumPad numpad = new frmNumPad();
        private frmMessageBox message = new frmMessageBox();

        public frmItemEditing(Size screenSize, int userID, string username) { // Form init
            InitializeComponent();
            this.Size = screenSize;
            this.userID = userID;
            this.username = username;
            this.Location = new Point(0, 0);
        }

        private void btnClose_Click(object sender, EventArgs e) { // Close Button Event
            if (!isDataValid()) { // Check if all the inputs are not going to break the system
                return;
            }
            updateDB();
            this.Close();
        }

        private void frmItemEditing_Load(object sender, EventArgs e) {
            // Load form
            formLoad();
            lblUsername.Text = username;
        }

        private void formLoad() { // Form load
            // Fill DB
            this.tblEPOSDepartmentsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSDepartments);
            this.tblEPOSItemFoldersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemFolders);
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);
            this.tblEPOSItemPriceTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemPrice);
            this.tblEPOSListItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSListItems);

            fillCombo(); // Fill the CBX
            cbxDepartment.SelectedIndex = -1;
        }

        private void fillCombo() { // Fill the CBX with Item (ItemID)
            cbxItems.Items.Clear(); // Clear cbx

            foreach (DataRow item in ePOSDBDataSet.tblEPOSItems.Rows) { // For every item in the items table
                String itemFormatted = String.Format("{0} ({1})", item[1].ToString(), Convert.ToInt32(item[0]).ToString("0000")); // Format the item string
                cbxItems.Items.Add(itemFormatted); // Add to the CBX
            }
        }

        private void updateForm(int itemRowIndex) { // If the selected item is changed, update form
            tblEPOSItemsTableAdapter.Fill(ePOSDBDataSet.tblEPOSItems);
            tblEPOSItemPriceTableAdapter.Fill(ePOSDBDataSet.tblEPOSItemPrice);

            // Get relevent rows to this object
            DataRow item = ePOSDBDataSet.tblEPOSItems.Rows[itemRowIndex];
            DataRow itemPrice = ePOSDBDataSet.tblEPOSItemPrice.Rows[DBTools.getPriceIndex(ePOSDBDataSet.tblEPOSItemPrice, Convert.ToInt32(item[0]))];

            fillCombo();
            updateItemBoxes(item, itemPrice);
        }

        private void updateItemBoxes(DataRow item, DataRow itemPrice) { // Update all properties when you select a new item
            int itemID = Convert.ToInt32(item[0]);

            // Item Details
            lblItemID.Text = String.Format("Item ID: {0}", itemID.ToString("0000"));
            txtName.Text = item[1].ToString();
            cbxDepartment.SelectedValue = Convert.ToInt32(item[2]);
            updateItemParentFolderList(itemID); // item[3] and item[4]
            cbAllowZeroPrice.Checked = Convert.ToBoolean(item[5]);
            cbPrintBar.Checked = false;
            cbPrintKitchen.Checked = false;
            string printerString = item[6].ToString();
            if (printerString != "") {
                string[] printers = printerString.Split(';');
                if (printers.Contains("Bar")) {
                    cbPrintBar.Checked = true;
                }
                if (printers.Contains("Kitchen")) {
                    cbPrintKitchen.Checked = true;
                }
            }
            cbPrintRed.Checked = Convert.ToBoolean(item[7]);
            txtQuantityAlt1.Text = Math.Truncate((Convert.ToDouble(item[8]) * 100)).ToString();
            txtQuantityAlt2.Text = Math.Truncate((Convert.ToDouble(item[9]) * 100)).ToString();
            txtQuantityAlt3.Text = Math.Truncate((Convert.ToDouble(item[10]) * 100)).ToString();
            txtTextAlt1.Text = item[11].ToString();
            txtTextAlt2.Text = item[12].ToString();
            txtTextAlt3.Text = item[13].ToString();
            cbxItemFolder.SelectedValue = Convert.ToInt32(item[14]);
            cbIsListItem.Checked = Convert.ToBoolean(item[15]);

            // Price Details
            txtBasePrice.Text = Math.Truncate((Convert.ToDecimal(itemPrice[2]) * 100m)).ToString();
            txtPriceAlt1.Text = Math.Truncate((Convert.ToDecimal(itemPrice[3]) * 100m)).ToString();
            txtPriceAlt2.Text = Math.Truncate((Convert.ToDecimal(itemPrice[4]) * 100m)).ToString();
            txtPriceAlt3.Text = Math.Truncate((Convert.ToDecimal(itemPrice[5]) * 100m)).ToString();

            //Item Preview
            btnItemPreview.Text = item[1].ToString();
            btnItemPreview.BackColor = Color.FromArgb(Convert.ToInt32(item[16]));
            btnItemPreview.ForeColor = Color.FromArgb(Convert.ToInt32(item[17]));

        }

        private void updateItemParentFolderList(int itemID) { // Update the parents list
            lbxParentFolders.Items.Clear(); // Clear all lists
            itemParentFolderIndexsT.Clear();
            itemParentFolderLocationsT.Clear();

            // Get indexs and locations from DB
            List<int> itemParentFolderIndexs = DBTools.getItemParentFolderIndexs(ePOSDBDataSet.tblEPOSItems, ePOSDBDataSet.tblEPOSItemFolders, itemID);
            List<int> itemFolderLocations = DBTools.getItemFolderLocations(ePOSDBDataSet.tblEPOSItems, itemID);

            string folderName = ""; // final folder name

            for (int i = 0; i < itemParentFolderIndexs.Count; i++) { // For all aprent folders
                int itemParentFolderIndex = itemParentFolderIndexs[i]; // Get the current index
                int itemParentFolderLocation = itemFolderLocations[i]; // Get the current location
                itemParentFolderIndexsT.Add(itemParentFolderIndex); // Keep an index copy so we can edit it
                itemParentFolderLocationsT.Add(itemParentFolderLocation); // Keep a location copy so we can edit it

                if (itemParentFolderIndex == -2) { // No folder
                    continue;
                }

                if (itemParentFolderIndex == -1) { // Root Folder
                    folderName = "Root";
                    lbxParentFolders.Items.Add(String.Format("{0}: {1}", folderName, itemParentFolderLocation));
                    continue;
                }
                // Any other folder
                DataRow itemParentFolderRow = ePOSDBDataSet.tblEPOSItemFolders[itemParentFolderIndex];
                folderName = itemParentFolderRow[1].ToString();
                lbxParentFolders.Items.Add(String.Format("{0}: {1}", folderName, itemParentFolderLocation));
            }
        }

        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e) { // On item change
            if (itemIndex != -1) {
                if (!isDataValid()) { // Check if all the inputs are not going to break the system
                    cbxItems.SelectedIndex = itemIndex;
                    return;
                }
                updateDB(); // Update the DB if it is an item
            }
            itemIndex = cbxItems.SelectedIndex; // Get selecteditem index
            if (itemIndex > -1) {
                updateForm(itemIndex); // Update form 
            }
        }

        private void OnTextBoxClick(object sender, EventArgs e) { // On click event to show keyboard
            TextBox tb = (TextBox)sender;
            string input = keyboard.getInput(tb.Text);
            if (input == "") {
                return;
            }
            tb.Text = input;
        }

        private void OnNumBoxClick(object sender, EventArgs e){ // On click event to show numberpad
            TextBox tb = (TextBox)sender;
            string input = numpad.getInput(tb.Text);
            if (input == "") {
                return;
            }
            tb.Text = input;
        }

        private void btnParentAdd_Click(object sender, EventArgs e) { // Add Folders
            if (!isDataValid()) { // On update if all curent info is valid
                return;
            }
            updateDB(); // Update DB to sotp wieredness 
            // Open New Add Dialog
            frmItemParentAddDialog frmItemParentAddDialog = new frmItemParentAddDialog(ePOSDBDataSet.tblEPOSItemFolders, itemIndex, itemParentFolderIndexsT);
            frmItemParentAddDialog.ShowDialog();
            List<int> newParentFolderIndexs = frmItemParentAddDialog.getParentFolderIndexs();
            frmItemParentAddDialog.Close();
            // Get new parent folders
            itemParentFolderIndexsT = newParentFolderIndexs;
            itemParentFolderLocationsT.Clear(); // Create new loactions
            string itemLocationString = "";
            foreach (int itemParentIndex in itemParentFolderIndexsT) { // Transpose into correct numbers
                if (itemParentIndex == -2) {
                    itemLocationString += "-1,";
                } else {
                    itemLocationString += "0,";
                }
            }
            itemLocationString = itemLocationString.Substring(0, itemLocationString.Length - 1); // Remove trailing comma
            // Update DB Row
            DataRow itemDataRow = ePOSDBDataSet.tblEPOSItems.Rows[itemIndex];
            itemDataRow[3] = itemParentFolderDBString(itemParentFolderIndexsT);
            itemDataRow[4] = itemLocationString;
            tblEPOSItemsTableAdapter.Update(itemDataRow);
            // Pull information back from DB
            updateItemParentFolderList(DBTools.getID(ePOSDBDataSet.tblEPOSItems, itemIndex));
        }

        private void btnParentRemove_Click(object sender, EventArgs e) { // Remove a parent 
            int removeIndex = lbxParentFolders.SelectedIndex;
            if (removeIndex < 0) {
                return;
            }
            if (lbxParentFolders.Items.Count == 1) { // If this is going to leave an empty list, clear it to ensure all the items get put in the DB correctly
                btnParentClear_Click(sender, e);
                return;
            }
            lbxParentFolders.Items.RemoveAt(removeIndex);
            itemParentFolderIndexsT.RemoveAt(removeIndex);
            itemParentFolderLocationsT.RemoveAt(removeIndex);

        }

        private void btnParentClear_Click(object sender, EventArgs e) {
            itemParentFolderIndexsT.Clear();
            itemParentFolderIndexsT.Add(-2); // No Folder
            itemParentFolderLocationsT.Clear();
            itemParentFolderLocationsT.Add(-1); // No Item
            lbxParentFolders.Items.Clear();
        }

        private void btnParentEditWeight_Click(object sender, EventArgs e) { // Update the location weight (in lbx and db strings)
            int selectedIndex = lbxParentFolders.SelectedIndex; // get selected index
            if (selectedIndex == -1) {
                return; // return if no selection
            }

            string rawInput = numpad.getInput(); // get input
            if (rawInput == "") { // ensure it is not empty
                return;
            }
            int weightInput = Convert.ToInt32(rawInput);  // get input as integer
            itemParentFolderLocationsT[selectedIndex] = weightInput; // Update Backend

            int parentFolderIndex = itemParentFolderIndexsT[selectedIndex]; // Update display (only editing the changed row)
            String parentFolderString = "";
            if (parentFolderIndex == -1) { // If its the root folder
                parentFolderString = String.Format("{0}: {1}", "Root", weightInput.ToString());
            } else { // If its any other folder
                parentFolderString = String.Format("{0}: {1}", ePOSDBDataSet.tblEPOSItemFolders.Rows[parentFolderIndex][1].ToString(), weightInput.ToString());
            }
            lbxParentFolders.Items[selectedIndex] = parentFolderString; // Replace string in the lbx
        }

        private void updateDB() { // Push changes to the DB


            if (itemIndex == -1) { //Unless no item has been edited
                return;
            }

            DataRow item = ePOSDBDataSet.tblEPOSItems.Rows[itemIndex];
            DataRow itemPrice = ePOSDBDataSet.tblEPOSItemPrice.Rows[DBTools.getPriceIndex(ePOSDBDataSet.tblEPOSItemPrice, Convert.ToInt32(item[0]))];

            // Insert into item table
            item[1] = txtName.Text;
            item[2] = getComboVal(cbxDepartment);
            item[3] = itemParentFolderDBString(itemParentFolderIndexsT);
            item[4] = itemParentLocationDBString(itemParentFolderLocationsT);
            item[5] = cbAllowZeroPrice.Checked;
            string printerString = "";
            if (cbPrintBar.Checked) {
                printerString += "Bar;";
            }
            if (cbPrintKitchen.Checked) {
                printerString += "Kitchen;";
            }
            if (printerString.Length > 0) {
                printerString = printerString.Substring(0, printerString.Length - 1);
            }
            item[6] = printerString;
            item[7] = cbPrintRed.Checked;
            item[8] = Convert.ToDecimal(txtQuantityAlt1.Text) / 100m;
            item[9] = Convert.ToDecimal(txtQuantityAlt2.Text) / 100m;
            item[10] = Convert.ToDecimal(txtQuantityAlt3.Text) / 100m;
            item[11] = txtTextAlt1.Text;
            item[12] = txtTextAlt2.Text;
            item[13] = txtTextAlt3.Text;
            item[14] = getComboVal(cbxItemFolder);
            item[15] = cbIsListItem.Checked;
            item[16] = btnItemPreview.BackColor.ToArgb();
            item[17] = btnItemPreview.ForeColor.ToArgb();

            // Insert into price table
            itemPrice[2] = Convert.ToDecimal(txtBasePrice.Text) / 100m;
            itemPrice[3] = Convert.ToDecimal(txtPriceAlt1.Text) / 100m;
            itemPrice[4] = Convert.ToDecimal(txtPriceAlt2.Text) / 100m;
            itemPrice[5] = Convert.ToDecimal(txtPriceAlt3.Text) / 100m;

            // Update DB
            tblEPOSItemsTableAdapter.Update(item);
            tblEPOSItemPriceTableAdapter.Update(itemPrice);
        }

        private bool isDataValid() {
            bool isDataValid = true; // It is valid unless proven overwise
            string errorMessage = "";

            if (cbxItems.SelectedIndex == -1) { // If no item is selected, return true
                return true;
            }

            if(txtName.Text.Length <= 0) { // Name box
                isDataValid = false;
                errorMessage += "Cannot have an empty name\n";
            }

            if (cbxDepartment.SelectedIndex == -1) { // Deperatment selected index
                isDataValid = false;
                errorMessage += "Must have a selected department\n";
            }

            // (Quantity) If empty make it 0
            if (txtQuantityAlt1.Text.Length <= 0) {
                txtQuantityAlt1.Text = "0";
            }
            if (txtQuantityAlt2.Text.Length <= 0) {
                txtQuantityAlt2.Text = "0";
            }
            if (txtQuantityAlt3.Text.Length <= 0) {
                txtQuantityAlt3.Text = "0";
            }

            // (Prices) If empty make it 0
            if (txtBasePrice.Text.Length <= 0) {
                txtBasePrice.Text = "0";
            }
            if (txtPriceAlt1.Text.Length <= 0) {
                txtPriceAlt1.Text = "0";
            }
            if (txtPriceAlt2.Text.Length <= 0) {
                txtPriceAlt2.Text = "0";
            }
            if (txtPriceAlt3.Text.Length <= 0) {
                txtPriceAlt3.Text = "0";
            }

            try { // Ensurning numbers are valid
                // try conversion
                Convert.ToDecimal(txtBasePrice.Text);
                Convert.ToDecimal(txtPriceAlt1.Text);
                Convert.ToDecimal(txtPriceAlt2.Text);
                Convert.ToDecimal(txtPriceAlt3.Text);
                Convert.ToDecimal(txtQuantityAlt1.Text);
                Convert.ToDecimal(txtQuantityAlt2.Text);
                Convert.ToDecimal(txtQuantityAlt3.Text);
            } catch { // If conversion fails (very unlikely due to restricted input)
                isDataValid = false;
                errorMessage += "Invalid price(s)/Quantities. Use intergers in pence\n";
            }

            bool allowZeroPrice = cbAllowZeroPrice.Checked;
            if (!allowZeroPrice) { // If zero prices are not allowed
                if (Convert.ToDecimal(txtBasePrice.Text) == 0) { // and base price is 0
                    isDataValid = false;
                    errorMessage += "Base Price: Cannot be zero with current settings\n";
                }
                if (Convert.ToDecimal(txtPriceAlt1.Text) == 0 && Convert.ToDecimal(txtQuantityAlt1.Text) != 0) { // or if any alt price is 0, but only complain if the qauntity is not zero (alt is in use)
                    isDataValid = false;
                    errorMessage += "Alt Price 1: Cannot be zero with current settings\n";
                }
                if (Convert.ToDecimal(txtPriceAlt2.Text) == 0 && Convert.ToDecimal(txtQuantityAlt2.Text) != 0) {
                    isDataValid = false;
                    errorMessage += "Alt Price 2: Cannot be zero with current settings\n";
                }
                if (Convert.ToDecimal(txtPriceAlt3.Text) == 0 && Convert.ToDecimal(txtQuantityAlt3.Text) != 0) {
                    isDataValid = false;
                    errorMessage += "Alt Price 3: Cannot be zero with current settings\n";
                }
            }

            // Length Checks (Too long)
            if(txtName.Text.Length > 254) {
                isDataValid = false;
                errorMessage += "Name: Too long, please limit to 254 characters\n";
            }
            if (txtTextAlt1.Text.Length > 254) {
                isDataValid = false;
                errorMessage += "Alt 1 Text: Too long, please limit to 254 characters\n";
            }
            if (txtTextAlt2.Text.Length > 254) {
                isDataValid = false;
                errorMessage += "Alt 2 Text: Too long, please limit to 254 characters\n";
            }
            if (txtTextAlt3.Text.Length > 254) {
                isDataValid = false;
                errorMessage += "Alt 3 Text: Too long, please limit to 254 characters\n";
            }

            if (!isDataValid) {
                message.ShowMessage(errorMessage);
            }
            return isDataValid;
        }

        private int getComboVal(ComboBox cbx) {
            if (cbx.SelectedIndex == -1) {
                return 0;
            }

            return Convert.ToInt32(cbx.SelectedValue);
        }


        private string itemParentFolderDBString(List<int> itemParentFolderIndexs) { // Gets the DB String for the itemParentFolders
            List<int> itemParentFolderIDs = new List<int>();
            foreach (int parentFolderIndex in itemParentFolderIndexs) { // For all parent folder index
                if (parentFolderIndex == -2) { // No folder
                    itemParentFolderIDs.Add(-1);
                    continue;
                }
                if (parentFolderIndex == -1) { // Root Folder
                    itemParentFolderIDs.Add(0);
                    continue;
                }

                itemParentFolderIDs.Add(DBTools.getID(ePOSDBDataSet.tblEPOSItemFolders, parentFolderIndex)); // Any other folder
            }
            String itemParentFolderDBString = ""; // New String
            foreach (int itemParentFolderID in itemParentFolderIDs) { // For all IDs, get and store  in comma seperated list
                itemParentFolderDBString += itemParentFolderID.ToString() + ",";
            }
            
            return itemParentFolderDBString.Substring(0, itemParentFolderDBString.Length - 1); // return the string minus the final comma
        }

        private string itemParentLocationDBString(List<int> itemParentLocations) { // Gets the DB string for the item Parent Locations
            String itemParentLocationDBString = "";
            foreach (int itemParentLocation in itemParentLocations) { // For all locations, insert into string
                itemParentLocationDBString += itemParentLocation.ToString() + ",";
            }
            return itemParentLocationDBString.Substring(0, itemParentLocationDBString.Length - 1); // return the string minus the final comma
        } 

        private Color getColour() {
            ColorDialog cdlg = new ColorDialog(); // Open a new color diaglog
            cdlg.AnyColor = true;
            cdlg.ShowDialog(); // Show
            Color newColour = cdlg.Color; // Get colour
            return newColour; // return the newly selected colour
        }

        private void btnChangeBackColour_Click(object sender, EventArgs e) {// Update Back Colour
            btnItemPreview.BackColor = getColour();
        }

        private void btnUpdateFrontColour_Click(object sender, EventArgs e) { // Update Front Colour
            btnItemPreview.ForeColor = getColour();
        }

        private void btnAddItem_Click(object sender, EventArgs e) { // Add new item
            // Create a new row with the minimum properties
            DataRow newItemRow = ePOSDBDataSet.tblEPOSItems.NewRow();
            newItemRow[1] = "New Item";
            newItemRow[2] = 1;
            newItemRow[3] = -1;
            newItemRow[4] = -1;
            newItemRow[5] = false;
            newItemRow[6] = "Bar";
            newItemRow[7] = false;
            newItemRow[8] = 0.0d; 
            newItemRow[9] = 0.0d;
            newItemRow[10] = 0.0d;
            newItemRow[11] = "";
            newItemRow[12] = "";
            newItemRow[13] = "";
            newItemRow[14] = 0;
            newItemRow[15] = false;
            newItemRow[16] = 0;
            newItemRow[17] = 0;

            ePOSDBDataSet.tblEPOSItems.Rows.Add(newItemRow); // Add row to datatable
            tblEPOSItemsTableAdapter.Update(ePOSDBDataSet.tblEPOSItems); // Update DB

            tblEPOSItemsTableAdapter.Fill(ePOSDBDataSet.tblEPOSItems);

            // Create an item price row with minimum properties
            DataRow newItemPiceRow = ePOSDBDataSet.tblEPOSItemPrice.NewRow();
            newItemPiceRow[1] = ePOSDBDataSet.tblEPOSItems.Rows[ePOSDBDataSet.tblEPOSItems.Rows.Count - 1][0];
            newItemPiceRow[2] = 0.0d;
            newItemPiceRow[3] = 0.0d;
            newItemPiceRow[4] = 0.0d;
            newItemPiceRow[5] = 0.0d;
            ePOSDBDataSet.tblEPOSItemPrice.Rows.Add(newItemPiceRow); // Add to datatalble

            // Update DB
            tblEPOSItemPriceTableAdapter.Update(ePOSDBDataSet.tblEPOSItemPrice);
            tblEPOSItemsTableAdapter.Fill(ePOSDBDataSet.tblEPOSItems);


            fillCombo(); // Fill item combo
            cbxItems.SelectedIndex = ePOSDBDataSet.tblEPOSItems.Rows.Count - 1; // Select new item
        }

        private void btnRemoveItem_Click(object sender, EventArgs e) {
            if (itemIndex == -1){ // no Item is selected, return
                return;
            }
            // Get item ID TO find its price 
            int itemID = DBTools.getID(ePOSDBDataSet.tblEPOSItems, itemIndex);
            int itemPriceIndex = DBTools.getPriceIndex(ePOSDBDataSet.tblEPOSItemPrice, itemID);

            // Delete item & price
            ePOSDBDataSet.tblEPOSItems.Rows[itemIndex].Delete();
            ePOSDBDataSet.tblEPOSItemPrice.Rows[itemPriceIndex].Delete();

            // Update item & price tables
            tblEPOSItemsTableAdapter.Update(ePOSDBDataSet.tblEPOSItems);
            tblEPOSItemPriceTableAdapter.Update(ePOSDBDataSet.tblEPOSItemPrice);

            // Accept the deletion on the DB
            ePOSDBDataSet.tblEPOSItems.AcceptChanges();
            ePOSDBDataSet.tblEPOSItemPrice.AcceptChanges();

            itemIndex = -1;
            fillCombo();
            cbxItems.SelectedIndex = -1;
        }

        private void btnClearListItem_Click(object sender, EventArgs e) {
            cbxItemFolder.SelectedIndex = -1;
        }
    }
}
