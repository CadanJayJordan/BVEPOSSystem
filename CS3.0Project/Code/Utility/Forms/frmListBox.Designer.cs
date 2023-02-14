namespace CS3._0Project.Code.Utility.Forms {
    partial class frmListBox {
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
            this.lbxListDisplay = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bstblEPOSListItems = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSListItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSListItemsTableAdapter();
            this.bstblEPOSItems = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxListDisplay
            // 
            this.lbxListDisplay.BackColor = System.Drawing.Color.Black;
            this.lbxListDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxListDisplay.ForeColor = System.Drawing.Color.White;
            this.lbxListDisplay.FormattingEnabled = true;
            this.lbxListDisplay.ItemHeight = 25;
            this.lbxListDisplay.Items.AddRange(new object[] {
            "20"});
            this.lbxListDisplay.Location = new System.Drawing.Point(12, 38);
            this.lbxListDisplay.Name = "lbxListDisplay";
            this.lbxListDisplay.Size = new System.Drawing.Size(246, 329);
            this.lbxListDisplay.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(246, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "20";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(12, 373);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(109, 38);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(149, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(270, 423);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbxListDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Box";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxListDisplay;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bstblEPOSListItems;
        private EPOSDBDataSet ePOSDBDataSet;
        private EPOSDBDataSetTableAdapters.tblEPOSListItemsTableAdapter tblEPOSListItemsTableAdapter;
        private System.Windows.Forms.BindingSource bstblEPOSItems;
        private EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter tblEPOSItemsTableAdapter;
    }
}