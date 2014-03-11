//===========================================================Hello!?===//
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
        private string loginName;
        private string lastLogin;
        private string filePath;
        public List<Student> adminStudents = new List<Student>();

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
        // Date: 2/16/2014                                                  //
        //------------------------------------------------------------------//
        public Admin()
        {
            loginName = "Unknown";
            lastLogin = "Unknown";
            filePath = "Unknown";
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/16/2014                                                  //
        //------------------------------------------------------------------//
        public Admin(string name, string login, string pathLoc)
        {
            loginName = name;
            lastLogin = login;
            filePath = pathLoc;
        }
    }
}
