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
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.btnClock = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.tblEPOSItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.tblEPOSItemsTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter();
            this.btnManagerFunctions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblEPOSItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1808, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSalesMode
            // 
            this.btnSalesMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalesMode.ForeColor = System.Drawing.Color.White;
            this.btnSalesMode.Location = new System.Drawing.Point(66, 80);
            this.btnSalesMode.Name = "btnSalesMode";
            this.btnSalesMode.Size = new System.Drawing.Size(350, 150);
            this.btnSalesMode.TabIndex = 1;
            this.btnSalesMode.Text = "Sale";
            this.btnSalesMode.UseVisualStyleBackColor = false;
            this.btnSalesMode.Click += new System.EventHandler(this.btnSalesMode_Click);
            // 
            // btnRefundMode
            // 
            this.btnRefundMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRefundMode.ForeColor = System.Drawing.Color.White;
            this.btnRefundMode.Location = new System.Drawing.Point(66, 250);
            this.btnRefundMode.Name = "btnRefundMode";
            this.btnRefundMode.Size = new System.Drawing.Size(350, 150);
            this.btnRefundMode.TabIndex = 2;
            this.btnRefundMode.Text = "Refund";
            this.btnRefundMode.UseVisualStyleBackColor = false;
            this.btnRefundMode.Click += new System.EventHandler(this.btnRefundMode_Click);
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConfiguration.ForeColor = System.Drawing.Color.White;
            this.btnConfiguration.Location = new System.Drawing.Point(319, 421);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(97, 64);
            this.btnConfiguration.TabIndex = 3;
            this.btnConfiguration.Text = "Config";
            this.btnConfiguration.UseVisualStyleBackColor = false;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(66, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(350, 55);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKeyboard.ForeColor = System.Drawing.Color.White;
            this.btnKeyboard.Location = new System.Drawing.Point(707, 331);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(350, 55);
            this.btnKeyboard.TabIndex = 5;
            this.btnKeyboard.Text = "Keyboard";
            this.btnKeyboard.UseVisualStyleBackColor = false;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnClock
            // 
            this.btnClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClock.ForeColor = System.Drawing.Color.White;
            this.btnClock.Location = new System.Drawing.Point(66, 421);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(247, 64);
            this.btnClock.TabIndex = 6;
            this.btnClock.Text = "Clock In/Out";
            this.btnClock.UseVisualStyleBackColor = false;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMessage.ForeColor = System.Drawing.Color.White;
            this.btnMessage.Location = new System.Drawing.Point(707, 392);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(350, 55);
            this.btnMessage.TabIndex = 7;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // tblEPOSItemsBindingSource
            // 
            this.tblEPOSItemsBindingSource.DataMember = "tblEPOSItems";
            this.tblEPOSItemsBindingSource.DataSource = this.ePOSDBDataSet;
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
            // btnManagerFunctions
            // 
            this.btnManagerFunctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnManagerFunctions.ForeColor = System.Drawing.Color.White;
            this.btnManagerFunctions.Location = new System.Drawing.Point(422, 80);
            this.btnManagerFunctions.Name = "btnManagerFunctions";
            this.btnManagerFunctions.Size = new System.Drawing.Size(133, 320);
            this.btnManagerFunctions.TabIndex = 8;
            this.btnManagerFunctions.Text = "Manager Functions";
            this.btnManagerFunctions.UseVisualStyleBackColor = false;
            this.btnManagerFunctions.Click += new System.EventHandler(this.btnManagerFunctions_Click);
            // 
            // frmEPOSMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.btnManagerFunctions);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnClock);
            this.Controls.Add(this.btnKeyboard);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnConfiguration);
            this.Controls.Add(this.btnRefundMode);
            this.Controls.Add(this.btnSalesMode);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEPOSMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EPOSMenu";
            this.Load += new System.EventHandler(this.frmEPOSMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblEPOSItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSalesMode;
        private System.Windows.Forms.Button btnRefundMode;
        private System.Windows.Forms.Button btnConfiguration;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposItemYDataGridViewTextBoxColumn;
        private EPOSDBDataSet ePOSDBDataSet;
        private System.Windows.Forms.BindingSource tblEPOSItemsBindingSource;
        private EPOSDBDataSetTableAdapters.tblEPOSItemsTableAdapter tblEPOSItemsTableAdapter;
        private System.Windows.Forms.Button btnManagerFunctions;
    }
}