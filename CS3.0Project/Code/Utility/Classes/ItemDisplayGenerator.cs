using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS3._0Project.Code.Sales;
using CS3._0Project.Code.Utility.Forms;

namespace CS3._0Project.Code.Utility.Classes {
    class ItemDisplayGenerator { // TODO: Finish abstracting the sales mode stuff for later use

        private frmSalesMode frmSalesMode;
        private DataTable items;
        private DataTable folders;
        private Panel pnlItemDisplay;

        private List<List<int>> sortList = new List<List<int>>();
        private List<List<int>> itemLocationList;

        private bool isItems;

        private int folderY = 20;

        private List<int> currentFolderPath = new List<int>();
        private frmMessageBox cMessageBox = new frmMessageBox();

        public ItemDisplayGenerator(frmSalesMode frmSalesMode, DataTable items, DataTable folders, Panel pnlItemDisplay) { // Constr
            this.frmSalesMode = frmSalesMode;
            this.items = items;
            this.folders = folders;
            this.pnlItemDisplay = pnlItemDisplay;
        }

        private List<List<int>> getItemFolderLocationList() { // Gets the item folders and locations and puts them in a list where it follows the schema
                                                              // [eposItemID, itemFolderID(1), itemLocaton (1), itemFolderID(2), itemLocation(2), ....] for a list of items
                                                              // (Each individual item has all the properties in the square brackets), and will be stored in the itemLocationList List.
            isItems = false; // Flag to see if there are actully items in the folder
            List<List<int>> itemLocationList = new List<List<int>>(); // Create new list when ran
            foreach (DataRow itemDataRow in items.Rows) { // For each item in the database 
                string[] itemFolderArray = itemDataRow[3].ToString().Split(','); // Get the folders that contain this item in a list
                string[] itemLocationArray = itemDataRow[4].ToString().Split(','); // Get the location in the folders for this item in a list

                if (itemFolderArray.Length != itemLocationArray.Length) { // if there are not equal items, something has gone horribly wrong
                    // TODO: Report Error
                    itemLocationList = null;
                    break;
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
            return itemLocationList;
        }

        private void sortFolderIDs() { // Sorts the list TODO: Refactor and unnest
            sortList = new List<List<int>>();
            int currentFolderID = currentFolderPath[currentFolderPath.Count - 1]; // Get the ID of the current folder
            isItems = !isFolderEmpty(currentFolderID, items);
            if (isItems) { // If there are items in the list
                List<List<int>> itemFolderLocations = new List<List<int>>(); // Create new list of int lists for the locations to sort
                List<List<int>> itemLocationList = getItemFolderLocationList();
                List<int> currentFolderIDs = getCurrentFolderItemIDs(itemLocationList, currentFolderID); // Get all the current IDs for this folder
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

        private List<int> getCurrentFolderItemIDs(List<List<int>> itemLocationList, int currentFolderID) { // Find all the items in the current folder and returns an integer list of IDs 
            List<int> currentFolderIDs = new List<int>(); // Create the list to return
            foreach (List<int> itemLocationRow in itemLocationList) { // For every item in the array
                int i = 1; // Set int to 1 to get the first FOLDER ID
                while (i < itemLocationRow.Count) { // Repeat until every other item in the list has been iterated through
                    if (itemLocationRow[i] == currentFolderID) { // If the current folder ID is equal to the iterated item
                        currentFolderIDs.Add(itemLocationRow[0]); // Add this folder to the list to display
                    }
                    i += 2; // Incremement to go through every other item
                }
            }
            return currentFolderIDs; // Return the list
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
        private void createItemButtons() { // Create a button in the group box for all items in the db table
            int itemX = 10;
            int itemY = folderY + 100;


            for (int i = 0; i < sortList.Count; i++) { // For every sorted item
                int itemId = sortList[i][0];
                foreach (DataRow itemDataRow in items.Rows) {
                    if (itemId == Convert.ToInt32(itemDataRow[0])) {
                        Button dynamicItemButton = new Button(); // Create a button
                        dynamicItemButton.Hide();
                        dynamicItemButton.Width = 100; // Assign width + height
                        dynamicItemButton.Height = 80;
                        if (Convert.ToBoolean(itemDataRow[15])) { // check to see if it is a list box button
                            dynamicItemButton.Name = "ldib" + itemDataRow[0].ToString().Trim(); // Get the ID For later use (name = ldib[ID]), for all items that are list items 
                            dynamicItemButton.Click += frmSalesMode.ListDynamicItemButton_Click;
                        } else {
                            dynamicItemButton.Name = "dib" + itemDataRow[0].ToString().Trim(); // Get the ID For later use (name = dib[ID]), for all items that are independent items and not a list
                            dynamicItemButton.Click += frmSalesMode.DynamicItemButton_Click; // Custom click event, for buttons
                        }
                        dynamicItemButton.Text = itemDataRow[1].ToString().Trim(); // Name of item
                        dynamicItemButton.Parent = pnlItemDisplay; // Put it inside the gbx
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
            }
        }

        private void createFolderButtons(Panel pnlItemDisplay, int parentFolderID) {
            // Folder Properties
            int folderX = 10;
            int folderWidth = 100;
            int folderHeight = 80;
            if (folderWidth + 20 > pnlItemDisplay.Width) { // If the gbx is too small (to contain the width of one button + padding)
                cMessageBox.ShowMessage("Screen Resolution Error"); // Error Message
                // TODO: Some form of backout sequence
            } else {
                parentFolderID = currentFolderPath[currentFolderPath.Count - 1]; // Get the parent folder
                List<int> currentFolderIDs = getFolderIDsWithParentID(parentFolderID);

                foreach (DataRow folderDataRow in folders.Rows) { // Iterate through each db table row 
                    if (currentFolderIDs.Contains(Convert.ToInt32(folderDataRow[0]))) {
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
        }
        private void DynamicFolderButton_Click(object sender, EventArgs e) { // If a folder is clicked
            pnlItemDisplay.Controls.Clear(); // Clear exitsting folders
            Button button = (Button)sender; // Assign type button to sender
            currentFolderPath.Add(Convert.ToInt32(button.Name.Substring(3, button.Name.Length - 3))); // Add the number on the name of the button, which is the folder ID and thereby the parent ID
            createButtons(); // Recreate new buttons
        }

        private void getItemFolders() { // Gets the item folders and locations and puts them in a list where it follows the schema
                                        // [eposItemID, itemFolderID(1), itemLocaton (1), itemFolderID(2), itemLocation(2), ....] for a list of items
                                        // (Each individual item has all the properties in the square brackets), and will be stored in the itemLocationList List.
            isItems = false; // Flag to see if there are actully items in the folder
            itemLocationList = new List<List<int>>(); // Create new list when ran
            foreach (DataRow itemDataRow in items.Rows) { // For each item in the database 
                string[] itemFolderArray = itemDataRow[3].ToString().Split(','); // Get the folders that contain this item in a list
                string[] itemLocationArray = itemDataRow[4].ToString().Split(','); // Get the location in the folders for this item in a list

                if (itemFolderArray.Length != itemLocationArray.Length) { // if there are not equal items, something has gone horribly wrong
                    // TODO: Report Error
                    break;
                }
                
                // The lists are equal and we can now add it to the location list
                List<int> itemLocationSubList = new List<int>(); // new sub list (for each individual items)
                itemLocationSubList.Add(Convert.ToInt32(itemDataRow[0])); // Add the item ID
                for (int i = 0; i < itemFolderArray.Length; i++) { // for each individual folder location
                    if (Convert.ToInt32(itemFolderArray[i]) == -1) { // If the item does not have a location (List or hidden item)
                        itemLocationSubList.Clear(); // Clear the list and break to the next item
                        break;
                    }
                    itemLocationSubList.Add(Convert.ToInt32(itemFolderArray[i])); // add folder ID
                    itemLocationSubList.Add(Convert.ToInt32(itemLocationArray[i])); // add location to that folder
                }
                if (itemLocationSubList.Count == 0) {
                    continue;
                }
                itemLocationList.Add(itemLocationSubList); // add to the main list
                
            }
        }

        private List<int> getFolderIDsWithParentID(int parentID) {
            List<int> foldersWithParentID = new List<int>();
            foreach(DataRow folder in folders.Rows) {
                if (Convert.ToInt32(folder[2]) == parentID) {
                    foldersWithParentID.Add(Convert.ToInt32(folder[0]));
                }
            }
            return foldersWithParentID;
        }

        private bool isFolderEmpty(int targetFolderID, DataTable items) { // Checks if the folder is empty in the given datatable
            bool isFolderEmpty = true; // default to true
            foreach (DataRow item in items.Rows) { // For every item
                if (!isFolderEmpty) { // If its already known to have items break the loop.
                    break;
                }
                string[] folders = item[3].ToString().Split(','); // Split folder string into an array
                foreach (string folder in folders) { // for every folder in the array
                    int folderID = Convert.ToInt32(folder); // Convert to int for compariosn
                    if (folderID == targetFolderID) { // If the folderID is the target
                        isFolderEmpty = false; // The folder is known to not be empty
                        break; // Break loop.
                    }
                }
            }
            return isFolderEmpty;
        }

        public void folderBack() {
            if (currentFolderPath.Count > 1) { // If it is not the base directory
                pnlItemDisplay.Controls.Clear(); // Clear existing folders
                currentFolderPath.RemoveAt(currentFolderPath.Count - 1); // Remove last folder path (like a back button)
                createButtons(); // Recreate the new buttons
            } // else do nothing 
        }

        public void createButtons() {
            if (currentFolderPath.Count == 0) {
                currentFolderPath.Add(0);
            }
            // TODO: Stop loads from appearing if you put two of the same item in the same folder.
            getItemFolders(); // Seperates the CSV fields in the db into lists
            sortFolderIDs(); // Sort the items based on their location setting

            createFolderButtons(pnlItemDisplay, currentFolderPath[currentFolderPath.Count - 1]); // Create folders buttons on load

            createItemButtons(); // Create buttons on form load

        }
    }
}
