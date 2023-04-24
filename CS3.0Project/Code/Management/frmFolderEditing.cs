using CS3._0Project.Code.Utility.Classes;
using CS3._0Project.Code.Utility.Forms;
using CS3._0Project.EPOSDBDataSetTableAdapters;
using CS3._0Project.Forms.Utility;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CS3._0Project.Code.Management {
    public partial class frmFolderEditing : Form {

        private Size screenSize;
        private int userID;
        private string username;

        private frmKeyboard keyboard = new frmKeyboard();
        private frmNumPad numPad = new frmNumPad(3);
        private DBTools DBTools = new DBTools();
        private frmMessageBox cMessageBox = new frmMessageBox();

        private int selectedFolderIndex = 0;

        public frmFolderEditing(Size screenSize, int userID, string username) {
            InitializeComponent();
            this.screenSize = screenSize;
            this.userID = userID;
            this.username = username;
        }

        private void frmUserEditing_Load(object sender, EventArgs e) {
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);
            this.tblEPOSItemFoldersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemFolders);

            this.Location = new Point(0, 0);
            this.Size = screenSize;
            lblUsername.Text = username;

            fillListBox();
        }

        private void fillListBox() { // Draw Folders onto screen
            selectedFolderIndex = lblFolders.SelectedIndex;
            lblFolders.Items.Clear();

            foreach (DataRow floor in ePOSDBDataSet.tblEPOSItemFolders) {
                lblFolders.Items.Add(floor[1] + ": " + DBTools.getItemName(ePOSDBDataSet.tblEPOSItemFolders, Convert.ToInt32(floor[2])));
            }
        }

        private void btnBack_Click(object sender, EventArgs e) { // Return to previous form
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) { // Add new folder
            DataRow newFolder = ePOSDBDataSet.tblEPOSItemFolders.NewRow();
            newFolder[1] = "New Folder";
            newFolder[2] = 0;
            newFolder[3] = 1;
            newFolder[4] = Color.White.ToArgb();
            newFolder[5] = Color.Black.ToArgb();

            ePOSDBDataSet.tblEPOSItemFolders.Rows.Add(newFolder);
            tblEPOSItemFoldersTableAdapter.Update(ePOSDBDataSet.tblEPOSItemFolders);

            tblEPOSItemFoldersTableAdapter.Fill(ePOSDBDataSet.tblEPOSItemFolders);
            fillListBox();
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            if (selectedFolderIndex == -1) {
                return;
            }

            bool safeToRemove = true;
            bool itemInFolder = false;
            bool hasChildFolder = false;
            string unsafeItems = "";
            string unsafeFolders = "";

            int folderID = DBTools.getID(ePOSDBDataSet.tblEPOSItemFolders, selectedFolderIndex);

            foreach (DataRow items in ePOSDBDataSet.tblEPOSItems) { // See if there are an items in the folder
                if (items[3].ToString().Split(',').Contains(folderID.ToString())) {
                    unsafeItems += items[1] + ",";
                    safeToRemove = false;
                    itemInFolder = true;
                }
            }

            foreach(DataRow folder in ePOSDBDataSet.tblEPOSItemFolders) { // See if the folder has children
                if (folderID == Convert.ToInt32(folder[2])) {
                    unsafeFolders += folder[1] + ",";
                    safeToRemove = false;
                    hasChildFolder = true;
                }
            }

            if (safeToRemove) { // If it is safe to remove the folder, delete it
                ePOSDBDataSet.tblEPOSItemFolders.Rows[selectedFolderIndex].Delete();
                tblEPOSItemFoldersTableAdapter.Update(ePOSDBDataSet.tblEPOSItemFolders);
                ePOSDBDataSet.tblEPOSItemFolders.AcceptChanges();
                fillListBox();
            } else { // If unsafe to remove, dont and show error
                if (itemInFolder) {
                    unsafeItems = unsafeItems.Substring(0, unsafeItems.Length - 1);
                    cMessageBox.ShowMessage("Please remove all items before deleting the folder.\nPlease remove the following items from the folder: " + unsafeItems);
                }
                if (hasChildFolder) {
                    unsafeFolders = unsafeFolders.Substring(0, unsafeFolders.Length - 1);
                    cMessageBox.ShowMessage("Please remove all child folders before deleting the folder.\nPlease remove the following children from the folder: " + unsafeFolders);
                }
            }
        }

        private void btnName_Click(object sender, EventArgs e) { // Update name
            if (selectedFolderIndex == -1) {
                return;
            }

            string newName = keyboard.getInput();
            if (newName == "") {
                return;
            }

            ePOSDBDataSet.tblEPOSItemFolders.Rows[selectedFolderIndex][1] = newName.Trim();

            tblEPOSItemFoldersTableAdapter.Update(ePOSDBDataSet.tblEPOSItemFolders.Rows[selectedFolderIndex]);

            tblEPOSItemFoldersTableAdapter.Fill(ePOSDBDataSet.tblEPOSItemFolders);

            fillListBox();
        }

        private void fillParentCBX() { // Fill cbx of parent folder
            tblEPOSItemFoldersTableAdapter.Fill(ePOSDBDataSet.tblEPOSItemFolders);
            cbxParent.Items.Clear();

            cbxParent.Items.Add("Root"); // Add root
            foreach(DataRow folder in ePOSDBDataSet.tblEPOSItemFolders) { // Add all other folders
                cbxParent.Items.Add(folder[1]);
            }
        }

        private void cbxParent_SelectedIndexChanged(object sender, EventArgs e) { // update new parent on index change
            int newParentID;
            if (cbxParent.SelectedIndex == -1) {
                return;
            } else if (cbxParent.SelectedIndex == 0) {
                newParentID = 0;
            } else {
                newParentID = DBTools.getID(ePOSDBDataSet.tblEPOSItemFolders, cbxParent.SelectedIndex - 1);
            }

            if (newParentID == DBTools.getID(ePOSDBDataSet.tblEPOSItemFolders, selectedFolderIndex)) {
                lblFolders.SelectedIndex = selectedFolderIndex;
                return;
            }

            ePOSDBDataSet.tblEPOSItemFolders.Rows[selectedFolderIndex][2] = newParentID;

            tblEPOSItemFoldersTableAdapter.Update(ePOSDBDataSet.tblEPOSItemFolders.Rows[selectedFolderIndex]);

            tblEPOSItemFoldersTableAdapter.Fill(ePOSDBDataSet.tblEPOSItemFolders);

            fillListBox();
        }

        private void lblFolders_SelectedIndexChanged(object sender, EventArgs e) { // Fill cbx on list change
            if (lblFolders.SelectedIndex != -1) {
                selectedFolderIndex = lblFolders.SelectedIndex;

                fillParentCBX();
                int folderIndex = DBTools.getItemIndex(ePOSDBDataSet.tblEPOSItemFolders, Convert.ToInt32(ePOSDBDataSet.tblEPOSItemFolders.Rows[selectedFolderIndex][2]));
                cbxParent.SelectedIndex = folderIndex + 1;

                btnPreview.Text = ePOSDBDataSet.tblEPOSItemFolders.Rows[selectedFolderIndex][1].ToString();
                btnPreview.ForeColor = Color.FromArgb(Convert.ToInt32(ePOSDBDataSet.tblEPOSItemFolders.Rows[selectedFolderIndex][5]));
                btnPreview.BackColor = Color.FromArgb(Convert.ToInt32(ePOSDBDataSet.tblEPOSItemFolders.Rows[selectedFolderIndex][4]));
            }
        }

        private Color getColour() {
            ColorDialog cdlg = new ColorDialog(); // Open a new color diaglog
            cdlg.AnyColor = true;
            cdlg.ShowDialog(); // Show
            Color newColour = cdlg.Color; // Get colour
            return newColour; // return the newly selected colour
        }

        private void btnUpdateFrontColour_Click(object sender, EventArgs e) { // Update text colour
            btnPreview.ForeColor = getColour();

            ePOSDBDataSet.tblEPOSItemFolders.Rows[selectedFolderIndex][5] = btnPreview.ForeColor.ToArgb();
            tblEPOSItemFoldersTableAdapter.Update(ePOSDBDataSet.tblEPOSItemFolders.Rows[selectedFolderIndex]);
            tblEPOSItemFoldersTableAdapter.Fill(ePOSDBDataSet.tblEPOSItemFolders);
        }

        private void btnChangeColour_Click(object sender, EventArgs e) { // Update button colour
            btnPreview.BackColor = getColour();

            ePOSDBDataSet.tblEPOSItemFolders.Rows[selectedFolderIndex][4] = btnPreview.BackColor.ToArgb();
            tblEPOSItemFoldersTableAdapter.Update(ePOSDBDataSet.tblEPOSItemFolders.Rows[selectedFolderIndex]);
            tblEPOSItemFoldersTableAdapter.Fill(ePOSDBDataSet.tblEPOSItemFolders);
        }
    }
}
