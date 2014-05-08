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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message)
        {
            InitializeComponent();
            MessageLbl.Text = message;
            //Setup(MessageLbl.Width, MessageLbl.Height*10);
        }

        private void Setup(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        private void OkayBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
