﻿namespace RaptorMath
{
    partial class ReportHome_Form
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
            this.GroupReport_CloseBtn = new System.Windows.Forms.Button();
            this.UseRep_Timer = new System.Windows.Forms.Timer(this.components);
            this.GroupReport_DataDisplay = new System.Windows.Forms.DataGridView();
            this.DateTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupReport_ButtonBox = new System.Windows.Forms.GroupBox();
            this.GroupReport_DrillBox = new System.Windows.Forms.GroupBox();
            this.GroupReport_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.GroupReport_GroupNameLbl = new System.Windows.Forms.Label();
            this.GroupReport_DateLbl = new System.Windows.Forms.Label();
            this.GroupReport_TimeLbl = new System.Windows.Forms.Label();
            this.GroupReport_WindowLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GroupReport_DataDisplay)).BeginInit();
            this.GroupReport_ButtonBox.SuspendLayout();
            this.GroupReport_UserInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupReport_CloseBtn
            // 
            this.GroupReport_CloseBtn.Location = new System.Drawing.Point(330, 13);
            this.GroupReport_CloseBtn.Name = "GroupReport_CloseBtn";
            this.GroupReport_CloseBtn.Size = new System.Drawing.Size(56, 26);
            this.GroupReport_CloseBtn.TabIndex = 1;
            this.GroupReport_CloseBtn.Text = "Close";
            this.GroupReport_CloseBtn.UseVisualStyleBackColor = true;
            // 
            // UseRep_Timer
            // 
            this.UseRep_Timer.Enabled = true;
            this.UseRep_Timer.Interval = 1000;
            // 
            // GroupReport_DataDisplay
            // 
            this.GroupReport_DataDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GroupReport_DataDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GroupReport_DataDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GroupReport_DataDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTaken,
            this.Percent,
            this.Wrong,
            this.NumQuestions,
            this.Skipped,
            this.RangeStart,
            this.RangeEnd,
            this.Op});
            this.GroupReport_DataDisplay.Location = new System.Drawing.Point(20, 136);
            this.GroupReport_DataDisplay.Name = "GroupReport_DataDisplay";
            this.GroupReport_DataDisplay.RowHeadersVisible = false;
            this.GroupReport_DataDisplay.Size = new System.Drawing.Size(396, 312);
            this.GroupReport_DataDisplay.TabIndex = 0;
            // 
            // DateTaken
            // 
            this.DateTaken.HeaderText = "TBD";
            this.DateTaken.Name = "DateTaken";
            this.DateTaken.ReadOnly = true;
            this.DateTaken.Width = 54;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "TBD";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Width = 54;
            // 
            // Wrong
            // 
            this.Wrong.HeaderText = "TBD";
            this.Wrong.Name = "Wrong";
            this.Wrong.ReadOnly = true;
            this.Wrong.Width = 54;
            // 
            // NumQuestions
            // 
            this.NumQuestions.HeaderText = "TBD";
            this.NumQuestions.Name = "NumQuestions";
            this.NumQuestions.ReadOnly = true;
            this.NumQuestions.Width = 54;
            // 
            // Skipped
            // 
            this.Skipped.HeaderText = "TBD";
            this.Skipped.Name = "Skipped";
            this.Skipped.ReadOnly = true;
            this.Skipped.Width = 54;
            // 
            // RangeStart
            // 
            this.RangeStart.HeaderText = "TBD";
            this.RangeStart.Name = "RangeStart";
            this.RangeStart.ReadOnly = true;
            this.RangeStart.Width = 54;
            // 
            // RangeEnd
            // 
            this.RangeEnd.HeaderText = "RangeEnd";
            this.RangeEnd.Name = "RangeEnd";
            this.RangeEnd.ReadOnly = true;
            this.RangeEnd.Width = 83;
            // 
            // Op
            // 
            this.Op.HeaderText = "Op";
            this.Op.Name = "Op";
            this.Op.ReadOnly = true;
            this.Op.Width = 46;
            // 
            // GroupReport_ButtonBox
            // 
            this.GroupReport_ButtonBox.Controls.Add(this.GroupReport_CloseBtn);
            this.GroupReport_ButtonBox.Location = new System.Drawing.Point(14, 455);
            this.GroupReport_ButtonBox.Name = "GroupReport_ButtonBox";
            this.GroupReport_ButtonBox.Size = new System.Drawing.Size(408, 45);
            this.GroupReport_ButtonBox.TabIndex = 34;
            this.GroupReport_ButtonBox.TabStop = false;
            // 
            // GroupReport_DrillBox
            // 
            this.GroupReport_DrillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupReport_DrillBox.Location = new System.Drawing.Point(12, 95);
            this.GroupReport_DrillBox.Name = "GroupReport_DrillBox";
            this.GroupReport_DrillBox.Size = new System.Drawing.Size(410, 361);
            this.GroupReport_DrillBox.TabIndex = 35;
            this.GroupReport_DrillBox.TabStop = false;
            this.GroupReport_DrillBox.Text = "Drill Records";
            // 
            // GroupReport_UserInfoBox
            // 
            this.GroupReport_UserInfoBox.Controls.Add(this.GroupReport_GroupNameLbl);
            this.GroupReport_UserInfoBox.Controls.Add(this.GroupReport_DateLbl);
            this.GroupReport_UserInfoBox.Controls.Add(this.GroupReport_TimeLbl);
            this.GroupReport_UserInfoBox.Location = new System.Drawing.Point(14, 31);
            this.GroupReport_UserInfoBox.Name = "GroupReport_UserInfoBox";
            this.GroupReport_UserInfoBox.Size = new System.Drawing.Size(410, 58);
            this.GroupReport_UserInfoBox.TabIndex = 37;
            this.GroupReport_UserInfoBox.TabStop = false;
            // 
            // GroupReport_GroupNameLbl
            // 
            this.GroupReport_GroupNameLbl.AutoSize = true;
            this.GroupReport_GroupNameLbl.Location = new System.Drawing.Point(6, 16);
            this.GroupReport_GroupNameLbl.Name = "GroupReport_GroupNameLbl";
            this.GroupReport_GroupNameLbl.Size = new System.Drawing.Size(79, 13);
            this.GroupReport_GroupNameLbl.TabIndex = 37;
            this.GroupReport_GroupNameLbl.Text = "<Group Name>";
            // 
            // GroupReport_DateLbl
            // 
            this.GroupReport_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupReport_DateLbl.AutoSize = true;
            this.GroupReport_DateLbl.Location = new System.Drawing.Point(346, 16);
            this.GroupReport_DateLbl.Name = "GroupReport_DateLbl";
            this.GroupReport_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.GroupReport_DateLbl.TabIndex = 35;
            this.GroupReport_DateLbl.Text = "<Date>";
            // 
            // GroupReport_TimeLbl
            // 
            this.GroupReport_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupReport_TimeLbl.AutoSize = true;
            this.GroupReport_TimeLbl.Location = new System.Drawing.Point(346, 39);
            this.GroupReport_TimeLbl.Name = "GroupReport_TimeLbl";
            this.GroupReport_TimeLbl.Size = new System.Drawing.Size(42, 13);
            this.GroupReport_TimeLbl.TabIndex = 34;
            this.GroupReport_TimeLbl.Text = "<Time>";
            // 
            // GroupReport_WindowLbl
            // 
            this.GroupReport_WindowLbl.AutoSize = true;
            this.GroupReport_WindowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupReport_WindowLbl.Location = new System.Drawing.Point(187, 9);
            this.GroupReport_WindowLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GroupReport_WindowLbl.Name = "GroupReport_WindowLbl";
            this.GroupReport_WindowLbl.Size = new System.Drawing.Size(83, 13);
            this.GroupReport_WindowLbl.TabIndex = 33;
            this.GroupReport_WindowLbl.Text = "Group Report";
            // 
            // GroupReport_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 512);
            this.Controls.Add(this.GroupReport_UserInfoBox);
            this.Controls.Add(this.GroupReport_DataDisplay);
            this.Controls.Add(this.GroupReport_ButtonBox);
            this.Controls.Add(this.GroupReport_WindowLbl);
            this.Controls.Add(this.GroupReport_DrillBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GroupReport_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            ((System.ComponentModel.ISupportInitialize)(this.GroupReport_DataDisplay)).EndInit();
            this.GroupReport_ButtonBox.ResumeLayout(false);
            this.GroupReport_UserInfoBox.ResumeLayout(false);
            this.GroupReport_UserInfoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GroupReport_CloseBtn;
        private System.Windows.Forms.Timer UseRep_Timer;
        private System.Windows.Forms.DataGridView GroupReport_DataDisplay;
        private System.Windows.Forms.GroupBox GroupReport_ButtonBox;
        private System.Windows.Forms.GroupBox GroupReport_DrillBox;
        private System.Windows.Forms.GroupBox GroupReport_UserInfoBox;
        private System.Windows.Forms.Label GroupReport_WindowLbl;
        private System.Windows.Forms.Label GroupReport_DateLbl;
        private System.Windows.Forms.Label GroupReport_TimeLbl;
        private System.Windows.Forms.Label GroupReport_GroupNameLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Op;
    }
}