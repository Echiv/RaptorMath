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
    public partial class DrillReport : Form
    {
        Manager localManager;
        public DrillReport(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            SetupLabels();
            SaveDrill();
            localManager.currentStudent.ResetCurrentDrill();
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.stuHome);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 5/01/14                                                    //
        //------------------------------------------------------------------//
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
        private void SetupLabels()
        {
            FinishBtn.NotifyDefault(false);
            NameLbl.Text = localManager.currentStudent.FirstName;
            StudentPercentageLbl.Text = localManager.CalculatePercentage();
            NumberCorrectlbl.Text = (Convert.ToInt32(localManager.currentStudent.curDrill.Questions) - Convert.ToInt32(localManager.currentStudent.curDrill.Wrong)).ToString();
            NumberIncorretLbl.Text = localManager.currentStudent.curDrill.Wrong;
            RewardsEarnedLbl.Text = (Convert.ToInt32(localManager.currentStudent.curDrill.Questions) - Convert.ToInt32(localManager.currentStudent.curDrill.Wrong)).ToString();
        }

        private void NameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
