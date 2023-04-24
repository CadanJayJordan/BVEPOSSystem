namespace CS3._0Project.Code.Management {
    partial class frmListItemEditing {
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblParentFolders = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbLists = new CS3._0Project.Code.Utility.Classes.tillListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlLists = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lbListItems = new CS3._0Project.Code.Utility.Classes.tillListBox();
            this.lblListItems = new System.Windows.Forms.Label();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.btnItemRemove = new System.Windows.Forms.Button();
            this.cbxItemList = new System.Windows.Forms.ComboBox();
            this.bstblEPOSListItems = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSListItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSListItemsTableAdapter();
            this.bstblEPOSItems = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter();
            this.cbZeroPrice = new System.Windows.Forms.CheckBox();
            this.pnlLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItems)).BeginInit();
            this.SuspendLayout();
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
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "{0}";
            // 
            // lblParentFolders
            // 
            this.lblParentFolders.AutoSize = true;
            this.lblParentFolders.BackColor = System.Drawing.Color.Transparent;
            this.lblParentFolders.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentFolders.ForeColor = System.Drawing.Color.Black;
            this.lblParentFolders.Location = new System.Drawing.Point(0, 30);
            this.lblParentFolders.Name = "lblParentFolders";
            this.lblParentFolders.Size = new System.Drawing.Size(59, 30);
            this.lblParentFolders.TabIndex = 32;
            this.lblParentFolders.Text = "Lists:";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(131, 608);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 74);
            this.btnRemove.TabIndex = 31;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(5, 608);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 74);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbLists
            // 
            this.lbLists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLists.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lbLists.FormattingEnabled = true;
            this.lbLists.ItemHeight = 30;
            this.lbLists.Location = new System.Drawing.Point(5, 63);
            this.lbLists.Name = "lbLists";
            this.lbLists.ShowScrollbar = false;
            this.lbLists.Size = new System.Drawing.Size(246, 540);
            this.lbLists.TabIndex = 29;
            this.lbLists.SelectedIndexChanged += new System.EventHandler(this.lbLists_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1073, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 74);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlLists
            // 
            this.pnlLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLists.BackColor = System.Drawing.Color.Transparent;
            this.pnlLists.Controls.Add(this.cbZeroPrice);
            this.pnlLists.Controls.Add(this.cbxItemList);
            this.pnlLists.Controls.Add(this.btnItemRemove);
            this.pnlLists.Controls.Add(this.btnItemAdd);
            this.pnlLists.Controls.Add(this.lblListItems);
            this.pnlLists.Controls.Add(this.lbListItems);
            this.pnlLists.Controls.Add(this.txtName);
            this.pnlLists.Controls.Add(this.lblName);
            this.pnlLists.Location = new System.Drawing.Point(257, 63);
            this.pnlLists.Name = "pnlLists";
            this.pnlLists.Size = new System.Drawing.Size(810, 619);
            this.pnlLists.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(136, 1);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 33);
            this.txtName.TabIndex = 35;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 30);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "List Name:";
            // 
            // lbListItems
            // 
            this.lbListItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbListItems.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListItems.FormattingEnabled = true;
            this.lbListItems.ItemHeight = 25;
            this.lbListItems.Location = new System.Drawing.Point(8, 106);
            this.lbListItems.Name = "lbListItems";
            this.lbListItems.ShowScrollbar = false;
            this.lbListItems.Size = new System.Drawing.Size(320, 479);
            this.lbListItems.TabIndex = 34;
            // 
            // lblListItems
            // 
            this.lblListItems.AutoSize = true;
            this.lblListItems.BackColor = System.Drawing.Color.Transparent;
            this.lblListItems.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListItems.ForeColor = System.Drawing.Color.Black;
            this.lblListItems.Location = new System.Drawing.Point(3, 73);
            this.lblListItems.Name = "lblListItems";
            this.lblListItems.Size = new System.Drawing.Size(71, 30);
            this.lblListItems.TabIndex = 36;
            this.lblListItems.Text = "Items:";
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnItemAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnItemAdd.ForeColor = System.Drawing.Color.White;
            this.btnItemAdd.Location = new System.Drawing.Point(334, 145);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(120, 74);
            this.btnItemAdd.TabIndex = 34;
            this.btnItemAdd.Text = "Add";
            this.btnItemAdd.UseVisualStyleBackColor = false;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // btnItemRemove
            // 
            this.btnItemRemove.BackColor = System.Drawing.Color.CadetBlue;
            this.btnItemRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnItemRemove.ForeColor = System.Drawing.Color.White;
            this.btnItemRemove.Location = new System.Drawing.Point(334, 225);
            this.btnItemRemove.Name = "btnItemRemove";
            this.btnItemRemove.Size = new System.Drawing.Size(120, 74);
            this.btnItemRemove.TabIndex = 37;
            this.btnItemRemove.Text = "Remove";
            this.btnItemRemove.UseVisualStyleBackColor = false;
            this.btnItemRemove.Click += new System.EventHandler(this.btnItemRemove_Click);
            // 
            // cbxItemList
            // 
            this.cbxItemList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItemList.FormattingEnabled = true;
            this.cbxItemList.Location = new System.Drawing.Point(334, 106);
            this.cbxItemList.Name = "cbxItemList";
            this.cbxItemList.Size = new System.Drawing.Size(235, 33);
            this.cbxItemList.TabIndex = 40;
            // 
            // bstblEPOSListItems
            // 
            this.bstblEPOSListItems.DataMember = "tblEPOSListItems";
            this.bstblEPOSListItems.DataSource = this.ePOSDBDataSet;
            // 
            // ePOSDBDataSet
            // 
            this.ePOSDBDataSet.DataSetName = "EPOSDBDataSet";
            this.ePOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEPOSListItemsTableAdapter
            // 
            this.tblEPOSListItemsTableAdapter.ClearBeforeFill = true;
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
            // cbZeroPrice
            // 
            this.cbZeroPrice.AutoSize = true;
            this.cbZeroPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbZeroPrice.ForeColor = System.Drawing.Color.Black;
            this.cbZeroPrice.Location = new System.Drawing.Point(80, 40);
            this.cbZeroPrice.Name = "cbZeroPrice";
            this.cbZeroPrice.Size = new System.Drawing.Size(305, 34);
            this.cbZeroPrice.TabIndex = 45;
            this.cbZeroPrice.Text = "Force Subsequent Zero Price";
            this.cbZeroPrice.UseVisualStyleBackColor = true;
            this.cbZeroPrice.CheckedChanged += new System.EventHandler(this.cbZeroPrice_CheckedChanged);
            // 
            // frmListItemEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.BackgroundImage = global::CS3._0Project.Properties.Resources.BVIcon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 694);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLists);
            this.Controls.Add(this.lblParentFolders);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbLists);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListItemEditing";
            this.Load += new System.EventHandler(this.frmListItemEditing_Load);
            this.pnlLists.ResumeLayout(false);
            this.pnlLists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblParentFolders;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private Utility.Classes.tillListBox lbLists;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlLists;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private Utility.Classes.tillListBox lbListItems;
        private System.Windows.Forms.Label lblListItems;
        private System.Windows.Forms.Button btnItemRemove;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.ComboBox cbxItemList;
        private System.Windows.Forms.BindingSource bstblEPOSListItems;
        private EPOSDBDataSet ePOSDBDataSet;
        private EPOSDBDataSetTableAdapters.tblEPOSListItemsTableAdapter tblEPOSListItemsTableAdapter;
        private System.Windows.Forms.BindingSource bstblEPOSItems;
        private EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter tblEPOSItemsTableAdapter;
        private System.Windows.Forms.CheckBox cbZeroPrice;
    }
}