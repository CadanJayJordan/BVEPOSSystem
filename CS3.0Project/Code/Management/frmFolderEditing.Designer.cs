namespace CS3._0Project.Code.Management {
    partial class frmFolderEditing {
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
            this.bstblEPOSItemFolders = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSItemFoldersTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemFoldersTableAdapter();
            this.bstblEPOSItems = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter();
            this.cbxParent = new System.Windows.Forms.ComboBox();
            this.lblParents = new System.Windows.Forms.Label();
            this.btnUpdateFrontColour = new System.Windows.Forms.Button();
            this.lblitemPreview = new System.Windows.Forms.Label();
            this.btnChangeColour = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.lblFolders = new CS3._0Project.Code.Utility.Classes.tillListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemFolders)).BeginInit();
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
            this.lblUsername.TabIndex = 10;
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
            this.lblParentFolders.Size = new System.Drawing.Size(422, 30);
            this.lblParentFolders.TabIndex = 26;
            this.lblParentFolders.Text = "Folders (Folder name: Parent folder name):";
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.CadetBlue;
            this.btnName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnName.ForeColor = System.Drawing.Color.White;
            this.btnName.Location = new System.Drawing.Point(495, 223);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(132, 74);
            this.btnName.TabIndex = 24;
            this.btnName.Text = "Edit Name";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(495, 143);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(132, 74);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(495, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 74);
            this.btnAdd.TabIndex = 22;
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
            this.btnBack.Location = new System.Drawing.Point(1109, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 74);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bstblEPOSItemFolders
            // 
            this.bstblEPOSItemFolders.DataMember = "tblEPOSItemFolders";
            this.bstblEPOSItemFolders.DataSource = this.ePOSDBDataSet;
            // 
            // ePOSDBDataSet
            // 
            this.ePOSDBDataSet.DataSetName = "EPOSDBDataSet";
            this.ePOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEPOSItemFoldersTableAdapter
            // 
            this.tblEPOSItemFoldersTableAdapter.ClearBeforeFill = true;
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
            // cbxParent
            // 
            this.cbxParent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxParent.FormattingEnabled = true;
            this.cbxParent.Location = new System.Drawing.Point(498, 333);
            this.cbxParent.Name = "cbxParent";
            this.cbxParent.Size = new System.Drawing.Size(317, 33);
            this.cbxParent.TabIndex = 28;
            this.cbxParent.SelectedIndexChanged += new System.EventHandler(this.cbxParent_SelectedIndexChanged);
            // 
            // lblParents
            // 
            this.lblParents.AutoSize = true;
            this.lblParents.BackColor = System.Drawing.Color.Transparent;
            this.lblParents.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParents.ForeColor = System.Drawing.Color.Black;
            this.lblParents.Location = new System.Drawing.Point(495, 300);
            this.lblParents.Name = "lblParents";
            this.lblParents.Size = new System.Drawing.Size(79, 30);
            this.lblParents.TabIndex = 29;
            this.lblParents.Text = "Parent:";
            // 
            // btnUpdateFrontColour
            // 
            this.btnUpdateFrontColour.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdateFrontColour.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFrontColour.ForeColor = System.Drawing.Color.White;
            this.btnUpdateFrontColour.Location = new System.Drawing.Point(708, 474);
            this.btnUpdateFrontColour.Name = "btnUpdateFrontColour";
            this.btnUpdateFrontColour.Size = new System.Drawing.Size(105, 111);
            this.btnUpdateFrontColour.TabIndex = 46;
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
            this.lblitemPreview.Location = new System.Drawing.Point(495, 369);
            this.lblitemPreview.Name = "lblitemPreview";
            this.lblitemPreview.Size = new System.Drawing.Size(142, 30);
            this.lblitemPreview.TabIndex = 45;
            this.lblitemPreview.Text = "Item Preview:";
            // 
            // btnChangeColour
            // 
            this.btnChangeColour.BackColor = System.Drawing.Color.CadetBlue;
            this.btnChangeColour.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeColour.ForeColor = System.Drawing.Color.White;
            this.btnChangeColour.Location = new System.Drawing.Point(597, 474);
            this.btnChangeColour.Name = "btnChangeColour";
            this.btnChangeColour.Size = new System.Drawing.Size(105, 111);
            this.btnChangeColour.TabIndex = 44;
            this.btnChangeColour.Text = "Edit Button Colour";
            this.btnChangeColour.UseVisualStyleBackColor = false;
            this.btnChangeColour.Click += new System.EventHandler(this.btnChangeColour_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(643, 372);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(130, 100);
            this.btnPreview.TabIndex = 47;
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // lblFolders
            // 
            this.lblFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblFolders.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblFolders.FormattingEnabled = true;
            this.lblFolders.ItemHeight = 30;
            this.lblFolders.Location = new System.Drawing.Point(5, 63);
            this.lblFolders.Name = "lblFolders";
            this.lblFolders.ShowScrollbar = false;
            this.lblFolders.Size = new System.Drawing.Size(484, 480);
            this.lblFolders.TabIndex = 21;
            this.lblFolders.SelectedIndexChanged += new System.EventHandler(this.lblFolders_SelectedIndexChanged);
            // 
            // frmFolderEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.BackgroundImage = global::CS3._0Project.Properties.Resources.BVIcon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1220, 660);
            this.ControlBox = false;
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnUpdateFrontColour);
            this.Controls.Add(this.lblitemPreview);
            this.Controls.Add(this.btnChangeColour);
            this.Controls.Add(this.lblParents);
            this.Controls.Add(this.cbxParent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblParentFolders);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFolders);
            this.Controls.Add(this.lblUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFolderEditing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmUserEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSItemFolders)).EndInit();
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
        private Utility.Classes.tillListBox lblFolders;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource bstblEPOSItemFolders;
        private EPOSDBDataSet ePOSDBDataSet;
        private EPOSDBDataSetTableAdapters.tblEPOSItemFoldersTableAdapter tblEPOSItemFoldersTableAdapter;
        private System.Windows.Forms.BindingSource bstblEPOSItems;
        private EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter tblEPOSItemsTableAdapter;
        private System.Windows.Forms.ComboBox cbxParent;
        private System.Windows.Forms.Label lblParents;
        private System.Windows.Forms.Button btnUpdateFrontColour;
        private System.Windows.Forms.Label lblitemPreview;
        private System.Windows.Forms.Button btnChangeColour;
        private System.Windows.Forms.Button btnPreview;
    }
}