namespace RaptorMath
{
    partial class UseDesg_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseDesg_Form));
            this.UseDesg_DateLbl = new System.Windows.Forms.Label();
            this.UseDesg_ExitBtn = new System.Windows.Forms.Button();
            this.UseDesg_Timer = new System.Windows.Forms.Timer(this.components);
            this.UseDesg_LoginBox = new System.Windows.Forms.GroupBox();
            this.UseDesg_LoginCmbo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UseDesg_passwordBox = new System.Windows.Forms.TextBox();
            this.UseDesg_LoginBtn = new System.Windows.Forms.Button();
            this.UseDesg_WindowLbl = new System.Windows.Forms.Label();
            this.UseDesg_TimeLbl = new System.Windows.Forms.Label();
            this.UseDesg_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.UseDesg_ButtonBox = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UseDesg_LoginBox.SuspendLayout();
            this.UseDesg_UserInfoBox.SuspendLayout();
            this.UseDesg_ButtonBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UseDesg_DateLbl
            // 
            this.UseDesg_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseDesg_DateLbl.AutoSize = true;
            this.UseDesg_DateLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesg_DateLbl.Location = new System.Drawing.Point(378, 10);
            this.UseDesg_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UseDesg_DateLbl.Name = "UseDesg_DateLbl";
            this.UseDesg_DateLbl.Size = new System.Drawing.Size(74, 26);
            this.UseDesg_DateLbl.TabIndex = 9;
            this.UseDesg_DateLbl.Text = "<Date>";
            // 
            // UseDesg_ExitBtn
            // 
            this.UseDesg_ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UseDesg_ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UseDesg_ExitBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesg_ExitBtn.Location = new System.Drawing.Point(331, 22);
            this.UseDesg_ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UseDesg_ExitBtn.Name = "UseDesg_ExitBtn";
            this.UseDesg_ExitBtn.Size = new System.Drawing.Size(125, 40);
            this.UseDesg_ExitBtn.TabIndex = 0;
            this.UseDesg_ExitBtn.Text = "Exit";
            this.UseDesg_ExitBtn.UseVisualStyleBackColor = true;
            this.UseDesg_ExitBtn.Click += new System.EventHandler(this.UseDesg_ExitBtn_Click);
            // 
            // UseDesg_Timer
            // 
            this.UseDesg_Timer.Enabled = true;
            this.UseDesg_Timer.Interval = 1000;
            this.UseDesg_Timer.Tick += new System.EventHandler(this.UseDesg_Timer_Tick);
            // 
            // UseDesg_LoginBox
            // 
            this.UseDesg_LoginBox.Controls.Add(this.UseDesg_LoginCmbo);
            this.UseDesg_LoginBox.Controls.Add(this.label2);
            this.UseDesg_LoginBox.Controls.Add(this.label1);
            this.UseDesg_LoginBox.Controls.Add(this.UseDesg_passwordBox);
            this.UseDesg_LoginBox.Controls.Add(this.UseDesg_LoginBtn);
            this.UseDesg_LoginBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UseDesg_LoginBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesg_LoginBox.Location = new System.Drawing.Point(4, 97);
            this.UseDesg_LoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.UseDesg_LoginBox.Name = "UseDesg_LoginBox";
            this.UseDesg_LoginBox.Padding = new System.Windows.Forms.Padding(4);
            this.UseDesg_LoginBox.Size = new System.Drawing.Size(474, 265);
            this.UseDesg_LoginBox.TabIndex = 1;
            this.UseDesg_LoginBox.TabStop = false;
            this.UseDesg_LoginBox.Text = "Select Your Name";
            // 
            // UseDesg_LoginCmbo
            // 
            this.UseDesg_LoginCmbo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.UseDesg_LoginCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UseDesg_LoginCmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UseDesg_LoginCmbo.FormattingEnabled = true;
            this.UseDesg_LoginCmbo.Location = new System.Drawing.Point(153, 69);
            this.UseDesg_LoginCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.UseDesg_LoginCmbo.MaxLength = 25;
            this.UseDesg_LoginCmbo.Name = "UseDesg_LoginCmbo";
            this.UseDesg_LoginCmbo.Size = new System.Drawing.Size(227, 34);
            this.UseDesg_LoginCmbo.TabIndex = 0;
            this.UseDesg_LoginCmbo.SelectedIndexChanged += new System.EventHandler(this.UseDesg_LoginCmbo_TextChanged);
            this.UseDesg_LoginCmbo.TextChanged += new System.EventHandler(this.UseDesg_LoginCmbo_TextChanged);
            this.UseDesg_LoginCmbo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_LettersKeyDown);
            this.UseDesg_LoginCmbo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // UseDesg_passwordBox
            // 
            this.UseDesg_passwordBox.Location = new System.Drawing.Point(152, 115);
            this.UseDesg_passwordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UseDesg_passwordBox.MaxLength = 20;
            this.UseDesg_passwordBox.Name = "UseDesg_passwordBox";
            this.UseDesg_passwordBox.Size = new System.Drawing.Size(228, 31);
            this.UseDesg_passwordBox.TabIndex = 1;
            this.UseDesg_passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            this.UseDesg_passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_LettersAndDigitsKeyDown);
            this.UseDesg_passwordBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_KeyUp);
            // 
            // UseDesg_LoginBtn
            // 
            this.UseDesg_LoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UseDesg_LoginBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesg_LoginBtn.Location = new System.Drawing.Point(191, 152);
            this.UseDesg_LoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UseDesg_LoginBtn.Name = "UseDesg_LoginBtn";
            this.UseDesg_LoginBtn.Size = new System.Drawing.Size(125, 40);
            this.UseDesg_LoginBtn.TabIndex = 2;
            this.UseDesg_LoginBtn.Text = "Login";
            this.UseDesg_LoginBtn.UseVisualStyleBackColor = true;
            this.UseDesg_LoginBtn.Click += new System.EventHandler(this.UseDesg_LoginBtn_Click);
            // 
            // UseDesg_WindowLbl
            // 
            this.UseDesg_WindowLbl.AutoSize = true;
            this.UseDesg_WindowLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesg_WindowLbl.Location = new System.Drawing.Point(8, 10);
            this.UseDesg_WindowLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UseDesg_WindowLbl.Name = "UseDesg_WindowLbl";
            this.UseDesg_WindowLbl.Size = new System.Drawing.Size(62, 26);
            this.UseDesg_WindowLbl.TabIndex = 15;
            this.UseDesg_WindowLbl.Text = "Login";
            // 
            // UseDesg_TimeLbl
            // 
            this.UseDesg_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseDesg_TimeLbl.AutoSize = true;
            this.UseDesg_TimeLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesg_TimeLbl.Location = new System.Drawing.Point(378, 42);
            this.UseDesg_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UseDesg_TimeLbl.Name = "UseDesg_TimeLbl";
            this.UseDesg_TimeLbl.Size = new System.Drawing.Size(78, 26);
            this.UseDesg_TimeLbl.TabIndex = 11;
            this.UseDesg_TimeLbl.Text = "<Time>";
            // 
            // UseDesg_UserInfoBox
            // 
            this.UseDesg_UserInfoBox.Controls.Add(this.UseDesg_WindowLbl);
            this.UseDesg_UserInfoBox.Controls.Add(this.UseDesg_DateLbl);
            this.UseDesg_UserInfoBox.Controls.Add(this.UseDesg_TimeLbl);
            this.UseDesg_UserInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UseDesg_UserInfoBox.Location = new System.Drawing.Point(4, 4);
            this.UseDesg_UserInfoBox.Margin = new System.Windows.Forms.Padding(4);
            this.UseDesg_UserInfoBox.Name = "UseDesg_UserInfoBox";
            this.UseDesg_UserInfoBox.Padding = new System.Windows.Forms.Padding(4);
            this.UseDesg_UserInfoBox.Size = new System.Drawing.Size(474, 85);
            this.UseDesg_UserInfoBox.TabIndex = 0;
            this.UseDesg_UserInfoBox.TabStop = false;
            // 
            // UseDesg_ButtonBox
            // 
            this.UseDesg_ButtonBox.Controls.Add(this.UseDesg_ExitBtn);
            this.UseDesg_ButtonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UseDesg_ButtonBox.Location = new System.Drawing.Point(4, 370);
            this.UseDesg_ButtonBox.Margin = new System.Windows.Forms.Padding(4);
            this.UseDesg_ButtonBox.Name = "UseDesg_ButtonBox";
            this.UseDesg_ButtonBox.Padding = new System.Windows.Forms.Padding(4);
            this.UseDesg_ButtonBox.Size = new System.Drawing.Size(474, 79);
            this.UseDesg_ButtonBox.TabIndex = 2;
            this.UseDesg_ButtonBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.UseDesg_ButtonBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UseDesg_LoginBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UseDesg_UserInfoBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.4902F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.5098F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 453);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // UseDesg_Form
            // 
            this.AcceptButton = this.UseDesg_LoginBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.UseDesg_ExitBtn;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UseDesg_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.UseDesg_LoginBox.ResumeLayout(false);
            this.UseDesg_LoginBox.PerformLayout();
            this.UseDesg_UserInfoBox.ResumeLayout(false);
            this.UseDesg_UserInfoBox.PerformLayout();
            this.UseDesg_ButtonBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UseDesg_DateLbl;
        private System.Windows.Forms.Button UseDesg_ExitBtn;
        private System.Windows.Forms.Timer UseDesg_Timer;
        private System.Windows.Forms.GroupBox UseDesg_LoginBox;
        private System.Windows.Forms.TextBox UseDesg_passwordBox;
        private System.Windows.Forms.Button UseDesg_LoginBtn;
        private System.Windows.Forms.Label UseDesg_WindowLbl;
        private System.Windows.Forms.Label UseDesg_TimeLbl;
        private System.Windows.Forms.GroupBox UseDesg_UserInfoBox;
        private System.Windows.Forms.GroupBox UseDesg_ButtonBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox UseDesg_LoginCmbo;


    }
}

