namespace RaptorMath
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
            this.SingleReport__GroupNameLbl = new System.Windows.Forms.Label();
            this.SingleReport_TimeLbl = new System.Windows.Forms.Label();
            this.SingleReport_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.SingleReport_DateLbl = new System.Windows.Forms.Label();
            this.GroupReport_WindowLbl = new System.Windows.Forms.Label();
            this.SingleReport_ButtonBox = new System.Windows.Forms.GroupBox();
            this.SingleReport_GroupReportBtn = new System.Windows.Forms.Button();
            this.SingleReport_CloseBtn = new System.Windows.Forms.Button();
            this.SingleReport_DrillBox = new System.Windows.Forms.GroupBox();
            this.SingleReport_DataDisplay = new System.Windows.Forms.DataGridView();
            this.DateTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingleReport_Timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SingleReport_UserInfoBox.SuspendLayout();
            this.SingleReport_ButtonBox.SuspendLayout();
            this.SingleReport_DrillBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingleReport_DataDisplay)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SingleReport__GroupNameLbl
            // 
            this.SingleReport__GroupNameLbl.AutoSize = true;
            this.SingleReport__GroupNameLbl.Location = new System.Drawing.Point(7, 48);
            this.SingleReport__GroupNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SingleReport__GroupNameLbl.Name = "SingleReport__GroupNameLbl";
            this.SingleReport__GroupNameLbl.Size = new System.Drawing.Size(114, 17);
            this.SingleReport__GroupNameLbl.TabIndex = 37;
            this.SingleReport__GroupNameLbl.Text = "<Student Name>";
            // 
            // SingleReport_TimeLbl
            // 
            this.SingleReport_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleReport_TimeLbl.AutoSize = true;
            this.SingleReport_TimeLbl.Location = new System.Drawing.Point(477, 47);
            this.SingleReport_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SingleReport_TimeLbl.Name = "SingleReport_TimeLbl";
            this.SingleReport_TimeLbl.Size = new System.Drawing.Size(55, 17);
            this.SingleReport_TimeLbl.TabIndex = 34;
            this.SingleReport_TimeLbl.Text = "<Time>";
            this.SingleReport_TimeLbl.Click += new System.EventHandler(this.SingleReport_TimeLbl_Click);
            // 
            // SingleReport_UserInfoBox
            // 
            this.SingleReport_UserInfoBox.Controls.Add(this.SingleReport__GroupNameLbl);
            this.SingleReport_UserInfoBox.Controls.Add(this.SingleReport_DateLbl);
            this.SingleReport_UserInfoBox.Controls.Add(this.SingleReport_TimeLbl);
            this.SingleReport_UserInfoBox.Controls.Add(this.GroupReport_WindowLbl);
            this.SingleReport_UserInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SingleReport_UserInfoBox.Location = new System.Drawing.Point(4, 4);
            this.SingleReport_UserInfoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SingleReport_UserInfoBox.Name = "SingleReport_UserInfoBox";
            this.SingleReport_UserInfoBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SingleReport_UserInfoBox.Size = new System.Drawing.Size(554, 100);
            this.SingleReport_UserInfoBox.TabIndex = 42;
            this.SingleReport_UserInfoBox.TabStop = false;
            // 
            // SingleReport_DateLbl
            // 
            this.SingleReport_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleReport_DateLbl.AutoSize = true;
            this.SingleReport_DateLbl.Location = new System.Drawing.Point(477, 19);
            this.SingleReport_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SingleReport_DateLbl.Name = "SingleReport_DateLbl";
            this.SingleReport_DateLbl.Size = new System.Drawing.Size(54, 17);
            this.SingleReport_DateLbl.TabIndex = 35;
            this.SingleReport_DateLbl.Text = "<Date>";
            this.SingleReport_DateLbl.Click += new System.EventHandler(this.SingleReport_DateLbl_Click);
            // 
            // GroupReport_WindowLbl
            // 
            this.GroupReport_WindowLbl.AutoSize = true;
            this.GroupReport_WindowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupReport_WindowLbl.Location = new System.Drawing.Point(7, 18);
            this.GroupReport_WindowLbl.Name = "GroupReport_WindowLbl";
            this.GroupReport_WindowLbl.Size = new System.Drawing.Size(107, 17);
            this.GroupReport_WindowLbl.TabIndex = 39;
            this.GroupReport_WindowLbl.Text = "Single Report";
            // 
            // SingleReport_ButtonBox
            // 
            this.SingleReport_ButtonBox.Controls.Add(this.SingleReport_GroupReportBtn);
            this.SingleReport_ButtonBox.Controls.Add(this.SingleReport_CloseBtn);
            this.SingleReport_ButtonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SingleReport_ButtonBox.Location = new System.Drawing.Point(4, 452);
            this.SingleReport_ButtonBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SingleReport_ButtonBox.Name = "SingleReport_ButtonBox";
            this.SingleReport_ButtonBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SingleReport_ButtonBox.Size = new System.Drawing.Size(554, 47);
            this.SingleReport_ButtonBox.TabIndex = 40;
            this.SingleReport_ButtonBox.TabStop = false;
            // 
            // SingleReport_GroupReportBtn
            // 
            this.SingleReport_GroupReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleReport_GroupReportBtn.Location = new System.Drawing.Point(289, 11);
            this.SingleReport_GroupReportBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SingleReport_GroupReportBtn.Name = "SingleReport_GroupReportBtn";
            this.SingleReport_GroupReportBtn.Size = new System.Drawing.Size(124, 28);
            this.SingleReport_GroupReportBtn.TabIndex = 2;
            this.SingleReport_GroupReportBtn.Text = "Group Report";
            this.SingleReport_GroupReportBtn.UseVisualStyleBackColor = true;
            // 
            // SingleReport_CloseBtn
            // 
            this.SingleReport_CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleReport_CloseBtn.Location = new System.Drawing.Point(421, 11);
            this.SingleReport_CloseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SingleReport_CloseBtn.Name = "SingleReport_CloseBtn";
            this.SingleReport_CloseBtn.Size = new System.Drawing.Size(124, 27);
            this.SingleReport_CloseBtn.TabIndex = 1;
            this.SingleReport_CloseBtn.Text = "Close";
            this.SingleReport_CloseBtn.UseVisualStyleBackColor = true;
            this.SingleReport_CloseBtn.Click += new System.EventHandler(this.SingleReport_CloseBtn_Click);
            // 
            // SingleReport_DrillBox
            // 
            this.SingleReport_DrillBox.Controls.Add(this.SingleReport_DataDisplay);
            this.SingleReport_DrillBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SingleReport_DrillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleReport_DrillBox.Location = new System.Drawing.Point(4, 112);
            this.SingleReport_DrillBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SingleReport_DrillBox.Name = "SingleReport_DrillBox";
            this.SingleReport_DrillBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SingleReport_DrillBox.Size = new System.Drawing.Size(554, 332);
            this.SingleReport_DrillBox.TabIndex = 41;
            this.SingleReport_DrillBox.TabStop = false;
            this.SingleReport_DrillBox.Text = "Drill Records";
            // 
            // SingleReport_DataDisplay
            // 
            this.SingleReport_DataDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SingleReport_DataDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SingleReport_DataDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SingleReport_DataDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTaken,
            this.Percent,
            this.Wrong,
            this.NumQuestions,
            this.Skipped,
            this.RangeStart});
            this.SingleReport_DataDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SingleReport_DataDisplay.Location = new System.Drawing.Point(5, 22);
            this.SingleReport_DataDisplay.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SingleReport_DataDisplay.Name = "SingleReport_DataDisplay";
            this.SingleReport_DataDisplay.RowHeadersVisible = false;
            this.SingleReport_DataDisplay.Size = new System.Drawing.Size(544, 304);
            this.SingleReport_DataDisplay.TabIndex = 38;
            // 
            // DateTaken
            // 
            this.DateTaken.HeaderText = "Date Taken";
            this.DateTaken.Name = "DateTaken";
            this.DateTaken.ReadOnly = true;
            this.DateTaken.Width = 117;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "Total Time";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Width = 110;
            // 
            // Wrong
            // 
            this.Wrong.HeaderText = "Questions";
            this.Wrong.Name = "Wrong";
            this.Wrong.ReadOnly = true;
            this.Wrong.Width = 106;
            // 
            // NumQuestions
            // 
            this.NumQuestions.HeaderText = "Percent";
            this.NumQuestions.Name = "NumQuestions";
            this.NumQuestions.ReadOnly = true;
            this.NumQuestions.Width = 89;
            // 
            // Skipped
            // 
            this.Skipped.HeaderText = "Wrong";
            this.Skipped.Name = "Skipped";
            this.Skipped.ReadOnly = true;
            this.Skipped.Width = 80;
            // 
            // RangeStart
            // 
            this.RangeStart.HeaderText = "Skipped";
            this.RangeStart.Name = "RangeStart";
            this.RangeStart.ReadOnly = true;
            this.RangeStart.Width = 91;
            // 
            // SingleReport_Timer
            // 
            this.SingleReport_Timer.Enabled = true;
            this.SingleReport_Timer.Interval = 1000;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

        private System.Windows.Forms.Label SingleReport__GroupNameLbl;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeStart;
        private System.Windows.Forms.Button SingleReport_GroupReportBtn;
    }
}