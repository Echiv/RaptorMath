//==============================================================//
//				      DrillReport.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Created: 5/01/14                                             //
// Authors: Joshua Boone and Justine Dinh                       //
// Purpose: Class is used to show an user their statistics for  //
//          a drill that they just completed.                   //
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
    // Date: 5/01/14                                                    //
    //------------------------------------------------------------------//
    public partial class DrillReport : Form
    {
        // Local copy of the class the UI goes to for its data
        Manager localManager;

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
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 5/01/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Constructor.</summary>
        /// <param name="manager">Copy of the class the UI talks to for data.</param>
        public DrillReport(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            SetupLabels();
            SaveDrill();
            localManager.currentStudent.ResetCurrentDrill();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 5/01/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Closes the drill report window and returns the user to the student homepage.</summary>
        private void FinishBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.stuHome);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 5/01/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Saves the user's completed drill.</summary>
        private void SaveDrill()
        {
            localManager.UpdateRewards();
            localManager.SaveDrill();
            localManager.ResetCurrentNumber();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 5/01/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Fills this window's data.</summary>
        private void SetupLabels()
        {
            // Setting a window to have a default accept button causes a border to be placed around the oject it calls. 
            // You have to hide that border with code.
            FinishBtn.NotifyDefault(false);
            NameLbl.Text = localManager.currentStudent.FirstName;
            StudentPercentageLbl.Text = localManager.CalculatePercentage();
            NumberCorrectlbl.Text = (Convert.ToInt32(localManager.currentStudent.curDrill.Questions) - Convert.ToInt32(localManager.currentStudent.curDrill.Wrong)).ToString();
            NumberIncorretLbl.Text = localManager.currentStudent.curDrill.Wrong;
            RewardsEarnedLbl.Text = (Convert.ToInt32(localManager.currentStudent.curDrill.Questions) - Convert.ToInt32(localManager.currentStudent.curDrill.Wrong)).ToString();
        }

        private void StudentPercentageLbl_Click(object sender, EventArgs e)
        {

        }

        private void NumberCorrectlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
