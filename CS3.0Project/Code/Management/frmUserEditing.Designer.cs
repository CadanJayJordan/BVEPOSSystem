namespace CS3._0Project.Code.Management {
    partial class frmUserEditing {
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
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlUserEditing = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtLoginCode = new System.Windows.Forms.TextBox();
            this.lblTillCode = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnPaswdShowHide = new System.Windows.Forms.Button();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtEmailAddr = new System.Windows.Forms.TextBox();
            this.lblEmailAddr = new System.Windows.Forms.Label();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.btnPayShowHide = new System.Windows.Forms.Button();
            this.cbIsManager = new System.Windows.Forms.CheckBox();
            this.bstblEPOSUsers = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSUsersTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSUsersTableAdapter();
            this.lbUsers = new CS3._0Project.Code.Utility.Classes.tillListBox();
            this.pnlUserEditing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
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
            this.lblUsername.TabIndex = 11;
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
            this.lblParentFolders.Size = new System.Drawing.Size(301, 30);
            this.lblParentFolders.TabIndex = 27;
            this.lblParentFolders.Text = "Users (Till Name (login code)):";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(131, 549);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 74);
            this.btnRemove.TabIndex = 24;
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
            this.btnAdd.Location = new System.Drawing.Point(5, 549);
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
            this.btnBack.Location = new System.Drawing.Point(1117, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 74);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlUserEditing
            // 
            this.pnlUserEditing.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserEditing.Controls.Add(this.cbIsManager);
            this.pnlUserEditing.Controls.Add(this.btnPayShowHide);
            this.pnlUserEditing.Controls.Add(this.txtPayRate);
            this.pnlUserEditing.Controls.Add(this.lblPayRate);
            this.pnlUserEditing.Controls.Add(this.txtEmailAddr);
            this.pnlUserEditing.Controls.Add(this.lblEmailAddr);
            this.pnlUserEditing.Controls.Add(this.txtSurname);
            this.pnlUserEditing.Controls.Add(this.lblSurname);
            this.pnlUserEditing.Controls.Add(this.txtForename);
            this.pnlUserEditing.Controls.Add(this.lblForename);
            this.pnlUserEditing.Controls.Add(this.btnPaswdShowHide);
            this.pnlUserEditing.Controls.Add(this.txtPassword);
            this.pnlUserEditing.Controls.Add(this.lblPassword);
            this.pnlUserEditing.Controls.Add(this.txtLoginCode);
            this.pnlUserEditing.Controls.Add(this.lblTillCode);
            this.pnlUserEditing.Controls.Add(this.txtName);
            this.pnlUserEditing.Controls.Add(this.lblName);
            this.pnlUserEditing.Location = new System.Drawing.Point(257, 63);
            this.pnlUserEditing.Name = "pnlUserEditing";
            this.pnlUserEditing.Size = new System.Drawing.Size(854, 590);
            this.pnlUserEditing.TabIndex = 28;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(136, 1);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 33);
            this.txtName.TabIndex = 30;
            this.txtName.Click += new System.EventHandler(this.onTextFieldClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 30);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Username:";
            // 
            // txtLoginCode
            // 
            this.txtLoginCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginCode.Location = new System.Drawing.Point(136, 38);
            this.txtLoginCode.Name = "txtLoginCode";
            this.txtLoginCode.Size = new System.Drawing.Size(75, 33);
            this.txtLoginCode.TabIndex = 32;
            this.txtLoginCode.Click += new System.EventHandler(this.txtLoginCode_Click);
            // 
            // lblTillCode
            // 
            this.lblTillCode.AutoSize = true;
            this.lblTillCode.BackColor = System.Drawing.Color.Transparent;
            this.lblTillCode.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTillCode.ForeColor = System.Drawing.Color.Black;
            this.lblTillCode.Location = new System.Drawing.Point(3, 37);
            this.lblTillCode.Name = "lblTillCode";
            this.lblTillCode.Size = new System.Drawing.Size(127, 30);
            this.lblTillCode.TabIndex = 31;
            this.lblTillCode.Text = "Login Code:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(136, 75);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(240, 33);
            this.txtPassword.TabIndex = 34;
            this.txtPassword.Click += new System.EventHandler(this.onTextFieldClick);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(3, 74);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(108, 30);
            this.lblPassword.TabIndex = 33;
            this.lblPassword.Text = "Password:";
            // 
            // btnPaswdShowHide
            // 
            this.btnPaswdShowHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaswdShowHide.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPaswdShowHide.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnPaswdShowHide.ForeColor = System.Drawing.Color.White;
            this.btnPaswdShowHide.Location = new System.Drawing.Point(382, 64);
            this.btnPaswdShowHide.Name = "btnPaswdShowHide";
            this.btnPaswdShowHide.Size = new System.Drawing.Size(87, 51);
            this.btnPaswdShowHide.TabIndex = 29;
            this.btnPaswdShowHide.Text = "Show";
            this.btnPaswdShowHide.UseVisualStyleBackColor = false;
            this.btnPaswdShowHide.Click += new System.EventHandler(this.btnPaswdShowHide_Click);
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(136, 124);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(240, 33);
            this.txtForename.TabIndex = 36;
            this.txtForename.Click += new System.EventHandler(this.onTextFieldClick);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.BackColor = System.Drawing.Color.Transparent;
            this.lblForename.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.ForeColor = System.Drawing.Color.Black;
            this.lblForename.Location = new System.Drawing.Point(3, 123);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(114, 30);
            this.lblForename.TabIndex = 35;
            this.lblForename.Text = "Forename:";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(136, 163);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(240, 33);
            this.txtSurname.TabIndex = 38;
            this.txtSurname.Click += new System.EventHandler(this.onTextFieldClick);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(3, 162);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(102, 30);
            this.lblSurname.TabIndex = 37;
            this.lblSurname.Text = "Surname:";
            // 
            // txtEmailAddr
            // 
            this.txtEmailAddr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddr.Location = new System.Drawing.Point(133, 216);
            this.txtEmailAddr.Name = "txtEmailAddr";
            this.txtEmailAddr.Size = new System.Drawing.Size(333, 33);
            this.txtEmailAddr.TabIndex = 40;
            this.txtEmailAddr.Click += new System.EventHandler(this.onTextFieldClick);
            // 
            // lblEmailAddr
            // 
            this.lblEmailAddr.AutoSize = true;
            this.lblEmailAddr.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailAddr.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddr.ForeColor = System.Drawing.Color.Black;
            this.lblEmailAddr.Location = new System.Drawing.Point(3, 215);
            this.lblEmailAddr.Name = "lblEmailAddr";
            this.lblEmailAddr.Size = new System.Drawing.Size(124, 30);
            this.lblEmailAddr.TabIndex = 39;
            this.lblEmailAddr.Text = "Email Addr:";
            // 
            // txtPayRate
            // 
            this.txtPayRate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayRate.Location = new System.Drawing.Point(170, 272);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.PasswordChar = '*';
            this.txtPayRate.Size = new System.Drawing.Size(88, 33);
            this.txtPayRate.TabIndex = 42;
            this.txtPayRate.Click += new System.EventHandler(this.txtPayRate_Click);
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.BackColor = System.Drawing.Color.Transparent;
            this.lblPayRate.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRate.ForeColor = System.Drawing.Color.Black;
            this.lblPayRate.Location = new System.Drawing.Point(3, 272);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(161, 30);
            this.lblPayRate.TabIndex = 41;
            this.lblPayRate.Text = "Pay Rate (£/hr):";
            // 
            // btnPayShowHide
            // 
            this.btnPayShowHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayShowHide.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPayShowHide.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnPayShowHide.ForeColor = System.Drawing.Color.White;
            this.btnPayShowHide.Location = new System.Drawing.Point(264, 262);
            this.btnPayShowHide.Name = "btnPayShowHide";
            this.btnPayShowHide.Size = new System.Drawing.Size(87, 51);
            this.btnPayShowHide.TabIndex = 43;
            this.btnPayShowHide.Text = "Show";
            this.btnPayShowHide.UseVisualStyleBackColor = false;
            this.btnPayShowHide.Click += new System.EventHandler(this.btnPayShowHide_Click);
            // 
            // cbIsManager
            // 
            this.cbIsManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIsManager.AutoSize = true;
            this.cbIsManager.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbIsManager.ForeColor = System.Drawing.Color.Black;
            this.cbIsManager.Location = new System.Drawing.Point(229, 36);
            this.cbIsManager.Name = "cbIsManager";
            this.cbIsManager.Size = new System.Drawing.Size(138, 34);
            this.cbIsManager.TabIndex = 44;
            this.cbIsManager.Text = "Is Manager";
            this.cbIsManager.UseVisualStyleBackColor = true;
            // 
            // bstblEPOSUsers
            // 
            this.bstblEPOSUsers.DataMember = "tblEPOSUsers";
            this.bstblEPOSUsers.DataSource = this.ePOSDBDataSet;
            // 
            // ePOSDBDataSet
            // 
            this.ePOSDBDataSet.DataSetName = "EPOSDBDataSet";
            this.ePOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEPOSUsersTableAdapter
            // 
            this.tblEPOSUsersTableAdapter.ClearBeforeFill = true;
            // 
            // lbUsers
            // 
            this.lbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 30;
            this.lbUsers.Location = new System.Drawing.Point(5, 63);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.ShowScrollbar = false;
            this.lbUsers.Size = new System.Drawing.Size(246, 480);
            this.lbUsers.TabIndex = 22;
            this.lbUsers.SelectedIndexChanged += new System.EventHandler(this.lbUsers_SelectedIndexChanged);
            // 
            // frmUserEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.BackgroundImage = global::CS3._0Project.Properties.Resources.BVIcon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1228, 665);
            this.Controls.Add(this.pnlUserEditing);
            this.Controls.Add(this.lblParentFolders);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserEditing";
            this.Load += new System.EventHandler(this.frmUserEditing_Load);
            this.pnlUserEditing.ResumeLayout(false);
            this.pnlUserEditing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblParentFolders;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private Utility.Classes.tillListBox lbUsers;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlUserEditing;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPaswdShowHide;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLoginCode;
        private System.Windows.Forms.Label lblTillCode;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtEmailAddr;
        private System.Windows.Forms.Label lblEmailAddr;
        private System.Windows.Forms.Button btnPayShowHide;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.CheckBox cbIsManager;
        private System.Windows.Forms.BindingSource bstblEPOSUsers;
        private EPOSDBDataSet ePOSDBDataSet;
        private EPOSDBDataSetTableAdapters.tblEPOSUsersTableAdapter tblEPOSUsersTableAdapter;
    }
}