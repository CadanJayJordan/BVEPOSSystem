using CS3._0Project.Code.Utility.Forms;
using CS3._0Project.EPOSDBDataSetTableAdapters;
using CS3._0Project.Forms.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3._0Project.Code.Management {
    public partial class frmUserEditing : Form {

        private Size screenSize;
        private int userID;
        private string username;

        private int selectedIndex = -1;
        private frmMessageBox frmMessageBox = new frmMessageBox();

        public frmUserEditing(Size screenSize, int userID, string username) {
            InitializeComponent();
            this.screenSize = screenSize;
            this.userID = userID;
            this.username = username;
        }

        private void frmUserEditing_Load(object sender, EventArgs e) {
            this.tblEPOSUsersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSUsers);

            this.Location = new Point(0, 0);
            this.Size = screenSize;
            lblUsername.Text = username;

            updateListBox();
        }

        private void btnBack_Click(object sender, EventArgs e) { // Close form and save if required
            if (selectedIndex > -1) {
                if (!isDataValid()) {
                    return;
                }
                updateDB(selectedIndex);
            }
            this.Close();
        }

        private void btnPaswdShowHide_Click(object sender, EventArgs e) { // Password show/hide 
            Button button = (Button)sender;
            if (button.Text == "Show") {
                button.Text = "Hide";
                txtPassword.PasswordChar = (char)0;
            } else {
                button.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnPayShowHide_Click(object sender, EventArgs e) { // Pay rate show/hide
            Button button = (Button)sender;
            if (button.Text == "Show") {
                button.Text = "Hide";
                txtPayRate.PasswordChar = (char)0;
            } else {
                button.Text = "Show";
                txtPayRate.PasswordChar = '*';
            }
        }

        private void updateListBox() { // Update users box
            lbUsers.Items.Clear();
            foreach(DataRow user in ePOSDBDataSet.tblEPOSUsers) {
                lbUsers.Items.Add(String.Format("{0} ({1})", user[1], user[2]));
            }
        }

        private void updateForm(int selectedIndex) { // Get info from db in form
            if (selectedIndex == -1) {
                return;
            }

            DataRow user = ePOSDBDataSet.tblEPOSUsers.Rows[selectedIndex];

            txtName.Text = user[1].ToString();
            txtLoginCode.Text = user[2].ToString();
            txtPassword.Text = user[3].ToString();
            cbIsManager.Checked = Convert.ToBoolean(user[4]);
            txtForename.Text = user[5].ToString();
            txtSurname.Text = user[6].ToString();
            txtEmailAddr.Text = user[7].ToString();
            txtPayRate.Text = user[9].ToString();
        }

        private void updateDB(int selectedIndex) { // Push all info to DB
            
            tblEPOSUsersTableAdapter.Fill(ePOSDBDataSet.tblEPOSUsers);

            DataRow user = ePOSDBDataSet.tblEPOSUsers.Rows[selectedIndex];

            user[1] = txtName.Text.Trim();
            user[2] = Convert.ToInt32(txtLoginCode.Text);
            user[3] = txtPassword.Text;
            user[4] = cbIsManager.Checked;
            user[5] = txtForename.Text.Trim();
            user[6] = txtSurname.Text.Trim();
            user[7] = txtEmailAddr.Text.Trim();
            user[9] = txtPayRate.Text.Trim();

            tblEPOSUsersTableAdapter.Update(user);
            tblEPOSUsersTableAdapter.Fill(ePOSDBDataSet.tblEPOSUsers);
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e) { // On user selection change, update form
            if (selectedIndex > -1) {
                if (!isDataValid()) {
                    return;
                }
                updateDB(selectedIndex);
            }
            selectedIndex = lbUsers.SelectedIndex;
            updateForm(selectedIndex);
        }

        private bool isDataValid() {
            bool isDataValid = true;
            string errorMessage = "";

            if (lbUsers.SelectedIndex == -1) { // If no item is selected, return true
                return true;
            }

            // Presence checks
            if (txtName.Text.Length <= 0) { // Name box
                isDataValid = false;
                errorMessage += "Cannot have an empty name\n";
            }
            if (txtPassword.Text.Length <= 0) { // Name box
                isDataValid = false;
                errorMessage += "Cannot have an empty password\n";
            }

            try { // Ensurning numbers are valid
                // try conversion
                Convert.ToInt32(txtLoginCode.Text);
                Convert.ToDouble(txtPayRate.Text);

                // Checking login code
                int loginCode = Convert.ToInt32(txtLoginCode.Text);

                if (loginCode == 0) { // if its default
                    isDataValid = false;
                    errorMessage += "Invalid Login code, login code cannot be 0\n";
                }

                foreach (DataRow user in ePOSDBDataSet.tblEPOSUsers) { // Checking if login code is already used
                    if (Convert.ToInt32(ePOSDBDataSet.tblEPOSUsers.Rows[selectedIndex][0]) == Convert.ToInt32(user[0])) { // If checking against the same user as the selected user, restart loop
                        continue;
                    }
                    if (Convert.ToInt32(user[2]) == loginCode) { // If match is found
                        isDataValid = false;
                        errorMessage += "Invalid Login code, login code (" + loginCode + ") already used\n";
                        break;
                    }
                }

            } catch { // If conversion fails (very unlikely due to restricted input)
                isDataValid = false;
                errorMessage += "Invalid Login code/pay rate\n";
            }

            // Length Checks (Too long)
            if (txtName.Text.Length > 254) {
                isDataValid = false;
                errorMessage += "Name: Too long, please limit to 254 characters\n";
            }
            if (txtPassword.Text.Length > 254) {
                isDataValid = false;
                errorMessage += "Password: Too long, please limit to 254 characters\n";
            }
            if (txtForename.Text.Length > 254) {
                isDataValid = false;
                errorMessage += "Forename: Too long, please limit to 254 characters\n";
            }
            if (txtSurname.Text.Length > 254) {
                isDataValid = false;
                errorMessage += "Surname: Too long, please limit to 254 characters\n";
            }
            if (txtEmailAddr.Text.Length > 254) {
                isDataValid = false;
                errorMessage += "Email Addr: Too long, please limit to 254 characters\n";
            }

            if (!isDataValid) {
                frmMessageBox.ShowMessage(errorMessage);
                lbUsers.SelectedIndex = selectedIndex;
            }

            return isDataValid;
        }

        private void onTextFieldClick(object sender, EventArgs e) { // On a text field click, open keybaord
            TextBox tb = (TextBox)sender;

            frmKeyboard frmKeyboard = new frmKeyboard();
            tb.Text = frmKeyboard.getInput(tb.Text);
        }

        private void txtLoginCode_Click(object sender, EventArgs e) { // On login code click, ask for a max 3 char number
            TextBox tb = (TextBox)sender;

            frmNumPad frmNumPad = new frmNumPad(3);
            txtLoginCode.Text = frmNumPad.getInput(tb.Text);
        }

        private void txtPayRate_Click(object sender, EventArgs e) { // On pay rate clcik, ask for a nimber
            TextBox tb = (TextBox)sender;

            frmNumPad frmNumPad = new frmNumPad();
            txtLoginCode.Text = frmNumPad.getInput(tb.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            // Create a new row with the minimum properties
            DataRow newUserRow = ePOSDBDataSet.tblEPOSUsers.NewRow();
            newUserRow[1] = "New User";
            newUserRow[2] = 0;
            newUserRow[3] = "";
            newUserRow[4] = false;
            newUserRow[5] = "";
            newUserRow[6] = "";
            newUserRow[7] = "";
            newUserRow[8] = 0.0m;
            newUserRow[9] = 0.0d;

            ePOSDBDataSet.tblEPOSUsers.Rows.Add(newUserRow); // Add row to datatable
            tblEPOSUsersTableAdapter.Update(ePOSDBDataSet.tblEPOSUsers); // Update DB

            tblEPOSUsersTableAdapter.Fill(ePOSDBDataSet.tblEPOSUsers);
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            if (selectedIndex == -1) { // Ensure some user is selected
                return;
            }

            DataRow deletionUser = ePOSDBDataSet.tblEPOSUsers[selectedIndex];
            if (Convert.ToBoolean(deletionUser[4])) { // if is a manager
                bool otherManager = false;

                foreach (DataRow user in ePOSDBDataSet.tblEPOSUsers) { // Checking to see if there is anouther manager
                    if (Convert.ToInt32(user[0]) == Convert.ToInt32(deletionUser[0])) {
                        continue;
                    }
                    if (Convert.ToBoolean(user[4])) { // If there is then its fine to delete
                        otherManager = true;
                        break;
                    }
                }

                if (!otherManager) { // If there is not anouther manager, do not delete
                    frmMessageBox.ShowMessage("Cannot delete only manager user.");
                    return;
                }
            }
            // If manager user and anouther manager eists or is standard user
            // delete the record
            ePOSDBDataSet.tblEPOSUsers[selectedIndex].Delete();
            tblEPOSUsersTableAdapter.Update(ePOSDBDataSet.tblEPOSUsers);
            ePOSDBDataSet.tblEPOSUsers.AcceptChanges();

        } 
    }
}
