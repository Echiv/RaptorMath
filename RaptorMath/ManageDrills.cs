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
    public partial class ManageDrills_Form : Form
    {
        public Manager localManager;
        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string AdminName
        {
            get { return MngDrills_AdminNameLbl.Text; }
            set { MngDrills_AdminNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                   //
        //------------------------------------------------------------------//
        private void InitializeDate()
        {
            MngDrills_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        private void InitializeTimer()
        {
            MngDrills_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        public ManageDrills_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();

            this.AdminName = localManager.currentUser.Remove(0, 8);
        }

        private void MngUsers_Timer_Tick(object sender, EventArgs e)
        {
            MngDrills_DateLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void MngDrills_AddRmvDrillBtn_Click(object sender, EventArgs e)
        {

        }

        private void MngDrills_ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit Raptor Math? Any settings changes will not be saved.", 
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        private void MngDrills_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }
    }
}
