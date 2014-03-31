//==============================================================//
//					       AdminHome.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Kyle Bridges and Harvey Kreitzer                    //
// Purpose: This form handles the implementation of our         //
//          required Admin Home page. Current date and time     //
//          are initialized along with the user's name, last    //
//          login date, and the drop down list is filled with   //
//          all the current students. (As of Cycle 1)           //
// User:    • The user is assumed to be an admin.               //
//          • The user can select the name of a student within  //
//            the drop down list to edit or view their records. //
//          • Once a student is selected, the user can click    //
//            the "View Records" button. This sends the user    //
//            to the User Report page.                          //
//          • Once a student is selected, the user can edit the //
//            student's current drill settings by changing the  //
//            operand range (min/max), operator type (+/-), and //
//            the number of questions per drill. As long as     //
//            these entries are valid (min < max, entries are   //
//            not 0, student is selected), the user can click   //
//            the Save Settings button to read the new settings //
//            into that student's XML file.                     //
//          • The user can click the Logout button to return to //
//            the User Designation page or click the Exit       //
//            button to end the program.                        //
// Result:  The Manager sets window to the User Report page and //
//          closes the current one.                             //
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
    public partial class AdminHome_Form : Form
    {
        public Manager localManager;

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string AdminName
        {
            get { return AdminHome_AdminNameLbl.Text; }
            set { AdminHome_AdminNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string LastLogin
        {
            get { return AdminHome_LoginLbl.Text; }
            set { AdminHome_LoginLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/13/2014                                                  //
        //------------------------------------------------------------------//
        public AdminHome_Form(Manager manager)
        {
            localManager = manager;
            InitializeComponent();
            InitializeDate();
            InitializeTimer();
/*
            foreach (String student in localManager.GetStudents())
                AdminHome_StudentSelection.Items.Add(student);
*/
            this.AdminName = localManager.currentUser.Remove(0, 8);
            if (localManager.currentAdmin.LastLogin == "Unknown")
                this.LastLogin = "--/--/----";
            else
                this.LastLogin = localManager.currentAdmin.LastLogin;

            localManager.SaveLoginDate(localManager.adminXMLPath,
                localManager.currentAdmin.LoginName, DateTime.Now.ToString("M/d/yyyy"), true);
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 3/3/2014                                                   //
        //------------------------------------------------------------------//
        private void InitializeDate()
        {
            AdminHome_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/14/2014                                                  //
        //------------------------------------------------------------------//
        private void InitializeTimer()
        {
            AdminHome_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/14/2014                                                  //
        //------------------------------------------------------------------//
        private void AdminHome_Timer_Tick(object sender, EventArgs e)
        {
            AdminHome_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/13/2014                                                  //
        //------------------------------------------------------------------//
        private void AdminHome_LogoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout? Any settings changes will not be saved.",
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // Save date you want to write out into class
                localManager.ClearAdminUser();
                localManager.currentUser = string.Empty;
                localManager.SetWindow(Window.authUser); 
                this.Close();
            }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/13/2014                                                  //
        //------------------------------------------------------------------//
        private void AdminHome_ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit Raptor Math? Any settings changes will not be saved.", 
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                localManager.ClearAdminUser();
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        private void AdminHome_SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void AdminHome_MngUsersBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.mngUsers);
            this.Close();
        }

        private void AdminHome_MngGroupsBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.mngGroups);
            this.Close();
        }

        private void AdminHome_StuReportBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.studentReports);
            this.Close();
        }

        private void AdminHome_EditStudentBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.editStudents);
            this.Close();
        }

        private void AdminHome_CreateDrillBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.createDrill);
            this.Close();
        }

        private void AdminHome_MngDrillBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.mngDrills);
            this.Close();
        }
/*
        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/13/2014                                                  //
        //------------------------------------------------------------------//
        private void studentRecordsButton_Click(object sender, EventArgs e)
        {
            // Clear current student
            localManager.currentStudent = localManager.FindStudentForReport(AdminHome_StudentSelection.Text);
            localManager.SetWindow(Window.adminReport);
            this.Close();
        }
*/
/*
        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        private void AdminHome_SaveSettingsBtn_Click(object sender, EventArgs e)
        {
            // Make sure all forms and radio buttons are filled and valid
            if ((localManager.InvalidDrillFields(AdminHome_MinOperand.Text, AdminHome_MaxOperand.Text, AdminHome_SetSize.Text))
                || (localManager.InvalidRadioButtons(AdminHome_AddRdo.Checked, AdminHome_SubRdo.Checked))
                || (localManager.InvalidRange(AdminHome_MinOperand.Text, AdminHome_MaxOperand.Text)
                || (localManager.InvalidStudentSelection(AdminHome_StudentSelection.Text)))
                || (localManager.InvalidQuestionCount(AdminHome_SetSize.Text)))
            {
                MessageBox.Show("You are missing a selection or have entered an invalid range.", "Raptor Math", MessageBoxButtons.OK);
            }
            else
            {
                localManager.SetOperand(AdminHome_AddRdo.Checked, AdminHome_SubRdo.Checked);
                //localManager.SaveDrillSettings(AdminHome_StudentSelection.Text, AdminHome_MinOperand.Text, AdminHome_MaxOperand.Text,
                //   AdminHome_SetSize.Text);
                MessageBox.Show("Settings succesfully saved.", "Raptor Math", MessageBoxButtons.OK);
            }
        }
*/
/*
        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        private void AdminHome_StudentSelection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AdminHome_RecordsBtn.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.mngUsers);
            this.Close();
        }
*/
    }
}
