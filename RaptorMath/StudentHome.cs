//==============================================================//
//					     StudentHome.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Kyle Bridges and Harvey Kreitzer                    //
// Purpose: This form handles the implementation of our         //
//          required Student Home page. Current date and time   //
//          are initialized along with the user's name, last    //
//          login date, and current number of drill questions.  //
// User:    • The user is assumed to be a student.              //
//          • The user can click the Start Drill button to      //
//            begin their next drill.                           //
//          • The user can click the Logout button to return to //
//            the User Designation page or click the Exit       //
//            button to end the program.                        //
// Result:  The Manager sets window to the Math Drill page and  //
//          closes the current one.                             //
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
    public partial class StuHome_Form : Form
    {
        public Manager localManager;

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string StudentName
        {
            get { return StuHome_StudentNameLbl.Text; }
            set { StuHome_StudentNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string LastLogin
        {
            get { return StuHome_LoginDateLbl.Text; }
            set { StuHome_LoginDateLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string Questions
        {
            get { return StuHome_TotalNumLbl.Text; }
            set { StuHome_TotalNumLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/11/2014                                                  //
        //------------------------------------------------------------------//
        public StuHome_Form(Manager manager)
        {
            localManager = manager;
            InitializeComponent();
            InitializeDate();
            InitializeTimer();
            RefreshDrillDdl();
            StuHome_StartDrillBtn.Enabled = false;
            StuHome_DrillDdl.Select();

            this.StudentName = localManager.currentUser;
            if (localManager.currentStudent.LastLogin == "Unknown")
                this.LastLogin = "--/--/----";
            else
                this.LastLogin = localManager.currentStudent.LastLogin;
            //this.Questions = localManager.GetNumQuestions();

            localManager.SaveLoginDate(localManager.studentXMLPath,
                localManager.currentStudent.LoginName, DateTime.Now.ToString("M/d/yyyy"));
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 3/2/2014                                                   //
        //------------------------------------------------------------------//
        private void InitializeDate()
        {
            StuHome_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/11/2014                                                  //
        //------------------------------------------------------------------//
        private void InitializeTimer()
        {
            StuHome_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of drill selection
        /// combo box.</summary>
        private void RefreshDrillDdl()
        {
            StuHome_DrillDdl.Items.Clear();
            foreach (Drill drill in localManager.currentStudent.curDrillList)
            {
                StuHome_DrillDdl.Items.Add(drill.DrillName);
            }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/11/2014                                                  //
        //------------------------------------------------------------------//
        private void StuHome_Timer_Tick(object sender, EventArgs e)
        {
            StuHome_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/11/2014                                                  //
        //------------------------------------------------------------------//
        private void StuHome_LogoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?",
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // Save date you want to write out into class
                localManager.ClearStudentUser();
                localManager.currentUser = string.Empty;
                localManager.SetWindow(Window.authUser);
                this.Close();
            }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/12/2014                                                  //
        //------------------------------------------------------------------//
        private void StuHome_ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit Raptor Math?",
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                localManager.ClearStudentUser();
                localManager.currentUser = string.Empty;
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/12/2014                                                  //
        //------------------------------------------------------------------//
        private void StuHome_StartDrillBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.stuDrill);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Registers combo box item selection.</summary>
        private void StuHome_DrillDdl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Drill currentDrill = localManager.currentStudent.curDrillList.Where(dri => dri.DrillName.Equals(StuHome_DrillDdl.Text)).FirstOrDefault();
            localManager.currentStudent.curDrill = currentDrill;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Enables 'Start' button.</summary>
        private void StuHome_DrillDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            StuHome_StartDrillBtn.Enabled = true;
        }
    }
}
