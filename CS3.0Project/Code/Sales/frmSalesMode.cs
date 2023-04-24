using CS3._0Project.Code.Utility.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CS3._0Project.Code.Table;
using CS3._0Project.Code.Utility.Classes;
using CS3._0Project.Forms;

namespace CS3._0Project.Code.Sales {
    public partial class frmSalesMode : Form {

        // TODO: Hide vertical scrollbar in list box (create custom listbox item)

        private Size screenSize;
        private int userID;
        private string username;
        private bool isRefundMode;   

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
        private int tableItemCountOnOpen = 0;

        private frmEPOSMenu frmEPOSMenu;
        private frmMessageBox cMessageBox = new frmMessageBox(); // Custom message box
        private frmKeyboard keyboard = new frmKeyboard();
        private DBTools DBTools = new DBTools();
        private ItemDisplayGenerator itemDisplayGenerator;
        private frmListBox listItemBox = new frmListBox();
        private PrintController printCtrl = new PrintController();

        // TODO: Add login to sales form
        // MAJOR TODO: Reservation System and storage
        public frmSalesMode(frmEPOSMenu frmEPOSMenu, Size size, int userID, string username, bool isRefundMode) {
            InitializeComponent();
            this.frmEPOSMenu = frmEPOSMenu;
            this.screenSize = size;
            this.userID = userID;
            this.username = username;
            this.isRefundMode = isRefundMode;
        }

        public frmSalesMode(Size size, int userID, string username, bool isRefundMode) {
            InitializeComponent();
            this.screenSize = size;
            this.userID = userID;
            this.username = username;
            this.isRefundMode = isRefundMode;
        }

        private void frmSalesMode_Shown(object sender, EventArgs e) {
            this.Size = screenSize;
        }

        private void btnHome_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmSalesMode_Load(object sender, EventArgs e) {
            refreshDB();
            frmInit();

            itemDisplayGenerator.createButtons();
            AllowButtonClick(pnlTillDisplay);

            
            lblUsername.Text = username;
        }

        private void refreshDB() {
            // Fill DB Tables On Load
            this.tblEPOSUsersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSUsers);
            this.tblEPOSCashChequesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSCashCheques);
            this.tblEPOSItemPriceTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemPrice);
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);
            this.tblEPOSItemFoldersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemFolders);
            this.tblEPOSOpenTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSOpenTables);
            this.tblEPOSTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSTables);


            itemDisplayGenerator = new ItemDisplayGenerator(this, ePOSDBDataSet.tblEPOSItems, ePOSDBDataSet.tblEPOSItemFolders, pnlItemDisplay);
        }

        private void frmInit() {
            /* Reset All Items */
            // FOR ITEM DISPLAY AND CALC
            tillSelectedItems = new List<int>();
            tillSelectedQuantity = new List<int>();
            tillSelectedAlts = new List<int>();
            tillSelectedLists = new List<List<List<int>>>();
            tillSelectedNotes = new List<string>();
            tillDisplayCopy = new List<int>(); // Holds ints in relation to the contents of the main list. > 0 is till items (itemIDs). 0 is list items. -1 is note items.
            tillTotal = 0.0m;
            chequeDeductions = 0.0m;
            cashAmount = 0.0m;
            isListBoxLocked = false;
            usingCustomAmount = false;

            // FOR TABLE OPENING
            openTableID = -1;

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
            if (isRefundMode) { // Get quantity based on refund mode
                tillSelectedQuantity.Add(-1);
            } else {
                tillSelectedQuantity.Add(1);
            }
            tillSelectedAlts.Add(0);
            tillSelectedLists.Add(new List<List<int>>());
            tillSelectedNotes.Add("");
            tillDisplayCopy.Add(itemID);

            addListItems(itemID, false);
  

            if (isListBoxLocked) {
                changeListLock();
            }

            updateTotal();
            updateTillList();
        }

        private void addListItems(int itemID, bool insert) { // Adds any list items to the item
    
            int listItemID = DBTools.getListItemID(ePOSDBDataSet.tblEPOSItems, itemID);

            if (listItemID > 0) { // If the list item > 0 then a list needs to be shown on item press so show the list and deal with output
                listItemBox.showList(listItemID);
                int listReturnItem = listItemBox.returnItem; // Get item from the from
                if (listReturnItem == -1) {
                    return;
                }
                List<int> listReturn = new List<int>(); // Create the list item fromat
                listReturn.Add(listItemID); // Add listbox ID
                listReturn.Add(listReturnItem); // Add list box selected item   {ListID,SelectedItemID}

                if (!insert) { // IF adding to the end (new item)
                    tillSelectedLists[tillSelectedLists.Count - 1].Add(listReturn); // Set the appropoiate item to this
                    tillDisplayCopy.Add(0);
                } else { // If inserting into the list
                    int screenSelectedIndex = getSelectedIndex(); // Get the current selected index
                    if (screenSelectedIndex == -1) { // Stop if nothing is selected
                        return;
                    }

                    tillSelectedLists[screenSelectedIndex].Add(listReturn); // Set the appropoiate item to this

                    // Get the display copy and locate where were inserting/adding the display item (Add 0 just after the item)
                    int selectedItemScreenIndex;
                    for (int i = 0; i < lbxTillDisplay.Items.Count; i++) { // For every item in the screen list
                        selectedItemScreenIndex = getParentIndex(i); // Get its parent item index
                        if (i == lbxTillDisplay.Items.Count - 1) { // If this is the final item in the list, just add 
                            tillDisplayCopy.Add(0);
                            break;
                        }
                        if (selectedItemScreenIndex == screenSelectedIndex) { // If the item is found not at the end of the list, insert the item just after the item.
                            tillDisplayCopy.Insert(i + 1, 0);
                            break;
                        }
                    }
                }

                addListItems(listReturnItem, insert);
            }
            
        }

        public void ListDynamicItemButton_Click(object sender, EventArgs e) { // List Items are buttons which show a list of modifiers that you can add to an item
            Button button = (Button)sender;
            int itemID = Convert.ToInt32(button.Name.Substring(4, button.Name.Length - 4)); // Get the itemID which is stored as part of the button name

            addListItems(itemID, true);

            if (isListBoxLocked) {
                changeListLock();
            }

            updateTotal();
            updateTillList();
        }

        private int getParentIndex(int listIndex) { // gets the current index in the lists (for itemid etc) for a given list index in the display, returns -1 if no item is selected
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
            return getParentIndex(selectedIndex);
        }

        private void updateTotal() { // Recalculate the total amount in the till list
            tillTotal = 0; // reset

            for (int i = 0; i < tillSelectedItems.Count; i++) { // For every item
                tillTotal += tillSelectedQuantity[i] * Convert.ToDecimal(this.ePOSDBDataSet.tblEPOSItemPrice.Rows[DBTools.getPriceIndex(ePOSDBDataSet.tblEPOSItemPrice, tillSelectedItems[i])][2 + tillSelectedAlts[i]]); // Get the total of each item multiplied by the qty and add it to the total
                foreach (List<int> selectedItemList in tillSelectedLists[i]) { // for every sub list item
                    tillTotal += tillSelectedQuantity[i] * DBTools.getListItemPrice(ePOSDBDataSet.tblEPOSItemPrice, selectedItemList); // Get any modifieres that are attached to the current item and multiply its price bu the quantity
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
                int itemIndex = DBTools.getItemIndex(ePOSDBDataSet.tblEPOSItems, itemID);
                int priceIndex = DBTools.getPriceIndex(ePOSDBDataSet.tblEPOSItemPrice, itemID);

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
                    decimal listItemPrice = DBTools.getListItemPrice(ePOSDBDataSet.tblEPOSItemPrice, selectedList); // Get list item details
                    int listItemIndex = DBTools.getItemIndex(ePOSDBDataSet.tblEPOSItems, Convert.ToInt32(selectedList[1]));
                    int listPriceIndex = DBTools.getPriceIndex(ePOSDBDataSet.tblEPOSItemPrice, Convert.ToInt32(selectedList[1]));
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
            if (isListBoxLocked) { // If the list box is locked
                return;
            }
            // Declare all items to be put into datatable 
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

            if (tillTotal != 0) {// If the whole bill is payed
                return;                    // 
            }

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

            int openTable = -1;
            if (lbxTillDisplay.Items.Count != 0) { // Dont bother saving to DB if there are no items on the bill
                tblEPOSCashChequesTableAdapter.Fill(ePOSDBDataSet.tblEPOSCashCheques); // Pull info from DB
                DataTable cashedCheques = ePOSDBDataSet.tblEPOSCashCheques; // Gets the dataTable
                cashedCheques.Rows.Add(); // Adds a new row
                int lastRowIndex = cashedCheques.Rows.Count - 1; // Finds the index of the last (new) row
                if (openTableID >= 0) {
                    openTable = Convert.ToInt32(ePOSDBDataSet.tblEPOSOpenTables.Rows[openTableIndex][1]);
                }

                // Input all data into the new row
                cashedCheques.Rows[lastRowIndex][1] = userID;
                cashedCheques.Rows[lastRowIndex][2] = openTable;
                cashedCheques.Rows[lastRowIndex][3] = cashedTime;
                cashedCheques.Rows[lastRowIndex][4] = itemsOnCheque;
                cashedCheques.Rows[lastRowIndex][5] = chequeDeductions;
                cashedCheques.Rows[lastRowIndex][6] = cashAmount;

                tblEPOSCashChequesTableAdapter.Update(ePOSDBDataSet.tblEPOSCashCheques); // Push updates to DB
            }

            tillSelectedItems.Clear(); // Clear the list of selected items
            tillSelectedQuantity.Clear();
            tillSelectedAlts.Clear();
            tillSelectedLists.Clear();
            tillSelectedNotes.Clear();
            tillDisplayCopy.Clear();

            chequeDeductions = 0; // reset for next sale
            cashAmount = 0;
            if (openTableID >= 0) { // Reset table when till is finished
                closeTable(openTableID); // Close the table if it is open (which we can assume if openTableID is not -1)
                openTableID = -1;
            }
        }

        private void tillErrorCorrect() { // Till error correction
            if (isListBoxLocked) { 
                return;
            } // Only do so if list box is unlocked
            if (lbxTillDisplay.SelectedIndex == -1) {
                return;
            } // Assuming an item is selected 

            int selectedItemIndex = getSelectedIndex(); // Get the selected index 
            int itemID = tillSelectedItems[selectedItemIndex]; // get the slected item ID

            decimal itemPrice = Convert.ToDecimal(ePOSDBDataSet.tblEPOSItemPrice.Rows[DBTools.getPriceIndex(ePOSDBDataSet.tblEPOSItemPrice, itemID)][2 + tillSelectedAlts[selectedItemIndex]]); // Get the item price

            if (openTableID > -1) {
                tableItemCountOnOpen--; // To ensure new tickets will print all new items, even after removing an item
            }

            // Update lists
            tillSelectedItems.RemoveAt(selectedItemIndex); // remove item from list
            tillSelectedQuantity.RemoveAt(selectedItemIndex); // Remove quantity
            tillSelectedAlts.RemoveAt(selectedItemIndex); // Remove any alts
            tillSelectedLists.RemoveAt(selectedItemIndex); // Remove any lists
            tillSelectedNotes.RemoveAt(selectedItemIndex); //Remove any notes

            removeSubItemsAt(selectedItemIndex); // Update the till display copy to remove any items and its sub items of the selected item index

            updateTillList();
            updateTotal(); // Update the till total

            tbxTillDisplay.Text = "Error Correct: £" + itemPrice.ToString("0.00"); // Display errorr correct message
        }

        private void removeSubItemsAt(int selectedItemIndex) { // Remove any item and its note and list items from the display copy (anything that is attached to the item we have removed)
            int itemCount = 0;
            for (int i = 0; i < tillDisplayCopy.Count; i++) { // For evey item in the display copy
                if (tillDisplayCopy[i] > 0) {
                    itemCount++;
                }
                if (getParentIndex(itemCount) != selectedItemIndex) {
                    continue;
                } // If the sub items parent is equal to the selected item index
                int deletionIndex = i;
                tillDisplayCopy.RemoveAt(deletionIndex); // remove the item

                if (tillDisplayCopy.Count < 1) { // If the list is empty, break
                    break;
                }

                while (tillDisplayCopy.Count > deletionIndex && tillDisplayCopy[deletionIndex] < 1) { // While there are items after the deleted item and the current item is not an item
                    tillDisplayCopy.RemoveAt(deletionIndex); // Remove a sub item

                    if (tillDisplayCopy.Count < 1) { // If the list is empty, break
                        break;
                    }
                }

                break; // break out of for loop to redraw the list
                
            }
        }

        private void tillCancel() {
            if (isListBoxLocked) { // Only cancel if list box is unlocked 
                return;
            }
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

        private void tillTableStore() { // Store the items in the list to an open table,
                                        /* MAJOR TODO: allow storing of already cashed off parts of the ticket
                                        In The Store a rouge value in the item string with a value to indicate cash or card then an amount? Like: -1,100 for 100 on card
                                        Then find a way to display this in the till display (Edit open table function probs)
                                        */
            if (isListBoxLocked) { // If the table is not locked, lock it
                changeListLock();
            }

            if (openTableID == -1) { 
                return;
            } // If the a table is open
            List<string> printBarItemName = new List<string>();
            List<int> printBarItemQuantity = new List<int>();
            List<List<string>> printBarItemListItems = new List<List<string>>();
            List<string> printBarItemNotes = new List<string>();
            List<bool> printBarItemPrintRed = new List<bool>();

            List<string> printKitchenItemName = new List<string>();
            List<int> printKitchenItemQuantity = new List<int>();
            List<List<string>> printKitchenItemListItems = new List<List<string>>();
            List<string> printKitchenItemNotes = new List<string>();
            List<bool> printKitchenItemPrintRed = new List<bool>();

            tblEPOSOpenTablesTableAdapter.Fill(ePOSDBDataSet.tblEPOSOpenTables); // Fill DB
            for (int i = 0; i < ePOSDBDataSet.tblEPOSOpenTables.Rows.Count; i++) { // For every open table
                if (Convert.ToInt32(ePOSDBDataSet.tblEPOSOpenTables.Rows[i][0]) == openTableID) { // Find open table
                    string newTableItemString = ""; // Create new string
                    for (int x = 0; x < tillSelectedItems.Count; x++) { // For every item in the list box
                        List<string> itemPrinters = DBTools.getItemPrinters(ePOSDBDataSet.tblEPOSItems, tillSelectedItems[x]);

                        if (itemPrinters.Contains("Bar")) {
                            List<string> printItemSubList = new List<string>();
                            String selectedListsFormatted = "";

                            foreach (List<int> selectedItem in tillSelectedLists[x]) {
                                selectedListsFormatted += String.Format("{0}.{1}:", selectedItem[0], selectedItem[1]);
                                printItemSubList.Add(DBTools.getItemName(ePOSDBDataSet.tblEPOSItems, selectedItem[1]));
                            }

                            newTableItemString += String.Format("{0},{1},{2},{3},{4};", tillSelectedItems[x], tillSelectedQuantity[x], tillSelectedAlts[x], selectedListsFormatted, tillSelectedNotes[x]); // Add its quantity and itemid to the string
                            if (tillSelectedAlts[x] > 0) { // Get the name based on weather it is an alternate item or not
                                printBarItemName.Add(ePOSDBDataSet.tblEPOSItems.Rows[DBTools.getItemIndex(ePOSDBDataSet.tblEPOSItems, tillSelectedItems[x])][10 + tillSelectedAlts[x]] + " " + DBTools.getItemName(ePOSDBDataSet.tblEPOSItems, tillSelectedItems[x]));
                            } else {
                                printBarItemName.Add(DBTools.getItemName(ePOSDBDataSet.tblEPOSItems, tillSelectedItems[x]));
                            }
                            printBarItemListItems.Add(printItemSubList);
                            printBarItemPrintRed.Add(DBTools.getItemPrintRed(ePOSDBDataSet.tblEPOSItems, tillSelectedItems[x]));
                            printBarItemQuantity.Add(tillSelectedQuantity[x]);
                            printBarItemNotes.Add(tillSelectedNotes[x]);
                        }
                        if (itemPrinters.Contains("Kitchen")) {
                            List<string> printItemSubList = new List<string>();
                            String selectedListsFormatted = "";

                            foreach (List<int> selectedItem in tillSelectedLists[x]) {
                                selectedListsFormatted += String.Format("{0}.{1}:", selectedItem[0], selectedItem[1]);
                                printItemSubList.Add(DBTools.getItemName(ePOSDBDataSet.tblEPOSItems, selectedItem[1]));
                            }

                            newTableItemString += String.Format("{0},{1},{2},{3},{4};", tillSelectedItems[x], tillSelectedQuantity[x], tillSelectedAlts[x], selectedListsFormatted, tillSelectedNotes[x]); // Add its quantity and itemid to the string
                            if (tillSelectedAlts[x] > 0) { // Get the name based on weather it is an alternate item or not
                                printKitchenItemName.Add(ePOSDBDataSet.tblEPOSItems.Rows[DBTools.getItemIndex(ePOSDBDataSet.tblEPOSItems, tillSelectedItems[x])][10 + tillSelectedAlts[x]] + " " + DBTools.getItemName(ePOSDBDataSet.tblEPOSItems, tillSelectedItems[x]));
                            } else {
                                printKitchenItemName.Add(DBTools.getItemName(ePOSDBDataSet.tblEPOSItems, tillSelectedItems[x]));
                            }
                            printKitchenItemListItems.Add(printItemSubList);
                            printKitchenItemPrintRed.Add(DBTools.getItemPrintRed(ePOSDBDataSet.tblEPOSItems, tillSelectedItems[x]));
                            printKitchenItemQuantity.Add(tillSelectedQuantity[x]);
                            printKitchenItemNotes.Add(tillSelectedNotes[x]);
                        }

                        
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

            int tableNumber = DBTools.getTableNumber(ePOSDBDataSet.tblEPOSTables, DBTools.getTableNumber(ePOSDBDataSet.tblEPOSOpenTables, openTableID));

            if (printBarItemNotes.Count > 0) {
                // Adjusting to only print newly added items
                printBarItemName.RemoveRange(0, tableItemCountOnOpen);
                printBarItemQuantity.RemoveRange(0, tableItemCountOnOpen);
                printBarItemListItems.RemoveRange(0, tableItemCountOnOpen);
                printBarItemNotes.RemoveRange(0, tableItemCountOnOpen);
                printBarItemPrintRed.RemoveRange(0, tableItemCountOnOpen);

                printCtrl.printTicket(false, username, tableNumber, printBarItemName, printBarItemQuantity, printBarItemListItems, printBarItemNotes, printBarItemPrintRed); // Print ticket to kitchen
                
            }
            if (printKitchenItemName.Count > 0) {
                // Adjusting to only print newly added items
                printKitchenItemName.RemoveRange(0, tableItemCountOnOpen);
                printKitchenItemQuantity.RemoveRange(0, tableItemCountOnOpen);
                printKitchenItemListItems.RemoveRange(0, tableItemCountOnOpen);
                printKitchenItemNotes.RemoveRange(0, tableItemCountOnOpen);
                printKitchenItemPrintRed.RemoveRange(0, tableItemCountOnOpen);

                printCtrl.printTicket(true, username, tableNumber, printKitchenItemName, printKitchenItemQuantity, printKitchenItemListItems, printKitchenItemNotes, printKitchenItemPrintRed); // Print ticket to kitchen
                
            }

            openTableID = -1; // Reset table ID to base value
            tableItemCountOnOpen = 0;
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
            int newQuantity = Convert.ToInt32(splitText[0]);
            if (newQuantity > 999) {
                tbxTillDisplay.Text = "";
                return;
            }
            if (isRefundMode) { // If in refund mode, use negative quantity
                newQuantity *= -1;
            }
            tillSelectedQuantity[listIndex] = newQuantity; // Convert the first number to a int, adjust quantity
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
            frmTablePlan frmTablePlan = new frmTablePlan(screenSize, userID, username, this); // new form instance, passing through any sub forms
            frmTablePlan.ShowDialog();// Open table plan
        }

        private void tillToggleAlts() { // Toggle to alt quantities
            int displayIndex = lbxTillDisplay.SelectedIndex;
            int listIndex = getSelectedIndex();
            if (listIndex == -1) { // If an item is selected
                return;
            }

            int selectedItemID = tillSelectedItems[listIndex];
            int itemIndex = DBTools.getItemIndex(ePOSDBDataSet.tblEPOSItems, selectedItemID);


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
            lbxTillDisplay.SelectedIndex = displayIndex;
        }

        private void tillAddNote() { // Adds notes 
            int selectedItemIndex = getSelectedIndex(); // Get the item (to add the note to)
            if (selectedItemIndex == -1) {
                return;
            }
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
            lbxTillDisplay.SelectedIndex = insertIndex;
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
            // MAJOR TODO: Allow moving tabs between tables
            // MAJOR TODO: Split bill feature

            tableItemCountOnOpen = tillSelectedItems.Count;

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
