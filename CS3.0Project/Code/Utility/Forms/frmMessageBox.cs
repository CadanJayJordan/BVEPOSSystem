using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CS3._0Project.Forms.Utility.Classes;

namespace CS3._0Project.Code.Utility.Forms {
    public partial class frmMessageBox : Form {

        private string message;

        public frmMessageBox() {
            InitializeComponent();
            new ControlDragger(this, true, false);
        }

        public void ShowMessage(string message) {
            this.message = message;
            this.Show();
        }

        private void frmMessageBox_Shown(object sender, EventArgs e) {
            rtbTextOutput.Text = message;
        }

        private void btnOk_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
