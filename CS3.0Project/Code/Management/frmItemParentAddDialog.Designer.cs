namespace CS3._0Project.Code.Management {
    partial class frmItemParentAddDialog {
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
            this.clbSelectedParents = new System.Windows.Forms.CheckedListBox();
            this.cbRootSelected = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbSelectedParents
            // 
            this.clbSelectedParents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbSelectedParents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.clbSelectedParents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbSelectedParents.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold);
            this.clbSelectedParents.ForeColor = System.Drawing.Color.White;
            this.clbSelectedParents.FormattingEnabled = true;
            this.clbSelectedParents.Location = new System.Drawing.Point(1, 36);
            this.clbSelectedParents.Name = "clbSelectedParents";
            this.clbSelectedParents.Size = new System.Drawing.Size(351, 540);
            this.clbSelectedParents.TabIndex = 0;
            // 
            // cbRootSelected
            // 
            this.cbRootSelected.AutoSize = true;
            this.cbRootSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold);
            this.cbRootSelected.ForeColor = System.Drawing.Color.White;
            this.cbRootSelected.Location = new System.Drawing.Point(1, 0);
            this.cbRootSelected.Name = "cbRootSelected";
            this.cbRootSelected.Size = new System.Drawing.Size(88, 39);
            this.cbRootSelected.TabIndex = 1;
            this.cbRootSelected.Text = "Root";
            this.cbRootSelected.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 16.75F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(113, 602);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 57);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmItemParentAddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(355, 671);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbRootSelected);
            this.Controls.Add(this.clbSelectedParents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmItemParentAddDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmItemParentAddDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbSelectedParents;
        private System.Windows.Forms.CheckBox cbRootSelected;
        private System.Windows.Forms.Button btnOk;
    }
}