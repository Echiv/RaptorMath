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
// Authors: Cody Jordan and Cian Carota                         //
// Changes:                                                     //
//          • Removed ability to creat drills to Create Drill   //
//            form.                                             //
//          • Added menu buttons to access admin tools.         //
//          • Refactored: Accessors, constructors, click events //
//            and other functions.                              //
//          • Added support for key events.                     //
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

        private bool isKeyPressed = false;

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle KeyUp event.</summary>
        private void RaptorMath_KeyUp(object sender, KeyEventArgs e)
        {
            isKeyPressed = false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersKeyDown event.</summary>
        private void RaptorMath_LettersKeyDown(object sender, KeyEventArgs e)
        {
            bool isLetter = char.IsLetter((char)e.KeyCode);
            if ((e.KeyCode != Keys.Back) && (!e.Shift) && (!isLetter))
            {
                e.SuppressKeyPress = isKeyPressed;
                isKeyPressed = true;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersAndDigitsKeyDown event.</summary>
        private void RaptorMath_LettersAndDigitsKeyDown(object sender, KeyEventArgs e)
        {
            bool isLetterorDigit = char.IsLetterOrDigit((char)e.KeyCode);
            bool isSpace = char.IsWhiteSpace((char)e.KeyCode);
            if ((e.KeyCode != Keys.Back) && (!e.Shift) && (!isLetterorDigit))
            {
                e.SuppressKeyPress = isKeyPressed;
                isKeyPressed = true;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle DigitsKeyDown event.</summary>
        private void RaptorMath_DigitsKeyDown(object sender, KeyEventArgs e)
        {
            bool isDigit = char.IsDigit((char)e.KeyCode);
            if ((e.KeyCode != Keys.Back) && (!e.Shift) && (!isDigit))
            {
                e.SuppressKeyPress = isKeyPressed;
                isKeyPressed = true;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersWithOneWhiteSpaceKeyPress event.</summary>
        private void RaptorMath_LettersWithOneWhiteSpaceKeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox cmbobx = (ComboBox)sender;
            e.Handled = (!(char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || (!cmbobx.Text.Contains(' ')) || (char.IsControl(e.KeyChar))));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersAndDigitsKeyPress event.</summary>
        private void RaptorMath_LettersAndDigitsKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || (char.IsControl(e.KeyChar)));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle DigitsKeyPress event.</summary>
        private void RaptorMath_DigitsKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (char.IsControl(e.KeyChar)));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersKeyPress event.</summary>
        private void RaptorMath_LettersKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (char.IsControl(e.KeyChar)));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

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
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        public AdminHome_Form(Manager manager)
        {
            localManager = manager;
            InitializeComponent();
            InitializeDate();
            InitializeTimer();

            this.AdminHome_CurrentPWTxt.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsKeyPress);
            this.AdminHome_NewPWTxt.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsKeyPress);

            AdminHome_CurrentPWTxt.Select();
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
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/13/14                                                    //
        //------------------------------------------------------------------//
        private void AdminHome_LogoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout? Any unsaved changes will be lost",
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
            if (MessageBox.Show("Are you sure you want to quit Raptor Math? Any unsaved changes will be lost", 
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                localManager.ClearAdminUser();
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Save' button click.</summary>
        private void AdminHome_SaveBtn_Click(object sender, EventArgs e)
        {
            bool passwordMatch = localManager.ChangeAdminPassword(AdminHome_CurrentPWTxt.Text.Trim(), AdminHome_NewPWTxt.Text.Trim());
            if (AdminHome_NewPWTxt.Text.Trim().All(char.IsLetterOrDigit))
            {
                if (passwordMatch == true)
                {
                    MessageBox.Show("Your password has been saved", "Raptor Math", MessageBoxButtons.OK);
                    AdminHome_CurrentPWTxt.Text = string.Empty;
                    AdminHome_NewPWTxt.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("The current password does not match the records", "Raptor Math", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("That password contains an invalid character", "Raptor Math", MessageBoxButtons.OK);
            }

        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Manage Users' button click.</summary>
        private void AdminHome_MngUsersBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.mngUsers);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Manage Groups' button click.</summary>
        private void AdminHome_MngGroupsBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.mngGroups);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Student Report' button click.</summary>
        private void AdminHome_StuReportBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.studentReports);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Edit Students' button click.</summary>
        private void AdminHome_EditStudentBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.editStudents);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Create Drill' button click.</summary>
        private void AdminHome_CreateDrillBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.createDrill);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Manage Drill' button click.</summary>
        private void AdminHome_MngDrillBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.mngDrills);
            this.Close();
        }

        private void AdminHome_AdminNameLbl_Click(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void AdminHome_PasswordBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AdminHome_SaveBtn_Click(sender, e); // call click event on Save Button
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle Text Changed event.</summary>
        private void AdminHome_CurrentPWTxt_TextChanged(object sender, EventArgs e)
        {
            if((AdminHome_CurrentPWTxt.Text.Length > 0)&&(AdminHome_NewPWTxt.Text.Length > 0))
            {
                AdminHome_SaveBtn.Enabled = true;
            }
            else
            {
                AdminHome_SaveBtn.Enabled = false;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>>Handle Text Changed event.</summary>
        private void AdminHome_NewPWTxt_TextChanged(object sender, EventArgs e)
        {
            if ((AdminHome_CurrentPWTxt.Text.Length > 0) && (AdminHome_NewPWTxt.Text.Length > 0))
            {
                AdminHome_SaveBtn.Enabled = true;
            }
            else
            {
                AdminHome_SaveBtn.Enabled = false;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/11/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Disallows copy, paste, cut from keyboard.</summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == (Keys.Control | Keys.C)) || (keyData == (Keys.Control | Keys.V)) || (keyData == (Keys.Control | Keys.X)))
            {

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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
