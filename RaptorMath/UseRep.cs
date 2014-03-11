//==============================================================//
//					       UseRep.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Kyle Bridges and Harvey Kreitzer                    //
// Purpose: This form handles the implementation of our         //
//          required User Report page. Current date and time    //
//          are initialized along with the user's name and the  //
//          name of the student selected for searching.         //
// User:    • The user is assumed to be an admin.               //
//          • The user can click on either the Start Date or    //
//            End Date calendar range fields to choose what     //
//            they want the date range to be.                   //
//          • The user can click the Search button to produce   //
//            a list of drill records between the desired       //
//            calendar range as long as the range is valid      //
//            (start <= end). The records are added in rows.    //
//          • The user can click the Close button to return to  //
//            the Admin Home page.                              //
// User:    • The user is assumed to be an admin.               //
// Result:  The Manager sets window to the Admin Home page and  //
//          closes the current one.                             //
//==============================================================//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RaptorMath
{
    public partial class UseRep_Form : Form
    {
        public Manager localManager;

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string AdminName
        {
            get { return UseRep_AdminNameLbl.Text; }
            set { UseRep_AdminNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public string StudentName
        {
            get { return UseRep_StudentNameLbl.Text; }
            set { UseRep_StudentNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/14/2014                                                  //
        //------------------------------------------------------------------//
        public UseRep_Form(Manager manager)
        {
            localManager = manager;
            InitializeComponent();
            InitializeDate();
            InitializeTimer();
            this.AdminName = localManager.currentAdmin.LoginName;
            this.StudentName = localManager.currentStudent.LoginName;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 3/3/2014                                                   //
        //------------------------------------------------------------------//
        private void InitializeDate()
        {
            UseRep_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/14/2014                                                  //
        //------------------------------------------------------------------//
        private void InitializeTimer()
        {
            UseRep_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/14/2014                                                  //
        //------------------------------------------------------------------//
        private void UseRep_Timer_Tick(object sender, EventArgs e)
        {
            UseRep_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/14/2014                                                  //
        //------------------------------------------------------------------//
        private void UseRep_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/28/2014                                                  //
        //------------------------------------------------------------------//
        private void UseRep_SearchBtn_Click(object sender, EventArgs e)
        {
            // Clear old search
            UseRep_DataDisplay.Rows.Clear();

            DateTime first = DateTime.Parse(UseRep_StartDate.Text);
            DateTime second = DateTime.Parse(UseRep_EndDate.Text);
            TimeSpan span = second - first;

            if (span.Days < 0)
            {
                MessageBox.Show("Please select a valid date range.", "Raptor Math", MessageBoxButtons.OK);
                return;
            }

            UseRep_SearchBtn.Enabled = false;
            List<Record> studentRecords = localManager.GenerateRecord(first, second);

            // Search by calendar
            foreach (Record record in studentRecords)
            {

                if ((DateTime.Parse(record.DateTaken) < first) && (DateTime.Parse(record.DateTaken)) > second)
                {
                    MessageBox.Show("No records found between the selected date range.", "Raptor Math", MessageBoxButtons.OK);
                    break;
                }
                
                else
                {
                    DataGridViewRow newRow = (DataGridViewRow)UseRep_DataDisplay.Rows[0].Clone();
                    newRow.Cells[0].Value = record.DateTaken;
                    newRow.Cells[1].Value = record.Percent;
                    newRow.Cells[2].Value = record.Wrong;
                    newRow.Cells[3].Value = record.Question;
                    newRow.Cells[4].Value = record.Skipped;
                    newRow.Cells[5].Value = record.RangeStart;
                    newRow.Cells[6].Value = record.RangeEnd;
                    newRow.Cells[7].Value = record.Operation;
                    UseRep_DataDisplay.Rows.Add(newRow);
                }
            }
        }

        private void UseRep_StartDate_ValueChanged(object sender, EventArgs e)
        {
            UseRep_SearchBtn.Enabled = true;
        }

        private void UseRep_EndDate_ValueChanged(object sender, EventArgs e)
        {
            UseRep_SearchBtn.Enabled = true;
        }
    }
}
