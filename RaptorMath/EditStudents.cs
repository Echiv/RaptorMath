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
        // Date: 3/16/2014                                                   //
        //------------------------------------------------------------------//
        private void InitializeDate()
        {
            EditStu_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        private void InitializeTimer()
        {
            EditStu_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

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

        private void MngUsers_Timer_Tick(object sender, EventArgs e)
        {
            EditStu_DateLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void RefreshSelectionCmboBo()
        {
            EditStu_SelectionCmbo.Items.Clear();
            foreach (Student student in localManager.studentList)
            {
                EditStu_SelectionCmbo.Items.Add(student.LoginName);
            }
        }

        private void RefreshNewNameCmbo()
        {
            EditStu_NewNameCmbo.Items.Clear();
            foreach (Student student in localManager.studentList)
            {
                EditStu_NewNameCmbo.Items.Add(student.LoginName);
            }
        }

        private void RefreshGroupCmbo()
        {
            EditStu_GroupCmbo.Items.Clear();
            foreach (Group group in localManager.groupList)
            {
                EditStu_GroupCmbo.Items.Add(group.Name);
            }
        }

        private void RefreshCmboBoxes()
        {
            RefreshSelectionCmboBo();
            RefreshNewNameCmbo();
            RefreshGroupCmbo();
        }

        private void EditStu_SaveStudentBtn_Click(object sender, EventArgs e)
        {
            localManager.RenameStudent(EditStu_NewNameCmbo.Text, EditStu_SelectionCmbo.Text, EditStu_GroupCmbo.Text, localManager.studentList, localManager.groupList);
            RefreshCmboBoxes();
        }

        private void EditStu_ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit Raptor Math? Any settings changes will not be saved.",
                "Raptor Math", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                localManager.SetIsRunningFalse();
                this.Close();
            }
        }

        private void EditStu_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        private void EditStu_SettingBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EditStu_SaveStudentBtn_Click(sender, e);
            }
        }
    }
}
