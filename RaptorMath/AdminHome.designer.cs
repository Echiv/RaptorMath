namespace RaptorMath
{
    partial class AdminHome_Form
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
            this.AdminHome_Timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AdminHome_SaveBtn = new System.Windows.Forms.Button();
            this.AdminHome_NewPWLbl = new System.Windows.Forms.Label();
            this.AdminHome_CurrentPWLbl = new System.Windows.Forms.Label();
            this.AdminHome_CurrentPWTxt = new System.Windows.Forms.RichTextBox();
            this.AdminHome_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.AdminHome_DateLbl = new System.Windows.Forms.Label();
            this.AdminHome_LastLoginLbl = new System.Windows.Forms.Label();
            this.AdminHome_WelcomeLbl = new System.Windows.Forms.Label();
            this.AdminHome_LoginLbl = new System.Windows.Forms.Label();
            this.AdminHome_AdminNameLbl = new System.Windows.Forms.Label();
            this.AdminHome_TimeLbl = new System.Windows.Forms.Label();
            this.AdminHome_PasswordBox = new System.Windows.Forms.GroupBox();
            this.AdminHome_NewPWTxt = new System.Windows.Forms.RichTextBox();
            this.AdminHome_WindowLbl = new System.Windows.Forms.Label();
            this.AdminHome_MngUsersBtn = new System.Windows.Forms.Button();
            this.AdminHome_MngGroupsBtn = new System.Windows.Forms.Button();
            this.AdminHome_UserBox = new System.Windows.Forms.GroupBox();
            this.AdminHome_StuReportBtn = new System.Windows.Forms.Button();
            this.AdminHome_EditStudentBtn = new System.Windows.Forms.Button();
            this.AdminHome_CreateDrillBtn = new System.Windows.Forms.Button();
            this.AdminHome_MngDrillBtn = new System.Windows.Forms.Button();
            this.AdminHome_DrillBox = new System.Windows.Forms.GroupBox();
            this.AdminHome_AdminBox = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AdminHome_LogoutBtn = new System.Windows.Forms.Button();
            this.AdminHome_ExitBtn = new System.Windows.Forms.Button();
            this.AdminHome_ButtonBox = new System.Windows.Forms.GroupBox();
            this.AdminHome_UserInfoBox.SuspendLayout();
            this.AdminHome_PasswordBox.SuspendLayout();
            this.AdminHome_UserBox.SuspendLayout();
            this.AdminHome_DrillBox.SuspendLayout();
            this.AdminHome_AdminBox.SuspendLayout();
            this.AdminHome_ButtonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminHome_Timer
            // 
            this.AdminHome_Timer.Enabled = true;
            this.AdminHome_Timer.Interval = 1000;
            this.AdminHome_Timer.Tick += new System.EventHandler(this.AdminHome_Timer_Tick);
            // 
            // AdminHome_SaveBtn
            // 
            this.AdminHome_SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminHome_SaveBtn.Enabled = false;
            this.AdminHome_SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_SaveBtn.Location = new System.Drawing.Point(135, 94);
            this.AdminHome_SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AdminHome_SaveBtn.Name = "AdminHome_SaveBtn";
            this.AdminHome_SaveBtn.Size = new System.Drawing.Size(116, 27);
            this.AdminHome_SaveBtn.TabIndex = 39;
            this.AdminHome_SaveBtn.Text = "Save";
            this.AdminHome_SaveBtn.UseVisualStyleBackColor = true;
            // 
            // AdminHome_NewPWLbl
            // 
            this.AdminHome_NewPWLbl.AutoSize = true;
            this.AdminHome_NewPWLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_NewPWLbl.Location = new System.Drawing.Point(32, 65);
            this.AdminHome_NewPWLbl.Name = "AdminHome_NewPWLbl";
            this.AdminHome_NewPWLbl.Size = new System.Drawing.Size(78, 13);
            this.AdminHome_NewPWLbl.TabIndex = 2;
            this.AdminHome_NewPWLbl.Text = "New Password";
            // 
            // AdminHome_CurrentPWLbl
            // 
            this.AdminHome_CurrentPWLbl.AutoSize = true;
            this.AdminHome_CurrentPWLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_CurrentPWLbl.Location = new System.Drawing.Point(22, 35);
            this.AdminHome_CurrentPWLbl.Name = "AdminHome_CurrentPWLbl";
            this.AdminHome_CurrentPWLbl.Size = new System.Drawing.Size(90, 13);
            this.AdminHome_CurrentPWLbl.TabIndex = 1;
            this.AdminHome_CurrentPWLbl.Text = "Current Password";
            // 
            // AdminHome_CurrentPWTxt
            // 
            this.AdminHome_CurrentPWTxt.Location = new System.Drawing.Point(121, 29);
            this.AdminHome_CurrentPWTxt.Name = "AdminHome_CurrentPWTxt";
            this.AdminHome_CurrentPWTxt.Size = new System.Drawing.Size(168, 27);
            this.AdminHome_CurrentPWTxt.TabIndex = 0;
            this.AdminHome_CurrentPWTxt.Text = "";
            // 
            // AdminHome_UserInfoBox
            // 
            this.AdminHome_UserInfoBox.Controls.Add(this.AdminHome_DateLbl);
            this.AdminHome_UserInfoBox.Controls.Add(this.AdminHome_LastLoginLbl);
            this.AdminHome_UserInfoBox.Controls.Add(this.AdminHome_WelcomeLbl);
            this.AdminHome_UserInfoBox.Controls.Add(this.AdminHome_LoginLbl);
            this.AdminHome_UserInfoBox.Controls.Add(this.AdminHome_AdminNameLbl);
            this.AdminHome_UserInfoBox.Controls.Add(this.AdminHome_TimeLbl);
            this.AdminHome_UserInfoBox.Location = new System.Drawing.Point(6, 26);
            this.AdminHome_UserInfoBox.Name = "AdminHome_UserInfoBox";
            this.AdminHome_UserInfoBox.Size = new System.Drawing.Size(410, 58);
            this.AdminHome_UserInfoBox.TabIndex = 39;
            this.AdminHome_UserInfoBox.TabStop = false;
            // 
            // AdminHome_DateLbl
            // 
            this.AdminHome_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminHome_DateLbl.AutoSize = true;
            this.AdminHome_DateLbl.Location = new System.Drawing.Point(354, 15);
            this.AdminHome_DateLbl.Name = "AdminHome_DateLbl";
            this.AdminHome_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.AdminHome_DateLbl.TabIndex = 31;
            this.AdminHome_DateLbl.Text = "<Date>";
            // 
            // AdminHome_LastLoginLbl
            // 
            this.AdminHome_LastLoginLbl.AutoSize = true;
            this.AdminHome_LastLoginLbl.Location = new System.Drawing.Point(9, 38);
            this.AdminHome_LastLoginLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdminHome_LastLoginLbl.Name = "AdminHome_LastLoginLbl";
            this.AdminHome_LastLoginLbl.Size = new System.Drawing.Size(59, 13);
            this.AdminHome_LastLoginLbl.TabIndex = 16;
            this.AdminHome_LastLoginLbl.Text = "Last Login:";
            // 
            // AdminHome_WelcomeLbl
            // 
            this.AdminHome_WelcomeLbl.AutoSize = true;
            this.AdminHome_WelcomeLbl.Location = new System.Drawing.Point(9, 16);
            this.AdminHome_WelcomeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdminHome_WelcomeLbl.Name = "AdminHome_WelcomeLbl";
            this.AdminHome_WelcomeLbl.Size = new System.Drawing.Size(55, 13);
            this.AdminHome_WelcomeLbl.TabIndex = 27;
            this.AdminHome_WelcomeLbl.Text = "Welcome,";
            // 
            // AdminHome_LoginLbl
            // 
            this.AdminHome_LoginLbl.AutoSize = true;
            this.AdminHome_LoginLbl.Location = new System.Drawing.Point(73, 38);
            this.AdminHome_LoginLbl.Name = "AdminHome_LoginLbl";
            this.AdminHome_LoginLbl.Size = new System.Drawing.Size(42, 13);
            this.AdminHome_LoginLbl.TabIndex = 29;
            this.AdminHome_LoginLbl.Text = "<Date>";
            // 
            // AdminHome_AdminNameLbl
            // 
            this.AdminHome_AdminNameLbl.AutoSize = true;
            this.AdminHome_AdminNameLbl.Location = new System.Drawing.Point(74, 16);
            this.AdminHome_AdminNameLbl.Name = "AdminHome_AdminNameLbl";
            this.AdminHome_AdminNameLbl.Size = new System.Drawing.Size(48, 13);
            this.AdminHome_AdminNameLbl.TabIndex = 28;
            this.AdminHome_AdminNameLbl.Text = "<Admin>";
            // 
            // AdminHome_TimeLbl
            // 
            this.AdminHome_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminHome_TimeLbl.AutoSize = true;
            this.AdminHome_TimeLbl.Location = new System.Drawing.Point(354, 38);
            this.AdminHome_TimeLbl.Name = "AdminHome_TimeLbl";
            this.AdminHome_TimeLbl.Size = new System.Drawing.Size(42, 13);
            this.AdminHome_TimeLbl.TabIndex = 17;
            this.AdminHome_TimeLbl.Text = "<Time>";
            // 
            // AdminHome_PasswordBox
            // 
            this.AdminHome_PasswordBox.Controls.Add(this.AdminHome_SaveBtn);
            this.AdminHome_PasswordBox.Controls.Add(this.AdminHome_NewPWLbl);
            this.AdminHome_PasswordBox.Controls.Add(this.AdminHome_CurrentPWLbl);
            this.AdminHome_PasswordBox.Controls.Add(this.AdminHome_NewPWTxt);
            this.AdminHome_PasswordBox.Controls.Add(this.AdminHome_CurrentPWTxt);
            this.AdminHome_PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_PasswordBox.Location = new System.Drawing.Point(7, 92);
            this.AdminHome_PasswordBox.Name = "AdminHome_PasswordBox";
            this.AdminHome_PasswordBox.Size = new System.Drawing.Size(409, 139);
            this.AdminHome_PasswordBox.TabIndex = 41;
            this.AdminHome_PasswordBox.TabStop = false;
            this.AdminHome_PasswordBox.Text = "Change Password";
            // 
            // AdminHome_NewPWTxt
            // 
            this.AdminHome_NewPWTxt.Location = new System.Drawing.Point(121, 62);
            this.AdminHome_NewPWTxt.Name = "AdminHome_NewPWTxt";
            this.AdminHome_NewPWTxt.Size = new System.Drawing.Size(168, 27);
            this.AdminHome_NewPWTxt.TabIndex = 0;
            this.AdminHome_NewPWTxt.Text = "";
            // 
            // AdminHome_WindowLbl
            // 
            this.AdminHome_WindowLbl.AutoSize = true;
            this.AdminHome_WindowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_WindowLbl.Location = new System.Drawing.Point(181, 9);
            this.AdminHome_WindowLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdminHome_WindowLbl.Name = "AdminHome_WindowLbl";
            this.AdminHome_WindowLbl.Size = new System.Drawing.Size(77, 13);
            this.AdminHome_WindowLbl.TabIndex = 37;
            this.AdminHome_WindowLbl.Text = "Admin Home";
            // 
            // AdminHome_MngUsersBtn
            // 
            this.AdminHome_MngUsersBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminHome_MngUsersBtn.Enabled = false;
            this.AdminHome_MngUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_MngUsersBtn.Location = new System.Drawing.Point(36, 29);
            this.AdminHome_MngUsersBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AdminHome_MngUsersBtn.Name = "AdminHome_MngUsersBtn";
            this.AdminHome_MngUsersBtn.Size = new System.Drawing.Size(116, 25);
            this.AdminHome_MngUsersBtn.TabIndex = 37;
            this.AdminHome_MngUsersBtn.Text = "Manage Users";
            this.AdminHome_MngUsersBtn.UseVisualStyleBackColor = true;
            // 
            // AdminHome_MngGroupsBtn
            // 
            this.AdminHome_MngGroupsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminHome_MngGroupsBtn.Enabled = false;
            this.AdminHome_MngGroupsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_MngGroupsBtn.Location = new System.Drawing.Point(36, 58);
            this.AdminHome_MngGroupsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AdminHome_MngGroupsBtn.Name = "AdminHome_MngGroupsBtn";
            this.AdminHome_MngGroupsBtn.Size = new System.Drawing.Size(116, 25);
            this.AdminHome_MngGroupsBtn.TabIndex = 43;
            this.AdminHome_MngGroupsBtn.Text = "Manage Groups";
            this.AdminHome_MngGroupsBtn.UseVisualStyleBackColor = true;
            // 
            // AdminHome_UserBox
            // 
            this.AdminHome_UserBox.Controls.Add(this.AdminHome_MngUsersBtn);
            this.AdminHome_UserBox.Controls.Add(this.AdminHome_MngGroupsBtn);
            this.AdminHome_UserBox.Controls.Add(this.AdminHome_StuReportBtn);
            this.AdminHome_UserBox.Controls.Add(this.AdminHome_EditStudentBtn);
            this.AdminHome_UserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_UserBox.Location = new System.Drawing.Point(8, 19);
            this.AdminHome_UserBox.Name = "AdminHome_UserBox";
            this.AdminHome_UserBox.Size = new System.Drawing.Size(193, 169);
            this.AdminHome_UserBox.TabIndex = 45;
            this.AdminHome_UserBox.TabStop = false;
            this.AdminHome_UserBox.Text = "User Controls";
            // 
            // AdminHome_StuReportBtn
            // 
            this.AdminHome_StuReportBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminHome_StuReportBtn.Enabled = false;
            this.AdminHome_StuReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_StuReportBtn.Location = new System.Drawing.Point(36, 87);
            this.AdminHome_StuReportBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AdminHome_StuReportBtn.Name = "AdminHome_StuReportBtn";
            this.AdminHome_StuReportBtn.Size = new System.Drawing.Size(116, 25);
            this.AdminHome_StuReportBtn.TabIndex = 19;
            this.AdminHome_StuReportBtn.Text = "Student Reports";
            this.AdminHome_StuReportBtn.UseVisualStyleBackColor = true;
            // 
            // AdminHome_EditStudentBtn
            // 
            this.AdminHome_EditStudentBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminHome_EditStudentBtn.Enabled = false;
            this.AdminHome_EditStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_EditStudentBtn.Location = new System.Drawing.Point(36, 116);
            this.AdminHome_EditStudentBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AdminHome_EditStudentBtn.Name = "AdminHome_EditStudentBtn";
            this.AdminHome_EditStudentBtn.Size = new System.Drawing.Size(116, 25);
            this.AdminHome_EditStudentBtn.TabIndex = 39;
            this.AdminHome_EditStudentBtn.Text = "Edit Students";
            this.AdminHome_EditStudentBtn.UseVisualStyleBackColor = true;
            // 
            // AdminHome_CreateDrillBtn
            // 
            this.AdminHome_CreateDrillBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AdminHome_CreateDrillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_CreateDrillBtn.Location = new System.Drawing.Point(27, 23);
            this.AdminHome_CreateDrillBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AdminHome_CreateDrillBtn.Name = "AdminHome_CreateDrillBtn";
            this.AdminHome_CreateDrillBtn.Size = new System.Drawing.Size(116, 25);
            this.AdminHome_CreateDrillBtn.TabIndex = 41;
            this.AdminHome_CreateDrillBtn.Text = "Create Drill";
            this.AdminHome_CreateDrillBtn.UseVisualStyleBackColor = true;
            // 
            // AdminHome_MngDrillBtn
            // 
            this.AdminHome_MngDrillBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AdminHome_MngDrillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_MngDrillBtn.Location = new System.Drawing.Point(27, 52);
            this.AdminHome_MngDrillBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AdminHome_MngDrillBtn.Name = "AdminHome_MngDrillBtn";
            this.AdminHome_MngDrillBtn.Size = new System.Drawing.Size(116, 25);
            this.AdminHome_MngDrillBtn.TabIndex = 42;
            this.AdminHome_MngDrillBtn.Text = "Manage Drills";
            this.AdminHome_MngDrillBtn.UseVisualStyleBackColor = true;
            // 
            // AdminHome_DrillBox
            // 
            this.AdminHome_DrillBox.Controls.Add(this.AdminHome_CreateDrillBtn);
            this.AdminHome_DrillBox.Controls.Add(this.AdminHome_MngDrillBtn);
            this.AdminHome_DrillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_DrillBox.Location = new System.Drawing.Point(216, 25);
            this.AdminHome_DrillBox.Name = "AdminHome_DrillBox";
            this.AdminHome_DrillBox.Size = new System.Drawing.Size(188, 169);
            this.AdminHome_DrillBox.TabIndex = 44;
            this.AdminHome_DrillBox.TabStop = false;
            this.AdminHome_DrillBox.Text = "Drill Controls";
            // 
            // AdminHome_AdminBox
            // 
            this.AdminHome_AdminBox.Controls.Add(this.AdminHome_DrillBox);
            this.AdminHome_AdminBox.Controls.Add(this.AdminHome_UserBox);
            this.AdminHome_AdminBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_AdminBox.Location = new System.Drawing.Point(6, 249);
            this.AdminHome_AdminBox.Name = "AdminHome_AdminBox";
            this.AdminHome_AdminBox.Size = new System.Drawing.Size(410, 200);
            this.AdminHome_AdminBox.TabIndex = 40;
            this.AdminHome_AdminBox.TabStop = false;
            this.AdminHome_AdminBox.Text = "Admin Controls";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // AdminHome_LogoutBtn
            // 
            this.AdminHome_LogoutBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AdminHome_LogoutBtn.Location = new System.Drawing.Point(134, 13);
            this.AdminHome_LogoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AdminHome_LogoutBtn.Name = "AdminHome_LogoutBtn";
            this.AdminHome_LogoutBtn.Size = new System.Drawing.Size(116, 26);
            this.AdminHome_LogoutBtn.TabIndex = 25;
            this.AdminHome_LogoutBtn.Text = "Logout";
            this.AdminHome_LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // AdminHome_ExitBtn
            // 
            this.AdminHome_ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminHome_ExitBtn.Location = new System.Drawing.Point(288, 13);
            this.AdminHome_ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AdminHome_ExitBtn.Name = "AdminHome_ExitBtn";
            this.AdminHome_ExitBtn.Size = new System.Drawing.Size(115, 26);
            this.AdminHome_ExitBtn.TabIndex = 26;
            this.AdminHome_ExitBtn.Text = "Exit";
            this.AdminHome_ExitBtn.UseVisualStyleBackColor = true;
            // 
            // AdminHome_ButtonBox
            // 
            this.AdminHome_ButtonBox.Controls.Add(this.AdminHome_LogoutBtn);
            this.AdminHome_ButtonBox.Controls.Add(this.AdminHome_ExitBtn);
            this.AdminHome_ButtonBox.Location = new System.Drawing.Point(8, 455);
            this.AdminHome_ButtonBox.Name = "AdminHome_ButtonBox";
            this.AdminHome_ButtonBox.Size = new System.Drawing.Size(408, 45);
            this.AdminHome_ButtonBox.TabIndex = 38;
            this.AdminHome_ButtonBox.TabStop = false;
            // 
            // AdminHome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 506);
            this.ControlBox = false;
            this.Controls.Add(this.AdminHome_UserInfoBox);
            this.Controls.Add(this.AdminHome_PasswordBox);
            this.Controls.Add(this.AdminHome_WindowLbl);
            this.Controls.Add(this.AdminHome_AdminBox);
            this.Controls.Add(this.AdminHome_ButtonBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminHome_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.AdminHome_UserInfoBox.ResumeLayout(false);
            this.AdminHome_UserInfoBox.PerformLayout();
            this.AdminHome_PasswordBox.ResumeLayout(false);
            this.AdminHome_PasswordBox.PerformLayout();
            this.AdminHome_UserBox.ResumeLayout(false);
            this.AdminHome_DrillBox.ResumeLayout(false);
            this.AdminHome_AdminBox.ResumeLayout(false);
            this.AdminHome_ButtonBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer AdminHome_Timer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button AdminHome_SaveBtn;
        private System.Windows.Forms.Label AdminHome_NewPWLbl;
        private System.Windows.Forms.Label AdminHome_CurrentPWLbl;
        private System.Windows.Forms.RichTextBox AdminHome_CurrentPWTxt;
        private System.Windows.Forms.GroupBox AdminHome_UserInfoBox;
        private System.Windows.Forms.Label AdminHome_DateLbl;
        private System.Windows.Forms.Label AdminHome_LastLoginLbl;
        private System.Windows.Forms.Label AdminHome_WelcomeLbl;
        private System.Windows.Forms.Label AdminHome_LoginLbl;
        private System.Windows.Forms.Label AdminHome_AdminNameLbl;
        private System.Windows.Forms.Label AdminHome_TimeLbl;
        private System.Windows.Forms.GroupBox AdminHome_PasswordBox;
        private System.Windows.Forms.RichTextBox AdminHome_NewPWTxt;
        private System.Windows.Forms.Label AdminHome_WindowLbl;
        private System.Windows.Forms.Button AdminHome_MngUsersBtn;
        private System.Windows.Forms.Button AdminHome_MngGroupsBtn;
        private System.Windows.Forms.GroupBox AdminHome_UserBox;
        private System.Windows.Forms.Button AdminHome_StuReportBtn;
        private System.Windows.Forms.Button AdminHome_EditStudentBtn;
        private System.Windows.Forms.Button AdminHome_CreateDrillBtn;
        private System.Windows.Forms.Button AdminHome_MngDrillBtn;
        private System.Windows.Forms.GroupBox AdminHome_DrillBox;
        private System.Windows.Forms.GroupBox AdminHome_AdminBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button AdminHome_LogoutBtn;
        private System.Windows.Forms.Button AdminHome_ExitBtn;
        private System.Windows.Forms.GroupBox AdminHome_ButtonBox;

    }
}