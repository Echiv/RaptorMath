//==============================================================//
//					     ReportGroup.cs		       		        //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Cody Jordan and Cian Carota                         //
// Purpose: This form allows the user select the specific       //
//            student/group and date range of drill records     //
//            to view.                                          //
// User:    • The user is assumed to be an admin.               //
//          • The user must select either a student or group.   //
//          • The user must define the date range of the drill  //
//            records.                                          //
//          • The user can then click the Single or Group       //
//            button to view the report.                        //
//          • The user can click the Close button to return to  //
//            Admin home or click the Exit button to end the    //
//            program.                                          //
//==============================================================//
/* 
Authors: Joshua Boone and Justine Dinh                     
Cycle 3 Changes:
 * Date: 4/12/14
 * • Added logic to disallow interaction with a form's border close button.
 * • Added logic to disallow copy, paste, and cut.
 * • Added logic to restrict the date range the user can select from
 * • Added logic to only enable report buttons if there are records in the given date range
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
    public partial class StudentReports_Form : Form
    {
        public Manager localManager;
        private bool startDate = false;
        private bool endDate = false;
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

        public bool StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public bool EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public string AdminName
        {
            get { return ReportHome_AdminNameLbl.Text; }
            set { ReportHome_AdminNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current date.</summary>
        private void InitializeDate()
        {
            ReportHome_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current time.</summary>
        private void InitializeTimer()
        {
            ReportHome_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Student Reports form constructor.</summary>
        /// <param name="manager">The program management class.</param>
        public StudentReports_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();

            ReportHome_SingleReportBtn.Enabled = false;
            ReportHome_GroupReportBtn.Enabled = false;
            ReportHome_StudentCmbo.Select();
            ReportHome_StartDate.MaxDate = DateTime.Now;
            TimeSpan sinceMidnight = DateTime.Now - DateTime.Today;
            ReportHome_StartDate.MaxDate.Subtract(sinceMidnight);
            localManager.StartDate = DateTime.Today;
            ReportHome_EndDate.MaxDate = DateTime.Now;
            ReportHome_EndDate.MinDate = ReportHome_StartDate.Value;
            localManager.EndDate = ReportHome_EndDate.Value;

            this.ReportHome_StudentCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersKeyPress);
            this.ReportHome_GroupCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersWithOneWhiteSpaceKeyPress); 
            
            foreach (Student student in localManager.studentList)
            {
                ReportHome_StudentCmbo.Items.Add(student.LoginName);
            }

            foreach (Group group in localManager.groupList)
            {
                ReportHome_GroupCmbo.Items.Add(group.Name);
            }

            this.AdminName = localManager.currentUser.Remove(0, 8);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Time display update on timer tick.</summary>
        private void ReportHome_Timer_Tick(object sender, EventArgs e)
        {
            ReportHome_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Close' button click.</summary>
        private void ReportHome_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Exit' button click.</summary>
        private void ReportHome_ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit Raptor Math?",
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Single Report' button click.</summary>
        private void ReportHome_SingleReportBtn_Click(object sender, EventArgs e)
        {
            localManager.reportStudent = localManager.FindStudentWithName(ReportHome_StudentCmbo.Text);
            //localManager.StartDate = DateTime.Parse(ReportHome_StartDate.Text);
            //localManager.EndDate = DateTime.Parse(ReportHome_EndDate.Text);
            //TimeSpan span = localManager.EndDate - localManager.StartDate;

            //if (span.Days < 0)
            //{
            //    MessageBox.Show("Please select a valid date range.", "Raptor Math", MessageBoxButtons.OK);
            //}
            //else
            //{
                //if (localManager.reportStudent != null)
                //{
                //    if (localManager.reportStudent.curRecordList.Count > 0)
                //    {
                        localManager.SetWindow(Window.reportSingle);
                        this.Close();
                //    }
                //    else
                //    {
                //        MessageBox.Show("The entered student has no records", "Raptor Math", MessageBoxButtons.OK);
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("The entered student doesn’t exist.", "Raptor Math", MessageBoxButtons.OK);
                //}
            //}
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Group Report' button click.</summary>
        private void ReportHome_GroupReportBtn_Click(object sender, EventArgs e)
        {
            localManager.reportGroup = localManager.FindGroupByName(ReportHome_GroupCmbo.Text);
            //localManager.StartDate = DateTime.Parse(ReportHome_StartDate.Text);
            //localManager.EndDate = DateTime.Parse(ReportHome_EndDate.Text);
            //TimeSpan span = localManager.EndDate - localManager.StartDate;

            //if (span.Days < 0)
            //{
            //    MessageBox.Show("Please select a valid date range.", "Raptor Math", MessageBoxButtons.OK);
            //}
            //else
            //{
            //    if (localManager.reportGroup != null)
            //    {
                    localManager.SetWindow(Window.reportGroup);
                    this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("The entered group doesn’t exist.", "Raptor Math", MessageBoxButtons.OK);        
            //    }
            //}
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Registers 'Start Date' date box item selection.</summary>
        private void ReportHome_StartDate_ValueChanged(object sender, EventArgs e)
        {
            localManager.StartDate = DateTime.Parse(ReportHome_StartDate.Text);
            ReportHome_EndDate.MinDate = ReportHome_StartDate.Value;
            UpdateSingleReportButton();
            UpdateGroupReportButton();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Registers 'End Date' date box item selection.</summary>
        private void ReportHome_EndDate_ValueChanged(object sender, EventArgs e)
        {
            localManager.EndDate = DateTime.Parse(ReportHome_EndDate.Text);
            ReportHome_StartDate.MaxDate = ReportHome_EndDate.Value;
            UpdateSingleReportButton();
            UpdateGroupReportButton();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void ReportHome_StudentCmbo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ReportHome_SingleReportBtn_Click(sender, e);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void ReportHome_GroupCmbo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ReportHome_GroupReportBtn_Click(sender, e);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Used to enable or disable the single student report button.</summary>
        private void UpdateSingleReportButton()
        {
            List<Record> studentRecords = new List<Record>();
            if (ReportHome_StudentCmbo.Text.Length > 0)
            {
                studentRecords = localManager.GenerateRecord(localManager.StartDate, localManager.EndDate, ReportHome_StudentCmbo.Text);
            }
            if (studentRecords.Count > 0)
            {
                ReportHome_SingleReportBtn.Enabled = true;
            }
            else
            {
                ReportHome_SingleReportBtn.Enabled = false;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Used to enable or disable the group student report button.</summary>
        private void UpdateGroupReportButton()
        {
            if (ReportHome_GroupCmbo.Text.Length > 0)
            {
                localManager.reportGroup = localManager.FindGroupByName(ReportHome_GroupCmbo.Text);
                bool exists = localManager.IsRecordInRangeGroup(localManager.StartDate, localManager.EndDate, localManager.reportGroup);
                if (exists)
                {
                    ReportHome_GroupReportBtn.Enabled = true;
                }
                else
                {
                    ReportHome_GroupReportBtn.Enabled = false;
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/8/14                                                     //
        //------------------------------------------------------------------//
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle Text Change event.</summary>
        private void ReportHome_StudentCmbo_TextChanged(object sender, EventArgs e)
        {
            if(ReportHome_StudentCmbo.Text.Length > 0)
            {
                ReportHome_GroupReportBtn.Enabled = false;
                ReportHome_GroupCmbo.Text = string.Empty;
                UpdateSingleReportButton();
                //    ReportHome_SingleReportBtn.Enabled = true;
            }
            else
            {
                ReportHome_SingleReportBtn.Enabled = false;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/8/14                                                     //
        //------------------------------------------------------------------//
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle Text Change event.</summary>
        private void ReportHome_GroupCmbo_TextChanged(object sender, EventArgs e)
        {
            if (ReportHome_GroupCmbo.Text.Length > 0)
            {
                ReportHome_SingleReportBtn.Enabled = false;
                ReportHome_StudentCmbo.Text = string.Empty;
                UpdateGroupReportButton();
                //ReportHome_GroupReportBtn.Enabled = true;
            }
            else
            {
                ReportHome_GroupReportBtn.Enabled = false;
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
