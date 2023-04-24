namespace CS3._0Project.Forms {
    partial class frmEPOSMenu {
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSalesMode = new System.Windows.Forms.Button();
            this.btnRefundMode = new System.Windows.Forms.Button();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClock = new System.Windows.Forms.Button();
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.btnManagerFunctions = new System.Windows.Forms.Button();
            this.bstblEPOSUsers = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSUsersTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSUsersTableAdapter();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1304, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSalesMode
            // 
            this.btnSalesMode.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSalesMode.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesMode.ForeColor = System.Drawing.Color.White;
            this.btnSalesMode.Location = new System.Drawing.Point(67, 157);
            this.btnSalesMode.Name = "btnSalesMode";
            this.btnSalesMode.Size = new System.Drawing.Size(381, 176);
            this.btnSalesMode.TabIndex = 1;
            this.btnSalesMode.Text = "Sale";
            this.btnSalesMode.UseVisualStyleBackColor = false;
            this.btnSalesMode.Click += new System.EventHandler(this.btnSalesMode_Click);
            // 
            // btnRefundMode
            // 
            this.btnRefundMode.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRefundMode.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefundMode.ForeColor = System.Drawing.Color.White;
            this.btnRefundMode.Location = new System.Drawing.Point(67, 339);
            this.btnRefundMode.Name = "btnRefundMode";
            this.btnRefundMode.Size = new System.Drawing.Size(381, 176);
            this.btnRefundMode.TabIndex = 2;
            this.btnRefundMode.Text = "Refund";
            this.btnRefundMode.UseVisualStyleBackColor = false;
            this.btnRefundMode.Click += new System.EventHandler(this.btnRefundMode_Click);
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.BackColor = System.Drawing.Color.CadetBlue;
            this.btnConfiguration.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguration.ForeColor = System.Drawing.Color.White;
            this.btnConfiguration.Location = new System.Drawing.Point(454, 437);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(288, 78);
            this.btnConfiguration.TabIndex = 3;
            this.btnConfiguration.Text = "Config";
            this.btnConfiguration.UseVisualStyleBackColor = false;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(67, 57);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(381, 94);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClock
            // 
            this.btnClock.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClock.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClock.ForeColor = System.Drawing.Color.White;
            this.btnClock.Location = new System.Drawing.Point(454, 57);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(288, 94);
            this.btnClock.TabIndex = 6;
            this.btnClock.Text = "Clock In/Out";
            this.btnClock.UseVisualStyleBackColor = false;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // ePOSDBDataSet
            // 
            this.ePOSDBDataSet.DataSetName = "EPOSDBDataSet";
            this.ePOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnManagerFunctions
            // 
            this.btnManagerFunctions.BackColor = System.Drawing.Color.CadetBlue;
            this.btnManagerFunctions.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerFunctions.ForeColor = System.Drawing.Color.White;
            this.btnManagerFunctions.Location = new System.Drawing.Point(454, 339);
            this.btnManagerFunctions.Name = "btnManagerFunctions";
            this.btnManagerFunctions.Size = new System.Drawing.Size(288, 92);
            this.btnManagerFunctions.TabIndex = 8;
            this.btnManagerFunctions.Text = "Manager Functions";
            this.btnManagerFunctions.UseVisualStyleBackColor = false;
            this.btnManagerFunctions.Click += new System.EventHandler(this.btnManagerFunctions_Click);
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
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "{0}";
            // 
            // frmEPOSMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.BackgroundImage = global::CS3._0Project.Properties.Resources.BVIcon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1416, 629);
            this.ControlBox = false;
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnManagerFunctions);
            this.Controls.Add(this.btnClock);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnConfiguration);
            this.Controls.Add(this.btnRefundMode);
            this.Controls.Add(this.btnSalesMode);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEPOSMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EPOSMenu";
            this.Load += new System.EventHandler(this.frmEPOSMenu_Load);
            this.Shown += new System.EventHandler(this.frmEPOSMenu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSalesMode;
        private System.Windows.Forms.Button btnRefundMode;
        private System.Windows.Forms.Button btnConfiguration;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemYDataGridViewTextBoxColumn;
        private EPOSDBDataSet ePOSDBDataSet;
        private System.Windows.Forms.Button btnManagerFunctions;
        private EPOSDBDataSetTableAdapters.tblEPOSUsersTableAdapter tblEPOSUsersTableAdapter;
        private System.Windows.Forms.BindingSource bstblEPOSUsers;
        private System.Windows.Forms.Label lblUsername;
    }
}