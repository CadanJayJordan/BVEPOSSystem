using System;
using System.Windows.Forms;
using CS3._0Project.Forms.Utility.Classes;

namespace CS3._0Project.Code.Utility.Forms {
    public partial class frmKeyboard : Form {

        private string textReturn; // text to return when getInput() is called

        public frmKeyboard() {
            InitializeComponent();
            new FormDragger(this); // Enable form dragging
        }

        private void frmKeyboard_Load(object sender, EventArgs e) {
            AllowButtonClick(this); // Allows reading of text on pressed button
        }

        public string getInput() { // Public function to return the text inputted into the form
            if (textReturn != null) {
                return textReturn.Trim();
            } else {
                return null;
            }
        }

        private void OnButtonClick(object sender, EventArgs e) { // When a button click is registered
            Button btn = (Button)sender;
            string btnText = btn.Text; // Get text on button
            switch (btnText) { // Check for certain circumstances
                case ("Close"): // Resets text box and closes form
                    rtxtOutput.Text = "";
                    this.Close();
                    break;
                case ("TAB"):
                    break; // todo: tab
                case ("CAP"):
                    break; // todo: caps
                case ("Shift"):
                    break; // todo: caps for 1 letter
                case ("Control"):
                    break; // todo: Symbols?
                case ("Enter"): // Move text to variable and close form
                    textReturn = rtxtOutput.Text;
                    rtxtOutput.Text = "";
                    this.Close();
                    break;
                case ("Space"): // Inserts space character
                    rtxtOutput.Text += " ";
                    break;
                case ("Delete"): // removes last typed character
                    if (rtxtOutput.Text.Length > 0) {
                        rtxtOutput.Text = rtxtOutput.Text.Substring(0, rtxtOutput.Text.Length - 1); // new substring containing everything except last char
                    }
                    break;
                case ("Clear"): // Clears all text inputted
                    rtxtOutput.Text = "";
                    break;
                case (""): // Empty Buttons todo: ? (symbols maybe)
                    break; 
                default: // Other buttons add text to the box
                    rtxtOutput.Text += btnText;
                    break;
            }
        }

        private void AllowButtonClick(Control ctrl) { // Findng buttons to read text of on click
            foreach (Control subctrl in ctrl.Controls) { // Get each control in the form
                if (subctrl.GetType() == typeof(GroupBox)) { // if the control is a group box, enter the method again
                    AllowButtonClick(subctrl); // Recursion
                } else if (subctrl.GetType() == typeof(Button)) { // If a button is found, allow the event to be used.
                    subctrl.Click += OnButtonClick;
                }
            }
        }
    }
}
