namespace RaptorMath
{
    partial class Login
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
            this.StudentNameCmbo = new System.Windows.Forms.ComboBox();
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.linkAdminLogin = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentNameCmbo
            // 
            this.StudentNameCmbo.FormattingEnabled = true;
            this.StudentNameCmbo.Items.AddRange(new object[] {
            "Select Your Name"});
            this.StudentNameCmbo.Location = new System.Drawing.Point(303, 191);
            this.StudentNameCmbo.Name = "StudentNameCmbo";
            this.StudentNameCmbo.Size = new System.Drawing.Size(151, 21);
            this.StudentNameCmbo.TabIndex = 1;
            this.StudentNameCmbo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.Location = new System.Drawing.Point(282, 249);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(188, 46);
            this.StartGameBtn.TabIndex = 2;
            this.StartGameBtn.Text = "Start Game";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkAdminLogin
            // 
            this.linkAdminLogin.AutoSize = true;
            this.linkAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.linkAdminLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkAdminLogin.Location = new System.Drawing.Point(648, 392);
            this.linkAdminLogin.Name = "linkAdminLogin";
            this.linkAdminLogin.Size = new System.Drawing.Size(79, 13);
            this.linkAdminLogin.TabIndex = 4;
            this.linkAdminLogin.TabStop = true;
            this.linkAdminLogin.Text = "Login as Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matisse ITC", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 82);
            this.label1.TabIndex = 5;
            this.label1.Text = "RaptorMath";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkAdminLogin);
            this.Controls.Add(this.StartGameBtn);
            this.Controls.Add(this.StudentNameCmbo);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StudentNameCmbo;
        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.LinkLabel linkAdminLogin;
        private System.Windows.Forms.Label label1;
    }
}