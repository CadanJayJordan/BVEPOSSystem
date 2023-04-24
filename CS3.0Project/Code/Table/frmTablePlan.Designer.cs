namespace CS3._0Project.Code.Table {
    partial class frmTablePlan {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pnlFloorPanel = new System.Windows.Forms.Panel();
            this.lblFloor = new System.Windows.Forms.Label();
            this.btnPlanClose = new System.Windows.Forms.Button();
            this.btnPlanUp = new System.Windows.Forms.Button();
            this.btnPlanDown = new System.Windows.Forms.Button();
            this.bstblEPOSTableFloors = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSTableFloorsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSTableFloorsTableAdapter();
            this.bstblEPOSTables = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSTablesTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSTablesTableAdapter();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTableFloors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTables)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFloorPanel
            // 
            this.pnlFloorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFloorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.pnlFloorPanel.BackgroundImage = global::CS3._0Project.Properties.Resources.BVIcon;
            this.pnlFloorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlFloorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFloorPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlFloorPanel.Name = "pnlFloorPanel";
            this.pnlFloorPanel.Size = new System.Drawing.Size(1280, 668);
            this.pnlFloorPanel.TabIndex = 0;
            // 
            // lblFloor
            // 
            this.lblFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFloor.AutoSize = true;
            this.lblFloor.BackColor = System.Drawing.Color.Transparent;
            this.lblFloor.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor.ForeColor = System.Drawing.Color.White;
            this.lblFloor.Location = new System.Drawing.Point(12, 622);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(182, 37);
            this.lblFloor.TabIndex = 0;
            this.lblFloor.Text = "Floor: {0} ({1})";
            // 
            // btnPlanClose
            // 
            this.btnPlanClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlanClose.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPlanClose.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnPlanClose.ForeColor = System.Drawing.Color.White;
            this.btnPlanClose.Location = new System.Drawing.Point(1167, 12);
            this.btnPlanClose.Name = "btnPlanClose";
            this.btnPlanClose.Size = new System.Drawing.Size(101, 60);
            this.btnPlanClose.TabIndex = 0;
            this.btnPlanClose.Text = "Close";
            this.btnPlanClose.UseVisualStyleBackColor = false;
            this.btnPlanClose.Click += new System.EventHandler(this.btnPlanClose_Click);
            // 
            // btnPlanUp
            // 
            this.btnPlanUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlanUp.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPlanUp.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnPlanUp.ForeColor = System.Drawing.Color.White;
            this.btnPlanUp.Location = new System.Drawing.Point(1060, 12);
            this.btnPlanUp.Name = "btnPlanUp";
            this.btnPlanUp.Size = new System.Drawing.Size(101, 60);
            this.btnPlanUp.TabIndex = 1;
            this.btnPlanUp.Text = "Up";
            this.btnPlanUp.UseVisualStyleBackColor = false;
            this.btnPlanUp.Click += new System.EventHandler(this.btnPlanUp_Click);
            // 
            // btnPlanDown
            // 
            this.btnPlanDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlanDown.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPlanDown.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnPlanDown.ForeColor = System.Drawing.Color.White;
            this.btnPlanDown.Location = new System.Drawing.Point(953, 12);
            this.btnPlanDown.Name = "btnPlanDown";
            this.btnPlanDown.Size = new System.Drawing.Size(101, 60);
            this.btnPlanDown.TabIndex = 2;
            this.btnPlanDown.Text = "Down";
            this.btnPlanDown.UseVisualStyleBackColor = false;
            this.btnPlanDown.Click += new System.EventHandler(this.btnPlanDown_Click);
            // 
            // bstblEPOSTableFloors
            // 
            this.bstblEPOSTableFloors.DataMember = "tblEPOSTableFloors";
            this.bstblEPOSTableFloors.DataSource = this.ePOSDBDataSet;
            // 
            // ePOSDBDataSet
            // 
            this.ePOSDBDataSet.DataSetName = "EPOSDBDataSet";
            this.ePOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEPOSTableFloorsTableAdapter
            // 
            this.tblEPOSTableFloorsTableAdapter.ClearBeforeFill = true;
            // 
            // bstblEPOSTables
            // 
            this.bstblEPOSTables.DataMember = "tblEPOSTables";
            this.bstblEPOSTables.DataSource = this.ePOSDBDataSet;
            // 
            // tblEPOSTablesTableAdapter
            // 
            this.tblEPOSTablesTableAdapter.ClearBeforeFill = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Black;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(0, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(36, 30);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "{0}";
            // 
            // frmTablePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1280, 668);
            this.ControlBox = false;
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnPlanUp);
            this.Controls.Add(this.btnPlanDown);
            this.Controls.Add(this.btnPlanClose);
            this.Controls.Add(this.pnlFloorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTablePlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Plan";
            this.Load += new System.EventHandler(this.frmTablePlan_Load);
            this.Shown += new System.EventHandler(this.frmTablePlan_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTableFloors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlanClose;
        private System.Windows.Forms.Button btnPlanUp;
        private System.Windows.Forms.Button btnPlanDown;
        private System.Windows.Forms.BindingSource bstblEPOSTableFloors;
        private EPOSDBDataSet ePOSDBDataSet;
        private EPOSDBDataSetTableAdapters.tblEPOSTableFloorsTableAdapter tblEPOSTableFloorsTableAdapter;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.BindingSource bstblEPOSTables;
        private EPOSDBDataSetTableAdapters.tblEPOSTablesTableAdapter tblEPOSTablesTableAdapter;
        public System.Windows.Forms.Panel pnlFloorPanel;
        private System.Windows.Forms.Label lblUsername;
    }
}