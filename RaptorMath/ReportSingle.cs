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
    public partial class SingleReport_Form : Form
    {
        public Manager localManager;

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                   //
        //------------------------------------------------------------------//
        private void InitializeDate()
        {
            SingleReport_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        private void InitializeTimer()
        {
            SingleReport_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        public SingleReport_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();
        }

        private void MngUsers_Timer_Tick(object sender, EventArgs e)
        {
            SingleReport_DateLbl.Text = DateTime.Now.ToString("h:mm tt");
        }
    }
}
