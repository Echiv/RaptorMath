//==============================================================//
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
/*
        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string StudentName
        {
            get { return MatDri_StudentNameLbl.Text; }
            set { MatDri_StudentNameLbl.Text = value; }
        }
*/
/*
        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/24/2014                                                  //
        //------------------------------------------------------------------//
        public string TotalQuestions
        {
            get { return MatDri_TotalNumLbl.Text; }
            set { MatDri_TotalNumLbl.Text = value; }
        }
*/

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
/*
            MatDri_CurrentNumLbl.Text = localManager.GetCurrentNumber();
            this.StudentName = localManager.currentStudent.LoginName;
*/
            //this.TotalQuestions = localManager.GetNumQuestions().Replace("questions.", "");
            RefreshRange();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 3/2/2014                                                   //
        //------------------------------------------------------------------//
        private void InitializeDate()
        {
/*
            MatDri_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
*/
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/12/2014                                                  //
        //------------------------------------------------------------------//
        private void InitializeTimer()
        {
/*
            MatDri_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
*/
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/12/2014                                                  //
        //------------------------------------------------------------------//
        private void MatDri_Timer_Tick(object sender, EventArgs e)
        {
/*
            MatDri_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
*/
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        private void RefreshRange()
        {
            /*
            firstNum = localManager.CreateRandom();
            secondNum = localManager.CreateRandom();
            //MatDri_FirstNumberLbl.Text = localManager.CreateRandom();
            //MatDri_SecondNumberLbl.Text = localManager.CreateRandom();
            //            MatDri_Concat.Text = String.Concat(MatDri_FirstNumberLbl.Text, " ", localManager.GetOperand(), " ", MatDri_SecondNumberLbl.Text, " =");
            MatDri_ProblemPrompt.Text = String.Concat(firstNum, " ", localManager.GetOperand(), " ", secondNum, " =");
        */
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/12/2014                                                  //
        //------------------------------------------------------------------//
        private void MatDri_SubmitBtn_Click(object sender, EventArgs e)
        {
            /*
            MatDri_ResponseLbl.Visible = false;

            if (localManager.IsValidEntry(MatDri_InputType.Text) == false)
            {
                MatDri_InputType.Clear();
                MessageBox.Show("Please enter a number.", "Raptor Math", MessageBoxButtons.OK);
                this.MatDri_InputType.Focus();
                return;
            }

            if (localManager.IsCorrectAnswer(firstNum, secondNum, MatDri_InputType.Text) == true)
            //if (localManager.IsCorrectAnswer(MatDri_FirstNumberLbl.Text, MatDri_SecondNumberLbl.Text, MatDri_InputType.Text) == true)
            {
                MatDri_ResponseLbl.ForeColor = Color.Green;
                MatDri_ResponseLbl.Text = "Correct!";
                MatDri_ResponseLbl.Visible = true;
                this.MatDri_InputType.Focus();
            }
            else
            {
                MatDri_ResponseLbl.ForeColor = Color.Red;
                MatDri_ResponseLbl.Text = "Incorrect.";
                MatDri_ResponseLbl.Visible = true;
                localManager.currentStudent.curDrill.IncrementWrong();
                this.MatDri_InputType.Focus();
            }

            MatDri_InputType.Clear();
            string currentNum = localManager.GetCurrentNumber();

            // Check if the end of the problem set range is reached
            // NOTE: We trim the label's text because somehow a whitespace is added during
            //       the process of calling the manager functions.            
            if (localManager.ReachesEnd(currentNum, MatDri_TotalNumLbl.Text.Trim()) == true)
            {
                MatDri_InputType.Enabled = false;
                MatDri_SkipBtn.Enabled = false;
                MatDri_SubmitBtn.Enabled = false;
                MessageBox.Show("All done!", "Raptor Math", MessageBoxButtons.OK);
                localManager.UpdateCurrentNumber();
            }
            else
            {
                MatDri_CurrentNumLbl.Text = localManager.UpdateCurrentNumber();
                RefreshRange();
            }
             * */
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/25/2014                                                  //
        //------------------------------------------------------------------//
        private void MatDri_SkipBtn_Click(object sender, EventArgs e)
        {
            /*
            // Case: Ask if user wants to skip
            if (MessageBox.Show("Are you sure you want to skip this problem?", "Raptor Math", 
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {     
                MatDri_InputType.Clear();
                localManager.currentStudent.curDrill.IncrementSkipped();
                localManager.currentStudent.curDrill.IncrementWrong();
                RefreshRange();
                // CASE: Don't skip the last problem.
                if (localManager.ReachesEnd(localManager.GetCurrentNumber(), MatDri_TotalNumLbl.Text.Trim()) == true)
                {
                    MatDri_InputType.Enabled = false;
                    MatDri_SkipBtn.Enabled = false;
                    MatDri_SubmitBtn.Enabled = false;
                    MessageBox.Show("Completed! Good job!", "Raptor Math", MessageBoxButtons.OK);
                    localManager.UpdateCurrentNumber();
                    return;
                }
                
                MatDri_CurrentNumLbl.Text = localManager.UpdateCurrentNumber();
            }
            this.MatDri_InputType.Focus();
             */
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/12/2014                                                  //
        //------------------------------------------------------------------//
        private void MatDri_EndDrillBtn_Click(object sender, EventArgs e)
        {
            /*if (localManager.currentProblemNumber <= Convert.ToInt32(localManager.currentStudent.curDrill.CurQuestions))
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
            }*/
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 3/2/2014                                                  //
        //------------------------------------------------------------------//
        private void MatDri_InputType_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the enter key is pressed, perform the same code on the click of the submit button
            if (e.KeyChar == 13)
            {
                MatDri_SubmitBtn_Click(sender, e);
            }
        }
    }
}
