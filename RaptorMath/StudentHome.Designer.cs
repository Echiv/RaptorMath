﻿namespace RaptorMath
{
    partial class StuHome_Form
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
            this.StuHome_TimeLbl = new System.Windows.Forms.Label();
            this.StuHome_LoginDateLbl = new System.Windows.Forms.Label();
            this.StuHome_StudentNameLbl = new System.Windows.Forms.Label();
            this.StuHome_ExitBtn = new System.Windows.Forms.Button();
            this.StuHome_NumQuestionsLbl = new System.Windows.Forms.Label();
            this.StuHome_TotalNumLbl = new System.Windows.Forms.Label();
            this.StuHome_DrillBox = new System.Windows.Forms.GroupBox();
            this.StuHome_Timer = new System.Windows.Forms.Timer(this.components);
            this.StuHome_DateLbl = new System.Windows.Forms.Label();
            this.StuHome_StartDrillBtn = new System.Windows.Forms.Button();
            this.StuHome_LastLoginLbl = new System.Windows.Forms.Label();
            this.StuHome_WelcomeLbl = new System.Windows.Forms.Label();
            this.StuHome_LogoutBtn = new System.Windows.Forms.Button();
            this.StuHome_ButtonBox = new System.Windows.Forms.GroupBox();
            this.StuHome_WindowLbl = new System.Windows.Forms.Label();
            this.StuHome_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.StuHome_DrillBox.SuspendLayout();
            this.StuHome_ButtonBox.SuspendLayout();
            this.StuHome_UserInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StuHome_TimeLbl
            // 
            this.StuHome_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StuHome_TimeLbl.AutoSize = true;
            this.StuHome_TimeLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_TimeLbl.Location = new System.Drawing.Point(220, 35);
            this.StuHome_TimeLbl.Name = "StuHome_TimeLbl";
            this.StuHome_TimeLbl.Size = new System.Drawing.Size(62, 22);
            this.StuHome_TimeLbl.TabIndex = 11;
            this.StuHome_TimeLbl.Text = "<Time>";
            // 
            // StuHome_LoginDateLbl
            // 
            this.StuHome_LoginDateLbl.AutoSize = true;
            this.StuHome_LoginDateLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_LoginDateLbl.Location = new System.Drawing.Point(87, 56);
            this.StuHome_LoginDateLbl.Name = "StuHome_LoginDateLbl";
            this.StuHome_LoginDateLbl.Size = new System.Drawing.Size(59, 22);
            this.StuHome_LoginDateLbl.TabIndex = 10;
            this.StuHome_LoginDateLbl.Text = "<Date>";
            // 
            // StuHome_StudentNameLbl
            // 
            this.StuHome_StudentNameLbl.AutoSize = true;
            this.StuHome_StudentNameLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_StudentNameLbl.Location = new System.Drawing.Point(87, 34);
            this.StuHome_StudentNameLbl.Name = "StuHome_StudentNameLbl";
            this.StuHome_StudentNameLbl.Size = new System.Drawing.Size(80, 22);
            this.StuHome_StudentNameLbl.TabIndex = 9;
            this.StuHome_StudentNameLbl.Text = "<Student>";
            // 
            // StuHome_ExitBtn
            // 
            this.StuHome_ExitBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_ExitBtn.Location = new System.Drawing.Point(219, 13);
            this.StuHome_ExitBtn.Name = "StuHome_ExitBtn";
            this.StuHome_ExitBtn.Size = new System.Drawing.Size(81, 31);
            this.StuHome_ExitBtn.TabIndex = 3;
            this.StuHome_ExitBtn.Text = "Exit";
            this.StuHome_ExitBtn.UseVisualStyleBackColor = true;
            this.StuHome_ExitBtn.Click += new System.EventHandler(this.StuHome_ExitBtn_Click);
            // 
            // StuHome_NumQuestionsLbl
            // 
            this.StuHome_NumQuestionsLbl.AutoSize = true;
            this.StuHome_NumQuestionsLbl.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_NumQuestionsLbl.Location = new System.Drawing.Point(7, 25);
            this.StuHome_NumQuestionsLbl.Name = "StuHome_NumQuestionsLbl";
            this.StuHome_NumQuestionsLbl.Size = new System.Drawing.Size(135, 27);
            this.StuHome_NumQuestionsLbl.TabIndex = 2;
            this.StuHome_NumQuestionsLbl.Text = "There will be";
            // 
            // StuHome_TotalNumLbl
            // 
            this.StuHome_TotalNumLbl.AutoSize = true;
            this.StuHome_TotalNumLbl.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_TotalNumLbl.Location = new System.Drawing.Point(137, 25);
            this.StuHome_TotalNumLbl.Name = "StuHome_TotalNumLbl";
            this.StuHome_TotalNumLbl.Size = new System.Drawing.Size(147, 27);
            this.StuHome_TotalNumLbl.TabIndex = 3;
            this.StuHome_TotalNumLbl.Text = "<#> questions.";
            // 
            // StuHome_DrillBox
            // 
            this.StuHome_DrillBox.Controls.Add(this.StuHome_TotalNumLbl);
            this.StuHome_DrillBox.Controls.Add(this.StuHome_NumQuestionsLbl);
            this.StuHome_DrillBox.Controls.Add(this.StuHome_StartDrillBtn);
            this.StuHome_DrillBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_DrillBox.Location = new System.Drawing.Point(12, 101);
            this.StuHome_DrillBox.Name = "StuHome_DrillBox";
            this.StuHome_DrillBox.Size = new System.Drawing.Size(310, 112);
            this.StuHome_DrillBox.TabIndex = 7;
            this.StuHome_DrillBox.TabStop = false;
            this.StuHome_DrillBox.Text = "About Your Next Drill";
            // 
            // StuHome_Timer
            // 
            this.StuHome_Timer.Enabled = true;
            this.StuHome_Timer.Interval = 1000;
            this.StuHome_Timer.Tick += new System.EventHandler(this.StuHome_Timer_Tick);
            // 
            // StuHome_DateLbl
            // 
            this.StuHome_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StuHome_DateLbl.AutoSize = true;
            this.StuHome_DateLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_DateLbl.Location = new System.Drawing.Point(220, 9);
            this.StuHome_DateLbl.Name = "StuHome_DateLbl";
            this.StuHome_DateLbl.Size = new System.Drawing.Size(59, 22);
            this.StuHome_DateLbl.TabIndex = 6;
            this.StuHome_DateLbl.Text = "<Date>";
            // 
            // StuHome_StartDrillBtn
            // 
            this.StuHome_StartDrillBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StuHome_StartDrillBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_StartDrillBtn.Location = new System.Drawing.Point(92, 67);
            this.StuHome_StartDrillBtn.Name = "StuHome_StartDrillBtn";
            this.StuHome_StartDrillBtn.Size = new System.Drawing.Size(121, 31);
            this.StuHome_StartDrillBtn.TabIndex = 1;
            this.StuHome_StartDrillBtn.Text = "Start Drill";
            this.StuHome_StartDrillBtn.UseVisualStyleBackColor = true;
            this.StuHome_StartDrillBtn.Click += new System.EventHandler(this.StuHome_StartDrillBtn_Click);
            // 
            // StuHome_LastLoginLbl
            // 
            this.StuHome_LastLoginLbl.AutoSize = true;
            this.StuHome_LastLoginLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_LastLoginLbl.Location = new System.Drawing.Point(6, 56);
            this.StuHome_LastLoginLbl.Name = "StuHome_LastLoginLbl";
            this.StuHome_LastLoginLbl.Size = new System.Drawing.Size(83, 22);
            this.StuHome_LastLoginLbl.TabIndex = 5;
            this.StuHome_LastLoginLbl.Text = "Last login:";
            // 
            // StuHome_WelcomeLbl
            // 
            this.StuHome_WelcomeLbl.AutoSize = true;
            this.StuHome_WelcomeLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_WelcomeLbl.Location = new System.Drawing.Point(6, 34);
            this.StuHome_WelcomeLbl.Name = "StuHome_WelcomeLbl";
            this.StuHome_WelcomeLbl.Size = new System.Drawing.Size(83, 22);
            this.StuHome_WelcomeLbl.TabIndex = 4;
            this.StuHome_WelcomeLbl.Text = "Welcome,";
            // 
            // StuHome_LogoutBtn
            // 
            this.StuHome_LogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StuHome_LogoutBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_LogoutBtn.Location = new System.Drawing.Point(10, 13);
            this.StuHome_LogoutBtn.Name = "StuHome_LogoutBtn";
            this.StuHome_LogoutBtn.Size = new System.Drawing.Size(81, 31);
            this.StuHome_LogoutBtn.TabIndex = 2;
            this.StuHome_LogoutBtn.Text = "Logout";
            this.StuHome_LogoutBtn.UseVisualStyleBackColor = true;
            this.StuHome_LogoutBtn.Click += new System.EventHandler(this.StuHome_LogoutBtn_Click);
            // 
            // StuHome_ButtonBox
            // 
            this.StuHome_ButtonBox.Controls.Add(this.StuHome_LogoutBtn);
            this.StuHome_ButtonBox.Controls.Add(this.StuHome_ExitBtn);
            this.StuHome_ButtonBox.Location = new System.Drawing.Point(12, 206);
            this.StuHome_ButtonBox.Name = "StuHome_ButtonBox";
            this.StuHome_ButtonBox.Size = new System.Drawing.Size(310, 52);
            this.StuHome_ButtonBox.TabIndex = 12;
            this.StuHome_ButtonBox.TabStop = false;
            // 
            // StuHome_WindowLbl
            // 
            this.StuHome_WindowLbl.AutoSize = true;
            this.StuHome_WindowLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_WindowLbl.Location = new System.Drawing.Point(6, 8);
            this.StuHome_WindowLbl.Name = "StuHome_WindowLbl";
            this.StuHome_WindowLbl.Size = new System.Drawing.Size(115, 22);
            this.StuHome_WindowLbl.TabIndex = 14;
            this.StuHome_WindowLbl.Text = "Student Home";
            // 
            // StuHome_UserInfoBox
            // 
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_TimeLbl);
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_DateLbl);
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_WindowLbl);
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_WelcomeLbl);
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_LoginDateLbl);
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_LastLoginLbl);
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_StudentNameLbl);
            this.StuHome_UserInfoBox.Location = new System.Drawing.Point(12, 3);
            this.StuHome_UserInfoBox.Name = "StuHome_UserInfoBox";
            this.StuHome_UserInfoBox.Size = new System.Drawing.Size(310, 92);
            this.StuHome_UserInfoBox.TabIndex = 15;
            this.StuHome_UserInfoBox.TabStop = false;
            // 
            // StuHome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.ControlBox = false;
            this.Controls.Add(this.StuHome_DrillBox);
            this.Controls.Add(this.StuHome_ButtonBox);
            this.Controls.Add(this.StuHome_UserInfoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StuHome_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.StuHome_DrillBox.ResumeLayout(false);
            this.StuHome_DrillBox.PerformLayout();
            this.StuHome_ButtonBox.ResumeLayout(false);
            this.StuHome_UserInfoBox.ResumeLayout(false);
            this.StuHome_UserInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label StuHome_TimeLbl;
        private System.Windows.Forms.Label StuHome_LoginDateLbl;
        private System.Windows.Forms.Label StuHome_StudentNameLbl;
        private System.Windows.Forms.Button StuHome_ExitBtn;
        private System.Windows.Forms.Label StuHome_NumQuestionsLbl;
        private System.Windows.Forms.Label StuHome_TotalNumLbl;
        private System.Windows.Forms.GroupBox StuHome_DrillBox;
        private System.Windows.Forms.Button StuHome_StartDrillBtn;
        private System.Windows.Forms.Timer StuHome_Timer;
        private System.Windows.Forms.Label StuHome_DateLbl;
        private System.Windows.Forms.Label StuHome_LastLoginLbl;
        private System.Windows.Forms.Label StuHome_WelcomeLbl;
        private System.Windows.Forms.Button StuHome_LogoutBtn;
        private System.Windows.Forms.GroupBox StuHome_ButtonBox;
        private System.Windows.Forms.Label StuHome_WindowLbl;
        private System.Windows.Forms.GroupBox StuHome_UserInfoBox;


    }
}