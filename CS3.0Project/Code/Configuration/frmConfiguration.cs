using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CS3._0Project.Code.Configuration {
    public partial class frmConfiguration : Form {
        private Size screenSize;
        private int userID;
        private string username;

        public frmConfiguration(Size screenSize, int userID, string username) {
            InitializeComponent();
            this.screenSize = screenSize;
            this.userID = userID;
            this.username = username;
        }

        private void frmConfiguration_Load(object sender, EventArgs e) {
            this.Size = screenSize; // On show ensure screen is the correct size
            lblUsername.Text = username;
            this.Location = new Point(0, 0);

            fillPrinters();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void fillPrinters() { // Get all system printers, show them in the cbxs
            foreach (String printer in PrinterSettings.InstalledPrinters) {
                cbxBillPrinter.Items.Add(printer);
                cbxKitchenPrinter.Items.Add(printer);
            }
            cbxBillPrinter.SelectedItem = ConfigurationSettings.AppSettings.Get("billPrinter");
            cbxKitchenPrinter.SelectedItem = ConfigurationSettings.AppSettings.Get("kitchenPrinter");
        }

        // Writing new settings to config file
        private void cbxBillPrinter_SelectedIndexChanged(object sender, EventArgs e) { 
            ConfigurationSettings.AppSettings.Set("billPrinter", cbxBillPrinter.Text);
        }

        private void cbxKitchenPrinter_SelectedIndexChanged(object sender, EventArgs e) {
            ConfigurationSettings.AppSettings.Set("kitchenPrinter", cbxKitchenPrinter.Text);

        }

        
    }
}
