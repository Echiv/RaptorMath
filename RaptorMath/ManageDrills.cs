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
        }

        private void MngUsers_Timer_Tick(object sender, EventArgs e)
        {
            MngDrills_DateLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void MngDrills_AddRmvDrillBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
