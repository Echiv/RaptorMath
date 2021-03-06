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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathDrill_Form));
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.doNothingContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MathDrill_UserInfoBox.SuspendLayout();
            this.MatDri_ButtonBox.SuspendLayout();
            this.MathDrill_ProblemBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatDri_Timer
            // 
            this.MatDri_Timer.Enabled = true;
            this.MatDri_Timer.Interval = 1000;
            this.MatDri_Timer.Tick += new System.EventHandler(this.MathDrill_Timer_Tick);
            // 
            // MathDrill_InputTxt
            // 
            this.MathDrill_InputTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MathDrill_InputTxt.ContextMenuStrip = this.doNothingContextMenu;
            this.MathDrill_InputTxt.DetectUrls = false;
            this.MathDrill_InputTxt.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_InputTxt.Location = new System.Drawing.Point(291, 82);
            this.MathDrill_InputTxt.Margin = new System.Windows.Forms.Padding(4);
            this.MathDrill_InputTxt.MaxLength = 6;
            this.MathDrill_InputTxt.Multiline = false;
            this.MathDrill_InputTxt.Name = "MathDrill_InputTxt";
            this.MathDrill_InputTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MathDrill_InputTxt.Size = new System.Drawing.Size(126, 52);
            this.MathDrill_InputTxt.TabIndex = 0;
            this.MathDrill_InputTxt.Text = "";
            this.MathDrill_InputTxt.TextChanged += new System.EventHandler(this.MathDrill_InputTxt_TextChanged);
            this.MathDrill_InputTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_DigitsKeyDown);
            this.MathDrill_InputTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MathDrill_InputType_KeyPress);
            this.MathDrill_InputTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_KeyUp);
            // 
            // MathDrill_SkipBtn
            // 
            this.MathDrill_SkipBtn.AutoSize = true;
            this.MathDrill_SkipBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_SkipBtn.Location = new System.Drawing.Point(154, 199);
            this.MathDrill_SkipBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MathDrill_SkipBtn.Name = "MathDrill_SkipBtn";
            this.MathDrill_SkipBtn.Size = new System.Drawing.Size(131, 40);
            this.MathDrill_SkipBtn.TabIndex = 1;
            this.MathDrill_SkipBtn.Text = "I don\'t know";
            this.toolTip1.SetToolTip(this.MathDrill_SkipBtn, "Skips the current problem");
            this.MathDrill_SkipBtn.UseVisualStyleBackColor = true;
            this.MathDrill_SkipBtn.Click += new System.EventHandler(this.MathDrill_SkipBtn_Click);
            // 
            // MathDrill_QuitBtn
            // 
            this.MathDrill_QuitBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_QuitBtn.Location = new System.Drawing.Point(340, 23);
            this.MathDrill_QuitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MathDrill_QuitBtn.Name = "MathDrill_QuitBtn";
            this.MathDrill_QuitBtn.Size = new System.Drawing.Size(125, 40);
            this.MathDrill_QuitBtn.TabIndex = 0;
            this.MathDrill_QuitBtn.Text = "Quit";
            this.toolTip1.SetToolTip(this.MathDrill_QuitBtn, "Ends the drill. Saves adventure if finished.");
            this.MathDrill_QuitBtn.UseVisualStyleBackColor = true;
            this.MathDrill_QuitBtn.Click += new System.EventHandler(this.MathDrill_EndDrillBtn_Click);
            // 
            // MathDrill_SubmitBtn
            // 
            this.MathDrill_SubmitBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_SubmitBtn.Location = new System.Drawing.Point(292, 199);
            this.MathDrill_SubmitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MathDrill_SubmitBtn.Name = "MathDrill_SubmitBtn";
            this.MathDrill_SubmitBtn.Size = new System.Drawing.Size(125, 40);
            this.MathDrill_SubmitBtn.TabIndex = 2;
            this.MathDrill_SubmitBtn.Text = "Submit";
            this.toolTip1.SetToolTip(this.MathDrill_SubmitBtn, "Submits your answer for grading.");
            this.MathDrill_SubmitBtn.UseVisualStyleBackColor = true;
            this.MathDrill_SubmitBtn.Click += new System.EventHandler(this.MathDrill_SubmitBtn_Click);
            // 
            // MathDrill_ResponseLbl
            // 
            this.MathDrill_ResponseLbl.AutoSize = true;
            this.MathDrill_ResponseLbl.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_ResponseLbl.Location = new System.Drawing.Point(286, 138);
            this.MathDrill_ResponseLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.MathDrill_OfLbl.Location = new System.Drawing.Point(267, 20);
            this.MathDrill_OfLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MathDrill_OfLbl.Name = "MathDrill_OfLbl";
            this.MathDrill_OfLbl.Size = new System.Drawing.Size(32, 27);
            this.MathDrill_OfLbl.TabIndex = 16;
            this.MathDrill_OfLbl.Text = "of";
            // 
            // MathDrill_ProblemLbl
            // 
            this.MathDrill_ProblemLbl.AutoSize = true;
            this.MathDrill_ProblemLbl.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_ProblemLbl.Location = new System.Drawing.Point(87, 20);
            this.MathDrill_ProblemLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MathDrill_ProblemLbl.Name = "MathDrill_ProblemLbl";
            this.MathDrill_ProblemLbl.Size = new System.Drawing.Size(93, 27);
            this.MathDrill_ProblemLbl.TabIndex = 9;
            this.MathDrill_ProblemLbl.Text = "Problem";
            // 
            // MathDrill_CurrentNumLbl
            // 
            this.MathDrill_CurrentNumLbl.AutoSize = true;
            this.MathDrill_CurrentNumLbl.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_CurrentNumLbl.Location = new System.Drawing.Point(207, 20);
            this.MathDrill_CurrentNumLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MathDrill_CurrentNumLbl.Name = "MathDrill_CurrentNumLbl";
            this.MathDrill_CurrentNumLbl.Size = new System.Drawing.Size(48, 27);
            this.MathDrill_CurrentNumLbl.TabIndex = 15;
            this.MathDrill_CurrentNumLbl.Text = "<#>";
            // 
            // MathDrill_ProblemPrompt
            // 
            this.MathDrill_ProblemPrompt.AutoSize = true;
            this.MathDrill_ProblemPrompt.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_ProblemPrompt.Location = new System.Drawing.Point(83, 82);
            this.MathDrill_ProblemPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.MathDrill_DateLbl.Location = new System.Drawing.Point(354, 16);
            this.MathDrill_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MathDrill_DateLbl.Name = "MathDrill_DateLbl";
            this.MathDrill_DateLbl.Size = new System.Drawing.Size(59, 22);
            this.MathDrill_DateLbl.TabIndex = 7;
            this.MathDrill_DateLbl.Text = "<Date>";
            // 
            // MathDrill_StudentNameLbl
            // 
            this.MathDrill_StudentNameLbl.AutoSize = true;
            this.MathDrill_StudentNameLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_StudentNameLbl.Location = new System.Drawing.Point(8, 41);
            this.MathDrill_StudentNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.MathDrill_TimeLbl.Location = new System.Drawing.Point(354, 41);
            this.MathDrill_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MathDrill_TimeLbl.Name = "MathDrill_TimeLbl";
            this.MathDrill_TimeLbl.Size = new System.Drawing.Size(62, 22);
            this.MathDrill_TimeLbl.TabIndex = 24;
            this.MathDrill_TimeLbl.Text = "<Time>";
            // 
            // MathDrill_WindowLbl
            // 
            this.MathDrill_WindowLbl.AutoSize = true;
            this.MathDrill_WindowLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_WindowLbl.Location = new System.Drawing.Point(8, 16);
            this.MathDrill_WindowLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MathDrill_WindowLbl.Name = "MathDrill_WindowLbl";
            this.MathDrill_WindowLbl.Size = new System.Drawing.Size(81, 22);
            this.MathDrill_WindowLbl.TabIndex = 26;
            this.MathDrill_WindowLbl.Text = "Math Drill";
            // 
            // MathDrill_UserInfoBox
            // 
            this.MathDrill_UserInfoBox.Controls.Add(this.MathDrill_WindowLbl);
            this.MathDrill_UserInfoBox.Controls.Add(this.MathDrill_TimeLbl);
            this.MathDrill_UserInfoBox.Controls.Add(this.MathDrill_StudentNameLbl);
            this.MathDrill_UserInfoBox.Controls.Add(this.MathDrill_DateLbl);
            this.MathDrill_UserInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MathDrill_UserInfoBox.Location = new System.Drawing.Point(4, 4);
            this.MathDrill_UserInfoBox.Margin = new System.Windows.Forms.Padding(4);
            this.MathDrill_UserInfoBox.Name = "MathDrill_UserInfoBox";
            this.MathDrill_UserInfoBox.Padding = new System.Windows.Forms.Padding(4);
            this.MathDrill_UserInfoBox.Size = new System.Drawing.Size(474, 80);
            this.MathDrill_UserInfoBox.TabIndex = 0;
            this.MathDrill_UserInfoBox.TabStop = false;
            // 
            // MatDri_ButtonBox
            // 
            this.MatDri_ButtonBox.Controls.Add(this.MathDrill_QuitBtn);
            this.MatDri_ButtonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatDri_ButtonBox.Location = new System.Drawing.Point(4, 366);
            this.MatDri_ButtonBox.Margin = new System.Windows.Forms.Padding(4);
            this.MatDri_ButtonBox.Name = "MatDri_ButtonBox";
            this.MatDri_ButtonBox.Padding = new System.Windows.Forms.Padding(4);
            this.MatDri_ButtonBox.Size = new System.Drawing.Size(474, 83);
            this.MatDri_ButtonBox.TabIndex = 2;
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
            this.MathDrill_ProblemBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MathDrill_ProblemBox.Location = new System.Drawing.Point(4, 92);
            this.MathDrill_ProblemBox.Margin = new System.Windows.Forms.Padding(4);
            this.MathDrill_ProblemBox.Name = "MathDrill_ProblemBox";
            this.MathDrill_ProblemBox.Padding = new System.Windows.Forms.Padding(4);
            this.MathDrill_ProblemBox.Size = new System.Drawing.Size(474, 266);
            this.MathDrill_ProblemBox.TabIndex = 1;
            this.MathDrill_ProblemBox.TabStop = false;
            // 
            // MathDrill_TotalNumberLbl
            // 
            this.MathDrill_TotalNumberLbl.AutoSize = true;
            this.MathDrill_TotalNumberLbl.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathDrill_TotalNumberLbl.Location = new System.Drawing.Point(304, 20);
            this.MathDrill_TotalNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MathDrill_TotalNumberLbl.Name = "MathDrill_TotalNumberLbl";
            this.MathDrill_TotalNumberLbl.Size = new System.Drawing.Size(48, 27);
            this.MathDrill_TotalNumberLbl.TabIndex = 26;
            this.MathDrill_TotalNumberLbl.Text = "<#>";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MatDri_ButtonBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MathDrill_UserInfoBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MathDrill_ProblemBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.50142F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.49857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 453);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // doNothingContextMenu
            // 
            this.doNothingContextMenu.Name = "doNothingContextMenu";
            this.doNothingContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // MathDrill_Form
            // 
            this.AcceptButton = this.MathDrill_SubmitBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MathDrill_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.MathDrill_UserInfoBox.ResumeLayout(false);
            this.MathDrill_UserInfoBox.PerformLayout();
            this.MatDri_ButtonBox.ResumeLayout(false);
            this.MathDrill_ProblemBox.ResumeLayout(false);
            this.MathDrill_ProblemBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip doNothingContextMenu;
    }
}