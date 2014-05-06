//==============================================================//
//				      PlayDrill.cs			    	            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Created: 4/24/14                                             //
// Authors: Joshua Boone and Justine Dinh                       //
// Purpose: Class is used to provide a means for an user to     //
//          an assigned drill.                                  //
//==============================================================//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace RaptorMath
{
    //------------------------------------------------------------------//
    // Authors: Joshua Boone and Justine Dinh                           //
    // Date: 4/24/14                                                    //
    //------------------------------------------------------------------//
    public partial class PlayDrill : Form
    {
        // Local copy of the class the UI goes to for its data
        Manager localManager;

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Constructor.</summary>
        /// <param name="manager">Copy of the class the UI talks to for data.</param>
        public PlayDrill(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();
            MathDrill_InputTxt.Select();
            MathDrill_SubmitBtn.Enabled = false;

            MathDrill_InputTxt.KeyPress += new KeyPressEventHandler(PlayDrill_DigitsKeyPress);
            MathDrill_CurrentNumLbl.Text = localManager.GetCurrentNumber();
            MathDrill_StudentNameLbl.Text = localManager.currentStudent.FirstName;
            MathDrill_TotalNumberLbl.Text = localManager.GetNumQuestions().Replace("questions.", "");
            MathDrill_InputTxt.SelectionAlignment = HorizontalAlignment.Right;
            RefreshRange();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handles the skip button click.</summary>
        private void MathDrill_SkipBtn_Click(object sender, EventArgs e)
        {
            MathDrill_InputTxt.Clear();
            DisplayFeedback(Color.Blue, "Skipped!", false);
            localManager.currentStudent.curDrill.IncrementSkipped();
            localManager.currentStudent.curDrill.IncrementWrong();
            // CASE: Don't skip the last problem. If this was the last problem we will take the
            if (IsEnd() == true)
            {
                SwitchToDrillReport();
            }
            RefreshRange();
            MathDrill_CurrentNumLbl.Text = localManager.UpdateCurrentNumber();
            this.MathDrill_InputTxt.Focus();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handles the submit button click.</summary>
        private void MathDrill_SubmitBtn_Click(object sender, EventArgs e)
        {
            if (MathDrill_InputTxt.Text != string.Empty)
            {
                MathDrill_ResponseLbl.Visible = false;
                // Check to see oif the answer is correct
                if (localManager.IsCorrectAnswer(MathDrill_InputTxt.Text))
                {
                    DisplayFeedback(Color.Green, "Correct!", true);
                }
                else
                {
                    DisplayFeedback(Color.Red, "Incorrect!", false);
                }
                // Clear the input
                MathDrill_InputTxt.Clear();
                // Check to see if the drill is done
                if (IsEnd() == true)
                {
                    SwitchToDrillReport();
                }
                else
                {
                    MathDrill_CurrentNumLbl.Text = localManager.UpdateCurrentNumber();
                    RefreshRange();
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handles displaying feedback to a student's answer.</summary>
        /// <param name="color">The color to display the feedback text in.</param>
        /// <param name="response">The feedback to display.</param>
        /// <param name="correctAnswer">Whether the student was correct or not.</param>
        private void DisplayFeedback(Color color, string response, bool correctAnswer)
        {
            MathDrill_ResponseLbl.ForeColor = color;
            MathDrill_ResponseLbl.Text = response;
            MathDrill_ResponseLbl.Visible = true;
            this.MathDrill_InputTxt.Focus();
            if (correctAnswer)
            {
                PlayDrillAnswerLbl.Text = string.Empty;
            }
            else
            {
                PlayDrillAnswerLbl.Text = MathDrill_ProblemPrompt.Text + " " + localManager.currSolution.ToString();
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Returns if the student has finished their drill.</summary>
        private bool IsEnd()
        {
            string currentNum = localManager.GetCurrentNumber();
            return localManager.ReachesEnd(currentNum, MathDrill_TotalNumberLbl.Text.Trim());
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handles switching the program to display the student's mini report.</summary>
        private void SwitchToDrillReport()
        {
            MathDrill_InputTxt.Enabled = false;
            MathDrill_SkipBtn.Enabled = false;
            MathDrill_SubmitBtn.Enabled = false;
            localManager.UpdateCurrentNumber();
            MessageBox.Show("Your adventure is over! Let's see how you did!", "Raptor Math", MessageBoxButtons.OK);
            localManager.SetWindow(Window.drillReport);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handles the quit button click.</summary>
        private void MathDrill_QuitBtn_Click(object sender, EventArgs e)
        {
            localManager.ResetCurrentNumber();
            localManager.currentStudent.ResetCurrentDrill();
            localManager.SetWindow(Window.stuHome);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Refresh display of math problem.</summary>
        private void RefreshRange()
        {
            MathDrill_ProblemPrompt.Text = localManager.genMathProb();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handles the text Change event for the answer box.</summary>
        private void PlayDrill_InputTxt_TextChanged(object sender, EventArgs e)
        {
            if (MathDrill_InputTxt.Text.Length > 0)
            {
                MathDrill_SubmitBtn.Enabled = true;
                if (true)
                {
                    MathDrill_SubmitBtn.Image = Properties.Resources.greenbutton;
                }
            }
            else
            {
                MathDrill_SubmitBtn.Enabled = false;
                if (true)
                {
                    MathDrill_SubmitBtn.Image = Properties.Resources.Gray_button;
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
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
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handles DigitsKeyPress event for the answer box.</summary>
        private void PlayDrill_DigitsKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (char.IsControl(e.KeyChar)));
            if (e.Handled)
            {
                System.Media.SystemSounds.Beep.Play();
            }
        }
            
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Function to disallow closing a window with the window's 'X' button.</summary>
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
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void PlayDrill_TimeLbl_Tick(object sender, EventArgs e)
        {
            MathDrill_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }
    }
}
