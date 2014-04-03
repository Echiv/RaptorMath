namespace RaptorMath
{
    partial class ManageDrills_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDrills_Form));
            this.MngDrills_WindowLbl = new System.Windows.Forms.Label();
            this.MngDrills_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.MngDrills_TimeLbl = new System.Windows.Forms.Label();
            this.MngDrills_DateLbl = new System.Windows.Forms.Label();
            this.MngDrills_AdminNameLbl = new System.Windows.Forms.Label();
            this.MngDrills_DrillBox = new System.Windows.Forms.GroupBox();
            this.MngDrills_PerformBox = new System.Windows.Forms.GroupBox();
            this.MngDrills_SelectDrillCmbo = new System.Windows.Forms.ComboBox();
            this.MngDrills_GroupCmbo = new System.Windows.Forms.ComboBox();
            this.MngDrills_StudentCmbo = new System.Windows.Forms.ComboBox();
            this.MngDrills_AddRmvDrillBtn = new System.Windows.Forms.Button();
            this.MngDrills_SelectDrillLbl = new System.Windows.Forms.Label();
            this.MngDrills_GroupLbl = new System.Windows.Forms.Label();
            this.MngDrills_StudentLbl = new System.Windows.Forms.Label();
            this.MngDrills_OperationBox = new System.Windows.Forms.GroupBox();
            this.MngDrills_RemoveDrillRdo = new System.Windows.Forms.RadioButton();
            this.MngDrills_AssignDrillRdo = new System.Windows.Forms.RadioButton();
            this.MngDrills_ButtonBox = new System.Windows.Forms.GroupBox();
            this.MngDrills_ExitBtn = new System.Windows.Forms.Button();
            this.MngDrills_CloseBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MngDrills_Timer = new System.Windows.Forms.Timer(this.components);
            this.MngDrills_UserInfoBox.SuspendLayout();
            this.MngDrills_DrillBox.SuspendLayout();
            this.MngDrills_PerformBox.SuspendLayout();
            this.MngDrills_OperationBox.SuspendLayout();
            this.MngDrills_ButtonBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MngDrills_WindowLbl
            // 
            this.MngDrills_WindowLbl.AutoSize = true;
            this.MngDrills_WindowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_WindowLbl.Location = new System.Drawing.Point(8, 18);
            this.MngDrills_WindowLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngDrills_WindowLbl.Name = "MngDrills_WindowLbl";
            this.MngDrills_WindowLbl.Size = new System.Drawing.Size(107, 17);
            this.MngDrills_WindowLbl.TabIndex = 0;
            this.MngDrills_WindowLbl.Text = "Manage Drills";
            // 
            // MngDrills_UserInfoBox
            // 
            this.MngDrills_UserInfoBox.Controls.Add(this.MngDrills_TimeLbl);
            this.MngDrills_UserInfoBox.Controls.Add(this.MngDrills_DateLbl);
            this.MngDrills_UserInfoBox.Controls.Add(this.MngDrills_AdminNameLbl);
            this.MngDrills_UserInfoBox.Controls.Add(this.MngDrills_WindowLbl);
            this.MngDrills_UserInfoBox.Location = new System.Drawing.Point(4, 4);
            this.MngDrills_UserInfoBox.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_UserInfoBox.Name = "MngDrills_UserInfoBox";
            this.MngDrills_UserInfoBox.Padding = new System.Windows.Forms.Padding(4);
            this.MngDrills_UserInfoBox.Size = new System.Drawing.Size(424, 75);
            this.MngDrills_UserInfoBox.TabIndex = 1;
            this.MngDrills_UserInfoBox.TabStop = false;
            // 
            // MngDrills_TimeLbl
            // 
            this.MngDrills_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MngDrills_TimeLbl.AutoSize = true;
            this.MngDrills_TimeLbl.Location = new System.Drawing.Point(345, 45);
            this.MngDrills_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngDrills_TimeLbl.Name = "MngDrills_TimeLbl";
            this.MngDrills_TimeLbl.Size = new System.Drawing.Size(55, 17);
            this.MngDrills_TimeLbl.TabIndex = 2;
            this.MngDrills_TimeLbl.Text = "<Time>";
            // 
            // MngDrills_DateLbl
            // 
            this.MngDrills_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MngDrills_DateLbl.AutoSize = true;
            this.MngDrills_DateLbl.Location = new System.Drawing.Point(346, 19);
            this.MngDrills_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngDrills_DateLbl.Name = "MngDrills_DateLbl";
            this.MngDrills_DateLbl.Size = new System.Drawing.Size(54, 17);
            this.MngDrills_DateLbl.TabIndex = 1;
            this.MngDrills_DateLbl.Text = "<Date>";
            // 
            // MngDrills_AdminNameLbl
            // 
            this.MngDrills_AdminNameLbl.AutoSize = true;
            this.MngDrills_AdminNameLbl.Location = new System.Drawing.Point(8, 44);
            this.MngDrills_AdminNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngDrills_AdminNameLbl.Name = "MngDrills_AdminNameLbl";
            this.MngDrills_AdminNameLbl.Size = new System.Drawing.Size(63, 17);
            this.MngDrills_AdminNameLbl.TabIndex = 0;
            this.MngDrills_AdminNameLbl.Text = "<Admin>";
            // 
            // MngDrills_DrillBox
            // 
            this.MngDrills_DrillBox.Controls.Add(this.MngDrills_PerformBox);
            this.MngDrills_DrillBox.Controls.Add(this.MngDrills_OperationBox);
            this.MngDrills_DrillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_DrillBox.Location = new System.Drawing.Point(4, 87);
            this.MngDrills_DrillBox.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_DrillBox.Name = "MngDrills_DrillBox";
            this.MngDrills_DrillBox.Padding = new System.Windows.Forms.Padding(4);
            this.MngDrills_DrillBox.Size = new System.Drawing.Size(424, 359);
            this.MngDrills_DrillBox.TabIndex = 2;
            this.MngDrills_DrillBox.TabStop = false;
            this.MngDrills_DrillBox.Text = "Add or Remove a Drill";
            // 
            // MngDrills_PerformBox
            // 
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_SelectDrillCmbo);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_GroupCmbo);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_StudentCmbo);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_AddRmvDrillBtn);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_SelectDrillLbl);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_GroupLbl);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_StudentLbl);
            this.MngDrills_PerformBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MngDrills_PerformBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_PerformBox.Location = new System.Drawing.Point(4, 136);
            this.MngDrills_PerformBox.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_PerformBox.Name = "MngDrills_PerformBox";
            this.MngDrills_PerformBox.Padding = new System.Windows.Forms.Padding(4);
            this.MngDrills_PerformBox.Size = new System.Drawing.Size(416, 219);
            this.MngDrills_PerformBox.TabIndex = 1;
            this.MngDrills_PerformBox.TabStop = false;
            this.MngDrills_PerformBox.Text = "Perform Action";
            // 
            // MngDrills_SelectDrillCmbo
            // 
            this.MngDrills_SelectDrillCmbo.FormattingEnabled = true;
            this.MngDrills_SelectDrillCmbo.Location = new System.Drawing.Point(159, 124);
            this.MngDrills_SelectDrillCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_SelectDrillCmbo.Name = "MngDrills_SelectDrillCmbo";
            this.MngDrills_SelectDrillCmbo.Size = new System.Drawing.Size(160, 24);
            this.MngDrills_SelectDrillCmbo.TabIndex = 9;
            this.MngDrills_SelectDrillCmbo.SelectedIndexChanged += new System.EventHandler(this.MngDrills_SelectDrillCmbo_SelectedIndexChanged);
            // 
            // MngDrills_GroupCmbo
            // 
            this.MngDrills_GroupCmbo.FormattingEnabled = true;
            this.MngDrills_GroupCmbo.Location = new System.Drawing.Point(159, 91);
            this.MngDrills_GroupCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_GroupCmbo.Name = "MngDrills_GroupCmbo";
            this.MngDrills_GroupCmbo.Size = new System.Drawing.Size(160, 24);
            this.MngDrills_GroupCmbo.TabIndex = 8;
            this.MngDrills_GroupCmbo.SelectedIndexChanged += new System.EventHandler(this.MngDrills_GroupCmbo_SelectedIndexChanged);
            // 
            // MngDrills_StudentCmbo
            // 
            this.MngDrills_StudentCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MngDrills_StudentCmbo.FormattingEnabled = true;
            this.MngDrills_StudentCmbo.Location = new System.Drawing.Point(159, 58);
            this.MngDrills_StudentCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_StudentCmbo.Name = "MngDrills_StudentCmbo";
            this.MngDrills_StudentCmbo.Size = new System.Drawing.Size(160, 24);
            this.MngDrills_StudentCmbo.TabIndex = 7;
            this.MngDrills_StudentCmbo.SelectedIndexChanged += new System.EventHandler(this.MngDrills_StudentCmbo_SelectedIndexChanged);
            // 
            // MngDrills_AddRmvDrillBtn
            // 
            this.MngDrills_AddRmvDrillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_AddRmvDrillBtn.Location = new System.Drawing.Point(159, 154);
            this.MngDrills_AddRmvDrillBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_AddRmvDrillBtn.Name = "MngDrills_AddRmvDrillBtn";
            this.MngDrills_AddRmvDrillBtn.Size = new System.Drawing.Size(100, 28);
            this.MngDrills_AddRmvDrillBtn.TabIndex = 6;
            this.MngDrills_AddRmvDrillBtn.Text = "Add/Rmv Drill";
            this.MngDrills_AddRmvDrillBtn.UseVisualStyleBackColor = true;
            this.MngDrills_AddRmvDrillBtn.Click += new System.EventHandler(this.MngDrills_AddRmvDrillBtn_Click);
            // 
            // MngDrills_SelectDrillLbl
            // 
            this.MngDrills_SelectDrillLbl.AutoSize = true;
            this.MngDrills_SelectDrillLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_SelectDrillLbl.Location = new System.Drawing.Point(79, 128);
            this.MngDrills_SelectDrillLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngDrills_SelectDrillLbl.Name = "MngDrills_SelectDrillLbl";
            this.MngDrills_SelectDrillLbl.Size = new System.Drawing.Size(75, 17);
            this.MngDrills_SelectDrillLbl.TabIndex = 5;
            this.MngDrills_SelectDrillLbl.Text = "Select Drill";
            // 
            // MngDrills_GroupLbl
            // 
            this.MngDrills_GroupLbl.AutoSize = true;
            this.MngDrills_GroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_GroupLbl.Location = new System.Drawing.Point(79, 95);
            this.MngDrills_GroupLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngDrills_GroupLbl.Name = "MngDrills_GroupLbl";
            this.MngDrills_GroupLbl.Size = new System.Drawing.Size(48, 17);
            this.MngDrills_GroupLbl.TabIndex = 4;
            this.MngDrills_GroupLbl.Text = "Group";
            // 
            // MngDrills_StudentLbl
            // 
            this.MngDrills_StudentLbl.AutoSize = true;
            this.MngDrills_StudentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_StudentLbl.Location = new System.Drawing.Point(79, 62);
            this.MngDrills_StudentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngDrills_StudentLbl.Name = "MngDrills_StudentLbl";
            this.MngDrills_StudentLbl.Size = new System.Drawing.Size(57, 17);
            this.MngDrills_StudentLbl.TabIndex = 3;
            this.MngDrills_StudentLbl.Text = "Student";
            // 
            // MngDrills_OperationBox
            // 
            this.MngDrills_OperationBox.Controls.Add(this.MngDrills_RemoveDrillRdo);
            this.MngDrills_OperationBox.Controls.Add(this.MngDrills_AssignDrillRdo);
            this.MngDrills_OperationBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MngDrills_OperationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_OperationBox.Location = new System.Drawing.Point(4, 19);
            this.MngDrills_OperationBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MngDrills_OperationBox.Name = "MngDrills_OperationBox";
            this.MngDrills_OperationBox.Padding = new System.Windows.Forms.Padding(11, 4, 11, 4);
            this.MngDrills_OperationBox.Size = new System.Drawing.Size(416, 107);
            this.MngDrills_OperationBox.TabIndex = 0;
            this.MngDrills_OperationBox.TabStop = false;
            this.MngDrills_OperationBox.Text = "Select an Operation";
            // 
            // MngDrills_RemoveDrillRdo
            // 
            this.MngDrills_RemoveDrillRdo.AutoSize = true;
            this.MngDrills_RemoveDrillRdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_RemoveDrillRdo.Location = new System.Drawing.Point(160, 63);
            this.MngDrills_RemoveDrillRdo.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_RemoveDrillRdo.Name = "MngDrills_RemoveDrillRdo";
            this.MngDrills_RemoveDrillRdo.Size = new System.Drawing.Size(109, 21);
            this.MngDrills_RemoveDrillRdo.TabIndex = 1;
            this.MngDrills_RemoveDrillRdo.TabStop = true;
            this.MngDrills_RemoveDrillRdo.Text = "Remove Drill";
            this.MngDrills_RemoveDrillRdo.UseVisualStyleBackColor = true;
            this.MngDrills_RemoveDrillRdo.CheckedChanged += new System.EventHandler(this.MngDrills_RemoveDrillRdo_CheckedChanged);
            // 
            // MngDrills_AssignDrillRdo
            // 
            this.MngDrills_AssignDrillRdo.AutoSize = true;
            this.MngDrills_AssignDrillRdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_AssignDrillRdo.Location = new System.Drawing.Point(160, 34);
            this.MngDrills_AssignDrillRdo.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_AssignDrillRdo.Name = "MngDrills_AssignDrillRdo";
            this.MngDrills_AssignDrillRdo.Size = new System.Drawing.Size(99, 21);
            this.MngDrills_AssignDrillRdo.TabIndex = 0;
            this.MngDrills_AssignDrillRdo.TabStop = true;
            this.MngDrills_AssignDrillRdo.Text = "Assign Drill";
            this.MngDrills_AssignDrillRdo.UseVisualStyleBackColor = true;
            this.MngDrills_AssignDrillRdo.CheckedChanged += new System.EventHandler(this.MngDrills_AssignDrillRdo_CheckedChanged);
            // 
            // MngDrills_ButtonBox
            // 
            this.MngDrills_ButtonBox.Controls.Add(this.MngDrills_ExitBtn);
            this.MngDrills_ButtonBox.Controls.Add(this.MngDrills_CloseBtn);
            this.MngDrills_ButtonBox.Location = new System.Drawing.Point(4, 454);
            this.MngDrills_ButtonBox.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_ButtonBox.Name = "MngDrills_ButtonBox";
            this.MngDrills_ButtonBox.Padding = new System.Windows.Forms.Padding(4);
            this.MngDrills_ButtonBox.Size = new System.Drawing.Size(424, 45);
            this.MngDrills_ButtonBox.TabIndex = 3;
            this.MngDrills_ButtonBox.TabStop = false;
            // 
            // MngDrills_ExitBtn
            // 
            this.MngDrills_ExitBtn.Location = new System.Drawing.Point(316, 12);
            this.MngDrills_ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_ExitBtn.Name = "MngDrills_ExitBtn";
            this.MngDrills_ExitBtn.Size = new System.Drawing.Size(100, 28);
            this.MngDrills_ExitBtn.TabIndex = 8;
            this.MngDrills_ExitBtn.Text = "Exit";
            this.MngDrills_ExitBtn.UseVisualStyleBackColor = true;
            this.MngDrills_ExitBtn.Click += new System.EventHandler(this.MngDrills_ExitBtn_Click);
            // 
            // MngDrills_CloseBtn
            // 
            this.MngDrills_CloseBtn.Location = new System.Drawing.Point(208, 12);
            this.MngDrills_CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_CloseBtn.Name = "MngDrills_CloseBtn";
            this.MngDrills_CloseBtn.Size = new System.Drawing.Size(100, 28);
            this.MngDrills_CloseBtn.TabIndex = 7;
            this.MngDrills_CloseBtn.Text = "Close";
            this.MngDrills_CloseBtn.UseVisualStyleBackColor = true;
            this.MngDrills_CloseBtn.Click += new System.EventHandler(this.MngDrills_CloseBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MngDrills_ButtonBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MngDrills_UserInfoBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MngDrills_DrillBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.5941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.4059F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 503);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // MngDrills_Timer
            // 
            this.MngDrills_Timer.Enabled = true;
            this.MngDrills_Timer.Interval = 1000;
            // 
            // ManageDrills_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(432, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageDrills_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.MngDrills_UserInfoBox.ResumeLayout(false);
            this.MngDrills_UserInfoBox.PerformLayout();
            this.MngDrills_DrillBox.ResumeLayout(false);
            this.MngDrills_PerformBox.ResumeLayout(false);
            this.MngDrills_PerformBox.PerformLayout();
            this.MngDrills_OperationBox.ResumeLayout(false);
            this.MngDrills_OperationBox.PerformLayout();
            this.MngDrills_ButtonBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MngDrills_WindowLbl;
        private System.Windows.Forms.GroupBox MngDrills_UserInfoBox;
        private System.Windows.Forms.GroupBox MngDrills_DrillBox;
        private System.Windows.Forms.GroupBox MngDrills_PerformBox;
        private System.Windows.Forms.GroupBox MngDrills_OperationBox;
        private System.Windows.Forms.GroupBox MngDrills_ButtonBox;
        private System.Windows.Forms.Label MngDrills_TimeLbl;
        private System.Windows.Forms.Label MngDrills_DateLbl;
        private System.Windows.Forms.Label MngDrills_AdminNameLbl;
        private System.Windows.Forms.Button MngDrills_AddRmvDrillBtn;
        private System.Windows.Forms.Label MngDrills_SelectDrillLbl;
        private System.Windows.Forms.Label MngDrills_GroupLbl;
        private System.Windows.Forms.Label MngDrills_StudentLbl;
        private System.Windows.Forms.RadioButton MngDrills_RemoveDrillRdo;
        private System.Windows.Forms.RadioButton MngDrills_AssignDrillRdo;
        private System.Windows.Forms.Button MngDrills_ExitBtn;
        private System.Windows.Forms.Button MngDrills_CloseBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer MngDrills_Timer;
        private System.Windows.Forms.ComboBox MngDrills_SelectDrillCmbo;
        private System.Windows.Forms.ComboBox MngDrills_GroupCmbo;
        private System.Windows.Forms.ComboBox MngDrills_StudentCmbo;
    }
}