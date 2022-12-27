namespace CS3._0Project.Code.Utility.Forms {
    partial class frmMessageBox {
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
            this.btnOk = new System.Windows.Forms.Button();
            this.rtbTextOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(114, 75);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(55, 31);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rtbTextOutput
            // 
            this.rtbTextOutput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtbTextOutput.BackColor = System.Drawing.SystemColors.Control;
            this.rtbTextOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTextOutput.HideSelection = false;
            this.rtbTextOutput.Location = new System.Drawing.Point(12, 12);
            this.rtbTextOutput.Name = "rtbTextOutput";
            this.rtbTextOutput.ReadOnly = true;
            this.rtbTextOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbTextOutput.Size = new System.Drawing.Size(260, 57);
            this.rtbTextOutput.TabIndex = 2;
            this.rtbTextOutput.Text = "";
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.ControlBox = false;
            this.Controls.Add(this.rtbTextOutput);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBox";
            this.Shown += new System.EventHandler(this.frmMessageBox_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RichTextBox rtbTextOutput;
    }
}