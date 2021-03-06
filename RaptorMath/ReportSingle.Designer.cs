﻿namespace RaptorMath
{
    partial class SingleReport_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleReport_Form));
            this.SingleReport__StudentNameLbl = new System.Windows.Forms.Label();
            this.SingleReport_TimeLbl = new System.Windows.Forms.Label();
            this.SingleReport_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.SingleReport_DateLbl = new System.Windows.Forms.Label();
            this.GroupReport_WindowLbl = new System.Windows.Forms.Label();
            this.SingleReport_ButtonBox = new System.Windows.Forms.GroupBox();
            this.SingleReport_ExcelBtn = new System.Windows.Forms.Button();
            this.SingleReport_CloseBtn = new System.Windows.Forms.Button();
            this.SingleReport_DrillBox = new System.Windows.Forms.GroupBox();
            this.SingleReport_DataDisplay = new System.Windows.Forms.DataGridView();
            this.DrillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Questions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingleReport_Timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SingleReport_UserInfoBox.SuspendLayout();
            this.SingleReport_ButtonBox.SuspendLayout();
            this.SingleReport_DrillBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingleReport_DataDisplay)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SingleReport__StudentNameLbl
            // 
            this.SingleReport__StudentNameLbl.AutoSize = true;
            this.SingleReport__StudentNameLbl.Location = new System.Drawing.Point(7, 48);
            this.SingleReport__StudentNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SingleReport__StudentNameLbl.Name = "SingleReport__StudentNameLbl";
            this.SingleReport__StudentNameLbl.Size = new System.Drawing.Size(87, 13);
            this.SingleReport__StudentNameLbl.TabIndex = 37;
            this.SingleReport__StudentNameLbl.Text = "<Student Name>";
            // 
            // SingleReport_TimeLbl
            // 
            this.SingleReport_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleReport_TimeLbl.AutoSize = true;
            this.SingleReport_TimeLbl.Location = new System.Drawing.Point(477, 47);
            this.SingleReport_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SingleReport_TimeLbl.Name = "SingleReport_TimeLbl";
            this.SingleReport_TimeLbl.Size = new System.Drawing.Size(42, 13);
            this.SingleReport_TimeLbl.TabIndex = 34;
            this.SingleReport_TimeLbl.Text = "<Time>";
            // 
            // SingleReport_UserInfoBox
            // 
            this.SingleReport_UserInfoBox.Controls.Add(this.SingleReport__StudentNameLbl);
            this.SingleReport_UserInfoBox.Controls.Add(this.SingleReport_DateLbl);
            this.SingleReport_UserInfoBox.Controls.Add(this.SingleReport_TimeLbl);
            this.SingleReport_UserInfoBox.Controls.Add(this.GroupReport_WindowLbl);
            this.SingleReport_UserInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SingleReport_UserInfoBox.Location = new System.Drawing.Point(4, 4);
            this.SingleReport_UserInfoBox.Margin = new System.Windows.Forms.Padding(4);
            this.SingleReport_UserInfoBox.Name = "SingleReport_UserInfoBox";
            this.SingleReport_UserInfoBox.Padding = new System.Windows.Forms.Padding(4);
            this.SingleReport_UserInfoBox.Size = new System.Drawing.Size(554, 100);
            this.SingleReport_UserInfoBox.TabIndex = 0;
            this.SingleReport_UserInfoBox.TabStop = false;
            // 
            // SingleReport_DateLbl
            // 
            this.SingleReport_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleReport_DateLbl.AutoSize = true;
            this.SingleReport_DateLbl.Location = new System.Drawing.Point(477, 19);
            this.SingleReport_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SingleReport_DateLbl.Name = "SingleReport_DateLbl";
            this.SingleReport_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.SingleReport_DateLbl.TabIndex = 35;
            this.SingleReport_DateLbl.Text = "<Date>";
            // 
            // GroupReport_WindowLbl
            // 
            this.GroupReport_WindowLbl.AutoSize = true;
            this.GroupReport_WindowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupReport_WindowLbl.Location = new System.Drawing.Point(7, 18);
            this.GroupReport_WindowLbl.Name = "GroupReport_WindowLbl";
            this.GroupReport_WindowLbl.Size = new System.Drawing.Size(84, 13);
            this.GroupReport_WindowLbl.TabIndex = 39;
            this.GroupReport_WindowLbl.Text = "Single Report";
            // 
            // SingleReport_ButtonBox
            // 
            this.SingleReport_ButtonBox.Controls.Add(this.SingleReport_ExcelBtn);
            this.SingleReport_ButtonBox.Controls.Add(this.SingleReport_CloseBtn);
            this.SingleReport_ButtonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SingleReport_ButtonBox.Location = new System.Drawing.Point(4, 452);
            this.SingleReport_ButtonBox.Margin = new System.Windows.Forms.Padding(4);
            this.SingleReport_ButtonBox.Name = "SingleReport_ButtonBox";
            this.SingleReport_ButtonBox.Padding = new System.Windows.Forms.Padding(4);
            this.SingleReport_ButtonBox.Size = new System.Drawing.Size(554, 47);
            this.SingleReport_ButtonBox.TabIndex = 2;
            this.SingleReport_ButtonBox.TabStop = false;
            // 
            // SingleReport_ExcelBtn
            // 
            this.SingleReport_ExcelBtn.Location = new System.Drawing.Point(280, 11);
            this.SingleReport_ExcelBtn.Name = "SingleReport_ExcelBtn";
            this.SingleReport_ExcelBtn.Size = new System.Drawing.Size(123, 27);
            this.SingleReport_ExcelBtn.TabIndex = 1;
            this.SingleReport_ExcelBtn.Text = "Export to Excel";
            this.SingleReport_ExcelBtn.UseVisualStyleBackColor = true;
            this.SingleReport_ExcelBtn.Click += new System.EventHandler(this.SingleReport_Excel_Click);
            // 
            // SingleReport_CloseBtn
            // 
            this.SingleReport_CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleReport_CloseBtn.Location = new System.Drawing.Point(421, 11);
            this.SingleReport_CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SingleReport_CloseBtn.Name = "SingleReport_CloseBtn";
            this.SingleReport_CloseBtn.Size = new System.Drawing.Size(124, 27);
            this.SingleReport_CloseBtn.TabIndex = 0;
            this.SingleReport_CloseBtn.Text = "Close";
            this.toolTip1.SetToolTip(this.SingleReport_CloseBtn, "Return to the student reports homepage.");
            this.SingleReport_CloseBtn.UseVisualStyleBackColor = true;
            this.SingleReport_CloseBtn.Click += new System.EventHandler(this.SingleReport_CloseBtn_Click);
            // 
            // SingleReport_DrillBox
            // 
            this.SingleReport_DrillBox.Controls.Add(this.SingleReport_DataDisplay);
            this.SingleReport_DrillBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SingleReport_DrillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleReport_DrillBox.Location = new System.Drawing.Point(4, 112);
            this.SingleReport_DrillBox.Margin = new System.Windows.Forms.Padding(4);
            this.SingleReport_DrillBox.Name = "SingleReport_DrillBox";
            this.SingleReport_DrillBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SingleReport_DrillBox.Size = new System.Drawing.Size(554, 332);
            this.SingleReport_DrillBox.TabIndex = 1;
            this.SingleReport_DrillBox.TabStop = false;
            this.SingleReport_DrillBox.Text = "Drill Records";
            // 
            // SingleReport_DataDisplay
            // 
            this.SingleReport_DataDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SingleReport_DataDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SingleReport_DataDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SingleReport_DataDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrillName,
            this.DateTaken,
            this.Questions,
            this.Percent,
            this.Skipped});
            this.SingleReport_DataDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SingleReport_DataDisplay.Location = new System.Drawing.Point(5, 19);
            this.SingleReport_DataDisplay.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SingleReport_DataDisplay.Name = "SingleReport_DataDisplay";
            this.SingleReport_DataDisplay.RowHeadersVisible = false;
            this.SingleReport_DataDisplay.Size = new System.Drawing.Size(544, 307);
            this.SingleReport_DataDisplay.TabIndex = 0;
            // 
            // DrillName
            // 
            this.DrillName.HeaderText = "Drill Name";
            this.DrillName.Name = "DrillName";
            this.DrillName.ReadOnly = true;
            this.DrillName.Width = 90;
            // 
            // DateTaken
            // 
            this.DateTaken.HeaderText = "Date Taken";
            this.DateTaken.Name = "DateTaken";
            this.DateTaken.ReadOnly = true;
            this.DateTaken.Width = 99;
            // 
            // Questions
            // 
            this.Questions.HeaderText = "# Questions";
            this.Questions.Name = "Questions";
            this.Questions.ReadOnly = true;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "% Correct";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Width = 86;
            // 
            // Skipped
            // 
            this.Skipped.HeaderText = "Skipped";
            this.Skipped.Name = "Skipped";
            this.Skipped.ReadOnly = true;
            this.Skipped.Width = 78;
            // 
            // SingleReport_Timer
            // 
            this.SingleReport_Timer.Enabled = true;
            this.SingleReport_Timer.Interval = 1000;
            this.SingleReport_Timer.Tick += new System.EventHandler(this.SingleReport_Timer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SingleReport_ButtonBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SingleReport_UserInfoBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SingleReport_DrillBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.10714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.89286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 503);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // SingleReport_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(562, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SingleReport_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.SingleReport_UserInfoBox.ResumeLayout(false);
            this.SingleReport_UserInfoBox.PerformLayout();
            this.SingleReport_ButtonBox.ResumeLayout(false);
            this.SingleReport_DrillBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SingleReport_DataDisplay)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SingleReport__StudentNameLbl;
        private System.Windows.Forms.Label SingleReport_TimeLbl;
        private System.Windows.Forms.GroupBox SingleReport_UserInfoBox;
        private System.Windows.Forms.Label SingleReport_DateLbl;
        private System.Windows.Forms.GroupBox SingleReport_ButtonBox;
        private System.Windows.Forms.Button SingleReport_CloseBtn;
        private System.Windows.Forms.GroupBox SingleReport_DrillBox;
        private System.Windows.Forms.DataGridView SingleReport_DataDisplay;
        private System.Windows.Forms.Timer SingleReport_Timer;
        private System.Windows.Forms.Label GroupReport_WindowLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Questions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skipped;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button SingleReport_ExcelBtn;
    }
}