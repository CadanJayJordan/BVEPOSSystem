﻿namespace CS3._0Project.Code.Sales {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesMode));
            this.btnHome = new System.Windows.Forms.Button();
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.btnFolderBack = new System.Windows.Forms.Button();
            this.pnlItemDisplay = new System.Windows.Forms.Panel();
            this.pnlTillDisplay = new System.Windows.Forms.Panel();
            this.btnTillCard = new System.Windows.Forms.Button();
            this.btnTillCash = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.lbxTillDisplay = new CS3._0Project.Code.Utility.Classes.tillListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTablePlan = new System.Windows.Forms.Button();
            this.btnToggleAlts = new System.Windows.Forms.Button();
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
            this.tbxTillDisplay = new System.Windows.Forms.TextBox();
            this.tblEPOSItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter();
            this.bstblEPOSItemFolders = new System.Windows.Forms.BindingSource(this.components);
            this.bstblEPOSItemPrice = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSItemFoldersTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemFoldersTableAdapter();
            this.tblEPOSItemPriceTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemPriceTableAdapter();
            this.bstblEPOSCashCheques = new System.Windows.Forms.BindingSource(this.components);
            this.bstblEPOSItemsTableAdapter = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSCashChequesTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSCashChequesTableAdapter();
            this.bstblEPOSOpenTables = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSOpenTablesTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSOpenTablesTableAdapter();
            this.tableAdapterManager1 = new CS3._0Project.EPOSDBDataSetTableAdapters.TableAdapterManager();
            this.bstblEPOSUsers = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSUsersTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSUsersTableAdapter();
            this.lblUsername = new System.Windows.Forms.Label();
            this.bstblEPOSTables = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSTablesTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSTablesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            this.pnlTillDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSCashCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemsTableAdapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSOpenTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTables)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.CadetBlue;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(12, 33);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 55);
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
            this.btnFolderBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolderBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFolderBack.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderBack.ForeColor = System.Drawing.Color.White;
            this.btnFolderBack.Location = new System.Drawing.Point(849, 12);
            this.btnFolderBack.Name = "btnFolderBack";
            this.btnFolderBack.Size = new System.Drawing.Size(104, 76);
            this.btnFolderBack.TabIndex = 2;
            this.btnFolderBack.Text = "Back";
            this.btnFolderBack.UseVisualStyleBackColor = false;
            this.btnFolderBack.Click += new System.EventHandler(this.btnFolderBack_Click);
            // 
            // pnlItemDisplay
            // 
            this.pnlItemDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItemDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pnlItemDisplay.Location = new System.Drawing.Point(12, 94);
            this.pnlItemDisplay.Name = "pnlItemDisplay";
            this.pnlItemDisplay.Size = new System.Drawing.Size(941, 715);
            this.pnlItemDisplay.TabIndex = 0;
            // 
            // pnlTillDisplay
            // 
            this.pnlTillDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTillDisplay.AutoSize = true;
            this.pnlTillDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pnlTillDisplay.Controls.Add(this.btnTillCard);
            this.pnlTillDisplay.Controls.Add(this.btnTillCash);
            this.pnlTillDisplay.Controls.Add(this.btnMultiply);
            this.pnlTillDisplay.Controls.Add(this.lbxTillDisplay);
            this.pnlTillDisplay.Controls.Add(this.button1);
            this.pnlTillDisplay.Controls.Add(this.btnTablePlan);
            this.pnlTillDisplay.Controls.Add(this.btnToggleAlts);
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
            this.pnlTillDisplay.Controls.Add(this.tbxTillDisplay);
            this.pnlTillDisplay.Location = new System.Drawing.Point(959, 12);
            this.pnlTillDisplay.Name = "pnlTillDisplay";
            this.pnlTillDisplay.Size = new System.Drawing.Size(605, 797);
            this.pnlTillDisplay.TabIndex = 3;
            // 
            // btnTillCard
            // 
            this.btnTillCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTillCard.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTillCard.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTillCard.ForeColor = System.Drawing.Color.White;
            this.btnTillCard.Location = new System.Drawing.Point(236, 502);
            this.btnTillCard.Name = "btnTillCard";
            this.btnTillCard.Size = new System.Drawing.Size(146, 65);
            this.btnTillCard.TabIndex = 3;
            this.btnTillCard.Text = "Card";
            this.btnTillCard.UseVisualStyleBackColor = false;
            // 
            // btnTillCash
            // 
            this.btnTillCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTillCash.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTillCash.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTillCash.ForeColor = System.Drawing.Color.White;
            this.btnTillCash.Location = new System.Drawing.Point(236, 573);
            this.btnTillCash.Name = "btnTillCash";
            this.btnTillCash.Size = new System.Drawing.Size(146, 65);
            this.btnTillCash.TabIndex = 2;
            this.btnTillCash.Text = "Cash";
            this.btnTillCash.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMultiply.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.White;
            this.btnMultiply.Location = new System.Drawing.Point(236, 644);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(146, 65);
            this.btnMultiply.TabIndex = 21;
            this.btnMultiply.Text = "Quantity";
            this.btnMultiply.UseVisualStyleBackColor = false;
            // 
            // lbxTillDisplay
            // 
            this.lbxTillDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxTillDisplay.BackColor = System.Drawing.Color.Black;
            this.lbxTillDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxTillDisplay.Font = new System.Drawing.Font("Consolas", 15F);
            this.lbxTillDisplay.ForeColor = System.Drawing.Color.White;
            this.lbxTillDisplay.FormattingEnabled = true;
            this.lbxTillDisplay.ItemHeight = 23;
            this.lbxTillDisplay.Items.AddRange(new object[] {
            "36",
            "",
            "1234567890123456789012345678901234567890"});
            this.lbxTillDisplay.Location = new System.Drawing.Point(16, 58);
            this.lbxTillDisplay.Name = "lbxTillDisplay";
            this.lbxTillDisplay.ShowScrollbar = true;
            this.lbxTillDisplay.Size = new System.Drawing.Size(428, 414);
            this.lbxTillDisplay.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(450, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 86);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add Note";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnTablePlan
            // 
            this.btnTablePlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTablePlan.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTablePlan.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTablePlan.ForeColor = System.Drawing.Color.White;
            this.btnTablePlan.Location = new System.Drawing.Point(450, 8);
            this.btnTablePlan.Name = "btnTablePlan";
            this.btnTablePlan.Size = new System.Drawing.Size(135, 94);
            this.btnTablePlan.TabIndex = 4;
            this.btnTablePlan.Text = "Table Plan";
            this.btnTablePlan.UseVisualStyleBackColor = false;
            // 
            // btnToggleAlts
            // 
            this.btnToggleAlts.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnToggleAlts.BackColor = System.Drawing.Color.CadetBlue;
            this.btnToggleAlts.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleAlts.ForeColor = System.Drawing.Color.White;
            this.btnToggleAlts.Location = new System.Drawing.Point(450, 257);
            this.btnToggleAlts.Name = "btnToggleAlts";
            this.btnToggleAlts.Size = new System.Drawing.Size(135, 65);
            this.btnToggleAlts.TabIndex = 22;
            this.btnToggleAlts.Text = "Toggle";
            this.btnToggleAlts.UseVisualStyleBackColor = false;
            // 
            // btnTableStore
            // 
            this.btnTableStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTableStore.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTableStore.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableStore.ForeColor = System.Drawing.Color.White;
            this.btnTableStore.Location = new System.Drawing.Point(450, 108);
            this.btnTableStore.Name = "btnTableStore";
            this.btnTableStore.Size = new System.Drawing.Size(135, 92);
            this.btnTableStore.TabIndex = 20;
            this.btnTableStore.Text = "Table Store";
            this.btnTableStore.UseVisualStyleBackColor = false;
            // 
            // btnTill00
            // 
            this.btnTill00.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTill00.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTill00.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTill00.ForeColor = System.Drawing.Color.White;
            this.btnTill00.Location = new System.Drawing.Point(16, 715);
            this.btnTill00.Name = "btnTill00";
            this.btnTill00.Size = new System.Drawing.Size(65, 65);
            this.btnTill00.TabIndex = 18;
            this.btnTill00.Text = "00";
            this.btnTill00.UseVisualStyleBackColor = false;
            // 
            // btnTill0
            // 
            this.btnTill0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTill0.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTill0.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTill0.ForeColor = System.Drawing.Color.White;
            this.btnTill0.Location = new System.Drawing.Point(87, 715);
            this.btnTill0.Name = "btnTill0";
            this.btnTill0.Size = new System.Drawing.Size(65, 65);
            this.btnTill0.TabIndex = 17;
            this.btnTill0.Text = "0";
            this.btnTill0.UseVisualStyleBackColor = false;
            // 
            // btnTillDecimal
            // 
            this.btnTillDecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTillDecimal.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTillDecimal.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTillDecimal.ForeColor = System.Drawing.Color.White;
            this.btnTillDecimal.Location = new System.Drawing.Point(158, 715);
            this.btnTillDecimal.Name = "btnTillDecimal";
            this.btnTillDecimal.Size = new System.Drawing.Size(65, 65);
            this.btnTillDecimal.TabIndex = 16;
            this.btnTillDecimal.Text = ".";
            this.btnTillDecimal.UseVisualStyleBackColor = false;
            // 
            // btnTill9
            // 
            this.btnTill9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTill9.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTill9.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTill9.ForeColor = System.Drawing.Color.White;
            this.btnTill9.Location = new System.Drawing.Point(158, 644);
            this.btnTill9.Name = "btnTill9";
            this.btnTill9.Size = new System.Drawing.Size(65, 65);
            this.btnTill9.TabIndex = 15;
            this.btnTill9.Text = "9";
            this.btnTill9.UseVisualStyleBackColor = false;
            // 
            // btnTill8
            // 
            this.btnTill8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTill8.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTill8.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTill8.ForeColor = System.Drawing.Color.White;
            this.btnTill8.Location = new System.Drawing.Point(87, 644);
            this.btnTill8.Name = "btnTill8";
            this.btnTill8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTill8.Size = new System.Drawing.Size(65, 65);
            this.btnTill8.TabIndex = 14;
            this.btnTill8.Text = "8";
            this.btnTill8.UseVisualStyleBackColor = false;
            // 
            // btnTill7
            // 
            this.btnTill7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTill7.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTill7.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTill7.ForeColor = System.Drawing.Color.White;
            this.btnTill7.Location = new System.Drawing.Point(16, 644);
            this.btnTill7.Name = "btnTill7";
            this.btnTill7.Size = new System.Drawing.Size(65, 65);
            this.btnTill7.TabIndex = 13;
            this.btnTill7.Text = "7";
            this.btnTill7.UseVisualStyleBackColor = false;
            // 
            // btnTill6
            // 
            this.btnTill6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTill6.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTill6.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTill6.ForeColor = System.Drawing.Color.White;
            this.btnTill6.Location = new System.Drawing.Point(158, 573);
            this.btnTill6.Name = "btnTill6";
            this.btnTill6.Size = new System.Drawing.Size(65, 65);
            this.btnTill6.TabIndex = 12;
            this.btnTill6.Text = "6";
            this.btnTill6.UseVisualStyleBackColor = false;
            // 
            // btnTill5
            // 
            this.btnTill5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTill5.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTill5.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTill5.ForeColor = System.Drawing.Color.White;
            this.btnTill5.Location = new System.Drawing.Point(87, 573);
            this.btnTill5.Name = "btnTill5";
            this.btnTill5.Size = new System.Drawing.Size(65, 65);
            this.btnTill5.TabIndex = 11;
            this.btnTill5.Text = "5";
            this.btnTill5.UseVisualStyleBackColor = false;
            // 
            // btnTill4
            // 
            this.btnTill4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTill4.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTill4.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTill4.ForeColor = System.Drawing.Color.White;
            this.btnTill4.Location = new System.Drawing.Point(16, 573);
            this.btnTill4.Name = "btnTill4";
            this.btnTill4.Size = new System.Drawing.Size(65, 65);
            this.btnTill4.TabIndex = 10;
            this.btnTill4.Text = "4";
            this.btnTill4.UseVisualStyleBackColor = false;
            // 
            // btnTill3
            // 
            this.btnTill3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTill3.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTill3.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTill3.ForeColor = System.Drawing.Color.White;
            this.btnTill3.Location = new System.Drawing.Point(158, 502);
            this.btnTill3.Name = "btnTill3";
            this.btnTill3.Size = new System.Drawing.Size(65, 65);
            this.btnTill3.TabIndex = 9;
            this.btnTill3.Text = "3";
            this.btnTill3.UseVisualStyleBackColor = false;
            // 
            // btnTill2
            // 
            this.btnTill2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTill2.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTill2.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTill2.ForeColor = System.Drawing.Color.White;
            this.btnTill2.Location = new System.Drawing.Point(87, 502);
            this.btnTill2.Name = "btnTill2";
            this.btnTill2.Size = new System.Drawing.Size(65, 65);
            this.btnTill2.TabIndex = 8;
            this.btnTill2.Text = "2";
            this.btnTill2.UseVisualStyleBackColor = false;
            // 
            // btnTill1
            // 
            this.btnTill1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTill1.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTill1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTill1.ForeColor = System.Drawing.Color.White;
            this.btnTill1.Location = new System.Drawing.Point(16, 502);
            this.btnTill1.Name = "btnTill1";
            this.btnTill1.Size = new System.Drawing.Size(65, 65);
            this.btnTill1.TabIndex = 7;
            this.btnTill1.Text = "1";
            this.btnTill1.UseVisualStyleBackColor = false;
            // 
            // btnTillErrorCorrect
            // 
            this.btnTillErrorCorrect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTillErrorCorrect.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTillErrorCorrect.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTillErrorCorrect.ForeColor = System.Drawing.Color.White;
            this.btnTillErrorCorrect.Location = new System.Drawing.Point(450, 328);
            this.btnTillErrorCorrect.Name = "btnTillErrorCorrect";
            this.btnTillErrorCorrect.Size = new System.Drawing.Size(135, 65);
            this.btnTillErrorCorrect.TabIndex = 6;
            this.btnTillErrorCorrect.Text = "Remove";
            this.btnTillErrorCorrect.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(236, 715);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 65);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // tbxTillTotal
            // 
            this.tbxTillTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTillTotal.BackColor = System.Drawing.Color.Black;
            this.tbxTillTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTillTotal.Font = new System.Drawing.Font("Consolas", 15F);
            this.tbxTillTotal.ForeColor = System.Drawing.Color.White;
            this.tbxTillTotal.Location = new System.Drawing.Point(16, 472);
            this.tbxTillTotal.Name = "tbxTillTotal";
            this.tbxTillTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxTillTotal.Size = new System.Drawing.Size(428, 24);
            this.tbxTillTotal.TabIndex = 4;
            this.tbxTillTotal.Text = "36";
            // 
            // tbxTillDisplay
            // 
            this.tbxTillDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTillDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.tbxTillDisplay.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTillDisplay.ForeColor = System.Drawing.Color.White;
            this.tbxTillDisplay.Location = new System.Drawing.Point(16, 13);
            this.tbxTillDisplay.Name = "tbxTillDisplay";
            this.tbxTillDisplay.ReadOnly = true;
            this.tbxTillDisplay.Size = new System.Drawing.Size(428, 39);
            this.tbxTillDisplay.TabIndex = 1;
            this.tbxTillDisplay.Text = "25";
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
            // bstblEPOSOpenTables
            // 
            this.bstblEPOSOpenTables.DataMember = "tblEPOSOpenTables";
            this.bstblEPOSOpenTables.DataSource = this.ePOSDBDataSet;
            // 
            // tblEPOSOpenTablesTableAdapter
            // 
            this.tblEPOSOpenTablesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblClockLogTableAdapter = null;
            this.tableAdapterManager1.tblEPOSCashChequesTableAdapter = this.tblEPOSCashChequesTableAdapter;
            this.tableAdapterManager1.tblEPOSDepartmentsTableAdapter = null;
            this.tableAdapterManager1.tblEPOSItemFoldersTableAdapter = this.tblEPOSItemFoldersTableAdapter;
            this.tableAdapterManager1.tblEPOSItemPriceTableAdapter = this.tblEPOSItemPriceTableAdapter;
            this.tableAdapterManager1.tblEPOSItemsTableAdapter = this.tblEPOSItemsTableAdapter;
            this.tableAdapterManager1.tblEPOSListItemsTableAdapter = null;
            this.tableAdapterManager1.tblEPOSOpenTablesTableAdapter = this.tblEPOSOpenTablesTableAdapter;
            this.tableAdapterManager1.tblEPOSTableFloorsTableAdapter = null;
            this.tableAdapterManager1.tblEPOSTablesTableAdapter = null;
            this.tableAdapterManager1.tblEPOSUsersTableAdapter = null;
            this.tableAdapterManager1.tblOrderLogTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CS3._0Project.EPOSDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Black;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(0, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(36, 30);
            this.lblUsername.TabIndex = 24;
            this.lblUsername.Text = "{0}";
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
            // frmSalesMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1576, 840);
            this.ControlBox = false;
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlTillDisplay);
            this.Controls.Add(this.pnlItemDisplay);
            this.Controls.Add(this.btnFolderBack);
            this.Controls.Add(this.btnHome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalesMode";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private EPOSDBDataSet ePOSDBDataSet;
        private System.Windows.Forms.BindingSource bstblEPOSItemFolders;
        private EPOSDBDataSetTableAdapters.tblEPOSItemFoldersTableAdapter tblEPOSItemFoldersTableAdapter;
        private System.Windows.Forms.Button btnFolderBack;
        private System.Windows.Forms.Panel pnlItemDisplay;
        private System.Windows.Forms.Panel pnlTillDisplay;
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
        private System.Windows.Forms.Button btnToggleAlts;
        private System.Windows.Forms.Button button1;
        private Utility.Classes.tillListBox lbxTillDisplay;
        private EPOSDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bstblEPOSUsers;
        private EPOSDBDataSetTableAdapters.tblEPOSUsersTableAdapter tblEPOSUsersTableAdapter;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.BindingSource bstblEPOSTables;
        private EPOSDBDataSetTableAdapters.tblEPOSTablesTableAdapter tblEPOSTablesTableAdapter;
    }
}