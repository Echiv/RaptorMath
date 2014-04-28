//==============================================================//
//					       CreateDrill.cs				        //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Cody Jordan and Cian Carota                         //
// Purpose: This form gives the user the ability to create and  //
//          adjust drill settings.                              //
// User:    • The user is assumed to be an admin.               //
//          • The user can select the operator type, set the    //
//            number of questions, define the operand range,    //
//            and name the drill.                               //
//          • The user can then click the Save Drill button to  //
//            save the settings.                                //
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
 * • Added error message boxes instead of just messages boxes.
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
    public partial class CreateDrill_Form : Form
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
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string AdminName
        {
            get { return CreateDrill_AdminNameLbl.Text; }
            set { CreateDrill_AdminNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current date.</summary>
        private void InitializeDate()
        {
            CreateDrill_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current time.</summary>
        private void InitializeTimer()
        {
            CreateDrill_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Create Drill form constructor.</summary>
        /// <param name="manager">The program management class.</param>
        public CreateDrill_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();

            CreateDrill_AdditionRdo.Select();
            this.CreateDrill_NumQuestionsTxt.KeyPress += new KeyPressEventHandler(RaptorMath_DigitsKeyPress);
            this.CreateDrill_MinValueTxt.KeyPress += new KeyPressEventHandler(RaptorMath_DigitsKeyPress);
            this.CreateDrill_MaxValueTxt.KeyPress += new KeyPressEventHandler(RaptorMath_DigitsKeyPress);
            this.CreateDrill_DrillNameTxt.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsKeyPress);
            this.AdminName = localManager.currentUser.Remove(0, 8);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Time display update on timer tick.</summary>
        private void CreateDrill_Timer_Tick(object sender, EventArgs e)
        {
            CreateDrill_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Exit' button click.</summary>
        private void CreateDrill_ExitBtn_Click(object sender, EventArgs e)
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
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/25/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Close' button click.</summary>
        private void CreateDrill_CloseBtn_Click(object sender, EventArgs e)
        {
            //localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Save Drill' button click.</summary>
        private void CreateDrill_SaveDrillBtn_Click(object sender, EventArgs e)
        {
            // Make sure all forms and radio buttons are filled and valid
            if ((localManager.InvalidDrillFields(CreateDrill_MinValueTxt.Text, CreateDrill_MaxValueTxt.Text, CreateDrill_NumQuestionsTxt.Text))
                || (localManager.InvalidRadioButtons(CreateDrill_AdditionRdo.Checked, CreateDrill_SubtactionRdo.Checked))
                || (localManager.InvalidRange(CreateDrill_MinValueTxt.Text, CreateDrill_MaxValueTxt.Text))
                || (localManager.InvalidQuestionCount(CreateDrill_NumQuestionsTxt.Text))
                || !(CreateDrill_DrillNameTxt.Text.Trim().Length > 0))
            {
                MessageBox.Show("You are missing a selection or have entered an invalid range.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isDrillAdded = localManager.CreateDrill(CreateDrill_DrillNameTxt.Text, CreateDrill_NumQuestionsTxt.Text, CreateDrill_MinValueTxt.Text, CreateDrill_MaxValueTxt.Text,
                   CreateDrill_AdditionRdo.Checked, CreateDrill_SubtactionRdo.Checked);
                if (isDrillAdded)
                {
                    MessageBox.Show("The Drill has been succesfully saved!", "Raptor Math", MessageBoxButtons.OK);
                    CreateDrill_MinValueTxt.Text = string.Empty;
                    CreateDrill_MaxValueTxt.Text = string.Empty;
                    CreateDrill_NumQuestionsTxt.Text = string.Empty;
                    CreateDrill_DrillNameTxt.Text = string.Empty;
                }                
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/2/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void CreateDrill_CreateBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CreateDrill_SaveDrillBtn_Click(sender, e);
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
