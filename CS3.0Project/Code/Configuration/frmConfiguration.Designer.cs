namespace CS3._0Project.Code.Configuration {
    partial class frmConfiguration {
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cbxBillPrinter = new System.Windows.Forms.ComboBox();
            this.lblBillPrinter = new System.Windows.Forms.Label();
            this.cbxKitchenPrinter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1228, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // cbxBillPrinter
            // 
            this.cbxBillPrinter.DisplayMember = "eposDepartmentName";
            this.cbxBillPrinter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBillPrinter.FormattingEnabled = true;
            this.cbxBillPrinter.Location = new System.Drawing.Point(176, 51);
            this.cbxBillPrinter.Name = "cbxBillPrinter";
            this.cbxBillPrinter.Size = new System.Drawing.Size(317, 33);
            this.cbxBillPrinter.TabIndex = 12;
            this.cbxBillPrinter.ValueMember = "eposItemDepartmentID";
            this.cbxBillPrinter.SelectedIndexChanged += new System.EventHandler(this.cbxBillPrinter_SelectedIndexChanged);
            // 
            // lblBillPrinter
            // 
            this.lblBillPrinter.AutoSize = true;
            this.lblBillPrinter.BackColor = System.Drawing.Color.Transparent;
            this.lblBillPrinter.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillPrinter.ForeColor = System.Drawing.Color.Black;
            this.lblBillPrinter.Location = new System.Drawing.Point(12, 50);
            this.lblBillPrinter.Name = "lblBillPrinter";
            this.lblBillPrinter.Size = new System.Drawing.Size(158, 30);
            this.lblBillPrinter.TabIndex = 11;
            this.lblBillPrinter.Text = "Bill/Bar Printer:";
            // 
            // cbxKitchenPrinter
            // 
            this.cbxKitchenPrinter.DisplayMember = "eposDepartmentName";
            this.cbxKitchenPrinter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKitchenPrinter.FormattingEnabled = true;
            this.cbxKitchenPrinter.Location = new System.Drawing.Point(176, 88);
            this.cbxKitchenPrinter.Name = "cbxKitchenPrinter";
            this.cbxKitchenPrinter.Size = new System.Drawing.Size(317, 33);
            this.cbxKitchenPrinter.TabIndex = 14;
            this.cbxKitchenPrinter.ValueMember = "eposItemDepartmentID";
            this.cbxKitchenPrinter.SelectedIndexChanged += new System.EventHandler(this.cbxKitchenPrinter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kitchen Printer:";
            // 
            // frmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.BackgroundImage = global::CS3._0Project.Properties.Resources.BVIcon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1340, 682);
            this.ControlBox = false;
            this.Controls.Add(this.cbxKitchenPrinter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxBillPrinter);
            this.Controls.Add(this.lblBillPrinter);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguration";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.frmConfiguration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cbxBillPrinter;
        private System.Windows.Forms.Label lblBillPrinter;
        private System.Windows.Forms.ComboBox cbxKitchenPrinter;
        private System.Windows.Forms.Label label1;
    }
}