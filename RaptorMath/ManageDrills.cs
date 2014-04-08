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

        private bool isKeyPressed = false;
        private void RaptorMath_KeyUp(object sender, KeyEventArgs e)
        {
            isKeyPressed = false;
        }

        private void RaptorMath_LettersKeyDown(object sender, KeyEventArgs e)
        {
            bool isLetter = char.IsLetter((char)e.KeyCode);
            if ((e.KeyCode != Keys.Back) && (!e.Shift) && (!isLetter))
            {
                e.SuppressKeyPress = isKeyPressed;
                isKeyPressed = true;
            }
        }

        private void RaptorMath_LettersAndDigitsKeyDown(object sender, KeyEventArgs e)
        {
            bool isLetterorDigit = char.IsLetterOrDigit((char)e.KeyCode);
            bool isSpace = char.IsWhiteSpace((char)e.KeyCode);
            if ((e.KeyCode != Keys.Back) && (!e.Shift) && (!isLetterorDigit))
            {
                e.SuppressKeyPress = isKeyPressed;
                isKeyPressed = true;
            }
        }

        private void RaptorMath_DigitsKeyDown(object sender, KeyEventArgs e)
        {
            bool isDigit = char.IsDigit((char)e.KeyCode);
            if ((e.KeyCode != Keys.Back) && (!e.Shift) && (!isDigit))
            {
                e.SuppressKeyPress = isKeyPressed;
                isKeyPressed = true;
            }
        }

        private void RaptorMath_LettersWithOneWhiteSpaceKeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox cmbobx = (ComboBox)sender;
            e.Handled = (!(char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || (!cmbobx.Text.Contains(' ')) || (char.IsControl(e.KeyChar))));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        private void RaptorMath_LettersAndDigitsKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || (char.IsControl(e.KeyChar)));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        private void RaptorMath_DigitsKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (char.IsControl(e.KeyChar)));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        private void RaptorMath_LettersKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (char.IsControl(e.KeyChar)));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }
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
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current date.</summary>
        private void InitializeDate()
        {
            MngDrills_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current time.</summary>
        private void InitializeTimer()
        {
            MngDrills_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'Stu/Grp' combo box, 
        /// populating with student data.</summary>
        private void RefreshStudentCmboBox()
        {
            MngDrills_StudentOrGroupCmbo.Items.Clear();
            foreach (Student student in localManager.studentList)
            {
                MngDrills_StudentOrGroupCmbo.Items.Add(student.LoginName);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'Stu/Grp' combo box, 
        /// populating with group data.</summary>
        private void RefreshGroupCmboBox()
        {
            MngDrills_StudentOrGroupCmbo.Items.Clear();
            foreach (Group group in localManager.groupList)
            {
                MngDrills_StudentOrGroupCmbo.Items.Add(group.Name);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears content of 'Select Drill' combo box and 
        /// repopulates with drills that can be assigned to the selected 
        /// student.</summary>
        /// <param name="student">The student to be modified</param>
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears content of 'Select Drill' combo box and 
        /// repopulates with drills that can be assigned to the selected 
        /// group.</summary>
        /// <param name="group">The group to be modified</param>
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears content of 'Select Drill' combo box and 
        /// repopulates with drills that can be unassigned from the selected 
        /// stident.</summary>
        /// <param name="student">The student to be modified</param>
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears content of 'Select Drill' combo box and 
        /// repopulates with drills that can be unassigned from the selected 
        /// group.</summary>
        /// <param name="group">The group to be modified</param>
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Will refresh 'Stu/Grp' and 'Select 
        /// Drill' combo boxes relative to intent to assign a drill to a 
        /// student.</summary>
        /// <param name="student">The student to be modified</param>
        private void RefreshAssignedStudentCmboBoxes(Student student)
        {
            RefreshStudentCmboBox();
            RefreshSelectAssignedDrillCmbo(student);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Will refresh 'Stu/Grp' and 'Select 
        /// Drill' combo boxes relative to intent to assign a drill to a 
        /// group.</summary>
        /// <param name="group">The group to be modified</param>
        private void RefreshAssignedGroupCmboBoxes(Group group)
        {
            RefreshGroupCmboBox();
            RefreshSelectAssignedDrillCmbo(group);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Will refresh 'Stu/Grp' and 'Select 
        /// Drill' combo boxes relative to intent to unassign a drill to a 
        /// student.</summary>
        /// <param name="student">The student to be modified</param>
        private void RefreshUnassignedStudentCmboBoxes(Student student)
        {
            RefreshStudentCmboBox();
            RefreshSelectUnassignedDrillCmbo(student);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Will refresh 'Stu/Grp' and 'Select 
        /// Drill' combo boxes relative to intent to unassign a drill to a 
        /// group.</summary>
        /// <param name="group">The group to be modified</param>
        private void RefreshUnassignedGroupCmboBoxes(Group group)
        {
            RefreshGroupCmboBox();
            RefreshSelectUnassignedDrillCmbo(group);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Create Drill form constructor.</summary>
        /// <param name="manager">The program management class.</param>
        public ManageDrills_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();
            RefreshStudentCmboBox();

            MngDrills_AssignDrillRdo.Select();
            MngDrills_StudentRdo.Select();

            this.MngDrills_StudentOrGroupCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsKeyPress);
            this.MngDrills_SelectDrillCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsKeyPress);
            this.AdminName = localManager.currentUser.Remove(0, 8);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Time display update on timer tick.</summary>
        private void MngDrills_Timer_Tick(object sender, EventArgs e)
        {
            MngDrills_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Add/Rmv Drill' button click.</summary>
        private void MngDrills_AddRmvDrillBtn_Click(object sender, EventArgs e)
        {
            if (MngDrills_AssignDrillRdo.Checked)
            {
                bool isAssigned = false;
                bool isStudent = false;
                // Assigning to a group
                if((MngDrills_GroupRdo.Checked) && (!MngDrills_StudentRdo.Checked))
                {
                    isAssigned = localManager.AssignDrillToGroup(MngDrills_StudentOrGroupCmbo.Text, MngDrills_SelectDrillCmbo.Text);
                    RefreshSelectUnassignedDrillCmbo(localManager.FindGroupByName(MngDrills_StudentOrGroupCmbo.Text));
                    isStudent = false;
                }
                // Assigning to a student
                else if ((MngDrills_StudentRdo.Checked) && (!MngDrills_GroupRdo.Checked))
                {
                    isAssigned = localManager.AssignDrillToStudent(MngDrills_StudentOrGroupCmbo.Text, MngDrills_SelectDrillCmbo.Text);
                    RefreshSelectUnassignedDrillCmbo(localManager.FindStudentWithName(MngDrills_StudentOrGroupCmbo.Text));
                    isStudent = true;
                }

                if((isAssigned == true) && (isStudent == true))
                {
                    MessageBox.Show("Drill has been assigned to the Student", "Raptor Math", MessageBoxButtons.OK);
                    MngDrills_SelectDrillCmbo.Text = string.Empty;
                }
                if ((isAssigned == false) && (isStudent == true))
                {
                    MessageBox.Show("Drill has not been assigned to the student", "Raptor Math", MessageBoxButtons.OK);
                }
                if ((isAssigned == true) && (isStudent == false))
                {
                    MessageBox.Show("Drill has been assigned to the Group", "Raptor Math", MessageBoxButtons.OK);
                    MngDrills_SelectDrillCmbo.Text = string.Empty;
                }
                if ((isAssigned == false) && (isStudent == false))
                {
                    MessageBox.Show("Drill has not been assigned to the Group", "Raptor Math", MessageBoxButtons.OK);
                }
            }
            else if(MngDrills_RemoveDrillRdo.Checked)
            {
                bool isUnassigned = false;
                bool isStudent = false;
                // Removing from group
                if ((MngDrills_GroupRdo.Checked) && (!MngDrills_StudentRdo.Checked))
                {
                    isUnassigned = localManager.UnassignDrillFromGroup(MngDrills_StudentOrGroupCmbo.Text, MngDrills_SelectDrillCmbo.Text);
                    RefreshSelectAssignedDrillCmbo(localManager.FindGroupByName(MngDrills_StudentOrGroupCmbo.Text));
                    isStudent = false;
                }
                // Removing from student
                if ((MngDrills_StudentRdo.Checked) && (!MngDrills_GroupRdo.Checked))
                {
                    isUnassigned = localManager.UnassignDrillFromStudent(MngDrills_StudentOrGroupCmbo.Text, MngDrills_SelectDrillCmbo.Text);
                    RefreshSelectAssignedDrillCmbo(localManager.FindStudentWithName(MngDrills_StudentOrGroupCmbo.Text));
                    isStudent = true;
                }
                if ((isUnassigned == true) && (isStudent == true))
                {
                    MessageBox.Show("Drill has been removed", "Raptor Math", MessageBoxButtons.OK);
                    MngDrills_SelectDrillCmbo.Text = string.Empty;
                }
                if ((isUnassigned == false) && (isStudent == true))
                {
                    MessageBox.Show("Drill has not been removed", "Raptor Math", MessageBoxButtons.OK);
                }
                if ((isUnassigned == true) && (isStudent == false))
                {
                    MessageBox.Show("Drill has been removed", "Raptor Math", MessageBoxButtons.OK);
                    MngDrills_SelectDrillCmbo.Text = string.Empty;
                }
                if ((isUnassigned == false) && (isStudent == false))
                {
                    MessageBox.Show("Drill has not been removed", "Raptor Math", MessageBoxButtons.OK);
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Exit' button click.</summary>
        private void MngDrills_ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit Raptor Math? Any settings changes will not be saved.", 
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Close' button click.</summary>
        private void MngDrills_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Assign' radiobutton click.</summary>
        private void MngDrills_AssignDrillRdo_CheckedChanged(object sender, EventArgs e)
        {
            RefreshAllDrillBoxesWithRdoChoices();
            MngDrills_AddRmvDrillBtn.Text = "Add Drill";
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'remove' radiobutton click.</summary>
        private void MngDrills_RemoveDrillRdo_CheckedChanged(object sender, EventArgs e)
        {
            RefreshAllDrillBoxesWithRdoChoices();
            MngDrills_AddRmvDrillBtn.Text = "Remove Drill";
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'student' radiobutton click.</summary>
        private void MngDrills_StudentRdo_CheckedChanged(object sender, EventArgs e)
        {
            MngDrills_StudentOrGroupCmbo.Text = string.Empty;
            RefreshStudentCmboBox();
            RefreshAllDrillBoxesWithRdoChoices();
            MngDrills_StudentOrGroupLbl.Text = "Student";
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'group' radiobutton click.</summary>
        private void MngDrills_GroupRdo_CheckedChanged(object sender, EventArgs e)
        {
            MngDrills_StudentOrGroupCmbo.Text = string.Empty;
            RefreshGroupCmboBox();
            RefreshAllDrillBoxesWithRdoChoices();
            MngDrills_StudentOrGroupLbl.Text = "Group";
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void MngDrills_PerformBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MngDrills_AddRmvDrillBtn_Click(sender, e);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle text change in 'Stu/Grp' combo box.</summary>
        private void MngDrills_StudentOrGroupCmbo_TextChanged(object sender, EventArgs e)
        {
            RefreshAllDrillBoxesWithRdoChoices();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Refreshes all combo boxes, which will be repopulated 
        /// relative to radiobutton selections.</summary>
        private void RefreshAllDrillBoxesWithRdoChoices()
        {
            // Assigning to student
            if ((MngDrills_AssignDrillRdo.Checked) && (MngDrills_StudentRdo.Checked))
            {
                RefreshSelectUnassignedDrillCmbo(localManager.FindStudentWithName(MngDrills_StudentOrGroupCmbo.Text));
            }
            // Assigning to group
            else if ((MngDrills_AssignDrillRdo.Checked) && (MngDrills_GroupRdo.Checked))
            {
                RefreshSelectUnassignedDrillCmbo(localManager.FindGroupByName(MngDrills_StudentOrGroupCmbo.Text));
            }
            // Removing from student
            else if ((MngDrills_RemoveDrillRdo.Checked) && (MngDrills_StudentRdo.Checked))
            {
                RefreshSelectAssignedDrillCmbo(localManager.FindStudentWithName(MngDrills_StudentOrGroupCmbo.Text));
            }
            // Removing from group
            else if ((MngDrills_RemoveDrillRdo.Checked) && (MngDrills_GroupRdo.Checked))
            {
                RefreshSelectAssignedDrillCmbo(localManager.FindGroupByName(MngDrills_StudentOrGroupCmbo.Text));
            }
        }
    }
}
