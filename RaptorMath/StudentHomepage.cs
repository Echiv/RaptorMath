﻿//==============================================================//
//				      StudentHomepage.cs			    	    //
//==============================================================//
// Program Name: RaptorMath                                     //
// Created: 4/19/14                                             //
// Authors: Joshua Boone and Justine Dinh                       //
// Purpose: Class is used to provide a means for an user to     //
//          select one of their assigned drills and navigate    //
//          them to the window where they take their drill.     //
//==============================================================//

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
    //------------------------------------------------------------------//
    // Authors: Joshua Boone and Justine Dinh                           //
    // Date: 4/19/14                                                    //
    //------------------------------------------------------------------//
    public partial class StudentHomepage : Form
    {
        // Local copy of the class the UI goes to for its data
        public Manager localManager;

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Constructor.</summary>
        /// <param name="manager">Copy of the class the UI talks to for data.</param>
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
        /// <summary>Handles the event of a drill being selected.</summary>
        private void StuHome_DrillDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Drill currentDrill = localManager.currentStudent.curDrillList.Where(dri => dri.DrillName.Equals(StuHome_DrillDdl.Text)).FirstOrDefault();
            localManager.currentStudent.curDrill = currentDrill;
            StuHome_StartDrillBtn.Enabled = true;
            StuHome_StartDrillBtn.Image = Properties.Resources.go_green;
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Returns the user to the user login window.</summary>
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
            // Setting a window to have a default accept button causes a border to be placed around the oject it calls. 
            // You have to hide that border with code.
            StuHome_StartDrillBtn.NotifyDefault(false);
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
            StuHome_StudentNameLbl.Text = localManager.currentStudent.FirstName;
            eggsearnedvalue.Text = localManager.currentStudent.RewardTotal.ToString();
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

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        private void StuHome_Timer_Tick(object sender, EventArgs e)
        {
            StuHome_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }
    }
}
