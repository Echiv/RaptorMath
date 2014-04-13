//==============================================================//
//					       Manager.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Kyle Bridges and Harvey Kreitzer                    //
// Purpose: This class is called by the main Program in order   //
//          to properly create, manage, and close all the forms //
//          found within the program itself. It can call the    //
//          XMLParser class whenever the program requires       //
//          reading or writing to XML, and it contains a        //
//          variety of useful functions that are easily         //
//          accessible within the desired form.                 //
//==============================================================//
// Authors: Cody Jordan and Cian Carota                         //
// Changes:                                                     //
//          • Refactored: Accessors and constructors            //
//          • Added accessor functions.                         //
//          • Added access and data validation functions.       //
//          • Added object (Admin, Student, Group, etc...)      //
//            creation functions.                               //
//==============================================================//
/* 
Authors: Joshua Boone and Justine Dinh                     
Cycle 3 Changes:
 * Date: 4/12/14
 * • Added new methods for editing a student
 * • Added a method to find if there exists any group records within a given date range
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaptorMath
{
    //------------------------------------------------------------------//
    // Kyle Bridges, Harvey Kreitzer                                    //
    // Date: 2/20/2014                                                  //
    //------------------------------------------------------------------//
    // Authors: Cody Jordan, Cian Carota                                //
    // Date: 4/3/14                                                     //
    //------------------------------------------------------------------//
    public enum Window
    {
        authUser, adminHome, adminReport,
        stuHome
        , stuDrill, mngUsers, createDrill, editStudents, mngDrills
        , mngGroups, reportGroup, reportSingle, studentReports };
    public class Manager
    {
        Window form = Window.authUser;
        bool programRunning = true;
        public string currentUser = string.Empty;
        public string currentPassword = string.Empty;
        public string currentUserLogin = string.Empty;
        //public string operand = string.Empty;
        public string dataDirectory = string.Empty;
        public string adminXMLPath = string.Empty;
        public string studentXMLPath = string.Empty;
        public string groupXMLPath = string.Empty;
        public string drillXMLPath = string.Empty;
        public int currentProblemNumber = 1;
        public List<Student> studentList = new List<Student>();
        public List<Admin> adminList = new List<Admin>();
        public List<Group> groupList = new List<Group>();
        public List<Drill> mainDrillList = new List<Drill>();
        public Student currentStudent = new Student();
        public Admin currentAdmin = new Admin();
        public Drill currentDrill = new Drill();
        public Random random = new Random();
        public DateTime StartDate = DateTime.Now;
        public DateTime EndDate = DateTime.Now;
        public Student reportStudent = new Student();
        public Group reportGroup = new Group();
        public int currSolution;
        //XMLParser XML = new XMLParser();
        XMLDriver XMLDriver = new XMLDriver();

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Drill object default constructor.</summary>
        public Manager()
        {

            string AppData = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            dataDirectory = System.IO.Path.Combine(AppData, "RaptorMath");
            if (!System.IO.Directory.Exists(dataDirectory))
                System.IO.Directory.CreateDirectory(dataDirectory);
            string adminFile = "RaptorMathAdmins.xml";
            string studentFile = "RaptorMathStudents.xml";
            string groupFile = "RaptorMathGroups.xml";
            string drillFile = "RaptorMathDrills.xml";
            adminXMLPath = System.IO.Path.Combine(dataDirectory, adminFile);
            studentXMLPath = System.IO.Path.Combine(dataDirectory, studentFile);
            groupXMLPath = System.IO.Path.Combine(dataDirectory, groupFile);
            drillXMLPath = System.IO.Path.Combine(dataDirectory, drillFile);
            XMLDriver localXMLDriver = new XMLDriver(adminXMLPath, studentXMLPath, groupXMLPath, drillXMLPath, dataDirectory);
            XMLDriver = localXMLDriver;
            //XML.LoadXML(studentList, adminList);
            XMLDriver.StartUp(adminList, studentList, groupList, mainDrillList);
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Validate the administrator's info and then add the administrator to the admin XML
        /// </summary>
        /// <param name="adminFName">Admin's first name.</param>
        /// <param name="adminLName">Admin's last mame.</param>
        /// <param name="password">Admin's password.</param>
        /// <param name="LastLogin">Admin's last login date.</param>
        /// <param name="filePath">Admin XML filepath.</param>
        /// <returns>Boolean confirming creation success.</returns>
        public bool CreateUser(string adminFName, string adminLName, string password, string LastLogin, string filePath)
        {
            bool isCreatedUser = false;
            Admin newAdmin = new Admin(adminFName, adminLName, password, LastLogin, filePath);

            bool isUserInfoValid = isAdminInfoValid(newAdmin);
            if(isUserInfoValid)
                isCreatedUser = XMLDriver.AddUserToXML(newAdmin, adminList);

            return isCreatedUser;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Validate the student info and then add the student to the student XML</summary>
        /// <param name="groupID">Student's group ID.</param>
        /// <param name="firstName">Student's first name.</param>
        /// <param name="lastName">Student's last name.</param>
        /// <param name="lastLogin">Student's last login date.</param>
        /// <returns>Boolean confirming creation success.</returns>
        public bool CreateUser(int groupID, string firstName, string lastName, string lastLogin)
        {
            bool isCreatedUser = false;
            Student newStudent = new Student(groupID, firstName, lastName, lastLogin);

            bool isUserInfoValid = isStudentInfoValid(newStudent);
            if(isUserInfoValid)
                isCreatedUser = XMLDriver.AddUserToXML(newStudent, studentList);
            if(isCreatedUser)
            {
                Group group = groupList.Where(grp => grp.ID.ToString().Equals(newStudent.GroupID.ToString())).FirstOrDefault();
                AddGroupDrillsToStudent(group, newStudent);
            }
            return isCreatedUser;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Validate group info and then add the group to the group XML</summary>
        /// <param name="name">Group's name.</param>
        /// <returns>Boolean confirming creation success.</returns>
        public bool CreateGroup(string name)
        {
            bool isCreatedGroup = false;

            bool isGroupValid = isGroupInfoValid(name);
            if (isGroupValid)
                isCreatedGroup = XMLDriver.AddNewGroup(name, groupList);

            return isCreatedGroup;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Validate Drill info and then add the drill to the drill XML</summary>
        /// <param name="drillName">Drill's name.</param>
        /// <param name="numQuestions">Drill's number of problems.</param>
        /// <param name="minValue">Drill's min value.</param>
        /// <param name="maxValue">Drill's max value.</param>
        /// <param name="add">Drill's operator if addition.</param>
        /// <param name="subtract">Drill's operator if subtraction.</param>
        /// <returns>Boolean confirming creation success.</returns>
        public bool CreateDrill(string drillName, string numQuestions, string minValue, string maxValue, bool add, bool subtract)
        {
            bool isDrillAdded = false;
            string operand = SetOperand(add, subtract);

            Drill newDrill = new Drill(drillName, numQuestions, minValue, maxValue, operand);
            bool isDrillValid = isDrillInfoValid(newDrill);
            if (isDrillValid)
                isDrillAdded = XMLDriver.AddNewDrill(newDrill, mainDrillList);

            return isDrillAdded;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Validation of admin data input.</summary>
        /// <param name="adminToValidate">Admin object to validate.</param>
        /// <returns>Boolean confirming validity.</returns>
        public bool isAdminInfoValid(Admin adminToValidate)
        {
            if (!(adminToValidate.FirstName.Equals(string.Empty))
                && (adminToValidate.FirstName.All(char.IsLetter))
                && !(adminToValidate.LastName.Equals(string.Empty))
                && (adminToValidate.LastName.All(char.IsLetter))
                && (adminToValidate.Password.All(char.IsLetterOrDigit))
                && (!studentList.Any(student => student.LoginName.Equals(adminToValidate.LoginName))))
            {
                return true;
            }
            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Validation of student data input.</summary>
        /// <param name="studentToValidate">Stdent object to validate.</param>
        /// <returns>Boolean confirming validity.</returns>
        public bool isStudentInfoValid(Student studentToValidate)
        {
            if (!(studentToValidate.FirstName.Equals(string.Empty))
                && (studentToValidate.FirstName.All(char.IsLetter))
                && !(studentToValidate.LastName.Equals(string.Empty))
                && (studentToValidate.LastName.All(char.IsLetter)) 
                && (studentToValidate.GroupID > 0)
                && (groupList.Any(group => group.ID.Equals(studentToValidate.GroupID)))
                && (!adminList.Any(admin => admin.LoginName.Equals(studentToValidate.LoginName))))
            {
                return true;
            }
            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Validation of group data input.</summary>
        /// <param name="groupToValidate">Group object to validate.</param>
        /// <returns>Boolean confirming validity.</returns>
        public bool isGroupInfoValid(string groupToValidate)
        {
            if (!(groupToValidate.Equals(string.Empty)))
            {
                return true;
            }
            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Validation of drill data input.</summary>
        /// <param name="drillToValidate">Drill object to validate.</param>
        /// <returns>Boolean confirming validity.</returns>
        public bool isDrillInfoValid(Drill drillToValidate)
        {
            if (!(drillToValidate.DrillName.Equals(string.Empty))
                && (drillToValidate.Questions.All(char.IsDigit))
                && (drillToValidate.RangeStart.All(char.IsDigit) && (Convert.ToInt32(drillToValidate.RangeStart) > 0))
                && (drillToValidate.RangeEnd.All(char.IsDigit) && (Convert.ToInt32(drillToValidate.RangeEnd) > 0))
                && (drillToValidate.Operand.Equals("subtraction") || (drillToValidate.Operand.Equals("addition"))))
            {
                return true;
            }
            return false;
        }

        ////----------------------------------------------------------------------------------------------//
        //// Authors: Cody Jordan, Cian Carota                                                            //
        //// Date: 4/3/14                                                                                 //
        ////----------------------------------------------------------------------------------------------//
        ///// <summary>Adjust student information.</summary>
        ///// <param name="newFName">Student's new first name.</param>
        ///// <param name="newLName">Student's new last name.</param>
        ///// <param name="currentName">Student's current full name.</param>
        ///// <param name="newGroup">Student's new group name.</param>
        ///// <param name="studentList">List containing student objects.</param>
        ///// <param name="groupList">List containing group objects.</param>
        //public bool RenameStudent(string newFName, string newLName, string currentName, string newGroup, List<Student> studentList, List<Group> groupList)
        //{
        //    Tuple<bool, bool> GroupStudentChanged = new Tuple<bool, bool>(false, false);
            
        //    if (currentName.Replace(" ", string.Empty).All(char.IsLetter)
        //        && !(currentName.Replace(" ", string.Empty).Equals(string.Empty))
        //        && ((!newFName.Equals(string.Empty)) || (!newLName.Equals(string.Empty)) || (!newGroup.Equals(string.Empty))))
        //    {
        //        Student selectedStudent = FindStudentWithName(currentName);
        //        // Need to make sure that this student doesn't alreadt exist
        //        string newName = newFName + " " + newLName;
        //        Student existStudent = FindStudentWithName(newName);
        //        if (selectedStudent != null && existStudent == null)
        //        {
        //            // Need to make sure the group exists
        //            Group selectedGroup = FindGroupByName(newGroup);
        //            if (selectedGroup != null)
        //            {
        //                Group oldGroup = FindGroupByID(selectedStudent.GroupID);
        //                GroupStudentChanged = XMLDriver.editStudent(newFName, newLName, selectedStudent, selectedGroup, studentList);
        //                if (GroupStudentChanged.Item1)
        //                {
        //                    RemoveGroupDrillsFromStudent(oldGroup, selectedStudent);
        //                    AddGroupDrillsToStudent(selectedGroup, selectedStudent);
        //                }
        //            }
        //            else
        //            {
        //                // 4/09/14 Added this bad code to get the program to rename a student even no new group was selected
        //                Group oldGroup = FindGroupByID(selectedStudent.GroupID);
        //                GroupStudentChanged = XMLDriver.editStudent(newFName, newLName, selectedStudent, oldGroup, studentList);
        //            }
        //            return GroupStudentChanged.Item2;
        //        }
        //    }
        //    return GroupStudentChanged.Item2;
        //}

        //----------------------------------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                                                           //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Adjust student information.</summary>
        /// <param name="newFName">Student's new first name.</param>
        /// <param name="newLName">Student's new last name.</param>
        /// <param name="currentName">Student's current full name.</param>
        /// <param name="newGroup">Student's new group name.</param>
        /// <param name="studentList">List containing student objects.</param>
        /// <param name="groupList">List containing group objects.</param>
        public int IsValidEdit(string newFName, string newLName, string currentName, string newGroup, List<Student> studentList, List<Group> groupList)
        {
            // Error code can be 0 through 3. 
            // 0 means the edit is valid
            // 1 means the entered student doesn't exist
            // 2 means the entered new name(s) are not valid
            // 3 means the entered group is not valid
            int errorCode = 0;

            // Check to see if student to edit exists
            if (FindStudentWithName(currentName) == null)
            {
                errorCode = 1;
            }
            // Check to see if the desired new name student is valid
            else if (IsEditNameValid(newFName, newLName, currentName, studentList) == false)
            {
                errorCode = 2;
            }
            // Check to see if the desirted new group is valid
            else if (FindGroupByName(newGroup) == null && !newGroup.Equals(string.Empty))
            {
                errorCode = 3;
            }

            return errorCode;
        }
        //----------------------------------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                                                           //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Checks to see if the new name is valid.</summary>
        /// <param name="newFName">Student's new first name.</param>
        /// <param name="newLName">Student's new last name.</param>
        /// <param name="currentName">Student's current full name.</param>
        /// <param name="studentList">List containing student objects.</param>
        public bool IsEditNameValid(string newFName, string newLName, string currentName, List<Student> studentList)
        {
            // Used to return what data was not valid
            bool isValid = true;
            // Used to to see if there already exists a student in the system with the new name selected
            Student existStudent;
            // USed to hold the split name of the current student so we can easily get his first and last name
            string[] wholeName;
            // Holds the valid chars to split a string on
            string[] separators = {" "};
            // Now split the string
            wholeName = currentName.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            // Check to see if a student by the passed names already exists
            // Need to find out if we are changing the student's name and if so what parts of it
            if (newFName.Equals(string.Empty) && newLName.Equals(string.Empty))
            {
                // We are not trying to change the student's name
                // Do nothing because this valid
            }
            else if (newFName.Equals(string.Empty) && !newLName.Equals(string.Empty))
            {
                // We are trying to change the student's last name.
                // Need to get the students first name here for appending
                string newName = wholeName[0] + " " + newLName;
                // Check to see if there is already a student by this name
                existStudent = FindStudentWithName(newName);
                if (existStudent != null)
                {
                    isValid = false;
                }
            }
            else if (!newFName.Equals(string.Empty) && newLName.Equals(string.Empty))
            {
                // We are trying to change the student's first name.
                // Need to get the students last name here for appending
                string newName = newFName + " " + wholeName[0];
                // Check to see if there is already a student by this name
                existStudent = FindStudentWithName(newName);
                if (existStudent != null)
                {
                    isValid = false;
                }
            }
            else if (!newFName.Equals(string.Empty) && !newLName.Equals(string.Empty))
            {
                // We are trying to change the student's whole name
                string newName = newFName + " " + newLName;
                // Check to see if there is already a student by this name
                existStudent = FindStudentWithName(newName);
                if (existStudent != null)
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                                                       //
        // Date: 4/12/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Adjust student information.</summary>
        /// <param name="newFName">Student's new first name.</param>
        /// <param name="newLName">Student's new last name.</param>
        /// <param name="currentName">Student's current full name.</param>
        /// <param name="newGroup">Student's new group name.</param>
        /// <param name="studentList">List containing student objects.</param>
        /// <param name="groupList">List containing group objects.</param>
        public void EditStudent(string newFName, string newLName, string currentName, string newGroup, List<Student> studentList, List<Group> groupList)
        {
            // Get the student we need to edit
            Student selectedStudent = FindStudentWithName(currentName);
            // We must determine what exactly needs to be edited
            if (!newFName.Equals(string.Empty) && newLName.Equals(string.Empty))
            {
                selectedStudent.FirstName = newFName;
                selectedStudent.LoginName = selectedStudent.FirstName + " " + selectedStudent.LastName;
                XMLDriver.EditName(selectedStudent);
            }
            else if (newFName.Equals(string.Empty) && !newLName.Equals(string.Empty))
            {
                selectedStudent.LastName = newLName;
                selectedStudent.LoginName = selectedStudent.FirstName + " " + selectedStudent.LastName;
                XMLDriver.EditName(selectedStudent);
            }
            else if (!newFName.Equals(string.Empty) && !newLName.Equals(string.Empty))
            {
                selectedStudent.FirstName = newFName;
                selectedStudent.LastName = newLName;
                selectedStudent.LoginName = selectedStudent.FirstName + " " + selectedStudent.LastName;
                XMLDriver.EditName(selectedStudent);
            }
            // Now to check to see if the group needs to be changed
            if (!newGroup.Equals(string.Empty))
            {
                Group selectedGroup = FindGroupByName(newGroup);
                Group oldGroup = FindGroupByID(selectedStudent.GroupID);
                XMLDriver.EditGroup(selectedStudent, selectedGroup);
                RemoveGroupDrillsFromStudent(oldGroup, selectedStudent);
                AddGroupDrillsToStudent(selectedGroup, selectedStudent);
            }
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Adjust group information.</summary>
        /// <param name="newName">Group's new name.</param>
        /// <param name="currentName">Group's current name.</param>
        /// <param name="groupList">List of group objects.</param>
        public bool RenameGroup(string newName, string currentName, List<Group> groupList)
        {
            if (!(newName.Equals(string.Empty))
                && !(currentName.Equals(string.Empty)))
            {
                return XMLDriver.editGroup(newName, currentName, groupList);
            }
            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Change admin's current password.</summary>
        /// <param name="currentPassword">Current Password.</param>
        /// <param name="newPassword">New password.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool ChangeAdminPassword(string currentPassword, string newPassword)
        {
            if (currentPassword == currentAdmin.Password)
            {
                return XMLDriver.editAdmin(newPassword, currentAdmin, adminList);
            }
            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Remove user from data set.</summary>
        /// <param name="userName">User's name.</param>
        public bool removeUser(string userName)
        {
            bool isAdmin = false;
            if(userName.Length > 9)
                isAdmin = adminList.Any(admin => admin.LoginName.Equals(userName.Remove(0, 8)));
            bool isStudent = studentList.Any(student => student.LoginName.Equals(userName));
            if (isAdmin)
            {
                Admin admin = adminList.Where(adm => adm.LoginName.Equals(userName.Remove(0, 8))).FirstOrDefault();
                if (admin != null)
                    return XMLDriver.Delete(admin, adminList);
                else
                    return false;
            }
            else if(isStudent)
            {
                Student student = studentList.Where(stu => stu.LoginName.Equals(userName)).FirstOrDefault();
                if(adminList != null)
                    return XMLDriver.Delete(student, studentList);
                return false;
            }
            else
                return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Assign a drill to a student.</summary>
        /// <param name="studentName">Studen'ts name.</param>
        /// <param name="drillName">Drill's name.</param>
        /// <returns>Boolean confirming assignment success.</returns>
        public bool AssignDrillToStudent(string studentName, string drillName)
        {
            Student student = studentList.Where(stu => stu.LoginName.Equals(studentName)).FirstOrDefault();
            Drill drill = mainDrillList.Where(dri => dri.DrillName.Equals(drillName)).FirstOrDefault();
            if ((student != null) && (drill != null))
                return AddDrillToStudent(student, drill);
            else
                return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Assign a drill to a group.</summary>
        /// <param name="groupName">Group's name.</param>
        /// <param name="drillName">Drill's name.</param>
        /// <returns>Boolean confirming assignment success.</returns>
        public bool AssignDrillToGroup(string groupName, string drillName)
        {
            Group group = groupList.Where(grp => grp.Name.Equals(groupName)).FirstOrDefault();
            Drill drill = mainDrillList.Where(dri => dri.DrillName.Equals(drillName)).FirstOrDefault();
            if ((group != null) && (drill != null))
                return AddDrillToGroup(group, drill);
            else
                return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Remove a drill from a student.</summary>
        /// <param name="studentName">Studen'ts name.</param>
        /// <param name="drillName">Drill's name.</param>
        /// <returns>Boolean confirming removal success.</returns>
        public bool UnassignDrillFromStudent(string studentName, string drillName)
        {
            Student student = studentList.Where(stu => stu.LoginName.Equals(studentName)).FirstOrDefault();
            Drill drill = mainDrillList.Where(dri => dri.DrillName.Equals(drillName)).FirstOrDefault();
            if ((student != null) && (drill != null))
                return RemoveDrillFromStudent(student, drill);
            else
                return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Remove a drill from a group.</summary>
        /// <param name="groupName">Group's name.</param>
        /// <param name="drillName">Drill's name.</param>
        /// <returns>Boolean confirming removal success.</returns>
        public bool UnassignDrillFromGroup(string groupName, string drillName)
        {
            Group group = groupList.Where(grp => grp.Name.Equals(groupName)).FirstOrDefault();
            Drill drill = mainDrillList.Where(dri => dri.DrillName.Equals(drillName)).FirstOrDefault();
            if ((group != null) && (drill != null))
                return RemoveDrillFromGroup(group, drill);
            else
                return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Search dataset for a student's name.</summary>
        /// <param name="studentName">Student's name.</param>
        /// <returns>Student object.</returns>
        public Student FindStudentWithName(string studentName)
        {
            Student foundStudent = studentList.Where(stu => stu.LoginName.Equals(studentName)).FirstOrDefault();
            return (foundStudent);
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Search dataset for a group's name.</summary>
        /// <param name="GroupName">Group's name.</param>
        /// <returns>Group object.</returns>
        public Group FindGroupByName(string GroupName)
        {
            Group foundGroup = groupList.Where(grp => grp.Name.Equals(GroupName)).FirstOrDefault();
            return (foundGroup);
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Search dataset for a group's ID.</summary>
        /// <param name="groupID">Group's ID.</param>
        /// <returns>Group object.</returns>
        public Group FindGroupByID(int groupID)
        {
            Group foundGroup = groupList.Where(grp => grp.ID.ToString().Equals(groupID.ToString())).FirstOrDefault();
            return foundGroup;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Search dataset for a group ID given group's name.</summary>
        /// <param name="GroupName">Group's name.</param>
        /// <returns>Group ID.</returns>
        public int FindGroupIDByName(string GroupName)
        {
            Group foundGroup = groupList.Where(grp => grp.Name.Equals(GroupName)).FirstOrDefault();
            if (GroupName == string.Empty)
                return 1;
            if (foundGroup == null)
                return 0;
            return (foundGroup.ID);
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Add a drill to student's XML file.</summary>
        /// <param name="student">Student object to be modified.</param>
        /// <param name="drillToAdd">Drill object to be added.</param>
        /// <returns>Boolean confirming addition success.</returns>
        public bool AddDrillToStudent(Student student, Drill drillToAdd)
        {
            return XMLDriver.AddDrillToStudentXML(student, drillToAdd);
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Add a drill to group's XML file.</summary>
        /// <param name="group">Group object to be modified.</param>
        /// <param name="drillToAdd">Drill object to be added.</param>
        /// <returns>Boolean confirming addition success.</returns>
        public bool AddDrillToGroup(Group group, Drill drillToAdd)
        {
            bool isDrillAddedToGroup = XMLDriver.AddDrillToGroupXML(group, drillToAdd);
            List<Student> StudentList = FindStudentsByGroupID(group.ID);
            
            if(isDrillAddedToGroup)
            {
                foreach(Student student in StudentList)
                {
                    AddDrillToStudent(student, drillToAdd);
                }
            }
            return isDrillAddedToGroup;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Add all group's drills to student's XML file.</summary>
        /// <param name="group">Group object acting as source.</param>
        /// <param name="student">Student object to be modified.</param>
        public void AddGroupDrillsToStudent(Group group, Student student)
        {
            if ((group != null) && (student != null))
            {
                foreach(Drill drill in group.groupDrillList)
                {
                    AddDrillToStudent(student, drill);
                }
            }
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Remove all group's drills from student's XML file.</summary>
        /// <param name="group">Group object acting as source.</param>
        /// <param name="student">Student object to be modified.</param>
        public void RemoveGroupDrillsFromStudent(Group group, Student student)
        {
            if ((group != null) && (student != null))
            {
                foreach (Drill drill in group.groupDrillList)
                {
                    RemoveDrillFromStudent(student, drill);
                }
            }
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Get data on all students associated with a group.</summary>
        /// <param name="groupID">Group acting as source.</param>
        /// <returns>List of student objects.</returns>
        public List<Student> FindStudentsByGroupID(int groupID)
        {
            return studentList.Where(stu => stu.GroupID.ToString().Equals(groupID.ToString())).ToList();
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Remove a drill from student's XML file.</summary>
        /// <param name="student">Student object to be modified.</param>
        /// <param name="drillToRemove">Drill object to be removed.</param>
        /// <returns>Boolean confirming removal success.</returns>
        public bool RemoveDrillFromStudent(Student student, Drill drillToRemove)
        {
            return XMLDriver.RemoveDrillFromStudentXML(student, drillToRemove);
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Remove a drill from group's XML file.</summary>
        /// <param name="group">Group object to be modified.</param>
        /// <param name="drillToRemove">Drill object to be removed.</param>
        /// <returns>Boolean confirming removal success.</returns>
        public bool RemoveDrillFromGroup(Group group, Drill drillToRemove)
        {
            bool isDrillRemovedFromGroup = XMLDriver.RemoveDrillFromGroupXML(group, drillToRemove);
            List<Student> StudentList = FindStudentsByGroupID(group.ID);

            if (isDrillRemovedFromGroup)
            {
                foreach (Student student in StudentList)
                {
                    RemoveDrillFromStudent(student, drillToRemove);
                }
            }
            return isDrillRemovedFromGroup;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/1/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Check running status of program.</summary>
        /// <returns>Boolean confirming running status.</returns>
        public bool IsRunning()
        {
            return (programRunning);
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/1/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Access form.</summary>
        /// <returns>Form object being accessed.</returns>
        public Window GetWindow()
        {
            return (form);
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/1/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Set status of program to not running.</summary>
        public void SetIsRunningFalse()
        {
            programRunning = false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/1/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Set window object.</summary>
        /// <param name="newForm">Window to be established.</param>
        public void SetWindow(Window newForm)
        {
            form = newForm;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Generate a list of all user's first names.</summary>
        /// <returns>List of strings.</returns>
        public List<String> GetUsersFirstNames()
        {
            List<String> userFirstNamesList = new List<String>();
            foreach (Admin admin in adminList)
                userFirstNamesList.Add(admin.FirstName);

            foreach (Student student in studentList)
                userFirstNamesList.Add(student.FirstName);

            
            userFirstNamesList.Sort();
            return userFirstNamesList.Distinct().ToList(); 
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Generate a list of all user's last names.</summary>
        /// <returns>List of strings.</returns>
        public List<String> GetUsersLastNames()
        {
            List<String> userLastNamesList = new List<String>();
            foreach (Admin admin in adminList)
                userLastNamesList.Add(admin.LastName);

            foreach (Student student in studentList)
                userLastNamesList.Add(student.LastName);

            
            userLastNamesList.Sort();
            return userLastNamesList.Distinct().ToList(); 
        }

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/26/2014                                                  //
        // Returns list of users for use in drop down list                  //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Fill a list of user names.</summary>
        /// <returns>List<String></returns>
        public List<String> GetUsers()
        {
            List<String> userList = new List<String>();

            /*
            if (!adminList.Any())
            {
                userList.Add(noAdmins);

                if (!studentList.Any())
                    userList.Add(noStudents);
            }

            else
            {*/
            foreach (Admin admin in adminList)
            {
                string userName = String.Concat("<Admin> ", admin.LoginName);
                userList.Add(userName);
            }

            foreach (Student student in studentList)
                userList.Add(student.LoginName);
            //}
            userList.Sort();
            return userList;
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/26/2014                                                  //
        // Checks if the selected user is an admin, returns bool            //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Check if user is admin.</summary>
        /// <returns>Boolean confirmation</returns>
        public bool isAdmin()
        {
            if ((currentUser.StartsWith("<Admin>")) && (currentUser != string.Empty))
                return true;
            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Establish current Admin.</summary>
        /// <param name="currentUser">Name of current user.</param>
        /// <returns>Boolean confirming success.</returns>
        private bool SetCurrentAdmin(string currentUser)
        {
            if (currentUser.Length > 8)
            {
                currentUser = currentUser.Remove(0, 8);
                currentAdmin = FindAdmin(currentUser);
            }
            if (currentAdmin != null)
            {
                currentUser = String.Concat("<Admin> ", currentUser);
                return true;
            }

            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 3/13/14                                                                                //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Validate admin's password input.</summary>
        /// <returns>Boolean confirming password.</returns>
        public bool isCorrectAdminPassword()
        {
            if (currentAdmin != null)
            {
                if (currentAdmin.Password == currentPassword)
                    return true;
                else
                    ClearAdminUser();
            }
            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/1/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Check if selection is student.</summary>
        /// <returns>Boolean confirmation.</returns>
        public bool isStudent()
        {
            if (!(currentUser.StartsWith("<Admin>")) && (currentUser != string.Empty))
                return true;
            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Establish current student.</summary>
        /// <param name="currentUser">Name of current user.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool SetCurrentStudent(string currentUser) 
        {
            currentStudent = FindStudent(currentUser);
            if (currentStudent != null)
                return true;

            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Validate user as admin, and navigate to admin home.</summary>
        /// <returns>Boolean confirmation.</returns>
        public bool validateAdmin()
        {
            bool isValidAdmin = SetCurrentAdmin(currentUser);
            if (isValidAdmin)
            {
                SetWindow(Window.adminHome);
                return true;
            }
            else
                ClearAdminUser();
           
            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                                            //
        // Date: 4/3/14                                                                                 //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Validate user as admin, and navigate to admin home.</summary>
        /// <returns>Boolean confirmation.</returns>
        public bool validateStudent()
        {
            bool isValidStudent = SetCurrentStudent(currentUser);
            if (isValidStudent)
            {
                SetWindow(Window.stuHome);
                return true;
            }  
            else
                ClearStudentUser();

            return false;
        }
        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/26/2014                                                  //
        // Finds a selected student in the list, to populate drill settings //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Find an existing student object.</summary>
        /// <param name="currentUser">Actuive user name.</param>
        /// <returns>Student</returns>
        public Student FindStudent(string currentUser)
        {
            //Student aStudent = new Student();
            Student aStudent = studentList.Where(stu => stu.LoginName.Equals(currentUser)).FirstOrDefault();
            if(aStudent != null)
            {
                studentList.Remove(aStudent);
            }
            /*foreach (Student student in studentList)
            {
                if (student.LoginName == currentUser)
                {
                    aStudent = student;
                    studentList.Remove(student);
                    break;
                }
            }*/
            return aStudent;
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/26/2014                                                  //
        // Find selected admin to populate last login                       //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Find and existing admin object.</summary>
        /// <param name="currentUser">Active user name.</param>
        /// <returns>Admin</returns>
        public Admin FindAdmin(string currentUser)
        {
            //Admin aAdmin = new Admin();
            Admin aAdmin = aAdmin = adminList.Where(admin => admin.LoginName.Equals(currentUser)).FirstOrDefault();
            if (aAdmin != null)
            {
                adminList.Remove(aAdmin);
            }
            /*foreach (Admin admin in adminList)
            {
                if (admin.LoginName == currentUser)
                {
                    aAdmin = admin;
                    adminList.Remove(admin);
                    break;
                }
                else
                    continue;
            }*/

            return aAdmin;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        // Updates the user's last login date                               //
        //------------------------------------------------------------------//
        public void SaveLoginDate(string fileName, string userName, string date, bool isAdmin = false)
        {
            XMLDriver.WriteLogin(fileName, userName, date, isAdmin);
            currentUserLogin = date;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Clears local data current student object.</summary>
        public void ClearStudentUser()
        {
            if(currentStudent != null)
            {
                currentStudent.LastLogin = currentUserLogin;
                studentList.Add(currentStudent);
                currentStudent = new Student(); // Clear student
            }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Clears local data current admin object.</summary>
        public void ClearAdminUser()
        {
            if (currentAdmin != null)
            {
                currentAdmin.LastLogin = currentUserLogin;
                adminList.Add(currentAdmin);
                currentAdmin = new Admin(); // Clear admin
            }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        //------------------------------------------------------------------//
        public string GetNumQuestions()
        {
            string currentQuestions = currentStudent.curDrill.Questions;
            currentQuestions = String.Concat(currentQuestions, " questions.");
            return currentQuestions;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        //------------------------------------------------------------------//
        public string GetCurrentNumber()
        {
            return currentProblemNumber.ToString();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        //------------------------------------------------------------------//
        public string UpdateCurrentNumber()
        {
            currentProblemNumber++;
            return currentProblemNumber.ToString();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public bool ReachesEnd(string currentNumber, string rangeEnd)
        {
            if (currentNumber == rangeEnd)
                return true;
            else
                return false;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        //------------------------------------------------------------------//
        public void ResetCurrentNumber()
        {
            currentProblemNumber = 1;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        // Purpose: Generate a random number between the set parameters.    //
        //------------------------------------------------------------------//
        public string CreateRandom()
        {
            // NOTE: Check if the range makes mathematical sense.
            //       ex) Start = 5, End = -1
            //       Maybe move this checking to the Admin side?         
            string startRange = currentStudent.curDrill.RangeStart;
            string endRange = currentStudent.curDrill.RangeEnd;

            // NOTE: We add one to whatever the RangeEnd is due to the way random.Next functions
            //       ex) random.Next(1, 11) generates a number between 1 and 11.
            int randomNumber = random.Next(Convert.ToInt32(startRange), Convert.ToInt32(endRange) + 1);
            return randomNumber.ToString();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public string GetOperand()
        {
            // NOTE: Error if no operand or mislabeled
            if (currentStudent.curDrill.Operand == "addition")
                return "+";
            else
                return "-";
        }

        //------------------------------------------------------------------//
        // Joshua Boone                                                     //
        // Date: 3/6/2014                                                   //
        //------------------------------------------------------------------//
        public bool IsOverFlow(string number)
        {
            bool overFlow = false;
            int z = 0;
            try
            {
                // The following line raises an exception because it is checked.
                z = checked(Convert.ToInt32(number) + 0);
            }
            catch (System.OverflowException e)
            {
                overFlow = true;
            }

            return overFlow;
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public bool NoTextEntered(string enteredText)
        {
            if (enteredText == "")
                return true;
            else
                return false;
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public bool ContainsInvalid(string enteredText)
        {
            bool test = false;
            int iter = 0;
            // NOTE: Currently the user is allowed to just enter '-'.
            //       Trying to figure out how to allow negatives.
            foreach (char c in enteredText)
            {
                if (((c < '0') || (c > '9')) && ((c != '-') || (iter != 0)))
                    test = true;
                iter++;
            }

            // Check: If first is a negative sign, there has to be a number after it
            if ((enteredText.ElementAt(0) == '-') && (enteredText.Length < 2))
                test = true;

            return test;
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public bool IsValidEntry(string userInput)
        {
            if ((NoTextEntered(userInput)) || (ContainsInvalid(userInput)) || IsOverFlow(userInput))
                return false;
            else
                return true;
        }

        // DEPRICATED
        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/25/2014                                                  //
        //------------------------------------------------------------------//
        public bool IsCorrectAnswer(string startRange, string endRange, string userInput)
        {
            int start = Convert.ToInt32(startRange);
            int end = Convert.ToInt32(endRange);
            int input = Convert.ToInt32(userInput);
            int additionEq = start + end;
            int subtractionEq = start - end;

            if ((additionEq == input) || (subtractionEq == input))
                return true;
            else
                return false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        public int CurrSolution
        {
            get { return currSolution; }
            set { currSolution = value;  }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Composes the string that will provide the user the 
        /// math problem for their current drill problem.</summary>
        /// <returns>String</returns>
        public string genMathProb()
        {
            string mathProb;
            int solution;

            string operand1 = CreateRandom();
            string operand2 = CreateRandom();

            solution = calcSolution(Convert.ToInt32(operand1), Convert.ToInt32(operand2));
            // if solution is not neg
            if (solution >= 0)
            {
                mathProb = String.Concat(operand1, " ", GetOperand(), " ", operand2, " ="); // adjust: GetOperand()
            }
            // else if solution is neg
            else
            {
                // invert operand arguments for calculation
                solution = calcSolution(Convert.ToInt32(operand2), Convert.ToInt32(operand1));
                mathProb = String.Concat(operand2, " ", GetOperand(), " ", operand1, " ="); // adjust: GetOperand()
            }

            CurrSolution = solution;

            return mathProb;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Derive the solution of a mathematical operation.
        /// </summary>
        /// <param name="value1">First operand.</param>
        /// <param name="value2">Second operand.</param>
        /// <returns>Integer</returns>
        public int calcSolution(int value1, int value2)
        {
            int solution = 0;

            switch (GetOperand())
            {
                case "+": // addition
                    solution = value1 + value2;
                    break;
                case "-": // subtraction
                    solution = value1 - value2;
                    break;
                case "*": // multiplication
                    solution = value1 * value2;
                    break;
                case "/": // division
                    solution = value1 / value2;
                    break;
                default:
                    break;
            }

            return solution;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/7/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Compare user's input with precalculated solution.
        /// </summary>
        /// <param name="userInput">User's input.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool IsCorrectAnswer(string userInput)
        {
            int input = Convert.ToInt32(userInput);

            if (CurrSolution == input)
                return true;
            else
                return false;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public bool IsCompletedSession(string totalQuestions)
        {
            if (Convert.ToInt32(totalQuestions) == currentProblemNumber)
                return true;
            else
                return false;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Save drill data to XML.</summary>
        public void SaveDrill()
        {
            currentStudent.curDrill.Percent = CalculatePercentage();
            XMLDriver.WriteCurrentSession(currentStudent, currentStudent.curDrill);
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        /*public void AddNewRecordToList()
        {
            Record newRecord = new Record();
            newRecord.DateTaken = DateTime.Now.ToString("M/d/yyyy");
            newRecord.Question = currentStudent.curDrill.CurQuestions;
            newRecord.RangeStart = currentStudent.curDrill.CurRangeStart;
            newRecord.RangeEnd = currentStudent.curDrill.CurRangeEnd;
            newRecord.Operation = currentStudent.curDrill.CurOperand;
            newRecord.Wrong = currentStudent.curDrill.CurWrong;
            newRecord.Percent = currentStudent.curDrill.curPercent;
            currentStudent.reportList.Add(newRecord);
        }*/

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public string CalculatePercentage()
        {
            float wrong = float.Parse(currentStudent.curDrill.Wrong);
            float totalNumber = float.Parse(currentStudent.curDrill.Questions);
            float percentage = 100 - ((wrong / totalNumber) * 100);
            return percentage.ToString();
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 3/10/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Fill a list of student objects.</summary>
        /// <returns>List<String></returns>
        public List<String> GetStudents()
        {
            // NOTE: In future releases, we will use this to populate student records
            //       so each admin can be used to get only their students
            // Error list: If student list is empty, no students
            List<String> students = new List<String>();

            foreach (Student student in studentList)
                students.Add(student.LoginName);

            students.Sort();
            return students;
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer, Kyle Bridges                                    //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public bool InvalidDrillFields(string minOperand, string maxOperand, string setSize)
        {
            // Check min and max size
            if ((IsValidEntry(minOperand)) && (IsValidEntry(maxOperand)) && (IsValidEntry(setSize)))
                return false;
            else
                return true;
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/28/2014                                                  //
        //------------------------------------------------------------------//
        public bool InvalidStudentSelection(string studentName)
        {
            if ((studentName == "") || (studentName == "Unknown") || (studentName == null))
                return true;
            else
                return false;

        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public bool InvalidRadioButtons(bool subtract, bool add)
        {
            if (!subtract && !add)
                return true;
            else
                return false;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/28/2014                                                  //
        //------------------------------------------------------------------//
        public bool InvalidRange(string min, string max)
        {
            if (Convert.ToInt32(min) >= Convert.ToInt32(max))
                return true;
            else
                return false;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 3/1/2014                                                   //
        //------------------------------------------------------------------//
        public bool InvalidQuestionCount(string size)
        {
            if (Convert.ToInt32(size) <= 0)
                return true;
            else
                return false;
        }


        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/28/2014                                                  //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Spell out operator type.</summary>
        /// <param name="add">True if addition.</param>
        /// <param name="subtract">True if Subtraction.</param>
        /// <returns>String</returns>
        public string SetOperand(bool add, bool subtract)
        {
            string operand = string.Empty;
            if (add == true)
                operand = "addition";
            else if (subtract == true)
                operand = "subtraction";
            return operand;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/28/2014                                                  //
        //------------------------------------------------------------------//
        /*public void SaveDrillSettings(string minOperand, string maxOperand, string questionCount)
        {
            XML.WriteDrillSettings(currentStudent.LoginName, minOperand, maxOperand, questionCount, operand);
            UpdateLocalDrillSettings(currentStudent, minOperand, maxOperand, questionCount, operand);
            ClearStudentUser();
        }*/

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 3/1/2014                                                   //
        //------------------------------------------------------------------//
        /*public void UpdateLocalDrillSettings(Student student, string minOp, string maxOp, string size, string op)
        {
            student.curDrill.CurQuestions = size;
            student.curDrill.CurRangeStart = minOp;
            student.curDrill.CurRangeEnd = maxOp;
            student.curDrill.CurOperand = op;
        }*/

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/28/2014                                                  //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/3/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Fill list of record objects.</summary>
        /// <param name="first">Early time boundary.</param>
        /// <param name="second">Late time boundary.</param>
        /// <param name="studentName">Student's name.</param>
        /// <returns>List<Record></returns>
        public List<Record> GenerateRecord(DateTime first, DateTime second, string studentName)
        {
            Student student = FindStudentWithName(studentName);
            string date;
            List<Record> recordList = new List<Record>();
            foreach (Record record in student.curRecordList)
            {
                date = record.DateTaken;
                if ((DateTime.Parse(date) >= first) && (DateTime.Parse(date) <= second))
                    recordList.Add(record);
            }

            return recordList;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        //------------------------------------------------------------------//
        public Student FindStudentForReport(string currentUser)
        {
            Student aStudent = new Student();

            foreach (Student student in studentList)
            {
                if (student.LoginName == currentUser)
                {
                    aStudent = student;
                    break;
                }
            }

            return aStudent;
        }

        //------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                         //
        // Date: 4/8/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Generate average percent, average wrong, average skipper</summary>
        /// <param name="first">Start date</param>
        /// <param name="second">End date</param>
        /// <param name="group">Group to generate report</param>
        /// <returns>Tuple that contains the group name, avg percent, avg skipped, numberOfSets</returns>
        public Tuple<string, float, float, float, int> GenerateRecordForGroup(DateTime first, DateTime second, Group group)
        {
            string date;
            List<Record> recordList = new List<Record>();
            List<Student> listOfStudentsInGroup = new List<Student>();
            
            foreach (Student student in studentList)
            {
                if (student.GroupID == group.ID)
                    listOfStudentsInGroup.Add(student);
            }
            int numberOfSets = 0;
            float totalPercent = 0.0f;
            int totalWrong = 0;
            int totalSkipped = 0;
            int numberOfStudents = listOfStudentsInGroup.Count;
            foreach(Student studentInGroup in listOfStudentsInGroup)
            {
                foreach (Record record in studentInGroup.curRecordList)
                {
                    date = record.DateTaken;
                    if ((DateTime.Parse(date) >= first) && (DateTime.Parse(date) <= second))
                    {
                        numberOfSets += 1;
                        totalPercent += float.Parse(record.Percent);
                        totalWrong += Convert.ToInt32(record.Wrong);
                        totalSkipped += Convert.ToInt32(record.Skipped);
                    }
                }
            }
            if (numberOfStudents > 0)
            {
                float avgPercent = (totalPercent / numberOfSets) / numberOfStudents;
                float avgWrong = totalWrong / numberOfStudents;
                float avgSkipped = totalSkipped / numberOfStudents;
                return Tuple.Create(group.Name, avgPercent, avgWrong, avgSkipped, numberOfSets);
            }
            else
                return Tuple.Create(group.Name, 0f, 0f, 0f, 0);
            
            //return recordList;
        }

        //------------------------------------------------------------------//
        // Authors: Joshua Boone and Justine Dinh                           //
        // Date: 4/12/14                                                    //
        //------------------------------------------------------------------//
        /// <summary>Returns if there are group reocords in a picked date range</summary>
        /// <param name="first">Start date</param>
        /// <param name="second">End date</param>
        /// <param name="group">Group to generate report</param>
        /// <returns>Whether there are records for this group in the given date range</returns>
        public bool IsRecordInRangeGroup(DateTime first, DateTime second, Group group)
        {
            string date;
            bool recordsExist = false;
            List<Record> recordList = new List<Record>();
            List<Student> listOfStudentsInGroup = new List<Student>();

            foreach (Student student in studentList)
            {
                if (student.GroupID == group.ID)
                {
                    listOfStudentsInGroup.Add(student);
                }
            }
            foreach (Student studentInGroup in listOfStudentsInGroup)
            {
                foreach (Record record in studentInGroup.curRecordList)
                {
                    date = record.DateTaken;
                    if ((DateTime.Parse(date) >= first) && (DateTime.Parse(date) <= second))
                    {
                        recordsExist = true;
                        break;
                    }
                }
            }

           return recordsExist;
        }
    }
}
