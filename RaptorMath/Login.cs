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
    public partial class Login : Form
    {
        Manager localManager;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (localManager.validateStudent() != true)
                {
                    MessageBox.Show("The name entered does not match any users.", "Raptor Math", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void loginSelectStudentName_TextChanged(object sender, EventArgs e)
        {
            localManager.currentUser = UseDesg_LoginCmbo.Text;
            if (localManager.isStudent())
            {
                UseDesg_LoginBtn.Enabled = true;
                UseDesg_passwordBox.Enabled = false;
            }
            else if (localManager.isAdmin() && localManager.currentUser.Length > 8)
            {
                UseDesg_passwordBox.Enabled = true;
            }
            else
            {
                UseDesg_LoginBtn.Enabled = false;
                UseDesg_passwordBox.Enabled = false;
            }

        }

    }
}
