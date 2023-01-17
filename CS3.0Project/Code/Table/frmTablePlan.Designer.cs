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
            this.btnPlanClose = new System.Windows.Forms.Button();
            this.btnPlanUp = new System.Windows.Forms.Button();
            this.btnPlanDown = new System.Windows.Forms.Button();
            this.bstblEPOSTableFloors = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSTableFloorsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSTableFloorsTableAdapter();
            this.lblFloor = new System.Windows.Forms.Label();
            this.bstblEPOSTables = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSTablesTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSTablesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTableFloors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTables)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFloorPanel
            // 
            this.pnlFloorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFloorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFloorPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlFloorPanel.Name = "pnlFloorPanel";
            this.pnlFloorPanel.Size = new System.Drawing.Size(1280, 668);
            this.pnlFloorPanel.TabIndex = 0;
            // 
            // btnPlanClose
            // 
            this.btnPlanClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlanClose.Location = new System.Drawing.Point(1204, 12);
            this.btnPlanClose.Name = "btnPlanClose";
            this.btnPlanClose.Size = new System.Drawing.Size(64, 38);
            this.btnPlanClose.TabIndex = 0;
            this.btnPlanClose.Text = "Close";
            this.btnPlanClose.UseVisualStyleBackColor = true;
            this.btnPlanClose.Click += new System.EventHandler(this.btnPlanClose_Click);
            // 
            // btnPlanUp
            // 
            this.btnPlanUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlanUp.Location = new System.Drawing.Point(1134, 12);
            this.btnPlanUp.Name = "btnPlanUp";
            this.btnPlanUp.Size = new System.Drawing.Size(64, 38);
            this.btnPlanUp.TabIndex = 1;
            this.btnPlanUp.Text = "Up";
            this.btnPlanUp.UseVisualStyleBackColor = true;
            this.btnPlanUp.Click += new System.EventHandler(this.btnPlanUp_Click);
            // 
            // btnPlanDown
            // 
            this.btnPlanDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlanDown.Location = new System.Drawing.Point(1064, 12);
            this.btnPlanDown.Name = "btnPlanDown";
            this.btnPlanDown.Size = new System.Drawing.Size(64, 38);
            this.btnPlanDown.TabIndex = 2;
            this.btnPlanDown.Text = "Down";
            this.btnPlanDown.UseVisualStyleBackColor = true;
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
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.BackColor = System.Drawing.Color.Transparent;
            this.lblFloor.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor.ForeColor = System.Drawing.Color.White;
            this.lblFloor.Location = new System.Drawing.Point(12, 9);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(202, 24);
            this.lblFloor.TabIndex = 0;
            this.lblFloor.Text = "Floor: {0} ({1})";
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
            // frmTablePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1280, 668);
            this.ControlBox = false;
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.btnPlanDown);
            this.Controls.Add(this.btnPlanUp);
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
    }
}