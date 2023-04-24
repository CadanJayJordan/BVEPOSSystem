namespace CS3._0Project.Code.Management {
    partial class frmManagementFunctions {
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditTablePlan = new System.Windows.Forms.Button();
            this.btnItemEditing = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.btnTableFloorEditing = new System.Windows.Forms.Button();
            this.btnEditDepartments = new System.Windows.Forms.Button();
            this.btnEditFolders = new System.Windows.Forms.Button();
            this.btnEditLists = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1136, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 76);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEditTablePlan
            // 
            this.btnEditTablePlan.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEditTablePlan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnEditTablePlan.ForeColor = System.Drawing.Color.White;
            this.btnEditTablePlan.Location = new System.Drawing.Point(12, 49);
            this.btnEditTablePlan.Name = "btnEditTablePlan";
            this.btnEditTablePlan.Size = new System.Drawing.Size(133, 129);
            this.btnEditTablePlan.TabIndex = 1;
            this.btnEditTablePlan.Text = "Edit Table Plan";
            this.btnEditTablePlan.UseVisualStyleBackColor = false;
            this.btnEditTablePlan.Click += new System.EventHandler(this.btnEditTablePlan_Click);
            // 
            // btnItemEditing
            // 
            this.btnItemEditing.BackColor = System.Drawing.Color.CadetBlue;
            this.btnItemEditing.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnItemEditing.ForeColor = System.Drawing.Color.White;
            this.btnItemEditing.Location = new System.Drawing.Point(151, 49);
            this.btnItemEditing.Name = "btnItemEditing";
            this.btnItemEditing.Size = new System.Drawing.Size(133, 129);
            this.btnItemEditing.TabIndex = 3;
            this.btnItemEditing.Text = "Edit Items";
            this.btnItemEditing.UseVisualStyleBackColor = false;
            this.btnItemEditing.Click += new System.EventHandler(this.btnItemEditing_Click);
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
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "{0}";
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEditUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnEditUsers.ForeColor = System.Drawing.Color.White;
            this.btnEditUsers.Location = new System.Drawing.Point(429, 49);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(133, 129);
            this.btnEditUsers.TabIndex = 12;
            this.btnEditUsers.Text = "Edit Users";
            this.btnEditUsers.UseVisualStyleBackColor = false;
            this.btnEditUsers.Click += new System.EventHandler(this.btnEditUsers_Click);
            // 
            // btnTableFloorEditing
            // 
            this.btnTableFloorEditing.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTableFloorEditing.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnTableFloorEditing.ForeColor = System.Drawing.Color.White;
            this.btnTableFloorEditing.Location = new System.Drawing.Point(12, 184);
            this.btnTableFloorEditing.Name = "btnTableFloorEditing";
            this.btnTableFloorEditing.Size = new System.Drawing.Size(133, 129);
            this.btnTableFloorEditing.TabIndex = 13;
            this.btnTableFloorEditing.Text = "Edit Table Floors";
            this.btnTableFloorEditing.UseVisualStyleBackColor = false;
            this.btnTableFloorEditing.Click += new System.EventHandler(this.btnTableFloorEditing_Click);
            // 
            // btnEditDepartments
            // 
            this.btnEditDepartments.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEditDepartments.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnEditDepartments.ForeColor = System.Drawing.Color.White;
            this.btnEditDepartments.Location = new System.Drawing.Point(290, 49);
            this.btnEditDepartments.Name = "btnEditDepartments";
            this.btnEditDepartments.Size = new System.Drawing.Size(133, 129);
            this.btnEditDepartments.TabIndex = 14;
            this.btnEditDepartments.Text = "Edit Departments";
            this.btnEditDepartments.UseVisualStyleBackColor = false;
            this.btnEditDepartments.Click += new System.EventHandler(this.btnEditDepartments_Click);
            // 
            // btnEditFolders
            // 
            this.btnEditFolders.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEditFolders.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnEditFolders.ForeColor = System.Drawing.Color.White;
            this.btnEditFolders.Location = new System.Drawing.Point(290, 184);
            this.btnEditFolders.Name = "btnEditFolders";
            this.btnEditFolders.Size = new System.Drawing.Size(133, 129);
            this.btnEditFolders.TabIndex = 15;
            this.btnEditFolders.Text = "Edit Folders";
            this.btnEditFolders.UseVisualStyleBackColor = false;
            this.btnEditFolders.Click += new System.EventHandler(this.btnEditFolders_Click);
            // 
            // btnEditLists
            // 
            this.btnEditLists.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEditLists.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnEditLists.ForeColor = System.Drawing.Color.White;
            this.btnEditLists.Location = new System.Drawing.Point(151, 184);
            this.btnEditLists.Name = "btnEditLists";
            this.btnEditLists.Size = new System.Drawing.Size(133, 129);
            this.btnEditLists.TabIndex = 16;
            this.btnEditLists.Text = "Edit Lists";
            this.btnEditLists.UseVisualStyleBackColor = false;
            this.btnEditLists.Click += new System.EventHandler(this.btnEditLists_Click);
            // 
            // frmManagementFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.BackgroundImage = global::CS3._0Project.Properties.Resources.BVIcon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1252, 667);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditLists);
            this.Controls.Add(this.btnEditFolders);
            this.Controls.Add(this.btnEditDepartments);
            this.Controls.Add(this.btnTableFloorEditing);
            this.Controls.Add(this.btnEditUsers);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnItemEditing);
            this.Controls.Add(this.btnEditTablePlan);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManagementFunctions";
            this.Text = "Management Functions";
            this.Load += new System.EventHandler(this.frmManagementFunctions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditTablePlan;
        private System.Windows.Forms.Button btnItemEditing;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnEditUsers;
        private System.Windows.Forms.Button btnTableFloorEditing;
        private System.Windows.Forms.Button btnEditDepartments;
        private System.Windows.Forms.Button btnEditFolders;
        private System.Windows.Forms.Button btnEditLists;
    }
}