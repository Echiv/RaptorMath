//==============================================================//
//					        Admin.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Kyle Bridges and Harvey Kreitzer                    //
// Purpose: This class creates an Admin object that contains    //
//          all pertinent data along with a list of all of the  //
//          students each admin has based on a given file path. //
//==============================================================//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaptorMath
{
    //------------------------------------------------------------------//
    // Harvey Kreitzer                                                  //
    // Date: 2/16/2014                                                  //
    //------------------------------------------------------------------//
    public class Admin
    {
        private int id;
        private string firstName;
        private string lastName;
        private string loginName;
        private string password;
        private string lastLogin;
        private string filePath;
        public List<Student> adminStudents = new List<Student>();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
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

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
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
        // Date: 2/16/2014                                                  //
        //------------------------------------------------------------------//
        public Admin()
        {
            firstName = "Unknown";
            lastName = "Unknown";
            loginName = firstName + " " + lastName;
            password = "Unknown";
            lastLogin = "Unknown";
            filePath = "Unknown";
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/16/2014                                                  //
        //------------------------------------------------------------------//
        public Admin(string fname, string lname, string pwd, string login, string pathLoc)
        {
            firstName = fname;
            lastName = lname;
            loginName = firstName + " " + lastName;
            password = pwd;
            lastLogin = login;
            filePath = pathLoc;
        }
    }
}
