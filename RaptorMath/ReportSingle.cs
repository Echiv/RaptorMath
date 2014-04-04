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
    public partial class SingleReport_Form : Form
    {
        public Manager localManager;

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                   //
        //------------------------------------------------------------------//
        private void InitializeDate()
        {
            SingleReport_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        private void InitializeTimer()
        {
            SingleReport_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        public string StudentName
        {
            get { return SingleReport__StudentNameLbl.Text; }
            set { SingleReport__StudentNameLbl.Text = value; }
        }

        public SingleReport_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();

            DisplayRecords();

            this.StudentName = localManager.reportStudent;
        }

        private void MngUsers_Timer_Tick(object sender, EventArgs e)
        {
            SingleReport_DateLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void SingleReport_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.adminHome);
            this.Close();
        }

        private void SingleReport_TimeLbl_Click(object sender, EventArgs e)
        {

        }

        private void SingleReport_DateLbl_Click(object sender, EventArgs e)
        {

        }

        private void DisplayRecords()
        {
            DateTime first = localManager.StartDate;
            DateTime second = localManager.EndDate;
            string studentName = localManager.reportStudent;
            List<Record> studentRecords = localManager.GenerateRecord(first, second, studentName);
            MessageBox.Show(studentRecords.Count.ToString());
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
                    DataGridViewRow newRow = (DataGridViewRow)SingleReport_DataDisplay.Rows[0].Clone();
                    newRow.Cells[0].Value = record.DrillName;
                    newRow.Cells[1].Value = record.DateTaken;
                    newRow.Cells[2].Value = record.Question;
                    newRow.Cells[3].Value = record.Percent;
                    newRow.Cells[4].Value = record.Skipped;

                    SingleReport_DataDisplay.Rows.Add(newRow);
                }
            }
        }
    }
}
