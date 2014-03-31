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
    public partial class CreateDrill_Form : Form
    {
        public Manager localManager;

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string AdminName
        {
            get { return CreateDrill_AdminNameLbl.Text; }
            set { CreateDrill_AdminNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                   //
        //------------------------------------------------------------------//
        private void InitializeDate()
        {
            CreateDrill_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        private void InitializeTimer()
        {
            CreateDrill_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        public CreateDrill_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();

            this.AdminName = localManager.currentUser.Remove(0, 8);
        }

        private void CreateDrill_Timer_Tick(object sender, EventArgs e)
        {
            CreateDrill_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void CreateDrill_ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit Raptor Math? Any settings changes will not be saved.",
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        private void CreateDrill_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        private void CreateDrill_SaveDrillBtn_Click(object sender, EventArgs e)
        {
            /*// Make sure all forms and radio buttons are filled and valid
            if ((localManager.InvalidDrillFields(CreateDrill_MinValueTxt.Text, CreateDrill_MaxValueTxt.Text, CreateDrill_NumQuestionsTxt.Text))
                || (localManager.InvalidRadioButtons(CreateDrill_AdditionRdo.Checked, CreateDrill_SubtactionRdo.Checked))
                || (localManager.InvalidRange(CreateDrill_MinValueTxt.Text, CreateDrill_MaxValueTxt.Text))
                || (localManager.InvalidQuestionCount(CreateDrill_NumQuestionsTxt.Text)))
            {
                MessageBox.Show("You are missing a selection or have entered an invalid range.", "Raptor Math", MessageBoxButtons.OK);
            }
            else
            {
                localManager.SetOperand(CreateDrill_AdditionRdo.Checked, CreateDrill_SubtactionRdo.Checked);
                localManager.SaveDrillSettings(CreateDrill_MinValueTxt.Text, CreateDrill_MaxValueTxt.Text,
                   CreateDrill_NumQuestionsTxt.Text);
                MessageBox.Show("Settings succesfully saved.", "Raptor Math", MessageBoxButtons.OK);
            }*/
        }
    }
}
