//==============================================================//
//					     ManageGroups.cs				        //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Cody Jordan and Cian Carota                         //
// Purpose: This form allows the user to create and/or manage   //
//          groups.                                             //
// User:    • The user is assumed to be an admin.               //
//          • The user can enter a new group name.              //
//          • The user can click the Create Group button to     //
//            create the group.                                 //
//          • The user can select an existing group, and enter  //
//            a new name.                                       //
//          • The user can click the Rename Group button to     //
//            commit the change.                                //
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
 * Date: 4/14/14
 * • Added logic to disallow renaming a group to its current name.
 * • Added logic so that the porgram only allows interaction with the new name combox when there is valid group selected.
 * • Added error message boxes instead of just messages boxes.
 * • Changed it so the enter will call the correct button associated with the program's focus.
 * Date: 4/16/14
 * • Added logic to to remove leading and trailing white space from group names along with changing spaces in between
 *   words down to onlt one space if there is more than that.
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
    //------------------------------------------------------------------//
    // Authors: Cody Jordan, Cian Carota                                //
    // Date: 4/3/14                                                     //
    //------------------------------------------------------------------//
    public partial class ManageGroups_Form : Form
    {
        public Manager localManager;

        private bool isKeyPressed = false;

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
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/14/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersAndDigitsKeyPress event.</summary>
        private void RaptorMath_LettersAndDigitsEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
            if (e.KeyChar == (char)Keys.Enter)
            {
                Console.WriteLine("CLICK");
                MngGroups_RenameBtn.PerformClick();
            }
            else
            {
                e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || (char.IsControl(e.KeyChar)));
                if (e.Handled)
                    System.Media.SystemSounds.Beep.Play();
            }
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
            get { return MngGroups_AdminNameLbl.Text; }
            set { MngGroups_AdminNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'Name' combo box, 
        /// populating with group data.</summary>
        private void RefreshGroupNameCmboBox()
        {
            MngGroups_GroupNameCmbo.Items.Clear();
            MngGroups_NewNameCmbo.Items.Clear();

            foreach (Group group in localManager.groupList)
            {
                MngGroups_GroupNameCmbo.Items.Add(group.Name);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'Select a Group' combo box, 
        /// populating with group data.</summary>
        private void RefreshGroupCmboBox()
        {
            MngGroups_SelectGroupCmbo.Items.Clear();
            MngGroups_NewNameCmbo.Items.Clear();

            foreach (Group group in localManager.groupList)
            {
                MngGroups_SelectGroupCmbo.Items.Add(group.Name);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Will refresh all combo boxes.</summary>
        private void RefreshCmboBoxes()
        {
            RefreshGroupNameCmboBox();
            RefreshGroupCmboBox();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Will clear all combo boxes.</summary>
        private void ClearCmboBoxes()
        {
            MngGroups_GroupNameCmbo.Text = string.Empty;
            MngGroups_SelectGroupCmbo.Text = string.Empty;
            MngGroups_NewNameCmbo.Text = string.Empty;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current date.</summary>
        private void InitializeDate()
        {
            MngGroups_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current time.</summary>
        private void InitializeTimer()
        {
            MngGroups_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Manage Groups form constructor.</summary>
        /// <param name="manager">The program management class.</param>
        public ManageGroups_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();
            RefreshCmboBoxes();

            MngGroups_GroupNameCmbo.Select();
            MngGroups_CreateBtn.Enabled = false;
            MngGroups_RenameBtn.Enabled = false;
            MngGroups_NewNameCmbo.Enabled = false;

            this.MngGroups_SelectGroupCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsKeyPress);
            this.MngGroups_NewNameCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsEnterKeyPress);
            this.MngGroups_GroupNameCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsKeyPress);

            this.AdminName = localManager.currentUser.Remove(0, 8);
            MngGroups_NewNameCmbo.GotFocus += new EventHandler(MngGroups_NewNameCmbo_GotFocus);
            MngGroups_GroupNameCmbo.GotFocus += new EventHandler(MngGroups_GroupNameCmbo_GotFocus);
            MngGroups_SelectGroupCmbo.GotFocus += new EventHandler(MngGroups_NewNameCmbo_GotFocus);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Time display update on timer tick.</summary>
        private void MngGroups_Timer_Tick(object sender, EventArgs e)
        {
            MngGroups_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Create Group' button click.</summary>
        private void MngGroups_CreateBtn_Click(object sender, EventArgs e)
        {
            string newGroupName = localManager.RemoveExtraWhiteSpace(MngGroups_GroupNameCmbo.Text);
                if (newGroupName != string.Empty)
                {
                    bool isGroupAdded = localManager.CreateGroup(newGroupName);
                    if (isGroupAdded)
                    {
                        MessageBox.Show("New group created.", "Raptor Math", MessageBoxButtons.OK);
                        RefreshCmboBoxes();
                        ClearCmboBoxes();
                        MngGroups_GroupNameCmbo.Select();
                    }
                    else
                    {
                        MessageBox.Show("A group with the provided name already exists.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("A group name cannot be blank.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Exit' button click.</summary>
        private void MngGroups_ExitBtn_Click(object sender, EventArgs e)
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
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Close' button click.</summary>
        private void MngGroups_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/14/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Rename Group' button click.</summary>
        private void MngGroups_RenameBtn_Click(object sender, EventArgs e)
        {
            if (MngGroups_SelectGroupCmbo.Text.Trim() != "Unassigned")
            {
                if (!MngGroups_SelectGroupCmbo.Text.Equals(MngGroups_NewNameCmbo.Text))
                {
                    string newGroupName = localManager.RemoveExtraWhiteSpace(MngGroups_NewNameCmbo.Text);
                    if (newGroupName != string.Empty)
                    {
                        bool isGroupRenamed = localManager.RenameGroup(newGroupName, MngGroups_SelectGroupCmbo.Text, localManager.groupList);
                        if (isGroupRenamed)
                        {
                            MessageBox.Show("Group has been renamed.", "Raptor Math", MessageBoxButtons.OK);
                            RefreshCmboBoxes();
                            ClearCmboBoxes();
                            MngGroups_SelectGroupCmbo.Select();
                        }
                        else
                        {
                            MessageBox.Show("The entered group doesn't exist.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("A group name cannot be blank.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Cannot give a group the name it already has.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cannot rename the default group.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void MngGroups_GroupBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MngGroups_CreateBtn_Click(sender, e);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void MngGroups_ModifyBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MngGroups_RenameBtn_Click(sender, e);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle Text Changed event.</summary>
        private void MngGroups_GroupNameCmbo_TextChanged(object sender, EventArgs e)
        {
            if (MngGroups_GroupNameCmbo.Text.Length > 0)
                MngGroups_CreateBtn.Enabled = true;
            else
                MngGroups_CreateBtn.Enabled = false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/11/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle Text Changed event.</summary>
        private void MngGroups_SelectGroupAndNewNameCmbo_TextChanged(object sender, EventArgs e)
        {
            if (MngGroups_SelectGroupCmbo.Text.Length > 0)
            {
                if (localManager.FindGroupByName(MngGroups_SelectGroupCmbo.Text) != null)
                {
                    MngGroups_NewNameCmbo.Enabled = true;
                }
                else
                {
                    MngGroups_NewNameCmbo.Enabled = false;
                }
            }

            if ((MngGroups_NewNameCmbo.Text.Length > 0) && (localManager.FindGroupByName(MngGroups_SelectGroupCmbo.Text) != null))
                MngGroups_RenameBtn.Enabled = true;
            else
                MngGroups_RenameBtn.Enabled = false;
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

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/14/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Custom method to set the enter button to the "Rename" button.</summary>
        private void MngGroups_NewNameCmbo_GotFocus(Object sender, EventArgs e)
        {
            this.AcceptButton = MngGroups_RenameBtn;
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/14/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Custom method to set the enter button to the "Create Group" button.</summary>
        private void MngGroups_GroupNameCmbo_GotFocus(Object sender, EventArgs e)
        {
            this.AcceptButton = MngGroups_CreateBtn;
        }
    }
}
