﻿//==============================================================//
//					      Program.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Kyle Bridges and Harvey Kreitzer                    //
// Purpose: This class initializes the main program and handles //
//          the creation and passing of its forms and methods.  //
//          It calls the Manager class to begin initialization. //
//          If the program is already running, an error message //
//          will display and will not open up another instance. //
//==============================================================//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaptorMath
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static Manager allManager = new Manager();
        [STAThread]
        static void Main()
        {
            System.Threading.Mutex mutexMyapplication = new System.Threading.Mutex(false, "RaptorMath.exe");
            if (!mutexMyapplication.WaitOne(TimeSpan.Zero, true))
            {
                MessageBox.Show(Application.ProductName + " is already running!", Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new UseDesg_Form());

            while (allManager.IsRunning() == true)
            {
                switch (allManager.GetWindow())
                {
                    case Window.authUser:
                        {
                            Application.Run(new UseDesg_Form(allManager));
                            break;
                        }
                    case Window.adminHome:
                        {
                            Application.Run(new AdminHome_Form(allManager));
                            break;
                        }
                    case Window.stuHome:
                        {
                            Application.Run(new StuHome_Form(allManager));
                            break;
                        }
                    case Window.stuDrill:
                        {
                            Application.Run(new MathDrill_Form(allManager));
                            break;
                        }
                    case Window.mngUsers:
                        {
                            Application.Run(new MngUsers_Form(allManager));
                            break;
                        }
                    case Window.createDrill:
                        {
                            Application.Run(new CreateDrill_Form(allManager));
                            break;
                        }
                    case Window.editStudents:
                        {
                            Application.Run(new EditStudents_Form(allManager));
                            break;
                        }
                    case Window.mngDrills:
                        {
                            Application.Run(new ManageDrills_Form(allManager));
                            break;
                        }
                    case Window.mngGroups:
                        {
                            Application.Run(new ManageGroups_Form(allManager));
                            break;
                        }
                    case Window.reportGroup:
                        {
                            Application.Run(new ReportGroup_Form(allManager));
                            break;
                        }
                    case Window.reportSingle:
                        {
                            Application.Run(new SingleReport_Form(allManager));
                            break;
                        }
                    case Window.studentReports:
                        {
                            Application.Run(new StudentReports_Form(allManager));
                            break;
                        } 

                    default:
                        break;
                }
            }
        }
    }
}
