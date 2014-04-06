﻿using System;
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

        private void RefreshStudentCmboBox()
        {
            MngDrills_StudentOrGroupCmbo.Items.Clear();
            foreach (Student student in localManager.studentList)
            {
                MngDrills_StudentOrGroupCmbo.Items.Add(student.LoginName);
            }
        }

        private void RefreshGroupCmboBox()
        {
            MngDrills_StudentOrGroupCmbo.Items.Clear();
            foreach (Group group in localManager.groupList)
            {
                MngDrills_StudentOrGroupCmbo.Items.Add(group.Name);
            }
        }

        private void RefreshSelectAssignedDrillCmbo(Student student)
        {
            MngDrills_SelectDrillCmbo.Items.Clear();
            if (student != null)
            {
                MngDrills_StudentOrGroupCmbo.ForeColor = Color.Green;
                foreach (Drill drill in student.curDrillList)
                {
                    MngDrills_SelectDrillCmbo.Items.Add(drill.DrillName);
                }
            }
            else
            {
                MngDrills_StudentOrGroupCmbo.ForeColor = Color.Red;
            }
        }

        private void RefreshSelectAssignedDrillCmbo(Group group)
        {
            MngDrills_SelectDrillCmbo.Items.Clear();
            if (group != null)
            {
                MngDrills_StudentOrGroupCmbo.ForeColor = Color.Green;
                foreach (Drill drill in group.groupDrillList)
                {
                    MngDrills_SelectDrillCmbo.Items.Add(drill.DrillName);
                }
            }
            else
            {
                MngDrills_StudentOrGroupCmbo.ForeColor = Color.Red;
            }
        }

        private void RefreshSelectUnassignedDrillCmbo(Student student)
        {
            MngDrills_SelectDrillCmbo.Items.Clear();
            if (student != null)
            {
                MngDrills_StudentOrGroupCmbo.ForeColor = Color.Green;
                foreach (Drill drill in localManager.mainDrillList)
                {
                    Drill studentDrill = student.CurDrillList.Where(dri => dri.ID.ToString().Equals(drill.ID.ToString())).FirstOrDefault();
                    if (studentDrill == null)
                        MngDrills_SelectDrillCmbo.Items.Add(drill.DrillName);
                }
            }
            else
            {
                MngDrills_StudentOrGroupCmbo.ForeColor = Color.Red;
            }
        }

        private void RefreshSelectUnassignedDrillCmbo(Group group)
        {
            MngDrills_SelectDrillCmbo.Items.Clear();
            if (group != null)
            {
                MngDrills_StudentOrGroupCmbo.ForeColor = Color.Green;
                foreach (Drill drill in localManager.mainDrillList)
                {
                    Drill studentDrill = group.groupDrillList.Where(dri => dri.ID.ToString().Equals(drill.ID.ToString())).FirstOrDefault();
                    if (studentDrill == null)
                        MngDrills_SelectDrillCmbo.Items.Add(drill.DrillName);
                }
            }
            else
            {
                MngDrills_StudentOrGroupCmbo.ForeColor = Color.Red;
            }
        }

        private void RefreshAssignedStudentCmboBoxes(Student student)
        {
            RefreshStudentCmboBox();
            RefreshSelectAssignedDrillCmbo(student);
        }

        private void RefreshAssignedGroupCmboBoxes(Group group)
        {
            RefreshGroupCmboBox();
            RefreshSelectAssignedDrillCmbo(group);
        }

        private void RefreshUnassignedStudentCmboBoxes(Student student)
        {
            RefreshStudentCmboBox();
            RefreshSelectUnassignedDrillCmbo(student);
        }

        private void RefreshUnassignedGroupCmboBoxes(Group group)
        {
            RefreshGroupCmboBox();
            RefreshSelectUnassignedDrillCmbo(group);
        }

        public ManageDrills_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();
            RefreshStudentCmboBox();

            MngDrills_AssignDrillRdo.Select();
            MngDrills_StudentRdo.Select();
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
                bool isAssigned = false;
                bool isStudent = false;
                if((MngDrills_GroupRdo.Checked) && (!MngDrills_StudentRdo.Checked))
                {
                    isAssigned = localManager.AssignDrillToGroup(MngDrills_StudentOrGroupCmbo.Text, MngDrills_SelectDrillCmbo.Text);
                    RefreshSelectUnassignedDrillCmbo(localManager.FindGroupByName(MngDrills_StudentOrGroupCmbo.Text));
                    isStudent = false;
                }
                else if ((MngDrills_StudentRdo.Checked) && (!MngDrills_GroupRdo.Checked))
                {
                    isAssigned = localManager.AssignDrillToStudent(MngDrills_StudentOrGroupCmbo.Text, MngDrills_SelectDrillCmbo.Text);
                    RefreshSelectUnassignedDrillCmbo(localManager.FindStudentWithName(MngDrills_StudentOrGroupCmbo.Text));
                    isStudent = true;
                }
                
                if((isAssigned == true) && (isStudent == true))
                {
                    MessageBox.Show("Drill has been assigned to the Student");
                    MngDrills_SelectDrillCmbo.Text = string.Empty;
                }
                if ((isAssigned == false) && (isStudent == true))
                {
                    MessageBox.Show("Drill has not been assigned to the student");
                }
                if ((isAssigned == true) && (isStudent == false))
                { 
                    MessageBox.Show("Drill has been assigned to the Group");
                    MngDrills_SelectDrillCmbo.Text = string.Empty;
                }
                if ((isAssigned == false) && (isStudent == false))
                {
                    MessageBox.Show("Drill has not been assigned to the Group");
                }
            }
            else if(MngDrills_RemoveDrillRdo.Checked)
            {
                bool isUnassigned = false;
                bool isStudent = false;
                if ((MngDrills_GroupRdo.Checked) && (!MngDrills_StudentRdo.Checked))
                {
                    isUnassigned = localManager.UnassignDrillFromGroup(MngDrills_StudentOrGroupCmbo.Text, MngDrills_SelectDrillCmbo.Text);
                    RefreshSelectAssignedDrillCmbo(localManager.FindGroupByName(MngDrills_StudentOrGroupCmbo.Text));
                    isStudent = false;
                }
                if ((MngDrills_StudentRdo.Checked) && (!MngDrills_GroupRdo.Checked))
                {
                    isUnassigned = localManager.UnassignDrillFromStudent(MngDrills_StudentOrGroupCmbo.Text, MngDrills_SelectDrillCmbo.Text);
                    RefreshSelectAssignedDrillCmbo(localManager.FindStudentWithName(MngDrills_StudentOrGroupCmbo.Text));
                    isStudent = true;
                }
                if ((isUnassigned == true) && (isStudent == true))
                {
                    MessageBox.Show("Drill has been removed to the Student");
                    MngDrills_SelectDrillCmbo.Text = string.Empty;
                }
                if ((isUnassigned == false) && (isStudent == true))
                {
                    MessageBox.Show("Drill has not been removed to the student");
                }
                if ((isUnassigned == true) && (isStudent == false))
                {
                    MessageBox.Show("Drill has been removed to the Group");
                    MngDrills_SelectDrillCmbo.Text = string.Empty;
                }
                if ((isUnassigned == false) && (isStudent == false))
                {
                    MessageBox.Show("Drill has not been removed to the Group");
                }
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
            RefreshAllDrillBoxesWithRdoChoices();
            MngDrills_AddRmvDrillBtn.Text = "Add Drill";
        }

        private void MngDrills_RemoveDrillRdo_CheckedChanged(object sender, EventArgs e)
        {
            RefreshAllDrillBoxesWithRdoChoices();
            MngDrills_AddRmvDrillBtn.Text = "Remove Drill";
        }

        private void MngDrills_StudentRdo_CheckedChanged(object sender, EventArgs e)
        {
            MngDrills_StudentOrGroupCmbo.Text = string.Empty;
            RefreshStudentCmboBox();
            RefreshAllDrillBoxesWithRdoChoices();
            MngDrills_StudentOrGroupLbl.Text = "Student";
        }

        private void MngDrills_GroupRdo_CheckedChanged(object sender, EventArgs e)
        {
            MngDrills_StudentOrGroupCmbo.Text = string.Empty;
            RefreshGroupCmboBox();
            RefreshAllDrillBoxesWithRdoChoices();
            MngDrills_StudentOrGroupLbl.Text = "Group";
        }

        private void MngDrills_PerformBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MngDrills_AddRmvDrillBtn_Click(sender, e);
            }
        }

        private void MngDrills_StudentOrGroupCmbo_TextChanged(object sender, EventArgs e)
        {
            RefreshAllDrillBoxesWithRdoChoices();
        }

        private void RefreshAllDrillBoxesWithRdoChoices()
        {
            if ((MngDrills_AssignDrillRdo.Checked) && (MngDrills_StudentRdo.Checked))
            {
                RefreshSelectUnassignedDrillCmbo(localManager.FindStudentWithName(MngDrills_StudentOrGroupCmbo.Text));
            }
            else if ((MngDrills_AssignDrillRdo.Checked) && (MngDrills_GroupRdo.Checked))
            {
                RefreshSelectUnassignedDrillCmbo(localManager.FindGroupByName(MngDrills_StudentOrGroupCmbo.Text));
            }
            else if ((MngDrills_RemoveDrillRdo.Checked) && (MngDrills_StudentRdo.Checked))
            {
                RefreshSelectAssignedDrillCmbo(localManager.FindStudentWithName(MngDrills_StudentOrGroupCmbo.Text));
            }
            else if ((MngDrills_RemoveDrillRdo.Checked) && (MngDrills_GroupRdo.Checked))
            {
                RefreshSelectAssignedDrillCmbo(localManager.FindGroupByName(MngDrills_StudentOrGroupCmbo.Text));
            }
        }
    }
}
