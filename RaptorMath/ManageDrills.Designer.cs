namespace RaptorMath
{
    partial class MngDrills_Form
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
            this.MngDrills_WindowLbl = new System.Windows.Forms.Label();
            this.MngDrills_UserInfoBox = new System.Windows.Forms.GroupBox();
            this.MngDrills_DrillBox = new System.Windows.Forms.GroupBox();
            this.MngDrills_OperationBox = new System.Windows.Forms.GroupBox();
            this.MngDrills_PerformBox = new System.Windows.Forms.GroupBox();
            this.MngDrills_ButtonBox = new System.Windows.Forms.GroupBox();
            this.MngDrills_AdminNameLbl = new System.Windows.Forms.Label();
            this.MngDrills_DateLbl = new System.Windows.Forms.Label();
            this.MngDrills_TimeLbl = new System.Windows.Forms.Label();
            this.MngDrills_AssignDrillRdo = new System.Windows.Forms.RadioButton();
            this.MngDrills_RemoveDrillRdo = new System.Windows.Forms.RadioButton();
            this.MngDrills_StudentDdl = new System.Windows.Forms.ComboBox();
            this.MngDrills_GroupDdl = new System.Windows.Forms.ComboBox();
            this.MngDrills_SelectDrillDdl = new System.Windows.Forms.ComboBox();
            this.MngDrills_StudentLbl = new System.Windows.Forms.Label();
            this.MngDrills_GroupLbl = new System.Windows.Forms.Label();
            this.MngDrills_SelectDrillLbl = new System.Windows.Forms.Label();
            this.MngDrills_AddRmvDrillBtn = new System.Windows.Forms.Button();
            this.MngDrills_CloseBtn = new System.Windows.Forms.Button();
            this.MngDrills_ExitBtn = new System.Windows.Forms.Button();
            this.MngDrills_UserInfoBox.SuspendLayout();
            this.MngDrills_DrillBox.SuspendLayout();
            this.MngDrills_OperationBox.SuspendLayout();
            this.MngDrills_PerformBox.SuspendLayout();
            this.MngDrills_ButtonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MngDrills_WindowLbl
            // 
            this.MngDrills_WindowLbl.AutoSize = true;
            this.MngDrills_WindowLbl.Location = new System.Drawing.Point(238, 9);
            this.MngDrills_WindowLbl.Name = "MngDrills_WindowLbl";
            this.MngDrills_WindowLbl.Size = new System.Drawing.Size(71, 13);
            this.MngDrills_WindowLbl.TabIndex = 0;
            this.MngDrills_WindowLbl.Text = "Manage Drills";
            // 
            // MngDrills_UserInfoBox
            // 
            this.MngDrills_UserInfoBox.Controls.Add(this.MngDrills_TimeLbl);
            this.MngDrills_UserInfoBox.Controls.Add(this.MngDrills_DateLbl);
            this.MngDrills_UserInfoBox.Controls.Add(this.MngDrills_AdminNameLbl);
            this.MngDrills_UserInfoBox.Location = new System.Drawing.Point(13, 29);
            this.MngDrills_UserInfoBox.Name = "MngDrills_UserInfoBox";
            this.MngDrills_UserInfoBox.Size = new System.Drawing.Size(495, 74);
            this.MngDrills_UserInfoBox.TabIndex = 1;
            this.MngDrills_UserInfoBox.TabStop = false;
            // 
            // MngDrills_DrillBox
            // 
            this.MngDrills_DrillBox.Controls.Add(this.MngDrills_PerformBox);
            this.MngDrills_DrillBox.Controls.Add(this.MngDrills_OperationBox);
            this.MngDrills_DrillBox.Location = new System.Drawing.Point(13, 109);
            this.MngDrills_DrillBox.Name = "MngDrills_DrillBox";
            this.MngDrills_DrillBox.Size = new System.Drawing.Size(495, 507);
            this.MngDrills_DrillBox.TabIndex = 2;
            this.MngDrills_DrillBox.TabStop = false;
            this.MngDrills_DrillBox.Text = "Add or Remove a Drill";
            // 
            // MngDrills_OperationBox
            // 
            this.MngDrills_OperationBox.Controls.Add(this.MngDrills_RemoveDrillRdo);
            this.MngDrills_OperationBox.Controls.Add(this.MngDrills_AssignDrillRdo);
            this.MngDrills_OperationBox.Location = new System.Drawing.Point(7, 20);
            this.MngDrills_OperationBox.Name = "MngDrills_OperationBox";
            this.MngDrills_OperationBox.Size = new System.Drawing.Size(482, 96);
            this.MngDrills_OperationBox.TabIndex = 0;
            this.MngDrills_OperationBox.TabStop = false;
            this.MngDrills_OperationBox.Text = "Select an Operation";
            // 
            // MngDrills_PerformBox
            // 
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_AddRmvDrillBtn);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_SelectDrillLbl);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_GroupLbl);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_StudentLbl);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_SelectDrillDdl);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_GroupDdl);
            this.MngDrills_PerformBox.Controls.Add(this.MngDrills_StudentDdl);
            this.MngDrills_PerformBox.Location = new System.Drawing.Point(7, 123);
            this.MngDrills_PerformBox.Name = "MngDrills_PerformBox";
            this.MngDrills_PerformBox.Size = new System.Drawing.Size(482, 377);
            this.MngDrills_PerformBox.TabIndex = 1;
            this.MngDrills_PerformBox.TabStop = false;
            this.MngDrills_PerformBox.Text = "Perform Action";
            // 
            // MngDrills_ButtonBox
            // 
            this.MngDrills_ButtonBox.Controls.Add(this.MngDrills_ExitBtn);
            this.MngDrills_ButtonBox.Controls.Add(this.MngDrills_CloseBtn);
            this.MngDrills_ButtonBox.Location = new System.Drawing.Point(13, 623);
            this.MngDrills_ButtonBox.Name = "MngDrills_ButtonBox";
            this.MngDrills_ButtonBox.Size = new System.Drawing.Size(495, 68);
            this.MngDrills_ButtonBox.TabIndex = 3;
            this.MngDrills_ButtonBox.TabStop = false;
            // 
            // MngDrills_AdminNameLbl
            // 
            this.MngDrills_AdminNameLbl.AutoSize = true;
            this.MngDrills_AdminNameLbl.Location = new System.Drawing.Point(7, 20);
            this.MngDrills_AdminNameLbl.Name = "MngDrills_AdminNameLbl";
            this.MngDrills_AdminNameLbl.Size = new System.Drawing.Size(48, 13);
            this.MngDrills_AdminNameLbl.TabIndex = 0;
            this.MngDrills_AdminNameLbl.Text = "<Admin>";
            // 
            // MngDrills_DateLbl
            // 
            this.MngDrills_DateLbl.AutoSize = true;
            this.MngDrills_DateLbl.Location = new System.Drawing.Point(438, 19);
            this.MngDrills_DateLbl.Name = "MngDrills_DateLbl";
            this.MngDrills_DateLbl.Size = new System.Drawing.Size(42, 13);
            this.MngDrills_DateLbl.TabIndex = 1;
            this.MngDrills_DateLbl.Text = "<Date>";
            // 
            // MngDrills_TimeLbl
            // 
            this.MngDrills_TimeLbl.AutoSize = true;
            this.MngDrills_TimeLbl.Location = new System.Drawing.Point(441, 36);
            this.MngDrills_TimeLbl.Name = "MngDrills_TimeLbl";
            this.MngDrills_TimeLbl.Size = new System.Drawing.Size(42, 13);
            this.MngDrills_TimeLbl.TabIndex = 2;
            this.MngDrills_TimeLbl.Text = "<Time>";
            // 
            // MngDrills_AssignDrillRdo
            // 
            this.MngDrills_AssignDrillRdo.AutoSize = true;
            this.MngDrills_AssignDrillRdo.Location = new System.Drawing.Point(167, 20);
            this.MngDrills_AssignDrillRdo.Name = "MngDrills_AssignDrillRdo";
            this.MngDrills_AssignDrillRdo.Size = new System.Drawing.Size(76, 17);
            this.MngDrills_AssignDrillRdo.TabIndex = 0;
            this.MngDrills_AssignDrillRdo.TabStop = true;
            this.MngDrills_AssignDrillRdo.Text = "Assign Drill";
            this.MngDrills_AssignDrillRdo.UseVisualStyleBackColor = true;
            // 
            // MngDrills_RemoveDrillRdo
            // 
            this.MngDrills_RemoveDrillRdo.AutoSize = true;
            this.MngDrills_RemoveDrillRdo.Location = new System.Drawing.Point(167, 43);
            this.MngDrills_RemoveDrillRdo.Name = "MngDrills_RemoveDrillRdo";
            this.MngDrills_RemoveDrillRdo.Size = new System.Drawing.Size(85, 17);
            this.MngDrills_RemoveDrillRdo.TabIndex = 1;
            this.MngDrills_RemoveDrillRdo.TabStop = true;
            this.MngDrills_RemoveDrillRdo.Text = "Remove Drill";
            this.MngDrills_RemoveDrillRdo.UseVisualStyleBackColor = true;
            // 
            // MngDrills_StudentDdl
            // 
            this.MngDrills_StudentDdl.FormattingEnabled = true;
            this.MngDrills_StudentDdl.Location = new System.Drawing.Point(179, 20);
            this.MngDrills_StudentDdl.Name = "MngDrills_StudentDdl";
            this.MngDrills_StudentDdl.Size = new System.Drawing.Size(121, 21);
            this.MngDrills_StudentDdl.TabIndex = 0;
            // 
            // MngDrills_GroupDdl
            // 
            this.MngDrills_GroupDdl.FormattingEnabled = true;
            this.MngDrills_GroupDdl.Location = new System.Drawing.Point(179, 47);
            this.MngDrills_GroupDdl.Name = "MngDrills_GroupDdl";
            this.MngDrills_GroupDdl.Size = new System.Drawing.Size(121, 21);
            this.MngDrills_GroupDdl.TabIndex = 1;
            // 
            // MngDrills_SelectDrillDdl
            // 
            this.MngDrills_SelectDrillDdl.FormattingEnabled = true;
            this.MngDrills_SelectDrillDdl.Location = new System.Drawing.Point(179, 74);
            this.MngDrills_SelectDrillDdl.Name = "MngDrills_SelectDrillDdl";
            this.MngDrills_SelectDrillDdl.Size = new System.Drawing.Size(121, 21);
            this.MngDrills_SelectDrillDdl.TabIndex = 2;
            // 
            // MngDrills_StudentLbl
            // 
            this.MngDrills_StudentLbl.AutoSize = true;
            this.MngDrills_StudentLbl.Location = new System.Drawing.Point(138, 23);
            this.MngDrills_StudentLbl.Name = "MngDrills_StudentLbl";
            this.MngDrills_StudentLbl.Size = new System.Drawing.Size(44, 13);
            this.MngDrills_StudentLbl.TabIndex = 3;
            this.MngDrills_StudentLbl.Text = "Student";
            // 
            // MngDrills_GroupLbl
            // 
            this.MngDrills_GroupLbl.AutoSize = true;
            this.MngDrills_GroupLbl.Location = new System.Drawing.Point(138, 50);
            this.MngDrills_GroupLbl.Name = "MngDrills_GroupLbl";
            this.MngDrills_GroupLbl.Size = new System.Drawing.Size(36, 13);
            this.MngDrills_GroupLbl.TabIndex = 4;
            this.MngDrills_GroupLbl.Text = "Group";
            // 
            // MngDrills_SelectDrillLbl
            // 
            this.MngDrills_SelectDrillLbl.AutoSize = true;
            this.MngDrills_SelectDrillLbl.Location = new System.Drawing.Point(117, 77);
            this.MngDrills_SelectDrillLbl.Name = "MngDrills_SelectDrillLbl";
            this.MngDrills_SelectDrillLbl.Size = new System.Drawing.Size(57, 13);
            this.MngDrills_SelectDrillLbl.TabIndex = 5;
            this.MngDrills_SelectDrillLbl.Text = "Select Drill";
            // 
            // MngDrills_AddRmvDrillBtn
            // 
            this.MngDrills_AddRmvDrillBtn.Location = new System.Drawing.Point(176, 102);
            this.MngDrills_AddRmvDrillBtn.Name = "MngDrills_AddRmvDrillBtn";
            this.MngDrills_AddRmvDrillBtn.Size = new System.Drawing.Size(75, 23);
            this.MngDrills_AddRmvDrillBtn.TabIndex = 6;
            this.MngDrills_AddRmvDrillBtn.Text = "Add/Rmv Drill";
            this.MngDrills_AddRmvDrillBtn.UseVisualStyleBackColor = true;
            // 
            // MngDrills_CloseBtn
            // 
            this.MngDrills_CloseBtn.Location = new System.Drawing.Point(293, 19);
            this.MngDrills_CloseBtn.Name = "MngDrills_CloseBtn";
            this.MngDrills_CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.MngDrills_CloseBtn.TabIndex = 7;
            this.MngDrills_CloseBtn.Text = "Close";
            this.MngDrills_CloseBtn.UseVisualStyleBackColor = true;
            // 
            // MngDrills_ExitBtn
            // 
            this.MngDrills_ExitBtn.Location = new System.Drawing.Point(401, 19);
            this.MngDrills_ExitBtn.Name = "MngDrills_ExitBtn";
            this.MngDrills_ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.MngDrills_ExitBtn.TabIndex = 8;
            this.MngDrills_ExitBtn.Text = "Exit";
            this.MngDrills_ExitBtn.UseVisualStyleBackColor = true;
            // 
            // MngDrills_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 700);
            this.Controls.Add(this.MngDrills_ButtonBox);
            this.Controls.Add(this.MngDrills_DrillBox);
            this.Controls.Add(this.MngDrills_UserInfoBox);
            this.Controls.Add(this.MngDrills_WindowLbl);
            this.Name = "MngDrills_Form";
            this.Text = "Raptor Math";
            this.MngDrills_UserInfoBox.ResumeLayout(false);
            this.MngDrills_UserInfoBox.PerformLayout();
            this.MngDrills_DrillBox.ResumeLayout(false);
            this.MngDrills_OperationBox.ResumeLayout(false);
            this.MngDrills_OperationBox.PerformLayout();
            this.MngDrills_PerformBox.ResumeLayout(false);
            this.MngDrills_PerformBox.PerformLayout();
            this.MngDrills_ButtonBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox MngDrills_SelectDrillDdl;
        private System.Windows.Forms.ComboBox MngDrills_GroupDdl;
        private System.Windows.Forms.ComboBox MngDrills_StudentDdl;
        private System.Windows.Forms.RadioButton MngDrills_RemoveDrillRdo;
        private System.Windows.Forms.RadioButton MngDrills_AssignDrillRdo;
        private System.Windows.Forms.Button MngDrills_ExitBtn;
        private System.Windows.Forms.Button MngDrills_CloseBtn;
    }
}