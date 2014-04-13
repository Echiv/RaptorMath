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
// Authors: Cody Jordan and Cian Carota                         //
// Changes:                                                     //
//          • Refactored: Accessors, constructors, click events //
//            and other functions.                              //
//          • Added support for key events.                     //
//==============================================================//
/* 
Authors: Joshua Boone and Justine Dinh                     
Cycle 3 Changes:
 * Date: 4/12/14
 * • Added logic to disallow interaction with a form's border close button.
 * • Added logic to disallow copy, paste, and cut.
*/

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
            if ((e.KeyCode != Keys.Back) && (!e.Shift) && (!isLetterorDigit) && (!isSpace))
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
            e.Handled = !(char.IsLetter(e.KeyChar) || (char.IsControl(e.KeyChar)) || (e.KeyChar == ' ') || (e.KeyChar == '<') || (e.KeyChar == '>'));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/12/2014                                                  //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>User Designation form constructor.</summary>
        /// <param name="manager">The program management class.</param>
        public UseDesg_Form(Manager manager)
        {
            localManager = manager;
            InitializeComponent();
            InitializeDate();
            InitializeTimer();
            RefreshLoginDropDownBox();
            UseDesg_LoginBtn.Enabled = false;
            UseDesg_passwordBox.Enabled = false;
            UseDesg_passwordBox.PasswordChar = '*';
            UseDesg_LoginCmbo.Select();

            this.UseDesg_LoginCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersKeyPress);
            this.UseDesg_passwordBox.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsKeyPress);
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Refresh the content of the 'Name' combobox.</summary>
        private void RefreshLoginDropDownBox()
        {
            UseDesg_LoginCmbo.Items.Clear();
            foreach (string item in localManager.GetUsers())
                UseDesg_LoginCmbo.Items.Add(item);
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
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Login' button click.</summary>
        private void UseDesg_LoginBtn_Click(object sender, EventArgs e)
        {
            localManager.currentPassword = UseDesg_passwordBox.Text;
            if(localManager.isStudent())
            {
                if (localManager.validateStudent() != true)
                {
                    MessageBox.Show("The name entered does not match any users.", "Raptor Math", MessageBoxButtons.OK);
                }
                else
                    this.Close();
            }
            else if (localManager.isAdmin())
            {
                if (localManager.validateAdmin() != true)
                {
                    MessageBox.Show("The name entered does not match any users.", "Raptor Math", MessageBoxButtons.OK);
                    UseDesg_passwordBox.Text = string.Empty;
                }
                else
                {
                    if (localManager.isCorrectAdminPassword())
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password. Try again.", "Raptor Math", MessageBoxButtons.OK);
                        UseDesg_passwordBox.Text = "";
                    }
                }
            }         
        }
      
        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/16/2014                                                  //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle Selection Change event.</summary>
        private void UseDesg_LoginDdl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            localManager.currentUser = UseDesg_LoginCmbo.Text;
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/13/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Enables 'Login' button on 'Password' textbox text 
        /// change.</summary>
        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if((localManager.currentUser != string.Empty) && (UseDesg_passwordBox.Text.Length > 0))
                UseDesg_LoginBtn.Enabled = true;
            else
                UseDesg_LoginBtn.Enabled = false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle Text Change event.</summary>
        private void UseDesg_LoginCmbo_TextChanged(object sender, EventArgs e)
        {
            localManager.currentUser = UseDesg_LoginCmbo.Text;
            if (localManager.isStudent())
            {
                UseDesg_LoginBtn.Enabled = true;
                UseDesg_passwordBox.Enabled = false;
            }
            else if (localManager.isAdmin() && localManager.currentUser.Length > 8)
            {
                UseDesg_passwordBox.Enabled = true;
            }
            else
            {
                UseDesg_LoginBtn.Enabled = false;
                UseDesg_passwordBox.Enabled = false;
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
    }
}