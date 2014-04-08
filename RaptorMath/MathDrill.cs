﻿//==============================================================//
//					       MathDrill.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Kyle Bridges and Harvey Kreitzer                    //
// Purpose: This form handles the implementation of our         //
//          required Math Drill page. Current date and time     //
//          are initialized along with the user's name, the     //
//          range of problem numbers, and the current equation. //
//          Two random numbers are properly seeded and are used //
//          as parameters for the current problem equation.     //
//          All respective counters are incremented throughout  //
//          the program, such as numbers skipped and wrong.     //
// User:    • The user is assumed to be a student.              //
//          • The user can click the Submit button to submit    //
//            their answer. The program determines whether the  //
//            answer is invalid, correct, or incorrect and      //
//            provides the user with appropriate feedback.      //
//          • The user can click the Skip button to move on to  //
//            the next problem. As of Cycle 1, skipping the     //
//            problem counts as getting it wrong.               //
//          • The user can click the End Drill button to end    //
//            the current drill at any given time. If the user  //
//            ends the drill before completing it, the records  //
//            of the current drill are not saved.               //
// Result:  If the user successfully completes a drill, their   //
//          settings are read back  into the proper location    //
//          in their XML file. The Manager sets window to the   //
//          Student Home page and closes the current one.       //
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
    public partial class MathDrill_Form : Form
    {
        public Manager localManager;
        public string firstNum = string.Empty;
        public string secondNum = string.Empty;


        private bool isKeyPressed = false;

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle KeyUp event.</summary>
        private void RaptorMath_KeyUp(object sender, KeyEventArgs e)
        {
            isKeyPressed = false;
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
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
        // Cody Jordan, Cian Carota                                         //
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
        // Cody Jordan, Cian Carota                                         //
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
        // Cody Jordan, Cian Carota                                         //
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
        // Cody Jordan, Cian Carota                                         //
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
        // Cody Jordan, Cian Carota                                         //
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
        // Cody Jordan, Cian Carota                                         //
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
        public string StudentName
        {
            get { return MathDrill_StudentNameLbl.Text; }
            set { MathDrill_StudentNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/24/2014                                                  //
        //------------------------------------------------------------------//
        public string TotalQuestions
        {
            get { return MathDrill_TotalNumberLbl.Text; }
            set { MathDrill_TotalNumberLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/12/2014                                                  //
        //------------------------------------------------------------------//
        public MathDrill_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();

            MathDrill_InputTxt.Select();
            MathDrill_SubmitBtn.Enabled = false;
            
            this.MathDrill_InputTxt.KeyPress += new KeyPressEventHandler(RaptorMath_DigitsKeyPress);

            MathDrill_CurrentNumLbl.Text = localManager.GetCurrentNumber();
            this.StudentName = localManager.currentStudent.LoginName;

            this.TotalQuestions = localManager.GetNumQuestions().Replace("questions.", "");
            RefreshRange();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 3/2/2014                                                   //
        //------------------------------------------------------------------//
        private void InitializeDate()
        {
            MathDrill_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/12/2014                                                  //
        //------------------------------------------------------------------//
        private void InitializeTimer()
        {
            MathDrill_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/12/2014                                                  //
        //------------------------------------------------------------------//
        private void MathDrill_Timer_Tick(object sender, EventArgs e)
        {
            MathDrill_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        private void RefreshRange()
        {
            //firstNum = localManager.CreateRandom();
            //secondNum = localManager.CreateRandom();
            //MatDri_FirstNumberLbl.Text = localManager.CreateRandom();
            //MatDri_SecondNumberLbl.Text = localManager.CreateRandom();
            //            MatDri_Concat.Text = String.Concat(MatDri_FirstNumberLbl.Text, " ", localManager.GetOperand(), " ", MatDri_SecondNumberLbl.Text, " =");
            //MathDrill_ProblemPrompt.Text = String.Concat(firstNum, " ", localManager.GetOperand(), " ", secondNum, " =");
            MathDrill_ProblemPrompt.Text = localManager.genMathProb();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/12/2014                                                  //
        //------------------------------------------------------------------//
        private void MathDrill_SubmitBtn_Click(object sender, EventArgs e)
        {
            MathDrill_ResponseLbl.Visible = false;

            if (localManager.IsValidEntry(MathDrill_InputTxt.Text) == false)
            {
                MathDrill_InputTxt.Clear();
                MessageBox.Show("Please enter a number.", "Raptor Math", MessageBoxButtons.OK);
                this.MathDrill_InputTxt.Focus();
                return;
            }

            //if (localManager.IsCorrectAnswer(firstNum, secondNum, MathDrill_InputTxt.Text) == true)
            //if (localManager.IsCorrectAnswer(MatDri_FirstNumberLbl.Text, MatDri_SecondNumberLbl.Text, MatDri_InputType.Text) == true)
            if (localManager.IsCorrectAnswer(MathDrill_InputTxt.Text))
            {
                MathDrill_ResponseLbl.ForeColor = Color.Green;
                MathDrill_ResponseLbl.Text = "Correct!";
                MathDrill_ResponseLbl.Visible = true;
                this.MathDrill_InputTxt.Focus();
            }
            else
            {
                MathDrill_ResponseLbl.ForeColor = Color.Red;
                MathDrill_ResponseLbl.Text = "Incorrect.";
                MathDrill_ResponseLbl.Visible = true;
                localManager.currentStudent.curDrill.IncrementWrong();
                this.MathDrill_InputTxt.Focus();
            }

            MathDrill_InputTxt.Clear();
            string currentNum = localManager.GetCurrentNumber();

            // Check if the end of the problem set range is reached
            // NOTE: We trim the label's text because somehow a whitespace is added during
            //       the process of calling the manager functions.            
            if (localManager.ReachesEnd(currentNum, MathDrill_TotalNumberLbl.Text.Trim()) == true)
            {
                MathDrill_InputTxt.Enabled = false;
                MathDrill_SkipBtn.Enabled = false;
                MathDrill_SubmitBtn.Enabled = false;
                MessageBox.Show("All done!", "Raptor Math", MessageBoxButtons.OK);
                localManager.UpdateCurrentNumber();
            }
            else
            {
                MathDrill_CurrentNumLbl.Text = localManager.UpdateCurrentNumber();
                RefreshRange();
            }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/25/2014                                                  //
        //------------------------------------------------------------------//
        private void MathDrill_SkipBtn_Click(object sender, EventArgs e)
        {
            
            // Case: Ask if user wants to skip
            if (MessageBox.Show("Are you sure you want to skip this problem?", "Raptor Math", 
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {     
                MathDrill_InputTxt.Clear();
                localManager.currentStudent.curDrill.IncrementSkipped();
                localManager.currentStudent.curDrill.IncrementWrong();
                RefreshRange();
                // CASE: Don't skip the last problem.
                if (localManager.ReachesEnd(localManager.GetCurrentNumber(), MathDrill_TotalNumberLbl.Text.Trim()) == true)
                {
                    MathDrill_InputTxt.Enabled = false;
                    MathDrill_SkipBtn.Enabled = false;
                    MathDrill_SubmitBtn.Enabled = false;
                    MessageBox.Show("Completed! Good job!", "Raptor Math", MessageBoxButtons.OK);
                    localManager.UpdateCurrentNumber();
                    return;
                }
                
                MathDrill_CurrentNumLbl.Text = localManager.UpdateCurrentNumber();
            }
            this.MathDrill_InputTxt.Focus();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/12/2014                                                  //
        //------------------------------------------------------------------//
        private void MathDrill_EndDrillBtn_Click(object sender, EventArgs e)
        {
            if (localManager.currentProblemNumber <= Convert.ToInt32(localManager.currentStudent.curDrill.Questions))
            {
                if (MessageBox.Show("Are you sure you want to stop? You will have to start from the beginning next time.",
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    localManager.ResetCurrentNumber();
                    localManager.currentStudent.ResetCurrentDrill();
                    localManager.SetWindow(Window.stuHome); 
                    this.Close();
                }
            }
            else
            {
                // Read session into student XML file 
                localManager.SaveDrill();
                localManager.ResetCurrentNumber();
                localManager.currentStudent.ResetCurrentDrill();
                localManager.SetWindow(Window.stuHome);
                this.Close();
            }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 3/2/2014                                                  //
        //------------------------------------------------------------------//
        private void MathDrill_InputType_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the enter key is pressed, perform the same code on the click of the submit button
            if (e.KeyChar == 13)
            {
                MathDrill_SubmitBtn_Click(sender, e);
            }
        }

        private void MathDrill_InputTxt_TextChanged(object sender, EventArgs e)
        {
            if (MathDrill_InputTxt.Text.Length > 0)
                MathDrill_SubmitBtn.Enabled = true;
            else
                MathDrill_SubmitBtn.Enabled = false;
        }
    }
}
