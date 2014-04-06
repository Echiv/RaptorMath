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
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string AdminName
        {
            get { return MngUser_AdminNameLbl.Text; }
            set { MngUser_AdminNameLbl.Text = value; }
        }
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
            MngUsers_GroupCmbo.Items.Clear();
            foreach (Group group in localManager.groupList)
                MngUsers_GroupCmbo.Items.Add(group.Name);
        }

        private void RefreshUserDropDownBox()
        {
            MngUsers_NameCmbo.Items.Clear();
            MngUsers_UserCmbo.Items.Clear();
            foreach (Student student in localManager.studentList)
            {
                MngUsers_NameCmbo.Items.Add(student.LoginName);
                MngUsers_UserCmbo.Items.Add(student.LoginName);
            }
            foreach (Admin admin in localManager.adminList)
            {
                MngUsers_NameCmbo.Items.Add(admin.LoginName);
                MngUsers_UserCmbo.Items.Add(admin.LoginName);
            }
        }

        private void RefreshComboBoxes()
        {
            RefreshGroupDropDownBox();
            RefreshUserDropDownBox();
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
            RefreshComboBoxes();

            this.AdminName = localManager.currentUser.Remove(0, 8);
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
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        private void MngUsers_SaveUserBtm_Click(object sender, EventArgs e)
        {
            if (MngUsers_StudentRdo.Checked)
            {
                int groupID = localManager.FindGroupIDByName(MngUsers_GroupCmbo.Text);
                MessageBox.Show(groupID.ToString());
                bool isCreatedUser = localManager.CreateUser(groupID, MngUsers_NameCmbo.Text, "Unknown");
                if (isCreatedUser)
                {
                    RefreshComboBoxes();
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
                    isCreatedUser = localManager.CreateUser(MngUsers_NameCmbo.Text, MngUsers_PasswordTxt.Text, "Unknown", "RaptorMathStudents.xml");
                    if (isCreatedUser)
                    {
                        RefreshComboBoxes();
                        MessageBox.Show("New Admin Created!", "Raptor Math", MessageBoxButtons.OKCancel);
                    }
                    else
                        MessageBox.Show("Admin has not been Created!", "Raptor Math", MessageBoxButtons.OKCancel);
                }
                else
                    MessageBox.Show("The Passwords did not match!", "Raptor Math", MessageBoxButtons.OKCancel);
            }
        }

        private void MngUsers_StudentRdo_CheckedChanged(object sender, EventArgs e)
        {
            MngUsers_PasswordTxt.Enabled = false;
            MngUsers_ConfirmPasswordTxt.Enabled = false;
            MngUsers_GroupCmbo.Enabled = true;
        }

        private void MngUsers_AdminRdo_CheckedChanged(object sender, EventArgs e)
        {
            MngUsers_PasswordTxt.Enabled = true;
            MngUsers_ConfirmPasswordTxt.Enabled = true;
            MngUsers_GroupCmbo.Enabled = false;
        }

        private void MngUsers_RemoveUserBtn_Click(object sender, EventArgs e)
        {
            string userToBeRemoved = MngUsers_UserCmbo.Text;
            localManager.removeUser(userToBeRemoved);
            RefreshComboBoxes();
            MngUsers_UserCmbo.Text = string.Empty;
        }        
    }
}
