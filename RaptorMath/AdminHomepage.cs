﻿/* 
Authors: Joshua Boone and Justine Dinh                     
 * Date: 4/24/14
 * • Added the the whole class
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace RaptorMath
{
    //------------------------------------------------------------------//
    // Authors: Joshua Boone and Justine Dinh                           //
    // Date: 4/24/14                                                    //
    //------------------------------------------------------------------//
    public partial class AdminHomepage : Form
    {
        // The main class the the UI goes through to get information
        Manager localManager;
        // Used when importing students from a txt file
        OpenFileDialog openFile;

        public AdminHomepage(Manager manager)
        {
            InitializeComponent();
            InitializeTimer();
            InitializeDate();
            localManager = manager;
            AdminNameLbl.Text = localManager.currentAdmin.LoginName;
            LastLoginDateLbl.Text = localManager.currentAdmin.LastLogin;
            FillSingleColumnDataGrid(localManager.GetGroupNames() , GroupNameDataDisplay);
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Controls the loading of data and the disabling of buttons when switching between tabs.</summary>
        private void Tab1_Selected(Object sender, TabControlEventArgs e)
        {
            // The Statistics tab
            if (e.TabPageIndex == 0)
            {
                GroupSnapshotDataDisplay.Rows.Clear();
                FillSingleColumnDataGrid(localManager.GetGroupNames(), GroupNameDataDisplay);
            }
            // The Setup tab
            else if (e.TabPageIndex == 1)
            {
                StudentsRdo.Checked = true;
                DisableSetupButtons();
                SetupExistingUserDataDisplay.Rows.Clear();
                AvailableDrillDataDisplay.Rows.Clear();
                AssignedDrillDataDisplay.Rows.Clear();
                DisplayFoundStudents(localManager.studentList, SetupExistingUserDataDisplay);
                //SetupExistingUserDataDisplay.CurrentCell.Selected = false;
                //SetupExistingUserDataDisplay.ClearSelection();
            }
            // The Edit Users tab
            else if (e.TabPageIndex == 2)
            {
                // Refresh the group names
                RefreshComboBox(GroupNameComboBox, localManager.GetGroupNames());
                SaveChangesBtn.Enabled = false;
                RemoveUserGroupBtn.Enabled = false;
            }
            // The Add Users tab
            else if (e.TabPageIndex == 3)
            {
                // Refresh the group names
                RefreshComboBox(GroupNameCmbBox, localManager.GetGroupNames());
                // Refesh the first names
                RefreshComboBox(FirstNameCmboBox, localManager.GetUsersFirstNames());
                // Refesh the last names
                RefreshComboBox(LastNameCmboBox, localManager.GetUsersLastNames());
                SaveNewUserBtn.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /* The code in this section is for the Statistics tab only*/

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTxtBox.Text.Length > 0)
            {
                GroupNameDataDisplay.Rows.Clear();
                GroupSnapshotDataDisplay.Rows.Clear();
                List<string> matches = localManager.GetMatchingGroupNames(SearchTxtBox.Text);
                if (matches.Count > 0)
                {
                    FillSingleColumnDataGrid(matches, GroupNameDataDisplay);
                }
            }
            else
            {
                GroupNameDataDisplay.Rows.Clear();
                FillSingleColumnDataGrid(localManager.GetGroupNames(), GroupNameDataDisplay);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void GroupNameDataDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (GroupNameDataDisplay.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    GroupSnapshotDataDisplay.Rows.Clear();
                    List<Student> groupStudents = localManager.FindStudentsByGroupID(localManager.FindGroupByName(GroupNameDataDisplay.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()).ID);
                    if (groupStudents.Count > 0)
                    {
                        foreach (Student student in groupStudents)
                        {
                            DataGridViewRow newRow = (DataGridViewRow)GroupSnapshotDataDisplay.Rows[0].Clone();
                            newRow.Cells[0].Value = student.LoginName;
                            newRow.Cells[1].Value = student.curDrillList.Count;
                            newRow.Cells[2].Value = student.curRecordList.Count;
                            newRow.Cells[3].Value = localManager.GetAveragePercentStudent(student);
                            newRow.Cells[4].Value = student.LastLogin;

                            GroupSnapshotDataDisplay.Rows.Add(newRow);
                        }
                    }
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Clears the search message out of the search group box.</summary>
        private void SearchStatisticsTxtbox_Click(object sender, EventArgs e)
        {

        }

        /* The code in this section is for the Setup tab only*/

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/25/14                                                    //
        //------------------------------------------------------------------//
        private void StudentsRdo_CheckedChanged(object sender, EventArgs e)
        {
            NarrowListTxtBox.Text = string.Empty;
            SetupExistingUserDataDisplay.Columns[1].Visible = true;
            SetupExistingUserDataDisplay.Columns[0].HeaderText = "Student Name";
            SetupExistingUserDataDisplay.Rows.Clear();
            AvailableDrillDataDisplay.Rows.Clear();
            AssignedDrillDataDisplay.Rows.Clear();
            DisableSetupButtons();
            DisplayFoundStudents(localManager.studentList, SetupExistingUserDataDisplay);
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/25/14                                                    //
        //------------------------------------------------------------------//
        private void GroupsRdo_CheckedChanged(object sender, EventArgs e)
        {
            NarrowListTxtBox.Text = string.Empty;
            SetupExistingUserDataDisplay.Columns[1].Visible = false;
            SetupExistingUserDataDisplay.Columns[0].HeaderText = "Group Name";
            SetupExistingUserDataDisplay.Rows.Clear();
            AvailableDrillDataDisplay.Rows.Clear();
            AssignedDrillDataDisplay.Rows.Clear();
            DisableSetupButtons();
            DisplayFoundGroups(localManager.groupList, SetupExistingUserDataDisplay);
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/25/14                                                    //
        //------------------------------------------------------------------//
        private void NarrowListTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (StudentsRdo.Checked)
            {
                if (NarrowListTxtBox.Text.Length > 0)
                {
                    SetupExistingUserDataDisplay.Rows.Clear();
                    List<Student> matches = localManager.FindLastNameMatches(NarrowListTxtBox.Text);
                    if (matches.Count > 0)
                    {
                        DisplayFoundStudents(matches, SetupExistingUserDataDisplay);
                    }
                }
                else
                {
                    SetupExistingUserDataDisplay.Rows.Clear();
                    DisplayFoundStudents(localManager.studentList, SetupExistingUserDataDisplay);
                }
            }
            else if (GroupsRdo.Checked)
            {
                if (NarrowListTxtBox.Text.Length > 0)
                {
                    SetupExistingUserDataDisplay.Rows.Clear();
                    List<string> matches = localManager.GetMatchingGroupNames(NarrowListTxtBox.Text);
                    if (matches.Count > 0)
                    {
                        FillSingleColumnDataGrid(matches, SetupExistingUserDataDisplay);
                    }
                }
                else
                {
                    SetupExistingUserDataDisplay.Rows.Clear();
                    FillSingleColumnDataGrid(localManager.GetGroupNames(), SetupExistingUserDataDisplay);
                }
            }
            //SetupExistingUserDataDisplay.CurrentCell.Selected = false;
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/25/14                                                    //
        //------------------------------------------------------------------//
        private void NarrowListTxtBox_Click(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void SetupExistingUserDataDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (SetupExistingUserDataDisplay.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DisableSetupButtons();
                    if (StudentsRdo.Checked)
                    {
                        FillStudentDrills(e);
                    }
                    else if (GroupsRdo.Checked)
                    {
                        FillGroupDrills(e);
                    }
                    SetupDrillButtons(AvailableDrillDataDisplay, AssignedDrillDataDisplay);
                }
                else
                {
                    AvailableDrillDataDisplay.Rows.Clear();
                    AssignedDrillDataDisplay.Rows.Clear();
                    DisableSetupButtons();
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/28/14                                                    //
        //------------------------------------------------------------------//
        private void FillStudentDrills(DataGridViewCellEventArgs e)
        {
            AvailableDrillDataDisplay.Rows.Clear();
            AssignedDrillDataDisplay.Rows.Clear();
            Student selectedStudent;
            selectedStudent = localManager.FindStudentWithName(localManager.GetStudentNameFromCellFormat(SetupExistingUserDataDisplay.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
            if (selectedStudent != null)
            {
                FillAvailableDrillsStudentDataGrid(selectedStudent);
                FillAssignedDrillsDataGrid(selectedStudent.CurDrillList);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/28/14                                                    //
        //------------------------------------------------------------------//
        private void FillGroupDrills(DataGridViewCellEventArgs e)
        {
            AvailableDrillDataDisplay.Rows.Clear();
            AssignedDrillDataDisplay.Rows.Clear();
            Group selectedGroup;
            selectedGroup = localManager.FindGroupByName(SetupExistingUserDataDisplay.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            if (selectedGroup != null)
            {
                FillAvailableDrillsGroupDataGrid(selectedGroup);
                FillAssignedDrillsDataGrid(selectedGroup.groupDrillList);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/28/14                                                    //
        //------------------------------------------------------------------//
        private void FillAvailableDrillsStudentDataGrid(Student student)
        {
            foreach (Drill drill in localManager.mainDrillList)
            {
                Drill studentDrill = student.CurDrillList.Where(dri => dri.ID.ToString().Equals(drill.ID.ToString())).FirstOrDefault();
                if (studentDrill == null)
                {
                    DataGridViewRow newRow = (DataGridViewRow)AvailableDrillDataDisplay.Rows[0].Clone();
                    newRow.Cells[0].Value = drill.DrillName;
                    AvailableDrillDataDisplay.Rows.Add(newRow);
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/28/14                                                    //
        //------------------------------------------------------------------//
        private void FillAssignedDrillsDataGrid(List<Drill> currentDrills)
        {
            foreach (Drill drill in currentDrills)
            {
                DataGridViewRow newRow = (DataGridViewRow)AssignedDrillDataDisplay.Rows[0].Clone();
                newRow.Cells[0].Value = drill.DrillName;
                AssignedDrillDataDisplay.Rows.Add(newRow);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/28/14                                                    //
        //------------------------------------------------------------------//
        private void FillAvailableDrillsGroupDataGrid(Group group)
        {
            foreach (Drill drill in localManager.mainDrillList)
            {
                Drill Drill = group.groupDrillList.Where(dri => dri.ID.ToString().Equals(drill.ID.ToString())).FirstOrDefault();
                if (Drill == null)
                {
                    DataGridViewRow newRow = (DataGridViewRow)AvailableDrillDataDisplay.Rows[0].Clone();
                    newRow.Cells[0].Value = drill.DrillName;
                    AvailableDrillDataDisplay.Rows.Add(newRow);
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/28/14                                                    //
        //------------------------------------------------------------------//
        private void SetupDrillButtons(DataGridView avialable, DataGridView assigned)
        {
            if (avialable.Rows.Count < 2)
            {
                AssignSelectedBtn.Enabled = false;
                AssignAllBtn.Enabled = false;
            }
            else
            {
                AssignSelectedBtn.Enabled = true;
                AssignAllBtn.Enabled = true;
            }

            if (assigned.Rows.Count < 2)
            {
                RemoveSelectedBtn.Enabled = false;
                RemoveAllBtn.Enabled = false;
            }
            else
            {
                RemoveSelectedBtn.Enabled = true;
                RemoveAllBtn.Enabled = true;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/25/14                                                    //
        //------------------------------------------------------------------//
        private void NewDrillBtn_Click(object sender, EventArgs e)
        {
            CreateDrill_Form createDrillDialog = new CreateDrill_Form(localManager);
            createDrillDialog.ShowDialog(this);
            createDrillDialog.Dispose();

            System.Windows.Forms.DataGridViewCell selectedCell = SetupExistingUserDataDisplay.CurrentCell;
            if (selectedCell.RowIndex >= 0 && selectedCell.ColumnIndex >= 0)
            {
                if (SetupExistingUserDataDisplay.Rows[selectedCell.RowIndex].Cells[selectedCell.ColumnIndex].Value != null)
                {
                    DataGridViewCellEventArgs update = new DataGridViewCellEventArgs(selectedCell.ColumnIndex, selectedCell.RowIndex);
                    if (StudentsRdo.Checked)
                    {
                        FillStudentDrills(update);
                    }
                    else if (GroupsRdo.Checked)
                    {
                        FillGroupDrills(update);
                    }
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/25/14                                                    //
        //------------------------------------------------------------------//
        private void DeleteDrillBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewCell drillCell = AvailableDrillDataDisplay.CurrentCell;
            if (drillCell != null)
            {
                string drillName = AvailableDrillDataDisplay.Rows[drillCell.RowIndex].Cells[drillCell.ColumnIndex].Value.ToString();
                foreach (Group group in localManager.groupList)
                {
                    localManager.UnassignDrillFromGroup(group.Name, drillName);
                }
                foreach (Student student in localManager.studentList)
                {
                    localManager.UnassignDrillFromStudent(student.LoginName, drillName);
                }
                localManager.DeleteDrill(drillName);
                System.Windows.Forms.DataGridViewCell studentGroupCell = SetupExistingUserDataDisplay.CurrentCell;
                DataGridViewCellEventArgs update = new DataGridViewCellEventArgs(studentGroupCell.ColumnIndex, studentGroupCell.RowIndex);
                string studentGroupName = "";

                if (StudentsRdo.Checked)
                {
                    studentGroupName = localManager.GetStudentNameFromCellFormat(SetupExistingUserDataDisplay.Rows[studentGroupCell.RowIndex].Cells[studentGroupCell.ColumnIndex].Value.ToString());
                    FillStudentDrills(update);
                }
                else if (GroupsRdo.Checked)
                {
                    studentGroupName = SetupExistingUserDataDisplay.Rows[studentGroupCell.RowIndex].Cells[studentGroupCell.ColumnIndex].Value.ToString();
                    FillGroupDrills(update);
                }
            }
            SetupDrillButtons(AvailableDrillDataDisplay, AssignedDrillDataDisplay);
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/25/14                                                    //
        //------------------------------------------------------------------//
        private void AvailableDrillDataDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (AvailableDrillDataDisplay.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    AssignSelectedBtn.Enabled = true;
                    DeleteDrillBtn.Enabled = true;
                }
                else
                {
                    AssignSelectedBtn.Enabled = false;
                    DeleteDrillBtn.Enabled = false;
                }
            }
            else
            {
                AssignSelectedBtn.Enabled = false;
                DeleteDrillBtn.Enabled = false;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/28/14                                                    //
        //------------------------------------------------------------------//
        private void AssignedDrillDataDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (AssignedDrillDataDisplay.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    RemoveSelectedBtn.Enabled = true;
                }
                else
                {
                    RemoveSelectedBtn.Enabled = false;
                }
            }
            else
            {
                RemoveSelectedBtn.Enabled = false;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/28/14                                                    //
        //------------------------------------------------------------------//
        private void AssignSelectedBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewCell drillCell = AvailableDrillDataDisplay.CurrentCell;
            if (drillCell != null)
            {
                string drillName = AvailableDrillDataDisplay.Rows[drillCell.RowIndex].Cells[drillCell.ColumnIndex].Value.ToString();
                System.Windows.Forms.DataGridViewCell studentGroupCell = SetupExistingUserDataDisplay.CurrentCell;
                DataGridViewCellEventArgs update = new DataGridViewCellEventArgs(studentGroupCell.ColumnIndex, studentGroupCell.RowIndex);
                string studentGroupName = "";

                if (StudentsRdo.Checked)
                {
                    studentGroupName = localManager.GetStudentNameFromCellFormat(SetupExistingUserDataDisplay.Rows[studentGroupCell.RowIndex].Cells[studentGroupCell.ColumnIndex].Value.ToString());
                    localManager.AssignDrillToStudent(studentGroupName, drillName);
                    FillStudentDrills(update);
                }
                else if (GroupsRdo.Checked)
                {
                    studentGroupName = SetupExistingUserDataDisplay.Rows[studentGroupCell.RowIndex].Cells[studentGroupCell.ColumnIndex].Value.ToString();
                    localManager.AssignDrillToGroup(studentGroupName, drillName);
                    FillGroupDrills(update);
                }
            }
            SetupDrillButtons(AvailableDrillDataDisplay, AssignedDrillDataDisplay);
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/28/14                                                    //
        //------------------------------------------------------------------//
        private void RemoveSelectedBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewCell drillCell = AssignedDrillDataDisplay.CurrentCell;
            if (drillCell != null)
            {
                string drillName = AssignedDrillDataDisplay.Rows[drillCell.RowIndex].Cells[drillCell.ColumnIndex].Value.ToString();
                System.Windows.Forms.DataGridViewCell studentGroupCell = SetupExistingUserDataDisplay.CurrentCell;
                DataGridViewCellEventArgs update = new DataGridViewCellEventArgs(studentGroupCell.ColumnIndex, studentGroupCell.RowIndex);
                string studentGroupName = "";

                if (StudentsRdo.Checked)
                {
                    studentGroupName = localManager.GetStudentNameFromCellFormat(SetupExistingUserDataDisplay.Rows[studentGroupCell.RowIndex].Cells[studentGroupCell.ColumnIndex].Value.ToString());
                    localManager.UnassignDrillFromStudent(studentGroupName, drillName);
                    FillStudentDrills(update);
                }
                else if (GroupsRdo.Checked)
                {
                    studentGroupName = SetupExistingUserDataDisplay.Rows[studentGroupCell.RowIndex].Cells[studentGroupCell.ColumnIndex].Value.ToString();
                    localManager.UnassignDrillFromGroup(studentGroupName, drillName);
                    FillGroupDrills(update);
                }
            }
            SetupDrillButtons(AvailableDrillDataDisplay, AssignedDrillDataDisplay);
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/28/14                                                    //
        //------------------------------------------------------------------//
        private void AssignAllBtn_Click(object sender, EventArgs e)
        {
            List<string> drillNames = new List<string>();
            for (int iter = 0; iter < (AvailableDrillDataDisplay.Rows.Count - 1); iter++)
            {
                drillNames.Add(AvailableDrillDataDisplay.Rows[iter].Cells[0].Value.ToString());
            }

            string studentGroupName = "";
            System.Windows.Forms.DataGridViewCell studentGroupCell = SetupExistingUserDataDisplay.CurrentCell;
            DataGridViewCellEventArgs update = new DataGridViewCellEventArgs(studentGroupCell.ColumnIndex, studentGroupCell.RowIndex);
            if (StudentsRdo.Checked)
            {
                studentGroupName = localManager.GetStudentNameFromCellFormat(SetupExistingUserDataDisplay.Rows[studentGroupCell.RowIndex].Cells[studentGroupCell.ColumnIndex].Value.ToString());
                foreach (string drillName in drillNames)
                {
                    localManager.AssignDrillToStudent(studentGroupName, drillName);
                    FillStudentDrills(update);
                }
            }
            else if (GroupsRdo.Checked)
            {
                studentGroupName = SetupExistingUserDataDisplay.Rows[studentGroupCell.RowIndex].Cells[studentGroupCell.ColumnIndex].Value.ToString();
                foreach (string drillName in drillNames)
                {
                    localManager.AssignDrillToGroup(studentGroupName, drillName);
                    FillGroupDrills(update); 
                }
            }
            SetupDrillButtons(AvailableDrillDataDisplay, AssignedDrillDataDisplay);
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/28/14                                                    //
        //------------------------------------------------------------------//
        private void RemoveAllBtn_Click(object sender, EventArgs e)
        {
            List<string> drillNames = new List<string>();
            for (int iter = 0; iter < (AssignedDrillDataDisplay.Rows.Count - 1); iter++)
            {
                drillNames.Add(AssignedDrillDataDisplay.Rows[iter].Cells[0].Value.ToString());
                Debug.WriteLine(AssignedDrillDataDisplay.Rows[iter].Cells[0].Value.ToString());
            }

            string studentGroupName = "";
            System.Windows.Forms.DataGridViewCell studentGroupCell = SetupExistingUserDataDisplay.CurrentCell;
            DataGridViewCellEventArgs update = new DataGridViewCellEventArgs(studentGroupCell.ColumnIndex, studentGroupCell.RowIndex);
            if (StudentsRdo.Checked)
            {
                studentGroupName = localManager.GetStudentNameFromCellFormat(SetupExistingUserDataDisplay.Rows[studentGroupCell.RowIndex].Cells[studentGroupCell.ColumnIndex].Value.ToString());
                foreach (string drillName in drillNames)
                {
                    localManager.UnassignDrillFromStudent(studentGroupName, drillName);
                    FillStudentDrills(update);
                }
            }
            else if (GroupsRdo.Checked)
            {
                studentGroupName = SetupExistingUserDataDisplay.Rows[studentGroupCell.RowIndex].Cells[studentGroupCell.ColumnIndex].Value.ToString();
                foreach (string drillName in drillNames)
                {
                    localManager.UnassignDrillFromGroup(studentGroupName, drillName);
                    FillGroupDrills(update);
                }
            }
            SetupDrillButtons(AvailableDrillDataDisplay, AssignedDrillDataDisplay);
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/28/14                                                    //
        //------------------------------------------------------------------//
        private void DisableSetupButtons()
        {
            DeleteDrillBtn.Enabled = false;
            AssignSelectedBtn.Enabled = false;
            RemoveSelectedBtn.Enabled = false;
            AssignAllBtn.Enabled = false;
            RemoveAllBtn.Enabled = false;
        }

        /*
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         *
         * 
         * 
         * */

        /* The code in this section is for the Edit Users tab only*/

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void SearchEditUsersTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (SearchEditUsersTxtbox.Text.Length > 0)
            {
                ExistingUserDataEditUsersDisplay.Rows.Clear();
                List<Student> matches = localManager.FindLastNameMatches(SearchEditUsersTxtbox.Text);
                if (matches.Count > 0)
                {
                    DisplayFoundStudents(matches, ExistingUserDataEditUsersDisplay);
                }
            }
            else
            {
                ExistingUserDataEditUsersDisplay.Rows.Clear();
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void ExistingUserDataEditUsersDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ExistingUserDataEditUsersDisplay.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ClearModifyUserBoxes();
                    Student selectedStudent;
                    selectedStudent = localManager.FindStudentWithName(localManager.GetStudentNameFromCellFormat(ExistingUserDataEditUsersDisplay.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
                    if (selectedStudent != null)
                    {
                        GroupNameComboBox.Text = localManager.FindGroupByID(selectedStudent.GroupID).Name;
                        FirstNameTxtBox.Text = selectedStudent.FirstName;
                        LastNameTxtBox.Text = selectedStudent.LastName;
                        SaveChangesBtn.Enabled = true;
                        RemoveUserGroupBtn.Enabled = true;
                    }
                    else
                    {
                        SaveChangesBtn.Enabled = false;
                        RemoveUserGroupBtn.Enabled = false;
                    }
                }
                else
                {
                    GroupNameComboBox.Text = string.Empty;
                    FirstNameTxtBox.Text = string.Empty;
                    LastNameTxtBox.Text = string.Empty;
                    SaveChangesBtn.Enabled = false;
                    RemoveUserGroupBtn.Enabled = false;
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void DisplayFoundStudents(List<Student> matches, DataGridView dataGrid)
        {
            string fullName = "";
            foreach (Student stu in matches)
            {
                fullName = stu.LastName + ", " + stu.FirstName;
                DataGridViewRow newRow = (DataGridViewRow)dataGrid.Rows[0].Clone();
                newRow.Cells[0].Value = fullName;
                newRow.Cells[1].Value = localManager.FindGroupByID(stu.GroupID).Name;
                dataGrid.Rows.Add(newRow);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void  DisplayFoundGroups(List<Group> matches, DataGridView dataGrid)
        {
            foreach (Group group in matches)
            {
                DataGridViewRow newRow = (DataGridViewRow)dataGrid.Rows[0].Clone();
                newRow.Cells[0].Value = group.Name;
                dataGrid.Rows.Add(newRow);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void GroupNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Resets the boxes sued to modify a student.</summary>
        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = ExistingUserDataEditUsersDisplay.SelectedCells[0].RowIndex;
            DataGridViewRow row = ExistingUserDataEditUsersDisplay.Rows[selectedrowindex];

            if (row.Cells[0].Value != null)
            {
                string selectedStudent = localManager.GetStudentNameFromCellFormat(row.Cells[0].Value.ToString());
                if (selectedStudent != "Unknown Student")
                {
                    int isValidEdit = localManager.IsValidEdit(FirstNameTxtBox.Text, LastNameTxtBox.Text, selectedStudent, GroupNameComboBox.Text, localManager.studentList, localManager.groupList);
                    if (isValidEdit == 0)
                    {
                        localManager.EditStudent(FirstNameTxtBox.Text, LastNameTxtBox.Text, selectedStudent, GroupNameComboBox.Text, localManager.studentList, localManager.groupList);
                        MessageBox.Show("Student changes saved.", "Raptor Math", MessageBoxButtons.OK);
                        GroupNameComboBox.Text = string.Empty;
                        FirstNameTxtBox.Text = string.Empty;
                        LastNameTxtBox.Text = string.Empty;
                        RefreshComboBox(GroupNameComboBox, localManager.GetGroupNames());
                        RefreshDataGrid();
                    }
                    else if (isValidEdit == 1)
                    {
                        MessageBox.Show("Error. Entered student doesn't exist.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (isValidEdit == 2)
                    {
                        MessageBox.Show("Error. That student already exists.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FirstNameTxtBox.Focus();
                    }
                    else if (isValidEdit == 3)
                    {
                        MessageBox.Show("Error. Entered group doesn't exist.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EditUsersGroupBox.Focus();
                    }
                    else if (isValidEdit == 4)
                    {
                        MessageBox.Show("Error. Student already belongs to this group.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EditUsersGroupBox.Focus();
                    }
                    else if (isValidEdit == 5)
                    {
                        MessageBox.Show("Error. You must choose something to change about the student.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Remove User' button click.</summary>
        private void RemoveUserGroupBtn_Click(object sender, EventArgs e)
        {
            string userToBeRemoved = FirstNameTxtBox.Text + " " + LastNameTxtBox.Text;
            bool isUserRemoved = false;
            string checkForDefaultUser = string.Empty;

            if (userToBeRemoved.Length > 9)
                checkForDefaultUser = userToBeRemoved.Remove(0, 8);

            if (checkForDefaultUser.Trim() != "Default Admin")
            {
                if (MessageBox.Show("Are you sure you want to remove this user? All their data will be removed from the system.",
                    "Raptor Math", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    isUserRemoved = localManager.removeUser(userToBeRemoved);
                    if (isUserRemoved == true)
                    {
                        MessageBox.Show("The selected user has been removed", "Raptor Math", MessageBoxButtons.OK);
                        RefreshComboBox(GroupNameComboBox, localManager.GetGroupNames());
                        GroupNameComboBox.Text = string.Empty;
                        FirstNameTxtBox.Text = string.Empty;
                        LastNameTxtBox.Text = string.Empty;
                        RefreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("The selected user does not match any known users and cannot be removed", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Cannot remove the default admin", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void RefreshDataGrid()
        {
            ExistingUserDataEditUsersDisplay.Rows.Clear();
            List<Student> matches = localManager.FindLastNameMatches(SearchEditUsersTxtbox.Text);
            if (matches.Count > 0)
            {
                DisplayFoundStudents(matches, ExistingUserDataEditUsersDisplay);
            }
        }
        
        /* This part of the code is for the Add Users tab*/

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void SearchAddUsersTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (SearchAddUsersTxtBox.Text.Length > 0)
            {
                ExistingUserDataDisplay.Rows.Clear();
                List<Student> matches = localManager.FindLastNameMatches(SearchAddUsersTxtBox.Text);
                if (matches.Count > 0)
                {
                    DisplayFoundStudents(matches, ExistingUserDataDisplay);
                }
            }
            else
            {
                ExistingUserDataDisplay.Rows.Clear();
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void SaveNewUserBtn_Click(object sender, EventArgs e)
        {
            bool isCreatedUser = false;
            int groupID = localManager.FindGroupIDByName(GroupNameCmbBox.Text.Trim());

            if (groupID == 0)
            {
                MessageBox.Show("The group entered does not match any groups.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                isCreatedUser = localManager.CreateUser(groupID, FirstNameCmboBox.Text, LastNameCmboBox.Text, "Unknown");
                if (isCreatedUser)
                {
                    // Refresh the group names
                    RefreshComboBox(GroupNameCmbBox, localManager.GetGroupNames());
                    // Refesh the first names
                    RefreshComboBox(FirstNameCmboBox, localManager.GetUsersFirstNames());
                    // Refesh the last names
                    RefreshComboBox(LastNameCmboBox, localManager.GetUsersLastNames());
                    MessageBox.Show("New user created.", "Raptor Math", MessageBoxButtons.OK);
                    FirstNameCmboBox.Text = string.Empty;
                    LastNameCmboBox.Text = string.Empty;
                    if (!LockGroupNameCheckBox.Checked)
                    {
                        GroupNameCmbBox.Text = string.Empty;
                    }
                    FirstNameCmboBox.Select();
                }
                else
                {
                    MessageBox.Show("Entered name already exists.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Attempts to import a list of students into the system from a txt file.</summary>
        private void ImportFromTextFileBtn_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "Text Files|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Tuple<int, int, int, int> code = localManager.ImportStudents(openFile.FileName);
                if (code.Item1 == 0 && code.Item4 == 0)
                {
                    MessageBox.Show("All users in the file were added.", "Raptor Math", MessageBoxButtons.OK);
                    // Refresh the group names
                    RefreshComboBox(GroupNameCmbBox, localManager.GetGroupNames());
                    // Refesh the first names
                    RefreshComboBox(FirstNameCmboBox, localManager.GetUsersFirstNames());
                    // Refesh the last names
                    RefreshComboBox(LastNameCmboBox, localManager.GetUsersLastNames());
                }
                else if (code.Item2 == 1)
                {
                    MessageBox.Show("Unable to open the file.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (code.Item3 == 1)
                {
                    MessageBox.Show("Provided file is empty.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (code.Item4 == 1 && code.Item1 == 0)
                {
                    MessageBox.Show("Unable to add some students but some were added.", "Raptor Math", MessageBoxButtons.OK);
                    // Refresh the group names
                    RefreshComboBox(GroupNameCmbBox, localManager.GetGroupNames());
                    // Refesh the first names
                    RefreshComboBox(FirstNameCmboBox, localManager.GetUsersFirstNames());
                    // Refesh the last names
                    RefreshComboBox(LastNameCmboBox, localManager.GetUsersLastNames());
                }
                else if (code.Item4 == 1 && code.Item1 == 1)
                {
                    MessageBox.Show("Unable to add any students.", "Raptor Math", MessageBoxButtons.OK);
                }
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle Text Change event.</summary>
        private void FirstAndLastNameCmbo_TextChanged(object sender, EventArgs e)
        {
            if ((FirstNameCmboBox.Text.Length > 0) && (LastNameCmboBox.Text.Length > 0))
            {
                SaveNewUserBtn.Enabled = true;
            }
            else
            {
                SaveNewUserBtn.Enabled = false;
            }
        }

        /* This part of the code is for utility functions that anyone can use*/

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void RefreshComboBox(ComboBox box, List<string> items)
        {
            box.Items.Clear();
            foreach (String itemName in items)
            {
                box.Items.Add(itemName);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Sets today's date in the window.</summary>
        private void InitializeDate()
        {
            DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Sets the current time in the window.</summary>
        private void InitializeTimer()
        {
            TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/19/14                                                    //
        //------------------------------------------------------------------//
        private void AdminHome_Tick(object sender, EventArgs e)
        {
            TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }
        
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void FillSingleColumnDataGrid(List<string> matches, DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            foreach (String groupName in matches)
            {
                DataGridViewRow newRow = (DataGridViewRow)dataGrid.Rows[0].Clone();
                newRow.Cells[0].Value = groupName;
                dataGrid.Rows.Add(newRow);
            }
        }

        /* This section of code handles button clciks*/

        // This first part is for the two buttons that can be clicked from any any tab
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            localManager.ClearAdminUser();
            localManager.currentUser = string.Empty;
            localManager.SetWindow(Window.authUser);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit Raptor Math? Any settings changes will not be saved.",
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        /*The code below is for restricting user input and actions*/

        // The first part if for functions that affect all tabs
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Disallows closing a window with the window's 'X' button.</summary>
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Disallows copy, paste, cut from keyboard.</summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == (Keys.Control | Keys.C)) || (keyData == (Keys.Control | Keys.V)) || (keyData == (Keys.Control | Keys.X)))
            {

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        // Currently used for SearchEditUsersTxtbox, FirstNameTxtBox,       //
        // LastNameTxtBox                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersAndDigitsKeyPressNoSpace event.</summary>
        private void RaptorMath_LetterssKeyPressNoSpace(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (char.IsControl(e.KeyChar)));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        // Currently used for GroupNameComboBox                             //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersAndDigitsKeyPress event.</summary>
        private void RaptorMath_LettersAndDigitsKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || (char.IsControl(e.KeyChar)));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        /* The code in this section is for resetting text boxes and the like*/

        // This part is for the Edit Users tab
        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Resets the boxes used to modify a student.</summary>
        private void ClearModifyUserBoxes()
        {
            GroupNameComboBox.Text = string.Empty;
            FirstNameTxtBox.Text = string.Empty;
            LastNameTxtBox.Text = string.Empty;
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Clears the search message out of the search text boxes.</summary>
        private void SearchAddUsersTxtBox_Click(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Clears the search message out of the search text boxes.</summary>
        private void SearchEditUsersTxtbox_Click(object sender, EventArgs e)
        {

        }
    }
}
