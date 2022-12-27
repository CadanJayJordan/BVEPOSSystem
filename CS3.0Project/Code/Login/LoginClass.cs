using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS3._0Project.Forms.Utility;

namespace CS3._0Project.Forms.Login {
    class LoginClass {

        public int loginCode;
        public bool isManager;

        public LoginClass() {
            loginCode = getLoginCode();
            this.isManager = isManagerAccess(loginCode);
        }

        private int getLoginCode() {
            int loginCode;

            frmNumPad frmNumPad = new frmNumPad(true); ;
            frmNumPad.ShowDialog();
            String code = frmNumPad.getInput();

            if (code.Equals(String.Empty)) {
                loginCode = -1;
            } else {
                loginCode = Convert.ToInt32(code);
            }
            return loginCode;
        }

        private bool isManagerAccess(int loginCode) {
            // TODO: Check DB for access level.
            if (loginCode == 999) {
                return true;
            } else {
                return false;
            }
        }

    }
}
