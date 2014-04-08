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
        private int id;
        private int groupID;
        private string firstName;
        private string lastName;
        private string loginName;
        private string lastLogin;
        private string recordsPath;

        public List<Record> curRecordList = new List<Record>();
        public List<Drill> curDrillList = new List<Drill>();

        public Drill curDrill = new Drill();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int GroupID
        {
            get { return this.groupID; }
            set { this.groupID = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
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

        public List<Drill> CurDrillList
        {
            get { return this.curDrillList; }
            set { this.curDrillList = value; }
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/17/2014                                                  //
        //------------------------------------------------------------------//
        public Student()
        {
            id = 0;
            groupID = 0;
            firstName = "Unknown";
            lastName = "Unknown";
            loginName = firstName + " " + lastName; 
            lastLogin = "Unknown";
            recordsPath = "Unknown";
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/17/2014                                                  //
        //------------------------------------------------------------------//
        public Student(int grpID, string fname, string lname, string login)
        {
            groupID = grpID;
            firstName = fname;
            lastName = lname;
            loginName = firstName + " " + lastName;
            lastLogin = login;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Resets drill object.</summary>
        public void ResetCurrentDrill()
        {
            curDrill.Reset();
        }
    }
}
