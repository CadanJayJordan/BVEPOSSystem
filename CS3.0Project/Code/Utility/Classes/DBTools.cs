using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3._0Project.Code.Utility.Classes {
    internal class DBTools {

        public DBTools() {
        }

        public string getUsername(DataTable tblEPOSUsers, int userID) { // Gets UserID, returns an empty string if not found
            string username = "";
            foreach (DataRow user in tblEPOSUsers.Rows) {
                if (Convert.ToInt32(user[0]) != userID) {
                    continue;
                }
                username = user[1].ToString();
                break;
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
    }
}
