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
    public enum Window { authUser, adminHome, adminReport, stuHome
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
        public string reportStudent = string.Empty;
        XMLParser XML = new XMLParser();
        XMLDriver XMLDriver = new XMLDriver();

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Drill object default constructor.</summary>
        public Manager()
        {

            string AppData = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            dataDirectory = System.IO.Path.Combine(AppData, "RaptorMath");
            if (!System.IO.Directory.Exists(dataDirectory))
                System.IO.Directory.CreateDirectory(dataDirectory);
            string adminFile = "RaptorMathRaptorMathAdmins.xml";
            string studentFile = "RaptorMathStudents.xml";
            string groupFile = "RaptorMathGroups.xml";
            string drillFile = "RaptorMathDrills.xml";
            adminXMLPath = System.IO.Path.Combine(dataDirectory, adminFile);
            studentXMLPath = System.IO.Path.Combine(dataDirectory, studentFile);
            groupXMLPath = System.IO.Path.Combine(dataDirectory, groupFile);
            drillXMLPath = System.IO.Path.Combine(dataDirectory, drillFile);
            Console.WriteLine(adminXMLPath);
            Console.WriteLine(studentXMLPath);
            Console.WriteLine(groupXMLPath);
            Console.WriteLine(drillXMLPath);
            Console.WriteLine(dataDirectory);
            XMLDriver localXMLDriver = new XMLDriver(adminXMLPath, studentXMLPath, groupXMLPath, drillXMLPath, dataDirectory);
            XMLDriver = localXMLDriver;
            //XML.LoadXML(studentList, adminList);
            XMLDriver.StartUp(adminList, studentList, groupList, mainDrillList);
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Validation of group data input.</summary>
        /// <param name="groupToValidate">Group object to validate.</param>
        /// <returns>Boolean confirming validity.</returns>
        public bool isGroupInfoValid(string groupToValidate)
        {
            if (!(groupToValidate.Equals(string.Empty))
                && (groupToValidate.All(char.IsLetterOrDigit)))
            {
                return true;
            }
            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Validation of drill data input.</summary>
        /// <param name="drillToValidate">Drill object to validate.</param>
        /// <returns>Boolean confirming validity.</returns>
        public bool isDrillInfoValid(Drill drillToValidate)
        {
            if (!(drillToValidate.DrillName.Equals(string.Empty))
                && (drillToValidate.DrillName.All(char.IsLetterOrDigit))
                && (drillToValidate.Questions.All(char.IsDigit))
                && (drillToValidate.RangeStart.All(char.IsDigit) && (Convert.ToInt32(drillToValidate.RangeStart) > 0))
                && (drillToValidate.RangeEnd.All(char.IsDigit) && (Convert.ToInt32(drillToValidate.RangeEnd) > 0))
                && (drillToValidate.Operand.Equals("subtraction") || (drillToValidate.Operand.Equals("addition"))))
            {
                return true;
            }
            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Adjust student information.</summary>
        /// <param name="newFName">Student's new first name.</param>
        /// <param name="newLName">Student's new last name.</param>
        /// <param name="currentName">Student's current full name.</param>
        /// <param name="newGroup">Student's new group name.</param>
        /// <param name="studentList">List containing student objects.</param>
        /// <param name="groupList">List containing group objects.</param>
        public bool RenameStudent(string newFName, string newLName, string currentName, string newGroup, List<Student> studentList, List<Group> groupList)
        {
            Tuple<bool, bool> GroupStudentChanged = new Tuple<bool, bool>(false, false);
            /*if ((newFName.Equals(string.Empty) || (newFName.All(char.IsLetter)))
                && (newLName.Equals(string.Empty) || (newLName.All(char.IsLetter)))
                && !(currentName.Equals(string.Empty))
                && (currentName.Replace(" ", string.Empty).All(char.IsLetter))
                && (newGroup.Equals(string.Empty) || (newGroup.All(char.IsLetterOrDigit))))*/
            if (currentName.Replace(" ", string.Empty).All(char.IsLetter)
                && !(currentName.Equals(string.Empty))
                && !((newFName.Equals(string.Empty)) && (newLName.Equals(string.Empty)) && (newGroup.Equals(string.Empty))))
            {
                Student selectedStudent = FindStudentWithName(currentName);
                if (selectedStudent != null)
                {
                    Group selectedGroup = FindGroupByName(newGroup);
                    Group oldGroup = FindGroupByID(selectedStudent.GroupID);
                    //bool hasGroupChanged = XMLDriver.editStudent(newFName, newLName, selectedStudent, selectedGroup, studentList);
                    GroupStudentChanged = XMLDriver.editStudent(newFName, newLName, selectedStudent, selectedGroup, studentList);
                    if (GroupStudentChanged.Item1)
                    {
                        RemoveGroupDrillsFromStudent(oldGroup, selectedStudent);
                        AddGroupDrillsToStudent(selectedGroup, selectedStudent);
                    }
                    return GroupStudentChanged.Item2;
                }
            }
            return GroupStudentChanged.Item2;
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Adjust group information.</summary>
        /// <param name="newName">Group's new name.</param>
        /// <param name="currentName">Group's current name.</param>
        /// <param name="groupList">List of group objects.</param>
        public void RenameGroup(string newName, string currentName, List<Group> groupList)
        {
            if (!(newName.Equals(string.Empty))
                && (newName.All(char.IsLetterOrDigit))
                && !(currentName.Equals(string.Empty))
                && (currentName.All(char.IsLetterOrDigit)))
            {
                XMLDriver.editGroup(newName, currentName, groupList);
            }
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Remove user from data set.</summary>
        /// <param name="userName">User's name.</param>
        public void removeUser(string userName)
        {
            bool isAdmin = adminList.Any(admin => admin.LoginName.Equals(userName.Remove(0, 8)));
            if (isAdmin)
            {
                Admin admin = adminList.Where(adm => adm.LoginName.Equals(userName.Remove(0, 8))).FirstOrDefault();
                if(admin != null)
                    XMLDriver.Delete(admin, adminList);
                /*TODO: else
                    throw error*/
            }
            bool isStudent = studentList.Any(student => student.LoginName.Equals(userName));
            if(isStudent)
            {
                Student student = studentList.Where(stu => stu.LoginName.Equals(userName)).FirstOrDefault();
                if(adminList != null)
                    XMLDriver.Delete(student, studentList);
                /*TODO: else
                    throw error*/
            }
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Search dataset for a group ID with group's name.</summary>
        /// <param name="GroupName">Group's name.</param>
        /// <returns>Group ID.</returns>
        public int FindGroupIDByName(string GroupName)
        {
            Group foundGroup = groupList.Where(grp => grp.Name.Equals(GroupName)).FirstOrDefault();
            if (foundGroup == null)
                return 0;
            return (foundGroup.ID);
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Add all group's drills to student's XML file.</summary>
        /// <param name="group">Group object acting as source.</param>
        /// <param name="student">Student object to be modified.</param>
        public void AddGroupDrillsToStudent(Group group, Student student)
        {
            foreach(Drill drill in group.groupDrillList)
            {
                AddDrillToStudent(student, drill);
            }
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Remove all group's drills from student's XML file.</summary>
        /// <param name="group">Group object acting as source.</param>
        /// <param name="student">Student object to be modified.</param>
        public void RemoveGroupDrillsFromStudent(Group group, Student student)
        {
            foreach (Drill drill in group.groupDrillList)
            {
                RemoveDrillFromStudent(student, drill);
            }
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Get data on all students associated with a group.</summary>
        /// <param name="groupID">Group acting as source.</param>
        /// <returns>List of student objects.</returns>
        public List<Student> FindStudentsByGroupID(int groupID)
        {
            return studentList.Where(stu => stu.GroupID.ToString().Equals(groupID.ToString())).ToList();
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Check running status of program.</summary>
        /// <returns>Boolean confirming running status.</returns>
        public bool IsRunning()
        {
            return (programRunning);
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Access form.</summary>
        /// <returns>Form object being accessed.</returns>
        public Window GetWindow()
        {
            return (form);
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Set status of program to not running.</summary>
        public void SetIsRunningFalse()
        {
            programRunning = false;
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Set window object.</summary>
        /// <param name="newForm">Window to be established.</param>
        public void SetWindow(Window newForm)
        {
            form = newForm;
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        public bool isAdmin()
        {
            if ((currentUser.StartsWith("<Admin>")) && (currentUser != string.Empty))
                return true;
            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>Establish current Admin.</summary>
        /// <param name="currentUser">Name of current user.</param>
        /// <returns>Boolean confirming success.</returns>
        private bool SetCurrentAdmin(string currentUser)
        {
            currentUser = currentUser.Remove(0, 8);
            currentAdmin = FindAdmin(currentUser);
            if (currentAdmin != null)
            {
                currentUser = String.Concat("<Admin> ", currentUser);
                return true;
            }

            return false;
        }

        //----------------------------------------------------------------------------------------------//
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
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
        // Cody Jordan, Cian Carota                                                                     //
        // Date:                                                                                        //
        //----------------------------------------------------------------------------------------------//
        /// <summary>alidate user as admin, and navigate to admin home.</summary>
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
        // Date: 3/6/2014                                                  //
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

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/25/2014                                                  //
        //------------------------------------------------------------------//
        public bool IsCorrectAnswer(string startRange, string endRange, string userInput)
        {
            Console.WriteLine("Checking IsCorrectAnswer");
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
**need to fix drills**
            student.curDrill.CurQuestions = size;
            student.curDrill.CurRangeStart = minOp;
            student.curDrill.CurRangeEnd = maxOp;
            student.curDrill.CurOperand = op;
        }*/

        //------------------------------------------------------------------//
        // Kyle Bridges, Harvey Kreitzer                                    //
        // Date: 2/28/2014                                                  //
        //------------------------------------------------------------------//
        public List<Record> GenerateRecord(DateTime first, DateTime second, string studentName)
        {
            Student student = FindStudentWithName(studentName);
            string date;
            List<Record> recordList = new List<Record>();
            foreach (Record record in student.curRecordList)
            {
                Console.WriteLine(student.curDrillList.Count.ToString());
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
    }
}
