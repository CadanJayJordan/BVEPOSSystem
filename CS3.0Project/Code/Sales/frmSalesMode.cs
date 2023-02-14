using CS3._0Project.Code.Utility.Forms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CS3._0Project.Code.Table;
using CS3._0Project.Code.Utility.Classes;

namespace CS3._0Project.Code.Sales {
    public partial class frmSalesMode : Form {

        // TODO: Hide vertical scrollbar in list box (create custom listbox item)

        private Size screenSize;
        private int userID;

        private bool isRefundMode; // TODO: Make refun mode work        

        // FOR ITEM DISPLAY AND CALC
        private List<int> tillSelectedItems = new List<int>();
        private List<int> tillSelectedQuantity = new List<int>();
        private List<int> tillSelectedAlts = new List<int>();
        private decimal tillTotal = 0.0m;
        private decimal chequeDeductions = 0.0m;
        private decimal cashAmount = 0.0m;
        private bool isListBoxLocked = false;
        private bool usingCustomAmount = false;

        // FOR TABLE OPENING
        private int openTableID = -1;

        private frmMessageBox cMessageBox = new frmMessageBox(); // Custom message box
        private ItemDisplayGenerator itemDisplayGenerator;
        private frmListBox listItemBox = new frmListBox();

        // TODO: Modernise all form design

        // BIG TODO: Reservation System and storage
        // BIG TODO: alt amounts on items
        // BIG TODO: Lists and item selection from a list
        public frmSalesMode(Size size, int userID, bool isRefundMode) {
            InitializeComponent();
            this.screenSize = size;
            this.userID = userID;
            this.isRefundMode = isRefundMode;
        }

        private void frmSalesMode_Shown(object sender, EventArgs e) {
            this.Size = screenSize;
        }

        private void btnHome_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmSalesMode_Load(object sender, EventArgs e) {
            // Fill DB Tables On Load
            this.tblEPOSCashChequesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSCashCheques);
            this.tblEPOSItemPriceTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemPrice);
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);
            this.tblEPOSItemFoldersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemFolders);
            tblEPOSOpenTablesTableAdapter.Fill(ePOSDBDataSet.tblEPOSOpenTables);


            itemDisplayGenerator = new ItemDisplayGenerator(this, ePOSDBDataSet.tblEPOSItems, ePOSDBDataSet.tblEPOSItemFolders, pnlItemDisplay);

            itemDisplayGenerator.createButtons();
            AllowButtonClick(pnlTillDisplay);

            //TODO: FUNCTION
            tbxTillDisplay.Clear();
            lbxTillDisplay.Items.Clear();
            tbxTillTotal.Clear();
        }

 
        private void btnFolderBack_Click(object sender, EventArgs e) {
            itemDisplayGenerator.folderBack();
        }
        
        public void DynamicItemButton_Click(object sender, EventArgs e) { // If a button is clicked
            Button button = (Button)sender; // Cast the sender to a button
            int itemID = Convert.ToInt32(button.Name.Substring(3, button.Name.Length - 3)); // Get the itemID which is stored as part of the button name
            
            tillSelectedItems.Add(itemID); // Add the itemID to the list
            tillSelectedQuantity.Add(1);
            tillSelectedAlts.Add(0);

            int listItemID = getListItemID(itemID);
            if (listItemID > 0) {
                
                listItemBox.showList(listItemID);
            }
            

            if (isListBoxLocked) {
                changeListLock();
            }

            updateTotal();
            updateTillList();
        }

        private int getListItemID(int itemID) {
            int listItemID = 0;
            foreach (DataRow itemRow in ePOSDBDataSet.tblEPOSItems.Rows) { // If the row contains the item ID
                if (Convert.ToInt32(itemRow[0]) == itemID) {
                    listItemID = Convert.ToInt32(itemRow[14]); // Return list ITem ID
                    break;
                }
            }
            return listItemID;
        }

        private void updateTotal() {
            tillTotal = 0;

            for (int i = 0; i < tillSelectedItems.Count; i++) {
                tillTotal += tillSelectedQuantity[i] * Convert.ToDecimal(this.ePOSDBDataSet.tblEPOSItemPrice.Rows[getPriceIndex(tillSelectedItems[i])][2 + tillSelectedAlts[i]]); // Get the total an add it to the total
            }
            updateTotalDisplay(tillTotal);
        }

        private void updateTotalDisplay(decimal total) {
            tbxTillTotal.Text = "Total: £" + total.ToString("0.00");
        }

        private void updateTillList() {
            lbxTillDisplay.Items.Clear();
            for (int i = 0; i < tillSelectedItems.Count; i++) {
                int itemID = tillSelectedItems[i];
                int itemIndex = getItemIndex(itemID);
                int priceIndex = getPriceIndex(itemID);

                decimal quantity = tillSelectedQuantity[i];
                int altNum = tillSelectedAlts[i];

                string itemName = ePOSDBDataSet.tblEPOSItems.Rows[itemIndex][1].ToString();
                if (altNum > 0) {
                    itemName = ePOSDBDataSet.tblEPOSItems.Rows[itemIndex][10 + altNum].ToString() + " " + itemName;
                } 
                
                string itemPrice = String.Format("£{0}", (Convert.ToDecimal(ePOSDBDataSet.tblEPOSItemPrice.Rows[priceIndex][2 + altNum]) * quantity).ToString("0.00")); // Get the item price and format it to be (£x.xx)

                String displayString = String.Format("{0, -4}{1}{2," + (36 - itemName.Length - 4) + "}", quantity.ToString(), itemName, itemPrice); // Format the display string to be <qty><name><price> with adequete spacing

                lbxTillDisplay.Items.Add(displayString); // Add each item to the db 
                }
        }
        private int getPriceIndex(int itemID) { // Returns the price index from the item ID
            int priceIndex = -1;
            for (int i = 0; i < ePOSDBDataSet.tblEPOSItemPrice.Rows.Count; i++) { // iterate through the itemPrices
                if (itemID == Convert.ToInt32(ePOSDBDataSet.tblEPOSItemPrice.Rows[i][1])) { // If the price equals the ID
                    priceIndex = i; // Return the index
                    break;
                }
            }
            return priceIndex;
        }

        private int getItemIndex(int itemID) { // Returns the index of the item from the item ID
            int itemIndex = -1;
            for (int i = 0; i < ePOSDBDataSet.tblEPOSItems.Rows.Count; i++) { // iterate through the items
                if (itemID == Convert.ToInt32(ePOSDBDataSet.tblEPOSItems.Rows[i][0])) { // if there is an ID match
                    itemIndex = i; // Return the index
                    break;
                }
            }
            return itemIndex;
        }


        private void OnTillButtonClick(object sender, EventArgs e) {
            Button btn = (Button)sender; // Cast sender to a button object
            string btnText = btn.Text;
            switch (btnText) { // Switch on the button text
                case ("Card"): // If card button is clicked
                    tillFinish(true);
                    break;
                case ("Cash"): // If cash button is clicked
                    tillFinish(false);
                    // OPEN CHASH DRAWER: outside of project scope
                    break;
                case ("Error Correct"): // If error correct button is clicked
                    tillErrorCorrect();
                    break;
                case ("Cancel"): // If cancel button is clicked
                    tillCancel();
                    break;
                case ("Table Store"): // If table store button is clicked
                    tillTableStore();
                    break;
                case ("Quantity"):
                    tillChangeQuantity();
                    break;
                case ("Table Plan"):
                    tillOpenTablePlan();
                    break;
                case ("Toggle"):
                    tillToggleAlts();
                    break;
                default: // If any of the other buttons are clicked that are not above (numbers)
                    if (tbxTillDisplay.Text.Length > 0) {
                        if (Char.IsLetter(Convert.ToChar(tbxTillDisplay.Text[0]))) {
                            tbxTillDisplay.Text = "";
                        }
                    }
                    tbxTillDisplay.Text += btnText;
                    usingCustomAmount = true;
                    break;
            }
        }

        public void AllowButtonClick(Control ctrl) { // Findng buttons to read text of on click
            foreach (Control subctrl in ctrl.Controls) { // Get each control in the form
                if (subctrl.GetType() == typeof(GroupBox) || subctrl.GetType() == typeof(Panel)) { // if the control is a group box or panel, enter the method again
                    AllowButtonClick(subctrl); // Recursion
                } else if (subctrl.GetType() == typeof(Button)) { // If a button is found, allow the event to be used.
                    subctrl.Click += OnTillButtonClick;
                }
            }
        }

        private void tillFinish(bool isByCard) { // Till finialisation 
            if (isListBoxLocked) { // If the list box is unlocked
                return;
            }
            if (lbxTillDisplay.Items.Count == 0) { // And has items in it
                return;
            }
            // Declare all items to be put into datatable 
            //int userID = 999; // TODO: User from table
            DateTime cashedTime = DateTime.Now; // The date/time when cashed is the same as now 
            string itemsOnCheque = ""; // String of a list of items and quantity
            decimal tenderedAmount;
            if (usingCustomAmount) { // If a number is typed in
                tenderedAmount = Convert.ToDecimal(tbxTillDisplay.Text); // Get tendered amount
                usingCustomAmount = false; // Make it so it is only using a custom amount if there is actully a custom amount
            } else { // If no number is typed it can be assumed we are tendered preciecily the correct amount
                tenderedAmount = tillTotal;
            }
            chequeDeductions += tenderedAmount; // Keep count of how much the cheque is


            lbxTillDisplay.Items.Add(new String('-', 36)); // seperate display
            lbxTillDisplay.Items.Add(String.Format("Subtotal{0," + (36 - "Subtotal".Length) + "}", "£" + tillTotal.ToString("0.00"))); // Add the subtotal line
            if (isByCard) { // If is a card payment
                lbxTillDisplay.Items.Add(String.Format("Card{0," + (36 - "Card".Length) + "}", "-£" + tenderedAmount.ToString("0.00"))); // Add the card line
                tillTotal -= tenderedAmount; // Subtract the tenderd amount off the total bill
                tbxTillDisplay.Text = "Card: £" + tenderedAmount.ToString("0.00"); // Print registering the card payment
                lbxTillDisplay.Items.Add(String.Format("Remaining Balance{0," + (36 - "Remaining Balance".Length) + "}", "£" + tillTotal.ToString("0.00"))); // Add the Remain balance line
            } else {
                lbxTillDisplay.Items.Add(String.Format("Cash{0," + (36 - "Cash".Length) + "}", "-£" + tenderedAmount.ToString("0.00"))); // Add the Cash line
                tbxTillDisplay.Text = "Cash: £" + tenderedAmount.ToString("0.00"); // Then print how much we are payed in cash
                cashAmount += tenderedAmount; // track cash in till
                decimal change = 0;
                if ((tillTotal - tenderedAmount) < 0) { // If we have change to handle
                    change = -(tillTotal - tenderedAmount); // change is equal to whatever the levtover is 
                    tillTotal = 0; // Total is no longer important
                    tenderedAmount = 0; // Tendered amount is no longer important
                    chequeDeductions -= change; // remove any over values from the deduction
                    cashAmount -= change; // Track cash in till
                    lbxTillDisplay.Items.Add(String.Format("Change{0," + (36 - "Change".Length) + "}", "£" + change.ToString("0.00"))); // Add the change line                        
                }
                tillTotal -= tenderedAmount; // remove the tendered amount from the total if there is no change or not enough to cover the whole bill
            }

            updateTotalDisplay(tillTotal); // Update the total amount

            if (tillTotal == 0) {// If the whole bill is payed     

                changeListLock(); // Lock the list

                // Create the Items on cheque string
                for (int i = 0; i < tillSelectedItems.Count; i++) { // For all selected items
                    int itemID = tillSelectedItems[i]; // get their ID 
                    int quantity = tillSelectedQuantity[i];
                    int altNum = tillSelectedAlts[i];
                    itemsOnCheque += String.Format("{0},{1},{2};", itemID.ToString(), quantity.ToString(), altNum.ToString()); // Add them to the cheque string
                }
                tblEPOSOpenTablesTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSOpenTables.*\r\nFROM tblEPOSOpenTables;\r\n";
                tblEPOSOpenTablesTableAdapter.Fill(ePOSDBDataSet.tblEPOSOpenTables); // Pull info from DB

                int openTableIndex = 0; // Index of open table row in db

                for (int i = 0; i < ePOSDBDataSet.tblEPOSOpenTables.Rows.Count; i++) {
                    if (Convert.ToInt32(ePOSDBDataSet.tblEPOSOpenTables.Rows[i][0]) == this.openTableID) { // If the table ID is equal
                        openTableIndex = i; // Update the open table index
                        break; // Break to avoid slowness
                    }
                }

                tblEPOSCashChequesTableAdapter.Fill(ePOSDBDataSet.tblEPOSCashCheques); // Pull info from DB
                DataTable cashedCheques = ePOSDBDataSet.tblEPOSCashCheques; // Gets the dataTable
                cashedCheques.Rows.Add(); // Adds a new row
                int lastRowIndex = cashedCheques.Rows.Count - 1; // Finds the index of the last (new) row
                int openTable = 0;
                if (openTableID >= 0) {
                    openTable = Convert.ToInt32(ePOSDBDataSet.tblEPOSOpenTables.Rows[openTableIndex][1]);
                } else {
                    openTable = -1;
                }

                // Input all data into the new row
                cashedCheques.Rows[lastRowIndex][1] = userID;
                cashedCheques.Rows[lastRowIndex][2] = openTable;
                cashedCheques.Rows[lastRowIndex][3] = cashedTime;
                cashedCheques.Rows[lastRowIndex][4] = itemsOnCheque;
                cashedCheques.Rows[lastRowIndex][5] = chequeDeductions;
                cashedCheques.Rows[lastRowIndex][6] = cashAmount;

                tblEPOSCashChequesTableAdapter.Update(ePOSDBDataSet.tblEPOSCashCheques); // Push updates to DB
                        
                tillSelectedItems.Clear(); // Clear the list of selected items
                tillSelectedQuantity.Clear();

                MessageBox.Show(userID + "\n" + cashedTime + "\n" + openTable + "\n" + itemsOnCheque + "\n" + chequeDeductions + "\n" + cashAmount);

                chequeDeductions = 0; // reset for next sale
                cashAmount = 0;
                if (openTableID >= 0) { // Reset table when till is finished
                    closeTable(openTableID); // Close the table if it is open (which we can assume if openTableID is not -1)
                    openTableID = -1;
                }
            } // else do nothing
                
            
        }

        private void tillErrorCorrect() { // Till error correction
            if (!isListBoxLocked) { // Only do so if list box is unlocked
                if (lbxTillDisplay.SelectedItem != null) { // Assuming an item is selected 
                    int selectedItemIndex = lbxTillDisplay.SelectedIndex; // Get the selected index 
                    int itemID = tillSelectedItems[selectedItemIndex]; // get the slected item ID

                    decimal itemPrice = Convert.ToDecimal(ePOSDBDataSet.tblEPOSItemPrice.Rows[getPriceIndex(itemID)][2 + tillSelectedAlts[selectedItemIndex]]); // Get the item price
                    lbxTillDisplay.Items.RemoveAt(selectedItemIndex); // Remove item from list box
                    tillSelectedItems.RemoveAt(selectedItemIndex); // remove item from list
                    tillSelectedQuantity.RemoveAt(selectedItemIndex); // Remove quantity
                    tillSelectedAlts.RemoveAt(selectedItemIndex);

                    updateTotal(); // Update the till total

                    tbxTillDisplay.Text = "Error Correct: £" + itemPrice.ToString("0.00"); // Display errorr correct message
                }
            }
        }

        private void tillCancel() { 
            if (!isListBoxLocked) { // Only cancel if lsit box is unlocked 
                tbxTillDisplay.Text = "Cancel £" + tillTotal.ToString("0.00"); // Display cancel value
                lbxTillDisplay.Items.Add(new String('-', 36)); // seperate display
                lbxTillDisplay.Items.Add(String.Format("Cancel{0," + (36 - "Cancel".Length) + "}", "-£" + tillTotal.ToString("0.00"))); // Add the cance; ;ime 
                tillSelectedItems.Clear(); // Clear all items from the list
                tillSelectedQuantity.Clear(); // Clear all quantitys from the list
                tillSelectedAlts.Clear(); // Clear Alts list
                lbxTillDisplay.ClearSelected(); // Clear any selected index to ensure nothing can be editied
                if (openTableID >= 0) { // If the table ID has been used
                    openTableID = -1; // Reset it
                }
                changeListLock(); // Lock list
                updateTotal(); // Update the total value
            }
        }

        private void tillTableStore() { // Store the items in the list to an open table,
                                        /* TODO: allow storing of already cashed off parts of the ticket
                                        In The Store a rouge value in the item string with a value to indicate cash or card then an amount? Like: -1,100 for 100 on card
                                        Then find a way to display this in the till display (Edit open table function probs)
                                        */
            if (isListBoxLocked) { // If the table is not locked, lock it
                changeListLock();
            } 

            if (openTableID != -1) { // If the a table is open
                tblEPOSOpenTablesTableAdapter.Fill(ePOSDBDataSet.tblEPOSOpenTables); // Fill DB
                for (int i = 0; i < ePOSDBDataSet.tblEPOSOpenTables.Rows.Count; i++) { // For every open table
                    if (Convert.ToInt32(ePOSDBDataSet.tblEPOSOpenTables.Rows[i][0]) == openTableID) { // Find open table
                        string newTableItemString = ""; // Create new string
                        for (int x = 0; x < lbxTillDisplay.Items.Count; x++) { // For every item in the list box
                            newTableItemString += String.Format("{0},{1},{2};", tillSelectedItems[x], tillSelectedQuantity[x], tillSelectedAlts[x]); // Add its quantity and itemid to the string
                        }
                        ePOSDBDataSet.tblEPOSOpenTables.Rows[i][2] = newTableItemString; // add string in DB
                        tblEPOSOpenTablesTableAdapter.Update(ePOSDBDataSet.tblEPOSOpenTables.Rows[i]); // Update string
                        break; // break loop to avoid unnessasary searching
                    }
                }
                // Display
                lbxTillDisplay.Items.Add(new String('-', 36)); // seperate display
                lbxTillDisplay.Items.Add(String.Format("Table Store{0," + (36 - "Table Store".Length) + "}", "£" + tillTotal.ToString("0.00"))); // Add the table store line
                tbxTillDisplay.Text = "Table Store: £" + tillTotal.ToString("0.00"); // Print registering the table store
                openTableID = -1; // Reset table ID to base value

            } // else do nothing
        }

        private void tillChangeQuantity() { // Function to multiply quantity
            usingCustomAmount = false; // Stops till thinking you usign a custom amoutn when entering a quantity change
            if (lbxTillDisplay.SelectedIndex != -1 && tbxTillDisplay.Text != "") { // If an index is selected and text is in the box
                // TODO: Fix error if quantity is not int
                tillSelectedQuantity[lbxTillDisplay.SelectedIndex] = Convert.ToInt32(tbxTillDisplay.Text);
                updateTotal();
                updateTillList();
                tbxTillDisplay.Text = "";
            }
        }

        private void changeListLock() { // Invert the list lock and disable selection
            if (isListBoxLocked) { // if it is locked 
                lbxTillDisplay.SelectionMode = SelectionMode.One; // allow selection
                isListBoxLocked = false; // not locked
            } else { // if it is not locked
                lbxTillDisplay.SelectionMode = SelectionMode.None; // disallow selection
                isListBoxLocked = true; // lock list
            }
        }

        private void tillOpenTablePlan() { // Open table plan Form
            frmTablePlan frmTablePlan = new frmTablePlan(screenSize, userID, this); // new form instance, passing through any sub forms
            frmTablePlan.ShowDialog();// Open table plan
        }

        private void tillToggleAlts() { // Toggle to alt quantities
            int listIndex = lbxTillDisplay.SelectedIndex;
            if (listIndex == -1) { // If an item is selected
                return;
            }

            int selectedItemID = tillSelectedItems[listIndex];
            int itemIndex = getItemIndex(selectedItemID);


            DataRow item = ePOSDBDataSet.tblEPOSItems.Rows[itemIndex];

            List<double> altQuantities = new List<double>(); // Get the alt quantities (% of total)
            altQuantities.Add(1); // default quantity
            altQuantities.Add(Convert.ToDouble(item[8])); // Alt amount 1
            altQuantities.Add(Convert.ToDouble(item[9])); // Alt amount 2
            altQuantities.Add(Convert.ToDouble(item[10])); // Alt amount 3

            int currentAltIndex = tillSelectedAlts[listIndex]; // get current alt index
            int newAltIndex;
            if (currentAltIndex + 1 > altQuantities.Count - 1) { // If we go passed the last alt (restart from beginning)
                newAltIndex = 0;
            } else { // Else we are toggling to the next alt
                newAltIndex = currentAltIndex + 1;
            }
            if (altQuantities[newAltIndex] == 0) {
                newAltIndex = 0;
            }
            tillSelectedAlts[listIndex] = newAltIndex;
            updateTotal();
            updateTillList();
            lbxTillDisplay.SelectedIndex = listIndex;
        }

        public void openTable(List<int> tableSelectedTillItems, List<int> tableSelectedTillQuantity, List<int> tableSelectedAlts, int openTableID) { // public to open a table externally using an int list of the selected item IDs
            this.tillSelectedItems = tableSelectedTillItems; // get the arrays from the other form
            this.tillSelectedQuantity = tableSelectedTillQuantity;
            this.tillSelectedAlts = tableSelectedAlts;
            this.openTableID = openTableID; // Pull table ID to open

            // TODO: Put notes on a table once opened
            // TODO: Allow moving tabs between tables
            // TODO: Split bill feature
            // URGENT TODO: Reciept Layout/print

            tbxTillDisplay.Text = ""; // Clear display if any text

            if (isListBoxLocked) { // If the table is locked 
                changeListLock();
            }
            // Update the till display
            updateTotal();
            updateTillList();
        }

        private void closeTable(int openTableID) { // "Close" a table by removeing it from the open tables DB table
            tblEPOSOpenTablesTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSOpenTables.*\r\nFROM tblEPOSOpenTables;\r\n";
            tblEPOSOpenTablesTableAdapter.Fill(ePOSDBDataSet.tblEPOSOpenTables); // Pull info from DB
            DataTable openTables = ePOSDBDataSet.tblEPOSOpenTables; // Table

            int openTableIndex = -1; // Index in DB of the open table
            for (int i = 0; i < openTables.Rows.Count; i++) { // Iterate until a DB match is found
                if (openTableID == Convert.ToInt32(openTables.Rows[i][0])) {
                    openTableIndex = i; // Store index
                }
            }

            if (openTableIndex >= 0) {
                ePOSDBDataSet.tblEPOSOpenTables.Rows[openTableIndex].Delete(); // Remove index
                tblEPOSOpenTablesTableAdapter.Update(ePOSDBDataSet.tblEPOSOpenTables); // Update db
                ePOSDBDataSet.tblEPOSOpenTables.AcceptChanges(); // Acept row deletion
            }
        }
    }
}
