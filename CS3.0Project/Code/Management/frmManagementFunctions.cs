using System;
using System.Drawing;
using System.Windows.Forms;
using CS3._0Project.Code.Table;

namespace CS3._0Project.Code.Management {
    public partial class frmManagementFunctions : Form {

        private Size screenSize;
        private int userID;
        private string username;

        public frmManagementFunctions(Size screenSize, int userID, string username) {
            InitializeComponent();
            this.screenSize = screenSize;
            this.userID = userID;
            this.username = username;
        }

        private void frmManagementFunctions_Load(object sender, EventArgs e) {
            this.Size = screenSize;
            this.Location = new Point(0, 0);
            lblUsername.Text = username;
        }

        private void btnClose_Click(object sender, EventArgs e) { // Back button closes form
            this.Close();
        }

        /* Opens different editing forms */
        private void btnEditTablePlan_Click(object sender, EventArgs e) {
            frmTablePlan frmTablePlan = new frmTablePlan(screenSize, userID, username, true);
            frmTablePlan.ShowDialog();
        }

        private void btnItemEditing_Click(object sender, EventArgs e) {
            frmItemEditing frmItemEditing = new frmItemEditing(screenSize, userID, username);
            frmItemEditing.ShowDialog();
        }

        private void btnEditFolders_Click(object sender, EventArgs e) {
            frmFolderEditing frmFolderEditing = new frmFolderEditing(screenSize, userID, username);
            frmFolderEditing.ShowDialog();
        }

        private void btnEditUsers_Click(object sender, EventArgs e) {
            frmUserEditing frmUserEditing = new frmUserEditing(screenSize, userID, username);
            frmUserEditing.ShowDialog();
        }

        private void btnEditDepartments_Click(object sender, EventArgs e) {
            frmDepartmentEditing frmDepartmentEditing = new frmDepartmentEditing(screenSize, userID, username);
            frmDepartmentEditing.ShowDialog();
        }

        private void btnTableFloorEditing_Click(object sender, EventArgs e) {
            frmTableFloorEditing frmTableFloorEditing = new frmTableFloorEditing(screenSize, userID, username);
            frmTableFloorEditing.ShowDialog();
        }

        private void btnEditLists_Click(object sender, EventArgs e) {
            frmListItemEditing frmListItemEditing = new frmListItemEditing(screenSize, userID, username);
            frmListItemEditing.ShowDialog();
        }
    }
}
