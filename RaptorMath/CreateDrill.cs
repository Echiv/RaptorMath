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
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle KeyUp event.</summary>
        private void RaptorMath_KeyUp(object sender, KeyEventArgs e)
        {
            isKeyPressed = false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
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
        // Date:                                                   //
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
        // Date:                                                   //
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
        // Date:                                                   //
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
        // Date:                                                   //
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
        // Date:                                                   //
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
        // Date:                                                   //
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
        // Date:                                                   //
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
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Time display update on timer tick.</summary>
        private void CreateDrill_Timer_Tick(object sender, EventArgs e)
        {
            CreateDrill_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
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
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Close' button click.</summary>
        private void CreateDrill_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
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
                MessageBox.Show("You are missing a selection or have entered an invalid range.", "Raptor Math", MessageBoxButtons.OK);
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
                else
                { 
                    //gets called even when there is an empty string, need to fix
                    MessageBox.Show("A Drill with that name already exists! Please choose a different name", "Raptor Math", MessageBoxButtons.OK);
                    CreateDrill_DrillNameTxt.Text = string.Empty;
                }
                
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void CreateDrill_CreateBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CreateDrill_SaveDrillBtn_Click(sender, e);
            }
        }
    }
}
