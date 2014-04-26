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
    public partial class StudentHomepage : Form
    {
        public Manager localManager;

        public StudentHomepage(Manager manager)
        {
            InitializeComponent();
            InitializeDate();
            InitializeTimer();
            localManager = manager;
            FillDrillDdl();
            SetButtons();
            SetLabels();

            localManager.SaveLoginDate(localManager.studentXMLPath,
                localManager.currentStudent.LoginName, DateTime.Now.ToString("M/d/yyyy"));
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Controls what happens when a drill is selected.</summary>
        private void StuHome_DrillDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Drill currentDrill = localManager.currentStudent.curDrillList.Where(dri => dri.DrillName.Equals(StuHome_DrillDdl.Text)).FirstOrDefault();
            localManager.currentStudent.curDrill = currentDrill;
            StuHome_StartDrillBtn.Enabled = true;
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Returns the student to the user login window.</summary>
        private void StuHome_LogoutBtn_Click(object sender, EventArgs e)
        {
            localManager.ClearStudentUser();
            localManager.currentUser = string.Empty;
            localManager.SetWindow(Window.authUser);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Open up the drill window so the student can take the selected drill.</summary>
        private void StuHome_StartDrillBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.stuDrill);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
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
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Sets this windows buttons.</summary>
        public void SetButtons()
        {
            StuHome_StartDrillBtn.Enabled = false;
            StuHome_DrillDdl.Enabled = false;
            if (localManager.currentStudent.CurDrillList.Count > 0)
                StuHome_DrillDdl.Enabled = true;
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Sets this windows labels.</summary>
        public void SetLabels()
        {
            StuHome_StudentNameLbl.Text = localManager.currentUser;
            if (localManager.currentStudent.LastLogin == "Unknown")
                StuHome_LoginDateLbl.Text = "--/--/----";
            else
                StuHome_LoginDateLbl.Text = localManager.currentStudent.LastLogin;
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Sets today's date in the window.</summary>
        private void InitializeDate()
        {
            StuHome_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Sets the current time in the window.</summary>
        private void InitializeTimer()
        {
            StuHome_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Fills the drill selection combo box.</summary>
        private void FillDrillDdl()
        {
            foreach (Drill drill in localManager.currentStudent.curDrillList)
            {
                StuHome_DrillDdl.Items.Add(drill.DrillName);
            }
        }

        private void StudentHomepage_Load(object sender, EventArgs e)
        {

        }
    }
}
