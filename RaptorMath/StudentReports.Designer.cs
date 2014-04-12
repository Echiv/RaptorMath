namespace RaptorMath
{
    partial class StudentReports_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentReports_Form));
            this.UseRep_DateLbl = new System.Windows.Forms.Label();
            this.ReportHome_DateRangeBox = new System.Windows.Forms.GroupBox();
            this.ReportHome_StartDate = new System.Windows.Forms.DateTimePicker();
            this.ReportHome_EndDate = new System.Windows.Forms.DateTimePicker();
            this.ReportHome_EndDateLbl = new System.Windows.Forms.Label();
            this.ReportHome_StartDateLbl = new System.Windows.Forms.Label();
            this.ReportHome_GroupReportBtn = new System.Windows.Forms.Button();
            this.ReportHome_Timer = new System.Windows.Forms.Timer(this.components);
            this.UseRep_TimeLbl = new System.Windows.Forms.Label();
            this.ReportHome_WindowLbl = new System.Windows.Forms.Label();
            this.ReportHome_SelectionBox = new System.Windows.Forms.GroupBox();
            this.ReportHome_GroupCmbo = new System.Windows.Forms.ComboBox();
            this.ReportHome_StudentCmbo = new System.Windows.Forms.ComboBox();
            this.ReportHome_GroupLbl = new System.Windows.Forms.Label();
            this.ReportHome_StudenLbl = new System.Windows.Forms.Label();
            this.ReportHome_SingleReportBtn = new System.Windows.Forms.Button();
            this.ReportHome_ButtonBox = new System.Windows.Forms.GroupBox();
            this.ReportHome_ExitBtn = new System.Windows.Forms.Button();
            this.ReportHome_CloseBtn = new System.Windows.Forms.Button();
            this.ReportHome_SelectReportBox = new System.Windows.Forms.GroupBox();
            this.ReportHome_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.ReportHome_DateLbl = new System.Windows.Forms.Label();
            this.ReportHome_AdminNameLbl = new System.Windows.Forms.Label();
            this.ReportHome_TimeLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.doNothingContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReportHome_DateRangeBox.SuspendLayout();
            this.ReportHome_SelectionBox.SuspendLayout();
            this.ReportHome_ButtonBox.SuspendLayout();
            this.ReportHome_SelectReportBox.SuspendLayout();
            this.ReportHome_UserInfoBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UseRep_DateLbl
            // 
            this.UseRep_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseRep_DateLbl.AutoSize = true;
            this.UseRep_DateLbl.Location = new System.Drawing.Point(346, 16);
            this.UseRep_DateLbl.Name = "UseRep_DateLbl";
            this.UseRep_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.UseRep_DateLbl.TabIndex = 18;
            this.UseRep_DateLbl.Text = "<Date>";
            // 
            // ReportHome_DateRangeBox
            // 
            this.ReportHome_DateRangeBox.Controls.Add(this.ReportHome_StartDate);
            this.ReportHome_DateRangeBox.Controls.Add(this.ReportHome_EndDate);
            this.ReportHome_DateRangeBox.Controls.Add(this.ReportHome_EndDateLbl);
            this.ReportHome_DateRangeBox.Controls.Add(this.ReportHome_StartDateLbl);
            this.ReportHome_DateRangeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportHome_DateRangeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_DateRangeBox.Location = new System.Drawing.Point(4, 216);
            this.ReportHome_DateRangeBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReportHome_DateRangeBox.Name = "ReportHome_DateRangeBox";
            this.ReportHome_DateRangeBox.Padding = new System.Windows.Forms.Padding(4);
            this.ReportHome_DateRangeBox.Size = new System.Drawing.Size(424, 111);
            this.ReportHome_DateRangeBox.TabIndex = 2;
            this.ReportHome_DateRangeBox.TabStop = false;
            this.ReportHome_DateRangeBox.Text = "Date Range";
            // 
            // ReportHome_StartDate
            // 
            this.ReportHome_StartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_StartDate.Location = new System.Drawing.Point(117, 33);
            this.ReportHome_StartDate.Margin = new System.Windows.Forms.Padding(4);
            this.ReportHome_StartDate.Name = "ReportHome_StartDate";
            this.ReportHome_StartDate.Size = new System.Drawing.Size(264, 20);
            this.ReportHome_StartDate.TabIndex = 0;
            this.ReportHome_StartDate.ValueChanged += new System.EventHandler(this.ReportHome_StartDate_ValueChanged);
            // 
            // ReportHome_EndDate
            // 
            this.ReportHome_EndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_EndDate.Location = new System.Drawing.Point(117, 65);
            this.ReportHome_EndDate.Margin = new System.Windows.Forms.Padding(4);
            this.ReportHome_EndDate.Name = "ReportHome_EndDate";
            this.ReportHome_EndDate.Size = new System.Drawing.Size(264, 20);
            this.ReportHome_EndDate.TabIndex = 1;
            this.ReportHome_EndDate.ValueChanged += new System.EventHandler(this.ReportHome_EndDate_ValueChanged);
            // 
            // ReportHome_EndDateLbl
            // 
            this.ReportHome_EndDateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_EndDateLbl.AutoSize = true;
            this.ReportHome_EndDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_EndDateLbl.Location = new System.Drawing.Point(37, 67);
            this.ReportHome_EndDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportHome_EndDateLbl.Name = "ReportHome_EndDateLbl";
            this.ReportHome_EndDateLbl.Size = new System.Drawing.Size(52, 13);
            this.ReportHome_EndDateLbl.TabIndex = 24;
            this.ReportHome_EndDateLbl.Text = "End Date";
            // 
            // ReportHome_StartDateLbl
            // 
            this.ReportHome_StartDateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_StartDateLbl.AutoSize = true;
            this.ReportHome_StartDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_StartDateLbl.Location = new System.Drawing.Point(36, 33);
            this.ReportHome_StartDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportHome_StartDateLbl.Name = "ReportHome_StartDateLbl";
            this.ReportHome_StartDateLbl.Size = new System.Drawing.Size(55, 13);
            this.ReportHome_StartDateLbl.TabIndex = 22;
            this.ReportHome_StartDateLbl.Text = "Start Date";
            // 
            // ReportHome_GroupReportBtn
            // 
            this.ReportHome_GroupReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_GroupReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_GroupReportBtn.Location = new System.Drawing.Point(218, 24);
            this.ReportHome_GroupReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReportHome_GroupReportBtn.Name = "ReportHome_GroupReportBtn";
            this.ReportHome_GroupReportBtn.Size = new System.Drawing.Size(117, 32);
            this.ReportHome_GroupReportBtn.TabIndex = 1;
            this.ReportHome_GroupReportBtn.Text = "Group Report";
            this.toolTip1.SetToolTip(this.ReportHome_GroupReportBtn, "Generates the report for your selected group.");
            this.ReportHome_GroupReportBtn.UseVisualStyleBackColor = true;
            this.ReportHome_GroupReportBtn.Click += new System.EventHandler(this.ReportHome_GroupReportBtn_Click);
            // 
            // ReportHome_Timer
            // 
            this.ReportHome_Timer.Enabled = true;
            this.ReportHome_Timer.Interval = 1000;
            this.ReportHome_Timer.Tick += new System.EventHandler(this.ReportHome_Timer_Tick);
            // 
            // UseRep_TimeLbl
            // 
            this.UseRep_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseRep_TimeLbl.AutoSize = true;
            this.UseRep_TimeLbl.Location = new System.Drawing.Point(346, 39);
            this.UseRep_TimeLbl.Name = "UseRep_TimeLbl";
            this.UseRep_TimeLbl.Size = new System.Drawing.Size(42, 13);
            this.UseRep_TimeLbl.TabIndex = 22;
            this.UseRep_TimeLbl.Text = "<Time>";
            // 
            // ReportHome_WindowLbl
            // 
            this.ReportHome_WindowLbl.AutoSize = true;
            this.ReportHome_WindowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_WindowLbl.Location = new System.Drawing.Point(7, 18);
            this.ReportHome_WindowLbl.Name = "ReportHome_WindowLbl";
            this.ReportHome_WindowLbl.Size = new System.Drawing.Size(99, 13);
            this.ReportHome_WindowLbl.TabIndex = 33;
            this.ReportHome_WindowLbl.Text = "Student Reports";
            // 
            // ReportHome_SelectionBox
            // 
            this.ReportHome_SelectionBox.Controls.Add(this.ReportHome_GroupCmbo);
            this.ReportHome_SelectionBox.Controls.Add(this.ReportHome_StudentCmbo);
            this.ReportHome_SelectionBox.Controls.Add(this.ReportHome_GroupLbl);
            this.ReportHome_SelectionBox.Controls.Add(this.ReportHome_StudenLbl);
            this.ReportHome_SelectionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportHome_SelectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_SelectionBox.Location = new System.Drawing.Point(4, 100);
            this.ReportHome_SelectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReportHome_SelectionBox.Name = "ReportHome_SelectionBox";
            this.ReportHome_SelectionBox.Padding = new System.Windows.Forms.Padding(4);
            this.ReportHome_SelectionBox.Size = new System.Drawing.Size(424, 108);
            this.ReportHome_SelectionBox.TabIndex = 1;
            this.ReportHome_SelectionBox.TabStop = false;
            this.ReportHome_SelectionBox.Text = "Select a Student or Group";
            // 
            // ReportHome_GroupCmbo
            // 
            this.ReportHome_GroupCmbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_GroupCmbo.ContextMenuStrip = this.doNothingContextMenu;
            this.ReportHome_GroupCmbo.FormattingEnabled = true;
            this.ReportHome_GroupCmbo.Location = new System.Drawing.Point(218, 66);
            this.ReportHome_GroupCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.ReportHome_GroupCmbo.MaxLength = 25;
            this.ReportHome_GroupCmbo.Name = "ReportHome_GroupCmbo";
            this.ReportHome_GroupCmbo.Size = new System.Drawing.Size(183, 21);
            this.ReportHome_GroupCmbo.TabIndex = 1;
            this.ReportHome_GroupCmbo.TextChanged += new System.EventHandler(this.ReportHome_GroupCmbo_TextChanged);
            this.ReportHome_GroupCmbo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_LettersAndDigitsKeyDown);
            this.ReportHome_GroupCmbo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReportHome_GroupCmbo_KeyPress);
            this.ReportHome_GroupCmbo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_KeyUp);
            // 
            // ReportHome_StudentCmbo
            // 
            this.ReportHome_StudentCmbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_StudentCmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ReportHome_StudentCmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ReportHome_StudentCmbo.ContextMenuStrip = this.doNothingContextMenu;
            this.ReportHome_StudentCmbo.FormattingEnabled = true;
            this.ReportHome_StudentCmbo.Location = new System.Drawing.Point(11, 66);
            this.ReportHome_StudentCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.ReportHome_StudentCmbo.MaxLength = 25;
            this.ReportHome_StudentCmbo.Name = "ReportHome_StudentCmbo";
            this.ReportHome_StudentCmbo.Size = new System.Drawing.Size(185, 21);
            this.ReportHome_StudentCmbo.TabIndex = 0;
            this.ReportHome_StudentCmbo.TextChanged += new System.EventHandler(this.ReportHome_StudentCmbo_TextChanged);
            this.ReportHome_StudentCmbo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_LettersKeyDown);
            this.ReportHome_StudentCmbo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReportHome_StudentCmbo_KeyPress);
            this.ReportHome_StudentCmbo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RaptorMath_KeyUp);
            // 
            // ReportHome_GroupLbl
            // 
            this.ReportHome_GroupLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_GroupLbl.AutoSize = true;
            this.ReportHome_GroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_GroupLbl.Location = new System.Drawing.Point(274, 33);
            this.ReportHome_GroupLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportHome_GroupLbl.Name = "ReportHome_GroupLbl";
            this.ReportHome_GroupLbl.Size = new System.Drawing.Size(36, 13);
            this.ReportHome_GroupLbl.TabIndex = 37;
            this.ReportHome_GroupLbl.Text = "Group";
            // 
            // ReportHome_StudenLbl
            // 
            this.ReportHome_StudenLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_StudenLbl.AutoSize = true;
            this.ReportHome_StudenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_StudenLbl.Location = new System.Drawing.Point(56, 33);
            this.ReportHome_StudenLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportHome_StudenLbl.Name = "ReportHome_StudenLbl";
            this.ReportHome_StudenLbl.Size = new System.Drawing.Size(44, 13);
            this.ReportHome_StudenLbl.TabIndex = 35;
            this.ReportHome_StudenLbl.Text = "Student";
            // 
            // ReportHome_SingleReportBtn
            // 
            this.ReportHome_SingleReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_SingleReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_SingleReportBtn.Location = new System.Drawing.Point(79, 24);
            this.ReportHome_SingleReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReportHome_SingleReportBtn.Name = "ReportHome_SingleReportBtn";
            this.ReportHome_SingleReportBtn.Size = new System.Drawing.Size(117, 30);
            this.ReportHome_SingleReportBtn.TabIndex = 0;
            this.ReportHome_SingleReportBtn.Text = "Single Report";
            this.toolTip1.SetToolTip(this.ReportHome_SingleReportBtn, "Generates the report for your selected student.");
            this.ReportHome_SingleReportBtn.UseVisualStyleBackColor = true;
            this.ReportHome_SingleReportBtn.Click += new System.EventHandler(this.ReportHome_SingleReportBtn_Click);
            // 
            // ReportHome_ButtonBox
            // 
            this.ReportHome_ButtonBox.Controls.Add(this.ReportHome_ExitBtn);
            this.ReportHome_ButtonBox.Controls.Add(this.ReportHome_CloseBtn);
            this.ReportHome_ButtonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportHome_ButtonBox.Location = new System.Drawing.Point(4, 449);
            this.ReportHome_ButtonBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReportHome_ButtonBox.Name = "ReportHome_ButtonBox";
            this.ReportHome_ButtonBox.Padding = new System.Windows.Forms.Padding(4);
            this.ReportHome_ButtonBox.Size = new System.Drawing.Size(424, 50);
            this.ReportHome_ButtonBox.TabIndex = 4;
            this.ReportHome_ButtonBox.TabStop = false;
            // 
            // ReportHome_ExitBtn
            // 
            this.ReportHome_ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_ExitBtn.Location = new System.Drawing.Point(294, 11);
            this.ReportHome_ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportHome_ExitBtn.Name = "ReportHome_ExitBtn";
            this.ReportHome_ExitBtn.Size = new System.Drawing.Size(117, 32);
            this.ReportHome_ExitBtn.TabIndex = 1;
            this.ReportHome_ExitBtn.Text = "Exit";
            this.toolTip1.SetToolTip(this.ReportHome_ExitBtn, "Closes the program.");
            this.ReportHome_ExitBtn.UseVisualStyleBackColor = true;
            this.ReportHome_ExitBtn.Click += new System.EventHandler(this.ReportHome_ExitBtn_Click);
            // 
            // ReportHome_CloseBtn
            // 
            this.ReportHome_CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReportHome_CloseBtn.Location = new System.Drawing.Point(161, 11);
            this.ReportHome_CloseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportHome_CloseBtn.Name = "ReportHome_CloseBtn";
            this.ReportHome_CloseBtn.Size = new System.Drawing.Size(117, 32);
            this.ReportHome_CloseBtn.TabIndex = 0;
            this.ReportHome_CloseBtn.Text = "Close";
            this.toolTip1.SetToolTip(this.ReportHome_CloseBtn, "Return to the administration\'s homepage.");
            this.ReportHome_CloseBtn.UseVisualStyleBackColor = true;
            this.ReportHome_CloseBtn.Click += new System.EventHandler(this.ReportHome_CloseBtn_Click);
            // 
            // ReportHome_SelectReportBox
            // 
            this.ReportHome_SelectReportBox.Controls.Add(this.ReportHome_SingleReportBtn);
            this.ReportHome_SelectReportBox.Controls.Add(this.ReportHome_GroupReportBtn);
            this.ReportHome_SelectReportBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportHome_SelectReportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportHome_SelectReportBox.Location = new System.Drawing.Point(4, 335);
            this.ReportHome_SelectReportBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReportHome_SelectReportBox.Name = "ReportHome_SelectReportBox";
            this.ReportHome_SelectReportBox.Padding = new System.Windows.Forms.Padding(4);
            this.ReportHome_SelectReportBox.Size = new System.Drawing.Size(424, 106);
            this.ReportHome_SelectReportBox.TabIndex = 3;
            this.ReportHome_SelectReportBox.TabStop = false;
            this.ReportHome_SelectReportBox.Text = "Select a Report";
            // 
            // ReportHome_UserInfoBox
            // 
            this.ReportHome_UserInfoBox.Controls.Add(this.ReportHome_DateLbl);
            this.ReportHome_UserInfoBox.Controls.Add(this.ReportHome_AdminNameLbl);
            this.ReportHome_UserInfoBox.Controls.Add(this.ReportHome_TimeLbl);
            this.ReportHome_UserInfoBox.Controls.Add(this.ReportHome_WindowLbl);
            this.ReportHome_UserInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportHome_UserInfoBox.Location = new System.Drawing.Point(4, 4);
            this.ReportHome_UserInfoBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReportHome_UserInfoBox.Name = "ReportHome_UserInfoBox";
            this.ReportHome_UserInfoBox.Padding = new System.Windows.Forms.Padding(4);
            this.ReportHome_UserInfoBox.Size = new System.Drawing.Size(424, 88);
            this.ReportHome_UserInfoBox.TabIndex = 0;
            this.ReportHome_UserInfoBox.TabStop = false;
            // 
            // ReportHome_DateLbl
            // 
            this.ReportHome_DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_DateLbl.AutoSize = true;
            this.ReportHome_DateLbl.Location = new System.Drawing.Point(361, 18);
            this.ReportHome_DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportHome_DateLbl.Name = "ReportHome_DateLbl";
            this.ReportHome_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.ReportHome_DateLbl.TabIndex = 31;
            this.ReportHome_DateLbl.Text = "<Date>";
            // 
            // ReportHome_AdminNameLbl
            // 
            this.ReportHome_AdminNameLbl.AutoSize = true;
            this.ReportHome_AdminNameLbl.Location = new System.Drawing.Point(8, 46);
            this.ReportHome_AdminNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportHome_AdminNameLbl.Name = "ReportHome_AdminNameLbl";
            this.ReportHome_AdminNameLbl.Size = new System.Drawing.Size(48, 13);
            this.ReportHome_AdminNameLbl.TabIndex = 28;
            this.ReportHome_AdminNameLbl.Text = "<Admin>";
            // 
            // ReportHome_TimeLbl
            // 
            this.ReportHome_TimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportHome_TimeLbl.AutoSize = true;
            this.ReportHome_TimeLbl.Location = new System.Drawing.Point(360, 46);
            this.ReportHome_TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportHome_TimeLbl.Name = "ReportHome_TimeLbl";
            this.ReportHome_TimeLbl.Size = new System.Drawing.Size(42, 13);
            this.ReportHome_TimeLbl.TabIndex = 17;
            this.ReportHome_TimeLbl.Text = "<Time>";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ReportHome_ButtonBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ReportHome_UserInfoBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReportHome_SelectReportBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ReportHome_SelectionBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReportHome_DateRangeBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0867F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.9133F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 503);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // doNothingContextMenu
            // 
            this.doNothingContextMenu.Name = "doNothingContextMenu";
            this.doNothingContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // StudentReports_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.ReportHome_CloseBtn;
            this.ClientSize = new System.Drawing.Size(432, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentReports_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Math";
            this.ReportHome_DateRangeBox.ResumeLayout(false);
            this.ReportHome_DateRangeBox.PerformLayout();
            this.ReportHome_SelectionBox.ResumeLayout(false);
            this.ReportHome_SelectionBox.PerformLayout();
            this.ReportHome_ButtonBox.ResumeLayout(false);
            this.ReportHome_SelectReportBox.ResumeLayout(false);
            this.ReportHome_UserInfoBox.ResumeLayout(false);
            this.ReportHome_UserInfoBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UseRep_AdminNameLbl;
        private System.Windows.Forms.Label UseRep_DateLbl;
        private System.Windows.Forms.GroupBox ReportHome_DateRangeBox;
        private System.Windows.Forms.Button ReportHome_GroupReportBtn;
        private System.Windows.Forms.DateTimePicker ReportHome_StartDate;
        private System.Windows.Forms.DateTimePicker ReportHome_EndDate;
        private System.Windows.Forms.Label ReportHome_EndDateLbl;
        private System.Windows.Forms.Label ReportHome_StartDateLbl;
        private System.Windows.Forms.Timer ReportHome_Timer;
        private System.Windows.Forms.Label UseRep_TimeLbl;
        private System.Windows.Forms.Label ReportHome_WindowLbl;
        private System.Windows.Forms.GroupBox UseRep_UserInfoBox;
        private System.Windows.Forms.Button ReportHome_SingleReportBtn;
        private System.Windows.Forms.GroupBox ReportHome_SelectionBox;
        private System.Windows.Forms.Label ReportHome_GroupLbl;
        private System.Windows.Forms.Label ReportHome_StudenLbl;
        private System.Windows.Forms.GroupBox ReportHome_ButtonBox;
        private System.Windows.Forms.Button ReportHome_CloseBtn;
        private System.Windows.Forms.GroupBox ReportHome_SelectReportBox;
        private System.Windows.Forms.Button ReportHome_ExitBtn;
        private System.Windows.Forms.GroupBox ReportHome_UserInfoBox;
        private System.Windows.Forms.Label ReportHome_DateLbl;
        private System.Windows.Forms.Label ReportHome_AdminNameLbl;
        private System.Windows.Forms.Label ReportHome_TimeLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox ReportHome_GroupCmbo;
        private System.Windows.Forms.ComboBox ReportHome_StudentCmbo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip doNothingContextMenu;
    }
}