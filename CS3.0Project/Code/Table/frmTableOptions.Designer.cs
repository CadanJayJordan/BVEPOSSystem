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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNumber = new System.Windows.Forms.Button();
            this.bstblEPOSUsers = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSUsersTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSUsersTableAdapter();
            this.bstblEPOSItems = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter();
            this.bstblEPOSItemPrice = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSItemPriceTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemPriceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSOpenTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemPrice)).BeginInit();
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
            this.btnOpen.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(13, 93);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(92, 65);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Location = new System.Drawing.Point(111, 93);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(92, 65);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
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
            this.btnClose.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(343, 93);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 65);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(14, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 65);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(111, 93);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(92, 65);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNumber
            // 
            this.btnNumber.BackColor = System.Drawing.Color.CadetBlue;
            this.btnNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnNumber.ForeColor = System.Drawing.Color.White;
            this.btnNumber.Location = new System.Drawing.Point(209, 93);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(92, 65);
            this.btnNumber.TabIndex = 6;
            this.btnNumber.Text = "Number";
            this.btnNumber.UseVisualStyleBackColor = false;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // bstblEPOSUsers
            // 
            this.bstblEPOSUsers.DataMember = "tblEPOSUsers";
            this.bstblEPOSUsers.DataSource = this.ePOSDBDataSet;
            // 
            // tblEPOSUsersTableAdapter
            // 
            this.tblEPOSUsersTableAdapter.ClearBeforeFill = true;
            // 
            // bstblEPOSItems
            // 
            this.bstblEPOSItems.DataMember = "tblEPOSItems";
            this.bstblEPOSItems.DataSource = this.ePOSDBDataSet;
            // 
            // tblEPOSItemsTableAdapter
            // 
            this.tblEPOSItemsTableAdapter.ClearBeforeFill = true;
            // 
            // bstblEPOSItemPrice
            // 
            this.bstblEPOSItemPrice.DataMember = "tblEPOSItemPrice";
            this.bstblEPOSItemPrice.DataSource = this.ePOSDBDataSet;
            // 
            // tblEPOSItemPriceTableAdapter
            // 
            this.tblEPOSItemPriceTableAdapter.ClearBeforeFill = true;
            // 
            // frmTableOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(447, 170);
            this.ControlBox = false;
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtOptionsDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTableOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTableOptions_Load);
            this.Shown += new System.EventHandler(this.frmTableOptions_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSOpenTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemPrice)).EndInit();
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.BindingSource bstblEPOSUsers;
        private EPOSDBDataSetTableAdapters.tblEPOSUsersTableAdapter tblEPOSUsersTableAdapter;
        private System.Windows.Forms.BindingSource bstblEPOSItems;
        private EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter tblEPOSItemsTableAdapter;
        private System.Windows.Forms.BindingSource bstblEPOSItemPrice;
        private EPOSDBDataSetTableAdapters.tblEPOSItemPriceTableAdapter tblEPOSItemPriceTableAdapter;
    }
}