//==============================================================//
//					       EditStudents.cs		                //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Cody Jordan and Cian Carota                         //
// Purpose: This form allows the user to modify the data of a   //
//            specific student.                                 //
// User:    • The user is assumed to be an admin.               //
//          • The user can select the name of a student within  //
//            the drop down list.                               //
//          • The user can edit the student's first and/or last //
//            name, and/or the student's associated group.      //
//          • The user can click the Save button to commit any  //
//            changes.                                      //
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
 * • Completely rewrote valdation checking when editing students
 * • Added in better error messages to let the user know what went wrong
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
    public partial class EditStudents_Form : Form
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
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string AdminName
        {
            get { return EditStu_AdminNameLbl.Text; }
            set { EditStu_AdminNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current date.</summary>
        private void InitializeDate()
        {
            EditStu_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current time.</summary>
        private void InitializeTimer()
        {
            EditStu_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Edit Students form constructor.</summary>
        /// <param name="manager">The program management class.</param>
        public EditStudents_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();
            RefreshCmboBoxes();

            EditStu_SelectionCmbo.Select();
            EditStu_SaveStudentBtn.Enabled = false;
            EditStu_NewFirstNameCmbo.Enabled = false;
            EditStu_NewLastNameCmbo.Enabled = false;
            EditStu_GroupCmbo.Enabled = false;

            this.EditStu_SelectionCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersWithOneWhiteSpaceKeyPress);
            this.EditStu_GroupCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsKeyPress);
            this.EditStu_NewFirstNameCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersKeyPress);
            this.EditStu_NewLastNameCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersKeyPress);

            this.AdminName = localManager.currentUser.Remove(0, 8);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Time display update on timer tick.</summary>
        private void EditStu_Timer_Tick(object sender, EventArgs e)
        {
            EditStu_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes the content of 'Select a Student'
        /// combo box.</summary>
        private void RefreshSelectionCmboBo()
        {
            EditStu_SelectionCmbo.Items.Clear();
            foreach (Student student in localManager.studentList)
            {
                EditStu_SelectionCmbo.Items.Add(student.LoginName);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'New First Name' combo 
        /// box.</summary>
        private void RefreshNewFirstNameCmbo()
        {
            EditStu_NewFirstNameCmbo.Items.Clear();
            foreach (Student student in localManager.studentList)
            {
                EditStu_NewFirstNameCmbo.Items.Add(student.FirstName);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'New Last Name' combo box.</summary>
        private void RefreshNewLastNameCmbo()
        {
            EditStu_NewLastNameCmbo.Items.Clear();
            foreach (Student student in localManager.studentList)
            {
                EditStu_NewLastNameCmbo.Items.Add(student.LastName);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'New Group' combo box.</summary>
        private void RefreshGroupCmbo()
        {
            EditStu_GroupCmbo.Items.Clear();
            foreach (Group group in localManager.groupList)
            {
                EditStu_GroupCmbo.Items.Add(group.Name);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of all combo boxes.</summary>
        private void RefreshCmboBoxes()
        {
            RefreshSelectionCmboBo();
            RefreshNewFirstNameCmbo();
            RefreshNewLastNameCmbo();
            RefreshGroupCmbo();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Clears content of all combo boxes.</summary>
        private void ClearCmboBoxes()
        {
            EditStu_SelectionCmbo.Text = string.Empty;
            EditStu_NewFirstNameCmbo.Text = string.Empty;
            EditStu_NewLastNameCmbo.Text = string.Empty;
            EditStu_GroupCmbo.Text = string.Empty;
        }

        ////------------------------------------------------------------------//
        //// Authors: Cody Jordan, Cian Carota                                //
        //// Date: 4/2/14                                                     //
        ////------------------------------------------------------------------//
        ///// <summary>Handle 'Save Student' button click.</summary>
        //private void EditStu_SaveStudentBtn_Click(object sender, EventArgs e)
        //{
        //    bool isStudentRenamed = localManager.RenameStudent(EditStu_NewFirstNameCmbo.Text, EditStu_NewLastNameCmbo.Text, EditStu_SelectionCmbo.Text, EditStu_GroupCmbo.Text, localManager.studentList, localManager.groupList);
        //    if (isStudentRenamed)
        //    {
        //        MessageBox.Show("Student changes saved", "Raptor Math", MessageBoxButtons.OK);
        //        ClearCmboBoxes();
        //        RefreshCmboBoxes();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error. Student not saved", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Save Student' button click.</summary>
        private void EditStu_SaveStudentBtn_Click(object sender, EventArgs e)
        {
            int isValidEdit = localManager.IsValidEdit(EditStu_NewFirstNameCmbo.Text, EditStu_NewLastNameCmbo.Text, EditStu_SelectionCmbo.Text, EditStu_GroupCmbo.Text, localManager.studentList, localManager.groupList);
            if (isValidEdit == 0)
            {
                localManager.EditStudent(EditStu_NewFirstNameCmbo.Text, EditStu_NewLastNameCmbo.Text, EditStu_SelectionCmbo.Text, EditStu_GroupCmbo.Text, localManager.studentList, localManager.groupList);
                MessageBox.Show("Student changes saved.", "Raptor Math", MessageBoxButtons.OK);
                ClearCmboBoxes();
                RefreshCmboBoxes();
            }
            else if (isValidEdit == 1)
            {
                MessageBox.Show("Error. Entered student doesn't exist.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EditStu_SelectionCmbo.Focus();
            }
            else if (isValidEdit == 2)
            {
                MessageBox.Show("Error. New name is not valid.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EditStu_NewFirstNameCmbo.Focus();
            }
            else if (isValidEdit == 3)
            {
                MessageBox.Show("Error. Entered group doesn't exist.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EditStu_GroupCmbo.Focus();
            }
            else if (isValidEdit == 4)
            {
                MessageBox.Show("Error. Student not saved.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Exit' button click.</summary>
        private void EditStu_ExitBtn_Click(object sender, EventArgs e)
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
        private void EditStu_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void EditStu_SettingBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EditStu_SaveStudentBtn_Click(sender, e);
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

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Enables and siables the combo boxes used to edit a student.</summary>
        private void EditStu_SelectionCmbo_TextChanged(object sender, EventArgs e)
        {
            if (EditStu_SelectionCmbo.Text.Length > 0 && (EditStu_NewFirstNameCmbo.Text.Length > 0 ||
                EditStu_NewLastNameCmbo.Text.Length > 0 || EditStu_GroupCmbo.Text.Length > 0))
            {
                EditStu_NewFirstNameCmbo.Enabled = true;
                EditStu_NewLastNameCmbo.Enabled = true;
                EditStu_GroupCmbo.Enabled = true;
                EditStu_SaveStudentBtn.Enabled = true;
            }
            else if (EditStu_SelectionCmbo.Text.Length > 0)
            {
                EditStu_NewFirstNameCmbo.Enabled = true;
                EditStu_NewLastNameCmbo.Enabled = true;
                EditStu_GroupCmbo.Enabled = true;
            }
            else
            {
                EditStu_NewFirstNameCmbo.Enabled = false;
                EditStu_NewLastNameCmbo.Enabled = false;
                EditStu_GroupCmbo.Enabled = false;
                EditStu_SaveStudentBtn.Enabled = false;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Disallows copy, paste, cut from keyboard.</summary>
        private void EditStu_NewFirstNameCmbo_TextChanged(object sender, EventArgs e)
        {
            if (EditStu_NewFirstNameCmbo.Text.Length > 0)
            {
                EditStu_SaveStudentBtn.Enabled = true;
            }
            else if (EditStu_NewLastNameCmbo.Text.Length < 1 && EditStu_GroupCmbo.Text.Length < 1)
            {
                EditStu_SaveStudentBtn.Enabled = false;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Disallows copy, paste, cut from keyboard.</summary>
        private void EditStu_NewLastNameCmbo_TextChanged(object sender, EventArgs e)
        {
            if (EditStu_NewLastNameCmbo.Text.Length > 0)
            {
                EditStu_SaveStudentBtn.Enabled = true;
            }
            else if (EditStu_NewFirstNameCmbo.Text.Length < 1 && EditStu_GroupCmbo.Text.Length < 1)
            {
                EditStu_SaveStudentBtn.Enabled = false;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Disallows copy, paste, cut from keyboard.</summary>
        private void EditStu_GroupCmbo_TextChanged(object sender, EventArgs e)
        {
            if (EditStu_GroupCmbo.Text.Length > 0)
            {
                EditStu_SaveStudentBtn.Enabled = true;
            }
            else if (EditStu_NewFirstNameCmbo.Text.Length < 1 && EditStu_NewLastNameCmbo.Text.Length < 1)
            {
                EditStu_SaveStudentBtn.Enabled = false;
            }
        }
    }
}
