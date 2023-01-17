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
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.btnFolderBack = new System.Windows.Forms.Button();
            this.pnlItemDisplay = new System.Windows.Forms.Panel();
            this.pnlTillDisplay = new System.Windows.Forms.Panel();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnTableStore = new System.Windows.Forms.Button();
            this.btnTill00 = new System.Windows.Forms.Button();
            this.btnTill0 = new System.Windows.Forms.Button();
            this.btnTillDecimal = new System.Windows.Forms.Button();
            this.btnTill9 = new System.Windows.Forms.Button();
            this.btnTill8 = new System.Windows.Forms.Button();
            this.btnTill7 = new System.Windows.Forms.Button();
            this.btnTill6 = new System.Windows.Forms.Button();
            this.btnTill5 = new System.Windows.Forms.Button();
            this.btnTill4 = new System.Windows.Forms.Button();
            this.btnTill3 = new System.Windows.Forms.Button();
            this.btnTill2 = new System.Windows.Forms.Button();
            this.btnTill1 = new System.Windows.Forms.Button();
            this.btnTillErrorCorrect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxTillTotal = new System.Windows.Forms.TextBox();
            this.btnTillCard = new System.Windows.Forms.Button();
            this.btnTillCash = new System.Windows.Forms.Button();
            this.tbxTillDisplay = new System.Windows.Forms.TextBox();
            this.lbxTillDisplay = new System.Windows.Forms.ListBox();
            this.tblEPOSItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter();
            this.bstblEPOSItemFolders = new System.Windows.Forms.BindingSource(this.components);
            this.bstblEPOSItemPrice = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSItemFoldersTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemFoldersTableAdapter();
            this.tblEPOSItemPriceTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemPriceTableAdapter();
            this.bstblEPOSCashCheques = new System.Windows.Forms.BindingSource(this.components);
            this.bstblEPOSItemsTableAdapter = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSCashChequesTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSCashChequesTableAdapter();
            this.btnTablePlan = new System.Windows.Forms.Button();
            this.bstblEPOSOpenTables = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSOpenTablesTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSOpenTablesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            this.pnlTillDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSCashCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemsTableAdapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSOpenTables)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 75);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ePOSDBDataSet
            // 
            this.ePOSDBDataSet.DataSetName = "EPOSDBDataSet";
            this.ePOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFolderBack
            // 
            this.btnFolderBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnFolderBack.ForeColor = System.Drawing.Color.White;
            this.btnFolderBack.Location = new System.Drawing.Point(529, 11);
            this.btnFolderBack.Name = "btnFolderBack";
            this.btnFolderBack.Size = new System.Drawing.Size(75, 75);
            this.btnFolderBack.TabIndex = 2;
            this.btnFolderBack.Text = "Back";
            this.btnFolderBack.UseVisualStyleBackColor = false;
            this.btnFolderBack.Click += new System.EventHandler(this.btnFolderBack_Click);
            // 
            // pnlItemDisplay
            // 
            this.pnlItemDisplay.Location = new System.Drawing.Point(12, 93);
            this.pnlItemDisplay.Name = "pnlItemDisplay";
            this.pnlItemDisplay.Size = new System.Drawing.Size(592, 669);
            this.pnlItemDisplay.TabIndex = 0;
            // 
            // pnlTillDisplay
            // 
            this.pnlTillDisplay.Controls.Add(this.btnMultiply);
            this.pnlTillDisplay.Controls.Add(this.btnTableStore);
            this.pnlTillDisplay.Controls.Add(this.btnTill00);
            this.pnlTillDisplay.Controls.Add(this.btnTill0);
            this.pnlTillDisplay.Controls.Add(this.btnTillDecimal);
            this.pnlTillDisplay.Controls.Add(this.btnTill9);
            this.pnlTillDisplay.Controls.Add(this.btnTill8);
            this.pnlTillDisplay.Controls.Add(this.btnTill7);
            this.pnlTillDisplay.Controls.Add(this.btnTill6);
            this.pnlTillDisplay.Controls.Add(this.btnTill5);
            this.pnlTillDisplay.Controls.Add(this.btnTill4);
            this.pnlTillDisplay.Controls.Add(this.btnTill3);
            this.pnlTillDisplay.Controls.Add(this.btnTill2);
            this.pnlTillDisplay.Controls.Add(this.btnTill1);
            this.pnlTillDisplay.Controls.Add(this.btnTillErrorCorrect);
            this.pnlTillDisplay.Controls.Add(this.btnCancel);
            this.pnlTillDisplay.Controls.Add(this.tbxTillTotal);
            this.pnlTillDisplay.Controls.Add(this.btnTillCard);
            this.pnlTillDisplay.Controls.Add(this.btnTillCash);
            this.pnlTillDisplay.Controls.Add(this.tbxTillDisplay);
            this.pnlTillDisplay.Controls.Add(this.lbxTillDisplay);
            this.pnlTillDisplay.Location = new System.Drawing.Point(624, 12);
            this.pnlTillDisplay.Name = "pnlTillDisplay";
            this.pnlTillDisplay.Size = new System.Drawing.Size(400, 750);
            this.pnlTillDisplay.TabIndex = 3;
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMultiply.ForeColor = System.Drawing.Color.White;
            this.btnMultiply.Location = new System.Drawing.Point(226, 650);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 51);
            this.btnMultiply.TabIndex = 21;
            this.btnMultiply.Text = "Quantity";
            this.btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnTableStore
            // 
            this.btnTableStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTableStore.ForeColor = System.Drawing.Color.White;
            this.btnTableStore.Location = new System.Drawing.Point(226, 593);
            this.btnTableStore.Name = "btnTableStore";
            this.btnTableStore.Size = new System.Drawing.Size(75, 51);
            this.btnTableStore.TabIndex = 20;
            this.btnTableStore.Text = "Table Store";
            this.btnTableStore.UseVisualStyleBackColor = false;
            // 
            // btnTill00
            // 
            this.btnTill00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTill00.ForeColor = System.Drawing.Color.White;
            this.btnTill00.Location = new System.Drawing.Point(16, 650);
            this.btnTill00.Name = "btnTill00";
            this.btnTill00.Size = new System.Drawing.Size(50, 51);
            this.btnTill00.TabIndex = 18;
            this.btnTill00.Text = "00";
            this.btnTill00.UseVisualStyleBackColor = false;
            // 
            // btnTill0
            // 
            this.btnTill0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTill0.ForeColor = System.Drawing.Color.White;
            this.btnTill0.Location = new System.Drawing.Point(72, 650);
            this.btnTill0.Name = "btnTill0";
            this.btnTill0.Size = new System.Drawing.Size(50, 51);
            this.btnTill0.TabIndex = 17;
            this.btnTill0.Text = "0";
            this.btnTill0.UseVisualStyleBackColor = false;
            // 
            // btnTillDecimal
            // 
            this.btnTillDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTillDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTillDecimal.ForeColor = System.Drawing.Color.White;
            this.btnTillDecimal.Location = new System.Drawing.Point(128, 650);
            this.btnTillDecimal.Name = "btnTillDecimal";
            this.btnTillDecimal.Size = new System.Drawing.Size(50, 51);
            this.btnTillDecimal.TabIndex = 16;
            this.btnTillDecimal.Text = ".";
            this.btnTillDecimal.UseVisualStyleBackColor = false;
            // 
            // btnTill9
            // 
            this.btnTill9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTill9.ForeColor = System.Drawing.Color.White;
            this.btnTill9.Location = new System.Drawing.Point(128, 593);
            this.btnTill9.Name = "btnTill9";
            this.btnTill9.Size = new System.Drawing.Size(50, 51);
            this.btnTill9.TabIndex = 15;
            this.btnTill9.Text = "9";
            this.btnTill9.UseVisualStyleBackColor = false;
            // 
            // btnTill8
            // 
            this.btnTill8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTill8.ForeColor = System.Drawing.Color.White;
            this.btnTill8.Location = new System.Drawing.Point(72, 593);
            this.btnTill8.Name = "btnTill8";
            this.btnTill8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTill8.Size = new System.Drawing.Size(50, 51);
            this.btnTill8.TabIndex = 14;
            this.btnTill8.Text = "8";
            this.btnTill8.UseVisualStyleBackColor = false;
            // 
            // btnTill7
            // 
            this.btnTill7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTill7.ForeColor = System.Drawing.Color.White;
            this.btnTill7.Location = new System.Drawing.Point(16, 593);
            this.btnTill7.Name = "btnTill7";
            this.btnTill7.Size = new System.Drawing.Size(50, 51);
            this.btnTill7.TabIndex = 13;
            this.btnTill7.Text = "7";
            this.btnTill7.UseVisualStyleBackColor = false;
            // 
            // btnTill6
            // 
            this.btnTill6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTill6.ForeColor = System.Drawing.Color.White;
            this.btnTill6.Location = new System.Drawing.Point(128, 536);
            this.btnTill6.Name = "btnTill6";
            this.btnTill6.Size = new System.Drawing.Size(50, 51);
            this.btnTill6.TabIndex = 12;
            this.btnTill6.Text = "6";
            this.btnTill6.UseVisualStyleBackColor = false;
            // 
            // btnTill5
            // 
            this.btnTill5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTill5.ForeColor = System.Drawing.Color.White;
            this.btnTill5.Location = new System.Drawing.Point(72, 536);
            this.btnTill5.Name = "btnTill5";
            this.btnTill5.Size = new System.Drawing.Size(50, 51);
            this.btnTill5.TabIndex = 11;
            this.btnTill5.Text = "5";
            this.btnTill5.UseVisualStyleBackColor = false;
            // 
            // btnTill4
            // 
            this.btnTill4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTill4.ForeColor = System.Drawing.Color.White;
            this.btnTill4.Location = new System.Drawing.Point(16, 536);
            this.btnTill4.Name = "btnTill4";
            this.btnTill4.Size = new System.Drawing.Size(50, 51);
            this.btnTill4.TabIndex = 10;
            this.btnTill4.Text = "4";
            this.btnTill4.UseVisualStyleBackColor = false;
            // 
            // btnTill3
            // 
            this.btnTill3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTill3.ForeColor = System.Drawing.Color.White;
            this.btnTill3.Location = new System.Drawing.Point(128, 479);
            this.btnTill3.Name = "btnTill3";
            this.btnTill3.Size = new System.Drawing.Size(50, 51);
            this.btnTill3.TabIndex = 9;
            this.btnTill3.Text = "3";
            this.btnTill3.UseVisualStyleBackColor = false;
            // 
            // btnTill2
            // 
            this.btnTill2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTill2.ForeColor = System.Drawing.Color.White;
            this.btnTill2.Location = new System.Drawing.Point(72, 479);
            this.btnTill2.Name = "btnTill2";
            this.btnTill2.Size = new System.Drawing.Size(50, 51);
            this.btnTill2.TabIndex = 8;
            this.btnTill2.Text = "2";
            this.btnTill2.UseVisualStyleBackColor = false;
            // 
            // btnTill1
            // 
            this.btnTill1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTill1.ForeColor = System.Drawing.Color.White;
            this.btnTill1.Location = new System.Drawing.Point(16, 479);
            this.btnTill1.Name = "btnTill1";
            this.btnTill1.Size = new System.Drawing.Size(50, 51);
            this.btnTill1.TabIndex = 7;
            this.btnTill1.Text = "1";
            this.btnTill1.UseVisualStyleBackColor = false;
            // 
            // btnTillErrorCorrect
            // 
            this.btnTillErrorCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTillErrorCorrect.ForeColor = System.Drawing.Color.White;
            this.btnTillErrorCorrect.Location = new System.Drawing.Point(307, 650);
            this.btnTillErrorCorrect.Name = "btnTillErrorCorrect";
            this.btnTillErrorCorrect.Size = new System.Drawing.Size(75, 51);
            this.btnTillErrorCorrect.TabIndex = 6;
            this.btnTillErrorCorrect.Text = "Error Correct";
            this.btnTillErrorCorrect.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(307, 593);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 51);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // tbxTillTotal
            // 
            this.tbxTillTotal.BackColor = System.Drawing.Color.Black;
            this.tbxTillTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTillTotal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTillTotal.ForeColor = System.Drawing.Color.White;
            this.tbxTillTotal.Location = new System.Drawing.Point(16, 450);
            this.tbxTillTotal.Name = "tbxTillTotal";
            this.tbxTillTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxTillTotal.Size = new System.Drawing.Size(366, 23);
            this.tbxTillTotal.TabIndex = 4;
            this.tbxTillTotal.Text = "36";
            // 
            // btnTillCard
            // 
            this.btnTillCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTillCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTillCard.ForeColor = System.Drawing.Color.White;
            this.btnTillCard.Location = new System.Drawing.Point(226, 479);
            this.btnTillCard.Name = "btnTillCard";
            this.btnTillCard.Size = new System.Drawing.Size(156, 51);
            this.btnTillCard.TabIndex = 3;
            this.btnTillCard.Text = "Card";
            this.btnTillCard.UseVisualStyleBackColor = false;
            // 
            // btnTillCash
            // 
            this.btnTillCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTillCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTillCash.ForeColor = System.Drawing.Color.White;
            this.btnTillCash.Location = new System.Drawing.Point(226, 536);
            this.btnTillCash.Name = "btnTillCash";
            this.btnTillCash.Size = new System.Drawing.Size(156, 51);
            this.btnTillCash.TabIndex = 2;
            this.btnTillCash.Text = "Cash";
            this.btnTillCash.UseVisualStyleBackColor = false;
            // 
            // tbxTillDisplay
            // 
            this.tbxTillDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxTillDisplay.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTillDisplay.ForeColor = System.Drawing.Color.White;
            this.tbxTillDisplay.Location = new System.Drawing.Point(16, 13);
            this.tbxTillDisplay.Name = "tbxTillDisplay";
            this.tbxTillDisplay.ReadOnly = true;
            this.tbxTillDisplay.Size = new System.Drawing.Size(366, 39);
            this.tbxTillDisplay.TabIndex = 1;
            this.tbxTillDisplay.Text = "25";
            // 
            // lbxTillDisplay
            // 
            this.lbxTillDisplay.BackColor = System.Drawing.Color.Black;
            this.lbxTillDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxTillDisplay.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTillDisplay.ForeColor = System.Drawing.Color.White;
            this.lbxTillDisplay.FormattingEnabled = true;
            this.lbxTillDisplay.ItemHeight = 22;
            this.lbxTillDisplay.Items.AddRange(new object[] {
            "36"});
            this.lbxTillDisplay.Location = new System.Drawing.Point(16, 57);
            this.lbxTillDisplay.Name = "lbxTillDisplay";
            this.lbxTillDisplay.Size = new System.Drawing.Size(366, 396);
            this.lbxTillDisplay.TabIndex = 0;
            // 
            // tblEPOSItemsTableAdapter
            // 
            this.tblEPOSItemsTableAdapter.ClearBeforeFill = true;
            // 
            // bstblEPOSItemFolders
            // 
            this.bstblEPOSItemFolders.DataMember = "tblEPOSItemFolders";
            this.bstblEPOSItemFolders.DataSource = this.ePOSDBDataSet;
            // 
            // bstblEPOSItemPrice
            // 
            this.bstblEPOSItemPrice.DataMember = "tblEPOSItemPrice";
            this.bstblEPOSItemPrice.DataSource = this.ePOSDBDataSet;
            // 
            // tblEPOSItemFoldersTableAdapter
            // 
            this.tblEPOSItemFoldersTableAdapter.ClearBeforeFill = true;
            // 
            // tblEPOSItemPriceTableAdapter
            // 
            this.tblEPOSItemPriceTableAdapter.ClearBeforeFill = true;
            // 
            // bstblEPOSCashCheques
            // 
            this.bstblEPOSCashCheques.DataMember = "tblEPOSCashCheques";
            this.bstblEPOSCashCheques.DataSource = this.ePOSDBDataSet;
            // 
            // bstblEPOSItemsTableAdapter
            // 
            this.bstblEPOSItemsTableAdapter.DataMember = "tblEPOSItems";
            this.bstblEPOSItemsTableAdapter.DataSource = this.ePOSDBDataSet;
            // 
            // tblEPOSCashChequesTableAdapter
            // 
            this.tblEPOSCashChequesTableAdapter.ClearBeforeFill = true;
            // 
            // btnTablePlan
            // 
            this.btnTablePlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTablePlan.ForeColor = System.Drawing.Color.White;
            this.btnTablePlan.Location = new System.Drawing.Point(1039, 11);
            this.btnTablePlan.Name = "btnTablePlan";
            this.btnTablePlan.Size = new System.Drawing.Size(75, 75);
            this.btnTablePlan.TabIndex = 4;
            this.btnTablePlan.Text = "Table Plan";
            this.btnTablePlan.UseVisualStyleBackColor = false;
            this.btnTablePlan.Click += new System.EventHandler(this.btnTablePlan_Click);
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
            // frmSalesMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1914, 1074);
            this.ControlBox = false;
            this.Controls.Add(this.btnTablePlan);
            this.Controls.Add(this.pnlTillDisplay);
            this.Controls.Add(this.pnlItemDisplay);
            this.Controls.Add(this.btnFolderBack);
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
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            this.pnlTillDisplay.ResumeLayout(false);
            this.pnlTillDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSCashCheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemsTableAdapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSOpenTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private EPOSDBDataSet ePOSDBDataSet;
        private System.Windows.Forms.BindingSource bstblEPOSItemFolders;
        private EPOSDBDataSetTableAdapters.tblEPOSItemFoldersTableAdapter tblEPOSItemFoldersTableAdapter;
        private System.Windows.Forms.Button btnFolderBack;
        private System.Windows.Forms.Panel pnlItemDisplay;
        private System.Windows.Forms.Panel pnlTillDisplay;
        private System.Windows.Forms.ListBox lbxTillDisplay;
        private System.Windows.Forms.TextBox tbxTillDisplay;
        private EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter tblEPOSItemsTableAdapter;
        private System.Windows.Forms.Button btnTillCard;
        private System.Windows.Forms.Button btnTillCash;
        private System.Windows.Forms.TextBox tbxTillTotal;
        private System.Windows.Forms.BindingSource bstblEPOSItemPrice;
        private EPOSDBDataSetTableAdapters.tblEPOSItemPriceTableAdapter tblEPOSItemPriceTableAdapter;
        private System.Windows.Forms.Button btnTill00;
        private System.Windows.Forms.Button btnTill0;
        private System.Windows.Forms.Button btnTillDecimal;
        private System.Windows.Forms.Button btnTill9;
        private System.Windows.Forms.Button btnTill8;
        private System.Windows.Forms.Button btnTill7;
        private System.Windows.Forms.Button btnTill6;
        private System.Windows.Forms.Button btnTill5;
        private System.Windows.Forms.Button btnTill4;
        private System.Windows.Forms.Button btnTill3;
        private System.Windows.Forms.Button btnTill2;
        private System.Windows.Forms.Button btnTill1;
        private System.Windows.Forms.Button btnTillErrorCorrect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnTableStore;
        private System.Windows.Forms.BindingSource bstblEPOSCashCheques;
        private System.Windows.Forms.BindingSource bstblEPOSItemsTableAdapter;
        private EPOSDBDataSetTableAdapters.tblEPOSCashChequesTableAdapter tblEPOSCashChequesTableAdapter;
        private System.Windows.Forms.Button btnTablePlan;
        private System.Windows.Forms.BindingSource bstblEPOSOpenTables;
        private EPOSDBDataSetTableAdapters.tblEPOSOpenTablesTableAdapter tblEPOSOpenTablesTableAdapter;
    }
}