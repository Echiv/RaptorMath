using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RaptorMath
{
    public partial class MngUsers_Form : Form
    {
        public Manager localManager;

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                   //
        //------------------------------------------------------------------//
        private void InitializeDate()
        {
            MngUsers_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        private void InitializeTimer()
        {
            MngUsers_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void RefreshGroupDropDownBox()
        {
            MngUsers_GroupDdl.Items.Clear();
            foreach (string group in localManager.GetGroups())
                MngUsers_GroupDdl.Items.Add(group);
        }

        private void MngUsers_Timer_Tick(object sender, EventArgs e)
        {
            MngUsers_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        public MngUsers_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();
            RefreshGroupDropDownBox();
        }

        private void MngUsers_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        private void MngUsers_ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit Raptor Math? Any settings changes will not be saved.",
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                localManager.ClearAdminUser();
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        private void MngUsers_SaveUserBtm_Click(object sender, EventArgs e)
        {
            string newUserName = MngUsers_NameTxt.Text;
            string newUserPassword = MngUsers_PasswordTxt.Text;
            string newUserConfirmPassword = MngUsers_ConfirmPasswordTxt.Text;
            MessageBox.Show(MngUsers_GroupDdl.Text);
            string newUserGroup = MngUsers_GroupDdl.Text;
            if ((MngUsers_StudentRdo.Checked) && (MngUsers_GroupDdl.Text != ""))
            {
                bool isCreatedUser = localManager.CreateUser(newUserGroup, newUserName, "Unknown");
                if (isCreatedUser)
                {
                    RefreshGroupDropDownBox();
                    MessageBox.Show("New Student Created!", "Raptor Math", MessageBoxButtons.OKCancel);
                }
                else
                    MessageBox.Show("Student has not been Created!", "Raptor Math", MessageBoxButtons.OKCancel);
            }
            else if ((MngUsers_AdminRdo.Checked) && (MngUsers_PasswordTxt.Text.Length > 0 && MngUsers_ConfirmPasswordTxt.Text.Length > 0))
            {
                bool isCreatedUser = false;
                if (MngUsers_PasswordTxt.Text == MngUsers_ConfirmPasswordTxt.Text)
                {
                    isCreatedUser = localManager.CreateUser(newUserName, newUserPassword, "Unknown", "RaptorMathStudents.xml");
                    if (isCreatedUser)
                        MessageBox.Show("New Admin Created!", "Raptor Math", MessageBoxButtons.OKCancel);
                    else
                        MessageBox.Show("Admin has not been Created!", "Raptor Math", MessageBoxButtons.OKCancel);
                }
                else
                    MessageBox.Show("Admin has not been Created!", "Raptor Math", MessageBoxButtons.OKCancel);
            }
            else
                MessageBox.Show("The User could not be created!!", "Raptor Math", MessageBoxButtons.OKCancel);

        }

        private void MngUsers_StudentRdo_CheckedChanged(object sender, EventArgs e)
        {
            MngUsers_PasswordTxt.Enabled = false;
            MngUsers_ConfirmPasswordTxt.Enabled = false;
            MngUsers_GroupDdl.Enabled = true;
        }

        private void MngUsers_AdminRdo_CheckedChanged(object sender, EventArgs e)
        {
            MngUsers_PasswordTxt.Enabled = true;
            MngUsers_ConfirmPasswordTxt.Enabled = true;
            MngUsers_GroupDdl.Enabled = false;
        }        
    }
}
