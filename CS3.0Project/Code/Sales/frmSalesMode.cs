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
using System.Runtime.CompilerServices;
using System.Diagnostics.PerformanceData;

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
        private List<List<List<int>>> tillSelectedLists = new List<List<List<int>>>();
        private List<string> tillSelectedNotes = new List<string>();
        private List<int> tillDisplayCopy = new List<int>(); // Holds ints in relation to the contents of the main list. > 0 is till items (itemIDs). 0 is list items. -1 is note items.
        private decimal tillTotal = 0.0m;
        private decimal chequeDeductions = 0.0m;
        private decimal cashAmount = 0.0m;
        private bool isListBoxLocked = false;
        private bool usingCustomAmount = false;

        // FOR TABLE OPENING
        private int openTableID = -1;

        private frmMessageBox cMessageBox = new frmMessageBox(); // Custom message box
        private frmKeyboard keyboard = new frmKeyboard();
        private ItemDisplayGenerator itemDisplayGenerator;
        private frmListBox listItemBox = new frmListBox();

        // TODO: Modernise all form design

        // BIG TODO: Reservation System and storage
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
            this.tblEPOSOpenTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSOpenTables);


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
            tillSelectedLists.Add(new List<List<int>>());
            tillSelectedNotes.Add("");
            tillDisplayCopy.Add(itemID);

            int listItemID = getListItemID(itemID); 
            if (listItemID > 0) { // If the list item > 0 then a list needs to be shown on item press so show the list and deal with output
                listItemBox.showList(listItemID);
                int listReturnItem = listItemBox.returnItem; // Get item from the from
                if (listReturnItem == -1) {
                    return;
                }
                List<int> listReturn = new List<int>(); // Create the list item fromat
                listReturn.Add(listItemID); // Add listbox ID
                listReturn.Add(listReturnItem); // Add list box selected item   {ListID,SelectedItemID}
                tillSelectedLists[tillSelectedLists.Count - 1].Add(listReturn); // Set the appropoiate item to this
                tillDisplayCopy.Add(0);
            }

            if (isListBoxLocked) {
                changeListLock();
            }

            updateTotal();
            updateTillList();
        }

        public void ListDynamicItemButton_Click(object sender, EventArgs e) { 
            Button button = (Button)sender;
            int itemID = Convert.ToInt32(button.Name.Substring(4, button.Name.Length - 4)); // Get the itemID which is stored as part of the button name
            int screenSelectedIndex = getSelectedIndex(); // Get the current selected index
            if (screenSelectedIndex == -1) { // Stop if nothing is selected
                return;
            }
            int listID = getListItemID(itemID);
            listItemBox.showList(listID);
            int listReturnItem = listItemBox.returnItem; // Get item from the from
            if (listReturnItem == -1) {
                return;
            }
            List<int> listReturn = new List<int>(); // Create the list item fromat
            listReturn.Add(listID); // Add listbox ID
            listReturn.Add(listReturnItem); // Add list box selected item   {ListID,SelectedItemID}
            tillSelectedLists[screenSelectedIndex].Add(listReturn); // Set the appropoiate item to this
            tillDisplayCopy.Add(0);

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
                    listItemID = Convert.ToInt32(itemRow[14]); // Return list Item ID
                    break;
                }
            }
            return listItemID;
        }

        private decimal getListItemPrice(List<int> selectedItemList) {
            if (selectedItemList.Count == 0) { // If the ITEM ID is 0 (no list item associated to this selection) then just return 0
                return 0;
            } // Otherwise get the item price from the DB table
            decimal listItemPrice; 
            int itemID = selectedItemList[1];
            int priceIndex = getPriceIndex(itemID);
            listItemPrice = Convert.ToDecimal(ePOSDBDataSet.tblEPOSItemPrice.Rows[priceIndex][2]);
            return listItemPrice;
        }

        private int getIndex(int listIndex) { // gets the current index in the lists (for itemid etc) for a given list index in the display, returns -1 if no item is selected
            int count = 0;
            for (int i = 0; i < lbxTillDisplay.Items.Count; i++) {
                if (Convert.ToInt32(tillDisplayCopy[i]) > 0) {
                    count++;
                }
                if (i == listIndex) {
                    break;
                }
            }
            return (count - 1);
        }

        private int getSelectedIndex() { // gets the current index in the lists (for itemid etc) for a selected item in the display, returns -1 if no item is selected
            int selectedIndex = lbxTillDisplay.SelectedIndex;
            if (selectedIndex == -1) {
                return -1;
            }
            return getIndex(selectedIndex);
        }

        private int getSelectedListIndex() { // Gets the index of the selected list item (under the selected item), returns -1 if not sub item is selected
            int count = 0;
            int selectedIndex = lbxTillDisplay.SelectedIndex;
            for (int i = 0; i < lbxTillDisplay.Items.Count; i++) {
                if (Convert.ToInt32(tillDisplayCopy[i]) == 0) {
                    count++;
                }
                if (i == selectedIndex) {
                    break;
                }
                if (Convert.ToInt32(tillDisplayCopy[i]) > 0) {
                    count = 0;
                }
            }
            return (count - 1);
        }

        private int getSelectedNoteIndex() { // Gets the index of the selected note item (under the selected item), returns -1 if not sub item is selected
            int count = 0;
            int selectedIndex = lbxTillDisplay.SelectedIndex;
            for (int i = 0; i < lbxTillDisplay.Items.Count; i++) {
                if (Convert.ToInt32(tillDisplayCopy[i]) == -1) {
                    count++;
                }
                if (i == selectedIndex) {
                    break;
                }
                if (Convert.ToInt32(tillDisplayCopy[i]) > 0) {
                    count = 0;
                }
            }
            return (count - 1);
        }

        private void updateTotal() { // Recalculate the total amount in the till list
            tillTotal = 0; // reset

            for (int i = 0; i < tillSelectedItems.Count; i++) { // For every item
                tillTotal += tillSelectedQuantity[i] * Convert.ToDecimal(this.ePOSDBDataSet.tblEPOSItemPrice.Rows[getPriceIndex(tillSelectedItems[i])][2 + tillSelectedAlts[i]]); // Get the total of each item multiplied by the qty and add it to the total
                foreach (List<int> selectedItemList in tillSelectedLists[i]) { // for every sub list item
                    tillTotal += tillSelectedQuantity[i] * getListItemPrice(selectedItemList); // Get any modifieres that are attached to the current item and multiply its price bu the quantity
                }
            }
            updateTotalDisplay(tillTotal);
        }

        private void updateTotalDisplay(decimal total) { // Updates the total text
            tbxTillTotal.Text = "Total: £" + total.ToString("0.00");
        }

        private void updateTillList() { // Clears and adds all items to the display list
            lbxTillDisplay.Items.Clear(); // Clear List
            for (int i = 0; i < tillSelectedItems.Count; i++) { // For every selected item
                int itemID = tillSelectedItems[i]; // Get item details
                int itemIndex = getItemIndex(itemID);
                int priceIndex = getPriceIndex(itemID);

                decimal quantity = tillSelectedQuantity[i]; // Get quantiy
                int altNum = tillSelectedAlts[i]; // Any alt numbers

                string itemName = ePOSDBDataSet.tblEPOSItems.Rows[itemIndex][1].ToString(); // Get item nme

                if (altNum > 0) { // If it is a modified alt item
                    itemName = ePOSDBDataSet.tblEPOSItems.Rows[itemIndex][10 + altNum].ToString() + " " + itemName; // Amend name
                }

                string itemPrice = String.Format("£{0}", (Convert.ToDecimal(ePOSDBDataSet.tblEPOSItemPrice.Rows[priceIndex][2 + altNum]) * quantity).ToString("0.00")); // Get the item price and format it to be (£x.xx)

                String displayString = String.Format("{0, -4}{1}{2," + (36 - itemName.Length - 4) + "}", quantity.ToString(), itemName, itemPrice); // Format the display string to be <qty><name><price> with adequete spacing

                lbxTillDisplay.Items.Add(displayString); // Add each item to the list box

                foreach (List<int> selectedList in tillSelectedLists[i]) { // For all list items
                    if (selectedList.Count == 0) {
                        break;
                    }
                    decimal listItemPrice = getListItemPrice(selectedList); // Get list item details
                    int listItemIndex = getItemIndex(Convert.ToInt32(selectedList[1]));
                    int listPriceIndex = getPriceIndex(Convert.ToInt32(selectedList[1]));
                    string listItemName = ePOSDBDataSet.tblEPOSItems.Rows[listItemIndex][1].ToString();
                    string listItemPriceFormatted = String.Format("£{0}", (Convert.ToDecimal(ePOSDBDataSet.tblEPOSItemPrice.Rows[listPriceIndex][2]) * quantity).ToString("0.00")); // Get the list item price and format it to be (£x.xx)
                    String listDisplayString = String.Format("{0, 4}{1, 10}{2," + (36 - listItemName.Length - 10) + "}", quantity.ToString(), listItemName, listItemPriceFormatted);
                    lbxTillDisplay.Items.Add(listDisplayString); // Add each selected list item to the list box
                }

                // Till Notes
                string tillNote = tillSelectedNotes[i];
                if (tillNote == "") { // Do not do anything if there is no note
                    continue;
                }

                string[] notes = tillNote.Split('\n');
                foreach (string note in notes) {
                    if (note != "") {
                        String noteDisplayString = String.Format("{0,-4}", note); // Create strin and add it to the till display
                        lbxTillDisplay.Items.Add(noteDisplayString);
                    }
                }
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
                case ("Remove"): // If error correct button is clicked
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
                case ("Add Note"):
                    tillAddNote();
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
                    int itemID = tillSelectedItems[i]; // get their info 
                    int quantity = tillSelectedQuantity[i];
                    int altNum = tillSelectedAlts[i];
                    String selectedListsFormatted = "";
                    foreach (List<int> selectedItem in tillSelectedLists[i]) {
                        selectedListsFormatted += String.Format("{0}.{1}:", selectedItem[0], selectedItem[1]);
                    }
                    string notes = tillSelectedNotes[i];

                    itemsOnCheque += String.Format("{0},{1},{2},{3},{4};", itemID.ToString(), quantity.ToString(), altNum.ToString(), selectedListsFormatted, notes); // Add them to the cheque string
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
                tillSelectedAlts.Clear();
                tillSelectedLists.Clear();
                tillSelectedNotes.Clear();
                tillDisplayCopy.Clear();

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
                    int selectedItemIndex = getSelectedIndex(); // Get the selected index 
                    int itemID = tillSelectedItems[selectedItemIndex]; // get the slected item ID

                    decimal itemPrice = Convert.ToDecimal(ePOSDBDataSet.tblEPOSItemPrice.Rows[getPriceIndex(itemID)][2 + tillSelectedAlts[selectedItemIndex]]); // Get the item price
                    tillSelectedItems.RemoveAt(selectedItemIndex); // remove item from list
                    tillSelectedQuantity.RemoveAt(selectedItemIndex); // Remove quantity
                    tillSelectedAlts.RemoveAt(selectedItemIndex); // Remove any alts
                    tillSelectedLists.RemoveAt(selectedItemIndex); // Remove any lists
                    tillSelectedNotes.RemoveAt(selectedItemIndex);
                    tillDisplayCopy.RemoveAt(lbxTillDisplay.SelectedIndex); // TODO: Remove all display copy items item removal.

                    updateTillList();
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
                tillSelectedLists.Clear(); // Clear selected lists
                tillSelectedNotes.Clear(); // Clear selected notes
                tillDisplayCopy.Clear();
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
                        for (int x = 0; x < tillSelectedItems.Count; x++) { // For every item in the list box
                            String selectedListsFormatted = "";

                            foreach (List<int> selectedItem in tillSelectedLists[x]) {
                                    selectedListsFormatted += String.Format("{0}.{1}:", selectedItem[0], selectedItem[1]);
                            }
                            newTableItemString += String.Format("{0},{1},{2},{3},{4};", tillSelectedItems[x], tillSelectedQuantity[x], tillSelectedAlts[x], selectedListsFormatted, tillSelectedNotes[x]); // Add its quantity and itemid to the string
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
            int listIndex = getSelectedIndex(); // Get selected index
            if (listIndex == -1){ // if nothing selected, return
                return;
            }
            if (tbxTillDisplay.Text == "") { // if quantity box is empty, return
                return;
            }
            if (!Char.IsDigit(tbxTillDisplay.Text[0])) { // if quantity box has unremoved text, return
                return;
            }
            string[] splitText = tbxTillDisplay.Text.Split('.'); // split if a decimal is input
            tillSelectedQuantity[listIndex] = Convert.ToInt32(splitText[0]); // Convert the first number to a int, adjust quantity
            updateTotal(); // Recalc total
            updateTillList(); // Redraw List
            tbxTillDisplay.Text = "";
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
            int listIndex = getSelectedIndex();
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
        }

        private void tillAddNote() { // Adds notes 
            int selectedItemIndex = getSelectedIndex(); // Get the item (to add the note to)
            if (selectedItemIndex == -1) {
                return;
            }
            keyboard.ShowDialog(); // Show keyboard
            string keyboardIn = keyboard.getInput(); // get keyboard input
            if (keyboardIn == "") { // If its empty then stop
                return;
            }
            tillSelectedNotes[selectedItemIndex] += keyboardIn + "\n"; // Add Note
            // Insert into displaycopy after all the lists attached to an item
            int insertIndex = 0;
            int count = 0;
            for (int i = 0; i < tillDisplayCopy.Count; i++) {
                if (tillDisplayCopy[i] > 0) {
                    count++;
                }
                if (count == selectedItemIndex + 1) {
                    insertIndex = i + 1;
                    break;
                }

            }

            if (insertIndex > tillDisplayCopy.Count - 1) {
                tillDisplayCopy.Add(-1);
            } else {
                tillDisplayCopy.Insert(insertIndex, -1); // Insert a -1 as a tracking int in the display copy, just after all the lists attached to one item.
            }
            updateTillList();
        }

        public void openTable(List<int> tableSelectedTillItems, List<int> tableSelectedTillQuantity, List<int> tableSelectedAlts, List<List<List<int>>> tableSelectedLists, List<string> tableSelectedNotes, List<int> tableDisplayCopy, int openTableID) { // public to open a table externally using an int list of the selected item IDs
            this.tillSelectedItems = tableSelectedTillItems; // get the arrays from the other form
            this.tillSelectedQuantity = tableSelectedTillQuantity;
            this.tillSelectedAlts = tableSelectedAlts;
            this.tillSelectedLists = tableSelectedLists;
            this.tillSelectedNotes = tableSelectedNotes;
            this.tillDisplayCopy = tableDisplayCopy;

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
