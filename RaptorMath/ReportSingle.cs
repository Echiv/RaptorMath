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
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current date.</summary>
        private void InitializeDate()
        {
            SingleReport_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current time.</summary>
        private void InitializeTimer()
        {
            SingleReport_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 2/20/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Accessor: Student's Name.</summary>
        public string StudentName
        {
            get { return SingleReport__StudentNameLbl.Text; }
            set { SingleReport__StudentNameLbl.Text = value; }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Single Report form constructor.</summary>
        /// <param name="manager">The program management class.</param>
        public SingleReport_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();

            DisplayRecords();

            this.StudentName = localManager.reportStudent;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Time display update on timer tick.</summary>
        private void SingleReport_Timer_Tick(object sender, EventArgs e)
        {
            SingleReport_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Close' button click.</summary>
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Refreshes the datagrid to display the records of the
        /// selected user.</summary>
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
