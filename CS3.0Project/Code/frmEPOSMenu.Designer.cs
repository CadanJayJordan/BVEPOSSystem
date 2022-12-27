namespace CS3._0Project.Forms {
    partial class frmEPOSMenu {
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSalesMode = new System.Windows.Forms.Button();
            this.btnRefundMode = new System.Windows.Forms.Button();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.btnClock = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter();
            this.eposItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eposItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eposItemDepartmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemFolderIDsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eposItemLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eposAllowZeroPriceDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eposItemPrintersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eposPrintRedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eposItemAlt1AmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eposItemAlt2AmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eposItemAlt3AmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEPOSItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1808, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSalesMode
            // 
            this.btnSalesMode.Location = new System.Drawing.Point(66, 80);
            this.btnSalesMode.Name = "btnSalesMode";
            this.btnSalesMode.Size = new System.Drawing.Size(350, 150);
            this.btnSalesMode.TabIndex = 1;
            this.btnSalesMode.Text = "Sale";
            this.btnSalesMode.UseVisualStyleBackColor = true;
            this.btnSalesMode.Click += new System.EventHandler(this.btnSalesMode_Click);
            // 
            // btnRefundMode
            // 
            this.btnRefundMode.Location = new System.Drawing.Point(66, 250);
            this.btnRefundMode.Name = "btnRefundMode";
            this.btnRefundMode.Size = new System.Drawing.Size(350, 150);
            this.btnRefundMode.TabIndex = 2;
            this.btnRefundMode.Text = "Refund";
            this.btnRefundMode.UseVisualStyleBackColor = true;
            this.btnRefundMode.Click += new System.EventHandler(this.btnRefundMode_Click);
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.Location = new System.Drawing.Point(319, 421);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(97, 64);
            this.btnConfiguration.TabIndex = 3;
            this.btnConfiguration.Text = "Config";
            this.btnConfiguration.UseVisualStyleBackColor = true;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(66, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(350, 55);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.Location = new System.Drawing.Point(707, 331);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(350, 55);
            this.btnKeyboard.TabIndex = 5;
            this.btnKeyboard.Text = "Keyboard";
            this.btnKeyboard.UseVisualStyleBackColor = true;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnClock
            // 
            this.btnClock.Location = new System.Drawing.Point(66, 421);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(247, 64);
            this.btnClock.TabIndex = 6;
            this.btnClock.Text = "Clock In/Out";
            this.btnClock.UseVisualStyleBackColor = true;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(707, 392);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(350, 55);
            this.btnMessage.TabIndex = 7;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eposItemIDDataGridViewTextBoxColumn,
            this.eposItemNameDataGridViewTextBoxColumn,
            this.eposItemDepartmentIDDataGridViewTextBoxColumn,
            this.itemFolderIDsDataGridViewTextBoxColumn,
            this.eposItemLocationDataGridViewTextBoxColumn,
            this.eposAllowZeroPriceDataGridViewCheckBoxColumn,
            this.eposItemPrintersDataGridViewTextBoxColumn,
            this.eposPrintRedDataGridViewCheckBoxColumn,
            this.eposItemAlt1AmountDataGridViewTextBoxColumn,
            this.eposItemAlt2AmountDataGridViewTextBoxColumn,
            this.eposItemAlt3AmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEPOSItemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 491);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1344, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // ePOSDBDataSet
            // 
            this.ePOSDBDataSet.DataSetName = "EPOSDBDataSet";
            this.ePOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEPOSItemsBindingSource
            // 
            this.tblEPOSItemsBindingSource.DataMember = "tblEPOSItems";
            this.tblEPOSItemsBindingSource.DataSource = this.ePOSDBDataSet;
            // 
            // tblEPOSItemsTableAdapter
            // 
            this.tblEPOSItemsTableAdapter.ClearBeforeFill = true;
            // 
            // eposItemIDDataGridViewTextBoxColumn
            // 
            this.eposItemIDDataGridViewTextBoxColumn.DataPropertyName = "eposItemID";
            this.eposItemIDDataGridViewTextBoxColumn.HeaderText = "eposItemID";
            this.eposItemIDDataGridViewTextBoxColumn.Name = "eposItemIDDataGridViewTextBoxColumn";
            // 
            // eposItemNameDataGridViewTextBoxColumn
            // 
            this.eposItemNameDataGridViewTextBoxColumn.DataPropertyName = "eposItemName";
            this.eposItemNameDataGridViewTextBoxColumn.HeaderText = "eposItemName";
            this.eposItemNameDataGridViewTextBoxColumn.Name = "eposItemNameDataGridViewTextBoxColumn";
            // 
            // eposItemDepartmentIDDataGridViewTextBoxColumn
            // 
            this.eposItemDepartmentIDDataGridViewTextBoxColumn.DataPropertyName = "eposItemDepartmentID";
            this.eposItemDepartmentIDDataGridViewTextBoxColumn.HeaderText = "eposItemDepartmentID";
            this.eposItemDepartmentIDDataGridViewTextBoxColumn.Name = "eposItemDepartmentIDDataGridViewTextBoxColumn";
            // 
            // itemFolderIDsDataGridViewTextBoxColumn
            // 
            this.itemFolderIDsDataGridViewTextBoxColumn.DataPropertyName = "itemFolderIDs";
            this.itemFolderIDsDataGridViewTextBoxColumn.HeaderText = "itemFolderIDs";
            this.itemFolderIDsDataGridViewTextBoxColumn.Name = "itemFolderIDsDataGridViewTextBoxColumn";
            // 
            // eposItemLocationDataGridViewTextBoxColumn
            // 
            this.eposItemLocationDataGridViewTextBoxColumn.DataPropertyName = "eposItemLocation";
            this.eposItemLocationDataGridViewTextBoxColumn.HeaderText = "eposItemLocation";
            this.eposItemLocationDataGridViewTextBoxColumn.Name = "eposItemLocationDataGridViewTextBoxColumn";
            // 
            // eposAllowZeroPriceDataGridViewCheckBoxColumn
            // 
            this.eposAllowZeroPriceDataGridViewCheckBoxColumn.DataPropertyName = "eposAllowZeroPrice";
            this.eposAllowZeroPriceDataGridViewCheckBoxColumn.HeaderText = "eposAllowZeroPrice";
            this.eposAllowZeroPriceDataGridViewCheckBoxColumn.Name = "eposAllowZeroPriceDataGridViewCheckBoxColumn";
            // 
            // eposItemPrintersDataGridViewTextBoxColumn
            // 
            this.eposItemPrintersDataGridViewTextBoxColumn.DataPropertyName = "eposItemPrinters";
            this.eposItemPrintersDataGridViewTextBoxColumn.HeaderText = "eposItemPrinters";
            this.eposItemPrintersDataGridViewTextBoxColumn.Name = "eposItemPrintersDataGridViewTextBoxColumn";
            // 
            // eposPrintRedDataGridViewCheckBoxColumn
            // 
            this.eposPrintRedDataGridViewCheckBoxColumn.DataPropertyName = "eposPrintRed";
            this.eposPrintRedDataGridViewCheckBoxColumn.HeaderText = "eposPrintRed";
            this.eposPrintRedDataGridViewCheckBoxColumn.Name = "eposPrintRedDataGridViewCheckBoxColumn";
            // 
            // eposItemAlt1AmountDataGridViewTextBoxColumn
            // 
            this.eposItemAlt1AmountDataGridViewTextBoxColumn.DataPropertyName = "eposItemAlt1Amount";
            this.eposItemAlt1AmountDataGridViewTextBoxColumn.HeaderText = "eposItemAlt1Amount";
            this.eposItemAlt1AmountDataGridViewTextBoxColumn.Name = "eposItemAlt1AmountDataGridViewTextBoxColumn";
            // 
            // eposItemAlt2AmountDataGridViewTextBoxColumn
            // 
            this.eposItemAlt2AmountDataGridViewTextBoxColumn.DataPropertyName = "eposItemAlt2Amount";
            this.eposItemAlt2AmountDataGridViewTextBoxColumn.HeaderText = "eposItemAlt2Amount";
            this.eposItemAlt2AmountDataGridViewTextBoxColumn.Name = "eposItemAlt2AmountDataGridViewTextBoxColumn";
            // 
            // eposItemAlt3AmountDataGridViewTextBoxColumn
            // 
            this.eposItemAlt3AmountDataGridViewTextBoxColumn.DataPropertyName = "eposItemAlt3Amount";
            this.eposItemAlt3AmountDataGridViewTextBoxColumn.HeaderText = "eposItemAlt3Amount";
            this.eposItemAlt3AmountDataGridViewTextBoxColumn.Name = "eposItemAlt3AmountDataGridViewTextBoxColumn";
            // 
            // frmEPOSMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnClock);
            this.Controls.Add(this.btnKeyboard);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnConfiguration);
            this.Controls.Add(this.btnRefundMode);
            this.Controls.Add(this.btnSalesMode);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEPOSMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EPOSMenu";
            this.Load += new System.EventHandler(this.frmEPOSMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEPOSItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSalesMode;
        private System.Windows.Forms.Button btnRefundMode;
        private System.Windows.Forms.Button btnConfiguration;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemYDataGridViewTextBoxColumn;
        private EPOSDBDataSet ePOSDBDataSet;
        private System.Windows.Forms.BindingSource tblEPOSItemsBindingSource;
        private EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter tblEPOSItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemDepartmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemFolderIDsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eposAllowZeroPriceDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemPrintersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eposPrintRedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemAlt1AmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemAlt2AmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemAlt3AmountDataGridViewTextBoxColumn;
    }
}