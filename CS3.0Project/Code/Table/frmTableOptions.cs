﻿using CS3._0Project.Code.Sales;
using CS3._0Project.Forms.Utility.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CS3._0Project.Forms.Utility;
using CS3._0Project.Code.Utility.Classes;

namespace CS3._0Project.Code.Table {
    public partial class frmTableOptions : Form {

        private int tableID;
        private int userID;
        private bool editMode;
        private frmSalesMode frmSalesMode;
        private frmTablePlan frmTablePlan;
        private DBTools DBTools = new DBTools();

        // TODO: Cost on open tables?

        public frmTableOptions(int userID, frmSalesMode frmSalesMode, frmTablePlan frmTablePlan, bool editMode) {
            InitializeComponent();
            new ControlDragger(this, true, false); // Enable dragging
            this.frmSalesMode = frmSalesMode;
            this.frmTablePlan = frmTablePlan;
            this.userID = userID;
            this.editMode = editMode;
        }

        public frmTableOptions(int userID, frmTablePlan frmTablePlan, bool editMode) {
            InitializeComponent();
            new ControlDragger(this, true, false); // Enable dragging
            this.editMode = editMode;
            this.frmTablePlan = frmTablePlan;
            this.userID = userID;
        }

        public void updateTableInfo(int tableID) {
            this.tableID = tableID; // Update table ID
            updateForm();
        }

        private void frmTableOptions_Load(object sender, EventArgs e) {
            // Fill adapters on form load
            this.tblEPOSItemPriceTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemPrice);
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);
            this.tblEPOSUsersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSUsers);
            this.tblEPOSTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSTables); 
            this.tblEPOSOpenTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSOpenTables);

            if (editMode) { // Show buttons according to weather we are editing the tables or using the tables
                btnOpen.Visible = false;
                btnBill.Visible = false;
                btnAdd.Visible = true;
                btnRemove.Visible = true;
                btnNumber.Visible = true;
            } else {
                btnOpen.Visible = true;
                btnBill.Visible = true;
                btnAdd.Visible = false;
                btnRemove.Visible = false;
                btnNumber.Visible = false;
            }
        }

        private void frmTableOptions_Shown(object sender, EventArgs e) {
            updateForm(); // On show ensure the table info is correct for what is selected
        }

        private void updateForm() {
            foreach (DataRow table in ePOSDBDataSet.tblEPOSTables) {  // for each table
                if (Convert.ToInt32(table[0]) == tableID) { // if the current table is the same as the db row
                    txtOptionsDisplay.Text = String.Format("Table: {0}", table[1].ToString()); // update the text
                    if (isTableOpen(tableID)) { // If the table is open, add open to the table properties
                        txtOptionsDisplay.Text += String.Format(System.Environment.NewLine + "Open");
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) { // Closes form on close button press
            this.Hide(); // Hides the form
        }

        private void btnOpen_Click(object sender, EventArgs e) { // On table open
            if (editMode) {
                return;
            }
            List<int> selectedTillItems = new List<int>(); // Create item and quantity lists
            List<int> selectedTillQuantity = new List<int>();
            List<int> selectedTillAlts = new List<int>();
            List<List<List<int>>> selectedTillListItems = new List<List<List<int>>>();
            List<string> selectedTillNotes = new List<string>();
            List<int> tillDisplayCopy = new List<int>();
            int openTableID = 0;
            if (isTableOpen(tableID)) { // If table is already open, load the table into the array
                tblEPOSOpenTablesTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSOpenTables.*\r\nFROM tblEPOSOpenTables\r\nWHERE (((tblEPOSOpenTables.openTableNumber)=" + tableID.ToString() + "));\r\n";
                this.tblEPOSOpenTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSOpenTables); // Fill table with tableID

                string tableItemString = ePOSDBDataSet.tblEPOSOpenTables[0][2].ToString(); // Get the table store string
                string[] tableItemList = tableItemString.Split(';'); // Get the item lists
                openTableID = Convert.ToInt32(ePOSDBDataSet.tblEPOSOpenTables[0][0]);

                foreach (string tableItem in tableItemList) { // For every item
                    if (tableItem != "") {
                        string[] tableArray = tableItem.Split(','); // Split the quantity and items
                        selectedTillItems.Add(Convert.ToInt32(tableArray[0])); // Add items to item array
                        selectedTillQuantity.Add(Convert.ToInt32(tableArray[1])); // Add quantity to qauntity array
                        selectedTillAlts.Add(Convert.ToInt32(tableArray[2])); // Add quantity to qauntity array
                        selectedTillNotes.Add(tableArray[4]); // Add notes to note array;
                        tillDisplayCopy.Add(Convert.ToInt32(tableArray[0]));

                        string[] listItems = tableArray[3].Split(':'); // For the list items, split each indiviual item up
                        List<List<int>> selectedListItems = new List<List<int>>();
                        foreach (string listItem in listItems) { // For every itme in an item
                            if (listItem != "") {
                                string[] listItemSplit = listItem.Split('.'); // Split into listID and itemID
                                List<int> selectedListItem = new List<int>(); // Create sub list
                                selectedListItem.Add(Convert.ToInt32(listItemSplit[0])); // Add Items
                                selectedListItem.Add(Convert.ToInt32(listItemSplit[1]));
                                selectedListItems.Add(selectedListItem);
                                tillDisplayCopy.Add(0); // Add Display int
                            }
                        }
                        selectedTillListItems.Add(selectedListItems); // Add to list items

                        if (tableArray[4] != "") { // If there is a note

                            tillDisplayCopy.Add(-1); // Add the note int to the display copy
                        }

                    }
                }
            } else { // If table is not already open, open it with fresh arrays
                tblEPOSOpenTablesTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSOpenTables.*\r\nFROM tblEPOSOpenTables;";
                this.tblEPOSOpenTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSOpenTables); // Fill table

                DataTable openTablesTable = ePOSDBDataSet.tblEPOSOpenTables;
                openTablesTable.Rows.Add(); // Add new row
                int lastRowIndex = openTablesTable.Rows.Count - 1; // Get index of new row

                // Add data to new row
                openTablesTable.Rows[lastRowIndex][1] = tableID;
                openTablesTable.Rows[lastRowIndex][2] = "";
                openTablesTable.Rows[lastRowIndex][3] = false;
                openTablesTable.Rows[lastRowIndex][4] = userID;

                tblEPOSOpenTablesTableAdapter.Update(ePOSDBDataSet.tblEPOSOpenTables); // Update table with new row
                this.tblEPOSOpenTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSOpenTables); // Fill table
                openTableID = Convert.ToInt32(ePOSDBDataSet.tblEPOSOpenTables.Rows[lastRowIndex][0]); // Get new table ID
            }

            frmSalesMode.openTable(selectedTillItems, selectedTillQuantity, selectedTillAlts, selectedTillListItems, selectedTillNotes, tillDisplayCopy, openTableID); // Open a table in the till view
            this.Hide(); // Hide this form
            frmTablePlan.Hide(); // Hide the table plan
            
        }

        public bool isTableOpen(int tableID) {
            bool isTableOpen = false;
            this.tblEPOSOpenTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSOpenTables); // Fill table
            tblEPOSOpenTablesTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSOpenTables.*\r\nFROM tblEPOSOpenTables;";
            this.tblEPOSOpenTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSOpenTables); // Fill table
            foreach (DataRow openTable in ePOSDBDataSet.tblEPOSOpenTables) { // For all open tables
                if (Convert.ToInt32(openTable[1]) == tableID) { // if there is a table match
                    isTableOpen = true; // the table is open
                    break;
                } // else there is no match, table is not open
            }
            return isTableOpen; // Return value
        }

        private void btnBill_Click(object sender, EventArgs e) {
            if (!isTableOpen(tableID)) {
                return;
            }// If table is already open, load the table into the array

            List<int> selectedTillItems = new List<int>(); // Create item and quantity lists
            List<int> selectedTillQuantity = new List<int>();
            List<int> selectedTillAlts = new List<int>();
            List<List<List<int>>> selectedTillListItems = new List<List<List<int>>>();
            List<string> selectedTillNotes = new List<string>();
            int openTableID = 0;

            tblEPOSOpenTablesTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSOpenTables.*\r\nFROM tblEPOSOpenTables\r\nWHERE (((tblEPOSOpenTables.openTableNumber)=" + tableID.ToString() + "));\r\n";
            this.tblEPOSOpenTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSOpenTables); // Fill table with tableID

            string tableItemString = ePOSDBDataSet.tblEPOSOpenTables[0][2].ToString(); // Get the table store string
            string[] tableItemList = tableItemString.Split(';'); // Get the item lists
            openTableID = Convert.ToInt32(ePOSDBDataSet.tblEPOSOpenTables[0][0]);

            foreach (string tableItem in tableItemList) { // For every item
                if (tableItem != "") {
                    string[] tableArray = tableItem.Split(','); // Split the quantity and items
                    selectedTillItems.Add(Convert.ToInt32(tableArray[0])); // Add items to item array
                    selectedTillQuantity.Add(Convert.ToInt32(tableArray[1])); // Add quantity to qauntity array
                    selectedTillAlts.Add(Convert.ToInt32(tableArray[2])); // Add quantity to qauntity array
                    selectedTillNotes.Add(tableArray[4]); // Add notes to note array;

                    string[] listItems = tableArray[3].Split(':'); // For the list items, split each indiviual item up
                    List<List<int>> selectedListItems = new List<List<int>>();
                    foreach (string listItem in listItems) { // For every itme in an item
                        if (listItem != "") {
                            string[] listItemSplit = listItem.Split('.'); // Split into listID and itemID
                            List<int> selectedListItem = new List<int>(); // Create sub list
                            selectedListItem.Add(Convert.ToInt32(listItemSplit[0])); // Add Items
                            selectedListItem.Add(Convert.ToInt32(listItemSplit[1]));
                            selectedListItems.Add(selectedListItem);
                        }
                    }
                    selectedTillListItems.Add(selectedListItems); // Add to list items
                }
            }

            // Format into printable items
            List<string> printItemName = new List<string>();
            List<List<string>> printItemListItems = new List<List<string>>();
            List<decimal> printItemPrice = new List<decimal>();

            for(int i = 0; i < selectedTillItems.Count; i++) { // For each item
                if (selectedTillAlts[i] > 0) { // Get name based on if it is an alt or not
                    printItemName.Add(ePOSDBDataSet.tblEPOSItems.Rows[DBTools.getItemIndex(ePOSDBDataSet.tblEPOSItems, selectedTillItems[i])][10 + selectedTillAlts[i]] + " " + DBTools.getItemName(ePOSDBDataSet.tblEPOSItems, selectedTillItems[i]));
                } else {
                    printItemName.Add(DBTools.getItemName(ePOSDBDataSet.tblEPOSItems, selectedTillItems[i]));
                }
                // Add item price
                printItemPrice.Add(Convert.ToDecimal(ePOSDBDataSet.tblEPOSItemPrice.Rows[DBTools.getPriceIndex(ePOSDBDataSet.tblEPOSItemPrice, selectedTillItems[i])][2 + selectedTillAlts[i]]));

                List<string> printItemSubList = new List<string>();

                foreach (List<int> selectedItem in selectedTillListItems[i]) { // Get list items
                    printItemSubList.Add(DBTools.getItemName(ePOSDBDataSet.tblEPOSItems, selectedItem[1])); // Add list item
                    printItemPrice.Add(Convert.ToDecimal(ePOSDBDataSet.tblEPOSItemPrice.Rows[DBTools.getPriceIndex(ePOSDBDataSet.tblEPOSItemPrice, selectedItem[1])][2])); // Add price

                }
                printItemListItems.Add(printItemSubList);
            }
            // Initate the print
            PrintController printCtrl = new PrintController();
            printCtrl.printBill(DBTools.getUsername(ePOSDBDataSet.tblEPOSUsers, userID), DBTools.getTableNumber(ePOSDBDataSet.tblEPOSTables, tableID), printItemName, selectedTillQuantity, printItemListItems, selectedTillNotes, printItemPrice);
        }

        private void btnNumber_Click(object sender, EventArgs e) { // Change table number (not ID)
            frmTablePlan.updateTables(); // Update tables to ensure nothing is moved when editing numbers

            tblEPOSTablesTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSTables.*\r\nFROM tblEPOSTables;";
            tblEPOSTablesTableAdapter.Fill(ePOSDBDataSet.tblEPOSTables); // Get DB Table

            // TODO: Start with existing number in the num pad
            frmNumPad numPad = new frmNumPad();
            numPad.ShowDialog();
            string input = numPad.getInput();
            int newTableNum = -1;
            if (input != "") {
                newTableNum = Convert.ToInt32(input);
            }

            foreach(DataRow table in ePOSDBDataSet.tblEPOSTables) { // For each table
                if (Convert.ToInt32(table[0]) == tableID) { // Find the table matching the seleceted table
                    if (newTableNum != -1) { // if the table num is not null
                        table[1] = newTableNum; // Set new table num
                    }
                }
            }
            tblEPOSTablesTableAdapter.Update(ePOSDBDataSet.tblEPOSTables); // Update DB
            frmTablePlan.drawTables(); // Redraw tables
        }

        private void btnRemove_Click(object sender, EventArgs e) { // TODO: error if open
            if (!isTableOpen(tableID)) { // If the table is not open
                frmTablePlan.updateTables(); // Update tables to ensure nothing is wrong when removed
                tblEPOSTablesTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSTables.*\r\nFROM tblEPOSTables;";
                tblEPOSTablesTableAdapter.Fill(ePOSDBDataSet.tblEPOSTables); // Get DB Table
                foreach (DataRow table in ePOSDBDataSet.tblEPOSTables) { // For every table
                    if (Convert.ToInt32(table[0]) == tableID) { // If a table ID match is found
                        table.Delete();
                    }
                }
                tblEPOSTablesTableAdapter.Update(ePOSDBDataSet.tblEPOSTables);
                ePOSDBDataSet.tblEPOSTables.AcceptChanges();
                frmTablePlan.drawTables(); // Draw tables again to remove table
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) { // Add new table
            frmTablePlan.updateTables(); // Update tables to ensure concurrency

            tblEPOSTablesTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSTables.*\r\nFROM tblEPOSTables;";
            tblEPOSTablesTableAdapter.Fill(ePOSDBDataSet.tblEPOSTables); // Get DB Table

            DataTable tables = ePOSDBDataSet.tblEPOSTables; // Gets the dataTable
            tables.Rows.Add(); // Adds a new row
            int lastRowIndex = tables.Rows.Count - 1; // Finds the index of the last (new) row
            DataRow lastRow = tables.Rows[lastRowIndex];
            // Insert data into DB
            lastRow[1] = 0; // Table Number (Not id)
            lastRow[2] = frmTablePlan.currentFloorID; // Current Flooor ID
            lastRow[3] = 100; // Table X location
            lastRow[4] = 100; // Table Y Location
            lastRow[5] = 100; // Table Width
            lastRow[6] = 100; // Table Height

            tblEPOSTablesTableAdapter.Update(lastRow); // Update DB
            frmTablePlan.drawTables(); // Draw tables again to add new table
        }

        
    }
}
