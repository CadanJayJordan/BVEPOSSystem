using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS3._0Project.Forms;

namespace CS3._0Project {
    public partial class frmStartup : Form {
        public frmStartup() {
            InitializeComponent();
        }
        
        private void frmStartup_Load(object sender, EventArgs e) { // form load
            frmEPOSMenu frm = new frmEPOSMenu();
            this.Hide();
            frm.ShowDialog();
            Application.Exit();
        }
    }
}
