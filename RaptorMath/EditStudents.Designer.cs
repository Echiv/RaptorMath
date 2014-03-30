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
            this.EditStu_WindowLbl = new System.Windows.Forms.Label();
            this.EditStu_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.EditStu_TimeLbl = new System.Windows.Forms.Label();
            this.EditStu_DateLbl = new System.Windows.Forms.Label();
            this.EditStu_AdminNameLbl = new System.Windows.Forms.Label();
            this.EditStu_SettingBox = new System.Windows.Forms.GroupBox();
            this.EditStu_SaveStudentBtn = new System.Windows.Forms.Button();
            this.EditStu_GroupLbl = new System.Windows.Forms.Label();
            this.EditStu_NameLbl = new System.Windows.Forms.Label();
            this.EditStu_SelectStudentLbl = new System.Windows.Forms.Label();
            this.EditStu_ButtonBox = new System.Windows.Forms.GroupBox();
            this.EditStu_ExitBtn = new System.Windows.Forms.Button();
            this.EditStu_CloseBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EditStu_Timer = new System.Windows.Forms.Timer(this.components);
            this.EditStu_SelectionCmbo = new System.Windows.Forms.ComboBox();
            this.EditStu_NewNameCmbo = new System.Windows.Forms.ComboBox();
            this.EditStu_GroupCmbo = new System.Windows.Forms.ComboBox();
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
            this.EditStu_WindowLbl.Location = new System.Drawing.Point(6, 15);
            this.EditStu_WindowLbl.Name = "EditStu_WindowLbl";
            this.EditStu_WindowLbl.Size = new System.Drawing.Size(83, 13);
            this.EditStu_WindowLbl.TabIndex = 0;
            this.EditStu_WindowLbl.Text = "Edit Students";
            // 
            // EditStu_UserInfoBox
            // 
            this.EditStu_UserInfoBox.Controls.Add(this.EditStu_TimeLbl);
            this.EditStu_UserInfoBox.Controls.Add(this.EditStu_DateLbl);
            this.EditStu_UserInfoBox.Controls.Add(this.EditStu_AdminNameLbl);
            this.EditStu_UserInfoBox.Controls.Add(this.EditStu_WindowLbl);
            this.EditStu_UserInfoBox.Location = new System.Drawing.Point(3, 3);
            this.EditStu_UserInfoBox.Name = "EditStu_UserInfoBox";
            this.EditStu_UserInfoBox.Size = new System.Drawing.Size(428, 80);
            this.EditStu_UserInfoBox.TabIndex = 1;
            this.EditStu_UserInfoBox.TabStop = false;
            // 
            // EditStu_TimeLbl
            // 
            this.EditStu_TimeLbl.AutoSize = true;
            this.EditStu_TimeLbl.Location = new System.Drawing.Point(377, 38);
            this.EditStu_TimeLbl.Name = "EditStu_TimeLbl";
            this.EditStu_TimeLbl.Size = new System.Drawing.Size(42, 13);
            this.EditStu_TimeLbl.TabIndex = 2;
            this.EditStu_TimeLbl.Text = "<Time>";
            // 
            // EditStu_DateLbl
            // 
            this.EditStu_DateLbl.AutoSize = true;
            this.EditStu_DateLbl.Location = new System.Drawing.Point(377, 16);
            this.EditStu_DateLbl.Name = "EditStu_DateLbl";
            this.EditStu_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.EditStu_DateLbl.TabIndex = 1;
            this.EditStu_DateLbl.Text = "<Date>";
            // 
            // EditStu_AdminNameLbl
            // 
            this.EditStu_AdminNameLbl.AutoSize = true;
            this.EditStu_AdminNameLbl.Location = new System.Drawing.Point(6, 37);
            this.EditStu_AdminNameLbl.Name = "EditStu_AdminNameLbl";
            this.EditStu_AdminNameLbl.Size = new System.Drawing.Size(48, 13);
            this.EditStu_AdminNameLbl.TabIndex = 0;
            this.EditStu_AdminNameLbl.Text = "<Admin>";
            // 
            // EditStu_SettingBox
            // 
            this.EditStu_SettingBox.Controls.Add(this.EditStu_GroupCmbo);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_NewNameCmbo);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_SelectionCmbo);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_SaveStudentBtn);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_GroupLbl);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_NameLbl);
            this.EditStu_SettingBox.Controls.Add(this.EditStu_SelectStudentLbl);
            this.EditStu_SettingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStu_SettingBox.Location = new System.Drawing.Point(3, 89);
            this.EditStu_SettingBox.Name = "EditStu_SettingBox";
            this.EditStu_SettingBox.Size = new System.Drawing.Size(428, 294);
            this.EditStu_SettingBox.TabIndex = 2;
            this.EditStu_SettingBox.TabStop = false;
            this.EditStu_SettingBox.Text = "Edit Student Settings";
            // 
            // EditStu_SaveStudentBtn
            // 
            this.EditStu_SaveStudentBtn.AutoSize = true;
            this.EditStu_SaveStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStu_SaveStudentBtn.Location = new System.Drawing.Point(163, 188);
            this.EditStu_SaveStudentBtn.Name = "EditStu_SaveStudentBtn";
            this.EditStu_SaveStudentBtn.Size = new System.Drawing.Size(82, 23);
            this.EditStu_SaveStudentBtn.TabIndex = 6;
            this.EditStu_SaveStudentBtn.Text = "Save Student";
            this.EditStu_SaveStudentBtn.UseVisualStyleBackColor = true;
            this.EditStu_SaveStudentBtn.Click += new System.EventHandler(this.EditStu_SaveStudentBtn_Click);
            // 
            // EditStu_GroupLbl
            // 
            this.EditStu_GroupLbl.AutoSize = true;
            this.EditStu_GroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStu_GroupLbl.Location = new System.Drawing.Point(45, 164);
            this.EditStu_GroupLbl.Name = "EditStu_GroupLbl";
            this.EditStu_GroupLbl.Size = new System.Drawing.Size(61, 13);
            this.EditStu_GroupLbl.TabIndex = 5;
            this.EditStu_GroupLbl.Text = "New Group";
            // 
            // EditStu_NameLbl
            // 
            this.EditStu_NameLbl.AutoSize = true;
            this.EditStu_NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStu_NameLbl.Location = new System.Drawing.Point(45, 136);
            this.EditStu_NameLbl.Name = "EditStu_NameLbl";
            this.EditStu_NameLbl.Size = new System.Drawing.Size(60, 13);
            this.EditStu_NameLbl.TabIndex = 4;
            this.EditStu_NameLbl.Text = "New Name";
            // 
            // EditStu_SelectStudentLbl
            // 
            this.EditStu_SelectStudentLbl.AutoSize = true;
            this.EditStu_SelectStudentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStu_SelectStudentLbl.Location = new System.Drawing.Point(45, 105);
            this.EditStu_SelectStudentLbl.Name = "EditStu_SelectStudentLbl";
            this.EditStu_SelectStudentLbl.Size = new System.Drawing.Size(86, 13);
            this.EditStu_SelectStudentLbl.TabIndex = 0;
            this.EditStu_SelectStudentLbl.Text = "Select a Student";
            // 
            // EditStu_ButtonBox
            // 
            this.EditStu_ButtonBox.Controls.Add(this.EditStu_ExitBtn);
            this.EditStu_ButtonBox.Controls.Add(this.EditStu_CloseBtn);
            this.EditStu_ButtonBox.Location = new System.Drawing.Point(3, 454);
            this.EditStu_ButtonBox.Name = "EditStu_ButtonBox";
            this.EditStu_ButtonBox.Size = new System.Drawing.Size(419, 55);
            this.EditStu_ButtonBox.TabIndex = 3;
            this.EditStu_ButtonBox.TabStop = false;
            // 
            // EditStu_ExitBtn
            // 
            this.EditStu_ExitBtn.Location = new System.Drawing.Point(338, 19);
            this.EditStu_ExitBtn.Name = "EditStu_ExitBtn";
            this.EditStu_ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.EditStu_ExitBtn.TabIndex = 1;
            this.EditStu_ExitBtn.Text = "Exit";
            this.EditStu_ExitBtn.UseVisualStyleBackColor = true;
            // 
            // EditStu_CloseBtn
            // 
            this.EditStu_CloseBtn.Location = new System.Drawing.Point(257, 19);
            this.EditStu_CloseBtn.Name = "EditStu_CloseBtn";
            this.EditStu_CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.EditStu_CloseBtn.TabIndex = 0;
            this.EditStu_CloseBtn.Text = "Close";
            this.EditStu_CloseBtn.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.10112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.89888F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 512);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // EditStu_Timer
            // 
            this.EditStu_Timer.Enabled = true;
            this.EditStu_Timer.Interval = 1000;
            // 
            // EditStu_SelectionCmbo
            // 
            this.EditStu_SelectionCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EditStu_SelectionCmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EditStu_SelectionCmbo.FormattingEnabled = true;
            this.EditStu_SelectionCmbo.Location = new System.Drawing.Point(142, 105);
            this.EditStu_SelectionCmbo.Name = "EditStu_SelectionCmbo";
            this.EditStu_SelectionCmbo.Size = new System.Drawing.Size(121, 21);
            this.EditStu_SelectionCmbo.TabIndex = 7;
            // 
            // EditStu_NewNameCmbo
            // 
            this.EditStu_NewNameCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.EditStu_NewNameCmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EditStu_NewNameCmbo.FormattingEnabled = true;
            this.EditStu_NewNameCmbo.Location = new System.Drawing.Point(142, 134);
            this.EditStu_NewNameCmbo.Name = "EditStu_NewNameCmbo";
            this.EditStu_NewNameCmbo.Size = new System.Drawing.Size(121, 21);
            this.EditStu_NewNameCmbo.TabIndex = 8;
            // 
            // EditStu_GroupCmbo
            // 
            this.EditStu_GroupCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EditStu_GroupCmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EditStu_GroupCmbo.FormattingEnabled = true;
            this.EditStu_GroupCmbo.Location = new System.Drawing.Point(142, 161);
            this.EditStu_GroupCmbo.Name = "EditStu_GroupCmbo";
            this.EditStu_GroupCmbo.Size = new System.Drawing.Size(121, 21);
            this.EditStu_GroupCmbo.TabIndex = 9;
            // 
            // EditStudents_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditStudents_Form";
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
        private System.Windows.Forms.ComboBox EditStu_NewNameCmbo;
        private System.Windows.Forms.ComboBox EditStu_SelectionCmbo;
    }
}