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

        private int userID = 0; // MAJOR TODO: Make user ID Work

        private frmMessageBox cMessageBox = new frmMessageBox();
        private DBTools DBTools = new DBTools();
        private LoginTools LoginTools = new LoginTools();
        
        private frmClock frmClock;
        private frmSalesMode frmSalesMode;
        private frmSalesMode frmRefundMode;
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
            //screenSize = new Size(1258, 900); 
            screenSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            this.Size = screenSize;

            formInit();
        }
        private void frmEPOSMenu_Shown(object sender, EventArgs e) {
            formInit();
        }

        private void formInit() {
            lblUsername.Text = DBTools.getUsername(ePOSDBDataSet.tblEPOSUsers, userID);
            
        }


        private void btnExit_Click(object sender, EventArgs e) {
            this.Close(); // Closes this form thereby terminating the program
        }

        private void btnLogin_Click(object sender, EventArgs e) {
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
            frmSalesMode = new frmSalesMode(screenSize, userID, false);
            frmSalesMode.ShowDialog();
            
        }

        private void btnRefundMode_Click(object sender, EventArgs e) {
            /*if (!isLoggedIn()) {
                  return;
                }
              frmRefundMode = new frmSalesMode(screenSize, userID, true);
              frmRefundMode.ShowDialog();
            }*/
        }

        private void btnConfiguration_Click(object sender, EventArgs e) {
            // If logged in and is a manager, open config screen
            if (!isLoggedIn()) {
                return;
            }
            if (!isManager()) {
                return;
            }

            frmConfiguration = new frmConfiguration(screenSize, userID);
            frmConfiguration.ShowDialog();

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

        private bool isLoggedIn() { // Bool to check for login
            if (userID < 1) {
                cMessageBox.ShowMessage("Please login before trying that");
                return false;
            } else {
                return true;
            }

        }

        private bool isManager() {
            if (!LoginTools.isManager) {
                cMessageBox.ShowMessage("You don't have permission to do that");
                return false;
            }

            return true;

        }

        private void btnManagerFunctions_Click(object sender, EventArgs e) {
            if (!isLoggedIn()) {
                return;
            }
            if (!isManager()) {
                return;
            }

            frmManagementFunctions = new frmManagementFunctions(screenSize, userID);
            frmManagementFunctions.ShowDialog();
        }

        private void btnClock_Click(object sender, EventArgs e) {
            // MAJOR TODO: Clock in/out functionallity
            if (!isLoggedIn()) {
                return;
            }

            frmClock = new frmClock(screenSize, userID, LoginTools.isManager);
            frmClock.ShowDialog();
        }

        
    }
}
