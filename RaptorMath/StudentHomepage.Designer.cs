namespace RaptorMath
{
    partial class StudentHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentHomepage));
            this.StuHome_WindowLbl = new System.Windows.Forms.Label();
            this.StuHome_TimeLbl = new System.Windows.Forms.Label();
            this.StuHome_DateLbl = new System.Windows.Forms.Label();
            this.StuHome_LoginDateLbl = new System.Windows.Forms.Label();
            this.StuHome_LastLoginLbl = new System.Windows.Forms.Label();
            this.StuHome_StudentNameLbl = new System.Windows.Forms.Label();
            this.StuHome_DrillDdl = new System.Windows.Forms.ComboBox();
            this.StuHome_StartDrillBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.StuHome_LogoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StuHome_Timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // StuHome_WindowLbl
            // 
            this.StuHome_WindowLbl.AutoSize = true;
            this.StuHome_WindowLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_WindowLbl.Location = new System.Drawing.Point(13, 9);
            this.StuHome_WindowLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_WindowLbl.Name = "StuHome_WindowLbl";
            this.StuHome_WindowLbl.Size = new System.Drawing.Size(0, 22);
            this.StuHome_WindowLbl.TabIndex = 30;
            // 
            // StuHome_TimeLbl
            // 
            this.StuHome_TimeLbl.AutoSize = true;
            this.StuHome_TimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.StuHome_TimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_TimeLbl.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.StuHome_TimeLbl.Location = new System.Drawing.Point(685, 40);
            this.StuHome_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_TimeLbl.Name = "StuHome_TimeLbl";
            this.StuHome_TimeLbl.Size = new System.Drawing.Size(75, 24);
            this.StuHome_TimeLbl.TabIndex = 29;
            this.StuHome_TimeLbl.Text = "<Time>";
            // 
            // StuHome_DateLbl
            // 
            this.StuHome_DateLbl.AutoSize = true;
            this.StuHome_DateLbl.BackColor = System.Drawing.Color.Transparent;
            this.StuHome_DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_DateLbl.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.StuHome_DateLbl.Location = new System.Drawing.Point(594, 40);
            this.StuHome_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_DateLbl.Name = "StuHome_DateLbl";
            this.StuHome_DateLbl.Size = new System.Drawing.Size(70, 24);
            this.StuHome_DateLbl.TabIndex = 26;
            this.StuHome_DateLbl.Text = "<Date>";
            // 
            // StuHome_LoginDateLbl
            // 
            this.StuHome_LoginDateLbl.AutoSize = true;
            this.StuHome_LoginDateLbl.BackColor = System.Drawing.Color.Transparent;
            this.StuHome_LoginDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_LoginDateLbl.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.StuHome_LoginDateLbl.Location = new System.Drawing.Point(685, 9);
            this.StuHome_LoginDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_LoginDateLbl.Name = "StuHome_LoginDateLbl";
            this.StuHome_LoginDateLbl.Size = new System.Drawing.Size(70, 24);
            this.StuHome_LoginDateLbl.TabIndex = 28;
            this.StuHome_LoginDateLbl.Text = "<Date>";
            // 
            // StuHome_LastLoginLbl
            // 
            this.StuHome_LastLoginLbl.AutoSize = true;
            this.StuHome_LastLoginLbl.BackColor = System.Drawing.Color.Transparent;
            this.StuHome_LastLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_LastLoginLbl.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.StuHome_LastLoginLbl.Location = new System.Drawing.Point(583, 9);
            this.StuHome_LastLoginLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_LastLoginLbl.Name = "StuHome_LastLoginLbl";
            this.StuHome_LastLoginLbl.Size = new System.Drawing.Size(94, 24);
            this.StuHome_LastLoginLbl.TabIndex = 25;
            this.StuHome_LastLoginLbl.Text = "Last login:";
            // 
            // StuHome_StudentNameLbl
            // 
            this.StuHome_StudentNameLbl.AutoSize = true;
            this.StuHome_StudentNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.StuHome_StudentNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_StudentNameLbl.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.StuHome_StudentNameLbl.Location = new System.Drawing.Point(334, 91);
            this.StuHome_StudentNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_StudentNameLbl.Name = "StuHome_StudentNameLbl";
            this.StuHome_StudentNameLbl.Size = new System.Drawing.Size(110, 25);
            this.StuHome_StudentNameLbl.TabIndex = 27;
            this.StuHome_StudentNameLbl.Text = "<Student>";
            // 
            // StuHome_DrillDdl
            // 
            this.StuHome_DrillDdl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StuHome_DrillDdl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StuHome_DrillDdl.FormattingEnabled = true;
            this.StuHome_DrillDdl.Location = new System.Drawing.Point(291, 180);
            this.StuHome_DrillDdl.Margin = new System.Windows.Forms.Padding(4);
            this.StuHome_DrillDdl.MaxDropDownItems = 100;
            this.StuHome_DrillDdl.MaxLength = 25;
            this.StuHome_DrillDdl.Name = "StuHome_DrillDdl";
            this.StuHome_DrillDdl.Size = new System.Drawing.Size(223, 21);
            this.StuHome_DrillDdl.TabIndex = 31;
            this.StuHome_DrillDdl.SelectedIndexChanged += new System.EventHandler(this.StuHome_DrillDdl_SelectedIndexChanged);
            // 
            // StuHome_StartDrillBtn
            // 
            this.StuHome_StartDrillBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StuHome_StartDrillBtn.BackColor = System.Drawing.Color.Green;
            this.StuHome_StartDrillBtn.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_StartDrillBtn.ForeColor = System.Drawing.Color.Black;
            this.StuHome_StartDrillBtn.Location = new System.Drawing.Point(367, 209);
            this.StuHome_StartDrillBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StuHome_StartDrillBtn.Name = "StuHome_StartDrillBtn";
            this.StuHome_StartDrillBtn.Size = new System.Drawing.Size(77, 48);
            this.StuHome_StartDrillBtn.TabIndex = 32;
            this.StuHome_StartDrillBtn.Text = "Go!";
            this.StuHome_StartDrillBtn.UseVisualStyleBackColor = false;
            this.StuHome_StartDrillBtn.Click += new System.EventHandler(this.StuHome_StartDrillBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "studentHome2.jpg");
            // 
            // StuHome_LogoutBtn
            // 
            this.StuHome_LogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StuHome_LogoutBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.StuHome_LogoutBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_LogoutBtn.Location = new System.Drawing.Point(630, 379);
            this.StuHome_LogoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StuHome_LogoutBtn.Name = "StuHome_LogoutBtn";
            this.StuHome_LogoutBtn.Size = new System.Drawing.Size(125, 40);
            this.StuHome_LogoutBtn.TabIndex = 36;
            this.StuHome_LogoutBtn.Text = "Logout";
            this.StuHome_LogoutBtn.UseVisualStyleBackColor = true;
            this.StuHome_LogoutBtn.Click += new System.EventHandler(this.StuHome_LogoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 33);
            this.label1.TabIndex = 37;
            this.label1.Text = "Choose Your Adventure";
            // 
            // StudentHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StuHome_LogoutBtn);
            this.Controls.Add(this.StuHome_DrillDdl);
            this.Controls.Add(this.StuHome_StartDrillBtn);
            this.Controls.Add(this.StuHome_WindowLbl);
            this.Controls.Add(this.StuHome_TimeLbl);
            this.Controls.Add(this.StuHome_DateLbl);
            this.Controls.Add(this.StuHome_LoginDateLbl);
            this.Controls.Add(this.StuHome_LastLoginLbl);
            this.Controls.Add(this.StuHome_StudentNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaptorMath";
            this.Load += new System.EventHandler(this.StudentHomepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StuHome_WindowLbl;
        private System.Windows.Forms.Label StuHome_TimeLbl;
        private System.Windows.Forms.Label StuHome_DateLbl;
        private System.Windows.Forms.Label StuHome_LoginDateLbl;
        private System.Windows.Forms.Label StuHome_LastLoginLbl;
        private System.Windows.Forms.Label StuHome_StudentNameLbl;
        private System.Windows.Forms.ComboBox StuHome_DrillDdl;
        private System.Windows.Forms.Button StuHome_StartDrillBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button StuHome_LogoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer StuHome_Timer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}