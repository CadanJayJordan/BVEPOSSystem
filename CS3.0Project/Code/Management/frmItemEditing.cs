using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3._0Project.Code.Management {
    public partial class frmItemEditing : Form {

        private int userID;

        public frmItemEditing(Size screenSize, int userID) {
            InitializeComponent();
            this.Size = screenSize;
            this.userID = userID;
            this.Location = new Point(0, 0);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmItemEditing_Load(object sender, EventArgs e) {
            formLoad();
        }

        private void formLoad() {
            this.tblEPOSItemsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItems);
            this.tblEPOSItemPriceTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSItemPrice);
        }

        private List<int> getItemIDs() {
            List<int> itemIDs = new List<int>();
            foreach (DataRow item in this.ePOSDBDataSet.tblEPOSItems) {
                itemIDs.Add(Convert.ToInt32(item[0]));
            }
            return itemIDs;
        }

        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e) {
            List<int> itemIDs = getItemIDs();
            int selectedItemID = Convert.ToInt32(cbxItems.SelectedValue);
            int selectedItemIndex = getIndexOfItem(itemIDs, selectedItemID);
            updateForm(selectedItemIndex);
        }

        private int getIndexOfItem(List<int> itemIDs, int searchItemID) {
            int rowIndex = -1;
            for (int i = 0; i < itemIDs.Count; i++) {
                if (itemIDs[i] == searchItemID) {
                    rowIndex = i;
                }
            }
            return rowIndex;
        }

        private void updateForm(int itemRowIndex) {
            lblName.Text = ePOSDBDataSet.tblEPOSItems.Rows[itemRowIndex][1].ToString();
        }
    }
}
