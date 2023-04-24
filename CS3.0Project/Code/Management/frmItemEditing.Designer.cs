namespace CS3._0Project.Code.Management {
    partial class frmItemEditing {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemEditing));
            this.btnClose = new System.Windows.Forms.Button();
            this.bstblEPOSItems = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter();
            this.bstblEPOSItemPrice = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSItemPriceTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemPriceTableAdapter();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAllItems = new System.Windows.Forms.Label();
            this.tblEPOSItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bstblEPOSItemFolders = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSItemFoldersTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemFoldersTableAdapter();
            this.bstblEPOSDepartments = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSDepartmentsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSDepartmentsTableAdapter();
            this.pnlItemEditing = new System.Windows.Forms.Panel();
            this.cbPrintBar = new System.Windows.Forms.CheckBox();
            this.cbPrintKitchen = new System.Windows.Forms.CheckBox();
            this.lblPrintSettings = new System.Windows.Forms.Label();
            this.btnItemPreview = new CS3._0Project.Code.Utility.Classes.RoundedButton();
            this.btnUpdateFrontColour = new System.Windows.Forms.Button();
            this.lblitemPreview = new System.Windows.Forms.Label();
            this.btnParentEditWeight = new System.Windows.Forms.Button();
            this.lblAlt3 = new System.Windows.Forms.Label();
            this.lblAlt2 = new System.Windows.Forms.Label();
            this.lblAlt1 = new System.Windows.Forms.Label();
            this.txtTextAlt3 = new System.Windows.Forms.TextBox();
            this.txtTextAlt2 = new System.Windows.Forms.TextBox();
            this.txtTextAlt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPriceAlt3 = new System.Windows.Forms.TextBox();
            this.txtPriceAlt2 = new System.Windows.Forms.TextBox();
            this.txtPriceAlt1 = new System.Windows.Forms.TextBox();
            this.lblAltPrices = new System.Windows.Forms.Label();
            this.txtQuantityAlt3 = new System.Windows.Forms.TextBox();
            this.txtQuantityAlt2 = new System.Windows.Forms.TextBox();
            this.txtQuantityAlt1 = new System.Windows.Forms.TextBox();
            this.lblAltsAmounts = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.cbPrintRed = new System.Windows.Forms.CheckBox();
            this.cbAllowZeroPrice = new System.Windows.Forms.CheckBox();
            this.cbIsListItem = new System.Windows.Forms.CheckBox();
            this.cbxItemFolder = new System.Windows.Forms.ComboBox();
            this.bstblEPOSListItems = new System.Windows.Forms.BindingSource(this.components);
            this.lblListItem = new System.Windows.Forms.Label();
            this.btnChangeColour = new System.Windows.Forms.Button();
            this.btnParentClear = new System.Windows.Forms.Button();
            this.btnParentRemove = new System.Windows.Forms.Button();
            this.btnParentAdd = new System.Windows.Forms.Button();
            this.lbxParentFolders = new CS3._0Project.Code.Utility.Classes.tillListBox();
            this.lblParentFolders = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.tblEPOSDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDepartments = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ePOSDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSListItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSListItemsTableAdapter();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearListItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEPOSItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSDepartments)).BeginInit();
            this.pnlItemEditing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEPOSDepartmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1059, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 78);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bstblEPOSItems
            // 
            this.bstblEPOSItems.DataMember = "tblEPOSItems";
            this.bstblEPOSItems.DataSource = this.ePOSDBDataSet;
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
            // bstblEPOSItemPrice
            // 
            this.bstblEPOSItemPrice.DataMember = "tblEPOSItemPrice";
            this.bstblEPOSItemPrice.DataSource = this.ePOSDBDataSet;
            // 
            // tblEPOSItemPriceTableAdapter
            // 
            this.tblEPOSItemPriceTableAdapter.ClearBeforeFill = true;
            // 
            // cbxItems
            // 
            this.cbxItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxItems.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(12, 62);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(244, 488);
            this.cbxItems.TabIndex = 2;
            this.cbxItems.SelectedIndexChanged += new System.EventHandler(this.cbxItems_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(3, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 30);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblAllItems
            // 
            this.lblAllItems.AutoSize = true;
            this.lblAllItems.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblAllItems.ForeColor = System.Drawing.Color.Black;
            this.lblAllItems.Location = new System.Drawing.Point(12, 30);
            this.lblAllItems.Name = "lblAllItems";
            this.lblAllItems.Size = new System.Drawing.Size(115, 32);
            this.lblAllItems.TabIndex = 4;
            this.lblAllItems.Text = "All Items:";
            // 
            // tblEPOSItemsBindingSource
            // 
            this.tblEPOSItemsBindingSource.DataMember = "tblEPOSItems";
            this.tblEPOSItemsBindingSource.DataSource = this.ePOSDBDataSet;
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
            // bstblEPOSDepartments
            // 
            this.bstblEPOSDepartments.DataMember = "tblEPOSDepartments";
            this.bstblEPOSDepartments.DataSource = this.ePOSDBDataSet;
            // 
            // tblEPOSDepartmentsTableAdapter
            // 
            this.tblEPOSDepartmentsTableAdapter.ClearBeforeFill = true;
            // 
            // pnlItemEditing
            // 
            this.pnlItemEditing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItemEditing.AutoSize = true;
            this.pnlItemEditing.BackColor = System.Drawing.Color.Transparent;
            this.pnlItemEditing.Controls.Add(this.btnClearListItem);
            this.pnlItemEditing.Controls.Add(this.cbPrintBar);
            this.pnlItemEditing.Controls.Add(this.cbPrintKitchen);
            this.pnlItemEditing.Controls.Add(this.lblPrintSettings);
            this.pnlItemEditing.Controls.Add(this.btnItemPreview);
            this.pnlItemEditing.Controls.Add(this.btnUpdateFrontColour);
            this.pnlItemEditing.Controls.Add(this.lblitemPreview);
            this.pnlItemEditing.Controls.Add(this.btnParentEditWeight);
            this.pnlItemEditing.Controls.Add(this.lblAlt3);
            this.pnlItemEditing.Controls.Add(this.lblAlt2);
            this.pnlItemEditing.Controls.Add(this.lblAlt1);
            this.pnlItemEditing.Controls.Add(this.txtTextAlt3);
            this.pnlItemEditing.Controls.Add(this.txtTextAlt2);
            this.pnlItemEditing.Controls.Add(this.txtTextAlt1);
            this.pnlItemEditing.Controls.Add(this.label1);
            this.pnlItemEditing.Controls.Add(this.txtPriceAlt3);
            this.pnlItemEditing.Controls.Add(this.txtPriceAlt2);
            this.pnlItemEditing.Controls.Add(this.txtPriceAlt1);
            this.pnlItemEditing.Controls.Add(this.lblAltPrices);
            this.pnlItemEditing.Controls.Add(this.txtQuantityAlt3);
            this.pnlItemEditing.Controls.Add(this.txtQuantityAlt2);
            this.pnlItemEditing.Controls.Add(this.txtQuantityAlt1);
            this.pnlItemEditing.Controls.Add(this.lblAltsAmounts);
            this.pnlItemEditing.Controls.Add(this.txtBasePrice);
            this.pnlItemEditing.Controls.Add(this.lblBasePrice);
            this.pnlItemEditing.Controls.Add(this.cbPrintRed);
            this.pnlItemEditing.Controls.Add(this.cbAllowZeroPrice);
            this.pnlItemEditing.Controls.Add(this.cbIsListItem);
            this.pnlItemEditing.Controls.Add(this.cbxItemFolder);
            this.pnlItemEditing.Controls.Add(this.lblListItem);
            this.pnlItemEditing.Controls.Add(this.btnChangeColour);
            this.pnlItemEditing.Controls.Add(this.btnParentClear);
            this.pnlItemEditing.Controls.Add(this.btnParentRemove);
            this.pnlItemEditing.Controls.Add(this.btnParentAdd);
            this.pnlItemEditing.Controls.Add(this.lbxParentFolders);
            this.pnlItemEditing.Controls.Add(this.lblParentFolders);
            this.pnlItemEditing.Controls.Add(this.lblItemID);
            this.pnlItemEditing.Controls.Add(this.cbxDepartment);
            this.pnlItemEditing.Controls.Add(this.lblDepartments);
            this.pnlItemEditing.Controls.Add(this.txtName);
            this.pnlItemEditing.Controls.Add(this.lblName);
            this.pnlItemEditing.Location = new System.Drawing.Point(262, 37);
            this.pnlItemEditing.Name = "pnlItemEditing";
            this.pnlItemEditing.Size = new System.Drawing.Size(786, 575);
            this.pnlItemEditing.TabIndex = 5;
            // 
            // cbPrintBar
            // 
            this.cbPrintBar.AutoSize = true;
            this.cbPrintBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbPrintBar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbPrintBar.ForeColor = System.Drawing.Color.Black;
            this.cbPrintBar.Location = new System.Drawing.Point(636, 298);
            this.cbPrintBar.Name = "cbPrintBar";
            this.cbPrintBar.Size = new System.Drawing.Size(144, 34);
            this.cbPrintBar.TabIndex = 47;
            this.cbPrintBar.Text = "Print To Bar";
            this.cbPrintBar.UseVisualStyleBackColor = true;
            // 
            // cbPrintKitchen
            // 
            this.cbPrintKitchen.AutoSize = true;
            this.cbPrintKitchen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbPrintKitchen.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbPrintKitchen.ForeColor = System.Drawing.Color.Black;
            this.cbPrintKitchen.Location = new System.Drawing.Point(597, 338);
            this.cbPrintKitchen.Name = "cbPrintKitchen";
            this.cbPrintKitchen.Size = new System.Drawing.Size(183, 34);
            this.cbPrintKitchen.TabIndex = 46;
            this.cbPrintKitchen.Text = "Print To Kitchen";
            this.cbPrintKitchen.UseVisualStyleBackColor = true;
            // 
            // lblPrintSettings
            // 
            this.lblPrintSettings.AutoSize = true;
            this.lblPrintSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblPrintSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintSettings.ForeColor = System.Drawing.Color.Black;
            this.lblPrintSettings.Location = new System.Drawing.Point(504, 263);
            this.lblPrintSettings.Name = "lblPrintSettings";
            this.lblPrintSettings.Size = new System.Drawing.Size(165, 30);
            this.lblPrintSettings.TabIndex = 45;
            this.lblPrintSettings.Text = "Printer Settings:";
            // 
            // btnItemPreview
            // 
            this.btnItemPreview.FlatAppearance.BorderSize = 0;
            this.btnItemPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnItemPreview.Location = new System.Drawing.Point(621, 3);
            this.btnItemPreview.Name = "btnItemPreview";
            this.btnItemPreview.Size = new System.Drawing.Size(130, 100);
            this.btnItemPreview.TabIndex = 44;
            this.btnItemPreview.UseVisualStyleBackColor = true;
            // 
            // btnUpdateFrontColour
            // 
            this.btnUpdateFrontColour.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdateFrontColour.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFrontColour.ForeColor = System.Drawing.Color.White;
            this.btnUpdateFrontColour.Location = new System.Drawing.Point(675, 109);
            this.btnUpdateFrontColour.Name = "btnUpdateFrontColour";
            this.btnUpdateFrontColour.Size = new System.Drawing.Size(105, 111);
            this.btnUpdateFrontColour.TabIndex = 43;
            this.btnUpdateFrontColour.Text = "Edit Text Colour";
            this.btnUpdateFrontColour.UseVisualStyleBackColor = false;
            this.btnUpdateFrontColour.Click += new System.EventHandler(this.btnUpdateFrontColour_Click);
            // 
            // lblitemPreview
            // 
            this.lblitemPreview.AutoSize = true;
            this.lblitemPreview.BackColor = System.Drawing.Color.Transparent;
            this.lblitemPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemPreview.ForeColor = System.Drawing.Color.Black;
            this.lblitemPreview.Location = new System.Drawing.Point(462, 4);
            this.lblitemPreview.Name = "lblitemPreview";
            this.lblitemPreview.Size = new System.Drawing.Size(142, 30);
            this.lblitemPreview.TabIndex = 42;
            this.lblitemPreview.Text = "Item Preview:";
            // 
            // btnParentEditWeight
            // 
            this.btnParentEditWeight.BackColor = System.Drawing.Color.CadetBlue;
            this.btnParentEditWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnParentEditWeight.ForeColor = System.Drawing.Color.White;
            this.btnParentEditWeight.Location = new System.Drawing.Point(334, 299);
            this.btnParentEditWeight.Name = "btnParentEditWeight";
            this.btnParentEditWeight.Size = new System.Drawing.Size(131, 58);
            this.btnParentEditWeight.TabIndex = 39;
            this.btnParentEditWeight.Text = "Edit Location Weight";
            this.btnParentEditWeight.UseVisualStyleBackColor = false;
            this.btnParentEditWeight.Click += new System.EventHandler(this.btnParentEditWeight_Click);
            // 
            // lblAlt3
            // 
            this.lblAlt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAlt3.AutoSize = true;
            this.lblAlt3.BackColor = System.Drawing.Color.Transparent;
            this.lblAlt3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlt3.ForeColor = System.Drawing.Color.Black;
            this.lblAlt3.Location = new System.Drawing.Point(635, 433);
            this.lblAlt3.Name = "lblAlt3";
            this.lblAlt3.Size = new System.Drawing.Size(63, 30);
            this.lblAlt3.TabIndex = 38;
            this.lblAlt3.Text = "Alt 3:";
            // 
            // lblAlt2
            // 
            this.lblAlt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAlt2.AutoSize = true;
            this.lblAlt2.BackColor = System.Drawing.Color.Transparent;
            this.lblAlt2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlt2.ForeColor = System.Drawing.Color.Black;
            this.lblAlt2.Location = new System.Drawing.Point(528, 433);
            this.lblAlt2.Name = "lblAlt2";
            this.lblAlt2.Size = new System.Drawing.Size(63, 30);
            this.lblAlt2.TabIndex = 37;
            this.lblAlt2.Text = "Alt 2:";
            // 
            // lblAlt1
            // 
            this.lblAlt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAlt1.AutoSize = true;
            this.lblAlt1.BackColor = System.Drawing.Color.Transparent;
            this.lblAlt1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlt1.ForeColor = System.Drawing.Color.Black;
            this.lblAlt1.Location = new System.Drawing.Point(426, 433);
            this.lblAlt1.Name = "lblAlt1";
            this.lblAlt1.Size = new System.Drawing.Size(59, 30);
            this.lblAlt1.TabIndex = 36;
            this.lblAlt1.Text = "Alt 1:";
            // 
            // txtTextAlt3
            // 
            this.txtTextAlt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTextAlt3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextAlt3.Location = new System.Drawing.Point(625, 536);
            this.txtTextAlt3.Name = "txtTextAlt3";
            this.txtTextAlt3.Size = new System.Drawing.Size(100, 33);
            this.txtTextAlt3.TabIndex = 35;
            this.txtTextAlt3.Click += new System.EventHandler(this.OnTextBoxClick);
            // 
            // txtTextAlt2
            // 
            this.txtTextAlt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTextAlt2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextAlt2.Location = new System.Drawing.Point(519, 536);
            this.txtTextAlt2.Name = "txtTextAlt2";
            this.txtTextAlt2.Size = new System.Drawing.Size(100, 33);
            this.txtTextAlt2.TabIndex = 34;
            this.txtTextAlt2.Click += new System.EventHandler(this.OnTextBoxClick);
            // 
            // txtTextAlt1
            // 
            this.txtTextAlt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTextAlt1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextAlt1.Location = new System.Drawing.Point(413, 536);
            this.txtTextAlt1.Name = "txtTextAlt1";
            this.txtTextAlt1.Size = new System.Drawing.Size(100, 33);
            this.txtTextAlt1.TabIndex = 33;
            this.txtTextAlt1.Click += new System.EventHandler(this.OnTextBoxClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(236, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Alternative Texts:";
            // 
            // txtPriceAlt3
            // 
            this.txtPriceAlt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPriceAlt3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAlt3.Location = new System.Drawing.Point(640, 501);
            this.txtPriceAlt3.Name = "txtPriceAlt3";
            this.txtPriceAlt3.Size = new System.Drawing.Size(70, 33);
            this.txtPriceAlt3.TabIndex = 31;
            this.txtPriceAlt3.Click += new System.EventHandler(this.OnNumBoxClick);
            // 
            // txtPriceAlt2
            // 
            this.txtPriceAlt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPriceAlt2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAlt2.Location = new System.Drawing.Point(533, 501);
            this.txtPriceAlt2.Name = "txtPriceAlt2";
            this.txtPriceAlt2.Size = new System.Drawing.Size(70, 33);
            this.txtPriceAlt2.TabIndex = 30;
            this.txtPriceAlt2.Click += new System.EventHandler(this.OnNumBoxClick);
            // 
            // txtPriceAlt1
            // 
            this.txtPriceAlt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPriceAlt1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAlt1.Location = new System.Drawing.Point(431, 501);
            this.txtPriceAlt1.Name = "txtPriceAlt1";
            this.txtPriceAlt1.Size = new System.Drawing.Size(70, 33);
            this.txtPriceAlt1.TabIndex = 29;
            this.txtPriceAlt1.Click += new System.EventHandler(this.OnNumBoxClick);
            // 
            // lblAltPrices
            // 
            this.lblAltPrices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAltPrices.AutoSize = true;
            this.lblAltPrices.BackColor = System.Drawing.Color.Transparent;
            this.lblAltPrices.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltPrices.ForeColor = System.Drawing.Color.Black;
            this.lblAltPrices.Location = new System.Drawing.Point(197, 500);
            this.lblAltPrices.Name = "lblAltPrices";
            this.lblAltPrices.Size = new System.Drawing.Size(216, 30);
            this.lblAltPrices.TabIndex = 26;
            this.lblAltPrices.Text = "Alternative Prices (p):";
            // 
            // txtQuantityAlt3
            // 
            this.txtQuantityAlt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQuantityAlt3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityAlt3.Location = new System.Drawing.Point(640, 466);
            this.txtQuantityAlt3.Name = "txtQuantityAlt3";
            this.txtQuantityAlt3.Size = new System.Drawing.Size(70, 33);
            this.txtQuantityAlt3.TabIndex = 25;
            this.txtQuantityAlt3.Click += new System.EventHandler(this.OnNumBoxClick);
            // 
            // txtQuantityAlt2
            // 
            this.txtQuantityAlt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQuantityAlt2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityAlt2.Location = new System.Drawing.Point(533, 466);
            this.txtQuantityAlt2.Name = "txtQuantityAlt2";
            this.txtQuantityAlt2.Size = new System.Drawing.Size(70, 33);
            this.txtQuantityAlt2.TabIndex = 24;
            this.txtQuantityAlt2.Click += new System.EventHandler(this.OnNumBoxClick);
            // 
            // txtQuantityAlt1
            // 
            this.txtQuantityAlt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQuantityAlt1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityAlt1.Location = new System.Drawing.Point(431, 466);
            this.txtQuantityAlt1.Name = "txtQuantityAlt1";
            this.txtQuantityAlt1.Size = new System.Drawing.Size(70, 33);
            this.txtQuantityAlt1.TabIndex = 23;
            this.txtQuantityAlt1.Click += new System.EventHandler(this.OnNumBoxClick);
            // 
            // lblAltsAmounts
            // 
            this.lblAltsAmounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAltsAmounts.AutoSize = true;
            this.lblAltsAmounts.BackColor = System.Drawing.Color.Transparent;
            this.lblAltsAmounts.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltsAmounts.ForeColor = System.Drawing.Color.Black;
            this.lblAltsAmounts.Location = new System.Drawing.Point(3, 464);
            this.lblAltsAmounts.Name = "lblAltsAmounts";
            this.lblAltsAmounts.Size = new System.Drawing.Size(410, 30);
            this.lblAltsAmounts.TabIndex = 22;
            this.lblAltsAmounts.Text = "Alternative Amounts (% of base amount):";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBasePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtBasePrice.Location = new System.Drawing.Point(156, 427);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(62, 33);
            this.txtBasePrice.TabIndex = 21;
            this.txtBasePrice.Click += new System.EventHandler(this.OnNumBoxClick);
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblBasePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.ForeColor = System.Drawing.Color.Black;
            this.lblBasePrice.Location = new System.Drawing.Point(3, 424);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(147, 30);
            this.lblBasePrice.TabIndex = 20;
            this.lblBasePrice.Text = "Base Price (p):";
            // 
            // cbPrintRed
            // 
            this.cbPrintRed.AutoSize = true;
            this.cbPrintRed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbPrintRed.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbPrintRed.ForeColor = System.Drawing.Color.Black;
            this.cbPrintRed.Location = new System.Drawing.Point(636, 378);
            this.cbPrintRed.Name = "cbPrintRed";
            this.cbPrintRed.Size = new System.Drawing.Size(143, 34);
            this.cbPrintRed.TabIndex = 19;
            this.cbPrintRed.Text = "Print In Red";
            this.cbPrintRed.UseVisualStyleBackColor = true;
            // 
            // cbAllowZeroPrice
            // 
            this.cbAllowZeroPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAllowZeroPrice.AutoSize = true;
            this.cbAllowZeroPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbAllowZeroPrice.ForeColor = System.Drawing.Color.Black;
            this.cbAllowZeroPrice.Location = new System.Drawing.Point(226, 423);
            this.cbAllowZeroPrice.Name = "cbAllowZeroPrice";
            this.cbAllowZeroPrice.Size = new System.Drawing.Size(187, 34);
            this.cbAllowZeroPrice.TabIndex = 18;
            this.cbAllowZeroPrice.Text = "Allow Zero Price";
            this.cbAllowZeroPrice.UseVisualStyleBackColor = true;
            // 
            // cbIsListItem
            // 
            this.cbIsListItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIsListItem.AutoSize = true;
            this.cbIsListItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbIsListItem.ForeColor = System.Drawing.Color.Black;
            this.cbIsListItem.Location = new System.Drawing.Point(422, 380);
            this.cbIsListItem.Name = "cbIsListItem";
            this.cbIsListItem.Size = new System.Drawing.Size(147, 34);
            this.cbIsListItem.TabIndex = 17;
            this.cbIsListItem.Text = "Is a list Item";
            this.cbIsListItem.UseVisualStyleBackColor = true;
            // 
            // cbxItemFolder
            // 
            this.cbxItemFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxItemFolder.DataSource = this.bstblEPOSListItems;
            this.cbxItemFolder.DisplayMember = "listItemName";
            this.cbxItemFolder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItemFolder.FormattingEnabled = true;
            this.cbxItemFolder.Location = new System.Drawing.Point(109, 382);
            this.cbxItemFolder.Name = "cbxItemFolder";
            this.cbxItemFolder.Size = new System.Drawing.Size(235, 33);
            this.cbxItemFolder.TabIndex = 16;
            this.cbxItemFolder.ValueMember = "listItemID";
            // 
            // bstblEPOSListItems
            // 
            this.bstblEPOSListItems.DataMember = "tblEPOSListItems";
            this.bstblEPOSListItems.DataSource = this.ePOSDBDataSet;
            // 
            // lblListItem
            // 
            this.lblListItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblListItem.AutoSize = true;
            this.lblListItem.BackColor = System.Drawing.Color.Transparent;
            this.lblListItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListItem.ForeColor = System.Drawing.Color.Black;
            this.lblListItem.Location = new System.Drawing.Point(3, 385);
            this.lblListItem.Name = "lblListItem";
            this.lblListItem.Size = new System.Drawing.Size(100, 30);
            this.lblListItem.TabIndex = 15;
            this.lblListItem.Text = "List Item:";
            // 
            // btnChangeColour
            // 
            this.btnChangeColour.BackColor = System.Drawing.Color.CadetBlue;
            this.btnChangeColour.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeColour.ForeColor = System.Drawing.Color.White;
            this.btnChangeColour.Location = new System.Drawing.Point(564, 109);
            this.btnChangeColour.Name = "btnChangeColour";
            this.btnChangeColour.Size = new System.Drawing.Size(105, 111);
            this.btnChangeColour.TabIndex = 13;
            this.btnChangeColour.Text = "Edit Button Colour";
            this.btnChangeColour.UseVisualStyleBackColor = false;
            this.btnChangeColour.Click += new System.EventHandler(this.btnChangeBackColour_Click);
            // 
            // btnParentClear
            // 
            this.btnParentClear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnParentClear.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParentClear.ForeColor = System.Drawing.Color.White;
            this.btnParentClear.Location = new System.Drawing.Point(334, 171);
            this.btnParentClear.Name = "btnParentClear";
            this.btnParentClear.Size = new System.Drawing.Size(131, 58);
            this.btnParentClear.TabIndex = 12;
            this.btnParentClear.Text = "Clear";
            this.btnParentClear.UseVisualStyleBackColor = false;
            this.btnParentClear.Click += new System.EventHandler(this.btnParentClear_Click);
            // 
            // btnParentRemove
            // 
            this.btnParentRemove.BackColor = System.Drawing.Color.CadetBlue;
            this.btnParentRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParentRemove.ForeColor = System.Drawing.Color.White;
            this.btnParentRemove.Location = new System.Drawing.Point(334, 235);
            this.btnParentRemove.Name = "btnParentRemove";
            this.btnParentRemove.Size = new System.Drawing.Size(131, 58);
            this.btnParentRemove.TabIndex = 11;
            this.btnParentRemove.Text = "Remove";
            this.btnParentRemove.UseVisualStyleBackColor = false;
            this.btnParentRemove.Click += new System.EventHandler(this.btnParentRemove_Click);
            // 
            // btnParentAdd
            // 
            this.btnParentAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnParentAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParentAdd.ForeColor = System.Drawing.Color.White;
            this.btnParentAdd.Location = new System.Drawing.Point(334, 107);
            this.btnParentAdd.Name = "btnParentAdd";
            this.btnParentAdd.Size = new System.Drawing.Size(131, 58);
            this.btnParentAdd.TabIndex = 10;
            this.btnParentAdd.Text = "Add";
            this.btnParentAdd.UseVisualStyleBackColor = false;
            this.btnParentAdd.Click += new System.EventHandler(this.btnParentAdd_Click);
            // 
            // lbxParentFolders
            // 
            this.lbxParentFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxParentFolders.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxParentFolders.FormattingEnabled = true;
            this.lbxParentFolders.ItemHeight = 25;
            this.lbxParentFolders.Location = new System.Drawing.Point(8, 107);
            this.lbxParentFolders.Name = "lbxParentFolders";
            this.lbxParentFolders.ShowScrollbar = false;
            this.lbxParentFolders.Size = new System.Drawing.Size(320, 254);
            this.lbxParentFolders.TabIndex = 9;
            // 
            // lblParentFolders
            // 
            this.lblParentFolders.AutoSize = true;
            this.lblParentFolders.BackColor = System.Drawing.Color.Transparent;
            this.lblParentFolders.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentFolders.ForeColor = System.Drawing.Color.Black;
            this.lblParentFolders.Location = new System.Drawing.Point(3, 74);
            this.lblParentFolders.Name = "lblParentFolders";
            this.lblParentFolders.Size = new System.Drawing.Size(462, 30);
            this.lblParentFolders.TabIndex = 8;
            this.lblParentFolders.Text = "Parent Folders (Folder name: Location Weight):";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.BackColor = System.Drawing.Color.Transparent;
            this.lblItemID.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.ForeColor = System.Drawing.Color.Black;
            this.lblItemID.Location = new System.Drawing.Point(321, 4);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(143, 30);
            this.lblItemID.TabIndex = 7;
            this.lblItemID.Text = "Item ID: 0000";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DataSource = this.tblEPOSDepartmentsBindingSource;
            this.cbxDepartment.DisplayMember = "eposDepartmentName";
            this.cbxDepartment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(142, 39);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(317, 33);
            this.cbxDepartment.TabIndex = 6;
            this.cbxDepartment.ValueMember = "eposItemDepartmentID";
            // 
            // tblEPOSDepartmentsBindingSource
            // 
            this.tblEPOSDepartmentsBindingSource.DataMember = "tblEPOSDepartments";
            this.tblEPOSDepartmentsBindingSource.DataSource = this.ePOSDBDataSet;
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartments.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartments.ForeColor = System.Drawing.Color.Black;
            this.lblDepartments.Location = new System.Drawing.Point(3, 39);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(135, 30);
            this.lblDepartments.TabIndex = 5;
            this.lblDepartments.Text = "Department:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(75, 1);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 33);
            this.txtName.TabIndex = 4;
            this.txtName.Click += new System.EventHandler(this.OnTextBoxClick);
            // 
            // ePOSDBDataSetBindingSource
            // 
            this.ePOSDBDataSetBindingSource.DataSource = this.ePOSDBDataSet;
            this.ePOSDBDataSetBindingSource.Position = 0;
            // 
            // tblEPOSListItemsTableAdapter
            // 
            this.tblEPOSListItemsTableAdapter.ClearBeforeFill = true;
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
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "{0}";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddItem.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(12, 556);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(120, 58);
            this.btnAddItem.TabIndex = 45;
            this.btnAddItem.Text = "New Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveItem.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(136, 556);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(120, 58);
            this.btnRemoveItem.TabIndex = 46;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClearListItem
            // 
            this.btnClearListItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearListItem.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClearListItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnClearListItem.ForeColor = System.Drawing.Color.White;
            this.btnClearListItem.Location = new System.Drawing.Point(350, 368);
            this.btnClearListItem.Name = "btnClearListItem";
            this.btnClearListItem.Size = new System.Drawing.Size(66, 58);
            this.btnClearListItem.TabIndex = 48;
            this.btnClearListItem.Text = "Clear";
            this.btnClearListItem.UseVisualStyleBackColor = false;
            this.btnClearListItem.Click += new System.EventHandler(this.btnClearListItem_Click);
            // 
            // frmItemEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1162, 626);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlItemEditing);
            this.Controls.Add(this.lblAllItems);
            this.Controls.Add(this.cbxItems);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemEditing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmItemEditing";
            this.Load += new System.EventHandler(this.frmItemEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEPOSItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSDepartments)).EndInit();
            this.pnlItemEditing.ResumeLayout(false);
            this.pnlItemEditing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEPOSDepartmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource bstblEPOSItems;
        private EPOSDBDataSet ePOSDBDataSet;
        private EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter tblEPOSItemsTableAdapter;
        private System.Windows.Forms.BindingSource bstblEPOSItemPrice;
        private EPOSDBDataSetTableAdapters.tblEPOSItemPriceTableAdapter tblEPOSItemPriceTableAdapter;
        private System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAllItems;
        private System.Windows.Forms.BindingSource tblEPOSItemsBindingSource;
        private System.Windows.Forms.BindingSource bstblEPOSItemFolders;
        private EPOSDBDataSetTableAdapters.tblEPOSItemFoldersTableAdapter tblEPOSItemFoldersTableAdapter;
        private System.Windows.Forms.BindingSource bstblEPOSDepartments;
        private EPOSDBDataSetTableAdapters.tblEPOSDepartmentsTableAdapter tblEPOSDepartmentsTableAdapter;
        private System.Windows.Forms.Panel pnlItemEditing;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.BindingSource tblEPOSDepartmentsBindingSource;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.BindingSource ePOSDBDataSetBindingSource;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Button btnParentClear;
        private System.Windows.Forms.Button btnParentRemove;
        private System.Windows.Forms.Button btnParentAdd;
        private Utility.Classes.tillListBox lbxParentFolders;
        private System.Windows.Forms.Label lblParentFolders;
        private System.Windows.Forms.Button btnChangeColour;
        private System.Windows.Forms.Label lblListItem;
        private System.Windows.Forms.ComboBox cbxItemFolder;
        private System.Windows.Forms.CheckBox cbIsListItem;
        private System.Windows.Forms.BindingSource bstblEPOSListItems;
        private EPOSDBDataSetTableAdapters.tblEPOSListItemsTableAdapter tblEPOSListItemsTableAdapter;
        private System.Windows.Forms.CheckBox cbPrintRed;
        private System.Windows.Forms.CheckBox cbAllowZeroPrice;
        private System.Windows.Forms.Label lblAltsAmounts;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblAltPrices;
        private System.Windows.Forms.TextBox txtQuantityAlt3;
        private System.Windows.Forms.TextBox txtQuantityAlt2;
        private System.Windows.Forms.TextBox txtQuantityAlt1;
        private System.Windows.Forms.TextBox txtPriceAlt3;
        private System.Windows.Forms.TextBox txtPriceAlt2;
        private System.Windows.Forms.TextBox txtPriceAlt1;
        private System.Windows.Forms.TextBox txtTextAlt3;
        private System.Windows.Forms.TextBox txtTextAlt2;
        private System.Windows.Forms.TextBox txtTextAlt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlt3;
        private System.Windows.Forms.Label lblAlt2;
        private System.Windows.Forms.Label lblAlt1;
        private System.Windows.Forms.Button btnParentEditWeight;
        private System.Windows.Forms.Label lblitemPreview;
        private System.Windows.Forms.Button btnUpdateFrontColour;
        private Utility.Classes.RoundedButton btnItemPreview;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.CheckBox cbPrintBar;
        private System.Windows.Forms.CheckBox cbPrintKitchen;
        private System.Windows.Forms.Label lblPrintSettings;
        private System.Windows.Forms.Button btnClearListItem;
    }
}