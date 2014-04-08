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
    public partial class ManageGroups_Form : Form
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
            get { return MngGroups_AdminNameLbl.Text; }
            set { MngGroups_AdminNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'Name' combo box, 
        /// populating with group data.</summary>
        private void RefreshGroupNameCmboBox()
        {
            MngGroups_GroupNameCmbo.Items.Clear();
            MngGroups_NewNameCmbo.Items.Clear();

            foreach (Group group in localManager.groupList)
            {
                MngGroups_GroupNameCmbo.Items.Add(group.Name);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Clears and refreshes content of 'Select a Group' combo box, 
        /// populating with group data.</summary>
        private void RefreshGroupCmboBox()
        {
            MngGroups_SelectGroupCmbo.Items.Clear();
            MngGroups_NewNameCmbo.Items.Clear();

            foreach (Group group in localManager.groupList)
            {
                MngGroups_SelectGroupCmbo.Items.Add(group.Name);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Will refresh all combo boxes.</summary>
        private void RefreshCmboBoxes()
        {
            RefreshGroupNameCmboBox();
            RefreshGroupCmboBox();

        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Will clear all combo boxes.</summary>
        private void ClearCmboBoxes()
        {
            MngGroups_GroupNameCmbo.Text = string.Empty;
            MngGroups_SelectGroupCmbo.Text = string.Empty;
            MngGroups_NewNameCmbo.Text = string.Empty;
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current date.</summary>
        private void InitializeDate()
        {
            MngGroups_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current time.</summary>
        private void InitializeTimer()
        {
            MngGroups_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Manage Groups form constructor.</summary>
        /// <param name="manager">The program management class.</param>
        public ManageGroups_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();
            RefreshCmboBoxes();

            MngGroups_GroupNameCmbo.Select();
            this.MngGroups_SelectGroupCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsKeyPress);
            this.MngGroups_NewNameCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsKeyPress);
            this.MngGroups_GroupNameCmbo.KeyPress += new KeyPressEventHandler(RaptorMath_LettersAndDigitsKeyPress);

            this.AdminName = localManager.currentUser.Remove(0, 8);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Time display update on timer tick.</summary>
        private void MngGroups_Timer_Tick(object sender, EventArgs e)
        {
            MngGroups_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Create Group' button click.</summary>
        private void MngGroups_CreateBtn_Click(object sender, EventArgs e)
        {
            string newGroupName = MngGroups_GroupNameCmbo.Text;
            localManager.CreateGroup(newGroupName);
            RefreshCmboBoxes();
            ClearCmboBoxes();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Exit' button click.</summary>
        private void MngGroups_ExitBtn_Click(object sender, EventArgs e)
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
        private void MngGroups_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Rename Group' button click.</summary>
        private void MngGroups_RenameBtn_Click(object sender, EventArgs e)
        {
            localManager.RenameGroup(MngGroups_NewNameCmbo.Text, MngGroups_SelectGroupCmbo.Text, localManager.groupList);
            RefreshCmboBoxes();
            ClearCmboBoxes();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void MngGroups_GroupBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MngGroups_CreateBtn_Click(sender, e);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Enter-key' press.</summary>
        private void MngGroups_ModifyBoxTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MngGroups_RenameBtn_Click(sender, e);
            }
        }
    }
}
