namespace RaptorMath
{
    partial class StuHome_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuHome_Form));
            this.StuHome_NumQuestionsLbl = new System.Windows.Forms.Label();
            this.StuHome_TotalNumLbl = new System.Windows.Forms.Label();
            this.StuHome_DrillBox = new System.Windows.Forms.GroupBox();
            this.StuHome_DrillDdl = new System.Windows.Forms.ComboBox();
            this.StuHome_ChooseLbl = new System.Windows.Forms.Label();
            this.StuHome_StartDrillBtn = new System.Windows.Forms.Button();
            this.StuHome_Timer = new System.Windows.Forms.Timer(this.components);
            this.StuHome_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.StuHome_WindowLbl = new System.Windows.Forms.Label();
            this.StuHome_TimeLbl = new System.Windows.Forms.Label();
            this.StuHome_DateLbl = new System.Windows.Forms.Label();
            this.StuHome_WelcomeLbl = new System.Windows.Forms.Label();
            this.StuHome_LoginDateLbl = new System.Windows.Forms.Label();
            this.StuHome_LastLoginLbl = new System.Windows.Forms.Label();
            this.StuHome_StudentNameLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StuHome_CoinBox = new System.Windows.Forms.GroupBox();
            this.StuHome_CoinPic = new System.Windows.Forms.PictureBox();
            this.StuHome_CoinTxt = new System.Windows.Forms.RichTextBox();
            this.StuHome_ButtonBox = new System.Windows.Forms.GroupBox();
            this.StuHome_LogoutBtn = new System.Windows.Forms.Button();
            this.StuHome_ExitBtn = new System.Windows.Forms.Button();
            this.StuHome_DrillBox.SuspendLayout();
            this.StuHome_UserInfoBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.StuHome_CoinBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuHome_CoinPic)).BeginInit();
            this.StuHome_ButtonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StuHome_NumQuestionsLbl
            // 
            this.StuHome_NumQuestionsLbl.AutoSize = true;
            this.StuHome_NumQuestionsLbl.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_NumQuestionsLbl.Location = new System.Drawing.Point(41, 117);
            this.StuHome_NumQuestionsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_NumQuestionsLbl.Name = "StuHome_NumQuestionsLbl";
            this.StuHome_NumQuestionsLbl.Size = new System.Drawing.Size(135, 27);
            this.StuHome_NumQuestionsLbl.TabIndex = 2;
            this.StuHome_NumQuestionsLbl.Text = "There will be";
            // 
            // StuHome_TotalNumLbl
            // 
            this.StuHome_TotalNumLbl.AutoSize = true;
            this.StuHome_TotalNumLbl.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_TotalNumLbl.Location = new System.Drawing.Point(213, 117);
            this.StuHome_TotalNumLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_TotalNumLbl.Name = "StuHome_TotalNumLbl";
            this.StuHome_TotalNumLbl.Size = new System.Drawing.Size(147, 27);
            this.StuHome_TotalNumLbl.TabIndex = 3;
            this.StuHome_TotalNumLbl.Text = "<#> questions.";
            // 
            // StuHome_DrillBox
            // 
            this.StuHome_DrillBox.Controls.Add(this.StuHome_DrillDdl);
            this.StuHome_DrillBox.Controls.Add(this.StuHome_TotalNumLbl);
            this.StuHome_DrillBox.Controls.Add(this.StuHome_ChooseLbl);
            this.StuHome_DrillBox.Controls.Add(this.StuHome_NumQuestionsLbl);
            this.StuHome_DrillBox.Controls.Add(this.StuHome_StartDrillBtn);
            this.StuHome_DrillBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuHome_DrillBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_DrillBox.Location = new System.Drawing.Point(4, 124);
            this.StuHome_DrillBox.Margin = new System.Windows.Forms.Padding(4);
            this.StuHome_DrillBox.Name = "StuHome_DrillBox";
            this.StuHome_DrillBox.Padding = new System.Windows.Forms.Padding(4);
            this.StuHome_DrillBox.Size = new System.Drawing.Size(474, 250);
            this.StuHome_DrillBox.TabIndex = 1;
            this.StuHome_DrillBox.TabStop = false;
            // 
            // StuHome_DrillDdl
            // 
            this.StuHome_DrillDdl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StuHome_DrillDdl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StuHome_DrillDdl.FormattingEnabled = true;
            this.StuHome_DrillDdl.Location = new System.Drawing.Point(112, 67);
            this.StuHome_DrillDdl.Margin = new System.Windows.Forms.Padding(4);
            this.StuHome_DrillDdl.MaxDropDownItems = 100;
            this.StuHome_DrillDdl.Name = "StuHome_DrillDdl";
            this.StuHome_DrillDdl.Size = new System.Drawing.Size(223, 30);
            this.StuHome_DrillDdl.TabIndex = 0;
            this.StuHome_DrillDdl.SelectionChangeCommitted += new System.EventHandler(this.StuHome_DrillDdl_SelectionChangeCommitted);
            // 
            // StuHome_ChooseLbl
            // 
            this.StuHome_ChooseLbl.AutoSize = true;
            this.StuHome_ChooseLbl.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_ChooseLbl.Location = new System.Drawing.Point(84, 28);
            this.StuHome_ChooseLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_ChooseLbl.Name = "StuHome_ChooseLbl";
            this.StuHome_ChooseLbl.Size = new System.Drawing.Size(234, 27);
            this.StuHome_ChooseLbl.TabIndex = 2;
            this.StuHome_ChooseLbl.Text = "Choose your adventure!";
            // 
            // StuHome_StartDrillBtn
            // 
            this.StuHome_StartDrillBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StuHome_StartDrillBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_StartDrillBtn.Location = new System.Drawing.Point(164, 156);
            this.StuHome_StartDrillBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StuHome_StartDrillBtn.Name = "StuHome_StartDrillBtn";
            this.StuHome_StartDrillBtn.Size = new System.Drawing.Size(125, 40);
            this.StuHome_StartDrillBtn.TabIndex = 1;
            this.StuHome_StartDrillBtn.Text = "Start";
            this.StuHome_StartDrillBtn.UseVisualStyleBackColor = true;
            this.StuHome_StartDrillBtn.Click += new System.EventHandler(this.StuHome_StartDrillBtn_Click);
            // 
            // StuHome_Timer
            // 
            this.StuHome_Timer.Enabled = true;
            this.StuHome_Timer.Interval = 1000;
            this.StuHome_Timer.Tick += new System.EventHandler(this.StuHome_Timer_Tick);
            // 
            // StuHome_UserInfoBox
            // 
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_WindowLbl);
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_TimeLbl);
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_DateLbl);
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_WelcomeLbl);
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_LoginDateLbl);
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_LastLoginLbl);
            this.StuHome_UserInfoBox.Controls.Add(this.StuHome_StudentNameLbl);
            this.StuHome_UserInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuHome_UserInfoBox.Location = new System.Drawing.Point(4, 4);
            this.StuHome_UserInfoBox.Margin = new System.Windows.Forms.Padding(4);
            this.StuHome_UserInfoBox.Name = "StuHome_UserInfoBox";
            this.StuHome_UserInfoBox.Padding = new System.Windows.Forms.Padding(4);
            this.StuHome_UserInfoBox.Size = new System.Drawing.Size(474, 112);
            this.StuHome_UserInfoBox.TabIndex = 0;
            this.StuHome_UserInfoBox.TabStop = false;
            // 
            // StuHome_WindowLbl
            // 
            this.StuHome_WindowLbl.AutoSize = true;
            this.StuHome_WindowLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_WindowLbl.Location = new System.Drawing.Point(11, 14);
            this.StuHome_WindowLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_WindowLbl.Name = "StuHome_WindowLbl";
            this.StuHome_WindowLbl.Size = new System.Drawing.Size(115, 22);
            this.StuHome_WindowLbl.TabIndex = 23;
            this.StuHome_WindowLbl.Text = "Student Home";
            // 
            // StuHome_TimeLbl
            // 
            this.StuHome_TimeLbl.AutoSize = true;
            this.StuHome_TimeLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_TimeLbl.Location = new System.Drawing.Point(374, 54);
            this.StuHome_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_TimeLbl.Name = "StuHome_TimeLbl";
            this.StuHome_TimeLbl.Size = new System.Drawing.Size(62, 22);
            this.StuHome_TimeLbl.TabIndex = 22;
            this.StuHome_TimeLbl.Text = "<Time>";
            // 
            // StuHome_DateLbl
            // 
            this.StuHome_DateLbl.AutoSize = true;
            this.StuHome_DateLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_DateLbl.Location = new System.Drawing.Point(374, 19);
            this.StuHome_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_DateLbl.Name = "StuHome_DateLbl";
            this.StuHome_DateLbl.Size = new System.Drawing.Size(59, 22);
            this.StuHome_DateLbl.TabIndex = 19;
            this.StuHome_DateLbl.Text = "<Date>";
            // 
            // StuHome_WelcomeLbl
            // 
            this.StuHome_WelcomeLbl.AutoSize = true;
            this.StuHome_WelcomeLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_WelcomeLbl.Location = new System.Drawing.Point(11, 39);
            this.StuHome_WelcomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_WelcomeLbl.Name = "StuHome_WelcomeLbl";
            this.StuHome_WelcomeLbl.Size = new System.Drawing.Size(83, 22);
            this.StuHome_WelcomeLbl.TabIndex = 17;
            this.StuHome_WelcomeLbl.Text = "Welcome,";
            // 
            // StuHome_LoginDateLbl
            // 
            this.StuHome_LoginDateLbl.AutoSize = true;
            this.StuHome_LoginDateLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_LoginDateLbl.Location = new System.Drawing.Point(117, 66);
            this.StuHome_LoginDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_LoginDateLbl.Name = "StuHome_LoginDateLbl";
            this.StuHome_LoginDateLbl.Size = new System.Drawing.Size(59, 22);
            this.StuHome_LoginDateLbl.TabIndex = 21;
            this.StuHome_LoginDateLbl.Text = "<Date>";
            // 
            // StuHome_LastLoginLbl
            // 
            this.StuHome_LastLoginLbl.AutoSize = true;
            this.StuHome_LastLoginLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_LastLoginLbl.Location = new System.Drawing.Point(11, 66);
            this.StuHome_LastLoginLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_LastLoginLbl.Name = "StuHome_LastLoginLbl";
            this.StuHome_LastLoginLbl.Size = new System.Drawing.Size(83, 22);
            this.StuHome_LastLoginLbl.TabIndex = 18;
            this.StuHome_LastLoginLbl.Text = "Last login:";
            // 
            // StuHome_StudentNameLbl
            // 
            this.StuHome_StudentNameLbl.AutoSize = true;
            this.StuHome_StudentNameLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_StudentNameLbl.Location = new System.Drawing.Point(117, 39);
            this.StuHome_StudentNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuHome_StudentNameLbl.Name = "StuHome_StudentNameLbl";
            this.StuHome_StudentNameLbl.Size = new System.Drawing.Size(80, 22);
            this.StuHome_StudentNameLbl.TabIndex = 20;
            this.StuHome_StudentNameLbl.Text = "<Student>";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.StuHome_DrillBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.StuHome_UserInfoBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.83183F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.16817F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 453);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.tableLayoutPanel2.Controls.Add(this.StuHome_CoinBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.StuHome_ButtonBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 380);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(476, 71);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // StuHome_CoinBox
            // 
            this.StuHome_CoinBox.Controls.Add(this.StuHome_CoinPic);
            this.StuHome_CoinBox.Controls.Add(this.StuHome_CoinTxt);
            this.StuHome_CoinBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuHome_CoinBox.Location = new System.Drawing.Point(4, 4);
            this.StuHome_CoinBox.Margin = new System.Windows.Forms.Padding(4);
            this.StuHome_CoinBox.Name = "StuHome_CoinBox";
            this.StuHome_CoinBox.Padding = new System.Windows.Forms.Padding(4);
            this.StuHome_CoinBox.Size = new System.Drawing.Size(189, 63);
            this.StuHome_CoinBox.TabIndex = 2;
            this.StuHome_CoinBox.TabStop = false;
            // 
            // StuHome_CoinPic
            // 
            this.StuHome_CoinPic.Location = new System.Drawing.Point(0, 0);
            this.StuHome_CoinPic.Margin = new System.Windows.Forms.Padding(4);
            this.StuHome_CoinPic.Name = "StuHome_CoinPic";
            this.StuHome_CoinPic.Size = new System.Drawing.Size(71, 60);
            this.StuHome_CoinPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StuHome_CoinPic.TabIndex = 27;
            this.StuHome_CoinPic.TabStop = false;
            // 
            // StuHome_CoinTxt
            // 
            this.StuHome_CoinTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.StuHome_CoinTxt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_CoinTxt.Location = new System.Drawing.Point(76, 14);
            this.StuHome_CoinTxt.Margin = new System.Windows.Forms.Padding(4);
            this.StuHome_CoinTxt.Multiline = false;
            this.StuHome_CoinTxt.Name = "StuHome_CoinTxt";
            this.StuHome_CoinTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.StuHome_CoinTxt.Size = new System.Drawing.Size(112, 35);
            this.StuHome_CoinTxt.TabIndex = 1;
            this.StuHome_CoinTxt.TabStop = false;
            this.StuHome_CoinTxt.Text = "";
            // 
            // StuHome_ButtonBox
            // 
            this.StuHome_ButtonBox.Controls.Add(this.StuHome_LogoutBtn);
            this.StuHome_ButtonBox.Controls.Add(this.StuHome_ExitBtn);
            this.StuHome_ButtonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuHome_ButtonBox.Location = new System.Drawing.Point(201, 4);
            this.StuHome_ButtonBox.Margin = new System.Windows.Forms.Padding(4);
            this.StuHome_ButtonBox.Name = "StuHome_ButtonBox";
            this.StuHome_ButtonBox.Padding = new System.Windows.Forms.Padding(4);
            this.StuHome_ButtonBox.Size = new System.Drawing.Size(271, 63);
            this.StuHome_ButtonBox.TabIndex = 3;
            this.StuHome_ButtonBox.TabStop = false;
            // 
            // StuHome_LogoutBtn
            // 
            this.StuHome_LogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StuHome_LogoutBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.StuHome_LogoutBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_LogoutBtn.Location = new System.Drawing.Point(7, 16);
            this.StuHome_LogoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StuHome_LogoutBtn.Name = "StuHome_LogoutBtn";
            this.StuHome_LogoutBtn.Size = new System.Drawing.Size(125, 40);
            this.StuHome_LogoutBtn.TabIndex = 0;
            this.StuHome_LogoutBtn.Text = "Logout";
            this.StuHome_LogoutBtn.UseVisualStyleBackColor = true;
            this.StuHome_LogoutBtn.Click += new System.EventHandler(this.StuHome_LogoutBtn_Click);
            // 
            // StuHome_ExitBtn
            // 
            this.StuHome_ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StuHome_ExitBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuHome_ExitBtn.Location = new System.Drawing.Point(140, 16);
            this.StuHome_ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StuHome_ExitBtn.Name = "StuHome_ExitBtn";
            this.StuHome_ExitBtn.Size = new System.Drawing.Size(125, 40);
            this.StuHome_ExitBtn.TabIndex = 1;
            this.StuHome_ExitBtn.Text = "Exit";
            this.StuHome_ExitBtn.UseVisualStyleBackColor = true;
            this.StuHome_ExitBtn.Click += new System.EventHandler(this.StuHome_ExitBtn_Click);
            // 
            // StuHome_Form
            // 
            this.AcceptButton = this.StuHome_StartDrillBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.StuHome_LogoutBtn;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StuHome_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.StuHome_DrillBox.ResumeLayout(false);
            this.StuHome_DrillBox.PerformLayout();
            this.StuHome_UserInfoBox.ResumeLayout(false);
            this.StuHome_UserInfoBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.StuHome_CoinBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StuHome_CoinPic)).EndInit();
            this.StuHome_ButtonBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label StuHome_NumQuestionsLbl;
        private System.Windows.Forms.Label StuHome_TotalNumLbl;
        private System.Windows.Forms.GroupBox StuHome_DrillBox;
        private System.Windows.Forms.Button StuHome_StartDrillBtn;
        private System.Windows.Forms.Timer StuHome_Timer;
        private System.Windows.Forms.GroupBox StuHome_UserInfoBox;
        private System.Windows.Forms.ComboBox StuHome_DrillDdl;
        private System.Windows.Forms.Label StuHome_ChooseLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox StuHome_CoinBox;
        private System.Windows.Forms.PictureBox StuHome_CoinPic;
        private System.Windows.Forms.RichTextBox StuHome_CoinTxt;
        private System.Windows.Forms.GroupBox StuHome_ButtonBox;
        private System.Windows.Forms.Button StuHome_LogoutBtn;
        private System.Windows.Forms.Button StuHome_ExitBtn;
        private System.Windows.Forms.Label StuHome_WindowLbl;
        private System.Windows.Forms.Label StuHome_TimeLbl;
        private System.Windows.Forms.Label StuHome_DateLbl;
        private System.Windows.Forms.Label StuHome_WelcomeLbl;
        private System.Windows.Forms.Label StuHome_LoginDateLbl;
        private System.Windows.Forms.Label StuHome_LastLoginLbl;
        private System.Windows.Forms.Label StuHome_StudentNameLbl;


    }
}