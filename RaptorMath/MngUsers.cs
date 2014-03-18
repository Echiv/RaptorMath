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
            if (MngUsers_StudentRdo.Checked)
                localManager.CreateUser("unassigned", newUserName, "Unknown", "funnyStuff.xml", "moreFunnyStuff.xml");
            else if (MngUsers_AdminRdo.Checked)
                
                localManager.CreateUser(newUserName, newUserPassword, "Unknown", "funStuff.xml");
               
            

            
        }        
    }
}
