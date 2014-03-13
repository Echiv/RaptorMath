namespace RaptorMath
{
    partial class UseDesg_Form
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
            this.components = new System.ComponentModel.Container();
            this.UseDesg_DateLbl = new System.Windows.Forms.Label();
            this.UseDesg_ExitBtn = new System.Windows.Forms.Button();
            this.UseDesg_Timer = new System.Windows.Forms.Timer(this.components);
            this.UseDesg_LoginDdl = new System.Windows.Forms.ComboBox();
            this.UseDesg_LoginBox = new System.Windows.Forms.GroupBox();
            this.UseDesg_LoginBtn = new System.Windows.Forms.Button();
            this.UseDesg_TimeLbl = new System.Windows.Forms.Label();
            this.UseDesg_WindowLbl = new System.Windows.Forms.Label();
            this.UseDesg_ButtonBox = new System.Windows.Forms.GroupBox();
            this.UseDesg_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.UseDesg_passwordBox = new System.Windows.Forms.TextBox();
            this.UseDesg_LoginBox.SuspendLayout();
            this.UseDesg_ButtonBox.SuspendLayout();
            this.UseDesg_UserInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UseDesg_DateLbl
            // 
            this.UseDesg_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseDesg_DateLbl.AutoSize = true;
            this.UseDesg_DateLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesg_DateLbl.Location = new System.Drawing.Point(293, 11);
            this.UseDesg_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UseDesg_DateLbl.Name = "UseDesg_DateLbl";
            this.UseDesg_DateLbl.Size = new System.Drawing.Size(74, 26);
            this.UseDesg_DateLbl.TabIndex = 9;
            this.UseDesg_DateLbl.Text = "<Date>";
            // 
            // UseDesg_ExitBtn
            // 
            this.UseDesg_ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UseDesg_ExitBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesg_ExitBtn.Location = new System.Drawing.Point(292, 17);
            this.UseDesg_ExitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UseDesg_ExitBtn.Name = "UseDesg_ExitBtn";
            this.UseDesg_ExitBtn.Size = new System.Drawing.Size(108, 38);
            this.UseDesg_ExitBtn.TabIndex = 3;
            this.UseDesg_ExitBtn.Text = "Exit";
            this.UseDesg_ExitBtn.UseVisualStyleBackColor = true;
            this.UseDesg_ExitBtn.Click += new System.EventHandler(this.UseDesg_ExitBtn_Click);
            // 
            // UseDesg_Timer
            // 
            this.UseDesg_Timer.Enabled = true;
            this.UseDesg_Timer.Interval = 1000;
            this.UseDesg_Timer.Tick += new System.EventHandler(this.UseDesg_Timer_Tick);
            // 
            // UseDesg_LoginDdl
            // 
            this.UseDesg_LoginDdl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UseDesg_LoginDdl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesg_LoginDdl.FormattingEnabled = true;
            this.UseDesg_LoginDdl.Location = new System.Drawing.Point(47, 32);
            this.UseDesg_LoginDdl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UseDesg_LoginDdl.Name = "UseDesg_LoginDdl";
            this.UseDesg_LoginDdl.Size = new System.Drawing.Size(309, 34);
            this.UseDesg_LoginDdl.TabIndex = 1;
            this.UseDesg_LoginDdl.SelectionChangeCommitted += new System.EventHandler(this.UseDesg_LoginDdl_SelectionChangeCommitted);
            // 
            // UseDesg_LoginBox
            // 
            this.UseDesg_LoginBox.Controls.Add(this.UseDesg_passwordBox);
            this.UseDesg_LoginBox.Controls.Add(this.UseDesg_LoginBtn);
            this.UseDesg_LoginBox.Controls.Add(this.UseDesg_LoginDdl);
            this.UseDesg_LoginBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesg_LoginBox.Location = new System.Drawing.Point(16, 80);
            this.UseDesg_LoginBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UseDesg_LoginBox.Name = "UseDesg_LoginBox";
            this.UseDesg_LoginBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UseDesg_LoginBox.Size = new System.Drawing.Size(413, 165);
            this.UseDesg_LoginBox.TabIndex = 10;
            this.UseDesg_LoginBox.TabStop = false;
            this.UseDesg_LoginBox.Text = "Select a User";
            // 
            // UseDesg_LoginBtn
            // 
            this.UseDesg_LoginBtn.Enabled = false;
            this.UseDesg_LoginBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesg_LoginBtn.Location = new System.Drawing.Point(47, 111);
            this.UseDesg_LoginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UseDesg_LoginBtn.Name = "UseDesg_LoginBtn";
            this.UseDesg_LoginBtn.Size = new System.Drawing.Size(311, 38);
            this.UseDesg_LoginBtn.TabIndex = 2;
            this.UseDesg_LoginBtn.Text = "Login";
            this.UseDesg_LoginBtn.UseVisualStyleBackColor = true;
            this.UseDesg_LoginBtn.Click += new System.EventHandler(this.UseDesg_LoginBtn_Click);
            // 
            // UseDesg_TimeLbl
            // 
            this.UseDesg_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseDesg_TimeLbl.AutoSize = true;
            this.UseDesg_TimeLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesg_TimeLbl.Location = new System.Drawing.Point(293, 43);
            this.UseDesg_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UseDesg_TimeLbl.Name = "UseDesg_TimeLbl";
            this.UseDesg_TimeLbl.Size = new System.Drawing.Size(78, 26);
            this.UseDesg_TimeLbl.TabIndex = 11;
            this.UseDesg_TimeLbl.Text = "<Time>";
            // 
            // UseDesg_WindowLbl
            // 
            this.UseDesg_WindowLbl.AutoSize = true;
            this.UseDesg_WindowLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesg_WindowLbl.Location = new System.Drawing.Point(8, 10);
            this.UseDesg_WindowLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UseDesg_WindowLbl.Name = "UseDesg_WindowLbl";
            this.UseDesg_WindowLbl.Size = new System.Drawing.Size(112, 26);
            this.UseDesg_WindowLbl.TabIndex = 15;
            this.UseDesg_WindowLbl.Text = "User Login";
            // 
            // UseDesg_ButtonBox
            // 
            this.UseDesg_ButtonBox.Controls.Add(this.UseDesg_ExitBtn);
            this.UseDesg_ButtonBox.Location = new System.Drawing.Point(16, 252);
            this.UseDesg_ButtonBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UseDesg_ButtonBox.Name = "UseDesg_ButtonBox";
            this.UseDesg_ButtonBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UseDesg_ButtonBox.Size = new System.Drawing.Size(413, 66);
            this.UseDesg_ButtonBox.TabIndex = 16;
            this.UseDesg_ButtonBox.TabStop = false;
            // 
            // UseDesg_UserInfoBox
            // 
            this.UseDesg_UserInfoBox.Controls.Add(this.UseDesg_WindowLbl);
            this.UseDesg_UserInfoBox.Controls.Add(this.UseDesg_DateLbl);
            this.UseDesg_UserInfoBox.Controls.Add(this.UseDesg_TimeLbl);
            this.UseDesg_UserInfoBox.Location = new System.Drawing.Point(16, 4);
            this.UseDesg_UserInfoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UseDesg_UserInfoBox.Name = "UseDesg_UserInfoBox";
            this.UseDesg_UserInfoBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UseDesg_UserInfoBox.Size = new System.Drawing.Size(413, 81);
            this.UseDesg_UserInfoBox.TabIndex = 17;
            this.UseDesg_UserInfoBox.TabStop = false;
            // 
            // UseDesg_passwordBox
            // 
            this.UseDesg_passwordBox.Location = new System.Drawing.Point(47, 73);
            this.UseDesg_passwordBox.Name = "UseDesg_passwordBox";
            this.UseDesg_passwordBox.Size = new System.Drawing.Size(309, 31);
            this.UseDesg_passwordBox.TabIndex = 3;
            this.UseDesg_passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // UseDesg_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 322);
            this.ControlBox = false;
            this.Controls.Add(this.UseDesg_UserInfoBox);
            this.Controls.Add(this.UseDesg_ButtonBox);
            this.Controls.Add(this.UseDesg_LoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UseDesg_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.UseDesg_LoginBox.ResumeLayout(false);
            this.UseDesg_LoginBox.PerformLayout();
            this.UseDesg_ButtonBox.ResumeLayout(false);
            this.UseDesg_UserInfoBox.ResumeLayout(false);
            this.UseDesg_UserInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UseDesg_DateLbl;
        private System.Windows.Forms.Button UseDesg_ExitBtn;
        private System.Windows.Forms.Timer UseDesg_Timer;
        private System.Windows.Forms.ComboBox UseDesg_LoginDdl;
        private System.Windows.Forms.GroupBox UseDesg_LoginBox;
        private System.Windows.Forms.Button UseDesg_LoginBtn;
        private System.Windows.Forms.Label UseDesg_TimeLbl;
        private System.Windows.Forms.Label UseDesg_WindowLbl;
        private System.Windows.Forms.GroupBox UseDesg_ButtonBox;
        private System.Windows.Forms.GroupBox UseDesg_UserInfoBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox UseDesg_passwordBox;

    }
}

