/* 
Authors: Joshua Boone and Justine Dinh                     
 * Date: 4/24/14
 * • Added the the whole class
*/
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
        Manager localManager;
        public PlayDrill(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();
            MathDrill_InputTxt.Select();
            MathDrill_SubmitBtn.Enabled = false;

            MathDrill_InputTxt.KeyPress += new KeyPressEventHandler(RaptorMath_DigitsKeyPress);
            MathDrill_CurrentNumLbl.Text = localManager.GetCurrentNumber();
            MathDrill_StudentNameLbl.Text = localManager.currentStudent.LoginName;
            MathDrill_TotalNumberLbl.Text = localManager.GetNumQuestions().Replace("questions.", "");
            RefreshRange();
        }

        private void MathDrill_WindowLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlayDrill_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void MathDrill_SkipBtn_Click(object sender, EventArgs e)
        {
            MathDrill_InputTxt.Clear();
            MathDrill_ResponseLbl.ForeColor = Color.Blue;
            MathDrill_ResponseLbl.Text = "Skipped!";
            MathDrill_ResponseLbl.Visible = true;
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
            this.MathDrill_InputTxt.Focus();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void MathDrill_SubmitBtn_Click(object sender, EventArgs e)
        {
            if (MathDrill_InputTxt.Text != string.Empty)
            {
                MathDrill_ResponseLbl.Visible = false;

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
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
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
        /// <summary>Handle Text Change event.</summary>
        private void PlayDrill_InputTxt_TextChanged(object sender, EventArgs e)
        {
            if (MathDrill_InputTxt.Text.Length > 0)
            {
                MathDrill_SubmitBtn.Enabled = true;
                if (true)
                {
                    MathDrill_SubmitBtn.Image = Properties.Resources.submit_green31;
                }
            }
            else
            {
                MathDrill_SubmitBtn.Enabled = false;
                if (true)
                {
                    MathDrill_SubmitBtn.Image = Properties.Resources.Submit_gray1;
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
        /// <summary>Handle DigitsKeyPress event.</summary>
        private void RaptorMath_DigitsKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MathDrill_SubmitBtn_Click(sender, e);
            }
            else
            {
                e.Handled = !(char.IsDigit(e.KeyChar) || (char.IsControl(e.KeyChar)));
                if (e.Handled)
                {
                    System.Media.SystemSounds.Beep.Play();
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void MathDrill_InputType_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the enter key is pressed, perform the same code on the click of the submit button
            if (e.KeyChar == 13)
            {
                MathDrill_SubmitBtn_Click(sender, e);
            }
        }
            

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
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
