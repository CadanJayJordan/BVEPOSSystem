namespace CS3._0Project.Code.Management {
    partial class frmClock {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblNameText = new System.Windows.Forms.Label();
            this.pnlManager = new System.Windows.Forms.Panel();
            this.lblMangrClocked = new System.Windows.Forms.Label();
            this.lblSelectedUser = new System.Windows.Forms.Label();
            this.cbxMngrSelectedUser = new System.Windows.Forms.ComboBox();
            this.tblEPOSUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.btnDeleteShift = new System.Windows.Forms.Button();
            this.lblManager = new System.Windows.Forms.Label();
            this.tblClockLogTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblClockLogTableAdapter();
            this.bstblEPOSUsers = new System.Windows.Forms.BindingSource(this.components);
            this.bstblClockLog = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSUsersTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSUsersTableAdapter();
            this.dgvClockDisplay = new System.Windows.Forms.DataGridView();
            this.dgvColClockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColClockOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColClockNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClockIn = new System.Windows.Forms.Button();
            this.btnClockOut = new System.Windows.Forms.Button();
            this.pnlStandard = new System.Windows.Forms.Panel();
            this.pnlManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEPOSUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblClockLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClockDisplay)).BeginInit();
            this.pnlStandard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.CadetBlue;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(1144, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(123, 106);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameText.Location = new System.Drawing.Point(7, -4);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(103, 60);
            this.lblNameText.TabIndex = 4;
            this.lblNameText.Text = "User: {0}\r\nName: {1}\r\n";
            // 
            // pnlManager
            // 
            this.pnlManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlManager.AutoSize = true;
            this.pnlManager.Controls.Add(this.lblMangrClocked);
            this.pnlManager.Controls.Add(this.lblSelectedUser);
            this.pnlManager.Controls.Add(this.cbxMngrSelectedUser);
            this.pnlManager.Controls.Add(this.btnAddShift);
            this.pnlManager.Controls.Add(this.btnDeleteShift);
            this.pnlManager.Controls.Add(this.lblManager);
            this.pnlManager.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlManager.Location = new System.Drawing.Point(342, 9);
            this.pnlManager.Name = "pnlManager";
            this.pnlManager.Size = new System.Drawing.Size(466, 163);
            this.pnlManager.TabIndex = 5;
            // 
            // lblMangrClocked
            // 
            this.lblMangrClocked.AutoSize = true;
            this.lblMangrClocked.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMangrClocked.Location = new System.Drawing.Point(5, 89);
            this.lblMangrClocked.Name = "lblMangrClocked";
            this.lblMangrClocked.Size = new System.Drawing.Size(114, 21);
            this.lblMangrClocked.TabIndex = 14;
            this.lblMangrClocked.Text = "Clocked In/Out";
            // 
            // lblSelectedUser
            // 
            this.lblSelectedUser.AutoSize = true;
            this.lblSelectedUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSelectedUser.Location = new System.Drawing.Point(5, 35);
            this.lblSelectedUser.Name = "lblSelectedUser";
            this.lblSelectedUser.Size = new System.Drawing.Size(107, 21);
            this.lblSelectedUser.TabIndex = 13;
            this.lblSelectedUser.Text = "Selected User:";
            // 
            // cbxMngrSelectedUser
            // 
            this.cbxMngrSelectedUser.DataSource = this.tblEPOSUsersBindingSource;
            this.cbxMngrSelectedUser.DisplayMember = "userName";
            this.cbxMngrSelectedUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMngrSelectedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbxMngrSelectedUser.FormattingEnabled = true;
            this.cbxMngrSelectedUser.Location = new System.Drawing.Point(9, 58);
            this.cbxMngrSelectedUser.Name = "cbxMngrSelectedUser";
            this.cbxMngrSelectedUser.Size = new System.Drawing.Size(198, 28);
            this.cbxMngrSelectedUser.TabIndex = 12;
            this.cbxMngrSelectedUser.ValueMember = "userID";
            this.cbxMngrSelectedUser.SelectionChangeCommitted += new System.EventHandler(this.cbxMngrSelectedUser_SelectionChangeCommitted);
            // 
            // tblEPOSUsersBindingSource
            // 
            this.tblEPOSUsersBindingSource.DataMember = "tblEPOSUsers";
            this.tblEPOSUsersBindingSource.DataSource = this.ePOSDBDataSet;
            // 
            // ePOSDBDataSet
            // 
            this.ePOSDBDataSet.DataSetName = "EPOSDBDataSet";
            this.ePOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddShift
            // 
            this.btnAddShift.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAddShift.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnAddShift.ForeColor = System.Drawing.Color.White;
            this.btnAddShift.Location = new System.Drawing.Point(249, 3);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(198, 75);
            this.btnAddShift.TabIndex = 11;
            this.btnAddShift.Text = "Add Shift";
            this.btnAddShift.UseVisualStyleBackColor = false;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // btnDeleteShift
            // 
            this.btnDeleteShift.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDeleteShift.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnDeleteShift.ForeColor = System.Drawing.Color.White;
            this.btnDeleteShift.Location = new System.Drawing.Point(249, 82);
            this.btnDeleteShift.Name = "btnDeleteShift";
            this.btnDeleteShift.Size = new System.Drawing.Size(198, 75);
            this.btnDeleteShift.TabIndex = 10;
            this.btnDeleteShift.Text = "Delete Shift";
            this.btnDeleteShift.UseVisualStyleBackColor = false;
            this.btnDeleteShift.Click += new System.EventHandler(this.btnDeleteShift_Click);
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.Location = new System.Drawing.Point(4, 4);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(201, 30);
            this.lblManager.TabIndex = 0;
            this.lblManager.Text = "Manager Functions:";
            // 
            // tblClockLogTableAdapter
            // 
            this.tblClockLogTableAdapter.ClearBeforeFill = true;
            // 
            // bstblEPOSUsers
            // 
            this.bstblEPOSUsers.DataMember = "tblEPOSUsers";
            this.bstblEPOSUsers.DataSource = this.ePOSDBDataSet;
            // 
            // bstblClockLog
            // 
            this.bstblClockLog.DataMember = "tblClockLog";
            this.bstblClockLog.DataSource = this.ePOSDBDataSet;
            // 
            // tblEPOSUsersTableAdapter
            // 
            this.tblEPOSUsersTableAdapter.ClearBeforeFill = true;
            // 
            // dgvClockDisplay
            // 
            this.dgvClockDisplay.AllowUserToAddRows = false;
            this.dgvClockDisplay.AllowUserToDeleteRows = false;
            this.dgvClockDisplay.AllowUserToResizeColumns = false;
            this.dgvClockDisplay.AllowUserToResizeRows = false;
            this.dgvClockDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClockDisplay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClockDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClockDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClockDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColClockIn,
            this.dgvColClockOut,
            this.dgvColDuration,
            this.dgvColClockNotes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClockDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClockDisplay.Location = new System.Drawing.Point(12, 178);
            this.dgvClockDisplay.MultiSelect = false;
            this.dgvClockDisplay.Name = "dgvClockDisplay";
            this.dgvClockDisplay.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClockDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClockDisplay.RowTemplate.Height = 30;
            this.dgvClockDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClockDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClockDisplay.Size = new System.Drawing.Size(1255, 429);
            this.dgvClockDisplay.TabIndex = 0;
            // 
            // dgvColClockIn
            // 
            this.dgvColClockIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvColClockIn.HeaderText = "Clock In";
            this.dgvColClockIn.Name = "dgvColClockIn";
            this.dgvColClockIn.ReadOnly = true;
            this.dgvColClockIn.Width = 110;
            // 
            // dgvColClockOut
            // 
            this.dgvColClockOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvColClockOut.HeaderText = "Clock Out";
            this.dgvColClockOut.Name = "dgvColClockOut";
            this.dgvColClockOut.ReadOnly = true;
            this.dgvColClockOut.Width = 115;
            // 
            // dgvColDuration
            // 
            this.dgvColDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvColDuration.HeaderText = "Duration";
            this.dgvColDuration.Name = "dgvColDuration";
            this.dgvColDuration.ReadOnly = true;
            this.dgvColDuration.Width = 116;
            // 
            // dgvColClockNotes
            // 
            this.dgvColClockNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColClockNotes.HeaderText = "Notes";
            this.dgvColClockNotes.Name = "dgvColClockNotes";
            this.dgvColClockNotes.ReadOnly = true;
            // 
            // btnClockIn
            // 
            this.btnClockIn.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClockIn.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnClockIn.ForeColor = System.Drawing.Color.White;
            this.btnClockIn.Location = new System.Drawing.Point(3, 3);
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.Size = new System.Drawing.Size(156, 75);
            this.btnClockIn.TabIndex = 7;
            this.btnClockIn.Text = "Clock In";
            this.btnClockIn.UseVisualStyleBackColor = false;
            this.btnClockIn.Click += new System.EventHandler(this.btnClockIn_Click);
            // 
            // btnClockOut
            // 
            this.btnClockOut.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClockOut.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnClockOut.ForeColor = System.Drawing.Color.White;
            this.btnClockOut.Location = new System.Drawing.Point(165, 3);
            this.btnClockOut.Name = "btnClockOut";
            this.btnClockOut.Size = new System.Drawing.Size(156, 75);
            this.btnClockOut.TabIndex = 8;
            this.btnClockOut.Text = "Clock Out";
            this.btnClockOut.UseVisualStyleBackColor = false;
            this.btnClockOut.Click += new System.EventHandler(this.btnClockOut_Click);
            // 
            // pnlStandard
            // 
            this.pnlStandard.Controls.Add(this.btnClockIn);
            this.pnlStandard.Controls.Add(this.btnClockOut);
            this.pnlStandard.Location = new System.Drawing.Point(12, 90);
            this.pnlStandard.Name = "pnlStandard";
            this.pnlStandard.Size = new System.Drawing.Size(324, 82);
            this.pnlStandard.TabIndex = 9;
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1279, 619);
            this.ControlBox = false;
            this.Controls.Add(this.pnlStandard);
            this.Controls.Add(this.dgvClockDisplay);
            this.Controls.Add(this.pnlManager);
            this.Controls.Add(this.lblNameText);
            this.Controls.Add(this.btnHome);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmClock";
            this.Load += new System.EventHandler(this.frmClock_Load);
            this.pnlManager.ResumeLayout(false);
            this.pnlManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEPOSUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblEPOSUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstblClockLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClockDisplay)).EndInit();
            this.pnlStandard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private EPOSDBDataSet ePOSDBDataSet;
        private EPOSDBDataSetTableAdapters.tblClockLogTableAdapter tblClockLogTableAdapter;
        private System.Windows.Forms.BindingSource bstblEPOSUsers;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Panel pnlManager;
        private System.Windows.Forms.BindingSource bstblClockLog;
        private EPOSDBDataSetTableAdapters.tblEPOSUsersTableAdapter tblEPOSUsersTableAdapter;
        private System.Windows.Forms.DataGridView dgvClockDisplay;
        private System.Windows.Forms.Button btnClockIn;
        private System.Windows.Forms.Button btnClockOut;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.Button btnDeleteShift;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Panel pnlStandard;
        private System.Windows.Forms.Label lblSelectedUser;
        private System.Windows.Forms.ComboBox cbxMngrSelectedUser;
        private System.Windows.Forms.BindingSource tblEPOSUsersBindingSource;
        private System.Windows.Forms.Label lblMangrClocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColClockIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColClockOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColClockNotes;
    }
}