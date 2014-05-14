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
    public partial class CreateGroup : Form
    {
        Manager localManager;

        public CreateGroup(Manager manage)
        {
            InitializeComponent();
            localManager = manage;
            CreateGroupDateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
            CreateGroupTimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 5/07/14                                                    //
        //------------------------------------------------------------------//
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 5/07/14                                                    //
        //------------------------------------------------------------------//
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string newGroupName = localManager.RemoveExtraWhiteSpace(NewGroupNameTxt.Text);
            if (newGroupName != string.Empty)
            {
                bool isGroupAdded = localManager.CreateGroup(newGroupName);
                if (isGroupAdded)
                {
                    MessageBox.Show("New group created.", "Raptor Math", MessageBoxButtons.OK);
                    NewGroupNameTxt.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("A group with the provided name already exists.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("A group name cannot be blank.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 5/07/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersAndDigitsKeyPress event.</summary>
        private void RaptorMath_LettersAndDigitsKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || (char.IsControl(e.KeyChar)));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 5/07/14                                                    //
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
        // Date: 5/07/14                                                    //
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
        // Date: 5/07/14                                                    //
        //------------------------------------------------------------------//
        private void NewGroupNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (NewGroupNameTxt.Text.Length > 0)
            {
                SaveBtn.Enabled = true;
            }
            else
            {
                SaveBtn.Enabled = false;
            }
        } 
    }
}
