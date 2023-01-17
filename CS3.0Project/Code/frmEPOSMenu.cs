using System;
using System.Drawing;
using System.Windows.Forms;
using CS3._0Project.Forms.Login;
using CS3._0Project.Code.Utility.Forms;
using CS3._0Project.Code.Configuration;
using CS3._0Project.Code.Sales;
using CS3._0Project.Code.Management;

namespace CS3._0Project.Forms {
    public partial class frmEPOSMenu : Form {

        private Size screenSize;

        private int loginCode = 999; // TODO: -1 by default
        private bool isManager = true; // TODO: false by default

        private int userID = 1; // TODO: Make user ID Work

        frmMessageBox cMessageBox = new frmMessageBox();

        public frmEPOSMenu() {
            InitializeComponent();
        }

        private void frmEPOSMenu_Load(object sender, EventArgs e) {
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);
            // Ensure the form is on the screen correctly
            this.Location = new Point(0, 0);
            // Make window the size of the screen
            //screenSize = new Size(1258, 900); 
            screenSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            this.Size = screenSize;

        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close(); // Closes this form thereby terminating the program
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            LoginClass loginClass = new LoginClass();
            loginCode = loginClass.loginCode;
            isManager = loginClass.isManager;
            MessageBox.Show(loginCode.ToString() + "\n" + isManager.ToString());
        }

        private void btnSalesMode_Click(object sender, EventArgs e) {
            if (isLoggedIn()) {
                frmSalesMode frmSalesMode = new frmSalesMode(screenSize, userID, false);
                frmSalesMode.ShowDialog();
            }
        }

        private void btnRefundMode_Click(object sender, EventArgs e) {
            /*if (isLoggedIn()) {
                frmSalesMode frmSalesMode = new frmSalesMode(screenSize, loginCode, true);
                frmSalesMode.ShowDialog();
            }*/
        }

        private void btnConfiguration_Click(object sender, EventArgs e) {
            if (isLoggedIn()) {
                if (!isManager) {
                    cMessageBox.ShowMessage("You don't have permission to do that");
                } else {
                    frmConfiguration frmConfiguration = new frmConfiguration(screenSize, loginCode);
                    frmConfiguration.ShowDialog();
                }
            }
        }
        private void btnKeyboard_Click(object sender, EventArgs e) {
            //REMOVE LATER
            frmKeyboard frmKeyboard = new frmKeyboard();
            frmKeyboard.ShowDialog();
            MessageBox.Show(frmKeyboard.getInput());
        }

        private void btnMessage_Click(object sender, EventArgs e) {
            //REMOVE LATER

            frmMessageBox frmMessageBox = new frmMessageBox();
            frmMessageBox.ShowMessage("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
        }

        private bool isLoggedIn() {
            if (loginCode < 0) {
                cMessageBox.ShowMessage("Please login before trying that");
                return false;
            } else {
                return true;
            }

        }

        private void btnManagerFunctions_Click(object sender, EventArgs e) {
            frmManagementFunctions frmManagementFunctions = new frmManagementFunctions(screenSize, userID);
            frmManagementFunctions.ShowDialog();
        }
    }
}
