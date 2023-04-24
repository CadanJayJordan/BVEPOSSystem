using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3._0Project.Code.Utility.Classes {
    class DBTools {

        private int userID = 0;
        private string username = "";

        public DBTools() {
        }

        public string getUsername(DataTable tblEPOSUsers, int userID) { // Gets UserID, returns an empty string if not found
            string username = "";
            if (userID == this.userID) {
                username = this.username;
            } else {
                foreach (DataRow user in tblEPOSUsers.Rows) {
                    if (Convert.ToInt32(user[0]) != userID) {
                        continue;
                    }
                    username = user[1].ToString();
                    this.username = username;
                    break;
                }
            }
            return username;
        }

        public int getPriceIndex(DataTable tblEPOSItemPrice, int itemID) { // Returns the price index from the item ID
            int priceIndex = -1;
            for (int i = 0; i < tblEPOSItemPrice.Rows.Count; i++) { // iterate through the itemPrices
                if (itemID == Convert.ToInt32(tblEPOSItemPrice.Rows[i][1])) { // If the price equals the ID
                    priceIndex = i; // Return the index
                    break;
                }
            }
            return priceIndex;
        }

        public int getItemIndex(DataTable tblEPOSItems, int itemID) { // Returns the index of the item from the item ID
            int itemIndex = -1;
            for (int i = 0; i < tblEPOSItems.Rows.Count; i++) { // iterate through the items
                if (itemID == Convert.ToInt32(tblEPOSItems.Rows[i][0])) { // if there is an ID match
                    itemIndex = i; // Return the index
                    break;
                }
            }
            return itemIndex;
        }

        public int getListItemID(DataTable tblEPOSItems, int itemID) {
            int listItemID = 0;
            foreach (DataRow itemRow in tblEPOSItems.Rows) { // If the row contains the item ID
                if (Convert.ToInt32(itemRow[0]) == itemID) {
                    listItemID = Convert.ToInt32(itemRow[14]); // Return list Item ID
                    break;
                }
            }
            return listItemID;
        }

        public decimal getListItemPrice(DataTable tblEPOSItemPrice, List<int> selectedItemList) {
            if (selectedItemList.Count == 0) { // If the ITEM ID is 0 (no list item associated to this selection) then just return 0
                return 0;
            } // Otherwise get the item price from the DB table
            decimal listItemPrice;
            int itemID = selectedItemList[1];
            int priceIndex = getPriceIndex(tblEPOSItemPrice, itemID);
            listItemPrice = Convert.ToDecimal(tblEPOSItemPrice.Rows[priceIndex][2]);
            return listItemPrice;
        }

        public int getUserIndex(DataTable tblEPOSUsers, int userSearchID) { // Gets the user Index in the db, will return -1 if not found
            for (int i = 0; i < tblEPOSUsers.Rows.Count; i++) {
                if (userSearchID == Convert.ToInt32(tblEPOSUsers.Rows[i][0])) {
                    return i;
                }
            }
            return -1;
        }

        public List<int> getItemFolderLocations(DataTable tblEPOSItems, int itemID) { // Gets the locations of this item where the folder resides
            List<int> itemFolderLocations = new List<int>();

            DataRow item = tblEPOSItems.Rows[getItemIndex(tblEPOSItems, itemID)];
            string itemFolderLocationsS = item[4].ToString();
            string[] itemFolderLocationSA = itemFolderLocationsS.Split(',');

            foreach (string itemFolderLocation in itemFolderLocationSA) {
                itemFolderLocations.Add(Convert.ToInt32(itemFolderLocation));
            }

            return itemFolderLocations;
        }

        public List<int> getItemParentFolderIndexs(DataTable tblEPOSItems, DataTable tblEPOSItemFolders, int itemID) { // Gets the indexes of all folders that the item resides in
            List<int> itemParentFolderIndexs = new List<int>();

            List<int> itemParentFolderIDs = getItemParentFolderIDs(tblEPOSItems, itemID); // Gets folder IDs

            foreach (int folderID in itemParentFolderIDs) { // For every folder ID
                if (folderID == -1) { // Check for no display
                    itemParentFolderIndexs.Add(-2); // Index of -2 for no display
                    continue;
                }

                if (folderID == 0) { // Check for root folder
                    itemParentFolderIndexs.Add(-1); // Index of -1 for root folder
                    continue;
                }

                for (int i = 0; i < tblEPOSItemFolders.Rows.Count; i++) { // Check for every other folder (index > 0)
                    if (folderID != Convert.ToInt32(tblEPOSItemFolders.Rows[i][0])) {
                        continue;
                    }
                    itemParentFolderIndexs.Add(i);
                    break;
                }
            }

            return itemParentFolderIndexs;
        }

        public List<int> getItemParentFolderIDs(DataTable tblEPOSItems, int itemID) { // Gets the IDs of all the folders an item is in.
            string parentFolderIDString = "";
            List<int> itemParentFolderIDs = new List<int>();
            foreach (DataRow item in tblEPOSItems.Rows) {
                if (Convert.ToInt32(item[0]) != itemID) {
                    continue;
                }
                parentFolderIDString = item[3].ToString();
                break;
            }

            string[] itemParentFolderIDsStrings = parentFolderIDString.Split(',');
            foreach (string parentFolderID in itemParentFolderIDsStrings) {
                if (parentFolderID.Length == 0) {
                    continue;
                }
                itemParentFolderIDs.Add(Convert.ToInt32(parentFolderID));
            }
            return itemParentFolderIDs;
        }

        public int getID(DataTable dataTable, int index) { // Gets the ID of a given index for a given table
            return Convert.ToInt32(dataTable.Rows[index][0]);
        }

        public int getTableNumber(DataTable tblEPOSTables, int tableID) { // Get table number
            int tableNumber = -1;
            foreach (DataRow table in tblEPOSTables.Rows) {
                if (Convert.ToInt32(table[0]) != tableID) {
                    continue;
                }
                tableNumber = Convert.ToInt32(table[1]);
                break;
            }
            return tableNumber;
        }

        public string getItemName(DataTable tblEPOSItems, int itemID) { // Get table number
            string itemname = "";
            foreach (DataRow item in tblEPOSItems.Rows) {
                if (Convert.ToInt32(item[0]) != itemID) {
                    continue;
                }
                itemname = item[1].ToString();
                break;
            }
            return itemname;
        }

        public bool getItemPrintRed(DataTable tblEPOSItems, int itemID) { // Get if the items is to be printed in red on tickets.
            bool printRed = false;
            foreach(DataRow item in tblEPOSItems.Rows) {
                if (Convert.ToInt32(item[0]) != itemID) {
                    continue;
                }
                printRed = Convert.ToBoolean(item[7]);
                break;
            }
            return printRed;
        }

        public List<string> getItemPrinters(DataTable tblEPOSItems, int itemID) {
            List<string> itemPrinters = new List<string>();
            foreach (DataRow item in tblEPOSItems.Rows) {
                if (Convert.ToInt32(item[0]) != itemID) {
                    continue;
                }
                itemPrinters = item[6].ToString().Split(';').ToList();
                break;
            }
            return itemPrinters;
        }

    }
}
