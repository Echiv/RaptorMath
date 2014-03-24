﻿//==============================================================//
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
    public enum Window { authUser, adminHome, adminReport, stuHome, stuDrill, mngUsers };
    public class Manager
    {
        Window form = Window.authUser;
        bool programRunning = true;
        public string currentUser = string.Empty;
        public string currentPassword = string.Empty;
        public string currentUserLogin = string.Empty;
        public string operand = string.Empty;
        public string dataDir = string.Empty;
        public string adminXMLPath = string.Empty;
        public string studentXMLPath = string.Empty;
        public int currentProblemNumber = 1;
        public List<Student> studentList = new List<Student>();
        public List<Admin> adminList = new List<Admin>();
        public List<String> groupList = new List<string>();
        public Student currentStudent = new Student();
        public Admin currentAdmin = new Admin();
        public Random random = new Random();
        XMLParser XML = new XMLParser();

        public Manager()
        {
            dataDir = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            string adminFile = "RaptorMathAdmins.xml";
            string studentFile = "RaptorMathStudents.xml";
            adminXMLPath = System.IO.Path.Combine(dataDir, adminFile);
            studentXMLPath = System.IO.Path.Combine(dataDir, studentFile);
            //XML.LoadXML(studentList, adminList);
            XML.StartUp(adminList, adminXMLPath, studentList, studentXMLPath, groupList);
        }

        public bool CreateUser(string adminName, string password, string LastLogin, string filePath)
        {
            Admin newAdmin = new Admin(adminName, password, LastLogin, filePath);
            bool isCreatedUser = XML.AddUserToXML(adminXMLPath, adminList, newAdmin);
            return isCreatedUser;
        }

        public bool CreateUser(string group, string studentName, string lastLogin)
        {
            Student newStudent = new Student(group, studentName, lastLogin);
            bool isCreatedUser = XML.AddUserToXML(studentXMLPath, studentList, newStudent, groupList);
            return isCreatedUser;
        }

        public bool IsRunning()
        {
            return (programRunning);
        }

        public Window GetWindow()
        {
            return (form);
        }

        public void SetIsRunningFalse()
        {
            programRunning = false;
        }

        public void SetWindow(Window newForm)
        {
            form = newForm;
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

        public List<String> GetGroups()
        {
            List<String> groups = new List<String>();

            foreach (String group in groupList)
                groups.Add(group);
            groups.Sort();
            return groups;
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/26/2014                                                  //
        // Checks if the selected user is an admin, returns bool            //
        //------------------------------------------------------------------//
        public bool isAdmin()
        {
            if (currentUser.StartsWith("<Admin>"))
            {
                return true;
            }
            return false;
        }

        private void SetCurrentAdmin(string currentUser)
        {
            if (currentUser.StartsWith("<Admin>"))
            {
                currentUser = currentUser.Remove(0, 8);
                currentAdmin = FindAdmin(currentUser);
                currentUser = String.Concat("<Admin> ", currentUser);
            }
        }

        public bool isCorrectAdminPassword()
        {
            if (currentAdmin.Password == currentPassword)
                return true;
            return false;
        }

        public bool isStudent()
        {
            if (!currentUser.StartsWith("<Admin>"))
                return true;
            return false;
        }

        public void SetCurrentStudent(string currentUser)
        {
            if (!currentUser.StartsWith("<Admin>"))
            {
                currentStudent = FindStudent(currentUser);
            }
        }

        public bool grantAccess()
        {
            if (isAdmin() == true)
            {
                SetCurrentAdmin(currentUser);
                if (isCorrectAdminPassword() == true)
                {
                    SetWindow(Window.adminHome);
                    return true;
                }
                else
                    ClearAdminUser();
            }
            else if (isStudent() == true)
            {
                SetCurrentStudent(currentUser);
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
            Student aStudent = new Student();

            foreach (Student student in studentList)
            {
                if (student.LoginName == currentUser)
                {
                    aStudent = student;
                    studentList.Remove(student);
                    break;
                }
            }
            return aStudent;
        }

        //------------------------------------------------------------------//
        // Harvey Kreitzer                                                  //
        // Date: 2/26/2014                                                  //
        // Find selected admin to populate last login                       //
        //------------------------------------------------------------------//
        public Admin FindAdmin(string currentUser)
        {
            Admin aAdmin = new Admin();

            foreach (Admin admin in adminList)
            {
                if (admin.LoginName == currentUser)
                {
                    aAdmin = admin;
                    adminList.Remove(admin);
                    break;
                }
                else
                    continue;
            }

            return aAdmin;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        // Updates the user's last login date                               //
        //------------------------------------------------------------------//
        public void SaveLoginDate(string fileName, string userName, string date, bool isAdmin = false)
        {
            XML.WriteLogin(fileName, userName, date, isAdmin);
            currentUserLogin = date;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        //------------------------------------------------------------------//
        public void ClearStudentUser()
        {
            currentStudent.LastLogin = currentUserLogin;
            studentList.Add(currentStudent);
            currentStudent = new Student(); // Clear student
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        public void ClearAdminUser()
        {
            currentAdmin.LastLogin = currentUserLogin;
            adminList.Add(currentAdmin);
            currentAdmin = new Admin(); // Clear student
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        //------------------------------------------------------------------//
        /*public string GetNumQuestions()
        {
**need to fix drills**
            string currentQuestions = currentStudent.curDrill.CurQuestions;
            currentQuestions = String.Concat(currentQuestions, " questions.");
            return currentQuestions;
        }*/

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

        /*public string CreateRandom()
        {
            // NOTE: Check if the range makes mathematical sense.
            //       ex) Start = 5, End = -1
            //       Maybe move this checking to the Admin side?
**need to fix drills**            
            string startRange = currentStudent.curDrill.CurRangeStart;
            string endRange = currentStudent.curDrill.CurRangeEnd;

            // NOTE: We add one to whatever the RangeEnd is due to the way random.Next functions
            //       ex) random.Next(1, 11) generates a number between 1 and 11.
            int randomNumber = random.Next(Convert.ToInt32(startRange), Convert.ToInt32(endRange) + 1);
            return randomNumber.ToString();
        }*/

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        /*public string GetOperand()
        {
**need to fix drills**
            // NOTE: Error if no operand or mislabeled
            if (currentStudent.curDrill.CurOperand == "addition")
                return "+";
            else
                return "-";
        }*/

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
        /*public void SaveDrill()
        {
**need to fix drills**
            currentStudent.curDrill.curPercent = CalculatePercentage();
            XML.WriteCurrentSession(currentStudent.DrillsPath, currentStudent.LoginName, currentStudent.curDrill);
            AddNewRecordToList();
        }*/

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        //------------------------------------------------------------------//
        /*public void AddNewRecordToList()
        {
**need to fix drills**
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
        /*public string CalculatePercentage()
        {
**need to fix drills**
            float wrong = float.Parse(currentStudent.curDrill.CurWrong);
            float totalNumber = float.Parse(currentStudent.curDrill.CurQuestions);
            float percentage = 100 - ((wrong / totalNumber) * 100);
            return percentage.ToString();
        }*/

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
        public void SetOperand(bool add, bool subtract)
        {
            if (add == true)
                operand = "addition";
            else if (subtract == true)
                operand = "subtraction";
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/28/2014                                                  //
        //------------------------------------------------------------------//
        /*public void SaveDrillSettings(string stuName, string minOperand, string maxOperand, string setSize)
        {
**need to fix drills**
            currentStudent = FindStudent(stuName);
            XML.WriteDrillSettings(currentStudent.LoginName, currentStudent.DrillsPath, minOperand, maxOperand, setSize, operand);
            UpdateLocalDrillSettings(currentStudent, minOperand, maxOperand, setSize, operand);
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
        public List<Record> GenerateRecord(DateTime first, DateTime second)
        {
            string date;
            List<Record> recordList = new List<Record>();
            foreach (Record record in currentStudent.reportList)
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
    }
}
