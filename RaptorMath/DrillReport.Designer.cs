namespace RaptorMath
{
    partial class DrillReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrillReport));
            this.NameLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.StudentPercentageLbl = new System.Windows.Forms.Label();
            this.PercentageLbl = new System.Windows.Forms.Label();
            this.NumberIncorretLbl = new System.Windows.Forms.Label();
            this.CorrectLbl = new System.Windows.Forms.Label();
            this.IncorrectLbl = new System.Windows.Forms.Label();
            this.NumberCorrectlbl = new System.Windows.Forms.Label();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.dinoeggsearnedlbl = new System.Windows.Forms.Label();
            this.RewardsEarnedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(351, 173);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(300, 42);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "<Student Name>";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TitleLbl
            // 
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(345, 75);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(306, 73);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Results";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentPercentageLbl
            // 
            this.StudentPercentageLbl.AutoSize = true;
            this.StudentPercentageLbl.BackColor = System.Drawing.Color.Transparent;
            this.StudentPercentageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPercentageLbl.Location = new System.Drawing.Point(555, 243);
            this.StudentPercentageLbl.Name = "StudentPercentageLbl";
            this.StudentPercentageLbl.Size = new System.Drawing.Size(162, 24);
            this.StudentPercentageLbl.TabIndex = 2;
            this.StudentPercentageLbl.Text = "<drill percentage>";
            this.StudentPercentageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentPercentageLbl.Click += new System.EventHandler(this.StudentPercentageLbl_Click);
            // 
            // PercentageLbl
            // 
            this.PercentageLbl.AutoSize = true;
            this.PercentageLbl.BackColor = System.Drawing.Color.Transparent;
            this.PercentageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageLbl.Location = new System.Drawing.Point(360, 243);
            this.PercentageLbl.Name = "PercentageLbl";
            this.PercentageLbl.Size = new System.Drawing.Size(197, 24);
            this.PercentageLbl.TabIndex = 3;
            this.PercentageLbl.Text = "Percentage Correct:";
            // 
            // NumberIncorretLbl
            // 
            this.NumberIncorretLbl.AutoSize = true;
            this.NumberIncorretLbl.BackColor = System.Drawing.Color.Transparent;
            this.NumberIncorretLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberIncorretLbl.Location = new System.Drawing.Point(555, 365);
            this.NumberIncorretLbl.Name = "NumberIncorretLbl";
            this.NumberIncorretLbl.Size = new System.Drawing.Size(105, 24);
            this.NumberIncorretLbl.TabIndex = 4;
            this.NumberIncorretLbl.Text = "<incorrect>";
            this.NumberIncorretLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CorrectLbl
            // 
            this.CorrectLbl.AutoSize = true;
            this.CorrectLbl.BackColor = System.Drawing.Color.Transparent;
            this.CorrectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectLbl.Location = new System.Drawing.Point(373, 307);
            this.CorrectLbl.Name = "CorrectLbl";
            this.CorrectLbl.Size = new System.Drawing.Size(184, 24);
            this.CorrectLbl.TabIndex = 5;
            this.CorrectLbl.Text = "Questions Correct:";
            // 
            // IncorrectLbl
            // 
            this.IncorrectLbl.AutoSize = true;
            this.IncorrectLbl.BackColor = System.Drawing.Color.Transparent;
            this.IncorrectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectLbl.Location = new System.Drawing.Point(379, 365);
            this.IncorrectLbl.Name = "IncorrectLbl";
            this.IncorrectLbl.Size = new System.Drawing.Size(178, 24);
            this.IncorrectLbl.TabIndex = 6;
            this.IncorrectLbl.Text = "Questions Wrong:";
            // 
            // NumberCorrectlbl
            // 
            this.NumberCorrectlbl.AutoSize = true;
            this.NumberCorrectlbl.BackColor = System.Drawing.Color.Transparent;
            this.NumberCorrectlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberCorrectlbl.Location = new System.Drawing.Point(555, 307);
            this.NumberCorrectlbl.Name = "NumberCorrectlbl";
            this.NumberCorrectlbl.Size = new System.Drawing.Size(90, 24);
            this.NumberCorrectlbl.TabIndex = 7;
            this.NumberCorrectlbl.Text = "<correct>";
            this.NumberCorrectlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NumberCorrectlbl.Click += new System.EventHandler(this.NumberCorrectlbl_Click);
            // 
            // FinishBtn
            // 
            this.FinishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishBtn.Location = new System.Drawing.Point(452, 605);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(96, 44);
            this.FinishBtn.TabIndex = 1;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // dinoeggsearnedlbl
            // 
            this.dinoeggsearnedlbl.AutoSize = true;
            this.dinoeggsearnedlbl.BackColor = System.Drawing.Color.Transparent;
            this.dinoeggsearnedlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinoeggsearnedlbl.Image = global::RaptorMath.Properties.Resources.dinoegg1;
            this.dinoeggsearnedlbl.Location = new System.Drawing.Point(411, 403);
            this.dinoeggsearnedlbl.Name = "dinoeggsearnedlbl";
            this.dinoeggsearnedlbl.Size = new System.Drawing.Size(126, 144);
            this.dinoeggsearnedlbl.TabIndex = 10;
            this.dinoeggsearnedlbl.Text = "  \r\n\r\n     Eggs\r\n    Earned:   \r\n\r\n  ";
            // 
            // RewardsEarnedLbl
            // 
            this.RewardsEarnedLbl.AutoSize = true;
            this.RewardsEarnedLbl.BackColor = System.Drawing.Color.Transparent;
            this.RewardsEarnedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RewardsEarnedLbl.Location = new System.Drawing.Point(521, 450);
            this.RewardsEarnedLbl.Name = "RewardsEarnedLbl";
            this.RewardsEarnedLbl.Size = new System.Drawing.Size(110, 55);
            this.RewardsEarnedLbl.TabIndex = 11;
            this.RewardsEarnedLbl.Text = "<#>";
            this.RewardsEarnedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrillReport
            // 
            this.AcceptButton = this.FinishBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::RaptorMath.Properties.Resources.FreeVector_Jungle_Background;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.RewardsEarnedLbl);
            this.Controls.Add(this.dinoeggsearnedlbl);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.NumberCorrectlbl);
            this.Controls.Add(this.IncorrectLbl);
            this.Controls.Add(this.CorrectLbl);
            this.Controls.Add(this.NumberIncorretLbl);
            this.Controls.Add(this.PercentageLbl);
            this.Controls.Add(this.StudentPercentageLbl);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.NameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrillReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label StudentPercentageLbl;
        private System.Windows.Forms.Label PercentageLbl;
        private System.Windows.Forms.Label NumberIncorretLbl;
        private System.Windows.Forms.Label CorrectLbl;
        private System.Windows.Forms.Label IncorrectLbl;
        private System.Windows.Forms.Label NumberCorrectlbl;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Label dinoeggsearnedlbl;
        private System.Windows.Forms.Label RewardsEarnedLbl;
    }
}