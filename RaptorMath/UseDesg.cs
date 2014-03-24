//==============================================================//
//					       UseDesg.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Kyle Bridges and Harvey Kreitzer                    //
// Purpose: This form handles the implementation of our         //
//          required User Designation page. Current date and    //
//          time are initialized, and the drop down list is     //
//          filled with a list of names for both admins and     //
//          students.                                           //
// User:    • The user can be either an admin or a student.     //
//          • The user selects their name from the provided     //
//            drop down list and they are sent to either the    //
//            student home page or the admin home page.         //
//          • The user is allowed to exit the program.          //
// Result:  The Manager sets window to the next form            //
//          (either Student Home page or Admin Home page)       //
//          and closes the current one.                         //
//==============================================================//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RaptorMath
{
    public partial class UseDesg_Form : Form
    {
        Manager localManager;

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/12/2014                                                  //
        //------------------------------------------------------------------//
        public UseDesg_Form(Manager manager)
        {
            localManager = manager;
            InitializeComponent();
            InitializeDate();
            InitializeTimer();
            RefreshLoginDropDownBox();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 3/2/2014                                                   //
        //------------------------------------------------------------------//
        private void InitializeDate()
        {
            UseDesg_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/11/2014                                                  //
        //------------------------------------------------------------------//
        private void InitializeTimer()
        {
            UseDesg_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void RefreshLoginDropDownBox()
        {
            UseDesg_LoginDdl.Items.Clear();
            foreach (string item in localManager.GetUsers())
                UseDesg_LoginDdl.Items.Add(item);
        }
        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/11/2014                                                  //
        //------------------------------------------------------------------//
        private void UseDesg_Timer_Tick(object sender, EventArgs e)
        {
            UseDesg_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/11/2014                                                  //
        //------------------------------------------------------------------//
        private void UseDesg_ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit Raptor Math?", 
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/16/2014                                                  //
        //------------------------------------------------------------------//
        private void UseDesg_LoginBtn_Click(object sender, EventArgs e)
        {
            localManager.currentPassword = UseDesg_passwordBox.Text;
            if (localManager.grantAccess() != true)
            {
                MessageBox.Show("Wrong password, Try again!");
                UseDesg_passwordBox.Text = string.Empty;
            }
            else
                this.Close();            
        }
      
        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/16/2014                                                  //
        //------------------------------------------------------------------//
        private void UseDesg_LoginDdl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            localManager.currentUser = UseDesg_LoginDdl.Text;
            if (localManager.isStudent())
            {
                UseDesg_passwordBox.Enabled = false;
                UseDesg_LoginBtn.Enabled = true;
            }
            else
            {
                UseDesg_passwordBox.Enabled = true;
                UseDesg_LoginBtn.Enabled = false;
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if((localManager.currentUser != string.Empty) && (UseDesg_passwordBox.Text.Length > 0))
                UseDesg_LoginBtn.Enabled = true;
            else
                UseDesg_LoginBtn.Enabled = false;
        }
    }
}