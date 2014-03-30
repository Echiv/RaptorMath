namespace RaptorMath
{
    partial class ReportGroup_Form
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
            this.GroupReport_Timer = new System.Windows.Forms.Timer(this.components);
            this.GroupReport_DataDisplay = new System.Windows.Forms.DataGridView();
            this.GroupReport_ButtonBox = new System.Windows.Forms.GroupBox();
            this.GroupReport_DrillBox = new System.Windows.Forms.GroupBox();
            this.GroupReport_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.GroupReport_GroupNameLbl = new System.Windows.Forms.Label();
            this.GroupReport_DateLbl = new System.Windows.Forms.Label();
            this.GroupReport_TimeLbl = new System.Windows.Forms.Label();
            this.GroupReport_WindowLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DateTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GroupReport_DataDisplay)).BeginInit();
            this.GroupReport_ButtonBox.SuspendLayout();
            this.GroupReport_DrillBox.SuspendLayout();
            this.GroupReport_UserInfoBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupReport_CloseBtn
            // 
            this.GroupReport_CloseBtn.Location = new System.Drawing.Point(226, 14);
            this.GroupReport_CloseBtn.Name = "GroupReport_CloseBtn";
            this.GroupReport_CloseBtn.Size = new System.Drawing.Size(86, 22);
            this.GroupReport_CloseBtn.TabIndex = 1;
            this.GroupReport_CloseBtn.Text = "Close";
            this.GroupReport_CloseBtn.UseVisualStyleBackColor = true;
            // 
            // GroupReport_Timer
            // 
            this.GroupReport_Timer.Enabled = true;
            this.GroupReport_Timer.Interval = 1000;
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
            this.RangeStart});
            this.GroupReport_DataDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupReport_DataDisplay.Location = new System.Drawing.Point(4, 18);
            this.GroupReport_DataDisplay.Name = "GroupReport_DataDisplay";
            this.GroupReport_DataDisplay.RowHeadersVisible = false;
            this.GroupReport_DataDisplay.Size = new System.Drawing.Size(550, 352);
            this.GroupReport_DataDisplay.TabIndex = 0;
            // 
            // GroupReport_ButtonBox
            // 
            this.GroupReport_ButtonBox.Controls.Add(this.GroupReport_CloseBtn);
            this.GroupReport_ButtonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupReport_ButtonBox.Location = new System.Drawing.Point(3, 470);
            this.GroupReport_ButtonBox.Name = "GroupReport_ButtonBox";
            this.GroupReport_ButtonBox.Size = new System.Drawing.Size(558, 39);
            this.GroupReport_ButtonBox.TabIndex = 34;
            this.GroupReport_ButtonBox.TabStop = false;
            // 
            // GroupReport_DrillBox
            // 
            this.GroupReport_DrillBox.Controls.Add(this.GroupReport_DataDisplay);
            this.GroupReport_DrillBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupReport_DrillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupReport_DrillBox.Location = new System.Drawing.Point(3, 89);
            this.GroupReport_DrillBox.Name = "GroupReport_DrillBox";
            this.GroupReport_DrillBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupReport_DrillBox.Size = new System.Drawing.Size(558, 375);
            this.GroupReport_DrillBox.TabIndex = 35;
            this.GroupReport_DrillBox.TabStop = false;
            this.GroupReport_DrillBox.Text = "Drill Records";
            // 
            // GroupReport_UserInfoBox
            // 
            this.GroupReport_UserInfoBox.Controls.Add(this.GroupReport_GroupNameLbl);
            this.GroupReport_UserInfoBox.Controls.Add(this.GroupReport_DateLbl);
            this.GroupReport_UserInfoBox.Controls.Add(this.GroupReport_TimeLbl);
            this.GroupReport_UserInfoBox.Controls.Add(this.GroupReport_WindowLbl);
            this.GroupReport_UserInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupReport_UserInfoBox.Location = new System.Drawing.Point(3, 3);
            this.GroupReport_UserInfoBox.Name = "GroupReport_UserInfoBox";
            this.GroupReport_UserInfoBox.Size = new System.Drawing.Size(558, 80);
            this.GroupReport_UserInfoBox.TabIndex = 37;
            this.GroupReport_UserInfoBox.TabStop = false;
            // 
            // GroupReport_GroupNameLbl
            // 
            this.GroupReport_GroupNameLbl.AutoSize = true;
            this.GroupReport_GroupNameLbl.Location = new System.Drawing.Point(6, 32);
            this.GroupReport_GroupNameLbl.Name = "GroupReport_GroupNameLbl";
            this.GroupReport_GroupNameLbl.Size = new System.Drawing.Size(79, 13);
            this.GroupReport_GroupNameLbl.TabIndex = 37;
            this.GroupReport_GroupNameLbl.Text = "<Group Name>";
            // 
            // GroupReport_DateLbl
            // 
            this.GroupReport_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupReport_DateLbl.AutoSize = true;
            this.GroupReport_DateLbl.Location = new System.Drawing.Point(494, 16);
            this.GroupReport_DateLbl.Name = "GroupReport_DateLbl";
            this.GroupReport_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.GroupReport_DateLbl.TabIndex = 35;
            this.GroupReport_DateLbl.Text = "<Date>";
            // 
            // GroupReport_TimeLbl
            // 
            this.GroupReport_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupReport_TimeLbl.AutoSize = true;
            this.GroupReport_TimeLbl.Location = new System.Drawing.Point(494, 39);
            this.GroupReport_TimeLbl.Name = "GroupReport_TimeLbl";
            this.GroupReport_TimeLbl.Size = new System.Drawing.Size(42, 13);
            this.GroupReport_TimeLbl.TabIndex = 34;
            this.GroupReport_TimeLbl.Text = "<Time>";
            // 
            // GroupReport_WindowLbl
            // 
            this.GroupReport_WindowLbl.AutoSize = true;
            this.GroupReport_WindowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupReport_WindowLbl.Location = new System.Drawing.Point(6, 16);
            this.GroupReport_WindowLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GroupReport_WindowLbl.Name = "GroupReport_WindowLbl";
            this.GroupReport_WindowLbl.Size = new System.Drawing.Size(83, 13);
            this.GroupReport_WindowLbl.TabIndex = 33;
            this.GroupReport_WindowLbl.Text = "Group Report";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GroupReport_ButtonBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.GroupReport_UserInfoBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GroupReport_DrillBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.52678F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.47321F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 512);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // DateTaken
            // 
            this.DateTaken.HeaderText = "Name";
            this.DateTaken.Name = "DateTaken";
            this.DateTaken.ReadOnly = true;
            this.DateTaken.Width = 64;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "AvgPercent";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Width = 98;
            // 
            // Wrong
            // 
            this.Wrong.HeaderText = "AvgWrong";
            this.Wrong.Name = "Wrong";
            this.Wrong.ReadOnly = true;
            this.Wrong.Width = 91;
            // 
            // NumQuestions
            // 
            this.NumQuestions.HeaderText = "AvgSkipped";
            this.NumQuestions.Name = "NumQuestions";
            this.NumQuestions.ReadOnly = true;
            // 
            // Skipped
            // 
            this.Skipped.HeaderText = "TotalSetsDone";
            this.Skipped.Name = "Skipped";
            this.Skipped.ReadOnly = true;
            this.Skipped.Width = 116;
            // 
            // RangeStart
            // 
            this.RangeStart.HeaderText = "AvgWorkTiime";
            this.RangeStart.Name = "RangeStart";
            this.RangeStart.ReadOnly = true;
            this.RangeStart.Width = 114;
            // 
            // ReportGroup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportGroup_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            ((System.ComponentModel.ISupportInitialize)(this.GroupReport_DataDisplay)).EndInit();
            this.GroupReport_ButtonBox.ResumeLayout(false);
            this.GroupReport_DrillBox.ResumeLayout(false);
            this.GroupReport_UserInfoBox.ResumeLayout(false);
            this.GroupReport_UserInfoBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GroupReport_CloseBtn;
        private System.Windows.Forms.Timer GroupReport_Timer;
        private System.Windows.Forms.DataGridView GroupReport_DataDisplay;
        private System.Windows.Forms.GroupBox GroupReport_ButtonBox;
        private System.Windows.Forms.GroupBox GroupReport_DrillBox;
        private System.Windows.Forms.GroupBox GroupReport_UserInfoBox;
        private System.Windows.Forms.Label GroupReport_WindowLbl;
        private System.Windows.Forms.Label GroupReport_DateLbl;
        private System.Windows.Forms.Label GroupReport_TimeLbl;
        private System.Windows.Forms.Label GroupReport_GroupNameLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeStart;
    }
}