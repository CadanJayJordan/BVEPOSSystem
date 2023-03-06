﻿namespace CS3._0Project.Code.Management {
    partial class frmShiftAddDialog {
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
            this.btnAddShift = new System.Windows.Forms.Button();
            this.lblStarttime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblDateDiv1 = new System.Windows.Forms.Label();
            this.lblDateDiv2 = new System.Windows.Forms.Label();
            this.lblDateDiv3 = new System.Windows.Forms.Label();
            this.lblDateDiv4 = new System.Windows.Forms.Label();
            this.txtStartDay = new System.Windows.Forms.TextBox();
            this.txtStartMonth = new System.Windows.Forms.TextBox();
            this.txtStartYear = new System.Windows.Forms.TextBox();
            this.txtEndYear = new System.Windows.Forms.TextBox();
            this.txtEndMonth = new System.Windows.Forms.TextBox();
            this.txtEndDay = new System.Windows.Forms.TextBox();
            this.txtStartMin = new System.Windows.Forms.TextBox();
            this.txtStartHour = new System.Windows.Forms.TextBox();
            this.lblColon1 = new System.Windows.Forms.Label();
            this.txtEndMin = new System.Windows.Forms.TextBox();
            this.txtEndHour = new System.Windows.Forms.TextBox();
            this.lblColon2 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.tblEPOSUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ePOSDBDataSet = new CS3._0Project.EPOSDBDataSet();
            this.ePOSDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEPOSUsersTableAdapter = new CS3._0Project.EPOSDBDataSetTableAdapters.tblEPOSUsersTableAdapter();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblEPOSUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddShift
            // 
            this.btnAddShift.Location = new System.Drawing.Point(365, 194);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(75, 69);
            this.btnAddShift.TabIndex = 0;
            this.btnAddShift.Text = "Add Shift";
            this.btnAddShift.UseVisualStyleBackColor = true;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // lblStarttime
            // 
            this.lblStarttime.AutoSize = true;
            this.lblStarttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblStarttime.Location = new System.Drawing.Point(47, 85);
            this.lblStarttime.Name = "lblStarttime";
            this.lblStarttime.Size = new System.Drawing.Size(93, 22);
            this.lblStarttime.TabIndex = 1;
            this.lblStarttime.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add Shift";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblEndTime.Location = new System.Drawing.Point(301, 85);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(87, 22);
            this.lblEndTime.TabIndex = 3;
            this.lblEndTime.Text = "End Time";
            // 
            // lblDateDiv1
            // 
            this.lblDateDiv1.AutoSize = true;
            this.lblDateDiv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDiv1.Location = new System.Drawing.Point(69, 121);
            this.lblDateDiv1.Name = "lblDateDiv1";
            this.lblDateDiv1.Size = new System.Drawing.Size(15, 24);
            this.lblDateDiv1.TabIndex = 4;
            this.lblDateDiv1.Text = "/";
            // 
            // lblDateDiv2
            // 
            this.lblDateDiv2.AutoSize = true;
            this.lblDateDiv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDiv2.Location = new System.Drawing.Point(125, 121);
            this.lblDateDiv2.Name = "lblDateDiv2";
            this.lblDateDiv2.Size = new System.Drawing.Size(15, 24);
            this.lblDateDiv2.TabIndex = 5;
            this.lblDateDiv2.Text = "/";
            // 
            // lblDateDiv3
            // 
            this.lblDateDiv3.AutoSize = true;
            this.lblDateDiv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDiv3.Location = new System.Drawing.Point(301, 117);
            this.lblDateDiv3.Name = "lblDateDiv3";
            this.lblDateDiv3.Size = new System.Drawing.Size(15, 24);
            this.lblDateDiv3.TabIndex = 6;
            this.lblDateDiv3.Text = "/";
            // 
            // lblDateDiv4
            // 
            this.lblDateDiv4.AutoSize = true;
            this.lblDateDiv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDiv4.Location = new System.Drawing.Point(357, 117);
            this.lblDateDiv4.Name = "lblDateDiv4";
            this.lblDateDiv4.Size = new System.Drawing.Size(15, 24);
            this.lblDateDiv4.TabIndex = 7;
            this.lblDateDiv4.Text = "/";
            // 
            // txtStartDay
            // 
            this.txtStartDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtStartDay.Location = new System.Drawing.Point(35, 118);
            this.txtStartDay.Name = "txtStartDay";
            this.txtStartDay.Size = new System.Drawing.Size(28, 29);
            this.txtStartDay.TabIndex = 8;
            this.txtStartDay.Click += new System.EventHandler(this.txt2Chars_Click);
            this.txtStartDay.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // txtStartMonth
            // 
            this.txtStartMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtStartMonth.Location = new System.Drawing.Point(90, 118);
            this.txtStartMonth.Name = "txtStartMonth";
            this.txtStartMonth.Size = new System.Drawing.Size(28, 29);
            this.txtStartMonth.TabIndex = 9;
            this.txtStartMonth.Click += new System.EventHandler(this.txt2Chars_Click);
            this.txtStartMonth.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // txtStartYear
            // 
            this.txtStartYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtStartYear.Location = new System.Drawing.Point(146, 118);
            this.txtStartYear.Name = "txtStartYear";
            this.txtStartYear.Size = new System.Drawing.Size(46, 29);
            this.txtStartYear.TabIndex = 10;
            this.txtStartYear.Click += new System.EventHandler(this.txt4Chars_Click);
            this.txtStartYear.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // txtEndYear
            // 
            this.txtEndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEndYear.Location = new System.Drawing.Point(378, 116);
            this.txtEndYear.Name = "txtEndYear";
            this.txtEndYear.Size = new System.Drawing.Size(46, 29);
            this.txtEndYear.TabIndex = 13;
            this.txtEndYear.Click += new System.EventHandler(this.txt4Chars_Click);
            this.txtEndYear.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // txtEndMonth
            // 
            this.txtEndMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEndMonth.Location = new System.Drawing.Point(322, 116);
            this.txtEndMonth.Name = "txtEndMonth";
            this.txtEndMonth.Size = new System.Drawing.Size(28, 29);
            this.txtEndMonth.TabIndex = 12;
            this.txtEndMonth.Click += new System.EventHandler(this.txt2Chars_Click);
            this.txtEndMonth.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // txtEndDay
            // 
            this.txtEndDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEndDay.Location = new System.Drawing.Point(267, 116);
            this.txtEndDay.Name = "txtEndDay";
            this.txtEndDay.Size = new System.Drawing.Size(28, 29);
            this.txtEndDay.TabIndex = 11;
            this.txtEndDay.Click += new System.EventHandler(this.txt2Chars_Click);
            this.txtEndDay.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // txtStartMin
            // 
            this.txtStartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtStartMin.Location = new System.Drawing.Point(128, 153);
            this.txtStartMin.Name = "txtStartMin";
            this.txtStartMin.Size = new System.Drawing.Size(28, 29);
            this.txtStartMin.TabIndex = 16;
            this.txtStartMin.Click += new System.EventHandler(this.txt2Chars_Click);
            this.txtStartMin.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // txtStartHour
            // 
            this.txtStartHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtStartHour.Location = new System.Drawing.Point(73, 153);
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(28, 29);
            this.txtStartHour.TabIndex = 15;
            this.txtStartHour.Click += new System.EventHandler(this.txt2Chars_Click);
            this.txtStartHour.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lblColon1
            // 
            this.lblColon1.AutoSize = true;
            this.lblColon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColon1.Location = new System.Drawing.Point(107, 156);
            this.lblColon1.Name = "lblColon1";
            this.lblColon1.Size = new System.Drawing.Size(15, 24);
            this.lblColon1.TabIndex = 14;
            this.lblColon1.Text = ":";
            // 
            // txtEndMin
            // 
            this.txtEndMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEndMin.Location = new System.Drawing.Point(360, 150);
            this.txtEndMin.Name = "txtEndMin";
            this.txtEndMin.Size = new System.Drawing.Size(28, 29);
            this.txtEndMin.TabIndex = 19;
            this.txtEndMin.Click += new System.EventHandler(this.txt2Chars_Click);
            this.txtEndMin.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // txtEndHour
            // 
            this.txtEndHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEndHour.Location = new System.Drawing.Point(305, 150);
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(28, 29);
            this.txtEndHour.TabIndex = 18;
            this.txtEndHour.Click += new System.EventHandler(this.txt2Chars_Click);
            this.txtEndHour.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lblColon2
            // 
            this.lblColon2.AutoSize = true;
            this.lblColon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColon2.Location = new System.Drawing.Point(339, 153);
            this.lblColon2.Name = "lblColon2";
            this.lblColon2.Size = new System.Drawing.Size(15, 24);
            this.lblColon2.TabIndex = 17;
            this.lblColon2.Text = ":";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(5, 241);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(91, 25);
            this.lblDuration.TabIndex = 20;
            this.lblDuration.Text = "Duration:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(284, 194);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 69);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbxUser
            // 
            this.cbxUser.DataSource = this.tblEPOSUsersBindingSource;
            this.cbxUser.DisplayMember = "userName";
            this.cbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(70, 210);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(208, 33);
            this.cbxUser.TabIndex = 22;
            this.cbxUser.ValueMember = "userID";
            this.cbxUser.SelectedIndexChanged += new System.EventHandler(this.cbxUser_SelectedIndexChanged);
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
            // ePOSDBDataSetBindingSource
            // 
            this.ePOSDBDataSetBindingSource.DataSource = this.ePOSDBDataSet;
            this.ePOSDBDataSetBindingSource.Position = 0;
            // 
            // tblEPOSUsersTableAdapter
            // 
            this.tblEPOSUsersTableAdapter.ClearBeforeFill = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(5, 213);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(59, 25);
            this.lblUser.TabIndex = 23;
            this.lblUser.Text = "User:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(373, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 69);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShiftAddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 275);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cbxUser);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.txtEndMin);
            this.Controls.Add(this.txtEndHour);
            this.Controls.Add(this.lblColon2);
            this.Controls.Add(this.txtStartMin);
            this.Controls.Add(this.txtStartHour);
            this.Controls.Add(this.lblColon1);
            this.Controls.Add(this.txtEndYear);
            this.Controls.Add(this.txtEndMonth);
            this.Controls.Add(this.txtEndDay);
            this.Controls.Add(this.txtStartYear);
            this.Controls.Add(this.txtStartMonth);
            this.Controls.Add(this.txtStartDay);
            this.Controls.Add(this.lblDateDiv4);
            this.Controls.Add(this.lblDateDiv3);
            this.Controls.Add(this.lblDateDiv2);
            this.Controls.Add(this.lblDateDiv1);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStarttime);
            this.Controls.Add(this.btnAddShift);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShiftAddDialog";
            this.ShowInTaskbar = false;
            this.Text = "frmShiftAddDialog";
            this.Load += new System.EventHandler(this.frmShiftAddDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblEPOSUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePOSDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.Label lblStarttime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblDateDiv1;
        private System.Windows.Forms.Label lblDateDiv2;
        private System.Windows.Forms.Label lblDateDiv3;
        private System.Windows.Forms.Label lblDateDiv4;
        private System.Windows.Forms.TextBox txtStartDay;
        private System.Windows.Forms.TextBox txtStartMonth;
        private System.Windows.Forms.TextBox txtStartYear;
        private System.Windows.Forms.TextBox txtEndYear;
        private System.Windows.Forms.TextBox txtEndMonth;
        private System.Windows.Forms.TextBox txtEndDay;
        private System.Windows.Forms.TextBox txtStartMin;
        private System.Windows.Forms.TextBox txtStartHour;
        private System.Windows.Forms.Label lblColon1;
        private System.Windows.Forms.TextBox txtEndMin;
        private System.Windows.Forms.TextBox txtEndHour;
        private System.Windows.Forms.Label lblColon2;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.BindingSource ePOSDBDataSetBindingSource;
        private EPOSDBDataSet ePOSDBDataSet;
        private System.Windows.Forms.BindingSource tblEPOSUsersBindingSource;
        private EPOSDBDataSetTableAdapters.tblEPOSUsersTableAdapter tblEPOSUsersTableAdapter;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnClose;
    }
}