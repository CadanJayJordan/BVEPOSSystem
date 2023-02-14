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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1165, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEditTablePlan
            // 
            this.btnEditTablePlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEditTablePlan.ForeColor = System.Drawing.Color.White;
            this.btnEditTablePlan.Location = new System.Drawing.Point(12, 110);
            this.btnEditTablePlan.Name = "btnEditTablePlan";
            this.btnEditTablePlan.Size = new System.Drawing.Size(133, 129);
            this.btnEditTablePlan.TabIndex = 1;
            this.btnEditTablePlan.Text = "Edit Table Plan";
            this.btnEditTablePlan.UseVisualStyleBackColor = false;
            this.btnEditTablePlan.Click += new System.EventHandler(this.btnEditTablePlan_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(5, 6);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(246, 41);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome: {0}";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(151, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 129);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit Items";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmManagementFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1252, 667);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnEditTablePlan);
            this.Controls.Add(this.btnClose);
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
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button button1;
    }
}