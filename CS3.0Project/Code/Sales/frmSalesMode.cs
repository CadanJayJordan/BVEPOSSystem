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
            //createItemButtons(); // Create buttons on form load
            createFolderButtons();
        }

        private void createItemButtons() { // Create a button in the group box for all items in the db table
            foreach (DataRow itemDataRow in this.ePOSDBDataSet.tblEPOSItems) { // For every item in the db
                Button dynamicItemButton = new Button(); // Create a button
                dynamicItemButton.Width = 100; // Assign width + height
                dynamicItemButton.Height = 80;
                dynamicItemButton.Name = "dib" + itemDataRow[0].ToString().Trim(); // Get the ID For later use (name = dib[ID])
                dynamicItemButton.Text = itemDataRow[1].ToString().Trim(); // Name of item
                dynamicItemButton.Parent = gbxItemDisplay; // Put it inside the gbx
                dynamicItemButton.Location = new Point(Convert.ToInt32(itemDataRow[4])+10, Convert.ToInt32(itemDataRow[5]) + 20); // place in gbx (offset for bounds of gbx being strange)
                dynamicItemButton.Click += DynamicItemButton_Click; // Custom click event
            }
        }

        private void createFolderButtons() {
            int parentFolder = 0;
            int folderX = 10;
            int folderY = 20;
            if (currentFolderPath.Count > 1) { // If parent folder is NOT the base directory
                parentFolder = currentFolderPath[currentFolderPath.Count - 2];
            }
            tblEPOSItemFoldersTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSItemFolders.itemFolderID, tblEPOSItemFolders.itemFolderName, tblEPOSItemFolders.parentFolderID\n" +
                    "FROM tblEPOSItemFolders\n" +
                    "WHERE(((tblEPOSItemFolders.parentFolderID) = " + parentFolder + "));"; // Query for all folders in the parent folder
            this.tblEPOSItemFoldersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemFolders);

            foreach (DataRow folderDataRow in this.ePOSDBDataSet.tblEPOSItemFolders) {
                Button dynamicFolderButton = new Button();
                dynamicFolderButton.Width = 100; // Assign width + height
                dynamicFolderButton.Height = 80;
                dynamicFolderButton.Name = "dfb" + folderDataRow[0].ToString().Trim();
                dynamicFolderButton.Text = folderDataRow[1].ToString().Trim();
                dynamicFolderButton.Parent = gbxItemDisplay;
                dynamicFolderButton.Location = new Point(folderX, folderY);
                dynamicFolderButton.Click += DynamicFolderButton_Click;
                folderX += 110;
            }
        }

        private void DynamicFolderButton_Click(object sender, EventArgs e) { // TODO: Custom click event
            clearGBX();
            Button button = (Button)sender;
            currentFolderPath.Add(Convert.ToInt32(button.Name.Substring(2, button.Name.Length - 1)));
            createFolderButtons();
        }

        private void DynamicItemButton_Click(object sender, EventArgs e) { // TODO: Custom click event
            throw new NotImplementedException();
        }

        private void clearGBX() {
            foreach(Control ctrl in gbxItemDisplay.Controls) {
                Controls.Remove(ctrl);
            }
        }
    }
}
