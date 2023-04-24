namespace CS3._0Project.Code.Management {
    partial class frmDepartmentEditing {
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
            this.btnName = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.bstblEPOSDepartments = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSDepartmentsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSDepartmentsTableAdapter();
            this.lbDepartments = new CS3._0Project.Code.Utility.Classes.tillListBox();
            this.bstblEPOSItems = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSDepartments)).BeginInit();
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
            this.lblUsername.TabIndex = 12;
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
            this.lblParentFolders.Size = new System.Drawing.Size(144, 30);
            this.lblParentFolders.TabIndex = 27;
            this.lblParentFolders.Text = "Departments:";
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.CadetBlue;
            this.btnName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnName.ForeColor = System.Drawing.Color.White;
            this.btnName.Location = new System.Drawing.Point(428, 223);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(120, 74);
            this.btnName.TabIndex = 25;
            this.btnName.Text = "Edit Name";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(428, 143);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 74);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(428, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 74);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1134, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 74);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bstblEPOSDepartments
            // 
            this.bstblEPOSDepartments.DataMember = "tblEPOSDepartments";
            this.bstblEPOSDepartments.DataSource = this.ePOSDBDataSet;
            // 
            // ePOSDBDataSet
            // 
            this.ePOSDBDataSet.DataSetName = "EPOSDBDataSet";
            this.ePOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEPOSDepartmentsTableAdapter
            // 
            this.tblEPOSDepartmentsTableAdapter.ClearBeforeFill = true;
            // 
            // lbDepartments
            // 
            this.lbDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDepartments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDepartments.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lbDepartments.FormattingEnabled = true;
            this.lbDepartments.ItemHeight = 30;
            this.lbDepartments.Location = new System.Drawing.Point(5, 63);
            this.lbDepartments.Name = "lbDepartments";
            this.lbDepartments.ShowScrollbar = false;
            this.lbDepartments.Size = new System.Drawing.Size(417, 570);
            this.lbDepartments.TabIndex = 22;
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
            // frmDepartmentEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.BackgroundImage = global::CS3._0Project.Properties.Resources.BVIcon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1245, 673);
            this.ControlBox = false;
            this.Controls.Add(this.lblParentFolders);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbDepartments);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDepartmentEditing";
            this.Load += new System.EventHandler(this.frmDepartmentEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblParentFolders;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private Utility.Classes.tillListBox lbDepartments;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource bstblEPOSDepartments;
        private EPOSDBDataSet ePOSDBDataSet;
        private EPOSDBDataSetTableAdapters.tblEPOSDepartmentsTableAdapter tblEPOSDepartmentsTableAdapter;
        private System.Windows.Forms.BindingSource bstblEPOSItems;
        private EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter tblEPOSItemsTableAdapter;
    }
}