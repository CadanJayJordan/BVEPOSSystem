using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CS3._0Project.Code.Management {
    public partial class frmItemParentAddDialog : Form {

        private EPOSDBDataSet.tblEPOSItemFoldersDataTable tblEPOSItemFolders;
        int itemIndex;
        private List<int> currentFolderIndexs;

        private List<int> folderIDs = new List<int>();

        public frmItemParentAddDialog(EPOSDBDataSet.tblEPOSItemFoldersDataTable tblEPOSItemFolders, int itemIndex, List<int> currentFolderIndexs) {
            InitializeComponent();
            this.tblEPOSItemFolders = tblEPOSItemFolders;
            this.itemIndex = itemIndex;
            this.currentFolderIndexs = currentFolderIndexs;
        }

        public List<int> getParentFolderIndexs() { // Gets indexs of the selected items on the folder
            List<int> parentFolderList = new List<int>();
            if (cbRootSelected.Checked) {
                parentFolderList.Add(-1);
            }
            for (int i = 0; i < clbSelectedParents.Items.Count; i++) { 
                if (clbSelectedParents.GetItemCheckState(i) != CheckState.Checked) {
                    continue;
                }
                parentFolderList.Add(i);
            }

            if (parentFolderList.Count < 1) {
                parentFolderList.Add(-2);
            }

            return parentFolderList;
        }

        private void fillListBox() { // Fills the list box with folders from the db
            foreach(DataRow folder in tblEPOSItemFolders.Rows) {
                int folderID = Convert.ToInt32(folder[0]);
                folderIDs.Add(folderID);
                clbSelectedParents.Items.Add(folder[1]);
            }
        }

        private void displayExistingInformation() { // Selects folders that are already the parent folders
            foreach(int selectedFolderIndex in currentFolderIndexs) {
                if (selectedFolderIndex > -1) {
                    clbSelectedParents.SetItemChecked(selectedFolderIndex, true);
                    continue;
                }
                if (selectedFolderIndex == -1) {
                    cbRootSelected.Checked = true;
                }
            }
        }

        private void frmItemParentAddDialog_Load(object sender, EventArgs e) {// Sizeing information
            this.MaximumSize = new Size(357, Screen.PrimaryScreen.Bounds.Height);
            fillListBox();
            displayExistingInformation();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
