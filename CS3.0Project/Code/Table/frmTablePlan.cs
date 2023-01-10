using CS3._0Project.Code.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3._0Project.Code.Table {
    public partial class frmTablePlan : Form {

        private Size screenSize;
        private int currentFloorIndex;
        private int currentFloorID;

        private List<List<int>> floors = new List<List<int>>(); // Create list of floors to sort on

        private frmTableOptions frmTableOptions;
        private frmSalesMode frmSalesMode;

        public frmTablePlan(Size screenSize, frmSalesMode frmSalesMode) {
            InitializeComponent();
            this.screenSize = screenSize;
            this.frmSalesMode = frmSalesMode;    
        }

        private void frmTablePlan_Load(object sender, EventArgs e) {
            // DB Fills
            this.tblEPOSTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSTables);
            this.tblEPOSTableFloorsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSTableFloors);

            frmTableOptions = new frmTableOptions(frmSalesMode, this); // Create a new instance of the options form on load
             
            currentFloorIndex = 0; // Ensure floors are reset
            getFloors(); // Gett all current floors
            sortFloors(0, floors.Count - 1); // Sort them via quicksort in order of the floor sorting number
            redrawPlan(); // Draw the plan
        }

        private void frmTablePlan_Shown(object sender, EventArgs e) {
            this.Location = new Point(0, 0); // Ensure size and location of form are correct
            this.Size = screenSize;
        }
        private void btnPlanClose_Click(object sender, EventArgs e) {
            frmTableOptions.Close(); // Close form options on close
            this.Close();
        }

        private void btnPlanUp_Click(object sender, EventArgs e) {
            if (currentFloorIndex < floors.Count - 1) { // Check to ensure there is a floor above
                currentFloorIndex += 1; // If so add a floor
                redrawPlan(); // Redraw the plan
            }
        } 

        private void btnPlanDown_Click(object sender, EventArgs e) {
            if (currentFloorIndex > 0) {// Check to ensure there is a floor below
                currentFloorIndex -= 1; // If so remove a floor
                redrawPlan(); // Redraw the plan 
            }
        }

        private void getFloors() {
            tblEPOSTableFloorsTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSTableFloors.*\n" +
                "FROM tblEPOSTableFloors;";
            this.tblEPOSTableFloorsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSTableFloors);
            floors.Clear(); // Clear current floor details
            foreach (DataRow floor in ePOSDBDataSet.tblEPOSTableFloors) { // FOr every floor in the DB
                List<int> floorData = new List<int>(); // New List
                floorData.Add(Convert.ToInt32(floor[0])); // Add floor ID to the list
                floorData.Add(Convert.ToInt32(floor[1])); // Add order number to the list
                floors.Add(floorData); // Add the new list to the floor list
            }
        }

        private void sortFloors(int start, int end) { // Quicksort to sort the list based on the floor order
            // Variable Init
            List<int> tempSwapIntList;
            int LIP = start;
            int HIP = end;
            int MIPVal = floors[Convert.ToInt32((end + start) / 2)][1];
            // Repeat
            while (!(LIP > HIP)) {
                // Finding items on the wrong side of hte MIP
                while (floors[LIP][1] < MIPVal) {
                    LIP++;
                }
                while (MIPVal < floors[HIP][1]) {
                    HIP--;
                }
                // Swap if either one pointer hits the middle, or both have an item on the wrong side.
                if (LIP <= HIP) {
                    // Perform Swap
                    tempSwapIntList = floors[LIP];
                    floors[LIP] = floors[HIP];
                    floors[HIP] = tempSwapIntList;
                    LIP++;
                    HIP--;
                }
            }
            // Recurison
            if (start < HIP) {
                sortFloors(LIP, end);
            }
            if (LIP < end) {
                sortFloors(start, HIP);
            }
        }

        private void redrawPlan() {
            currentFloorID = floors[currentFloorIndex][0]; // Ensure the floor ID is updated
            pnlFloorPanel.Controls.Clear(); // Clear the panel
            tblEPOSTableFloorsTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSTableFloors.*\n" +
                "FROM tblEPOSTableFloors\n" +
                "WHERE(((tblEPOSTableFloors.tableFloorID) = " + currentFloorID + " ));"; // Query for floor ID
            this.tblEPOSTableFloorsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSTableFloors); // Fill the database
            lblFloor.Text = String.Format("Floor: {0} ({1})", ePOSDBDataSet.tblEPOSTableFloors[0][2].ToString(), currentFloorIndex); // Update floor label
            drawTables(); // Draw Tables
        }

        private void drawTables() { // Will place the tables in the GUI
            foreach (DataRow table in ePOSDBDataSet.tblEPOSTables) { // For each table in the dataset
                if (Convert.ToInt32(table[2]) == currentFloorID) { // If the table has the floor id of the current floor
                    // Draw table
                    Button dynamicTableButton = new Button(); // New "button"
                    dynamicTableButton.BackColor = Color.White; // Set button colour
                    dynamicTableButton.ForeColor = Color.Black; // Set button text colour
                    dynamicTableButton.Parent = pnlFloorPanel; // Assign parent
                    dynamicTableButton.Name = "dtb" + table[0].ToString(); // Name = "dtb{tableID}"
                    dynamicTableButton.Text = table[1].ToString(); // Text is the table number
                    dynamicTableButton.Location = new Point(Convert.ToInt32(table[3]), Convert.ToInt32(table[4])); // Location is taken from DB
                    dynamicTableButton.Size = new Size(Convert.ToInt32(table[5]), Convert.ToInt32(table[6])); // Size is taken from DB
                    dynamicTableButton.Click += dynamicTableButton_Click; // Click event for tables
                }
            }
        }

        private void dynamicTableButton_Click(object sender, EventArgs e) { // When a table is clicked
            Button dynamicTableButton = (Button)sender; // Cast sender to type button
            int currentTableID = Convert.ToInt32(dynamicTableButton.Name.Substring(3, dynamicTableButton.Name.Length - 3)); // Get the table ID off the button name
            frmTableOptions.updateTableInfo(currentTableID); // Update table info
            if (!frmTableOptions.Visible) { // If the options are not already visible
                frmTableOptions.Show(); // Show the form
            } 
        }
    }
}
