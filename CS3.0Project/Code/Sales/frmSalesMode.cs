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

namespace CS3._0Project.Code.Sales {
    public partial class frmSalesMode : Form {

        private Size screenSize;
        private int loginCode;
       
        private bool isRefundMode;
        private List<int> currentFolderPath = new List<int>(); // Current Folder Path as Comma Seperated List

        private int folderY; // 
        private int parentFolder = 0; // Default Parent

        private frmMessageBox cMessageBox = new frmMessageBox();

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

            currentFolderPath.Add(0); // Set default folder path
            createFolderButtons(); // Create folders buttons on load

            //createItemButtons(); // Create buttons on form load


        }

        private void createItemButtons() { // Create a button in the group box for all items in the db table

            foreach (DataRow itemDataRow in this.ePOSDBDataSet.tblEPOSItems) { // For every item in the db
                Button dynamicItemButton = new Button(); // Create a button
                dynamicItemButton.Width = 100; // Assign width + height
                dynamicItemButton.Height = 80;
                dynamicItemButton.Name = "dib" + itemDataRow[0].ToString().Trim(); // Get the ID For later use (name = dib[ID])
                dynamicItemButton.Text = itemDataRow[1].ToString().Trim(); // Name of item
                dynamicItemButton.Parent = gbxItemDisplay; // Put it inside the gbx
                dynamicItemButton.Click += DynamicItemButton_Click; // Custom click event

                dynamicItemButton.Location = new Point(Convert.ToInt32(itemDataRow[4]) + 10, Convert.ToInt32(itemDataRow[5]) + 20);
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
            createFolderButtons(); // Recreate the folder buttons
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
