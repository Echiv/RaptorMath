/* 
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
            localManager = manager;
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
                // Do nothing here because current design doesn't need to load anything on entry
            }
            // The Setup tab
            else if (e.TabPageIndex == 1)
            {
                // Do nothing here because current design doesn't need to load anything on entry
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

        /* The code in this section is for the Edit Users Tab only*/
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

        ////------------------------------------------------------------------//
        //// Authors: Joshua Boone and Justine Dinh                           //
        //// Date: 4/24/14                                                    //
        ////------------------------------------------------------------------//
        //private void dataGridView_SelectionChanged(object sender, EventArgs e)
        //{
        //    ClearModifyUserBoxes();
        //    Student selectedStudent;
        //    foreach (DataGridViewRow row in ExistingUserDataEditUsersDisplay.SelectedRows)
        //    {
        //        if (row.Cells[0].Value != null)
        //        {
        //            selectedStudent = localManager.FindStudentWithName(localManager.GetStudentNameFromCellFormat(row.Cells[0].Value.ToString()));
        //            if (selectedStudent != null)
        //            {
        //                GroupNameComboBox.Text = localManager.FindGroupByID(selectedStudent.GroupID).Name;
        //                FirstNameTxtBox.Text = selectedStudent.FirstName;
        //                LastNameTxtBox.Text = selectedStudent.LastName;
        //                SaveChangesBtn.Enabled = true;
        //                RemoveUserGroupBtn.Enabled = true;
        //                break;
        //            }
        //        }
        //        else
        //        {
        //            SaveChangesBtn.Enabled = false;
        //            RemoveUserGroupBtn.Enabled = false;
        //        }
        //    }
        //}

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

        private void AdminHome_Tick(object sender, EventArgs e)
        {

        }

        // This section of code handles button clciks
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

        // The code below is for restricting user input and actions
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

        // The code in this section is for resetting text boxes and the like

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
            if (SearchAddUsersTxtBox.Text.Equals("Search"))
            {
                SearchAddUsersTxtBox.Text = string.Empty;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/24/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Clears the search message out of the search text boxes.</summary>
        private void SearchEditUsersTxtbox_Click(object sender, EventArgs e)
        {
            if (SearchEditUsersTxtbox.Text == "Search")
            {
                SearchEditUsersTxtbox.Text = string.Empty;
            }
        }
    }
}
