namespace RaptorMath
{
    partial class EditStudents_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudents_Form));
            this.EditStu_WindowLbl = new System.Windows.Forms.Label();
            this.EditStu_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.EditStu_TimeLbl = new System.Windows.Forms.Label();
            this.EditStu_DateLbl = new System.Windows.Forms.Label();
            this.EditStu_AdminNameLbl = new System.Windows.Forms.Label();
            this.EditStu_SettingBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditStu_NewLastNameCmbo = new System.Windows.Forms.ComboBox();
            this.EditStu_GroupCmbo = new System.Windows.Forms.ComboBox();
            this.EditStu_NewFirstNameCmbo = new System.Windows.Forms.ComboBox();
            this.EditStu_SelectionCmbo = new System.Windows.Forms.ComboBox();
            this.EditStu_SaveStudentBtn = new System.Windows.Forms.Button();
            this.EditStu_GroupLbl = new System.Windows.Forms.Label();
            this.EditStu_NameLbl = new System.Windows.Forms.Label();
            this.EditStu_SelectStudentLbl = new System.Windows.Forms.Label();
            this.EditStu_ButtonBox = new System.Windows.Forms.GroupBox();
            this.EditStu_ExitBtn = new System.Windows.Forms.Button();
            this.EditStu_CloseBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EditStu_Timer = new System.Windows.Forms.Timer(this.components);
            this.EditStu_UserInfoBox.SuspendLayout();
            this.EditStu_SettingBox.SuspendLayout();
            this.EditStu_ButtonBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditStu_WindowLbl
            // 
            this.EditStu_WindowLbl.AutoSize = true;
            this.EditStu_WindowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStu_WindowLbl.Location = new System.Drawing.Point(8, 18);
            this.EditStu_WindowLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditStu_WindowLbl.Name = "EditStu_WindowLbl";
            this.EditStu_WindowLbl.Size = new System.Drawing.Size(105, 17);
            this.EditStu_WindowLbl.TabIndex = 0;
            this.EditStu_WindowLbl.Text = "Edit Students";
            // 
            // EditStu_UserInfoBox
            // 
            this.EditStu_UserInfoBox.Controls.Add(this.EditStu_TimeLbl);
            this.EditStu_UserInfoBox.Controls.Add(this.EditStu_DateLbl);
            this.EditStu_UserInfoBox.Controls.Add(this.EditStu_AdminNameLbl);
            this.EditStu_UserInfoBox.Controls.Add(this.EditStu_WindowLbl);
            this.EditStu_UserInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditStu_UserInfoBox.Location = new System.Drawing.Point(4, 4);
            this.EditStu_UserInfoBox.Margin = new System.Windows.Forms.Padding(4);
            this.EditStu_UserInfoBox.Name = "EditStu_UserInfoBox";
            this.EditStu_UserInfoBox.Padding = new System.Windows.Forms.Padding(4);
            this.EditStu_UserInfoBox.Size = new System.Drawing.Size(424, 85);
            this.EditStu_UserInfoBox.TabIndex = 0;
            this.EditStu_UserInfoBox.TabStop = false;
            // 
            // EditStu_TimeLbl
            // 
            this.EditStu_TimeLbl.AutoSize = true;
            this.EditStu_TimeLbl.Location = new System.Drawing.Point(361, 45);
            this.EditStu_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditStu_TimeLbl.Name = "EditStu_TimeLbl";
            this.EditStu_TimeLbl.Size = new System.Drawing.Size(55, 17);
            this.EditStu_TimeLbl.TabIndex = 2;
            this.EditStu_TimeLbl.Text = "<Time>";
            // 
            // EditStu_DateLbl
            // 
            this.EditStu_DateLbl.AutoSize = true;
            this.EditStu_DateLbl.Location = new System.Drawing.Point(361, 18);
            this.EditStu_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditStu_DateLbl.Name = "EditStu_DateLbl";
            this.EditStu_DateLbl.Size = new System.Drawing.Size(54, 17);
            this.EditStu_DateLbl.TabIndex = 1;
            this.EditStu_DateLbl.Text = "<Date>";
            // 
            // EditStu_AdminNameLbl
            // 
            this.EditStu_AdminNameLbl.AutoSize = true;
            this.EditStu_AdminNameLbl.Location = new System.Drawing.Point(8, 46);
            this.EditStu_AdminNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditStu_AdminNameLbl.Name = "EditStu_AdminNameLbl";
            this.EditStu_AdminNameLbl.Size = new System.Drawing.Size(63, 17);
            this.EditStu_AdminNameLbl.TabIndex = 0;
            this.EditStu_AdminNameLbl.Text = "<Admin>";
            // 
            // EditStu_SettingBox
            // 
            this.EditStu_SettingBox.Controls.Add(this.label1);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_NewLastNameCmbo);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_GroupCmbo);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_NewFirstNameCmbo);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_SelectionCmbo);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_SaveStudentBtn);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_GroupLbl);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_NameLbl);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_SelectStudentLbl);
            this.EditStu_SettingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditStu_SettingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStu_SettingBox.Location = new System.Drawing.Point(4, 97);
            this.EditStu_SettingBox.Margin = new System.Windows.Forms.Padding(4);
            this.EditStu_SettingBox.Name = "EditStu_SettingBox";
            this.EditStu_SettingBox.Padding = new System.Windows.Forms.Padding(4);
            this.EditStu_SettingBox.Size = new System.Drawing.Size(424, 327);
            this.EditStu_SettingBox.TabIndex = 1;
            this.EditStu_SettingBox.TabStop = false;
            this.EditStu_SettingBox.Text = "Edit Student Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Last Name";
            // 
            // EditStu_NewLastNameCmbo
            // 
            this.EditStu_NewLastNameCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EditStu_NewLastNameCmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EditStu_NewLastNameCmbo.FormattingEnabled = true;
            this.EditStu_NewLastNameCmbo.Location = new System.Drawing.Point(167, 145);
            this.EditStu_NewLastNameCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.EditStu_NewLastNameCmbo.MaxLength = 25;
            this.EditStu_NewLastNameCmbo.Name = "EditStu_NewLastNameCmbo";
            this.EditStu_NewLastNameCmbo.Size = new System.Drawing.Size(160, 24);
            this.EditStu_NewLastNameCmbo.TabIndex = 2;
            this.EditStu_NewLastNameCmbo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_LettersKeyDown);
            this.EditStu_NewLastNameCmbo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditStu_SettingBoxTextBoxes_KeyPress);
            this.EditStu_NewLastNameCmbo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_KeyUp);
            // 
            // EditStu_GroupCmbo
            // 
            this.EditStu_GroupCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EditStu_GroupCmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EditStu_GroupCmbo.FormattingEnabled = true;
            this.EditStu_GroupCmbo.Location = new System.Drawing.Point(167, 177);
            this.EditStu_GroupCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.EditStu_GroupCmbo.MaxLength = 25;
            this.EditStu_GroupCmbo.Name = "EditStu_GroupCmbo";
            this.EditStu_GroupCmbo.Size = new System.Drawing.Size(160, 24);
            this.EditStu_GroupCmbo.TabIndex = 3;
            this.EditStu_GroupCmbo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_LettersAndDigitsKeyDown);
            this.EditStu_GroupCmbo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditStu_SettingBoxTextBoxes_KeyPress);
            this.EditStu_GroupCmbo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_KeyUp);
            // 
            // EditStu_NewFirstNameCmbo
            // 
            this.EditStu_NewFirstNameCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.EditStu_NewFirstNameCmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EditStu_NewFirstNameCmbo.FormattingEnabled = true;
            this.EditStu_NewFirstNameCmbo.Location = new System.Drawing.Point(167, 113);
            this.EditStu_NewFirstNameCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.EditStu_NewFirstNameCmbo.MaxLength = 25;
            this.EditStu_NewFirstNameCmbo.Name = "EditStu_NewFirstNameCmbo";
            this.EditStu_NewFirstNameCmbo.Size = new System.Drawing.Size(160, 24);
            this.EditStu_NewFirstNameCmbo.TabIndex = 1;
            this.EditStu_NewFirstNameCmbo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_LettersKeyDown);
            this.EditStu_NewFirstNameCmbo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditStu_SettingBoxTextBoxes_KeyPress);
            this.EditStu_NewFirstNameCmbo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_KeyUp);
            // 
            // EditStu_SelectionCmbo
            // 
            this.EditStu_SelectionCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EditStu_SelectionCmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EditStu_SelectionCmbo.FormattingEnabled = true;
            this.EditStu_SelectionCmbo.Location = new System.Drawing.Point(167, 79);
            this.EditStu_SelectionCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.EditStu_SelectionCmbo.MaxLength = 25;
            this.EditStu_SelectionCmbo.Name = "EditStu_SelectionCmbo";
            this.EditStu_SelectionCmbo.Size = new System.Drawing.Size(160, 24);
            this.EditStu_SelectionCmbo.TabIndex = 0;
            this.EditStu_SelectionCmbo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_LettersKeyDown);
            this.EditStu_SelectionCmbo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditStu_SettingBoxTextBoxes_KeyPress);
            this.EditStu_SelectionCmbo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_KeyUp);
            // 
            // EditStu_SaveStudentBtn
            // 
            this.EditStu_SaveStudentBtn.AutoSize = true;
            this.EditStu_SaveStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStu_SaveStudentBtn.Location = new System.Drawing.Point(171, 209);
            this.EditStu_SaveStudentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditStu_SaveStudentBtn.Name = "EditStu_SaveStudentBtn";
            this.EditStu_SaveStudentBtn.Size = new System.Drawing.Size(137, 33);
            this.EditStu_SaveStudentBtn.TabIndex = 4;
            this.EditStu_SaveStudentBtn.Text = "Save Student";
            this.EditStu_SaveStudentBtn.UseVisualStyleBackColor = true;
            this.EditStu_SaveStudentBtn.Click += new System.EventHandler(this.EditStu_SaveStudentBtn_Click);
            // 
            // EditStu_GroupLbl
            // 
            this.EditStu_GroupLbl.AutoSize = true;
            this.EditStu_GroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStu_GroupLbl.Location = new System.Drawing.Point(38, 177);
            this.EditStu_GroupLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditStu_GroupLbl.Name = "EditStu_GroupLbl";
            this.EditStu_GroupLbl.Size = new System.Drawing.Size(79, 17);
            this.EditStu_GroupLbl.TabIndex = 5;
            this.EditStu_GroupLbl.Text = "New Group";
            // 
            // EditStu_NameLbl
            // 
            this.EditStu_NameLbl.AutoSize = true;
            this.EditStu_NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStu_NameLbl.Location = new System.Drawing.Point(38, 113);
            this.EditStu_NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditStu_NameLbl.Name = "EditStu_NameLbl";
            this.EditStu_NameLbl.Size = new System.Drawing.Size(107, 17);
            this.EditStu_NameLbl.TabIndex = 4;
            this.EditStu_NameLbl.Text = "New First Name";
            // 
            // EditStu_SelectStudentLbl
            // 
            this.EditStu_SelectStudentLbl.AutoSize = true;
            this.EditStu_SelectStudentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStu_SelectStudentLbl.Location = new System.Drawing.Point(38, 79);
            this.EditStu_SelectStudentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditStu_SelectStudentLbl.Name = "EditStu_SelectStudentLbl";
            this.EditStu_SelectStudentLbl.Size = new System.Drawing.Size(112, 17);
            this.EditStu_SelectStudentLbl.TabIndex = 0;
            this.EditStu_SelectStudentLbl.Text = "Select a Student";
            // 
            // EditStu_ButtonBox
            // 
            this.EditStu_ButtonBox.Controls.Add(this.EditStu_ExitBtn);
            this.EditStu_ButtonBox.Controls.Add(this.EditStu_CloseBtn);
            this.EditStu_ButtonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditStu_ButtonBox.Location = new System.Drawing.Point(4, 432);
            this.EditStu_ButtonBox.Margin = new System.Windows.Forms.Padding(4);
            this.EditStu_ButtonBox.Name = "EditStu_ButtonBox";
            this.EditStu_ButtonBox.Padding = new System.Windows.Forms.Padding(4);
            this.EditStu_ButtonBox.Size = new System.Drawing.Size(424, 67);
            this.EditStu_ButtonBox.TabIndex = 2;
            this.EditStu_ButtonBox.TabStop = false;
            // 
            // EditStu_ExitBtn
            // 
            this.EditStu_ExitBtn.Location = new System.Drawing.Point(316, 23);
            this.EditStu_ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditStu_ExitBtn.Name = "EditStu_ExitBtn";
            this.EditStu_ExitBtn.Size = new System.Drawing.Size(100, 28);
            this.EditStu_ExitBtn.TabIndex = 1;
            this.EditStu_ExitBtn.Text = "Exit";
            this.EditStu_ExitBtn.UseVisualStyleBackColor = true;
            this.EditStu_ExitBtn.Click += new System.EventHandler(this.EditStu_ExitBtn_Click);
            // 
            // EditStu_CloseBtn
            // 
            this.EditStu_CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EditStu_CloseBtn.Location = new System.Drawing.Point(208, 23);
            this.EditStu_CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditStu_CloseBtn.Name = "EditStu_CloseBtn";
            this.EditStu_CloseBtn.Size = new System.Drawing.Size(100, 28);
            this.EditStu_CloseBtn.TabIndex = 0;
            this.EditStu_CloseBtn.Text = "Close";
            this.EditStu_CloseBtn.UseVisualStyleBackColor = true;
            this.EditStu_CloseBtn.Click += new System.EventHandler(this.EditStu_CloseBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.EditStu_UserInfoBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditStu_SettingBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.EditStu_ButtonBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.72897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.27103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 503);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // EditStu_Timer
            // 
            this.EditStu_Timer.Enabled = true;
            this.EditStu_Timer.Interval = 1000;
            this.EditStu_Timer.Tick += new System.EventHandler(this.EditStu_Timer_Tick);
            // 
            // EditStudents_Form
            // 
            this.AcceptButton = this.EditStu_SaveStudentBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.EditStu_CloseBtn;
            this.ClientSize = new System.Drawing.Size(432, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditStudents_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.EditStu_UserInfoBox.ResumeLayout(false);
            this.EditStu_UserInfoBox.PerformLayout();
            this.EditStu_SettingBox.ResumeLayout(false);
            this.EditStu_SettingBox.PerformLayout();
            this.EditStu_ButtonBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EditStu_WindowLbl;
        private System.Windows.Forms.GroupBox EditStu_UserInfoBox;
        private System.Windows.Forms.Label EditStu_TimeLbl;
        private System.Windows.Forms.Label EditStu_DateLbl;
        private System.Windows.Forms.Label EditStu_AdminNameLbl;
        private System.Windows.Forms.GroupBox EditStu_SettingBox;
        private System.Windows.Forms.Button EditStu_SaveStudentBtn;
        private System.Windows.Forms.Label EditStu_GroupLbl;
        private System.Windows.Forms.Label EditStu_NameLbl;
        private System.Windows.Forms.Label EditStu_SelectStudentLbl;
        private System.Windows.Forms.GroupBox EditStu_ButtonBox;
        private System.Windows.Forms.Button EditStu_ExitBtn;
        private System.Windows.Forms.Button EditStu_CloseBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer EditStu_Timer;
        private System.Windows.Forms.ComboBox EditStu_GroupCmbo;
        private System.Windows.Forms.ComboBox EditStu_NewFirstNameCmbo;
        private System.Windows.Forms.ComboBox EditStu_SelectionCmbo;
        private System.Windows.Forms.ComboBox EditStu_NewLastNameCmbo;
        private System.Windows.Forms.Label label1;
    }
}