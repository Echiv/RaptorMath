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
            this.SingleReport_ButtonBox = new System.Windows.Forms.GroupBox();
            this.SingleReport_CloseBtn = new System.Windows.Forms.Button();
            this.SingleReport_DrillBox = new System.Windows.Forms.GroupBox();
            this.Op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingleReport_DataDisplay = new System.Windows.Forms.DataGridView();
            this.UseRep_Timer = new System.Windows.Forms.Timer(this.components);
            this.GroupReport_WindowLbl = new System.Windows.Forms.Label();
            this.SingleReport_UserInfoBox.SuspendLayout();
            this.SingleReport_ButtonBox.SuspendLayout();
            this.SingleReport_DrillBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingleReport_DataDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // SingleReport__GroupNameLbl
            // 
            this.SingleReport__GroupNameLbl.AutoSize = true;
            this.SingleReport__GroupNameLbl.Location = new System.Drawing.Point(6, 16);
            this.SingleReport__GroupNameLbl.Name = "SingleReport__GroupNameLbl";
            this.SingleReport__GroupNameLbl.Size = new System.Drawing.Size(87, 13);
            this.SingleReport__GroupNameLbl.TabIndex = 37;
            this.SingleReport__GroupNameLbl.Text = "<Student Name>";
            // 
            // SingleReport_TimeLbl
            // 
            this.SingleReport_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleReport_TimeLbl.AutoSize = true;
            this.SingleReport_TimeLbl.Location = new System.Drawing.Point(346, 39);
            this.SingleReport_TimeLbl.Name = "SingleReport_TimeLbl";
            this.SingleReport_TimeLbl.Size = new System.Drawing.Size(42, 13);
            this.SingleReport_TimeLbl.TabIndex = 34;
            this.SingleReport_TimeLbl.Text = "<Time>";
            // 
            // SingleReport_UserInfoBox
            // 
            this.SingleReport_UserInfoBox.Controls.Add(this.SingleReport__GroupNameLbl);
            this.SingleReport_UserInfoBox.Controls.Add(this.SingleReport_DateLbl);
            this.SingleReport_UserInfoBox.Controls.Add(this.SingleReport_TimeLbl);
            this.SingleReport_UserInfoBox.Location = new System.Drawing.Point(10, 31);
            this.SingleReport_UserInfoBox.Name = "SingleReport_UserInfoBox";
            this.SingleReport_UserInfoBox.Size = new System.Drawing.Size(410, 58);
            this.SingleReport_UserInfoBox.TabIndex = 42;
            this.SingleReport_UserInfoBox.TabStop = false;
            // 
            // SingleReport_DateLbl
            // 
            this.SingleReport_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleReport_DateLbl.AutoSize = true;
            this.SingleReport_DateLbl.Location = new System.Drawing.Point(346, 16);
            this.SingleReport_DateLbl.Name = "SingleReport_DateLbl";
            this.SingleReport_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.SingleReport_DateLbl.TabIndex = 35;
            this.SingleReport_DateLbl.Text = "<Date>";
            // 
            // SingleReport_ButtonBox
            // 
            this.SingleReport_ButtonBox.Controls.Add(this.SingleReport_CloseBtn);
            this.SingleReport_ButtonBox.Location = new System.Drawing.Point(10, 455);
            this.SingleReport_ButtonBox.Name = "SingleReport_ButtonBox";
            this.SingleReport_ButtonBox.Size = new System.Drawing.Size(408, 45);
            this.SingleReport_ButtonBox.TabIndex = 40;
            this.SingleReport_ButtonBox.TabStop = false;
            // 
            // SingleReport_CloseBtn
            // 
            this.SingleReport_CloseBtn.Location = new System.Drawing.Point(330, 13);
            this.SingleReport_CloseBtn.Name = "SingleReport_CloseBtn";
            this.SingleReport_CloseBtn.Size = new System.Drawing.Size(56, 26);
            this.SingleReport_CloseBtn.TabIndex = 1;
            this.SingleReport_CloseBtn.Text = "Close";
            this.SingleReport_CloseBtn.UseVisualStyleBackColor = true;
            // 
            // SingleReport_DrillBox
            // 
            this.SingleReport_DrillBox.Controls.Add(this.SingleReport_DataDisplay);
            this.SingleReport_DrillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleReport_DrillBox.Location = new System.Drawing.Point(10, 95);
            this.SingleReport_DrillBox.Name = "SingleReport_DrillBox";
            this.SingleReport_DrillBox.Size = new System.Drawing.Size(410, 361);
            this.SingleReport_DrillBox.TabIndex = 41;
            this.SingleReport_DrillBox.TabStop = false;
            this.SingleReport_DrillBox.Text = "Drill Records";
            // 
            // Op
            // 
            this.Op.HeaderText = "Op";
            this.Op.Name = "Op";
            this.Op.ReadOnly = true;
            this.Op.Width = 48;
            // 
            // RangeEnd
            // 
            this.RangeEnd.HeaderText = "RangeEnd";
            this.RangeEnd.Name = "RangeEnd";
            this.RangeEnd.ReadOnly = true;
            this.RangeEnd.Width = 91;
            // 
            // RangeStart
            // 
            this.RangeStart.HeaderText = "TBD";
            this.RangeStart.Name = "RangeStart";
            this.RangeStart.ReadOnly = true;
            this.RangeStart.Width = 57;
            // 
            // Skipped
            // 
            this.Skipped.HeaderText = "TBD";
            this.Skipped.Name = "Skipped";
            this.Skipped.ReadOnly = true;
            this.Skipped.Width = 57;
            // 
            // NumQuestions
            // 
            this.NumQuestions.HeaderText = "TBD";
            this.NumQuestions.Name = "NumQuestions";
            this.NumQuestions.ReadOnly = true;
            this.NumQuestions.Width = 57;
            // 
            // Wrong
            // 
            this.Wrong.HeaderText = "TBD";
            this.Wrong.Name = "Wrong";
            this.Wrong.ReadOnly = true;
            this.Wrong.Width = 57;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "TBD";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Width = 57;
            // 
            // DateTaken
            // 
            this.DateTaken.HeaderText = "TBD";
            this.DateTaken.Name = "DateTaken";
            this.DateTaken.ReadOnly = true;
            this.DateTaken.Width = 57;
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
            this.RangeStart,
            this.RangeEnd,
            this.Op});
            this.SingleReport_DataDisplay.Location = new System.Drawing.Point(6, 19);
            this.SingleReport_DataDisplay.Name = "SingleReport_DataDisplay";
            this.SingleReport_DataDisplay.RowHeadersVisible = false;
            this.SingleReport_DataDisplay.Size = new System.Drawing.Size(396, 312);
            this.SingleReport_DataDisplay.TabIndex = 38;
            // 
            // UseRep_Timer
            // 
            this.UseRep_Timer.Enabled = true;
            this.UseRep_Timer.Interval = 1000;
            // 
            // GroupReport_WindowLbl
            // 
            this.GroupReport_WindowLbl.AutoSize = true;
            this.GroupReport_WindowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupReport_WindowLbl.Location = new System.Drawing.Point(183, 9);
            this.GroupReport_WindowLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GroupReport_WindowLbl.Name = "GroupReport_WindowLbl";
            this.GroupReport_WindowLbl.Size = new System.Drawing.Size(84, 13);
            this.GroupReport_WindowLbl.TabIndex = 39;
            this.GroupReport_WindowLbl.Text = "Single Report";
            // 
            // SingleReport_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 508);
            this.Controls.Add(this.SingleReport_UserInfoBox);
            this.Controls.Add(this.SingleReport_ButtonBox);
            this.Controls.Add(this.SingleReport_DrillBox);
            this.Controls.Add(this.GroupReport_WindowLbl);
            this.Name = "SingleReport_Form";
            this.Text = "Raptor Math";
            this.SingleReport_UserInfoBox.ResumeLayout(false);
            this.SingleReport_UserInfoBox.PerformLayout();
            this.SingleReport_ButtonBox.ResumeLayout(false);
            this.SingleReport_DrillBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SingleReport_DataDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SingleReport__GroupNameLbl;
        private System.Windows.Forms.Label SingleReport_TimeLbl;
        private System.Windows.Forms.GroupBox SingleReport_UserInfoBox;
        private System.Windows.Forms.Label SingleReport_DateLbl;
        private System.Windows.Forms.GroupBox SingleReport_ButtonBox;
        private System.Windows.Forms.Button SingleReport_CloseBtn;
        private System.Windows.Forms.GroupBox SingleReport_DrillBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Op;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTaken;
        private System.Windows.Forms.DataGridView SingleReport_DataDisplay;
        private System.Windows.Forms.Timer UseRep_Timer;
        private System.Windows.Forms.Label GroupReport_WindowLbl;
    }
}