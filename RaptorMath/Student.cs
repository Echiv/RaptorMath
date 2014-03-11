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
        private string loginName;
        private string lastLogin;
        private string filePath;
        public Drill curDrill = new Drill();

        public List<Record> reportList = new List<Record>();

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

        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/17/2014                                                  //
        //------------------------------------------------------------------//
        public Student()
        {
            loginName = "Unknown";
            lastLogin = "Unknown";
            filePath = "Unknown";
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/17/2014                                                  //
        //------------------------------------------------------------------//
        public Student(string name, string login, string stID,
            string cQuestions, string cRangeSt, string cRangeEnd, string cOp, string aPath)
        {
            loginName = name;
            lastLogin = login;
            filePath = aPath;
        }

        public void ResetCurrentDrill()
        {
            curDrill.Reset();
        }
    }
}
