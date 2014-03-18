//==============================================================//
//					       Student.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Kyle Bridges and Harvey Kreitzer                    //
// Purpose: This class creates a Student object that contains   //
//          all pertinent data along with a list of all of the  //
//          records of every student.                           //
//==============================================================//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace RaptorMath
{
    //------------------------------------------------------------------//
    // Harvey Kreitzer                                                  //
    // Date: 2/17/2014                                                  //
    //------------------------------------------------------------------//
    public class Student
    {
        private string group;
        private string loginName;
        private string lastLogin;
        private string recordsPath;
        private string drillsPath;
        //public Drill curDrill = new Drill();

        public List<Record> reportList = new List<Record>();

        public string Group
        {
            get { return this.group; }
            set { this.group = value; }
        }
        public string LoginName
        {
            get { return this.loginName; }
            set { this.loginName = value; }
        }

        public string LastLogin
        {
            get { return this.lastLogin; }
            set { this.lastLogin = value; }
        }

        public string RecordsPath
        {
            get { return this.recordsPath; }
            set { this.recordsPath = value; }
        }

        public string DrillsPath
        {
            get { return this.drillsPath; }
            set { this.drillsPath = value; }
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/17/2014                                                  //
        //------------------------------------------------------------------//
        public Student()
        {
            group = "Unassigned";
            loginName = "Unknown";
            lastLogin = "Unknown";
            recordsPath = "Unknown";
            drillsPath = "Unknown";
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/17/2014                                                  //
        //------------------------------------------------------------------//
        public Student(string grp, string name, string login, string recsPath, string driPath)
        {
            group = grp;
            loginName = name;
            lastLogin = login;
            recordsPath = recsPath;
            drillsPath = driPath;
        }

        /*public void ResetCurrentDrill()
        {
            curDrill.Reset();
        }*/
    }
}
