﻿namespace RaptorMath
{
    partial class StudentRepotrs_Form
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
            this.UseRep_DateLbl = new System.Windows.Forms.Label();
            this.ReportHome_DateRangeBox = new System.Windows.Forms.GroupBox();
            this.ReportHome_StartDate = new System.Windows.Forms.DateTimePicker();
            this.ReportHome_EndDate = new System.Windows.Forms.DateTimePicker();
            this.ReportHome_EndDateLbl = new System.Windows.Forms.Label();
            this.ReportHome_StartDateLbl = new System.Windows.Forms.Label();
            this.ReportHome_GroupReportBtn = new System.Windows.Forms.Button();
            this.UseRep_Timer = new System.Windows.Forms.Timer(this.components);
            this.UseRep_TimeLbl = new System.Windows.Forms.Label();
            this.ReportHome_WindowLbl = new System.Windows.Forms.Label();
            this.ReportHome_SelectionBox = new System.Windows.Forms.GroupBox();
            this.ReportHome_GroupLbl = new System.Windows.Forms.Label();
            this.ReportHome_GroupDdl = new System.Windows.Forms.ComboBox();
            this.ReportHome_StudenLbl = new System.Windows.Forms.Label();
            this.ReportHome_StudentDdl = new System.Windows.Forms.ComboBox();
            this.ReportHome_SingleReportBtn = new System.Windows.Forms.Button();
            this.ReportHome_ButtonBox = new System.Windows.Forms.GroupBox();
            this.ReportHome_ExitBtn = new System.Windows.Forms.Button();
            this.ReportHome_CloseBtn = new System.Windows.Forms.Button();
            this.ReportHome_SelectRportBox = new System.Windows.Forms.GroupBox();
            this.ReportHome_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.ReportHome_DateLbl = new System.Windows.Forms.Label();
            this.ReportHome_AdminNameLbl = new System.Windows.Forms.Label();
            this.ReportHome_TimeLbl = new System.Windows.Forms.Label();
            this.ReportHome_DateRangeBox.SuspendLayout();
            this.ReportHome_SelectionBox.SuspendLayout();
            this.ReportHome_ButtonBox.SuspendLayout();
            this.ReportHome_SelectRportBox.SuspendLayout();
            this.ReportHome_UserInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UseRep_DateLbl
            // 
            this.UseRep_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseRep_DateLbl.AutoSize = true;
            this.UseRep_DateLbl.Location = new System.Drawing.Point(346, 16);
            this.UseRep_DateLbl.Name = "UseRep_DateLbl";
            this.UseRep_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.UseRep_DateLbl.TabIndex = 18;
            this.UseRep_DateLbl.Text = "<Date>";
            // 
            // ReportHome_DateRangeBox
            // 
            this.ReportHome_DateRangeBox.Controls.Add(this.ReportHome_StartDate);
            this.ReportHome_DateRangeBox.Controls.Add(this.ReportHome_EndDate);
            this.ReportHome_DateRangeBox.Controls.Add(this.ReportHome_EndDateLbl);
            this.ReportHome_DateRangeBox.Controls.Add(this.ReportHome_StartDateLbl);
            this.ReportHome_DateRangeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_DateRangeBox.Location = new System.Drawing.Point(14, 184);
            this.ReportHome_DateRangeBox.Name = "ReportHome_DateRangeBox";
            this.ReportHome_DateRangeBox.Size = new System.Drawing.Size(407, 110);
            this.ReportHome_DateRangeBox.TabIndex = 19;
            this.ReportHome_DateRangeBox.TabStop = false;
            this.ReportHome_DateRangeBox.Text = "Date Range";
            // 
            // ReportHome_StartDate
            // 
            this.ReportHome_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_StartDate.Location = new System.Drawing.Point(142, 33);
            this.ReportHome_StartDate.Name = "ReportHome_StartDate";
            this.ReportHome_StartDate.Size = new System.Drawing.Size(199, 20);
            this.ReportHome_StartDate.TabIndex = 26;
            // 
            // ReportHome_EndDate
            // 
            this.ReportHome_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_EndDate.Location = new System.Drawing.Point(142, 59);
            this.ReportHome_EndDate.Name = "ReportHome_EndDate";
            this.ReportHome_EndDate.Size = new System.Drawing.Size(199, 20);
            this.ReportHome_EndDate.TabIndex = 25;
            // 
            // ReportHome_EndDateLbl
            // 
            this.ReportHome_EndDateLbl.AutoSize = true;
            this.ReportHome_EndDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_EndDateLbl.Location = new System.Drawing.Point(82, 61);
            this.ReportHome_EndDateLbl.Name = "ReportHome_EndDateLbl";
            this.ReportHome_EndDateLbl.Size = new System.Drawing.Size(52, 13);
            this.ReportHome_EndDateLbl.TabIndex = 24;
            this.ReportHome_EndDateLbl.Text = "End Date";
            // 
            // ReportHome_StartDateLbl
            // 
            this.ReportHome_StartDateLbl.AutoSize = true;
            this.ReportHome_StartDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_StartDateLbl.Location = new System.Drawing.Point(80, 33);
            this.ReportHome_StartDateLbl.Name = "ReportHome_StartDateLbl";
            this.ReportHome_StartDateLbl.Size = new System.Drawing.Size(55, 13);
            this.ReportHome_StartDateLbl.TabIndex = 22;
            this.ReportHome_StartDateLbl.Text = "Start Date";
            // 
            // ReportHome_GroupReportBtn
            // 
            this.ReportHome_GroupReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_GroupReportBtn.Location = new System.Drawing.Point(153, 48);
            this.ReportHome_GroupReportBtn.Name = "ReportHome_GroupReportBtn";
            this.ReportHome_GroupReportBtn.Size = new System.Drawing.Size(88, 26);
            this.ReportHome_GroupReportBtn.TabIndex = 0;
            this.ReportHome_GroupReportBtn.Text = "Group Report";
            this.ReportHome_GroupReportBtn.UseVisualStyleBackColor = true;
            // 
            // UseRep_Timer
            // 
            this.UseRep_Timer.Enabled = true;
            this.UseRep_Timer.Interval = 1000;
            // 
            // UseRep_TimeLbl
            // 
            this.UseRep_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseRep_TimeLbl.AutoSize = true;
            this.UseRep_TimeLbl.Location = new System.Drawing.Point(346, 39);
            this.UseRep_TimeLbl.Name = "UseRep_TimeLbl";
            this.UseRep_TimeLbl.Size = new System.Drawing.Size(42, 13);
            this.UseRep_TimeLbl.TabIndex = 22;
            this.UseRep_TimeLbl.Text = "<Time>";
            // 
            // ReportHome_WindowLbl
            // 
            this.ReportHome_WindowLbl.AutoSize = true;
            this.ReportHome_WindowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_WindowLbl.Location = new System.Drawing.Point(174, 9);
            this.ReportHome_WindowLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReportHome_WindowLbl.Name = "ReportHome_WindowLbl";
            this.ReportHome_WindowLbl.Size = new System.Drawing.Size(99, 13);
            this.ReportHome_WindowLbl.TabIndex = 33;
            this.ReportHome_WindowLbl.Text = "Student Reports";
            // 
            // ReportHome_SelectionBox
            // 
            this.ReportHome_SelectionBox.Controls.Add(this.ReportHome_GroupLbl);
            this.ReportHome_SelectionBox.Controls.Add(this.ReportHome_GroupDdl);
            this.ReportHome_SelectionBox.Controls.Add(this.ReportHome_StudenLbl);
            this.ReportHome_SelectionBox.Controls.Add(this.ReportHome_StudentDdl);
            this.ReportHome_SelectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_SelectionBox.Location = new System.Drawing.Point(14, 90);
            this.ReportHome_SelectionBox.Name = "ReportHome_SelectionBox";
            this.ReportHome_SelectionBox.Size = new System.Drawing.Size(406, 88);
            this.ReportHome_SelectionBox.TabIndex = 46;
            this.ReportHome_SelectionBox.TabStop = false;
            this.ReportHome_SelectionBox.Text = "Select a Student or Group";
            // 
            // ReportHome_GroupLbl
            // 
            this.ReportHome_GroupLbl.AutoSize = true;
            this.ReportHome_GroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_GroupLbl.Location = new System.Drawing.Point(291, 27);
            this.ReportHome_GroupLbl.Name = "ReportHome_GroupLbl";
            this.ReportHome_GroupLbl.Size = new System.Drawing.Size(36, 13);
            this.ReportHome_GroupLbl.TabIndex = 37;
            this.ReportHome_GroupLbl.Text = "Group";
            // 
            // ReportHome_GroupDdl
            // 
            this.ReportHome_GroupDdl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReportHome_GroupDdl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReportHome_GroupDdl.FormattingEnabled = true;
            this.ReportHome_GroupDdl.Location = new System.Drawing.Point(232, 43);
            this.ReportHome_GroupDdl.MaxDropDownItems = 100;
            this.ReportHome_GroupDdl.Name = "ReportHome_GroupDdl";
            this.ReportHome_GroupDdl.Size = new System.Drawing.Size(168, 21);
            this.ReportHome_GroupDdl.TabIndex = 36;
            // 
            // ReportHome_StudenLbl
            // 
            this.ReportHome_StudenLbl.AutoSize = true;
            this.ReportHome_StudenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_StudenLbl.Location = new System.Drawing.Point(68, 27);
            this.ReportHome_StudenLbl.Name = "ReportHome_StudenLbl";
            this.ReportHome_StudenLbl.Size = new System.Drawing.Size(44, 13);
            this.ReportHome_StudenLbl.TabIndex = 35;
            this.ReportHome_StudenLbl.Text = "Student";
            // 
            // ReportHome_StudentDdl
            // 
            this.ReportHome_StudentDdl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReportHome_StudentDdl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReportHome_StudentDdl.FormattingEnabled = true;
            this.ReportHome_StudentDdl.Location = new System.Drawing.Point(7, 43);
            this.ReportHome_StudentDdl.MaxDropDownItems = 100;
            this.ReportHome_StudentDdl.Name = "ReportHome_StudentDdl";
            this.ReportHome_StudentDdl.Size = new System.Drawing.Size(168, 21);
            this.ReportHome_StudentDdl.TabIndex = 34;
            // 
            // ReportHome_SingleReportBtn
            // 
            this.ReportHome_SingleReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_SingleReportBtn.Location = new System.Drawing.Point(153, 16);
            this.ReportHome_SingleReportBtn.Name = "ReportHome_SingleReportBtn";
            this.ReportHome_SingleReportBtn.Size = new System.Drawing.Size(88, 26);
            this.ReportHome_SingleReportBtn.TabIndex = 27;
            this.ReportHome_SingleReportBtn.Text = "Single Report";
            this.ReportHome_SingleReportBtn.UseVisualStyleBackColor = true;
            // 
            // ReportHome_ButtonBox
            // 
            this.ReportHome_ButtonBox.Controls.Add(this.ReportHome_ExitBtn);
            this.ReportHome_ButtonBox.Controls.Add(this.ReportHome_CloseBtn);
            this.ReportHome_ButtonBox.Location = new System.Drawing.Point(14, 455);
            this.ReportHome_ButtonBox.Name = "ReportHome_ButtonBox";
            this.ReportHome_ButtonBox.Size = new System.Drawing.Size(408, 45);
            this.ReportHome_ButtonBox.TabIndex = 47;
            this.ReportHome_ButtonBox.TabStop = false;
            // 
            // ReportHome_ExitBtn
            // 
            this.ReportHome_ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ReportHome_ExitBtn.Location = new System.Drawing.Point(315, 14);
            this.ReportHome_ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReportHome_ExitBtn.Name = "ReportHome_ExitBtn";
            this.ReportHome_ExitBtn.Size = new System.Drawing.Size(88, 26);
            this.ReportHome_ExitBtn.TabIndex = 25;
            this.ReportHome_ExitBtn.Text = "Exit";
            this.ReportHome_ExitBtn.UseVisualStyleBackColor = true;
            // 
            // ReportHome_CloseBtn
            // 
            this.ReportHome_CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ReportHome_CloseBtn.Location = new System.Drawing.Point(154, 14);
            this.ReportHome_CloseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReportHome_CloseBtn.Name = "ReportHome_CloseBtn";
            this.ReportHome_CloseBtn.Size = new System.Drawing.Size(88, 26);
            this.ReportHome_CloseBtn.TabIndex = 25;
            this.ReportHome_CloseBtn.Text = "Close";
            this.ReportHome_CloseBtn.UseVisualStyleBackColor = true;
            // 
            // ReportHome_SelectRportBox
            // 
            this.ReportHome_SelectRportBox.Controls.Add(this.ReportHome_SingleReportBtn);
            this.ReportHome_SelectRportBox.Controls.Add(this.ReportHome_GroupReportBtn);
            this.ReportHome_SelectRportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_SelectRportBox.Location = new System.Drawing.Point(15, 300);
            this.ReportHome_SelectRportBox.Name = "ReportHome_SelectRportBox";
            this.ReportHome_SelectRportBox.Size = new System.Drawing.Size(407, 94);
            this.ReportHome_SelectRportBox.TabIndex = 19;
            this.ReportHome_SelectRportBox.TabStop = false;
            this.ReportHome_SelectRportBox.Text = "Select a Report";
            // 
            // ReportHome_UserInfoBox
            // 
            this.ReportHome_UserInfoBox.Controls.Add(this.ReportHome_DateLbl);
            this.ReportHome_UserInfoBox.Controls.Add(this.ReportHome_AdminNameLbl);
            this.ReportHome_UserInfoBox.Controls.Add(this.ReportHome_TimeLbl);
            this.ReportHome_UserInfoBox.Location = new System.Drawing.Point(14, 25);
            this.ReportHome_UserInfoBox.Name = "ReportHome_UserInfoBox";
            this.ReportHome_UserInfoBox.Size = new System.Drawing.Size(410, 59);
            this.ReportHome_UserInfoBox.TabIndex = 48;
            this.ReportHome_UserInfoBox.TabStop = false;
            // 
            // ReportHome_DateLbl
            // 
            this.ReportHome_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_DateLbl.AutoSize = true;
            this.ReportHome_DateLbl.Location = new System.Drawing.Point(346, 16);
            this.ReportHome_DateLbl.Name = "ReportHome_DateLbl";
            this.ReportHome_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.ReportHome_DateLbl.TabIndex = 31;
            this.ReportHome_DateLbl.Text = "<Date>";
            // 
            // ReportHome_AdminNameLbl
            // 
            this.ReportHome_AdminNameLbl.AutoSize = true;
            this.ReportHome_AdminNameLbl.Location = new System.Drawing.Point(6, 16);
            this.ReportHome_AdminNameLbl.Name = "ReportHome_AdminNameLbl";
            this.ReportHome_AdminNameLbl.Size = new System.Drawing.Size(48, 13);
            this.ReportHome_AdminNameLbl.TabIndex = 28;
            this.ReportHome_AdminNameLbl.Text = "<Admin>";
            // 
            // ReportHome_TimeLbl
            // 
            this.ReportHome_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_TimeLbl.AutoSize = true;
            this.ReportHome_TimeLbl.Location = new System.Drawing.Point(346, 39);
            this.ReportHome_TimeLbl.Name = "ReportHome_TimeLbl";
            this.ReportHome_TimeLbl.Size = new System.Drawing.Size(42, 13);
            this.ReportHome_TimeLbl.TabIndex = 17;
            this.ReportHome_TimeLbl.Text = "<Time>";
            // 
            // StudentReports_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 512);
            this.Controls.Add(this.ReportHome_UserInfoBox);
            this.Controls.Add(this.ReportHome_ButtonBox);
            this.Controls.Add(this.ReportHome_SelectionBox);
            this.Controls.Add(this.ReportHome_SelectRportBox);
            this.Controls.Add(this.ReportHome_DateRangeBox);
            this.Controls.Add(this.ReportHome_WindowLbl);
            this.Name = "StudentReports_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.ReportHome_DateRangeBox.ResumeLayout(false);
            this.ReportHome_DateRangeBox.PerformLayout();
            this.ReportHome_SelectionBox.ResumeLayout(false);
            this.ReportHome_SelectionBox.PerformLayout();
            this.ReportHome_ButtonBox.ResumeLayout(false);
            this.ReportHome_SelectRportBox.ResumeLayout(false);
            this.ReportHome_UserInfoBox.ResumeLayout(false);
            this.ReportHome_UserInfoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UseRep_AdminNameLbl;
        private System.Windows.Forms.Label UseRep_DateLbl;
        private System.Windows.Forms.GroupBox ReportHome_DateRangeBox;
        private System.Windows.Forms.Button ReportHome_GroupReportBtn;
        private System.Windows.Forms.DateTimePicker ReportHome_StartDate;
        private System.Windows.Forms.DateTimePicker ReportHome_EndDate;
        private System.Windows.Forms.Label ReportHome_EndDateLbl;
        private System.Windows.Forms.Label ReportHome_StartDateLbl;
        private System.Windows.Forms.Timer UseRep_Timer;
        private System.Windows.Forms.Label UseRep_TimeLbl;
        private System.Windows.Forms.Label ReportHome_WindowLbl;
        private System.Windows.Forms.GroupBox UseRep_UserInfoBox;
        private System.Windows.Forms.Button ReportHome_SingleReportBtn;
        private System.Windows.Forms.GroupBox ReportHome_SelectionBox;
        private System.Windows.Forms.Label ReportHome_GroupLbl;
        private System.Windows.Forms.ComboBox ReportHome_GroupDdl;
        private System.Windows.Forms.Label ReportHome_StudenLbl;
        private System.Windows.Forms.ComboBox ReportHome_StudentDdl;
        private System.Windows.Forms.GroupBox ReportHome_ButtonBox;
        private System.Windows.Forms.Button ReportHome_CloseBtn;
        private System.Windows.Forms.GroupBox ReportHome_SelectRportBox;
        private System.Windows.Forms.Button ReportHome_ExitBtn;
        private System.Windows.Forms.GroupBox ReportHome_UserInfoBox;
        private System.Windows.Forms.Label ReportHome_DateLbl;
        private System.Windows.Forms.Label ReportHome_AdminNameLbl;
        private System.Windows.Forms.Label ReportHome_TimeLbl;
    }
}