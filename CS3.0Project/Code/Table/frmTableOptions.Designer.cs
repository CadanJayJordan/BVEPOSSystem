namespace CS3._0Project.Code.Table {
    partial class frmTableOptions {
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
            this.txtOptionsDisplay = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.bstblEPOSTables = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSTablesTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSTablesTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.bstblEPOSOpenTables = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSOpenTablesTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSOpenTablesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSOpenTables)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOptionsDisplay
            // 
            this.txtOptionsDisplay.BackColor = System.Drawing.Color.Black;
            this.txtOptionsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOptionsDisplay.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionsDisplay.ForeColor = System.Drawing.Color.White;
            this.txtOptionsDisplay.Location = new System.Drawing.Point(13, 13);
            this.txtOptionsDisplay.Multiline = true;
            this.txtOptionsDisplay.Name = "txtOptionsDisplay";
            this.txtOptionsDisplay.ReadOnly = true;
            this.txtOptionsDisplay.Size = new System.Drawing.Size(422, 74);
            this.txtOptionsDisplay.TabIndex = 0;
            this.txtOptionsDisplay.Text = "35";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 93);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 39);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(93, 93);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 39);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            // 
            // bstblEPOSTables
            // 
            this.bstblEPOSTables.DataMember = "tblEPOSTables";
            this.bstblEPOSTables.DataSource = this.ePOSDBDataSet;
            // 
            // ePOSDBDataSet
            // 
            this.ePOSDBDataSet.DataSetName = "EPOSDBDataSet";
            this.ePOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEPOSTablesTableAdapter
            // 
            this.tblEPOSTablesTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(360, 93);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bstblEPOSOpenTables
            // 
            this.bstblEPOSOpenTables.DataMember = "tblEPOSOpenTables";
            this.bstblEPOSOpenTables.DataSource = this.ePOSDBDataSet;
            // 
            // tblEPOSOpenTablesTableAdapter
            // 
            this.tblEPOSOpenTablesTableAdapter.ClearBeforeFill = true;
            // 
            // frmTableOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 144);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtOptionsDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTableOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Options";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTableOptions_Load);
            this.Shown += new System.EventHandler(this.frmTableOptions_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSOpenTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOptionsDisplay;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.BindingSource bstblEPOSTables;
        private EPOSDBDataSet ePOSDBDataSet;
        private EPOSDBDataSetTableAdapters.tblEPOSTablesTableAdapter tblEPOSTablesTableAdapter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource bstblEPOSOpenTables;
        private EPOSDBDataSetTableAdapters.tblEPOSOpenTablesTableAdapter tblEPOSOpenTablesTableAdapter;
    }
}