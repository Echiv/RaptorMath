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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MngUsers_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MngUsers_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.MngUsers_WindowLbl = new System.Windows.Forms.Label();
            this.MngUser_AdminNameLbl = new System.Windows.Forms.Label();
            this.MngUsers_TimeLbl = new System.Windows.Forms.Label();
            this.MngUsers_DateLbl = new System.Windows.Forms.Label();
            this.MngUsers_AddUserBox = new System.Windows.Forms.GroupBox();
            this.MngUsers_LastNameCmbo = new System.Windows.Forms.ComboBox();
            this.doNothingContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MngUsers_LastNameLbl = new System.Windows.Forms.Label();
            this.MngUsers_GroupCmbo = new System.Windows.Forms.ComboBox();
            this.MngUsers_FirstNameCmbo = new System.Windows.Forms.ComboBox();
            this.MngUsers_SaveUserBtm = new System.Windows.Forms.Button();
            this.MngUsers_GroupLbl = new System.Windows.Forms.Label();
            this.MngUsers_FirstNameLbl = new System.Windows.Forms.Label();
            this.MngUsers_ButtonBox = new System.Windows.Forms.GroupBox();
            this.MngUsers_ImportBtn = new System.Windows.Forms.Button();
            this.MngUsers_CloseBtn = new System.Windows.Forms.Button();
            this.MngUsers_Timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.MngUsers_UserInfoBox.SuspendLayout();
            this.MngUsers_AddUserBox.SuspendLayout();
            this.MngUsers_ButtonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MngUsers_UserInfoBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MngUsers_AddUserBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MngUsers_ButtonBox, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.95122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.04878F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 503);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MngUsers_UserInfoBox
            // 
            this.MngUsers_UserInfoBox.Controls.Add(this.MngUsers_WindowLbl);
            this.MngUsers_UserInfoBox.Controls.Add(this.MngUser_AdminNameLbl);
            this.MngUsers_UserInfoBox.Controls.Add(this.MngUsers_TimeLbl);
            this.MngUsers_UserInfoBox.Controls.Add(this.MngUsers_DateLbl);
            this.MngUsers_UserInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_UserInfoBox.Location = new System.Drawing.Point(15, 2);
            this.MngUsers_UserInfoBox.Margin = new System.Windows.Forms.Padding(15, 2, 15, 10);
            this.MngUsers_UserInfoBox.Name = "MngUsers_UserInfoBox";
            this.MngUsers_UserInfoBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MngUsers_UserInfoBox.Size = new System.Drawing.Size(402, 65);
            this.MngUsers_UserInfoBox.TabIndex = 0;
            this.MngUsers_UserInfoBox.TabStop = false;
            // 
            // MngUsers_WindowLbl
            // 
            this.MngUsers_WindowLbl.AutoSize = true;
            this.MngUsers_WindowLbl.Location = new System.Drawing.Point(5, 10);
            this.MngUsers_WindowLbl.Name = "MngUsers_WindowLbl";
            this.MngUsers_WindowLbl.Size = new System.Drawing.Size(88, 13);
            this.MngUsers_WindowLbl.TabIndex = 35;
            this.MngUsers_WindowLbl.Text = "Manage Users";
            // 
            // MngUser_AdminNameLbl
            // 
            this.MngUser_AdminNameLbl.AutoSize = true;
            this.MngUser_AdminNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUser_AdminNameLbl.Location = new System.Drawing.Point(5, 34);
            this.MngUser_AdminNameLbl.Name = "MngUser_AdminNameLbl";
            this.MngUser_AdminNameLbl.Size = new System.Drawing.Size(48, 13);
            this.MngUser_AdminNameLbl.TabIndex = 34;
            this.MngUser_AdminNameLbl.Text = "<Admin>";
            // 
            // MngUsers_TimeLbl
            // 
            this.MngUsers_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MngUsers_TimeLbl.AutoSize = true;
            this.MngUsers_TimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_TimeLbl.Location = new System.Drawing.Point(316, 36);
            this.MngUsers_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngUsers_TimeLbl.Name = "MngUsers_TimeLbl";
            this.MngUsers_TimeLbl.Size = new System.Drawing.Size(42, 13);
            this.MngUsers_TimeLbl.TabIndex = 33;
            this.MngUsers_TimeLbl.Text = "<Time>";
            // 
            // MngUsers_DateLbl
            // 
            this.MngUsers_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MngUsers_DateLbl.AutoSize = true;
            this.MngUsers_DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_DateLbl.Location = new System.Drawing.Point(317, 12);
            this.MngUsers_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngUsers_DateLbl.Name = "MngUsers_DateLbl";
            this.MngUsers_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.MngUsers_DateLbl.TabIndex = 32;
            this.MngUsers_DateLbl.Text = "<Date>";
            // 
            // MngUsers_AddUserBox
            // 
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_LastNameCmbo);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_LastNameLbl);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_GroupCmbo);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_FirstNameCmbo);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_SaveUserBtm);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_GroupLbl);
            this.MngUsers_AddUserBox.Controls.Add(this.MngUsers_FirstNameLbl);
            this.MngUsers_AddUserBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MngUsers_AddUserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_AddUserBox.Location = new System.Drawing.Point(15, 98);
            this.MngUsers_AddUserBox.Margin = new System.Windows.Forms.Padding(15, 2, 15, 10);
            this.MngUsers_AddUserBox.Name = "MngUsers_AddUserBox";
            this.MngUsers_AddUserBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MngUsers_AddUserBox.Size = new System.Drawing.Size(402, 332);
            this.MngUsers_AddUserBox.TabIndex = 1;
            this.MngUsers_AddUserBox.TabStop = false;
            this.MngUsers_AddUserBox.Text = "Add a User";
            // 
            // MngUsers_LastNameCmbo
            // 
            this.MngUsers_LastNameCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MngUsers_LastNameCmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MngUsers_LastNameCmbo.ContextMenuStrip = this.doNothingContextMenu;
            this.MngUsers_LastNameCmbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_LastNameCmbo.FormattingEnabled = true;
            this.MngUsers_LastNameCmbo.Location = new System.Drawing.Point(146, 124);
            this.MngUsers_LastNameCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.MngUsers_LastNameCmbo.MaxLength = 12;
            this.MngUsers_LastNameCmbo.Name = "MngUsers_LastNameCmbo";
            this.MngUsers_LastNameCmbo.Size = new System.Drawing.Size(169, 21);
            this.MngUsers_LastNameCmbo.TabIndex = 4;
            this.MngUsers_LastNameCmbo.TextChanged += new System.EventHandler(this.MngUsers_FirstAndLastNameCmbo_TextChanged);
            this.MngUsers_LastNameCmbo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_LettersKeyDown);
            this.MngUsers_LastNameCmbo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_KeyUp);
            // 
            // doNothingContextMenu
            // 
            this.doNothingContextMenu.Name = "doNothingContextMenu";
            this.doNothingContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // MngUsers_LastNameLbl
            // 
            this.MngUsers_LastNameLbl.AutoSize = true;
            this.MngUsers_LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_LastNameLbl.Location = new System.Drawing.Point(50, 122);
            this.MngUsers_LastNameLbl.Name = "MngUsers_LastNameLbl";
            this.MngUsers_LastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.MngUsers_LastNameLbl.TabIndex = 13;
            this.MngUsers_LastNameLbl.Text = "Last Name";
            // 
            // MngUsers_GroupCmbo
            // 
            this.MngUsers_GroupCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MngUsers_GroupCmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MngUsers_GroupCmbo.ContextMenuStrip = this.doNothingContextMenu;
            this.MngUsers_GroupCmbo.FormattingEnabled = true;
            this.MngUsers_GroupCmbo.Location = new System.Drawing.Point(146, 153);
            this.MngUsers_GroupCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.MngUsers_GroupCmbo.MaxLength = 25;
            this.MngUsers_GroupCmbo.Name = "MngUsers_GroupCmbo";
            this.MngUsers_GroupCmbo.Size = new System.Drawing.Size(169, 21);
            this.MngUsers_GroupCmbo.TabIndex = 7;
            this.MngUsers_GroupCmbo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_LettersAndDigitsKeyDown);
            this.MngUsers_GroupCmbo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MngUsers_AddUserBoxTextBoxes_KeyPress);
            this.MngUsers_GroupCmbo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_KeyUp);
            // 
            // MngUsers_FirstNameCmbo
            // 
            this.MngUsers_FirstNameCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MngUsers_FirstNameCmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MngUsers_FirstNameCmbo.ContextMenuStrip = this.doNothingContextMenu;
            this.MngUsers_FirstNameCmbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_FirstNameCmbo.FormattingEnabled = true;
            this.MngUsers_FirstNameCmbo.Location = new System.Drawing.Point(146, 92);
            this.MngUsers_FirstNameCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.MngUsers_FirstNameCmbo.MaxLength = 12;
            this.MngUsers_FirstNameCmbo.Name = "MngUsers_FirstNameCmbo";
            this.MngUsers_FirstNameCmbo.Size = new System.Drawing.Size(169, 21);
            this.MngUsers_FirstNameCmbo.TabIndex = 3;
            this.MngUsers_FirstNameCmbo.TextChanged += new System.EventHandler(this.MngUsers_FirstAndLastNameCmbo_TextChanged);
            this.MngUsers_FirstNameCmbo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_KeyUp);
            this.MngUsers_FirstNameCmbo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MngUsers_AddUserBoxTextBoxes_KeyPress);
            this.MngUsers_FirstNameCmbo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_LettersKeyDown);
            // 
            // MngUsers_SaveUserBtm
            // 
            this.MngUsers_SaveUserBtm.AutoSize = true;
            this.MngUsers_SaveUserBtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_SaveUserBtm.Location = new System.Drawing.Point(173, 192);
            this.MngUsers_SaveUserBtm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MngUsers_SaveUserBtm.Name = "MngUsers_SaveUserBtm";
            this.MngUsers_SaveUserBtm.Size = new System.Drawing.Size(115, 30);
            this.MngUsers_SaveUserBtm.TabIndex = 8;
            this.MngUsers_SaveUserBtm.Text = "Save User";
            this.toolTip1.SetToolTip(this.MngUsers_SaveUserBtm, "Saves the newly created student or admin.");
            this.MngUsers_SaveUserBtm.UseVisualStyleBackColor = true;
            this.MngUsers_SaveUserBtm.Click += new System.EventHandler(this.MngUsers_SaveUserBtm_Click);
            // 
            // MngUsers_GroupLbl
            // 
            this.MngUsers_GroupLbl.AutoSize = true;
            this.MngUsers_GroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_GroupLbl.Location = new System.Drawing.Point(52, 161);
            this.MngUsers_GroupLbl.Name = "MngUsers_GroupLbl";
            this.MngUsers_GroupLbl.Size = new System.Drawing.Size(36, 13);
            this.MngUsers_GroupLbl.TabIndex = 6;
            this.MngUsers_GroupLbl.Text = "Group";
            // 
            // MngUsers_FirstNameLbl
            // 
            this.MngUsers_FirstNameLbl.AutoSize = true;
            this.MngUsers_FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUsers_FirstNameLbl.Location = new System.Drawing.Point(50, 95);
            this.MngUsers_FirstNameLbl.Name = "MngUsers_FirstNameLbl";
            this.MngUsers_FirstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.MngUsers_FirstNameLbl.TabIndex = 4;
            this.MngUsers_FirstNameLbl.Text = "First Name";
            // 
            // MngUsers_ButtonBox
            // 
            this.MngUsers_ButtonBox.Controls.Add(this.MngUsers_ImportBtn);
            this.MngUsers_ButtonBox.Controls.Add(this.MngUsers_CloseBtn);
            this.MngUsers_ButtonBox.Location = new System.Drawing.Point(15, 450);
            this.MngUsers_ButtonBox.Margin = new System.Windows.Forms.Padding(15, 2, 15, 10);
            this.MngUsers_ButtonBox.Name = "MngUsers_ButtonBox";
            this.MngUsers_ButtonBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MngUsers_ButtonBox.Size = new System.Drawing.Size(402, 43);
            this.MngUsers_ButtonBox.TabIndex = 3;
            this.MngUsers_ButtonBox.TabStop = false;
            // 
            // MngUsers_ImportBtn
            // 
            this.MngUsers_ImportBtn.Location = new System.Drawing.Point(64, 11);
            this.MngUsers_ImportBtn.Name = "MngUsers_ImportBtn";
            this.MngUsers_ImportBtn.Size = new System.Drawing.Size(160, 30);
            this.MngUsers_ImportBtn.TabIndex = 1;
            this.MngUsers_ImportBtn.Text = "Import Students From Text File";
            this.MngUsers_ImportBtn.UseVisualStyleBackColor = true;
            this.MngUsers_ImportBtn.Click += new System.EventHandler(this.MngUsers_ImportBtn_Click);
            // 
            // MngUsers_CloseBtn
            // 
            this.MngUsers_CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MngUsers_CloseBtn.Location = new System.Drawing.Point(230, 11);
            this.MngUsers_CloseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MngUsers_CloseBtn.Name = "MngUsers_CloseBtn";
            this.MngUsers_CloseBtn.Size = new System.Drawing.Size(160, 30);
            this.MngUsers_CloseBtn.TabIndex = 1;
            this.MngUsers_CloseBtn.Text = "Close";
            this.toolTip1.SetToolTip(this.MngUsers_CloseBtn, "Return to the administration\'s homepage.");
            this.MngUsers_CloseBtn.UseVisualStyleBackColor = true;
            this.MngUsers_CloseBtn.Click += new System.EventHandler(this.MngUsers_CloseBtn_Click);
            // 
            // MngUsers_Timer
            // 
            this.MngUsers_Timer.Enabled = true;
            this.MngUsers_Timer.Interval = 1000;
            this.MngUsers_Timer.Tick += new System.EventHandler(this.MngUsers_Timer_Tick);
            // 
            // MngUsers_Form
            // 
            this.AcceptButton = this.MngUsers_SaveUserBtm;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.MngUsers_CloseBtn;
            this.ClientSize = new System.Drawing.Size(432, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MngUsers_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MngUsers_UserInfoBox.ResumeLayout(false);
            this.MngUsers_UserInfoBox.PerformLayout();
            this.MngUsers_AddUserBox.ResumeLayout(false);
            this.MngUsers_AddUserBox.PerformLayout();
            this.MngUsers_ButtonBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox MngUsers_UserInfoBox;
        private System.Windows.Forms.GroupBox MngUsers_AddUserBox;
        private System.Windows.Forms.GroupBox MngUsers_ButtonBox;
        private System.Windows.Forms.Timer MngUsers_Timer;
        private System.Windows.Forms.Label MngUsers_DateLbl;
        private System.Windows.Forms.Label MngUsers_TimeLbl;
        private System.Windows.Forms.Button MngUsers_CloseBtn;
        private System.Windows.Forms.Label MngUsers_GroupLbl;
        private System.Windows.Forms.Label MngUsers_FirstNameLbl;
        private System.Windows.Forms.Button MngUsers_SaveUserBtm;
        private System.Windows.Forms.Label MngUsers_WindowLbl;
        private System.Windows.Forms.Label MngUser_AdminNameLbl;
        private System.Windows.Forms.ComboBox MngUsers_GroupCmbo;
        private System.Windows.Forms.ComboBox MngUsers_FirstNameCmbo;
        private System.Windows.Forms.Label MngUsers_LastNameLbl;
        private System.Windows.Forms.ComboBox MngUsers_LastNameCmbo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip doNothingContextMenu;
        private System.Windows.Forms.Button MngUsers_ImportBtn;
    }
}