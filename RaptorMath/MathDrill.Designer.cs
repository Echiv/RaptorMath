﻿namespace RaptorMath
{
    partial class MathDrill_Form
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
            this.MathDrill_InputTxt = new System.Windows.Forms.RichTextBox();
            this.MathDrill_SkipBtn = new System.Windows.Forms.Button();
            this.MathDrill_QuitBtn = new System.Windows.Forms.Button();
            this.MathDrill_SubmitBtn = new System.Windows.Forms.Button();
            this.MathDrill_ResponseLbl = new System.Windows.Forms.Label();
            this.MathDrill_OfLbl = new System.Windows.Forms.Label();
            this.MathDrill_ProblemLbl = new System.Windows.Forms.Label();
            this.MathDrill_CurrentNumLbl = new System.Windows.Forms.Label();
            this.MathDrill_ProblemPrompt = new System.Windows.Forms.Label();
            this.MathDrill_DateLbl = new System.Windows.Forms.Label();
            this.MathDrill_StudentNameLbl = new System.Windows.Forms.Label();
            this.MathDrill_TimeLbl = new System.Windows.Forms.Label();
            this.MathDrill_WindowLbl = new System.Windows.Forms.Label();
            this.MathDrill_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.MatDri_ButtonBox = new System.Windows.Forms.GroupBox();
            this.MathDrill_ProblemBox = new System.Windows.Forms.GroupBox();
            this.MathDrill_TotalNumberLbl = new System.Windows.Forms.Label();
            this.MathDrill_CoinBox = new System.Windows.Forms.GroupBox();
            this.MathDrill_CoinPic = new System.Windows.Forms.PictureBox();
            this.MathDrill_CoinTxt = new System.Windows.Forms.RichTextBox();
            this.MathDrill_UserInfoBox.SuspendLayout();
            this.MatDri_ButtonBox.SuspendLayout();
            this.MathDrill_ProblemBox.SuspendLayout();
            this.MathDrill_CoinBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MathDrill_CoinPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MatDri_Timer
            // 
            this.MatDri_Timer.Enabled = true;
            this.MatDri_Timer.Interval = 1000;
            this.MatDri_Timer.Tick += new System.EventHandler(this.MatDri_Timer_Tick);
            // 
            // MathDrill_InputTxt
            // 
            this.MathDrill_InputTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MathDrill_InputTxt.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_InputTxt.Location = new System.Drawing.Point(206, 67);
            this.MathDrill_InputTxt.Multiline = false;
            this.MathDrill_InputTxt.Name = "MathDrill_InputTxt";
            this.MathDrill_InputTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MathDrill_InputTxt.Size = new System.Drawing.Size(81, 43);
            this.MathDrill_InputTxt.TabIndex = 1;
            this.MathDrill_InputTxt.Text = "";
            this.MathDrill_InputTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatDri_InputType_KeyPress);
            // 
            // MathDrill_SkipBtn
            // 
            this.MathDrill_SkipBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_SkipBtn.Location = new System.Drawing.Point(243, 165);
            this.MathDrill_SkipBtn.Name = "MathDrill_SkipBtn";
            this.MathDrill_SkipBtn.Size = new System.Drawing.Size(111, 31);
            this.MathDrill_SkipBtn.TabIndex = 3;
            this.MathDrill_SkipBtn.Text = "I don\'t know";
            this.MathDrill_SkipBtn.UseVisualStyleBackColor = true;
            this.MathDrill_SkipBtn.Click += new System.EventHandler(this.MatDri_SkipBtn_Click);
            // 
            // MathDrill_QuitBtn
            // 
            this.MathDrill_QuitBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_QuitBtn.Location = new System.Drawing.Point(68, 25);
            this.MathDrill_QuitBtn.Name = "MathDrill_QuitBtn";
            this.MathDrill_QuitBtn.Size = new System.Drawing.Size(111, 31);
            this.MathDrill_QuitBtn.TabIndex = 4;
            this.MathDrill_QuitBtn.Text = "Quit";
            this.MathDrill_QuitBtn.UseVisualStyleBackColor = true;
            this.MathDrill_QuitBtn.Click += new System.EventHandler(this.MatDri_EndDrillBtn_Click);
            // 
            // MathDrill_SubmitBtn
            // 
            this.MathDrill_SubmitBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_SubmitBtn.Location = new System.Drawing.Point(126, 165);
            this.MathDrill_SubmitBtn.Name = "MathDrill_SubmitBtn";
            this.MathDrill_SubmitBtn.Size = new System.Drawing.Size(111, 31);
            this.MathDrill_SubmitBtn.TabIndex = 2;
            this.MathDrill_SubmitBtn.Text = "Submit";
            this.MathDrill_SubmitBtn.UseVisualStyleBackColor = true;
            this.MathDrill_SubmitBtn.Click += new System.EventHandler(this.MatDri_SubmitBtn_Click);
            // 
            // MathDrill_ResponseLbl
            // 
            this.MathDrill_ResponseLbl.AutoSize = true;
            this.MathDrill_ResponseLbl.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_ResponseLbl.Location = new System.Drawing.Point(200, 113);
            this.MathDrill_ResponseLbl.Name = "MathDrill_ResponseLbl";
            this.MathDrill_ResponseLbl.Size = new System.Drawing.Size(91, 27);
            this.MathDrill_ResponseLbl.TabIndex = 23;
            this.MathDrill_ResponseLbl.Text = "<Result>";
            this.MathDrill_ResponseLbl.Visible = false;
            // 
            // MathDrill_OfLbl
            // 
            this.MathDrill_OfLbl.AutoSize = true;
            this.MathDrill_OfLbl.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_OfLbl.Location = new System.Drawing.Point(200, 16);
            this.MathDrill_OfLbl.Name = "MathDrill_OfLbl";
            this.MathDrill_OfLbl.Size = new System.Drawing.Size(32, 27);
            this.MathDrill_OfLbl.TabIndex = 16;
            this.MathDrill_OfLbl.Text = "of";
            // 
            // MathDrill_ProblemLbl
            // 
            this.MathDrill_ProblemLbl.AutoSize = true;
            this.MathDrill_ProblemLbl.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_ProblemLbl.Location = new System.Drawing.Point(65, 16);
            this.MathDrill_ProblemLbl.Name = "MathDrill_ProblemLbl";
            this.MathDrill_ProblemLbl.Size = new System.Drawing.Size(93, 27);
            this.MathDrill_ProblemLbl.TabIndex = 9;
            this.MathDrill_ProblemLbl.Text = "Problem";
            // 
            // MathDrill_CurrentNumLbl
            // 
            this.MathDrill_CurrentNumLbl.AutoSize = true;
            this.MathDrill_CurrentNumLbl.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_CurrentNumLbl.Location = new System.Drawing.Point(155, 16);
            this.MathDrill_CurrentNumLbl.Name = "MathDrill_CurrentNumLbl";
            this.MathDrill_CurrentNumLbl.Size = new System.Drawing.Size(48, 27);
            this.MathDrill_CurrentNumLbl.TabIndex = 15;
            this.MathDrill_CurrentNumLbl.Text = "<#>";
            // 
            // MathDrill_ProblemPrompt
            // 
            this.MathDrill_ProblemPrompt.AutoSize = true;
            this.MathDrill_ProblemPrompt.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_ProblemPrompt.Location = new System.Drawing.Point(65, 67);
            this.MathDrill_ProblemPrompt.Name = "MathDrill_ProblemPrompt";
            this.MathDrill_ProblemPrompt.Size = new System.Drawing.Size(94, 43);
            this.MathDrill_ProblemPrompt.TabIndex = 25;
            this.MathDrill_ProblemPrompt.Text = "<Eq>";
            // 
            // MathDrill_DateLbl
            // 
            this.MathDrill_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MathDrill_DateLbl.AutoSize = true;
            this.MathDrill_DateLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_DateLbl.Location = new System.Drawing.Point(270, 16);
            this.MathDrill_DateLbl.Name = "MathDrill_DateLbl";
            this.MathDrill_DateLbl.Size = new System.Drawing.Size(59, 22);
            this.MathDrill_DateLbl.TabIndex = 7;
            this.MathDrill_DateLbl.Text = "<Date>";
            // 
            // MathDrill_StudentNameLbl
            // 
            this.MathDrill_StudentNameLbl.AutoSize = true;
            this.MathDrill_StudentNameLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_StudentNameLbl.Location = new System.Drawing.Point(6, 16);
            this.MathDrill_StudentNameLbl.Name = "MathDrill_StudentNameLbl";
            this.MathDrill_StudentNameLbl.Size = new System.Drawing.Size(80, 22);
            this.MathDrill_StudentNameLbl.TabIndex = 8;
            this.MathDrill_StudentNameLbl.Text = "<Student>";
            // 
            // MathDrill_TimeLbl
            // 
            this.MathDrill_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MathDrill_TimeLbl.AutoSize = true;
            this.MathDrill_TimeLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_TimeLbl.Location = new System.Drawing.Point(270, 42);
            this.MathDrill_TimeLbl.Name = "MathDrill_TimeLbl";
            this.MathDrill_TimeLbl.Size = new System.Drawing.Size(62, 22);
            this.MathDrill_TimeLbl.TabIndex = 24;
            this.MathDrill_TimeLbl.Text = "<Time>";
            // 
            // MathDrill_WindowLbl
            // 
            this.MathDrill_WindowLbl.AutoSize = true;
            this.MathDrill_WindowLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_WindowLbl.Location = new System.Drawing.Point(163, -1);
            this.MathDrill_WindowLbl.Name = "MathDrill_WindowLbl";
            this.MathDrill_WindowLbl.Size = new System.Drawing.Size(81, 22);
            this.MathDrill_WindowLbl.TabIndex = 26;
            this.MathDrill_WindowLbl.Text = "Math Drill";
            // 
            // MathDrill_UserInfoBox
            // 
            this.MathDrill_UserInfoBox.Controls.Add(this.MathDrill_TimeLbl);
            this.MathDrill_UserInfoBox.Controls.Add(this.MathDrill_StudentNameLbl);
            this.MathDrill_UserInfoBox.Controls.Add(this.MathDrill_DateLbl);
            this.MathDrill_UserInfoBox.Location = new System.Drawing.Point(12, 12);
            this.MathDrill_UserInfoBox.Name = "MathDrill_UserInfoBox";
            this.MathDrill_UserInfoBox.Size = new System.Drawing.Size(360, 65);
            this.MathDrill_UserInfoBox.TabIndex = 27;
            this.MathDrill_UserInfoBox.TabStop = false;
            // 
            // MatDri_ButtonBox
            // 
            this.MatDri_ButtonBox.Controls.Add(this.MathDrill_QuitBtn);
            this.MatDri_ButtonBox.Location = new System.Drawing.Point(187, 286);
            this.MatDri_ButtonBox.Name = "MatDri_ButtonBox";
            this.MatDri_ButtonBox.Size = new System.Drawing.Size(184, 70);
            this.MatDri_ButtonBox.TabIndex = 28;
            this.MatDri_ButtonBox.TabStop = false;
            // 
            // MathDrill_ProblemBox
            // 
            this.MathDrill_ProblemBox.Controls.Add(this.MathDrill_TotalNumberLbl);
            this.MathDrill_ProblemBox.Controls.Add(this.MathDrill_SkipBtn);
            this.MathDrill_ProblemBox.Controls.Add(this.MathDrill_ResponseLbl);
            this.MathDrill_ProblemBox.Controls.Add(this.MathDrill_ProblemPrompt);
            this.MathDrill_ProblemBox.Controls.Add(this.MathDrill_SubmitBtn);
            this.MathDrill_ProblemBox.Controls.Add(this.MathDrill_InputTxt);
            this.MathDrill_ProblemBox.Controls.Add(this.MathDrill_OfLbl);
            this.MathDrill_ProblemBox.Controls.Add(this.MathDrill_ProblemLbl);
            this.MathDrill_ProblemBox.Controls.Add(this.MathDrill_CurrentNumLbl);
            this.MathDrill_ProblemBox.Location = new System.Drawing.Point(12, 75);
            this.MathDrill_ProblemBox.Name = "MathDrill_ProblemBox";
            this.MathDrill_ProblemBox.Size = new System.Drawing.Size(360, 205);
            this.MathDrill_ProblemBox.TabIndex = 29;
            this.MathDrill_ProblemBox.TabStop = false;
            // 
            // MathDrill_TotalNumberLbl
            // 
            this.MathDrill_TotalNumberLbl.AutoSize = true;
            this.MathDrill_TotalNumberLbl.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_TotalNumberLbl.Location = new System.Drawing.Point(228, 16);
            this.MathDrill_TotalNumberLbl.Name = "MathDrill_TotalNumberLbl";
            this.MathDrill_TotalNumberLbl.Size = new System.Drawing.Size(48, 27);
            this.MathDrill_TotalNumberLbl.TabIndex = 26;
            this.MathDrill_TotalNumberLbl.Text = "<#>";
            // 
            // MathDrill_CoinBox
            // 
            this.MathDrill_CoinBox.Controls.Add(this.MathDrill_CoinPic);
            this.MathDrill_CoinBox.Controls.Add(this.MathDrill_CoinTxt);
            this.MathDrill_CoinBox.Location = new System.Drawing.Point(8, 286);
            this.MathDrill_CoinBox.Name = "MathDrill_CoinBox";
            this.MathDrill_CoinBox.Size = new System.Drawing.Size(173, 70);
            this.MathDrill_CoinBox.TabIndex = 31;
            this.MathDrill_CoinBox.TabStop = false;
            // 
            // MathDrill_CoinPic
            // 
            this.MathDrill_CoinPic.Location = new System.Drawing.Point(2, 12);
            this.MathDrill_CoinPic.Name = "MathDrill_CoinPic";
            this.MathDrill_CoinPic.Size = new System.Drawing.Size(53, 49);
            this.MathDrill_CoinPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MathDrill_CoinPic.TabIndex = 27;
            this.MathDrill_CoinPic.TabStop = false;
            // 
            // MathDrill_CoinTxt
            // 
            this.MathDrill_CoinTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MathDrill_CoinTxt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_CoinTxt.Location = new System.Drawing.Point(57, 25);
            this.MathDrill_CoinTxt.Multiline = false;
            this.MathDrill_CoinTxt.Name = "MathDrill_CoinTxt";
            this.MathDrill_CoinTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MathDrill_CoinTxt.Size = new System.Drawing.Size(105, 29);
            this.MathDrill_CoinTxt.TabIndex = 1;
            this.MathDrill_CoinTxt.Text = "";
            // 
            // MathDrill_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.MathDrill_WindowLbl);
            this.Controls.Add(this.MathDrill_CoinBox);
            this.Controls.Add(this.MathDrill_UserInfoBox);
            this.Controls.Add(this.MatDri_ButtonBox);
            this.Controls.Add(this.MathDrill_ProblemBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MathDrill_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.MathDrill_UserInfoBox.ResumeLayout(false);
            this.MathDrill_UserInfoBox.PerformLayout();
            this.MatDri_ButtonBox.ResumeLayout(false);
            this.MathDrill_ProblemBox.ResumeLayout(false);
            this.MathDrill_ProblemBox.PerformLayout();
            this.MathDrill_CoinBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MathDrill_CoinPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MatDri_Timer;
        private System.Windows.Forms.RichTextBox MathDrill_InputTxt;
        private System.Windows.Forms.Button MathDrill_SkipBtn;
        private System.Windows.Forms.Button MathDrill_QuitBtn;
        private System.Windows.Forms.Button MathDrill_SubmitBtn;
        private System.Windows.Forms.Label MathDrill_ResponseLbl;
        private System.Windows.Forms.Label MathDrill_OfLbl;
        private System.Windows.Forms.Label MathDrill_ProblemLbl;
        private System.Windows.Forms.Label MathDrill_CurrentNumLbl;
        private System.Windows.Forms.Label MathDrill_ProblemPrompt;
        private System.Windows.Forms.Label MathDrill_DateLbl;
        private System.Windows.Forms.Label MathDrill_StudentNameLbl;
        private System.Windows.Forms.Label MathDrill_TimeLbl;
        private System.Windows.Forms.Label MathDrill_WindowLbl;
        private System.Windows.Forms.GroupBox MathDrill_UserInfoBox;
        private System.Windows.Forms.GroupBox MatDri_ButtonBox;
        private System.Windows.Forms.GroupBox MathDrill_ProblemBox;
        private System.Windows.Forms.Label MathDrill_TotalNumberLbl;
        private System.Windows.Forms.GroupBox MathDrill_CoinBox;
        private System.Windows.Forms.PictureBox MathDrill_CoinPic;
        private System.Windows.Forms.RichTextBox MathDrill_CoinTxt;
    }
}