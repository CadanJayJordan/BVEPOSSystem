using System;
using System.Windows.Forms;

using CS3._0Project.Forms.Utility.Classes;

namespace CS3._0Project.Code.Utility.Forms {
    public partial class frmMessageBox : Form {

        private string message;

        public frmMessageBox() {
            InitializeComponent();
            new ControlDragger(this, true, false); // Allow dragging
        }

        public void ShowMessage(string message) { // Public function to show message
            this.message = message;
            this.Show();
        }

        private void frmMessageBox_Shown(object sender, EventArgs e) {
            rtbTextOutput.Text = message; // On show update the message
        }

        private void btnOk_Click(object sender, EventArgs e) { // hide on ok
            this.Hide();
        }
    }
}
