namespace RaptorMath
{
    partial class MatDri_Form
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
            this.MatDri_Timer = new System.Windows.Forms.Timer(this.components);
            this.MatDri_InputType = new System.Windows.Forms.RichTextBox();
            this.MatDri_SkipBtn = new System.Windows.Forms.Button();
            this.MatDri_EndDrillBtn = new System.Windows.Forms.Button();
            this.MatDri_SubmitBtn = new System.Windows.Forms.Button();
            this.MatDri_ResponseLbl = new System.Windows.Forms.Label();
            this.MatDri_TotalNumLbl = new System.Windows.Forms.Label();
            this.MatDri_OfLbl = new System.Windows.Forms.Label();
            this.MatDri_ProblemLbl = new System.Windows.Forms.Label();
            this.MatDri_CurrentNumLbl = new System.Windows.Forms.Label();
            this.MatDri_ProblemPrompt = new System.Windows.Forms.Label();
            this.MatDri_DateLbl = new System.Windows.Forms.Label();
            this.MatDri_StudentNameLbl = new System.Windows.Forms.Label();
            this.MatDri_TimeLbl = new System.Windows.Forms.Label();
            this.MatDri_WindowLbl = new System.Windows.Forms.Label();
            this.MatDri_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.MatDri_ButtonBox = new System.Windows.Forms.GroupBox();
            this.MatDri_ProblemBox = new System.Windows.Forms.GroupBox();
            this.MatDri_UserInfoBox.SuspendLayout();
            this.MatDri_ProblemBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatDri_Timer
            // 
            this.MatDri_Timer.Enabled = true;
            this.MatDri_Timer.Interval = 1000;
            this.MatDri_Timer.Tick += new System.EventHandler(this.MatDri_Timer_Tick);
            // 
            // MatDri_InputType
            // 
            this.MatDri_InputType.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MatDri_InputType.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_InputType.Location = new System.Drawing.Point(283, 39);
            this.MatDri_InputType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatDri_InputType.Multiline = false;
            this.MatDri_InputType.Name = "MatDri_InputType";
            this.MatDri_InputType.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MatDri_InputType.Size = new System.Drawing.Size(107, 52);
            this.MatDri_InputType.TabIndex = 2;
            this.MatDri_InputType.Text = "";
            this.MatDri_InputType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatDri_InputType_KeyPress);
            // 
            // MatDri_SkipBtn
            // 
            this.MatDri_SkipBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_SkipBtn.Location = new System.Drawing.Point(29, 270);
            this.MatDri_SkipBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatDri_SkipBtn.Name = "MatDri_SkipBtn";
            this.MatDri_SkipBtn.Size = new System.Drawing.Size(108, 38);
            this.MatDri_SkipBtn.TabIndex = 5;
            this.MatDri_SkipBtn.Text = "Skip";
            this.MatDri_SkipBtn.UseVisualStyleBackColor = true;
            this.MatDri_SkipBtn.Click += new System.EventHandler(this.MatDri_SkipBtn_Click);
            // 
            // MatDri_EndDrillBtn
            // 
            this.MatDri_EndDrillBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_EndDrillBtn.Location = new System.Drawing.Point(308, 270);
            this.MatDri_EndDrillBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatDri_EndDrillBtn.Name = "MatDri_EndDrillBtn";
            this.MatDri_EndDrillBtn.Size = new System.Drawing.Size(108, 38);
            this.MatDri_EndDrillBtn.TabIndex = 6;
            this.MatDri_EndDrillBtn.Text = "End Drill";
            this.MatDri_EndDrillBtn.UseVisualStyleBackColor = true;
            this.MatDri_EndDrillBtn.Click += new System.EventHandler(this.MatDri_EndDrillBtn_Click);
            // 
            // MatDri_SubmitBtn
            // 
            this.MatDri_SubmitBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_SubmitBtn.Location = new System.Drawing.Point(148, 113);
            this.MatDri_SubmitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatDri_SubmitBtn.Name = "MatDri_SubmitBtn";
            this.MatDri_SubmitBtn.Size = new System.Drawing.Size(108, 38);
            this.MatDri_SubmitBtn.TabIndex = 3;
            this.MatDri_SubmitBtn.Text = "Submit";
            this.MatDri_SubmitBtn.UseVisualStyleBackColor = true;
            this.MatDri_SubmitBtn.Click += new System.EventHandler(this.MatDri_SubmitBtn_Click);
            // 
            // MatDri_ResponseLbl
            // 
            this.MatDri_ResponseLbl.AutoSize = true;
            this.MatDri_ResponseLbl.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_ResponseLbl.Location = new System.Drawing.Point(276, 113);
            this.MatDri_ResponseLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatDri_ResponseLbl.Name = "MatDri_ResponseLbl";
            this.MatDri_ResponseLbl.Size = new System.Drawing.Size(119, 35);
            this.MatDri_ResponseLbl.TabIndex = 23;
            this.MatDri_ResponseLbl.Text = "<Result>";
            this.MatDri_ResponseLbl.Visible = false;
            // 
            // MatDri_TotalNumLbl
            // 
            this.MatDri_TotalNumLbl.AutoSize = true;
            this.MatDri_TotalNumLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_TotalNumLbl.Location = new System.Drawing.Point(280, 9);
            this.MatDri_TotalNumLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatDri_TotalNumLbl.Name = "MatDri_TotalNumLbl";
            this.MatDri_TotalNumLbl.Size = new System.Drawing.Size(22, 26);
            this.MatDri_TotalNumLbl.TabIndex = 17;
            this.MatDri_TotalNumLbl.Text = "#";
            // 
            // MatDri_OfLbl
            // 
            this.MatDri_OfLbl.AutoSize = true;
            this.MatDri_OfLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_OfLbl.Location = new System.Drawing.Point(236, 9);
            this.MatDri_OfLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatDri_OfLbl.Name = "MatDri_OfLbl";
            this.MatDri_OfLbl.Size = new System.Drawing.Size(30, 26);
            this.MatDri_OfLbl.TabIndex = 16;
            this.MatDri_OfLbl.Text = "of";
            // 
            // MatDri_ProblemLbl
            // 
            this.MatDri_ProblemLbl.AutoSize = true;
            this.MatDri_ProblemLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_ProblemLbl.Location = new System.Drawing.Point(104, 9);
            this.MatDri_ProblemLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatDri_ProblemLbl.Name = "MatDri_ProblemLbl";
            this.MatDri_ProblemLbl.Size = new System.Drawing.Size(87, 26);
            this.MatDri_ProblemLbl.TabIndex = 9;
            this.MatDri_ProblemLbl.Text = "Problem";
            // 
            // MatDri_CurrentNumLbl
            // 
            this.MatDri_CurrentNumLbl.AutoSize = true;
            this.MatDri_CurrentNumLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_CurrentNumLbl.Location = new System.Drawing.Point(204, 9);
            this.MatDri_CurrentNumLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatDri_CurrentNumLbl.Name = "MatDri_CurrentNumLbl";
            this.MatDri_CurrentNumLbl.Size = new System.Drawing.Size(22, 26);
            this.MatDri_CurrentNumLbl.TabIndex = 15;
            this.MatDri_CurrentNumLbl.Text = "#";
            // 
            // MatDri_ProblemPrompt
            // 
            this.MatDri_ProblemPrompt.AutoSize = true;
            this.MatDri_ProblemPrompt.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_ProblemPrompt.Location = new System.Drawing.Point(33, 47);
            this.MatDri_ProblemPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatDri_ProblemPrompt.Name = "MatDri_ProblemPrompt";
            this.MatDri_ProblemPrompt.Size = new System.Drawing.Size(99, 46);
            this.MatDri_ProblemPrompt.TabIndex = 25;
            this.MatDri_ProblemPrompt.Text = "<Eq>";
            // 
            // MatDri_DateLbl
            // 
            this.MatDri_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MatDri_DateLbl.AutoSize = true;
            this.MatDri_DateLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_DateLbl.Location = new System.Drawing.Point(293, 11);
            this.MatDri_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatDri_DateLbl.Name = "MatDri_DateLbl";
            this.MatDri_DateLbl.Size = new System.Drawing.Size(74, 26);
            this.MatDri_DateLbl.TabIndex = 7;
            this.MatDri_DateLbl.Text = "<Date>";
            // 
            // MatDri_StudentNameLbl
            // 
            this.MatDri_StudentNameLbl.AutoSize = true;
            this.MatDri_StudentNameLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_StudentNameLbl.Location = new System.Drawing.Point(8, 37);
            this.MatDri_StudentNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatDri_StudentNameLbl.Name = "MatDri_StudentNameLbl";
            this.MatDri_StudentNameLbl.Size = new System.Drawing.Size(102, 26);
            this.MatDri_StudentNameLbl.TabIndex = 8;
            this.MatDri_StudentNameLbl.Text = "<Student>";
            // 
            // MatDri_TimeLbl
            // 
            this.MatDri_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MatDri_TimeLbl.AutoSize = true;
            this.MatDri_TimeLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_TimeLbl.Location = new System.Drawing.Point(293, 43);
            this.MatDri_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatDri_TimeLbl.Name = "MatDri_TimeLbl";
            this.MatDri_TimeLbl.Size = new System.Drawing.Size(78, 26);
            this.MatDri_TimeLbl.TabIndex = 24;
            this.MatDri_TimeLbl.Text = "<Time>";
            // 
            // MatDri_WindowLbl
            // 
            this.MatDri_WindowLbl.AutoSize = true;
            this.MatDri_WindowLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDri_WindowLbl.Location = new System.Drawing.Point(8, 10);
            this.MatDri_WindowLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatDri_WindowLbl.Name = "MatDri_WindowLbl";
            this.MatDri_WindowLbl.Size = new System.Drawing.Size(104, 26);
            this.MatDri_WindowLbl.TabIndex = 26;
            this.MatDri_WindowLbl.Text = "Math Drill";
            // 
            // MatDri_UserInfoBox
            // 
            this.MatDri_UserInfoBox.Controls.Add(this.MatDri_WindowLbl);
            this.MatDri_UserInfoBox.Controls.Add(this.MatDri_TimeLbl);
            this.MatDri_UserInfoBox.Controls.Add(this.MatDri_StudentNameLbl);
            this.MatDri_UserInfoBox.Controls.Add(this.MatDri_DateLbl);
            this.MatDri_UserInfoBox.Location = new System.Drawing.Point(16, 4);
            this.MatDri_UserInfoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatDri_UserInfoBox.Name = "MatDri_UserInfoBox";
            this.MatDri_UserInfoBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatDri_UserInfoBox.Size = new System.Drawing.Size(413, 81);
            this.MatDri_UserInfoBox.TabIndex = 0;
            this.MatDri_UserInfoBox.TabStop = false;
            // 
            // MatDri_ButtonBox
            // 
            this.MatDri_ButtonBox.Location = new System.Drawing.Point(16, 252);
            this.MatDri_ButtonBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatDri_ButtonBox.Name = "MatDri_ButtonBox";
            this.MatDri_ButtonBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatDri_ButtonBox.Size = new System.Drawing.Size(413, 66);
            this.MatDri_ButtonBox.TabIndex = 4;
            this.MatDri_ButtonBox.TabStop = false;
            // 
            // MatDri_ProblemBox
            // 
            this.MatDri_ProblemBox.Controls.Add(this.MatDri_ResponseLbl);
            this.MatDri_ProblemBox.Controls.Add(this.MatDri_ProblemPrompt);
            this.MatDri_ProblemBox.Controls.Add(this.MatDri_SubmitBtn);
            this.MatDri_ProblemBox.Controls.Add(this.MatDri_TotalNumLbl);
            this.MatDri_ProblemBox.Controls.Add(this.MatDri_InputType);
            this.MatDri_ProblemBox.Controls.Add(this.MatDri_OfLbl);
            this.MatDri_ProblemBox.Controls.Add(this.MatDri_ProblemLbl);
            this.MatDri_ProblemBox.Controls.Add(this.MatDri_CurrentNumLbl);
            this.MatDri_ProblemBox.Location = new System.Drawing.Point(16, 80);
            this.MatDri_ProblemBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatDri_ProblemBox.Name = "MatDri_ProblemBox";
            this.MatDri_ProblemBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatDri_ProblemBox.Size = new System.Drawing.Size(413, 165);
            this.MatDri_ProblemBox.TabIndex = 1;
            this.MatDri_ProblemBox.TabStop = false;
            // 
            // MatDri_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 322);
            this.ControlBox = false;
            this.Controls.Add(this.MatDri_EndDrillBtn);
            this.Controls.Add(this.MatDri_SkipBtn);
            this.Controls.Add(this.MatDri_UserInfoBox);
            this.Controls.Add(this.MatDri_ButtonBox);
            this.Controls.Add(this.MatDri_ProblemBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MatDri_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.MatDri_UserInfoBox.ResumeLayout(false);
            this.MatDri_UserInfoBox.PerformLayout();
            this.MatDri_ProblemBox.ResumeLayout(false);
            this.MatDri_ProblemBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MatDri_Timer;
        private System.Windows.Forms.RichTextBox MatDri_InputType;
        private System.Windows.Forms.Button MatDri_SkipBtn;
        private System.Windows.Forms.Button MatDri_EndDrillBtn;
        private System.Windows.Forms.Button MatDri_SubmitBtn;
        private System.Windows.Forms.Label MatDri_ResponseLbl;
        private System.Windows.Forms.Label MatDri_TotalNumLbl;
        private System.Windows.Forms.Label MatDri_OfLbl;
        private System.Windows.Forms.Label MatDri_ProblemLbl;
        private System.Windows.Forms.Label MatDri_CurrentNumLbl;
        private System.Windows.Forms.Label MatDri_ProblemPrompt;
        private System.Windows.Forms.Label MatDri_DateLbl;
        private System.Windows.Forms.Label MatDri_StudentNameLbl;
        private System.Windows.Forms.Label MatDri_TimeLbl;
        private System.Windows.Forms.Label MatDri_WindowLbl;
        private System.Windows.Forms.GroupBox MatDri_UserInfoBox;
        private System.Windows.Forms.GroupBox MatDri_ButtonBox;
        private System.Windows.Forms.GroupBox MatDri_ProblemBox;
    }
}