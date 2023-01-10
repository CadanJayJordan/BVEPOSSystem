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

namespace CS3._0Project.Code.Sales {
    public partial class frmSalesMode : Form {

        private Size screenSize;
        private int loginCode;

        private bool isRefundMode; // TODO: Make refun mode work
        private List<int> currentFolderPath = new List<int>(); // Current Folder Path
                              
        private int folderY; // Folder y so we can put the items under the folders
        private int parentFolder = 0; // Default Parent

        // FOR ITEM DISPLAYING AND SORTING
        private List<List<int>> itemLocationList;
        private List<List<int>> sortList;
        private bool isItems;

        // FOR ITEM DISPLAY AND CALC
        private List<int> tillSelectedItems = new List<int>();
        private List<int> tillSelectedQuantity = new List<int>();
        decimal tillTotal = 0.0m;
        decimal chequeDeductions = 0.0m;
        decimal cashAmount = 0.0m;
        private bool isListBoxLocked = false;
        private bool usingCustomAmount = false;

        // FOR TABLE OPENING


        private frmMessageBox cMessageBox = new frmMessageBox(); // Custom message box

        public frmSalesMode(Size size, int loginCode, bool isRefundMode) {
            InitializeComponent();
            this.screenSize = size;
            this.loginCode = loginCode;
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
            this.tblEPOSCashChequesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSCashCheques);
            this.tblEPOSItemPriceTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemPrice);
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);
            this.tblEPOSItemFoldersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemFolders);
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);
            this.tblEPOSCashChequesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSCashCheques);

            currentFolderPath.Add(0); // Ensure the base directory is always set
            createButtons();

            //TODO: FUNCTION
            tbxTillDisplay.Clear();
            lbxTillDisplay.Items.Clear();
            tbxTillTotal.Clear();
        }

        private void createButtons() {
            tblEPOSItemsTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSItems.*" +
                "\nFROM tblEPOSItems;"; // Reset the table adaptor to ensure no querys are taking place
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);

            // TODO: Make DB follow 1st standard form. Have a seperate table linking folders and items to avoid this mess
            // TODO: Stop loads from appearing if you put two of the same item in the same folder.
            getItemFolders(); // Seperates the CSV fields in the db into lists
            sortFolderIDs(); // Sort the items based on their location setting

            createFolderButtons(); // Create folders buttons on load

            createItemButtons(); // Create buttons on form load

            AllowButtonClick(pnlTillDisplay); // Allow all buttons in the till display to be clicked

        }

        private void createItemButtons() { // Create a button in the group box for all items in the db table
            int itemX = 10;
            int itemY = folderY + 100;


            for (int i = 0; i < sortList.Count; i++) { // For every sorted item
                string itemId = sortList[i][0].ToString();
                tblEPOSItemsTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSItems.*\n" +
                    "FROM tblEPOSItems\n" +
                    "WHERE (((tblEPOSItems.eposItemID)= " + itemId + "));"; // Query the DB for that item ID
                    this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);

                DataRow itemDataRow = ePOSDBDataSet.tblEPOSItems.Rows[0]; // Get the 1 (hopefully) data row returned from the DB query

                Button dynamicItemButton = new Button(); // Create a button
                dynamicItemButton.Hide();
                dynamicItemButton.Width = 100; // Assign width + height
                dynamicItemButton.Height = 80;
                dynamicItemButton.Name = "dib" + itemDataRow[0].ToString().Trim(); // Get the ID For later use (name = dib[ID])
                dynamicItemButton.Text = itemDataRow[1].ToString().Trim(); // Name of item
                dynamicItemButton.Parent = pnlItemDisplay; // Put it inside the gbx
                dynamicItemButton.Click += DynamicItemButton_Click; // Custom click event
                dynamicItemButton.ForeColor = Color.White; // Change text colour
                if ((itemX + dynamicItemButton.Width + 10) > pnlItemDisplay.Width) { // If the items go off the right hand side of the gbx
                    itemY += 100; // Move item down
                    itemX = 10; // reset the x coordinate
                }
                dynamicItemButton.Location = new Point(itemX, itemY); // Set location
                dynamicItemButton.Show();
                itemX += 110; // To stop items overflowing
            }
        }

        private void getItemFolders() { // Gets the item folders and locations and puts them in a list where it follows the schema
                                        // [eposItemID, itemFolderID(1), itemLocaton (1), itemFolderID(2), itemLocation(2), ....] for a list of items
                                        // (Each individual item has all the properties in the square brackets), and will be stored in the itemLocationList List.
            isItems = false; // Flag to see if there are actully items in the folder
            itemLocationList = new List<List<int>>(); // Create new list when ran
            foreach(DataRow itemDataRow in this.ePOSDBDataSet.tblEPOSItems) { // For each item in the database 
                string[] itemFolderArray = itemDataRow[3].ToString().Split(','); // Get the folders that contain this item in a list
                string[] itemLocationArray = itemDataRow[4].ToString().Split(','); // Get the location in the folders for this item in a list

                if (itemFolderArray.Length != itemLocationArray.Length) { // if there are not equal items, something has gone horribly wrong
                    // TODO: Report Error

                } else { // The lists are equal and we can now add it to the location list
                    List<int> itemLocationSubList = new List<int>(); // new sub list (for each individual items)
                    itemLocationSubList.Add(Convert.ToInt32(itemDataRow[0])); // Add the item ID
                    for (int i = 0; i < itemFolderArray.Length; i++) { // for each individual folder location
                        itemLocationSubList.Add(Convert.ToInt32(itemFolderArray[i])); // add folder ID
                        itemLocationSubList.Add(Convert.ToInt32(itemLocationArray[i])); // add location to that folder
                    }
                    itemLocationList.Add(itemLocationSubList); // add to the main list
                }
            }
        }

        private List<int> getCurrentFolderItemIDs(int currentFolderID) { // Find all the items in the current folder and returns an integer list of IDs 
            List<int> currentFolderIDs = new List<int>(); // Create the list to return
            foreach(List<int> itemLocationRow in itemLocationList) { // For every item in the array
                int i = 1; // Set int to 1 to get the first FOLDER ID
                while(i < itemLocationRow.Count) { // Repeat until every other item in the list has been iterated through
                    if (itemLocationRow[i] == currentFolderID) { // If the current folder ID is equal to the iterated item
                        currentFolderIDs.Add(itemLocationRow[0]); // Add this folder to the list to display
                        isItems = true;
                    }
                    i += 2; // Incremement to go through every other item
                }
            }
            return currentFolderIDs; // Return the list
        }

        private void sortFolderIDs() { // Sorts the list 
            sortList = new List<List<int>>();
            int currentFolderID = currentFolderPath[currentFolderPath.Count - 1]; // Get the ID of the current folder
            List<int> currentFolderIDs = getCurrentFolderItemIDs(currentFolderID); // Get all the current IDs for this folder
            if (isItems) { // If there are items in the list
                List<List<int>> itemFolderLocations = new List<List<int>>(); // Create new list of int lists for the locations to sort
                foreach (List<int> itemLocationRow in itemLocationList) { // For all item locations
                    for (int i = 0; i < currentFolderIDs.Count; i++) { // For every ID of an item in the current folder
                        if (itemLocationRow[0] == currentFolderIDs[i]) { // If there are ID matches
                            int x = 1; // Set int to 1 to get the first FOLDER ID
                            while (x < itemLocationRow.Count) { // Repeat until every other item in the list has been iterated through
                                if (itemLocationRow[x] == currentFolderID) { // If the current folder ID is equal to the iterated item
                                    List<int> itemFolderLocationSubList = new List<int>(); // Create a new list to add to the current list
                                    itemFolderLocationSubList.Add(itemLocationRow[0]); // Add ID
                                    itemFolderLocationSubList.Add(itemLocationRow[x + 1]); // Add location
                                    itemFolderLocations.Add(itemFolderLocationSubList); // Add to the locations to sort
                                }
                                x += 2; // Incremement to go through every other item (Refer to getItemFolders() to see why)
                            }
                        }
                    }
                }
                sortList = itemFolderLocations;  // Create a copy of this list to sort
                qSort(0, sortList.Count - 1); // Perform the sort on the sort list (Quicksort)
            }
        }

        //QUICK SORT
        private void qSort(int start, int end) { // start & end are list dimensions
            // Variable Init
            List<int> tempSwapIntList;
            int LIP = start;
            int HIP = end;
            int MIPVal = sortList[Convert.ToInt32((end + start) / 2)][1];
            // Repeat
            while (!(LIP > HIP)) {
                // Finding items on the wrong side of hte MIP
                while (sortList[LIP][1] < MIPVal) {
                    LIP++;
                }
                while (MIPVal < sortList[HIP][1]) {
                    HIP--;
                }
                // Swap if either one pointer hits the middle, or both have an item on the wrong side.
                if (LIP <= HIP) {
                    // Perform Swap
                    tempSwapIntList = sortList[LIP];
                    sortList[LIP] = sortList[HIP];
                    sortList[HIP] = tempSwapIntList;
                    LIP++;
                    HIP--;
                }
            }
            // Recurison
            if (start < HIP) {
                qSort(LIP, end);
            }
            if (LIP < end) {
                qSort(start, HIP);
            }
        }



        private void createFolderButtons() {
            // Folder Properties
            int folderX = 10;
            folderY = 20;
            int folderWidth = 100;
            int folderHeight = 80;
            if (folderWidth + 20 > pnlItemDisplay.Width) { // If the gbx is too small (to contain the width of one button + padding)
                cMessageBox.ShowMessage("Screen Resolution Error"); // Error Message
                // TODO: Some form of backout sequence
            } else {
                parentFolder = currentFolderPath[currentFolderPath.Count - 1]; // Get the parent folder

                tblEPOSItemFoldersTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSItemFolders.itemFolderID, tblEPOSItemFolders.itemFolderName, tblEPOSItemFolders.parentFolderID, tblEPOSItemFolders.itemFolderLocation\n" +
                        "FROM tblEPOSItemFolders\n" +
                        "WHERE(((tblEPOSItemFolders.parentFolderID) = " + parentFolder + "))\n" +
                        "ORDER BY tblEPOSItemFolders.itemFolderLocation;"; // Query for all folders in the parent folder, and sorts by the location (so they will be displayed in any specified order)
                this.tblEPOSItemFoldersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemFolders); // Pull the query from the DB

                foreach (DataRow folderDataRow in this.ePOSDBDataSet.tblEPOSItemFolders) { // Iterate through each db table row 
                    Button dynamicFolderButton = new Button(); // Create a new button   
                    dynamicFolderButton.Hide(); // Hide (to avoid funky buisness happening)
                    dynamicFolderButton.Width = folderWidth; // Assign width + height
                    dynamicFolderButton.Height = folderHeight;
                    dynamicFolderButton.Name = "dfb" + folderDataRow[0].ToString().Trim(); // Set name based on its DB ID for later use
                    dynamicFolderButton.Text = folderDataRow[1].ToString().Trim(); // Get the display text to be the DB Name
                    dynamicFolderButton.Parent = pnlItemDisplay; // Assign parent
                    dynamicFolderButton.Click += DynamicFolderButton_Click; // Assign the custom click event
                    dynamicFolderButton.ForeColor = Color.White; // Change text colour
                    if ((folderX + dynamicFolderButton.Width + 10) > pnlItemDisplay.Width) { // If the folders go off the right hand side of the gbx
                        folderY += 100; // Move folder down
                        folderX = 10; // reset the x coordinate
                    }
                    dynamicFolderButton.Location = new Point(folderX, folderY); // Assign its location
                    folderX += 110; // Shift each folder along as not to overlap
                    dynamicFolderButton.Show();
                }
            }
        }

        private void DynamicFolderButton_Click(object sender, EventArgs e) { // If a folder is clicked
            pnlItemDisplay.Controls.Clear(); // Clear exitsting folders
            Button button = (Button)sender; // Assign type button to sender
            currentFolderPath.Add(Convert.ToInt32(button.Name.Substring(3, button.Name.Length - 3))); // Add the number on the name of the button, which is the folder ID and thereby the parent ID
            createButtons(); // Recreate new buttons
        }
        private void btnFolderBack_Click(object sender, EventArgs e) {
            if (currentFolderPath.Count > 1) { // If it is not the base directory
                pnlItemDisplay.Controls.Clear(); // Clear existing folders
                currentFolderPath.RemoveAt(currentFolderPath.Count - 1); // Remove last folder path (like a back button)
                createButtons(); // Recreate the new buttons
            } // else do nothing 
        }

        private void DynamicItemButton_Click(object sender, EventArgs e) { // If a button is clicked
            Button button = (Button)sender; // Cast the sender to a button
            int itemID = Convert.ToInt32(button.Name.Substring(3, button.Name.Length - 3)); // Get the itemID which is stored as part of the button name
            
            tillSelectedItems.Add(itemID); // Add the itemID to the list
            tillSelectedQuantity.Add(1);

            if (isListBoxLocked) {
                changeListLock();
            }

            updateTotal();
            updateTillList();
        }

        private void updateTotal() {
            
            tillTotal = 0;

            // TODO: Remove query for quicker access
            for (int i = 0; i < tillSelectedItems.Count; i++) {
                tblEPOSItemPriceTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSItemPrice.*\n" +
                    "FROM tblEPOSItemPrice" +
                    "\nWHERE (((tblEPOSItemPrice.eposItemID)=" + tillSelectedItems[i] + "));"; // Query the DB for that item ID to get associated prices
                this.tblEPOSItemPriceTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemPrice); // Fill datatable
                tillTotal += tillSelectedQuantity[i] * Convert.ToDecimal(this.ePOSDBDataSet.tblEPOSItemPrice.Rows[0][2]); // Get the total an add it to the total
            }
            updateTotalDisplay(tillTotal);
        }

        private void updateTotalDisplay(decimal total) {
            tbxTillTotal.Text = "Total: £" + total.ToString("0.00");
        }

        private void updateTillList() {
            lbxTillDisplay.Items.Clear();
            for (int i = 0; i < tillSelectedItems.Count; i++) {
                // TODO: Find quicker way to do the acquring of price and name, or maybe dont update if the items are already on the screen
                tblEPOSItemPriceTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSItemPrice.*\n" +
                    "FROM tblEPOSItemPrice" +
                    "\nWHERE (((tblEPOSItemPrice.eposItemID)=" + tillSelectedItems[i].ToString() + "));"; // Query the DB for that item ID to get associated prices
                this.tblEPOSItemPriceTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemPrice); // Fill datatable

                tblEPOSItemsTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSItems.*\n" +
                    "FROM tblEPOSItems\n" +
                    "WHERE (((tblEPOSItems.eposItemID)= " + tillSelectedItems[i].ToString() + "));"; // Query the DB for that item ID
                this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems); // Fill datatable

                string itemName = ePOSDBDataSet.tblEPOSItems.Rows[0][1].ToString(); // Get the item name
                decimal quantity = tillSelectedQuantity[i];
                string itemPrice = String.Format("£{0}", (Convert.ToDecimal(ePOSDBDataSet.tblEPOSItemPrice.Rows[0][2]) * quantity).ToString("0.00")); // Get the item price and format it to be (£x.xx)

                String displayString = String.Format("{0, -4}{1}{2," + (36 - itemName.Length - 4) + "}", quantity.ToString(), itemName, itemPrice); // Format the display string to be <qty><name><price> with adequete spacing

                lbxTillDisplay.Items.Add(displayString); // Add each item to the db 
                }
        }
        private void AllowButtonClick(Control ctrl) { // Findng buttons to read text of on click
            foreach (Control subctrl in ctrl.Controls) { // Get each control in the form
                if (subctrl.GetType() == typeof(GroupBox) || subctrl.GetType() == typeof(Panel)) { // if the control is a group box or panel, enter the method again
                    AllowButtonClick(subctrl); // Recursion
                } else if (subctrl.GetType() == typeof(Button)) { // If a button is found, allow the event to be used.
                    subctrl.Click += OnTillButtonClick;
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
                case ("Error Correct"): // If error correct button is clicked
                    tillErrorCorrect();
                    break;
                case ("Cancel"): // If cancel button is clicked
                    tillCancel();
                    break;
                case ("Table Store"): // If table store button is clicked
                    tillTableStore();
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

        private void tillFinish(bool isByCard) { // Till finialisation 
            if (!isListBoxLocked) { // If the list box is unlocked
                if (lbxTillDisplay.Items.Count > 0) { // And has items in it
                    // Declare all items to be put into datatable 
                    int userID = 999; // TODO: User from table
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
                            itemsOnCheque += String.Format("{0},{1};", itemID.ToString(), quantity.ToString()); // Add them to the cheque string
                        }

                        tblEPOSCashChequesTableAdapter.Fill(ePOSDBDataSet.tblEPOSCashCheques); // Pull information to keep DB sync
                        DataTable cashedCheques = ePOSDBDataSet.tblEPOSCashCheques; // Gets the dataTable
                        cashedCheques.Rows.Add(); // Adds a new row
                        int lastRowIndex = cashedCheques.Rows.Count - 1; // Finds the index of the last (new) row

                        // Input all data into the new row
                        cashedCheques.Rows[lastRowIndex][1] = userID;
                        cashedCheques.Rows[lastRowIndex][2] = cashedTime;
                        cashedCheques.Rows[lastRowIndex][3] = itemsOnCheque;
                        cashedCheques.Rows[lastRowIndex][4] = chequeDeductions;
                        cashedCheques.Rows[lastRowIndex][5] = cashAmount;

                        tblEPOSCashChequesTableAdapter.Update(ePOSDBDataSet.tblEPOSCashCheques); // Push updates to DB
                        
                        tillSelectedItems.Clear(); // Clear the list of selected items
                        tillSelectedQuantity.Clear();

                        MessageBox.Show(userID + "\n" + cashedTime + "\n" + itemsOnCheque + "\n" + chequeDeductions + "\n" + cashAmount);

                        chequeDeductions = 0; // reset for next sale
                        cashAmount = 0;
                    } // else do nothing
                }
            }
        }

        private void tillErrorCorrect() { // Till error correction
            if (!isListBoxLocked) { // Only do so if list box is unlocked
                if (lbxTillDisplay.SelectedItem != null) { // Assuming an item is selected 
                    int selectedItemIndex = lbxTillDisplay.SelectedIndex; // Get the selected index 
                    int itemID = tillSelectedItems[selectedItemIndex]; // get the slected item ID

                    tblEPOSItemPriceTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSItemPrice.*\n" +
                            "FROM tblEPOSItemPrice" +
                            "\nWHERE (((tblEPOSItemPrice.eposItemID)=" + itemID + "));"; // Query the DB for that item ID to get associated prices
                    this.tblEPOSItemPriceTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemPrice); // Fill datatable

                    decimal itemPrice = Convert.ToDecimal(ePOSDBDataSet.tblEPOSItemPrice.Rows[0][2]); // Get the item price

                    lbxTillDisplay.Items.RemoveAt(selectedItemIndex); // Remove item from list box
                    tillSelectedItems.RemoveAt(selectedItemIndex); // remove item from list
                    tillSelectedQuantity.RemoveAt(selectedItemIndex); // Remove quantity

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
                lbxTillDisplay.ClearSelected(); // Clear any selected index to ensure nothing can be editied
                changeListLock(); // Lock list
                updateTotal(); // Update the total value
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

        private void btnTablePlan_Click(object sender, EventArgs e) {
            frmTablePlan frmTablePlan = new frmTablePlan(screenSize, this);
            frmTablePlan.ShowDialog();
        } 

        public void openTable(List<int> tableSelectedTillItems, List<int> tableSelectedTillQuantity) { // New code to open a table externally using an int list of the selected item IDs
            this.tillSelectedItems = tableSelectedTillItems;
            this.tillSelectedQuantity = tableSelectedTillQuantity;

            if (isListBoxLocked) { // If the table is locked 
                changeListLock();
            }

            updateTotal();
            updateTillList();
        }

        private void tillTableStore() {

        }
    }
}
