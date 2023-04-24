namespace CS3._0Project.Code.Management {
    partial class frmTableFloorEditing {
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
            this.btnBack = new System.Windows.Forms.Button();
            this.bstblEPOSTableFloors = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSTableFloorsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSTableFloorsTableAdapter();
            this.bstblEPOSTables = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSTablesTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSTablesTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.lblParentFolders = new System.Windows.Forms.Label();
            this.lbTablesFloors = new CS3._0Project.Code.Utility.Classes.tillListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTableFloors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTables)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Black;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(0, 0);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(36, 30);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "{0}";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1044, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 74);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bstblEPOSTableFloors
            // 
            this.bstblEPOSTableFloors.DataMember = "tblEPOSTableFloors";
            this.bstblEPOSTableFloors.DataSource = this.ePOSDBDataSet;
            // 
            // ePOSDBDataSet
            // 
            this.ePOSDBDataSet.DataSetName = "EPOSDBDataSet";
            this.ePOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEPOSTableFloorsTableAdapter
            // 
            this.tblEPOSTableFloorsTableAdapter.ClearBeforeFill = true;
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(495, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 74);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(495, 143);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 74);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.CadetBlue;
            this.btnName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnName.ForeColor = System.Drawing.Color.White;
            this.btnName.Location = new System.Drawing.Point(495, 223);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(120, 74);
            this.btnName.TabIndex = 18;
            this.btnName.Text = "Edit Name";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnLocation.ForeColor = System.Drawing.Color.White;
            this.btnLocation.Location = new System.Drawing.Point(495, 303);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(120, 74);
            this.btnLocation.TabIndex = 19;
            this.btnLocation.Text = "Edit Location";
            this.btnLocation.UseVisualStyleBackColor = false;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // lblParentFolders
            // 
            this.lblParentFolders.AutoSize = true;
            this.lblParentFolders.BackColor = System.Drawing.Color.Transparent;
            this.lblParentFolders.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentFolders.ForeColor = System.Drawing.Color.Black;
            this.lblParentFolders.Location = new System.Drawing.Point(0, 30);
            this.lblParentFolders.Name = "lblParentFolders";
            this.lblParentFolders.Size = new System.Drawing.Size(429, 30);
            this.lblParentFolders.TabIndex = 20;
            this.lblParentFolders.Text = "Table Floors (Floor name: Location Weight):";
            // 
            // lbTablesFloors
            // 
            this.lbTablesFloors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTablesFloors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTablesFloors.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lbTablesFloors.FormattingEnabled = true;
            this.lbTablesFloors.ItemHeight = 30;
            this.lbTablesFloors.Location = new System.Drawing.Point(5, 63);
            this.lbTablesFloors.Name = "lbTablesFloors";
            this.lbTablesFloors.ShowScrollbar = false;
            this.lbTablesFloors.Size = new System.Drawing.Size(484, 480);
            this.lbTablesFloors.TabIndex = 15;
            // 
            // frmTableFloorEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.BackgroundImage = global::CS3._0Project.Properties.Resources.BVIcon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1155, 572);
            this.ControlBox = false;
            this.Controls.Add(this.lblParentFolders);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbTablesFloors);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUsername);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTableFloorEditing";
            this.Load += new System.EventHandler(this.frmTableFloorEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTableFloors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource bstblEPOSTableFloors;
        private EPOSDBDataSet ePOSDBDataSet;
        private EPOSDBDataSetTableAdapters.tblEPOSTableFloorsTableAdapter tblEPOSTableFloorsTableAdapter;
        private System.Windows.Forms.BindingSource bstblEPOSTables;
        private EPOSDBDataSetTableAdapters.tblEPOSTablesTableAdapter tblEPOSTablesTableAdapter;
        private Utility.Classes.tillListBox lbTablesFloors;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Label lblParentFolders;
    }
}