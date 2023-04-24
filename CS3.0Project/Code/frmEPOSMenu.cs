using System;
using System.Drawing;
using System.Windows.Forms;
using CS3._0Project.Forms.Login;
using CS3._0Project.Code.Utility.Forms;
using CS3._0Project.Code.Utility.Classes;
using CS3._0Project.Code.Configuration;
using CS3._0Project.Code.Sales;
using CS3._0Project.Code.Management;

namespace CS3._0Project.Forms {
    public partial class frmEPOSMenu : Form {

        private Size screenSize;

        private int userID = 0;
        private string username = "";

        private frmMessageBox cMessageBox = new frmMessageBox();
        private DBTools DBTools = new DBTools();
        private LoginTools LoginTools = new LoginTools();
        
        private frmClock frmClock;
        private frmSalesMode frmSalesMode;
        private frmConfiguration frmConfiguration;
        private frmManagementFunctions frmManagementFunctions;

        public frmEPOSMenu() {
            InitializeComponent();
        }

        private void frmEPOSMenu_Load(object sender, EventArgs e) {
            // Fill DB
            this.tblEPOSUsersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSUsers);
            // Ensure the form is on the screen correctly
            this.Location = new Point(0, 0);
            // Make window the size of the screen
            //screenSize = new Size(1258, 900); // DEBUG FOR SCREEN SIZES
            screenSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            this.Size = screenSize;

            formInit();
        }
        private void frmEPOSMenu_Shown(object sender, EventArgs e) {
            formInit();
        }

        private void formInit() {
            string dbName = DBTools.getUsername(ePOSDBDataSet.tblEPOSUsers, userID);
            username = dbName;
            lblUsername.Text = dbName;
        }


        private void btnExit_Click(object sender, EventArgs e) {
            this.Close(); // Closes this form thereby terminating the program
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            this.tblEPOSUsersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSUsers);

            getLogin();
        }

        private void getLogin() { // Gets login form
            lblUsername.Text = "";
            // Open login form and bring values out
            LoginTools.getLogin(ePOSDBDataSet.tblEPOSUsers);
            userID = LoginTools.userID;
            if (userID < 1) {
                return;
            }
            formInit();
        }

        private void btnSalesMode_Click(object sender, EventArgs e) {
            if (!isLoggedIn()) { // if we are logged in, open the sales mode
                return;
            }
            frmSalesMode = new frmSalesMode(this, screenSize, userID, username, false);
            frmSalesMode.ShowDialog();
            
        }

        private void btnRefundMode_Click(object sender, EventArgs e) {
            if (!isLoggedIn()) { // if we are logged in, open the sales mode with refund setting on
                return;
            }
            frmSalesMode = new frmSalesMode(this, screenSize, userID, username, true);
            frmSalesMode.ShowDialog();
        }

        private void btnConfiguration_Click(object sender, EventArgs e) {
            // If logged in and is a manager, open config screen
            if (!isLoggedIn()) {
                return;
            }
            if (!isManager()) {
                return;
            }

            frmConfiguration = new frmConfiguration(screenSize, userID, username);
            frmConfiguration.ShowDialog();

        }

        private bool isLoggedIn() { // Bool to check for login
            if (userID < 1) {
                cMessageBox.ShowMessage("Please login before trying that");
                return false;
            } else {
                return true;
            }

        }

        private bool isManager() { // Checks permission level
            if (!LoginTools.isManager) {
                cMessageBox.ShowMessage("You don't have permission to do that");
                return false;
            }
            return true;
        }

        private void btnManagerFunctions_Click(object sender, EventArgs e) { // Open manager functions if manager
            if (!isLoggedIn()) {
                return;
            }
            if (!isManager()) {
                return;
            }

            frmManagementFunctions = new frmManagementFunctions(screenSize, userID, username);
            frmManagementFunctions.ShowDialog();
        }

        private void btnClock_Click(object sender, EventArgs e) { // Clock in/out open if logged in
            if (!isLoggedIn()) {
                return;
            }

            frmClock = new frmClock(screenSize, userID, LoginTools.isManager);
            frmClock.ShowDialog();
        }
    }
}
