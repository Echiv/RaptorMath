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
            this.AdminHome_WindowLbl = new System.Windows.Forms.Label();
            this.AdminHome_WelcomeLbl = new System.Windows.Forms.Label();
            this.AdminHome_LoginLbl = new System.Windows.Forms.Label();
            this.AdminHome_AdminNameLbl = new System.Windows.Forms.Label();
            this.AdminHome_TimeLbl = new System.Windows.Forms.Label();
            this.AdminHome_PasswordBox = new System.Windows.Forms.GroupBox();
            this.AdminHome_NewPWTxt = new System.Windows.Forms.RichTextBox();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AdminHome_UserInfoBox.SuspendLayout();
            this.AdminHome_PasswordBox.SuspendLayout();
            this.AdminHome_UserBox.SuspendLayout();
            this.AdminHome_DrillBox.SuspendLayout();
            this.AdminHome_AdminBox.SuspendLayout();
            this.AdminHome_ButtonBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.AdminHome_SaveBtn.Location = new System.Drawing.Point(190, 99);
            this.AdminHome_SaveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminHome_SaveBtn.Name = "AdminHome_SaveBtn";
            this.AdminHome_SaveBtn.Size = new System.Drawing.Size(115, 30);
            this.AdminHome_SaveBtn.TabIndex = 39;
            this.AdminHome_SaveBtn.Text = "Save";
            this.AdminHome_SaveBtn.UseVisualStyleBackColor = true;
            this.AdminHome_SaveBtn.Click += new System.EventHandler(this.AdminHome_SaveBtn_Click);
            // 
            // AdminHome_NewPWLbl
            // 
            this.AdminHome_NewPWLbl.AutoSize = true;
            this.AdminHome_NewPWLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_NewPWLbl.Location = new System.Drawing.Point(52, 69);
            this.AdminHome_NewPWLbl.Name = "AdminHome_NewPWLbl";
            this.AdminHome_NewPWLbl.Size = new System.Drawing.Size(78, 13);
            this.AdminHome_NewPWLbl.TabIndex = 2;
            this.AdminHome_NewPWLbl.Text = "New Password";
            // 
            // AdminHome_CurrentPWLbl
            // 
            this.AdminHome_CurrentPWLbl.AutoSize = true;
            this.AdminHome_CurrentPWLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_CurrentPWLbl.Location = new System.Drawing.Point(52, 28);
            this.AdminHome_CurrentPWLbl.Name = "AdminHome_CurrentPWLbl";
            this.AdminHome_CurrentPWLbl.Size = new System.Drawing.Size(90, 13);
            this.AdminHome_CurrentPWLbl.TabIndex = 1;
            this.AdminHome_CurrentPWLbl.Text = "Current Password";
            // 
            // AdminHome_CurrentPWTxt
            // 
            this.AdminHome_CurrentPWTxt.Location = new System.Drawing.Point(151, 25);
            this.AdminHome_CurrentPWTxt.Name = "AdminHome_CurrentPWTxt";
            this.AdminHome_CurrentPWTxt.Size = new System.Drawing.Size(195, 26);
            this.AdminHome_CurrentPWTxt.TabIndex = 0;
            this.AdminHome_CurrentPWTxt.Text = "";
            // 
            // AdminHome_UserInfoBox
            // 
            this.AdminHome_UserInfoBox.Controls.Add(this.AdminHome_DateLbl);
            this.AdminHome_UserInfoBox.Controls.Add(this.AdminHome_LastLoginLbl);
            this.AdminHome_UserInfoBox.Controls.Add(this.AdminHome_WindowLbl);
            this.AdminHome_UserInfoBox.Controls.Add(this.AdminHome_WelcomeLbl);
            this.AdminHome_UserInfoBox.Controls.Add(this.AdminHome_LoginLbl);
            this.AdminHome_UserInfoBox.Controls.Add(this.AdminHome_AdminNameLbl);
            this.AdminHome_UserInfoBox.Controls.Add(this.AdminHome_TimeLbl);
            this.AdminHome_UserInfoBox.Location = new System.Drawing.Point(3, 3);
            this.AdminHome_UserInfoBox.Name = "AdminHome_UserInfoBox";
            this.AdminHome_UserInfoBox.Size = new System.Drawing.Size(425, 103);
            this.AdminHome_UserInfoBox.TabIndex = 39;
            this.AdminHome_UserInfoBox.TabStop = false;
            // 
            // AdminHome_DateLbl
            // 
            this.AdminHome_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminHome_DateLbl.AutoSize = true;
            this.AdminHome_DateLbl.Location = new System.Drawing.Point(369, 15);
            this.AdminHome_DateLbl.Name = "AdminHome_DateLbl";
            this.AdminHome_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.AdminHome_DateLbl.TabIndex = 31;
            this.AdminHome_DateLbl.Text = "<Date>";
            // 
            // AdminHome_LastLoginLbl
            // 
            this.AdminHome_LastLoginLbl.AutoSize = true;
            this.AdminHome_LastLoginLbl.Location = new System.Drawing.Point(6, 46);
            this.AdminHome_LastLoginLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdminHome_LastLoginLbl.Name = "AdminHome_LastLoginLbl";
            this.AdminHome_LastLoginLbl.Size = new System.Drawing.Size(59, 13);
            this.AdminHome_LastLoginLbl.TabIndex = 16;
            this.AdminHome_LastLoginLbl.Text = "Last Login:";
            // 
            // AdminHome_WindowLbl
            // 
            this.AdminHome_WindowLbl.AutoSize = true;
            this.AdminHome_WindowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_WindowLbl.Location = new System.Drawing.Point(6, 11);
            this.AdminHome_WindowLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdminHome_WindowLbl.Name = "AdminHome_WindowLbl";
            this.AdminHome_WindowLbl.Size = new System.Drawing.Size(77, 13);
            this.AdminHome_WindowLbl.TabIndex = 37;
            this.AdminHome_WindowLbl.Text = "Admin Home";
            // 
            // AdminHome_WelcomeLbl
            // 
            this.AdminHome_WelcomeLbl.AutoSize = true;
            this.AdminHome_WelcomeLbl.Location = new System.Drawing.Point(6, 28);
            this.AdminHome_WelcomeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdminHome_WelcomeLbl.Name = "AdminHome_WelcomeLbl";
            this.AdminHome_WelcomeLbl.Size = new System.Drawing.Size(55, 13);
            this.AdminHome_WelcomeLbl.TabIndex = 27;
            this.AdminHome_WelcomeLbl.Text = "Welcome,";
            // 
            // AdminHome_LoginLbl
            // 
            this.AdminHome_LoginLbl.AutoSize = true;
            this.AdminHome_LoginLbl.Location = new System.Drawing.Point(70, 46);
            this.AdminHome_LoginLbl.Name = "AdminHome_LoginLbl";
            this.AdminHome_LoginLbl.Size = new System.Drawing.Size(42, 13);
            this.AdminHome_LoginLbl.TabIndex = 29;
            this.AdminHome_LoginLbl.Text = "<Date>";
            // 
            // AdminHome_AdminNameLbl
            // 
            this.AdminHome_AdminNameLbl.AutoSize = true;
            this.AdminHome_AdminNameLbl.Location = new System.Drawing.Point(71, 28);
            this.AdminHome_AdminNameLbl.Name = "AdminHome_AdminNameLbl";
            this.AdminHome_AdminNameLbl.Size = new System.Drawing.Size(48, 13);
            this.AdminHome_AdminNameLbl.TabIndex = 28;
            this.AdminHome_AdminNameLbl.Text = "<Admin>";
            // 
            // AdminHome_TimeLbl
            // 
            this.AdminHome_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminHome_TimeLbl.AutoSize = true;
            this.AdminHome_TimeLbl.Location = new System.Drawing.Point(369, 38);
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
            this.AdminHome_PasswordBox.Location = new System.Drawing.Point(3, 112);
            this.AdminHome_PasswordBox.Name = "AdminHome_PasswordBox";
            this.AdminHome_PasswordBox.Size = new System.Drawing.Size(425, 175);
            this.AdminHome_PasswordBox.TabIndex = 41;
            this.AdminHome_PasswordBox.TabStop = false;
            this.AdminHome_PasswordBox.Text = "Change Password";
            // 
            // AdminHome_NewPWTxt
            // 
            this.AdminHome_NewPWTxt.Location = new System.Drawing.Point(151, 66);
            this.AdminHome_NewPWTxt.Name = "AdminHome_NewPWTxt";
            this.AdminHome_NewPWTxt.Size = new System.Drawing.Size(195, 28);
            this.AdminHome_NewPWTxt.TabIndex = 0;
            this.AdminHome_NewPWTxt.Text = "";
            // 
            // AdminHome_MngUsersBtn
            // 
            this.AdminHome_MngUsersBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminHome_MngUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_MngUsersBtn.Location = new System.Drawing.Point(16, 18);
            this.AdminHome_MngUsersBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminHome_MngUsersBtn.Name = "AdminHome_MngUsersBtn";
            this.AdminHome_MngUsersBtn.Size = new System.Drawing.Size(116, 25);
            this.AdminHome_MngUsersBtn.TabIndex = 37;
            this.AdminHome_MngUsersBtn.Text = "Manage Users";
            this.AdminHome_MngUsersBtn.UseVisualStyleBackColor = true;
            this.AdminHome_MngUsersBtn.Click += new System.EventHandler(this.AdminHome_MngUsersBtn_Click);
            // 
            // AdminHome_MngGroupsBtn
            // 
            this.AdminHome_MngGroupsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminHome_MngGroupsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_MngGroupsBtn.Location = new System.Drawing.Point(16, 46);
            this.AdminHome_MngGroupsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.AdminHome_UserBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdminHome_UserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_UserBox.Location = new System.Drawing.Point(3, 16);
            this.AdminHome_UserBox.Name = "AdminHome_UserBox";
            this.AdminHome_UserBox.Size = new System.Drawing.Size(153, 137);
            this.AdminHome_UserBox.TabIndex = 45;
            this.AdminHome_UserBox.TabStop = false;
            this.AdminHome_UserBox.Text = "User Controls";
            // 
            // AdminHome_StuReportBtn
            // 
            this.AdminHome_StuReportBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminHome_StuReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_StuReportBtn.Location = new System.Drawing.Point(16, 76);
            this.AdminHome_StuReportBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminHome_StuReportBtn.Name = "AdminHome_StuReportBtn";
            this.AdminHome_StuReportBtn.Size = new System.Drawing.Size(116, 25);
            this.AdminHome_StuReportBtn.TabIndex = 19;
            this.AdminHome_StuReportBtn.Text = "Student Reports";
            this.AdminHome_StuReportBtn.UseVisualStyleBackColor = true;
            // 
            // AdminHome_EditStudentBtn
            // 
            this.AdminHome_EditStudentBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminHome_EditStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_EditStudentBtn.Location = new System.Drawing.Point(16, 105);
            this.AdminHome_EditStudentBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.AdminHome_CreateDrillBtn.Location = new System.Drawing.Point(5, 19);
            this.AdminHome_CreateDrillBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.AdminHome_MngDrillBtn.Location = new System.Drawing.Point(5, 48);
            this.AdminHome_MngDrillBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.AdminHome_DrillBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.AdminHome_DrillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_DrillBox.Location = new System.Drawing.Point(272, 16);
            this.AdminHome_DrillBox.Name = "AdminHome_DrillBox";
            this.AdminHome_DrillBox.Size = new System.Drawing.Size(153, 137);
            this.AdminHome_DrillBox.TabIndex = 44;
            this.AdminHome_DrillBox.TabStop = false;
            this.AdminHome_DrillBox.Text = "Drill Controls";
            // 
            // AdminHome_AdminBox
            // 
            this.AdminHome_AdminBox.Controls.Add(this.AdminHome_DrillBox);
            this.AdminHome_AdminBox.Controls.Add(this.AdminHome_UserBox);
            this.AdminHome_AdminBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminHome_AdminBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHome_AdminBox.Location = new System.Drawing.Point(3, 304);
            this.AdminHome_AdminBox.Name = "AdminHome_AdminBox";
            this.AdminHome_AdminBox.Size = new System.Drawing.Size(428, 156);
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
            this.AdminHome_LogoutBtn.Location = new System.Drawing.Point(132, 12);
            this.AdminHome_LogoutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminHome_LogoutBtn.Name = "AdminHome_LogoutBtn";
            this.AdminHome_LogoutBtn.Size = new System.Drawing.Size(116, 26);
            this.AdminHome_LogoutBtn.TabIndex = 25;
            this.AdminHome_LogoutBtn.Text = "Logout";
            this.AdminHome_LogoutBtn.UseVisualStyleBackColor = true;
            this.AdminHome_LogoutBtn.Click += new System.EventHandler(this.AdminHome_LogoutBtn_Click);
            // 
            // AdminHome_ExitBtn
            // 
            this.AdminHome_ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminHome_ExitBtn.Location = new System.Drawing.Point(308, 12);
            this.AdminHome_ExitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminHome_ExitBtn.Name = "AdminHome_ExitBtn";
            this.AdminHome_ExitBtn.Size = new System.Drawing.Size(115, 26);
            this.AdminHome_ExitBtn.TabIndex = 26;
            this.AdminHome_ExitBtn.Text = "Exit";
            this.AdminHome_ExitBtn.UseVisualStyleBackColor = true;
            this.AdminHome_ExitBtn.Click += new System.EventHandler(this.AdminHome_ExitBtn_Click);
            // 
            // AdminHome_ButtonBox
            // 
            this.AdminHome_ButtonBox.Controls.Add(this.AdminHome_LogoutBtn);
            this.AdminHome_ButtonBox.Controls.Add(this.AdminHome_ExitBtn);
            this.AdminHome_ButtonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminHome_ButtonBox.Location = new System.Drawing.Point(3, 466);
            this.AdminHome_ButtonBox.Name = "AdminHome_ButtonBox";
            this.AdminHome_ButtonBox.Size = new System.Drawing.Size(428, 43);
            this.AdminHome_ButtonBox.TabIndex = 38;
            this.AdminHome_ButtonBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AdminHome_ButtonBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AdminHome_AdminBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.AdminHome_UserInfoBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AdminHome_PasswordBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.32479F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.67521F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 512);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // AdminHome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 512);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}