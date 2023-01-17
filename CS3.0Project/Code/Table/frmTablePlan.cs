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
using CS3._0Project.Code.Utility.Classes;
using CS3._0Project.Forms.Utility.Classes;


namespace CS3._0Project.Code.Table {
    public partial class frmTablePlan : Form {

        private Size screenSize;
        private int userID;
        private bool editMode = false;

        private int currentFloorIndex;
        public int currentFloorID;

        private List<List<int>> floors = new List<List<int>>(); // Create list of floors to sort on

        private frmTableOptions frmTableOptions;
        private frmSalesMode frmSalesMode;

        public frmTablePlan(Size screenSize, int userID, frmSalesMode frmSalesMode) { // Initial constructor for sales and table item loading
            InitializeComponent();
            this.screenSize = screenSize;
            this.frmSalesMode = frmSalesMode;
            this.userID = userID;
        }

        public frmTablePlan(Size screenSize, int userID, bool editMode) { // Use for when you are not opening tables, only editing them
            InitializeComponent();
            this.screenSize = screenSize;
            this.userID = userID;
            this.editMode = editMode;
        }

        private void frmTablePlan_Load(object sender, EventArgs e) {
            // DB Fills
            this.tblEPOSTablesTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSTables);
            this.tblEPOSTableFloorsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSTableFloors);

            if (editMode) { // If we are editing the table plan
                frmTableOptions = new frmTableOptions(userID, this, true); // Create a new instance of the options form on load
            } else {
                frmTableOptions = new frmTableOptions(userID, frmSalesMode, this, false); // Create a new instance of the options form on load
            }
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
            if (editMode) { // Update the DB with any edits if in editing mode
                updateTables();
            }
            frmTableOptions.Close(); // Close form options on close
            this.Close();
        }

        private void btnPlanUp_Click(object sender, EventArgs e) {
            if (currentFloorIndex < floors.Count - 1) { // Check to ensure there is a floor above
                if (editMode) { // Update the DB with any edits if in editing mode
                    updateTables(); 
                }
                currentFloorIndex += 1; // If so add a floor
                redrawPlan(); // Redraw the plan
            }
        } 

        private void btnPlanDown_Click(object sender, EventArgs e) {
            if (currentFloorIndex > 0) {// Check to ensure there is a floor below
                if (editMode) { // Update the DB with any edits if in editing mode
                    updateTables();
                }
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
            tblEPOSTableFloorsTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSTableFloors.*\n" +
                "FROM tblEPOSTableFloors\n" +
                "WHERE(((tblEPOSTableFloors.tableFloorID) = " + currentFloorID + " ));"; // Query for floor ID
            this.tblEPOSTableFloorsTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSTableFloors); // Fill the database
            lblFloor.Text = String.Format("Floor: {0} ({1})", ePOSDBDataSet.tblEPOSTableFloors[0][2].ToString(), currentFloorIndex); // Update floor label
            drawTables(); // Draw Tables
        }
        // TODO: Adapt class for table editing via a passd bool
        // TODO: Some error or warning if resolution is changed and tables are off the screen
        public void drawTables() { // Will place the tables in the GUI
            pnlFloorPanel.Controls.Clear(); // Clear the panel
            tblEPOSTablesTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSTables.*\r\nFROM tblEPOSTables;";
            tblEPOSTablesTableAdapter.Fill(ePOSDBDataSet.tblEPOSTables);
            foreach (DataRow table in ePOSDBDataSet.tblEPOSTables) { // For each table in the dataset
                if (Convert.ToInt32(table[2]) == currentFloorID) { // If the table has the floor id of the current floor
                    SizeableButton dynamicTableButton = new SizeableButton(editMode); // Create the custom button, if edit mode is enable, allow buttons to be resised

                    string tableText = table[1].ToString(); // New text
                    dynamicTableButton.BackColor = Color.Green; // Set button colour
                    if (frmTableOptions.isTableOpen(Convert.ToInt32(table[0]))) { // If the table is opem append text and colour
                        tableText += "\n(Open)";
                        dynamicTableButton.BackColor = Color.Red; // Set button colour if table is open
                    }

                    // Draw table
                    dynamicTableButton.ForeColor = Color.Black; // Set button text colour
                    dynamicTableButton.Parent = pnlFloorPanel; // Assign parent
                    dynamicTableButton.Name = "dtb" + table[0].ToString(); // Name = "dtb{tableID}"
                    dynamicTableButton.Text = tableText; // Text is the table number + open (if open)
                    dynamicTableButton.Location = new Point(Convert.ToInt32(table[3]), Convert.ToInt32(table[4])); // Location is taken from DB
                    dynamicTableButton.Size = new Size(Convert.ToInt32(table[5]), Convert.ToInt32(table[6])); // Size is taken from DB
                    dynamicTableButton.Click += dynamicTableButton_Click; // Click event for tables

                    if (editMode) { // If it is edit mode
                        new ControlDragger(dynamicTableButton, false, true); // Allow Moving
                    }
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

        private void updateTables() {
            tblEPOSTablesTableAdapter.Adapter.SelectCommand.CommandText = "SELECT tblEPOSTables.*\r\nFROM tblEPOSTables;";
            tblEPOSTablesTableAdapter.Fill(ePOSDBDataSet.tblEPOSTables); // Ensure DB Is updated
            foreach (Control table in pnlFloorPanel.Controls) { // For each table in the plan (on the current floor)
                foreach (DataRow dbTables in ePOSDBDataSet.tblEPOSTables) { // Go through each table in the DB
                    if (Convert.ToInt32(table.Name.Substring(3, table.Name.Length - 3)) == Convert.ToInt32(dbTables[0])) { // Until a match is found.
                        // Insert data into DB
                        dbTables[1] = table.Name; // Table Number (Not id)
                        dbTables[3] = table.Location.X; // Table X location
                        dbTables[4] = table.Location.Y; // Table Y Location
                        dbTables[5] = table.Width; // Table Width
                        dbTables[6] = table.Height; // Table Height
                    }
                }
            }
            tblEPOSTablesTableAdapter.Update(ePOSDBDataSet.tblEPOSTables); // Update DB
        }
    }
}
