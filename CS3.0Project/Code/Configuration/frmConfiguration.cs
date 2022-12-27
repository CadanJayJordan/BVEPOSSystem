using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS3._0Project.Code.Utility.Forms;

namespace CS3._0Project.Code.Configuration {
    public partial class frmConfiguration : Form {
        private Size screenSize;
        private int loginCode;

        public frmConfiguration(Size screenSize, int loginCode) {
            InitializeComponent();
            this.screenSize = screenSize;
            this.loginCode = loginCode;
        }

        private void frmConfiguration_Shown(object sender, EventArgs e) {
            this.Size = screenSize; // On show ensure screen is the correct size
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
