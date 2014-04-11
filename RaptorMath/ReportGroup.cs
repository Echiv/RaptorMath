//==============================================================//
//					     ReportGroup.cs		       		        //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Cody Jordan and Cian Carota                         //
// Purpose: This form allows the user comparatively view the    //
//          the records of students in a group.                 //
// User:    • The user is assumed to be an admin.               //
//          • The user can click the Close button to return to  //
//            Admin home.                                       //
//==============================================================//

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
    public partial class ReportGroup_Form : Form
    {
        private Microsoft.Office.Interop.Excel.Application excel;
        public Manager localManager;
        private bool isKeyPressed = false;

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
            GroupReport_DateLbl.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/16/2014                                                  //
        //------------------------------------------------------------------//
        /// <summary>Formating initial display of current time.</summary>
        private void InitializeTimer()
        {
            GroupReport_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Group Report form constructor.</summary>
        /// <param name="manager">The program management class.</param>
        public ReportGroup_Form(Manager manager)
        {
            InitializeComponent();
            localManager = manager;
            InitializeDate();
            InitializeTimer();

            GroupReport_GroupNameLbl.Visible = false;

            if (localManager.reportGroup.ID > 0)
            {
                GroupReport_GroupNameLbl.Text = localManager.reportGroup.Name;
                GroupReport_GroupNameLbl.Visible = true;
                DisplayRecords();
            }
            else
            {
                MessageBox.Show("Group does not exist", "Raptor Math", MessageBoxButtons.OK);
            }
        }

        ~ReportGroup_Form()
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
        private void GroupReport_Timer_Tick(object sender, EventArgs e)
        {
            GroupReport_TimeLbl.Text = DateTime.Now.ToString("h:mm tt");
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Handle 'Close' button click.</summary>
        private void GroupReport_CloseBtn_Click(object sender, EventArgs e)
        {
            localManager.SetWindow(Window.studentReports);
            this.Close();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Displays the Group information in the GroupReport</summary>
        private void DisplayRecords()
        {
            DateTime first = localManager.StartDate;
            DateTime second = localManager.EndDate;

            Tuple<string, float, float, float, int> GroupReportSummary = localManager.GenerateRecordForGroup(first, second, localManager.reportGroup);
            DataGridViewRow newRow = (DataGridViewRow)GroupReport_DataDisplay.Rows[0].Clone();
            newRow.Cells[0].Value = GroupReportSummary.Item1;
            newRow.Cells[1].Value = GroupReportSummary.Item2;
            newRow.Cells[2].Value = GroupReportSummary.Item3;
            newRow.Cells[3].Value = GroupReportSummary.Item4;
            newRow.Cells[4].Value = GroupReportSummary.Item5;

            GroupReport_DataDisplay.Rows.Add(newRow);
        }

        private void GroupReport_ExcelBtn_Click(object sender, EventArgs e)
        {
            excel = new Microsoft.Office.Interop.Excel.Application();
            excel.DisplayAlerts = false;
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            //excel.Visible = true;
            ws.Cells[1, 1] = "Group Name";
            ws.Cells[1, 2] = GroupReport_GroupNameLbl.Text;
            ws.Cells[2, 1] = "Date Range";
            ws.Cells[2, 2] = localManager.StartDate.ToString() + " through " + localManager.EndDate.ToString();
            ws.Cells[3, 1] = "Name";
            ws.Cells[3, 2] = "Average Percent";
            ws.Cells[3, 3] = "Average Wrong";
            ws.Cells[3, 4] = "Average Skipped";
            ws.Cells[3, 5] = "Total Sets Done";

            for (int i = 0; i < GroupReport_DataDisplay.Rows.Count; i++)
            {
                for (int j = 0; j < GroupReport_DataDisplay.Columns.Count; j++)
                {
                    ws.Cells[i + 4, j + 1] = GroupReport_DataDisplay.Rows[i].Cells[j].Value;
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
