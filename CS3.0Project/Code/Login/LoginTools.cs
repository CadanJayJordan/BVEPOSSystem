using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS3._0Project.Code.Utility.Forms;
using CS3._0Project.Forms.Utility;

namespace CS3._0Project.Forms.Login {
    class LoginTools {

        public int userID = -1;
        public bool isManager = false;
        private int userIndex;

        DataTable tblEPOSUsers;

        private frmMessageBox cMessageBox = new frmMessageBox();

        public LoginTools() {

        }

        public void getLogin(DataTable tblEPOSUsers) { // Get user login
            this.tblEPOSUsers = tblEPOSUsers;
            this.userID = getUserID(getLoginCode());
            if (userID == -1) {
                cMessageBox.ShowMessage("Invalid Login Code");
                return;
            }
            this.isManager = isManagerAccess(userIndex);
        }

        private int getLoginCode() { // Gets login code from the user, returns -1 if nothing is entered
            int loginCode;

            frmNumPad frmNumPad = new frmNumPad(3); ;
            String code = frmNumPad.getInput(); // Get input from user

            if (code.Equals(String.Empty)) {
                loginCode = -1;
            } else {
                loginCode = Convert.ToInt32(code);
            }
            return loginCode;
        }

        private int getUserID(int loginCode) { // Gets user ID from the login Code, returns -1 if no user is found
            int userID = -1;
            for(int i = 0; i < tblEPOSUsers.Rows.Count; i++) {
                if (Convert.ToInt32(tblEPOSUsers.Rows[i][2]) != loginCode){
                    continue;
                }
                userID = Convert.ToInt32(tblEPOSUsers.Rows[i][0]);
                userIndex = i;
                break;
            }

            return userID;
        }

        private bool isManagerAccess(int userIndex) { // Checks if the user is a manager
            bool isManager = false;
            if (Convert.ToBoolean(tblEPOSUsers.Rows[userIndex][4])) { // If is manager
                isManager = true;
            }

            return isManager; // If not manager
            
        }

    }
}
