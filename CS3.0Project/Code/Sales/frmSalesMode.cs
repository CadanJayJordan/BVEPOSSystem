using CS3._0Project.Code.Utility.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CS3._0Project.EPOSDBDataSet;

namespace CS3._0Project.Code.Sales {
    public partial class frmSalesMode : Form {

        private Size screenSize;
        private int loginCode;

        private bool isRefundMode;
        private List<int> currentFolderPath = new List<int>(); // Current Folder Path as Comma Seperated List

        private int folderY; // Folder y so we can put the items under the folders
        private int parentFolder = 0; // Default Parent

        private List<List<int>> itemLocationList;
        private List<List<int>> sortList;

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
            // TODO: This line of code loads data into the 'ePOSDBDataSet.tblEPOSItemFolders' table. You can move, or remove it, as needed.
            this.tblEPOSItemFoldersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemFolders);
            // TODO: This line of code loads data into the 'ePOSDBDataSet.tblEPOSItems' table. You can move, or remove it, as needed.
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);

            currentFolderPath.Add(0);
            createButtons();
        }

        private void createButtons() {
            getItemFolders();
            sortFolderIDs();


            createFolderButtons(); // Create folders buttons on load

            createItemButtons(); // Create buttons on form load
        }

        private void createItemButtons() { // Create a button in the group box for all items in the db table
            int itemX = 10;
            int itemY = folderY + 100;


            for (int i = 0; i < sortList.Count; i++) {
                string itemId = sortList[i][0].ToString();
                tblEPOSItemsTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSItems.*\n" +
                    "FROM tblEPOSItems\n" +
                    "WHERE (((tblEPOSItems.eposItemID)= " + itemId + "));";
                    this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);

                DataRow itemDataRow = ePOSDBDataSet.tblEPOSItems.Rows[0];

                Button dynamicItemButton = new Button(); // Create a button
                dynamicItemButton.Hide();
                dynamicItemButton.Width = 100; // Assign width + height
                dynamicItemButton.Height = 80;
                dynamicItemButton.Name = "dib" + itemDataRow[0].ToString().Trim(); // Get the ID For later use (name = dib[ID])
                dynamicItemButton.Text = itemDataRow[1].ToString().Trim(); // Name of item
                dynamicItemButton.Parent = gbxItemDisplay; // Put it inside the gbx
                dynamicItemButton.Click += DynamicItemButton_Click; // Custom click event
                if ((itemX + dynamicItemButton.Width + 10) > gbxItemDisplay.Width) { // If the items go off the right hand side of the gbx
                    itemY += 100; // Move item down
                    itemX = 10; // reset the x coordinate
                }
                dynamicItemButton.Location = new Point(itemX, itemY);
                dynamicItemButton.Show();
                itemX += 110;
            }

        }

        private void getItemFolders() { // Gets the item folders and locations and puts them in a list where it follows the schema
                                        // [eposItemID, itemFolderID(1), itemLocaton (1), itemFolderID(2), itemLocation(2), ....] for a list of items
                                        // (Each individual item has all the properties in the square brackets), and will be stored in the itemLocationList List.

            itemLocationList = new List<List<int>>(); // Create new list when ran
            foreach(DataRow itemDataRow in this.ePOSDBDataSet.tblEPOSItems) {
                string[] itemFolderArray = itemDataRow[3].ToString().Split(',');
                string[] itemLocationArray = itemDataRow[4].ToString().Split(',');

                if (itemFolderArray.Length != itemLocationArray.Length) { // if there are not equal items
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
                    }
                    i += 2; // Incremement to go through every other item
                }
            }
            return currentFolderIDs; // Return the list
        }

        private void sortFolderIDs() { // Sorts the list 
            int currentFolderID = currentFolderPath[currentFolderPath.Count - 1]; // Get the ID of the current folder
            List<int> currentFolderIDs = getCurrentFolderItemIDs(currentFolderID); // Get all the current IDs for this folder
            List<List<int>> itemFolderLocations = new List<List<int>>();
            List<int> sortedFolderIDs = new List<int>();
            foreach(List<int> itemLocationRow in itemLocationList) {
                for (int i = 0; i < currentFolderIDs.Count; i++) {
                    if (itemLocationRow[0] == currentFolderIDs[i]){
                        int x = 1; // Set int to 1 to get the first FOLDER ID
                        while (x < itemLocationRow.Count) { // Repeat until every other item in the list has been iterated through
                            if (itemLocationRow[x] == currentFolderID) { // If the current folder ID is equal to the iterated item
                                List<int> itemFolderLocationSubList = new List<int>();
                                itemFolderLocationSubList.Add(itemLocationRow[0]);
                                itemFolderLocationSubList.Add(itemLocationRow[x + 1]);
                                itemFolderLocations.Add(itemFolderLocationSubList);
                            }
                            x += 2; // Incremement to go through every other item
                        }
                    }
                }
            }
            sortList = itemFolderLocations;
            qSort(0, sortList.Count - 1);
                       
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
            if (folderWidth + 20 > gbxItemDisplay.Width) { // If the gbx is too small (to contain the width of one button + padding)
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
                    dynamicFolderButton.Parent = gbxItemDisplay; // Assign parent
                    dynamicFolderButton.Click += DynamicFolderButton_Click; // Assign the custom click event
                    if ((folderX + dynamicFolderButton.Width + 10) > gbxItemDisplay.Width) { // If the folders go off the right hand side of the gbx
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
            gbxItemDisplay.Controls.Clear(); // Clear exitsting folders
            Button button = (Button)sender; // Assign type button to sender
            currentFolderPath.Add(Convert.ToInt32(button.Name.Substring(3, button.Name.Length - 3))); // Add the number on the name of the button, which is the folder ID and thereby the parent ID
            createButtons();
        }

        private void DynamicItemButton_Click(object sender, EventArgs e) { // TODO: Custom click event
            throw new NotImplementedException();
        }

        private void btnFolderBack_Click(object sender, EventArgs e) {
            if (currentFolderPath.Count > 1) { // If it is not the base directory
                gbxItemDisplay.Controls.Clear(); // Clear existing folders
                currentFolderPath.RemoveAt(currentFolderPath.Count - 1); // Remove last folder path (like a back button)
                createFolderButtons(); // Recreate the new folder buttons
            } // else do nothing 
        }
    }
}
