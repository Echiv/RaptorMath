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

        private void RefreshStudentCmboBo()
        {
            MngDrills_StudentCmbo.Items.Clear();
            foreach (Student student in localManager.studentList)
            {
                MngDrills_StudentCmbo.Items.Add(student.LoginName);
            }
        }

        private void RefreshGroupCmbo()
        {
            MngDrills_GroupCmbo.Items.Clear();
            foreach (Group group in localManager.groupList)
            {
                MngDrills_GroupCmbo.Items.Add(group.Name);
            }
        }

        private void RefreshSelectAssignedDrillCmbo(Student student)
        {
            MngDrills_SelectDrillCmbo.Items.Clear();
            foreach (Drill drill in student.curDrillList)
            {
                MngDrills_SelectDrillCmbo.Items.Add(drill.DrillName);
            }
        }

        private void RefreshSelectUnassignedDrillCmbo()
        {
            MngDrills_SelectDrillCmbo.Items.Clear();
            foreach (Drill drill in localManager.mainDrillList)
            {
                MngDrills_SelectDrillCmbo.Items.Add(drill.DrillName);
            }
        }

        private void RefreshAssignedCmboBoxes(Student student)
        {
            RefreshStudentCmboBo();
            RefreshGroupCmbo();
            RefreshSelectAssignedDrillCmbo(student);
        }

        private void RefreshUnassignedCmboBoxes()
        {
            RefreshStudentCmboBo();
            RefreshGroupCmbo();
            RefreshSelectUnassignedDrillCmbo();
        }

        public ManageDrills_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();
            RefreshStudentCmboBo();

            this.AdminName = localManager.currentUser.Remove(0, 8);
        }

        private void MngUsers_Timer_Tick(object sender, EventArgs e)
        {
            MngDrills_DateLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void MngDrills_AddRmvDrillBtn_Click(object sender, EventArgs e)
        {
            if (MngDrills_AssignDrillRdo.Checked)
            {
                localManager.AssignDrill(MngDrills_StudentCmbo.Text, MngDrills_SelectDrillCmbo.Text);
                RefreshSelectUnassignedDrillCmbo();
            }
            else if(MngDrills_RemoveDrillRdo.Checked)
            {
                localManager.UnassignDrill(MngDrills_StudentCmbo.Text, MngDrills_SelectDrillCmbo.Text);
                RefreshSelectAssignedDrillCmbo(localManager.FindStudentWithName(MngDrills_StudentCmbo.Text));
            }
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

        private void MngDrills_AssignDrillRdo_CheckedChanged(object sender, EventArgs e)
        {
            MngDrills_AddRmvDrillBtn.Text = "Add Drill";
            MngDrills_GroupCmbo.Enabled = true;
            MngDrills_StudentCmbo.Enabled = true;
           
        }

        private void MngDrills_RemoveDrillRdo_CheckedChanged(object sender, EventArgs e)
        {
            MngDrills_AddRmvDrillBtn.Text = "Remove Drill";
            MngDrills_GroupCmbo.Enabled = true;
            MngDrills_StudentCmbo.Enabled = true;

        }

        private void MngDrills_GroupCmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MngDrills_RemoveDrillRdo.Checked)
            {
                //RefreshSelectAssignedDrillCmbo(localManager.FindStudentWithName(MngDrills_StudentCmbo.Text));
            }
            else if (MngDrills_AssignDrillRdo.Checked)
            {
                RefreshSelectUnassignedDrillCmbo();
            }
        }

        private void MngDrills_SelectDrillCmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MngDrills_SelectDrillCmbo.Text != string.Empty)
            {
                MngDrills_AddRmvDrillBtn.Enabled = true;
            }
        }

        private void MngDrills_StudentCmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MngDrills_RemoveDrillRdo.Checked) 
            {
                RefreshSelectAssignedDrillCmbo(localManager.FindStudentWithName(MngDrills_StudentCmbo.Text));
            }
            else
            {
                RefreshSelectUnassignedDrillCmbo();
            }
        }
    }
}
