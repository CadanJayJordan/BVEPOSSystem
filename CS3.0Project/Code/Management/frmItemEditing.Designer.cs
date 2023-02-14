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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node4", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.btnClose = new System.Windows.Forms.Button();
            this.bstblEPOSItems = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter();
            this.bstblEPOSItemPrice = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSItemPriceTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemPriceTableAdapter();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1207, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 43);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
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
            this.cbxItems.DataSource = this.bstblEPOSItems;
            this.cbxItems.DisplayMember = "eposItemName";
            this.cbxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(40, 62);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(205, 319);
            this.cbxItems.TabIndex = 2;
            this.cbxItems.ValueMember = "eposItemID";
            this.cbxItems.SelectedIndexChanged += new System.EventHandler(this.cbxItems_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(315, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "label1";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(499, 78);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            treeNode4.Name = "Node7";
            treeNode4.Text = "Node7";
            treeNode5.Name = "Node8";
            treeNode5.Text = "Node8";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Node3";
            treeNode7.Name = "Node5";
            treeNode7.Text = "Node5";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Node6";
            treeNode9.Name = "Node4";
            treeNode9.Text = "Node4";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(121, 180);
            this.treeView1.TabIndex = 4;
            // 
            // frmItemEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1294, 646);
            this.ControlBox = false;
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbxItems);
            this.Controls.Add(this.btnClose);
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
        private System.Windows.Forms.TreeView treeView1;
    }
}