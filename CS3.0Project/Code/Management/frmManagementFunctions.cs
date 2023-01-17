using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS3._0Project.Code.Management;
using CS3._0Project.Code.Utility.Classes;
using CS3._0Project.Forms.Utility.Classes;
using CS3._0Project.Code.Table;

namespace CS3._0Project.Code.Management {
    public partial class frmManagementFunctions : Form {

        private Size screenSize;
        private int userID;

        public frmManagementFunctions(Size screenSize, int userID) {
            InitializeComponent();
            this.screenSize = screenSize;
            this.userID = userID;
        }

        private void frmManagementFunctions_Load(object sender, EventArgs e) {
            this.Size = screenSize;
            this.Location = new Point(0, 0);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnEditTablePlan_Click(object sender, EventArgs e) {
            frmTablePlan frmTablePlan = new frmTablePlan(screenSize, userID, true);
            frmTablePlan.ShowDialog();
        }
    }
}
