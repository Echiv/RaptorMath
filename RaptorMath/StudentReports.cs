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
        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                //
        //------------------------------------------------------------------//
        public string AdminName
        {
            get { return ReportHome_AdminNameLbl.Text; }
            set { ReportHome_AdminNameLbl.Text = value; }
        }
        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                   //
        //------------------------------------------------------------------//
        private void InitializeDate()
        {
            ReportHome_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        private void InitializeTimer()
        {
            ReportHome_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        public StudentReports_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();
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

        private void MngUsers_Timer_Tick(object sender, EventArgs e)
        {
            ReportHome_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void ReportHome_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        private void ReportHome_ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit Raptor Math? Any settings changes will not be saved.",
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        private void ReportHome_SingleReportBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReportHome_StudentCmbo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                //SendKeys.Send("{button1}");
                ReportHome_SingleReportBtn.PerformClick();
            }
        }
    }
}
