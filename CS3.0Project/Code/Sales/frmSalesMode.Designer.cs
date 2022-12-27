namespace CS3._0Project.Code.Sales {
    partial class frmSalesMode {
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
            this.btnHome = new System.Windows.Forms.Button();
            this.bstblEPOSItemsTableAdapter = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter();
            this.gbxItemDisplay = new System.Windows.Forms.GroupBox();
            this.bstblEPOSItemFolders = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSItemFoldersTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemFoldersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemsTableAdapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemFolders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 75);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // bstblEPOSItemsTableAdapter
            // 
            this.bstblEPOSItemsTableAdapter.DataMember = "tblEPOSItems";
            this.bstblEPOSItemsTableAdapter.DataSource = this.ePOSDBDataSet;
            // 
            // ePOSDBDataSet
            // 
            this.ePOSDBDataSet.DataSetName = "EPOSDBDataSet";
            this.ePOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEPOSItemsTableAdapter
            // 
            this.tblEPOSItemsTableAdapter.ClearBeforeFill = true;
            // 
            // gbxItemDisplay
            // 
            this.gbxItemDisplay.Location = new System.Drawing.Point(12, 93);
            this.gbxItemDisplay.Name = "gbxItemDisplay";
            this.gbxItemDisplay.Size = new System.Drawing.Size(816, 675);
            this.gbxItemDisplay.TabIndex = 1;
            this.gbxItemDisplay.TabStop = false;
            this.gbxItemDisplay.Text = "groupBox1";
            // 
            // bstblEPOSItemFolders
            // 
            this.bstblEPOSItemFolders.DataMember = "tblEPOSItemFolders";
            this.bstblEPOSItemFolders.DataSource = this.ePOSDBDataSet;
            // 
            // tblEPOSItemFoldersTableAdapter
            // 
            this.tblEPOSItemFoldersTableAdapter.ClearBeforeFill = true;
            // 
            // frmSalesMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1074);
            this.ControlBox = false;
            this.Controls.Add(this.gbxItemDisplay);
            this.Controls.Add(this.btnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalesMode";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Mode";
            this.Load += new System.EventHandler(this.frmSalesMode_Load);
            this.Shown += new System.EventHandler(this.frmSalesMode_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemsTableAdapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemFolders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.BindingSource bstblEPOSItemsTableAdapter;
        private EPOSDBDataSet ePOSDBDataSet;
        private EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter tblEPOSItemsTableAdapter;
        private System.Windows.Forms.GroupBox gbxItemDisplay;
        private System.Windows.Forms.BindingSource bstblEPOSItemFolders;
        private EPOSDBDataSetTableAdapters.tblEPOSItemFoldersTableAdapter tblEPOSItemFoldersTableAdapter;
    }
}