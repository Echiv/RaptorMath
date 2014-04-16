//==============================================================//
//					       MngUsers.cs		       		        //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Cody Jordan and Cian Carota                         //
// Purpose: This form allows the user to create and/or remove   //
//          users.                                              //
// User:    • The user is assumed to be an admin.               //
//          • The user can select whether to add a student or   //
//            an admin.                                         //
//          • The user can enter their first and last name.     //
//          • If adding an admin, the user must set a password. //
//          • If adding a student, the user must associate them //
//            with a group.                                     //
//          • The user can then click the Save User button to   //
//            save the new user.                                //
//          • The user can select the name of a current user.   //
//          • The user can then click the Remove User button to //
//            remove the selected user.                         //
//          • The user can click the Close button to return to  //
//            Admin Home or click the Exit button to end the    //
//            program.                                          //
//==============================================================//
/* 
Authors: Joshua Boone and Justine Dinh                     
Cycle 3 Changes:
 * Date: 4/12/14
 * • Added logic to disallow interaction with a form's border close button.
 * • Added logic to disallow copy, paste, and cut.
 * • No longer display passwords as plain text
 * Date: 4/13/14
 * • Changed regular message boxes to the proper error message boxes.
 * • Added support for numbers ot be entered into the password boxes.
 * • Fixed a tabbing issue where tabs wouldn't work in the right order when certain boxes had data in them
 * • Added some UI enhancements to better direct the user during errors.
 * • Added a confirmation box when removing a user from the system.
 * • Added new button for importing students from a text file
 * Date: 4/14/14
 * • Changed some logic when creating a new user that was causing to error messages boxes to appear.
 *   so that only one is shown
 * • Fixed a bug that allowed numbers and special characters into the selection combo for removing a user.
 * Date: 4/15/14
 * • Changed the minimal length of a password to 4 and the maximum length to 8.
 * • Added logic to keep the save button disabled until all boxes have the correct data in them.
 * Date: 4/16/14
 * • Updated logic for the radio buttons so the they enable/disbale the save button correctly when clicked.
*/

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
        private bool isKeyPressed = false;
        // Used when importing students from a txt file
        OpenFileDialog openFile;
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Disallows closing a window with the window's 'X' button.</summary>
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        } 

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
        private void RaptorMath_LettersAndWhiteSpaceKeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox cmbobx = (ComboBox)sender;
            e.Handled = !(char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || (char.IsControl(e.KeyChar)));
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
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/13/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersAndDigitsKeyPress event.</summary>
        private void RaptorMath_OnlyLettersAndDigitsKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || (char.IsControl(e.KeyChar)));
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
            get { return MngUser_AdminNameLbl.Text; }
            set { MngUser_AdminNameLbl.Text = value; }
        }
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current date.</summary>
        private void InitializeDate()
        {
            MngUsers_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current time.</summary>
        private void InitializeTimer()
        {
            MngUsers_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'Group' combo box.
        /// </summary>
        private void RefreshGroupDropDownBox()
        {
            MngUsers_GroupCmbo.Items.Clear();
            foreach (Group group in localManager.groupList)
                MngUsers_GroupCmbo.Items.Add(group.Name);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/4/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'First Name',
        /// 'Last Name', & 'Select a User' combo boxes.</summary>
        private void RefreshUserDropDownBox()
        {
            MngUsers_FirstNameCmbo.Items.Clear();
            MngUsers_LastNameCmbo.Items.Clear();
            MngUsers_RemoveUserCmbo.Items.Clear();
            foreach (String userFirstName in localManager.GetUsersFirstNames())
            {
                MngUsers_FirstNameCmbo.Items.Add(userFirstName);
            }
            foreach (String userLastName in localManager.GetUsersLastNames())
            {
                MngUsers_LastNameCmbo.Items.Add(userLastName);
            }
            List<String> listOfUsers = localManager.GetUsers();
            foreach (String userNames in listOfUsers)
            {
                if (listOfUsers.Count > 0)
                {
                    MngUsers_RemoveUserCmbo.Enabled = true;
                    MngUsers_RemoveUserCmbo.Items.Add(userNames);
                }
                else
                    MngUsers_RemoveUserCmbo.Enabled = false;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of all combo boxes.
        /// </summary>
        private void RefreshComboBoxes()
        {
            RefreshGroupDropDownBox();
            RefreshUserDropDownBox();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Time display update on timer tick.</summary>
        private void MngUsers_Timer_Tick(object sender, EventArgs e)
        {
            MngUsers_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/4/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Manage Users form constructor.</summary>
        /// <param name="manager">The program management class.</param>
        public MngUsers_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();
            RefreshComboBoxes();

            if (MngUsers_RemoveUserCmbo.Items.Count == 0)
            {
                MngUsers_RemoveUserCmbo.Enabled = false;
            }
            MngUsers_ConfirmPasswordTxt.Enabled = false;
            MngUsers_RemoveUserBtn.Enabled = false;
            MngUsers_SaveUserBtm.Enabled = false;
            MngUsers_PasswordTxt.PasswordChar = '*';
            MngUsers_ConfirmPasswordTxt.PasswordChar = '*';

            MngUsers_StudentRdo.Select();
            this.MngUsers_FirstNameCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersKeyPress);
            this.MngUsers_LastNameCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersKeyPress);
            this.MngUsers_PasswordTxt.KeyPress += new KeyPressEventHandler(RaptorMath_OnlyLettersAndDigitsKeyPress);
            this.MngUsers_ConfirmPasswordTxt.KeyPress += new KeyPressEventHandler(RaptorMath_OnlyLettersAndDigitsKeyPress);
            this.MngUsers_GroupCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsKeyPress);
            this.MngUsers_RemoveUserCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndWhiteSpaceKeyPress);

            this.AdminName = localManager.currentUser.Remove(0, 8);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Close' button click.</summary>
        private void MngUsers_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Exit' button click.</summary>
        private void MngUsers_ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit Raptor Math? Any settings changes will not be saved.",
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/4/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Save User' button click.</summary>
        private void MngUsers_SaveUserBtm_Click(object sender, EventArgs e)
        {
            if (MngUsers_StudentRdo.Checked)
            {
                bool isCreatedUser = false;
                int groupID = localManager.FindGroupIDByName(MngUsers_GroupCmbo.Text.Trim());

                if (groupID == 0)
                {
                    MessageBox.Show("The group entered does not match any groups.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // 4/14/14 Moved the if/else into this else to prevent two error boxes from displaying
                    isCreatedUser = localManager.CreateUser(groupID, MngUsers_FirstNameCmbo.Text, MngUsers_LastNameCmbo.Text, "Unknown");
                    if (isCreatedUser)
                    {
                        RefreshComboBoxes();
                        MessageBox.Show("New user created.", "Raptor Math", MessageBoxButtons.OK);
                        MngUsers_FirstNameCmbo.Text = string.Empty;
                        MngUsers_LastNameCmbo.Text = string.Empty;
                        MngUsers_GroupCmbo.Text = string.Empty;
                        MngUsers_FirstNameCmbo.Select();
                    }
                    else
                    {
                        MessageBox.Show("Entered name already exists.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if ((MngUsers_AdminRdo.Checked)
                && ((MngUsers_PasswordTxt.Text.Length >= 4) && (MngUsers_ConfirmPasswordTxt.Text.Length >= 4))
                && ((MngUsers_FirstNameCmbo.Text.Length > 0) && (MngUsers_LastNameCmbo.Text.Length > 0)))
            {
                bool isCreatedUser = false;
                if (MngUsers_PasswordTxt.Text == MngUsers_ConfirmPasswordTxt.Text)
                {
                    isCreatedUser = localManager.CreateUser(MngUsers_FirstNameCmbo.Text, MngUsers_LastNameCmbo.Text, MngUsers_PasswordTxt.Text, "Unknown", "RaptorMathStudents.xml");
                    if (isCreatedUser)
                    {
                        MessageBox.Show("New user created.", "Raptor Math", MessageBoxButtons.OK);
                        MngUsers_FirstNameCmbo.Text = string.Empty;
                        MngUsers_LastNameCmbo.Text = string.Empty;
                        MngUsers_PasswordTxt.Text = string.Empty;
                        MngUsers_ConfirmPasswordTxt.Text = string.Empty;
                        RefreshComboBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Entered name already exists.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MngUsers_FirstNameCmbo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Entered passwords do not match. Please try again.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MngUsers_PasswordTxt.Text = string.Empty;
                    MngUsers_ConfirmPasswordTxt.Text = string.Empty;
                    MngUsers_PasswordTxt.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error. Must provide a password.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MngUsers_PasswordTxt.Focus();
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/4/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Save User' button click.</summary>
        //private void MngUsers_SaveUserBtm_Click2(object sender, EventArgs e)
        //{
        //    if (MngUsers_StudentRdo.Checked)
        //    {
        //        int isCreatedUser = localManager.CreateStudent(MngUsers_GroupCmbo.Text.Trim(), MngUsers_FirstNameCmbo.Text, MngUsers_LastNameCmbo.Text, "Unknown");

        //        if (isCreatedUser == 0)
        //        {
        //            MessageBox.Show("The group entered does not match any groups.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //        {
        //            isCreatedUser = localManager.CreateUser(groupID, MngUsers_FirstNameCmbo.Text, MngUsers_LastNameCmbo.Text, "Unknown");
        //            if (isCreatedUser)
        //            {
        //                RefreshComboBoxes();
        //                MessageBox.Show("New user created.", "Raptor Math", MessageBoxButtons.OK);
        //                MngUsers_FirstNameCmbo.Text = string.Empty;
        //                MngUsers_LastNameCmbo.Text = string.Empty;
        //                MngUsers_GroupCmbo.Text = string.Empty;
        //                MngUsers_FirstNameCmbo.Select();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Entered name already exists.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    else if (MngUsers_AdminRdo.Checked)
        //    {
        //        bool isCreatedUser = false;
        //        if (MngUsers_PasswordTxt.Text == MngUsers_ConfirmPasswordTxt.Text)
        //        {
        //            isCreatedUser = localManager.CreateUser(MngUsers_FirstNameCmbo.Text, MngUsers_LastNameCmbo.Text, MngUsers_PasswordTxt.Text, "Unknown", "RaptorMathStudents.xml");
        //            if (isCreatedUser)
        //            {
        //                MessageBox.Show("New user created.", "Raptor Math", MessageBoxButtons.OK);
        //                MngUsers_FirstNameCmbo.Text = string.Empty;
        //                MngUsers_LastNameCmbo.Text = string.Empty;
        //                MngUsers_PasswordTxt.Text = string.Empty;
        //                MngUsers_ConfirmPasswordTxt.Text = string.Empty;
        //                RefreshComboBoxes();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Entered name already exists.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                MngUsers_FirstNameCmbo.Focus();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Entered passwords do not match. Please try again.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            MngUsers_PasswordTxt.Text = string.Empty;
        //            MngUsers_ConfirmPasswordTxt.Text = string.Empty;
        //            MngUsers_PasswordTxt.Focus();
        //        }
        //    }
        //}

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/4/14                                                     //
        //------------------------------------------------------------------//
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/16/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Student' radiobutton click.</summary>
        private void MngUsers_StudentRdo_CheckedChanged(object sender, EventArgs e)
        {
            if (MngUsers_FirstNameCmbo.Text.Length > 0 && MngUsers_LastNameCmbo.Text.Length > 0)
            {
                MngUsers_SaveUserBtm.Enabled = true;
            }
            MngUsers_PasswordTxt.Enabled = false;
            MngUsers_ConfirmPasswordTxt.Enabled = false;
            MngUsers_GroupCmbo.Enabled = true;
            MngUsers_PasswordTxt.Text = string.Empty;
            MngUsers_ConfirmPasswordTxt.Text = string.Empty;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/4/14                                                     //
        //------------------------------------------------------------------//
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/16/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Admin' radiobutton click.</summary>
        private void MngUsers_AdminRdo_CheckedChanged(object sender, EventArgs e)
        {
            MngUsers_SaveUserBtm.Enabled = false;
            MngUsers_PasswordTxt.Enabled = true;
            //MngUsers_ConfirmPasswordTxt.Enabled = true;
            MngUsers_GroupCmbo.Enabled = false;
            MngUsers_GroupCmbo.Text = string.Empty;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/4/14                                                     //
        //------------------------------------------------------------------//
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/15/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Remove User' button click.</summary>
        private void MngUsers_RemoveUserBtn_Click(object sender, EventArgs e)
        {
            string userToBeRemoved = MngUsers_RemoveUserCmbo.Text;
            bool isUserRemoved = false;
            string checkForDefaultUser = string.Empty;

            if (userToBeRemoved.Length > 9)
                checkForDefaultUser = userToBeRemoved.Remove(0, 8);

            if (checkForDefaultUser.Trim() != "Default Admin")
            {
                if (MessageBox.Show("Are you sure you want to remove this user? All their data will be removed from the system.",
                    "Raptor Math", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    isUserRemoved = localManager.removeUser(userToBeRemoved);
                    if (isUserRemoved == true)
                    {
                        MessageBox.Show("The selected user has been removed", "Raptor Math", MessageBoxButtons.OK);
                        RefreshComboBoxes();
                        MngUsers_RemoveUserCmbo.Text = string.Empty;
                        MngUsers_RemoveUserCmbo.Select();
                    }
                    else
                    {
                        MessageBox.Show("The selected user does not match any known users and cannot be removed", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Cannot remove the default admin", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/4/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void MngUsers_AddUserBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MngUsers_SaveUserBtm_Click(sender, e);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/4/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void MngUsers_RemoveUserBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MngUsers_RemoveUserBtn_Click(sender, e);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/4/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle Text Change event.</summary>
        private void MngUsers_RemoveUserCmbo_TextChanged(object sender, EventArgs e)
        {
            if (MngUsers_RemoveUserCmbo.Text.Length > 0)
            {
                MngUsers_RemoveUserBtn.Enabled = true;
            }
            else
            {
                MngUsers_RemoveUserBtn.Enabled = false;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/4/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle Text Change event.</summary>
        private void MngUsers_FirstAndLastNameCmbo_TextChanged(object sender, EventArgs e)
        {
            if ((MngUsers_FirstNameCmbo.Text.Length > 0) && (MngUsers_LastNameCmbo.Text.Length > 0) &&
                (MngUsers_PasswordTxt.Text.Length >= 4) && (MngUsers_ConfirmPasswordTxt.Text.Length >= 4) &&
                MngUsers_AdminRdo.Checked)
            {
                MngUsers_SaveUserBtm.Enabled = true;
            }
            else if ((MngUsers_FirstNameCmbo.Text.Length > 0) && (MngUsers_LastNameCmbo.Text.Length > 0) &&
                MngUsers_StudentRdo.Checked)
            {
                MngUsers_SaveUserBtm.Enabled = true;
            }
            else
            {
                MngUsers_SaveUserBtm.Enabled = false;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/11/14                                                    //
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

        // TODO: Need to come up with a way to show the admin which lines in the file were not added
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/13/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Attempts to import a list of students into the sysem from a file.</summary>
        private void MngUsers_ImportBtn_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "Text Files|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Tuple<int, int, int, int> code = localManager.ImportStudents(openFile.FileName);
                if (code.Item1 == 0 && code.Item4 == 0)
                {
                    MessageBox.Show("All users in the file were added.", "Raptor Math", MessageBoxButtons.OK);
                    RefreshComboBoxes();
                }
                else if (code.Item2 == 1)
                {
                    MessageBox.Show("Unable to open the file.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (code.Item3 == 1)
                {
                    MessageBox.Show("Provided file is empty.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (code.Item4 == 1 && code.Item1 == 0)
                {
                    MessageBox.Show("Unable to add some students but some were added.", "Raptor Math", MessageBoxButtons.OK);
                    RefreshComboBoxes();
                }
                else if (code.Item4 == 1 && code.Item1 == 1)
                {
                    MessageBox.Show("Unable to add any students.", "Raptor Math", MessageBoxButtons.OK);
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/15/14                                                    //
        //------------------------------------------------------------------//
        private void MngUsers_PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (MngUsers_PasswordTxt.Text.Length >= 4)
            {
                MngUsers_ConfirmPasswordTxt.Enabled = true;
            }
            else
            {
                MngUsers_ConfirmPasswordTxt.Enabled = false;
            }

            if ((MngUsers_FirstNameCmbo.Text.Length > 0) && (MngUsers_LastNameCmbo.Text.Length > 0) &&
                (MngUsers_PasswordTxt.Text.Length >= 4) && (MngUsers_ConfirmPasswordTxt.Text.Length >= 4))
                MngUsers_SaveUserBtm.Enabled = true;
            else
                MngUsers_SaveUserBtm.Enabled = false;
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/15/14                                                    //
        //------------------------------------------------------------------//
        private void MngUsers_ConfirmPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if ((MngUsers_FirstNameCmbo.Text.Length > 0) && (MngUsers_LastNameCmbo.Text.Length > 0) &&
                (MngUsers_PasswordTxt.Text.Length >= 4) && (MngUsers_ConfirmPasswordTxt.Text.Length >= 4))
                MngUsers_SaveUserBtm.Enabled = true;
            else
                MngUsers_SaveUserBtm.Enabled = false;
        }
    }
}
