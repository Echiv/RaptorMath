namespace RaptorMath
{
    partial class CustomMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.MessageLbl = new System.Windows.Forms.Label();
            this.OkayBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageLbl
            // 
            this.MessageLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.Location = new System.Drawing.Point(12, 108);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(35, 13);
            this.MessageLbl.TabIndex = 0;
            this.MessageLbl.Text = "label1";
            // 
            // OkayBtn
            // 
            this.OkayBtn.BackColor = System.Drawing.Color.Snow;
            this.OkayBtn.Location = new System.Drawing.Point(87, 163);
            this.OkayBtn.Name = "OkayBtn";
            this.OkayBtn.Size = new System.Drawing.Size(100, 50);
            this.OkayBtn.TabIndex = 1;
            this.OkayBtn.Text = "Okay";
            this.OkayBtn.UseVisualStyleBackColor = false;
            this.OkayBtn.Click += new System.EventHandler(this.OkayBtn_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.OkayBtn);
            this.Controls.Add(this.MessageLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLbl;
        private System.Windows.Forms.Button OkayBtn;
    }
}