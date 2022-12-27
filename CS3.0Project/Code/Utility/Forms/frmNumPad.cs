using System;
using System.Windows.Forms;
using CS3._0Project.Forms.Utility.Classes;

namespace CS3._0Project.Forms.Utility {
    public partial class frmNumPad : Form {

        private bool isLoginCode;

        public frmNumPad(bool isLoginCode) {
            InitializeComponent();
            this.isLoginCode = isLoginCode; // Get input, if it is login, numbers cannot exceed 3 chars
            new FormDragger(this); // Allow Moving form via dragging
            
        }
        public string getInput() { // Get text from textbox
            return txtInput.Text;
        }

        private void btnClear_Click(object sender, EventArgs e) { // Clear text box
            txtInput.Text = String.Empty;
        }

        private void btnBackspace_Click(object sender, EventArgs e) { // Remove last entered character
            string text = txtInput.Text;
            if (text.Length > 0) {
                txtInput.Text = text.Remove(text.Length - 1, 1);
            }
        }

        private void btnBack_Click(object sender, EventArgs e) { // Return to previous form with NO output
            btnClear_Click(sender, e);
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e) { // Return to previous form with output
            this.Close();
        }
        private void txtInput_TextChanged(object sender, EventArgs e) { // Ensure text length does not exceed 3 (codes cannot be more than 3 chars for login)
            if (isLoginCode) {
                string text = txtInput.Text;
                if (text.Length > 3) {
                    txtInput.Text = text.Substring(0, 3);
                }
            }
        }

        // Adding the numbers to the text box
        private void btn0_Click(object sender, EventArgs e) {
            txtInput.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e) {
            txtInput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e) {
            txtInput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e) {
            txtInput.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e) {
            txtInput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e) {
            txtInput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e) {
            txtInput.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e) {
            txtInput.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e) {
            txtInput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e) {
            txtInput.Text += "9";
        }
    }
}
