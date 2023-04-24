using System;
using System.Windows.Forms;
using CS3._0Project.Forms.Utility.Classes;

namespace CS3._0Project.Code.Utility.Forms {
    public partial class frmKeyboard : Form {

        private string textReturn; // text to return when getInput() is called
        private string startText;
        private bool isCaps = true;
        private bool shiftCap = true;

        public frmKeyboard() {
            InitializeComponent();
            new ControlDragger(this, true, false); // Enable form dragging
            AllowButtonClick(this); // Allows reading of text on pressed button
        }

        private void frmKeyboard_Load(object sender, EventArgs e) {
        }

        public string getInput(string startText = "") { // Public function to return the text inputted into the form
            this.startText = startText;
            txtOutput.Text = startText;
            textReturn = startText;
            this.ShowDialog();
            if (textReturn != null) {
                return textReturn;
            } else {
                return "";
            }
        }

        private void OnButtonClick(object sender, EventArgs e) { // When a button click is registered
            Button btn = (Button)sender;
            string btnText = btn.Text; // Get text on button
            switch (btnText) { // Check for certain circumstances
                case ("Close"): // Resets text box and closes form
                    textReturn = startText;
                    txtOutput.Text = "";
                    this.Close();
                    break;
                case ("CAPS"): // Capitalise until changed
                    invertCapitalisation();
                    break;
                case ("Shift"): // Capitalise for 1 letter
                    invertCapitalisation();
                    shiftCap = true;
                    break; // todo: caps for 1 letter
                case ("Enter"): // Move text to variable and close form
                    textReturn = txtOutput.Text;
                    txtOutput.Text = "";
                    this.Close();
                    break;
                case ("Space"): // Inserts space character
                    txtOutput.Text += " ";
                    break;
                case ("Delete"): // removes last typed character
                    if (txtOutput.Text.Length > 0) {
                        txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1); // new substring containing everything except last char
                    }
                    break;
                case ("Clear"): // Clears all text inputted
                    txtOutput.Text = "";
                    break;
                default: // Other buttons add text to the box
                    txtOutput.Text += btnText;
                    if (shiftCap) {
                        invertCapitalisation();
                        shiftCap = false;
                    }
                    break;
            }
        }

        private void AllowButtonClick(Control ctrl) { // Findng buttons to read text of on click
            foreach (Control subCtrl in ctrl.Controls) {
                if (subCtrl.GetType() == typeof(Button)) { // If a button is found, allow the event to be used.
                    subCtrl.Click += OnButtonClick;
                } else {
                    AllowButtonClick(subCtrl);
                }
            }
        }

        private void invertCapitalisation() {
            foreach (Control ctrl in this.Controls) {  // For all controls
                if (ctrl.GetType() != typeof(Button)) { // If not a button, restart loop
                    continue;
                }
                
                Button button = (Button)ctrl; // Is a button
                if (button.Text.Length != 1) { // If text length is not a single letter, restart loop
                    continue;
                }

                char btnChar = (char)button.Text[0]; // Get char
                // Finding if this char is actully a letter (so we can shift the UTF value)
                if ((int)btnChar < (int)'A') { // If less than A, not letter
                    continue;
                }
                if ((int)btnChar > (int)'z') { // if more than z, not letter
                    continue;
                }
                if ((int)btnChar > (int)'Z' && btnChar < (int)'a') { // If between Z and a, no letter
                    continue;
                }
                int newChar = 0;
                // Char is now our letter
                if (isCaps) {
                    newChar = (int)btnChar + 32; // Shift chars into the capital range
                } else {
                    newChar = (int)btnChar - 32; // Shift chars into the capital range
                }

                button.Text = Convert.ToChar(newChar).ToString(); // Add the new char to the button
            }
            isCaps = !isCaps;
        }
    }
}
