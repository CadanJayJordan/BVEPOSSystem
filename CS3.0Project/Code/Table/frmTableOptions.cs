using CS3._0Project.Code.Sales;
using CS3._0Project.Forms.Utility.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3._0Project.Code.Table {
    public partial class frmTableOptions : Form {

        int tableID;

        private frmSalesMode frmSalesMode;
        private frmTablePlan frmTablePlan;

        public frmTableOptions(frmSalesMode frmSalesMode, frmTablePlan frmTablePlan) {
            InitializeComponent();
            new FormDragger(this); // Enable dragging
            this.frmSalesMode = frmSalesMode;
            this.frmTablePlan = frmTablePlan;
        }

        public void updateTableInfo(int tableID) {
            this.tableID = tableID; // Update table ID
            updateForm();
        }

        private void frmTableOptions_Load(object sender, EventArgs e) {
            this.tblEPOSTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSTables); // Fill adapter on form load
            this.tblEPOSOpenTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSOpenTables);
        }

        private void frmTableOptions_Shown(object sender, EventArgs e) {
            updateForm(); // On show ensure the table info is correct for what is selected
        }

        private void updateForm() {
            foreach (DataRow table in ePOSDBDataSet.tblEPOSTables) {  // for each table
                if (Convert.ToInt32(table[0]) == tableID) { // ifthe current table is the same as the db row
                    txtOptionsDisplay.Text = String.Format("Table: {0}", table[1].ToString()); // update the text
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) { // Closes form on close button press
            this.Hide(); // Hides the form
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            List<int> selectedTillItems = new List<int>();
            List<int> selectedTillQuantity = new List<int>();
            tblEPOSOpenTablesTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSOpenTables.*\r\nFROM tblEPOSOpenTables\r\nWHERE (((tblEPOSOpenTables.openTableID)=" + tableID.ToString() + "));\r\n";
            this.tblEPOSOpenTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSOpenTables);

            string tableItemString = ePOSDBDataSet.tblEPOSOpenTables[0][2].ToString();
            string[] tableItemList = tableItemString.Split(';');

            foreach(string tableItem in tableItemList) {
                string[] tableArray = tableItem.Split(',');
                selectedTillItems.Add(Convert.ToInt32(tableArray[0]));
                selectedTillQuantity.Add(Convert.ToInt32(tableArray[1]));
            }

            frmSalesMode.openTable(selectedTillItems, selectedTillQuantity);
            this.Hide();
            frmTablePlan.Hide();
        }
    }
}
