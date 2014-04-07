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
    public partial class EditStudents_Form : Form
    {
        public Manager localManager;
        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string AdminName
        {
            get { return EditStu_AdminNameLbl.Text; }
            set { EditStu_AdminNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current date.</summary>
        private void InitializeDate()
        {
            EditStu_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current time.</summary>
        private void InitializeTimer()
        {
            EditStu_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Edit Students form constructor.</summary>
        /// <param name="manager">The program management class.</param>
        public EditStudents_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();
            RefreshCmboBoxes();

            EditStu_SelectionCmbo.Select();

            this.AdminName = localManager.currentUser.Remove(0, 8);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Time display update on timer tick.</summary>
        private void EditStu_Timer_Tick(object sender, EventArgs e)
        {
            EditStu_DateLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes the content of 'Select a Student'
        /// combo box.</summary>
        private void RefreshSelectionCmboBo()
        {
            EditStu_SelectionCmbo.Items.Clear();
            foreach (Student student in localManager.studentList)
            {
                EditStu_SelectionCmbo.Items.Add(student.LoginName);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'New First Name' combo 
        /// box.</summary>
        private void RefreshNewFirstNameCmbo()
        {
            EditStu_NewFirstNameCmbo.Items.Clear();
            foreach (Student student in localManager.studentList)
            {
                EditStu_NewFirstNameCmbo.Items.Add(student.FirstName);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'New Last Name' combo box.</summary>
        private void RefreshNewLastNameCmbo()
        {
            EditStu_NewLastNameCmbo.Items.Clear();
            foreach (Student student in localManager.studentList)
            {
                EditStu_NewLastNameCmbo.Items.Add(student.LastName);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'New Group' combo box.</summary>
        private void RefreshGroupCmbo()
        {
            EditStu_GroupCmbo.Items.Clear();
            foreach (Group group in localManager.groupList)
            {
                EditStu_GroupCmbo.Items.Add(group.Name);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of all combo boxes.</summary>
        private void RefreshCmboBoxes()
        {
            RefreshSelectionCmboBo();
            RefreshNewFirstNameCmbo();
            RefreshNewLastNameCmbo();
            RefreshGroupCmbo();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Save Student' button click.</summary>
        private void EditStu_SaveStudentBtn_Click(object sender, EventArgs e)
        {
            localManager.RenameStudent(EditStu_NewFirstNameCmbo.Text, EditStu_NewLastNameCmbo.Text, EditStu_SelectionCmbo.Text, EditStu_GroupCmbo.Text, localManager.studentList, localManager.groupList);
            RefreshCmboBoxes();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Exit' button click.</summary>
        private void EditStu_ExitBtn_Click(object sender, EventArgs e)
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
        private void EditStu_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void EditStu_SettingBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EditStu_SaveStudentBtn_Click(sender, e);
            }
        }
    }
}
