namespace RaptorMath
{
    partial class CreateGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGroup));
            this.GroupNameLbl = new System.Windows.Forms.Label();
            this.NewGroupNameTxt = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.CreateGroupGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateGroupTimeLbl = new System.Windows.Forms.Label();
            this.CreateGroupDateLbl = new System.Windows.Forms.Label();
            this.CreateGroupGroupBox.SuspendLayout();
            this.ButtonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupNameLbl
            // 
            resources.ApplyResources(this.GroupNameLbl, "GroupNameLbl");
            this.GroupNameLbl.Name = "GroupNameLbl";
            // 
            // NewGroupNameTxt
            // 
            resources.ApplyResources(this.NewGroupNameTxt, "NewGroupNameTxt");
            this.NewGroupNameTxt.Name = "NewGroupNameTxt";
            this.NewGroupNameTxt.TextChanged += new System.EventHandler(this.NewGroupNameTxt_TextChanged);
            this.NewGroupNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RaptorMath_LettersAndDigitsKeyPress);
            // 
            // SaveBtn
            // 
            resources.ApplyResources(this.SaveBtn, "SaveBtn");
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            resources.ApplyResources(this.CloseBtn, "CloseBtn");
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CreateGroupGroupBox
            // 
            this.CreateGroupGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.CreateGroupGroupBox.Controls.Add(this.NewGroupNameTxt);
            this.CreateGroupGroupBox.Controls.Add(this.GroupNameLbl);
            this.CreateGroupGroupBox.Controls.Add(this.CreateGroupTimeLbl);
            this.CreateGroupGroupBox.Controls.Add(this.CreateGroupDateLbl);
            resources.ApplyResources(this.CreateGroupGroupBox, "CreateGroupGroupBox");
            this.CreateGroupGroupBox.Name = "CreateGroupGroupBox";
            this.CreateGroupGroupBox.TabStop = false;
            // 
            // ButtonGroupBox
            // 
            this.ButtonGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.ButtonGroupBox.Controls.Add(this.CloseBtn);
            this.ButtonGroupBox.Controls.Add(this.SaveBtn);
            resources.ApplyResources(this.ButtonGroupBox, "ButtonGroupBox");
            this.ButtonGroupBox.Name = "ButtonGroupBox";
            this.ButtonGroupBox.TabStop = false;
            // 
            // CreateGroupTimeLbl
            // 
            resources.ApplyResources(this.CreateGroupTimeLbl, "CreateGroupTimeLbl");
            this.CreateGroupTimeLbl.Name = "CreateGroupTimeLbl";
            // 
            // CreateGroupDateLbl
            // 
            resources.ApplyResources(this.CreateGroupDateLbl, "CreateGroupDateLbl");
            this.CreateGroupDateLbl.Name = "CreateGroupDateLbl";
            // 
            // CreateGroup
            // 
            this.AcceptButton = this.SaveBtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.ButtonGroupBox);
            this.Controls.Add(this.CreateGroupGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateGroup";
            this.CreateGroupGroupBox.ResumeLayout(false);
            this.CreateGroupGroupBox.PerformLayout();
            this.ButtonGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GroupNameLbl;
        private System.Windows.Forms.TextBox NewGroupNameTxt;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.GroupBox CreateGroupGroupBox;
        private System.Windows.Forms.GroupBox ButtonGroupBox;
        private System.Windows.Forms.Label CreateGroupTimeLbl;
        private System.Windows.Forms.Label CreateGroupDateLbl;
    }
}