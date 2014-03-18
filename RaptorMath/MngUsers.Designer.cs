namespace RaptorMath
{
    partial class MngUsers_Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MngUsers_WindowLbl = new System.Windows.Forms.GroupBox();
            this.MngUsers_TimeLbl = new System.Windows.Forms.Label();
            this.MngUsers_DateLbl = new System.Windows.Forms.Label();
            this.MngUsers_AddUserBox = new System.Windows.Forms.GroupBox();
            this.MngUsers_ConfirmPassword = new System.Windows.Forms.Label();
            this.MngUsers_ConfirmPasswordTxt = new System.Windows.Forms.RichTextBox();
            this.MngUsers_SaveUserBtm = new System.Windows.Forms.Button();
            this.MngUsers_PasswordTxt = new System.Windows.Forms.RichTextBox();
            this.MngUsers_NameTxt = new System.Windows.Forms.RichTextBox();
            this.MngUsers_GroupDdl = new System.Windows.Forms.ComboBox();
            this.MngUsers_GroupLbl = new System.Windows.Forms.Label();
            this.MngUsers_PasswordLbl = new System.Windows.Forms.Label();
            this.MngUsers_NameLbl = new System.Windows.Forms.Label();
            this.MngUsers_AdminRdo = new System.Windows.Forms.RadioButton();
            this.MngUsers_StudentRdo = new System.Windows.Forms.RadioButton();
            this.MngUsers_UserTypeLbl = new System.Windows.Forms.Label();
            this.MngUsers_RemoveUserBox = new System.Windows.Forms.GroupBox();
            this.MngUsers_ButtonBox = new System.Windows.Forms.GroupBox();
            this.MngUsers_CloseBtn = new System.Windows.Forms.Button();
            this.MngUsers_ExitBtn = new System.Windows.Forms.Button();
            this.MngUsers_Timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.MngUsers_WindowLbl.SuspendLayout();
            this.MngUsers_AddUserBox.SuspendLayout();
            this.MngUsers_ButtonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MngUsers_WindowLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MngUsers_AddUserBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MngUsers_RemoveUserBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MngUsers_ButtonBox, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.30488F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.69512F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 503);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MngUsers_WindowLbl
            // 
            this.MngUsers_WindowLbl.Controls.Add(this.MngUsers_TimeLbl);
            this.MngUsers_WindowLbl.Controls.Add(this.MngUsers_DateLbl);
            this.MngUsers_WindowLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MngUsers_WindowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_WindowLbl.Location = new System.Drawing.Point(15, 3);
            this.MngUsers_WindowLbl.Margin = new System.Windows.Forms.Padding(15, 3, 15, 10);
            this.MngUsers_WindowLbl.Name = "MngUsers_WindowLbl";
            this.MngUsers_WindowLbl.Size = new System.Drawing.Size(402, 65);
            this.MngUsers_WindowLbl.TabIndex = 0;
            this.MngUsers_WindowLbl.TabStop = false;
            this.MngUsers_WindowLbl.Text = "Manage Users";
            // 
            // MngUsers_TimeLbl
            // 
            this.MngUsers_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MngUsers_TimeLbl.AutoSize = true;
            this.MngUsers_TimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_TimeLbl.Location = new System.Drawing.Point(316, 39);
            this.MngUsers_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngUsers_TimeLbl.Name = "MngUsers_TimeLbl";
            this.MngUsers_TimeLbl.Size = new System.Drawing.Size(55, 17);
            this.MngUsers_TimeLbl.TabIndex = 33;
            this.MngUsers_TimeLbl.Text = "<Time>";
            // 
            // MngUsers_DateLbl
            // 
            this.MngUsers_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MngUsers_DateLbl.AutoSize = true;
            this.MngUsers_DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_DateLbl.Location = new System.Drawing.Point(317, 14);
            this.MngUsers_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngUsers_DateLbl.Name = "MngUsers_DateLbl";
            this.MngUsers_DateLbl.Size = new System.Drawing.Size(54, 17);
            this.MngUsers_DateLbl.TabIndex = 32;
            this.MngUsers_DateLbl.Text = "<Date>";
            // 
            // MngUsers_AddUserBox
            // 
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_ConfirmPassword);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_ConfirmPasswordTxt);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_SaveUserBtm);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_PasswordTxt);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_NameTxt);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_GroupDdl);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_GroupLbl);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_PasswordLbl);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_NameLbl);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_AdminRdo);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_StudentRdo);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_UserTypeLbl);
            this.MngUsers_AddUserBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MngUsers_AddUserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_AddUserBox.Location = new System.Drawing.Point(15, 81);
            this.MngUsers_AddUserBox.Margin = new System.Windows.Forms.Padding(15, 3, 15, 10);
            this.MngUsers_AddUserBox.Name = "MngUsers_AddUserBox";
            this.MngUsers_AddUserBox.Size = new System.Drawing.Size(402, 217);
            this.MngUsers_AddUserBox.TabIndex = 1;
            this.MngUsers_AddUserBox.TabStop = false;
            this.MngUsers_AddUserBox.Text = "Add a User";
            // 
            // MngUsers_ConfirmPassword
            // 
            this.MngUsers_ConfirmPassword.AutoSize = true;
            this.MngUsers_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_ConfirmPassword.Location = new System.Drawing.Point(53, 112);
            this.MngUsers_ConfirmPassword.Name = "MngUsers_ConfirmPassword";
            this.MngUsers_ConfirmPassword.Size = new System.Drawing.Size(69, 34);
            this.MngUsers_ConfirmPassword.TabIndex = 12;
            this.MngUsers_ConfirmPassword.Text = "Confirm\r\nPassword";
            // 
            // MngUsers_ConfirmPasswordTxt
            // 
            this.MngUsers_ConfirmPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_ConfirmPasswordTxt.Location = new System.Drawing.Point(149, 112);
            this.MngUsers_ConfirmPasswordTxt.Name = "MngUsers_ConfirmPasswordTxt";
            this.MngUsers_ConfirmPasswordTxt.Size = new System.Drawing.Size(148, 26);
            this.MngUsers_ConfirmPasswordTxt.TabIndex = 11;
            this.MngUsers_ConfirmPasswordTxt.Text = "";
            // 
            // MngUsers_SaveUserBtm
            // 
            this.MngUsers_SaveUserBtm.AutoSize = true;
            this.MngUsers_SaveUserBtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_SaveUserBtm.Location = new System.Drawing.Point(173, 173);
            this.MngUsers_SaveUserBtm.Name = "MngUsers_SaveUserBtm";
            this.MngUsers_SaveUserBtm.Size = new System.Drawing.Size(84, 32);
            this.MngUsers_SaveUserBtm.TabIndex = 10;
            this.MngUsers_SaveUserBtm.Text = "Save User";
            this.MngUsers_SaveUserBtm.UseVisualStyleBackColor = true;
            this.MngUsers_SaveUserBtm.Click += new System.EventHandler(this.MngUsers_SaveUserBtm_Click);
            // 
            // MngUsers_PasswordTxt
            // 
            this.MngUsers_PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_PasswordTxt.Location = new System.Drawing.Point(149, 80);
            this.MngUsers_PasswordTxt.Name = "MngUsers_PasswordTxt";
            this.MngUsers_PasswordTxt.Size = new System.Drawing.Size(148, 26);
            this.MngUsers_PasswordTxt.TabIndex = 9;
            this.MngUsers_PasswordTxt.Text = "";
            // 
            // MngUsers_NameTxt
            // 
            this.MngUsers_NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_NameTxt.Location = new System.Drawing.Point(149, 48);
            this.MngUsers_NameTxt.Name = "MngUsers_NameTxt";
            this.MngUsers_NameTxt.Size = new System.Drawing.Size(148, 26);
            this.MngUsers_NameTxt.TabIndex = 8;
            this.MngUsers_NameTxt.Text = "";
            // 
            // MngUsers_GroupDdl
            // 
            this.MngUsers_GroupDdl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MngUsers_GroupDdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_GroupDdl.FormattingEnabled = true;
            this.MngUsers_GroupDdl.Location = new System.Drawing.Point(149, 143);
            this.MngUsers_GroupDdl.Name = "MngUsers_GroupDdl";
            this.MngUsers_GroupDdl.Size = new System.Drawing.Size(148, 24);
            this.MngUsers_GroupDdl.TabIndex = 7;
            // 
            // MngUsers_GroupLbl
            // 
            this.MngUsers_GroupLbl.AutoSize = true;
            this.MngUsers_GroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_GroupLbl.Location = new System.Drawing.Point(53, 150);
            this.MngUsers_GroupLbl.Name = "MngUsers_GroupLbl";
            this.MngUsers_GroupLbl.Size = new System.Drawing.Size(48, 17);
            this.MngUsers_GroupLbl.TabIndex = 6;
            this.MngUsers_GroupLbl.Text = "Group";
            // 
            // MngUsers_PasswordLbl
            // 
            this.MngUsers_PasswordLbl.AutoSize = true;
            this.MngUsers_PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_PasswordLbl.Location = new System.Drawing.Point(52, 80);
            this.MngUsers_PasswordLbl.Name = "MngUsers_PasswordLbl";
            this.MngUsers_PasswordLbl.Size = new System.Drawing.Size(69, 17);
            this.MngUsers_PasswordLbl.TabIndex = 5;
            this.MngUsers_PasswordLbl.Text = "Password";
            // 
            // MngUsers_NameLbl
            // 
            this.MngUsers_NameLbl.AutoSize = true;
            this.MngUsers_NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_NameLbl.Location = new System.Drawing.Point(53, 51);
            this.MngUsers_NameLbl.Name = "MngUsers_NameLbl";
            this.MngUsers_NameLbl.Size = new System.Drawing.Size(45, 17);
            this.MngUsers_NameLbl.TabIndex = 4;
            this.MngUsers_NameLbl.Text = "Name";
            // 
            // MngUsers_AdminRdo
            // 
            this.MngUsers_AdminRdo.AutoSize = true;
            this.MngUsers_AdminRdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_AdminRdo.Location = new System.Drawing.Point(229, 21);
            this.MngUsers_AdminRdo.Name = "MngUsers_AdminRdo";
            this.MngUsers_AdminRdo.Size = new System.Drawing.Size(68, 21);
            this.MngUsers_AdminRdo.TabIndex = 3;
            this.MngUsers_AdminRdo.TabStop = true;
            this.MngUsers_AdminRdo.Text = "Admin";
            this.MngUsers_AdminRdo.UseVisualStyleBackColor = true;
            // 
            // MngUsers_StudentRdo
            // 
            this.MngUsers_StudentRdo.AutoSize = true;
            this.MngUsers_StudentRdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_StudentRdo.Location = new System.Drawing.Point(145, 21);
            this.MngUsers_StudentRdo.Name = "MngUsers_StudentRdo";
            this.MngUsers_StudentRdo.Size = new System.Drawing.Size(78, 21);
            this.MngUsers_StudentRdo.TabIndex = 2;
            this.MngUsers_StudentRdo.TabStop = true;
            this.MngUsers_StudentRdo.Text = "Student";
            this.MngUsers_StudentRdo.UseVisualStyleBackColor = true;
            // 
            // MngUsers_UserTypeLbl
            // 
            this.MngUsers_UserTypeLbl.AutoSize = true;
            this.MngUsers_UserTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_UserTypeLbl.Location = new System.Drawing.Point(52, 25);
            this.MngUsers_UserTypeLbl.Name = "MngUsers_UserTypeLbl";
            this.MngUsers_UserTypeLbl.Size = new System.Drawing.Size(74, 17);
            this.MngUsers_UserTypeLbl.TabIndex = 1;
            this.MngUsers_UserTypeLbl.Text = "User Type";
            // 
            // MngUsers_RemoveUserBox
            // 
            this.MngUsers_RemoveUserBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MngUsers_RemoveUserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_RemoveUserBox.Location = new System.Drawing.Point(15, 311);
            this.MngUsers_RemoveUserBox.Margin = new System.Windows.Forms.Padding(15, 3, 15, 10);
            this.MngUsers_RemoveUserBox.Name = "MngUsers_RemoveUserBox";
            this.MngUsers_RemoveUserBox.Size = new System.Drawing.Size(402, 92);
            this.MngUsers_RemoveUserBox.TabIndex = 2;
            this.MngUsers_RemoveUserBox.TabStop = false;
            this.MngUsers_RemoveUserBox.Text = "Remove a User";
            // 
            // MngUsers_ButtonBox
            // 
            this.MngUsers_ButtonBox.Controls.Add(this.MngUsers_CloseBtn);
            this.MngUsers_ButtonBox.Controls.Add(this.MngUsers_ExitBtn);
            this.MngUsers_ButtonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MngUsers_ButtonBox.Location = new System.Drawing.Point(15, 416);
            this.MngUsers_ButtonBox.Margin = new System.Windows.Forms.Padding(15, 3, 15, 10);
            this.MngUsers_ButtonBox.Name = "MngUsers_ButtonBox";
            this.MngUsers_ButtonBox.Size = new System.Drawing.Size(402, 56);
            this.MngUsers_ButtonBox.TabIndex = 3;
            this.MngUsers_ButtonBox.TabStop = false;
            // 
            // MngUsers_CloseBtn
            // 
            this.MngUsers_CloseBtn.Location = new System.Drawing.Point(229, 20);
            this.MngUsers_CloseBtn.Name = "MngUsers_CloseBtn";
            this.MngUsers_CloseBtn.Size = new System.Drawing.Size(75, 32);
            this.MngUsers_CloseBtn.TabIndex = 18;
            this.MngUsers_CloseBtn.Text = "Close";
            this.MngUsers_CloseBtn.UseVisualStyleBackColor = true;
            this.MngUsers_CloseBtn.Click += new System.EventHandler(this.MngUsers_CloseBtn_Click);
            // 
            // MngUsers_ExitBtn
            // 
            this.MngUsers_ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MngUsers_ExitBtn.Location = new System.Drawing.Point(321, 19);
            this.MngUsers_ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MngUsers_ExitBtn.Name = "MngUsers_ExitBtn";
            this.MngUsers_ExitBtn.Size = new System.Drawing.Size(75, 32);
            this.MngUsers_ExitBtn.TabIndex = 17;
            this.MngUsers_ExitBtn.Text = "Exit";
            this.MngUsers_ExitBtn.UseVisualStyleBackColor = true;
            this.MngUsers_ExitBtn.Click += new System.EventHandler(this.MngUsers_ExitBtn_Click);
            // 
            // MngUsers_Timer
            // 
            this.MngUsers_Timer.Enabled = true;
            this.MngUsers_Timer.Interval = 1000;
            this.MngUsers_Timer.Tick += new System.EventHandler(this.MngUsers_Timer_Tick);
            // 
            // MngUsers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MngUsers_Form";
            this.Text = "Raptor Math";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MngUsers_WindowLbl.ResumeLayout(false);
            this.MngUsers_WindowLbl.PerformLayout();
            this.MngUsers_AddUserBox.ResumeLayout(false);
            this.MngUsers_AddUserBox.PerformLayout();
            this.MngUsers_ButtonBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox MngUsers_WindowLbl;
        private System.Windows.Forms.GroupBox MngUsers_AddUserBox;
        private System.Windows.Forms.GroupBox MngUsers_RemoveUserBox;
        private System.Windows.Forms.GroupBox MngUsers_ButtonBox;
        private System.Windows.Forms.Timer MngUsers_Timer;
        private System.Windows.Forms.Label MngUsers_DateLbl;
        private System.Windows.Forms.Label MngUsers_TimeLbl;
        private System.Windows.Forms.Button MngUsers_CloseBtn;
        private System.Windows.Forms.Button MngUsers_ExitBtn;
        private System.Windows.Forms.Label MngUsers_GroupLbl;
        private System.Windows.Forms.Label MngUsers_PasswordLbl;
        private System.Windows.Forms.Label MngUsers_NameLbl;
        private System.Windows.Forms.RadioButton MngUsers_AdminRdo;
        private System.Windows.Forms.RadioButton MngUsers_StudentRdo;
        private System.Windows.Forms.Label MngUsers_UserTypeLbl;
        private System.Windows.Forms.ComboBox MngUsers_GroupDdl;
        private System.Windows.Forms.RichTextBox MngUsers_PasswordTxt;
        private System.Windows.Forms.RichTextBox MngUsers_NameTxt;
        private System.Windows.Forms.Button MngUsers_SaveUserBtm;
        private System.Windows.Forms.Label MngUsers_ConfirmPassword;
        private System.Windows.Forms.RichTextBox MngUsers_ConfirmPasswordTxt;
    }
}