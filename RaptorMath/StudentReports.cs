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
        private bool startDate = false;
        private bool endDate = false;

        public bool StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public bool EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
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

            ReportHome_SingleReportBtn.Enabled = false;
            ReportHome_GroupReportBtn.Enabled = false;
            ReportHome_StudentCmbo.Select();

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

        private void ReportHome_Timer_Tick(object sender, EventArgs e)
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
            localManager.StartDate = DateTime.Parse(ReportHome_StartDate.Text);
            localManager.EndDate = DateTime.Parse(ReportHome_EndDate.Text);
            localManager.reportStudent = ReportHome_StudentCmbo.Text;
            localManager.SetWindow(Window.reportSingle);
            this.Close();
        }

        private void ReportHome_GroupReportBtn_Click(object sender, EventArgs e)
        {
            localManager.StartDate = DateTime.Parse(ReportHome_StartDate.Text);
            localManager.EndDate = DateTime.Parse(ReportHome_EndDate.Text);
            localManager.SetWindow(Window.reportGroup);
            this.Close();
        }

        private void ReportHome_StartDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = true;
            if (startDate && endDate)
            {
                ReportHome_SingleReportBtn.Enabled = true;
                ReportHome_GroupReportBtn.Enabled = true;
            }
        }

        private void ReportHome_EndDate_ValueChanged(object sender, EventArgs e)
        {
            endDate = true;
            if (startDate && endDate)
            {
                ReportHome_SingleReportBtn.Enabled = true;
                ReportHome_GroupReportBtn.Enabled = true;
            }
        }

        private void ReportHome_StudentCmbo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ReportHome_SingleReportBtn_Click(sender, e);
            }
        }

        private void ReportHome_GroupCmbo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ReportHome_GroupReportBtn_Click(sender, e);
            }
        }
    }
}
