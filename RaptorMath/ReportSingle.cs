//==============================================================//
//					     ReportGroup.cs		       		        //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Cody Jordan and Cian Carota                         //
// Purpose: This form allows the user to view the the records   //
//          of a student.                                       //
// User:    • The user is assumed to be an admin.               //
//          • The user can click the Close button to return to  //
//            Admin home.                                       //
//==============================================================//
/* 
Authors: Joshua Boone and Justine Dinh                     
Cycle 3 Changes:
 * Date: 4/10/14
 * • Added the ability to export a report to excel.
 * Date: 4/12/14
 * • Added logic to disallow interaction with a form's border close button.
 * • Added logic to disallow copy, paste, and cut.
 * Date: 5/01/14
 * • Completely deprecated.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace RaptorMath
{
    public partial class SingleReport_Form : Form
    {
        private Microsoft.Office.Interop.Excel.Application excel;
        public Manager localManager;

        private bool isKeyPressed = false;

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                     //
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
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle KeyUp event.</summary>
        private void RaptorMath_KeyUp(object sender, KeyEventArgs e)
        {
            isKeyPressed = false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersKeyDown event.</summary>
        private void RaptorMath_LettersKeyDown(object sender, KeyEventArgs e)
        {
            bool isLetter = char.IsLetter((char)e.KeyCode);
            if ((e.KeyCode != Keys.Back) && (!e.Shift) && (!isLetter))
            {
                e.SuppressKeyPress = isKeyPressed;
                isKeyPressed = true;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersAndDigitsKeyDown event.</summary>
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle DigitsKeyDown event.</summary>
        private void RaptorMath_DigitsKeyDown(object sender, KeyEventArgs e)
        {
            bool isDigit = char.IsDigit((char)e.KeyCode);
            if ((e.KeyCode != Keys.Back) && (!e.Shift) && (!isDigit))
            {
                e.SuppressKeyPress = isKeyPressed;
                isKeyPressed = true;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersWithOneWhiteSpaceKeyPress event.</summary>
        private void RaptorMath_LettersWithOneWhiteSpaceKeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox cmbobx = (ComboBox)sender;
            e.Handled = (!(char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || (!cmbobx.Text.Contains(' ')) || (char.IsControl(e.KeyChar))));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersAndDigitsKeyPress event.</summary>
        private void RaptorMath_LettersAndDigitsKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || (char.IsControl(e.KeyChar)));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle DigitsKeyPress event.</summary>
        private void RaptorMath_DigitsKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (char.IsControl(e.KeyChar)));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle LettersKeyPress event.</summary>
        private void RaptorMath_LettersKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (char.IsControl(e.KeyChar)));
            if (e.Handled)
                System.Media.SystemSounds.Beep.Play();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current date.</summary>
        private void InitializeDate()
        {
            SingleReport_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current time.</summary>
        private void InitializeTimer()
        {
            SingleReport_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
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
        // Date: 4/4/14                                                     //
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

            this.StudentName = localManager.reportStudent.LoginName;
        }

        ~SingleReport_Form()
        {
            if (excel != null)
            {
                excel.Quit();
                excel = null;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Time display update on timer tick.</summary>
        private void SingleReport_Timer_Tick(object sender, EventArgs e)
        {
            SingleReport_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Close' button click.</summary>
        private void SingleReport_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.studentReports);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/4/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Refreshes the datagrid to display the records of the
        /// selected user.</summary>
        private void DisplayRecords()
        {
            DateTime first = localManager.StartDate;
            DateTime second = localManager.EndDate;
            //string studentName = localManager.reportStudent;
            List<Record> studentRecords = localManager.GenerateRecord(first, second, localManager.reportStudent.LoginName);
            // Search by calendar
            if (studentRecords.Count > 0)
            {
                foreach (Record record in studentRecords)
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
            else
            {
                MessageBox.Show("No records found between the selected date range.", "Raptor Math", MessageBoxButtons.OK);
                SingleReport_CloseBtn.Select();
            }
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/10/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Exports the opened report to an excel file.</summary>
        private void SingleReport_Excel_Click(object sender, EventArgs e)
        {
            excel = new Microsoft.Office.Interop.Excel.Application();
            excel.DisplayAlerts = false;
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            //excel.Visible = true;
            ws.Cells[1, 1] = "Student Name";
            ws.Cells[1, 2] = StudentName;
            ws.Cells[2, 1] = "Date Range";
            ws.Cells[2, 2] = localManager.StartDate.ToString() + " through " + localManager.EndDate.ToString();
            ws.Cells[3, 1] = "Drill Name";
            ws.Cells[3, 2] = "Date Taken";
            ws.Cells[3, 3] = "# Questions";
            ws.Cells[3, 4] = "% Correct";
            ws.Cells[3, 5] = "Skipped";

            for (int i = 0; i < SingleReport_DataDisplay.Rows.Count; i++)
            {
                for (int j = 0; j < SingleReport_DataDisplay.Columns.Count; j++)
                {
                    ws.Cells[i+4, j+1] = SingleReport_DataDisplay.Rows[i].Cells[j].Value;
                }
            }
            ws.Cells.Columns.AutoFit();
            ws.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            using (SaveFileDialog exportSaveFileDialog = new SaveFileDialog())
            {
                exportSaveFileDialog.Title = "Select Excel File";
                exportSaveFileDialog.Filter = "Microsoft Office Excel Workbook(*.xlsx)|*.xlsx";

                if (DialogResult.OK == exportSaveFileDialog.ShowDialog())
                {
                    string fullFileName = exportSaveFileDialog.FileName;
                    // currentWorkbook.SaveCopyAs(fullFileName);
                    // indicating that we already saved the workbook, otherwise call to Quit() will pop up
                    // the save file dialogue box
                    object misValue = System.Reflection.Missing.Value;
                    try
                    {
                        wb.SaveAs(fullFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, System.Reflection.Missing.Value, misValue, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, true, misValue, misValue, misValue);
                        wb.Saved = true;
                        MessageBox.Show("Exported successfully", "Exported to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (System.Runtime.InteropServices.COMException error)
                    {
                        MessageBox.Show("Error. File is in use.", "Exported to Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (excel != null)
            {
                wb.Close(Type.Missing, Type.Missing, Type.Missing);
                excel.Quit();
                excel = null;
            }
        }
    }
}
