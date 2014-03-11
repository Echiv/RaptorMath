namespace RaptorMath
{
    partial class UseRep_Form
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
            this.UseRep_CloseBtn = new System.Windows.Forms.Button();
            this.UseRep_AdminNameLbl = new System.Windows.Forms.Label();
            this.UseRep_DateLbl = new System.Windows.Forms.Label();
            this.UseRep_SearchBox = new System.Windows.Forms.GroupBox();
            this.UseRep_StudentNameLbl = new System.Windows.Forms.Label();
            this.UseRep_SearchBtn = new System.Windows.Forms.Button();
            this.UseRep_StartDate = new System.Windows.Forms.DateTimePicker();
            this.UseRep_EndDate = new System.Windows.Forms.DateTimePicker();
            this.UseRep_EndDateLbl = new System.Windows.Forms.Label();
            this.UseRep_StartDateLbl = new System.Windows.Forms.Label();
            this.UseRep_Timer = new System.Windows.Forms.Timer(this.components);
            this.UseRep_TimeLbl = new System.Windows.Forms.Label();
            this.UseRep_DataDisplay = new System.Windows.Forms.DataGridView();
            this.DateTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseRep_WindowLbl = new System.Windows.Forms.Label();
            this.UseRep_ButtonBox = new System.Windows.Forms.GroupBox();
            this.UseRep_RecordBox = new System.Windows.Forms.GroupBox();
            this.UseRep_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.UseRep_SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UseRep_DataDisplay)).BeginInit();
            this.UseRep_ButtonBox.SuspendLayout();
            this.UseRep_UserInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UseRep_CloseBtn
            // 
            this.UseRep_CloseBtn.Location = new System.Drawing.Point(330, 13);
            this.UseRep_CloseBtn.Name = "UseRep_CloseBtn";
            this.UseRep_CloseBtn.Size = new System.Drawing.Size(56, 26);
            this.UseRep_CloseBtn.TabIndex = 6;
            this.UseRep_CloseBtn.Text = "Close";
            this.UseRep_CloseBtn.UseVisualStyleBackColor = true;
            this.UseRep_CloseBtn.Click += new System.EventHandler(this.UseRep_CloseBtn_Click);
            // 
            // UseRep_AdminNameLbl
            // 
            this.UseRep_AdminNameLbl.AutoSize = true;
            this.UseRep_AdminNameLbl.Location = new System.Drawing.Point(19, 39);
            this.UseRep_AdminNameLbl.Name = "UseRep_AdminNameLbl";
            this.UseRep_AdminNameLbl.Size = new System.Drawing.Size(48, 13);
            this.UseRep_AdminNameLbl.TabIndex = 2;
            this.UseRep_AdminNameLbl.Text = "<Admin>";
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
            // UseRep_SearchBox
            // 
            this.UseRep_SearchBox.Controls.Add(this.UseRep_StudentNameLbl);
            this.UseRep_SearchBox.Controls.Add(this.UseRep_SearchBtn);
            this.UseRep_SearchBox.Controls.Add(this.UseRep_StartDate);
            this.UseRep_SearchBox.Controls.Add(this.UseRep_EndDate);
            this.UseRep_SearchBox.Controls.Add(this.UseRep_EndDateLbl);
            this.UseRep_SearchBox.Controls.Add(this.UseRep_StartDateLbl);
            this.UseRep_SearchBox.Location = new System.Drawing.Point(15, 94);
            this.UseRep_SearchBox.Name = "UseRep_SearchBox";
            this.UseRep_SearchBox.Size = new System.Drawing.Size(407, 134);
            this.UseRep_SearchBox.TabIndex = 1;
            this.UseRep_SearchBox.TabStop = false;
            this.UseRep_SearchBox.Text = "Record Search";
            // 
            // UseRep_StudentNameLbl
            // 
            this.UseRep_StudentNameLbl.AutoSize = true;
            this.UseRep_StudentNameLbl.Location = new System.Drawing.Point(160, 16);
            this.UseRep_StudentNameLbl.Name = "UseRep_StudentNameLbl";
            this.UseRep_StudentNameLbl.Size = new System.Drawing.Size(87, 13);
            this.UseRep_StudentNameLbl.TabIndex = 20;
            this.UseRep_StudentNameLbl.Text = "<Student Name>";
            // 
            // UseRep_SearchBtn
            // 
            this.UseRep_SearchBtn.Location = new System.Drawing.Point(163, 96);
            this.UseRep_SearchBtn.Name = "UseRep_SearchBtn";
            this.UseRep_SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.UseRep_SearchBtn.TabIndex = 4;
            this.UseRep_SearchBtn.Text = "Search";
            this.UseRep_SearchBtn.UseVisualStyleBackColor = true;
            this.UseRep_SearchBtn.Click += new System.EventHandler(this.UseRep_SearchBtn_Click);
            // 
            // UseRep_StartDate
            // 
            this.UseRep_StartDate.Location = new System.Drawing.Point(124, 44);
            this.UseRep_StartDate.Name = "UseRep_StartDate";
            this.UseRep_StartDate.Size = new System.Drawing.Size(199, 20);
            this.UseRep_StartDate.TabIndex = 2;
            this.UseRep_StartDate.ValueChanged += new System.EventHandler(this.UseRep_StartDate_ValueChanged);
            // 
            // UseRep_EndDate
            // 
            this.UseRep_EndDate.Location = new System.Drawing.Point(124, 70);
            this.UseRep_EndDate.Name = "UseRep_EndDate";
            this.UseRep_EndDate.Size = new System.Drawing.Size(199, 20);
            this.UseRep_EndDate.TabIndex = 3;
            this.UseRep_EndDate.ValueChanged += new System.EventHandler(this.UseRep_EndDate_ValueChanged);
            // 
            // UseRep_EndDateLbl
            // 
            this.UseRep_EndDateLbl.AutoSize = true;
            this.UseRep_EndDateLbl.Location = new System.Drawing.Point(64, 72);
            this.UseRep_EndDateLbl.Name = "UseRep_EndDateLbl";
            this.UseRep_EndDateLbl.Size = new System.Drawing.Size(52, 13);
            this.UseRep_EndDateLbl.TabIndex = 24;
            this.UseRep_EndDateLbl.Text = "End Date";
            // 
            // UseRep_StartDateLbl
            // 
            this.UseRep_StartDateLbl.AutoSize = true;
            this.UseRep_StartDateLbl.Location = new System.Drawing.Point(62, 44);
            this.UseRep_StartDateLbl.Name = "UseRep_StartDateLbl";
            this.UseRep_StartDateLbl.Size = new System.Drawing.Size(55, 13);
            this.UseRep_StartDateLbl.TabIndex = 22;
            this.UseRep_StartDateLbl.Text = "Start Date";
            // 
            // UseRep_Timer
            // 
            this.UseRep_Timer.Enabled = true;
            this.UseRep_Timer.Interval = 1000;
            this.UseRep_Timer.Tick += new System.EventHandler(this.UseRep_Timer_Tick);
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
            // UseRep_DataDisplay
            // 
            this.UseRep_DataDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UseRep_DataDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UseRep_DataDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UseRep_DataDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTaken,
            this.Percent,
            this.Wrong,
            this.NumQuestions,
            this.Skipped,
            this.RangeStart,
            this.RangeEnd,
            this.Op});
            this.UseRep_DataDisplay.Location = new System.Drawing.Point(20, 246);
            this.UseRep_DataDisplay.Name = "UseRep_DataDisplay";
            this.UseRep_DataDisplay.RowHeadersVisible = false;
            this.UseRep_DataDisplay.Size = new System.Drawing.Size(396, 202);
            this.UseRep_DataDisplay.StandardTab = true;
            this.UseRep_DataDisplay.TabIndex = 8;
            this.UseRep_DataDisplay.TabStop = false;
            // 
            // DateTaken
            // 
            this.DateTaken.HeaderText = "DateTaken";
            this.DateTaken.Name = "DateTaken";
            this.DateTaken.ReadOnly = true;
            this.DateTaken.Width = 86;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "Percent";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Width = 69;
            // 
            // Wrong
            // 
            this.Wrong.HeaderText = "Wrong";
            this.Wrong.Name = "Wrong";
            this.Wrong.ReadOnly = true;
            this.Wrong.Width = 64;
            // 
            // NumQuestions
            // 
            this.NumQuestions.HeaderText = "Questions";
            this.NumQuestions.Name = "NumQuestions";
            this.NumQuestions.ReadOnly = true;
            this.NumQuestions.Width = 79;
            // 
            // Skipped
            // 
            this.Skipped.HeaderText = "Skipped";
            this.Skipped.Name = "Skipped";
            this.Skipped.ReadOnly = true;
            this.Skipped.Width = 71;
            // 
            // RangeStart
            // 
            this.RangeStart.HeaderText = "RangeStart";
            this.RangeStart.Name = "RangeStart";
            this.RangeStart.ReadOnly = true;
            this.RangeStart.Width = 86;
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
            // UseRep_WindowLbl
            // 
            this.UseRep_WindowLbl.AutoSize = true;
            this.UseRep_WindowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseRep_WindowLbl.Location = new System.Drawing.Point(19, 16);
            this.UseRep_WindowLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UseRep_WindowLbl.Name = "UseRep_WindowLbl";
            this.UseRep_WindowLbl.Size = new System.Drawing.Size(75, 13);
            this.UseRep_WindowLbl.TabIndex = 33;
            this.UseRep_WindowLbl.Text = "User Report";
            // 
            // UseRep_ButtonBox
            // 
            this.UseRep_ButtonBox.Controls.Add(this.UseRep_CloseBtn);
            this.UseRep_ButtonBox.Location = new System.Drawing.Point(14, 455);
            this.UseRep_ButtonBox.Name = "UseRep_ButtonBox";
            this.UseRep_ButtonBox.Size = new System.Drawing.Size(408, 45);
            this.UseRep_ButtonBox.TabIndex = 5;
            this.UseRep_ButtonBox.TabStop = false;
            // 
            // UseRep_RecordBox
            // 
            this.UseRep_RecordBox.Location = new System.Drawing.Point(12, 228);
            this.UseRep_RecordBox.Name = "UseRep_RecordBox";
            this.UseRep_RecordBox.Size = new System.Drawing.Size(410, 228);
            this.UseRep_RecordBox.TabIndex = 7;
            this.UseRep_RecordBox.TabStop = false;
            this.UseRep_RecordBox.Text = "Drill Records";
            // 
            // UseRep_UserInfoBox
            // 
            this.UseRep_UserInfoBox.Controls.Add(this.UseRep_DateLbl);
            this.UseRep_UserInfoBox.Controls.Add(this.UseRep_TimeLbl);
            this.UseRep_UserInfoBox.Location = new System.Drawing.Point(12, 3);
            this.UseRep_UserInfoBox.Name = "UseRep_UserInfoBox";
            this.UseRep_UserInfoBox.Size = new System.Drawing.Size(410, 81);
            this.UseRep_UserInfoBox.TabIndex = 0;
            this.UseRep_UserInfoBox.TabStop = false;
            // 
            // UseRep_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 512);
            this.ControlBox = false;
            this.Controls.Add(this.UseRep_SearchBox);
            this.Controls.Add(this.UseRep_WindowLbl);
            this.Controls.Add(this.UseRep_DataDisplay);
            this.Controls.Add(this.UseRep_AdminNameLbl);
            this.Controls.Add(this.UseRep_ButtonBox);
            this.Controls.Add(this.UseRep_RecordBox);
            this.Controls.Add(this.UseRep_UserInfoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UseRep_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.UseRep_SearchBox.ResumeLayout(false);
            this.UseRep_SearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UseRep_DataDisplay)).EndInit();
            this.UseRep_ButtonBox.ResumeLayout(false);
            this.UseRep_UserInfoBox.ResumeLayout(false);
            this.UseRep_UserInfoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UseRep_CloseBtn;
        private System.Windows.Forms.Label UseRep_AdminNameLbl;
        private System.Windows.Forms.Label UseRep_DateLbl;
        private System.Windows.Forms.GroupBox UseRep_SearchBox;
        private System.Windows.Forms.Label UseRep_StudentNameLbl;
        private System.Windows.Forms.Button UseRep_SearchBtn;
        private System.Windows.Forms.DateTimePicker UseRep_StartDate;
        private System.Windows.Forms.DateTimePicker UseRep_EndDate;
        private System.Windows.Forms.Label UseRep_EndDateLbl;
        private System.Windows.Forms.Label UseRep_StartDateLbl;
        private System.Windows.Forms.Timer UseRep_Timer;
        private System.Windows.Forms.Label UseRep_TimeLbl;
        private System.Windows.Forms.DataGridView UseRep_DataDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Op;
        private System.Windows.Forms.Label UseRep_WindowLbl;
        private System.Windows.Forms.GroupBox UseRep_ButtonBox;
        private System.Windows.Forms.GroupBox UseRep_RecordBox;
        private System.Windows.Forms.GroupBox UseRep_UserInfoBox;
    }
}