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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MngDrills_GroupRdo = new System.Windows.Forms.RadioButton();
            this.MngDrills_StudentRdo = new System.Windows.Forms.RadioButton();
            this.MngDrills_OperationBox = new System.Windows.Forms.GroupBox();
            this.MngDrills_RemoveDrillRdo = new System.Windows.Forms.RadioButton();
            this.MngDrills_AssignDrillRdo = new System.Windows.Forms.RadioButton();
            this.MngDrills_PerformBox = new System.Windows.Forms.GroupBox();
            this.MngDrills_SelectDrillCmbo = new System.Windows.Forms.ComboBox();
            this.MngDrills_StudentOrGroupCmbo = new System.Windows.Forms.ComboBox();
            this.MngDrills_AddRmvDrillBtn = new System.Windows.Forms.Button();
            this.MngDrills_SelectDrillLbl = new System.Windows.Forms.Label();
            this.MngDrills_StudentOrGroupLbl = new System.Windows.Forms.Label();
            this.MngDrills_ButtonBox = new System.Windows.Forms.GroupBox();
            this.MngDrills_ExitBtn = new System.Windows.Forms.Button();
            this.MngDrills_CloseBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MngDrills_Timer = new System.Windows.Forms.Timer(this.components);
            this.MngDrills_UserInfoBox.SuspendLayout();
            this.MngDrills_DrillBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MngDrills_OperationBox.SuspendLayout();
            this.MngDrills_PerformBox.SuspendLayout();
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
            this.MngDrills_WindowLbl.Size = new System.Drawing.Size(84, 13);
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
            this.MngDrills_UserInfoBox.TabIndex = 0;
            this.MngDrills_UserInfoBox.TabStop = false;
            // 
            // MngDrills_TimeLbl
            // 
            this.MngDrills_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MngDrills_TimeLbl.AutoSize = true;
            this.MngDrills_TimeLbl.Location = new System.Drawing.Point(345, 45);
            this.MngDrills_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngDrills_TimeLbl.Name = "MngDrills_TimeLbl";
            this.MngDrills_TimeLbl.Size = new System.Drawing.Size(42, 13);
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
            this.MngDrills_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.MngDrills_DateLbl.TabIndex = 1;
            this.MngDrills_DateLbl.Text = "<Date>";
            // 
            // MngDrills_AdminNameLbl
            // 
            this.MngDrills_AdminNameLbl.AutoSize = true;
            this.MngDrills_AdminNameLbl.Location = new System.Drawing.Point(8, 44);
            this.MngDrills_AdminNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngDrills_AdminNameLbl.Name = "MngDrills_AdminNameLbl";
            this.MngDrills_AdminNameLbl.Size = new System.Drawing.Size(48, 13);
            this.MngDrills_AdminNameLbl.TabIndex = 0;
            this.MngDrills_AdminNameLbl.Text = "<Admin>";
            // 
            // MngDrills_DrillBox
            // 
            this.MngDrills_DrillBox.Controls.Add(this.tableLayoutPanel2);
            this.MngDrills_DrillBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MngDrills_DrillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_DrillBox.Location = new System.Drawing.Point(4, 87);
            this.MngDrills_DrillBox.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_DrillBox.Name = "MngDrills_DrillBox";
            this.MngDrills_DrillBox.Padding = new System.Windows.Forms.Padding(4);
            this.MngDrills_DrillBox.Size = new System.Drawing.Size(424, 359);
            this.MngDrills_DrillBox.TabIndex = 1;
            this.MngDrills_DrillBox.TabStop = false;
            this.MngDrills_DrillBox.Text = "Add or Remove a Drill";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MngDrills_PerformBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(416, 339);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MngDrills_OperationBox, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(410, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MngDrills_GroupRdo);
            this.groupBox1.Controls.Add(this.MngDrills_StudentRdo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group or Student";
            // 
            // MngDrills_GroupRdo
            // 
            this.MngDrills_GroupRdo.AutoSize = true;
            this.MngDrills_GroupRdo.Location = new System.Drawing.Point(24, 55);
            this.MngDrills_GroupRdo.Name = "MngDrills_GroupRdo";
            this.MngDrills_GroupRdo.Size = new System.Drawing.Size(54, 17);
            this.MngDrills_GroupRdo.TabIndex = 1;
            this.MngDrills_GroupRdo.TabStop = true;
            this.MngDrills_GroupRdo.Text = "Group";
            this.MngDrills_GroupRdo.UseVisualStyleBackColor = true;
            this.MngDrills_GroupRdo.CheckedChanged += new System.EventHandler(this.MngDrills_GroupRdo_CheckedChanged);
            // 
            // MngDrills_StudentRdo
            // 
            this.MngDrills_StudentRdo.AutoSize = true;
            this.MngDrills_StudentRdo.Location = new System.Drawing.Point(24, 26);
            this.MngDrills_StudentRdo.Name = "MngDrills_StudentRdo";
            this.MngDrills_StudentRdo.Size = new System.Drawing.Size(62, 17);
            this.MngDrills_StudentRdo.TabIndex = 0;
            this.MngDrills_StudentRdo.TabStop = true;
            this.MngDrills_StudentRdo.Text = "Student";
            this.MngDrills_StudentRdo.UseVisualStyleBackColor = true;
            this.MngDrills_StudentRdo.CheckedChanged += new System.EventHandler(this.MngDrills_StudentRdo_CheckedChanged);
            // 
            // MngDrills_OperationBox
            // 
            this.MngDrills_OperationBox.Controls.Add(this.MngDrills_RemoveDrillRdo);
            this.MngDrills_OperationBox.Controls.Add(this.MngDrills_AssignDrillRdo);
            this.MngDrills_OperationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MngDrills_OperationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_OperationBox.Location = new System.Drawing.Point(210, 6);
            this.MngDrills_OperationBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MngDrills_OperationBox.Name = "MngDrills_OperationBox";
            this.MngDrills_OperationBox.Padding = new System.Windows.Forms.Padding(11, 4, 11, 4);
            this.MngDrills_OperationBox.Size = new System.Drawing.Size(195, 88);
            this.MngDrills_OperationBox.TabIndex = 1;
            this.MngDrills_OperationBox.TabStop = false;
            this.MngDrills_OperationBox.Text = "Assign or Remove";
            // 
            // MngDrills_RemoveDrillRdo
            // 
            this.MngDrills_RemoveDrillRdo.AutoSize = true;
            this.MngDrills_RemoveDrillRdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_RemoveDrillRdo.Location = new System.Drawing.Point(29, 52);
            this.MngDrills_RemoveDrillRdo.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_RemoveDrillRdo.Name = "MngDrills_RemoveDrillRdo";
            this.MngDrills_RemoveDrillRdo.Size = new System.Drawing.Size(85, 17);
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
            this.MngDrills_AssignDrillRdo.Location = new System.Drawing.Point(29, 23);
            this.MngDrills_AssignDrillRdo.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_AssignDrillRdo.Name = "MngDrills_AssignDrillRdo";
            this.MngDrills_AssignDrillRdo.Size = new System.Drawing.Size(76, 17);
            this.MngDrills_AssignDrillRdo.TabIndex = 0;
            this.MngDrills_AssignDrillRdo.TabStop = true;
            this.MngDrills_AssignDrillRdo.Text = "Assign Drill";
            this.MngDrills_AssignDrillRdo.UseVisualStyleBackColor = true;
            this.MngDrills_AssignDrillRdo.CheckedChanged += new System.EventHandler(this.MngDrills_AssignDrillRdo_CheckedChanged);
            // 
            // MngDrills_PerformBox
            // 
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_SelectDrillCmbo);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_StudentOrGroupCmbo);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_AddRmvDrillBtn);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_SelectDrillLbl);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_StudentOrGroupLbl);
            this.MngDrills_PerformBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MngDrills_PerformBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_PerformBox.Location = new System.Drawing.Point(4, 110);
            this.MngDrills_PerformBox.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_PerformBox.Name = "MngDrills_PerformBox";
            this.MngDrills_PerformBox.Padding = new System.Windows.Forms.Padding(4);
            this.MngDrills_PerformBox.Size = new System.Drawing.Size(408, 225);
            this.MngDrills_PerformBox.TabIndex = 2;
            this.MngDrills_PerformBox.TabStop = false;
            this.MngDrills_PerformBox.Text = "Perform Action";
            // 
            // MngDrills_SelectDrillCmbo
            // 
            this.MngDrills_SelectDrillCmbo.FormattingEnabled = true;
            this.MngDrills_SelectDrillCmbo.Location = new System.Drawing.Point(156, 69);
            this.MngDrills_SelectDrillCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_SelectDrillCmbo.MaxLength = 25;
            this.MngDrills_SelectDrillCmbo.Name = "MngDrills_SelectDrillCmbo";
            this.MngDrills_SelectDrillCmbo.Size = new System.Drawing.Size(178, 21);
            this.MngDrills_SelectDrillCmbo.TabIndex = 1;
            this.MngDrills_SelectDrillCmbo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MngDrills_PerformBoxTextBoxes_KeyPress);
            // 
            // MngDrills_StudentOrGroupCmbo
            // 
            this.MngDrills_StudentOrGroupCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MngDrills_StudentOrGroupCmbo.FormattingEnabled = true;
            this.MngDrills_StudentOrGroupCmbo.Location = new System.Drawing.Point(156, 37);
            this.MngDrills_StudentOrGroupCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_StudentOrGroupCmbo.MaxLength = 25;
            this.MngDrills_StudentOrGroupCmbo.Name = "MngDrills_StudentOrGroupCmbo";
            this.MngDrills_StudentOrGroupCmbo.Size = new System.Drawing.Size(178, 21);
            this.MngDrills_StudentOrGroupCmbo.TabIndex = 0;
            this.MngDrills_StudentOrGroupCmbo.SelectedIndexChanged += new System.EventHandler(this.MngDrills_StudentOrGroupCmbo_TextChanged);
            this.MngDrills_StudentOrGroupCmbo.TextChanged += new System.EventHandler(this.MngDrills_StudentOrGroupCmbo_TextChanged);
            this.MngDrills_StudentOrGroupCmbo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MngDrills_PerformBoxTextBoxes_KeyPress);
            // 
            // MngDrills_AddRmvDrillBtn
            // 
            this.MngDrills_AddRmvDrillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_AddRmvDrillBtn.Location = new System.Drawing.Point(156, 98);
            this.MngDrills_AddRmvDrillBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_AddRmvDrillBtn.Name = "MngDrills_AddRmvDrillBtn";
            this.MngDrills_AddRmvDrillBtn.Size = new System.Drawing.Size(100, 28);
            this.MngDrills_AddRmvDrillBtn.TabIndex = 2;
            this.MngDrills_AddRmvDrillBtn.Text = "Add/Rmv Drill";
            this.MngDrills_AddRmvDrillBtn.UseVisualStyleBackColor = true;
            this.MngDrills_AddRmvDrillBtn.Click += new System.EventHandler(this.MngDrills_AddRmvDrillBtn_Click);
            // 
            // MngDrills_SelectDrillLbl
            // 
            this.MngDrills_SelectDrillLbl.AutoSize = true;
            this.MngDrills_SelectDrillLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_SelectDrillLbl.Location = new System.Drawing.Point(76, 72);
            this.MngDrills_SelectDrillLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngDrills_SelectDrillLbl.Name = "MngDrills_SelectDrillLbl";
            this.MngDrills_SelectDrillLbl.Size = new System.Drawing.Size(57, 13);
            this.MngDrills_SelectDrillLbl.TabIndex = 5;
            this.MngDrills_SelectDrillLbl.Text = "Select Drill";
            // 
            // MngDrills_StudentOrGroupLbl
            // 
            this.MngDrills_StudentOrGroupLbl.AutoSize = true;
            this.MngDrills_StudentOrGroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDrills_StudentOrGroupLbl.Location = new System.Drawing.Point(76, 41);
            this.MngDrills_StudentOrGroupLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MngDrills_StudentOrGroupLbl.Name = "MngDrills_StudentOrGroupLbl";
            this.MngDrills_StudentOrGroupLbl.Size = new System.Drawing.Size(45, 13);
            this.MngDrills_StudentOrGroupLbl.TabIndex = 3;
            this.MngDrills_StudentOrGroupLbl.Text = "Stu/Grp";
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
            this.MngDrills_ButtonBox.TabIndex = 2;
            this.MngDrills_ButtonBox.TabStop = false;
            // 
            // MngDrills_ExitBtn
            // 
            this.MngDrills_ExitBtn.Location = new System.Drawing.Point(316, 12);
            this.MngDrills_ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_ExitBtn.Name = "MngDrills_ExitBtn";
            this.MngDrills_ExitBtn.Size = new System.Drawing.Size(100, 28);
            this.MngDrills_ExitBtn.TabIndex = 1;
            this.MngDrills_ExitBtn.Text = "Exit";
            this.MngDrills_ExitBtn.UseVisualStyleBackColor = true;
            this.MngDrills_ExitBtn.Click += new System.EventHandler(this.MngDrills_ExitBtn_Click);
            // 
            // MngDrills_CloseBtn
            // 
            this.MngDrills_CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MngDrills_CloseBtn.Location = new System.Drawing.Point(208, 12);
            this.MngDrills_CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MngDrills_CloseBtn.Name = "MngDrills_CloseBtn";
            this.MngDrills_CloseBtn.Size = new System.Drawing.Size(100, 28);
            this.MngDrills_CloseBtn.TabIndex = 0;
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
            this.MngDrills_Timer.Tick += new System.EventHandler(this.MngDrills_Timer_Tick);
            // 
            // ManageDrills_Form
            // 
            this.AcceptButton = this.MngDrills_AddRmvDrillBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.MngDrills_CloseBtn;
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MngDrills_OperationBox.ResumeLayout(false);
            this.MngDrills_OperationBox.PerformLayout();
            this.MngDrills_PerformBox.ResumeLayout(false);
            this.MngDrills_PerformBox.PerformLayout();
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
        private System.Windows.Forms.Label MngDrills_StudentOrGroupLbl;
        private System.Windows.Forms.RadioButton MngDrills_RemoveDrillRdo;
        private System.Windows.Forms.RadioButton MngDrills_AssignDrillRdo;
        private System.Windows.Forms.Button MngDrills_ExitBtn;
        private System.Windows.Forms.Button MngDrills_CloseBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer MngDrills_Timer;
        private System.Windows.Forms.ComboBox MngDrills_SelectDrillCmbo;
        private System.Windows.Forms.ComboBox MngDrills_StudentOrGroupCmbo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MngDrills_GroupRdo;
        private System.Windows.Forms.RadioButton MngDrills_StudentRdo;
    }
}