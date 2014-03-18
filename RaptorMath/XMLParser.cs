//==============================================================//
//					      XMLParser.cs				            //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Kyle Bridges and Harvey Kreitzer                    //
// Purpose: This class is called by the Manager whenever any    //
//          direct parsing of the XML needs to be handled. It   //
//          contains functions that read and write to both the  //
//          student and admin XMLs, parse the current student's //
//          settings, and properly stores the results back      //
//          into their respective XML files.                    //
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
    public class XMLParser
    {
        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        // Checks if the file exists, returns bool                          //
        //------------------------------------------------------------------//
        public bool FileExists(string fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                MessageBox.Show("XML access error. Please redownload the application.", "Raptor Math", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
        
        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/12/2014                                                  //
        // Loads XML to manager list of admins calls LoadStudentXML function//
        //------------------------------------------------------------------//
        /*public void LoadXML(List<Student> studentList, List<Admin> adminList)
        {
            if (!FileExists(adminFile))
                Environment.Exit(1);

            else
            {
                XDocument adminXML = XDocument.Load(adminFile);

                foreach (XElement admin in adminXML.Root.Nodes())
                {
                    Admin administrator = new Admin();
                    administrator.LoginName = admin.Element("loginName").Value;
                    administrator.Password = admin.Element("password").Value;
                    administrator.LastLogin = admin.Element("lastLogin").Value;
                    administrator.FilePath = admin.Element("path").Value;
                    administrator.adminStudents = studentList;
                    LoadStudentXML(administrator.FilePath, studentList);
                    //                studentList = adminList;
                    // Add to admin list
                    adminList.Add(administrator);
                }
            }
        }*/

        public bool adminXMLExists(string fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                return false;
            }
            return true;
        }

        public void StartUp(List<Admin> adminList, string adminXMLPath)
        {
            //AdminXML should contain all admin information
            //Should find AdminXML in C://App Data
            if (!adminXMLExists(adminXMLPath))
                InitialCreateAdminXML(adminXMLPath);

            XDocument adminXML = XDocument.Load(adminXMLPath);

            Console.WriteLine("StartUP");
            Console.WriteLine(adminXML.Root);
            LoadAdminXML(adminList, adminXML);
        }

        private void InitialCreateAdminXML(string adminXMLPath)
        {
            XDocument adminXML =
                new XDocument(
                    new XElement("RaptorMathAdmin",
                        new XElement("admin",
                            new XElement("loginName", "Admin"),
                            new XElement("password", "Admin"),
                            new XElement("path", "RaptorMathStudents.xml"),
                            new XElement("lastLogin", DateTime.Now.ToString("M/d/yyyy")))));
            adminXML.Save(adminXMLPath);
        }

        public void LoadAdminXML(List<Admin> adminList, XDocument adminXML)
        {
            foreach (XElement admin in adminXML.Root.Nodes())
            {
                Admin administrator = new Admin();
                administrator.LoginName = admin.Element("loginName").Value;
                administrator.Password = admin.Element("password").Value;
                administrator.LastLogin = admin.Element("lastLogin").Value;
                administrator.FilePath = admin.Element("path").Value;
                adminList.Add(administrator);
            }
        }

        public void InitialCreateStudentXml(string studentXMLPath, List<Student> studentList, Student newStudentEntry)
        {
            

            XDocument studentXML =
                new XDocument(
                    new XElement("RaptorMathStu",
                /* Group node that is initially Unassigned but can be assigned by teacher on creation*/
                        new XElement(newStudentEntry.Group,
                            new XElement("stu",
                                new XElement("loginName", newStudentEntry.LoginName),
                                new XElement("lastLogin", newStudentEntry.LastLogin),
                /*Path to RaptorMathStudents XML*/
                //new XElement("stuPath", "Unknown"),
                /*Path to this students records XML*/
                                new XElement("recPath", newStudentEntry.RecordsPath),
                                /*Path to this students drill XML*/
                                new XElement("driPath", newStudentEntry.DrillsPath)))));
            Console.WriteLine("InitialCreateStudentXml", studentXML.Root.Nodes().ToString());
            studentXML.Save(studentXMLPath);
            
        }

        public void AddUserToXML(string adminXMLPath, List<Admin> adminList, Admin newAdminEntry)
        {
            adminList.Add(newAdminEntry);
            XDocument adminXML = XDocument.Load(adminXMLPath);

            Console.WriteLine("AddUserToXML");
            foreach (XElement admin in adminXML.Root.Nodes())
            {
                if (admin.Element("loginName").Value != newAdminEntry.LoginName)
                {
                    XElement newAdmin =
                        new XElement("admin",
                                    new XElement("loginName", newAdminEntry.LoginName),
                                    new XElement("password", newAdminEntry.Password),
                                    new XElement("path", newAdminEntry.FilePath),
                                    new XElement("lastLogin", newAdminEntry.LastLogin));

                    adminXML.Add(newAdmin);
                }
            }
        }

        public void AddUserToXML(string studentXMLPath, List<Student> studentList, Student newStudentEntry)
        {
            if (!System.IO.File.Exists(studentXMLPath))
                InitialCreateStudentXml(studentXMLPath, studentList, newStudentEntry);

            XDocument studentXML = XDocument.Load(studentXMLPath);

            Console.WriteLine("AddUserToXML");
            /*IEnumerable<XElement> StudentNodesQuery =
                from groupName in studentXML.Root.Elements()
                from students in groupName.Elements()
                select students;*/

            IEnumerable<XElement> GroupNodesQuery =
                from groups in studentXML.Root.Elements()
                select groups;

            foreach (XElement groups in GroupNodesQuery)
            {
                if (groups.Name == newStudentEntry.Group)
                {
                    IEnumerable<XElement> StudentNodesQuery =
                        from students in groups.Elements()
                        select students;
                    bool studentNotFound = isStudentNameInXML(StudentNodesQuery, newStudentEntry.LoginName);
                    foreach (XElement student in StudentNodesQuery)
                    {
                        //Console.WriteLine(student);

                        if (!studentNotFound)
                        {
                            Console.WriteLine("True");
                            XElement newStudent =
                                new XElement("stu",
                                    new XElement("loginName", newStudentEntry.LoginName),
                                    new XElement("lastLogin", newStudentEntry.LastLogin),
                                    new XElement("recPath", newStudentEntry.RecordsPath),
                                    new XElement("driPath", newStudentEntry.DrillsPath));
                            Console.WriteLine("Before Adding the student");
                            Console.WriteLine(groups);
                            groups.Add(newStudent);
                            Console.WriteLine("After Adding the student");
                            Console.WriteLine(groups);
                            break;
                        }
                    }
                }
            }
            studentXML.Save(studentXMLPath);
        }

        private bool isStudentNameInXML(IEnumerable<XElement> StudentNodesQuery, string studentName)
        {
            foreach (XElement student in StudentNodesQuery)
            {
                if(student.Element("loginName").Value == studentName)
                {
                    Console.WriteLine("isStudentNameInXML is TRUE");
                    return true;
                }
                Console.WriteLine(student.Element("loginName").Value);
                Console.WriteLine(studentName);
            }
            Console.WriteLine("isStudentNameInXML is FALSE");
            return false;
        }

        private void CreateXML(/*List<Student> studentList*/)
        {
            //TODO: StudentXML should contain all student information
            //Should find StudentXML in C://App Data
            //string file = "Testing.xml";

            /*Combine the path of AppData\local with the file you want to save to create a filename*/
            //string filename = System.IO.Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), file);
            
            /*How to get the path to your current directory*/
            //(System.Environment.CurrentDirectory)

            /*string adminFilename = System.IO.Path.Combine(System.Environment.CurrentDirectory, "RaptorMathAdminsTest.xml");
            XDocument adminXML =
                new XDocument(
                    new XElement("RaptorMathAdmin",
                        new XElement("admin",
                            new XElement("loginName", "Admin"),
                            new XElement("password", "Admin"),
                            new XElement("path", "RaptorMathStudents.xml"),
                            new XElement("lastLogin", DateTime.Now.ToString("M/d/yyyy")))) );
            adminXML.Save(adminFilename);*/

            /*Create student XML when the Admin logs in for the first time */
            string studentFilename = System.IO.Path.Combine(System.Environment.CurrentDirectory, "RaptorMathStudentsTest.xml");
            XDocument studentXML =
                new XDocument(
                    new XElement("RaptorMathStu",
                        /* Group node that is initially Unassigned but can be assigned by teacher on creation*/
                        new XElement("Unassigned",
                            new XElement("stu",
                                new XElement("loginName", "Unknown"),
                                new XElement("lastLogin", "Unknown"),
                                /*Path to RaptorMathStudents XML*/
                                //new XElement("stuPath", "Unknown"),
                                /*Path to this students records XML*/
                                new XElement("recPath", "Unknown"),
                                /*Path to this students drill XML*/
                                new XElement("driPath", "Unknown")))) );
            studentXML.Save(studentFilename);
            /*Take their initials (i.e. CJ) with their screen name and concat "Records.xml" */
            string recordFilename = System.IO.Path.Combine(System.Environment.CurrentDirectory, "RaptorMathRecordsTest.xml");
            XDocument recordXML =
                new XDocument(
                    new XElement("StudentRecords",
                        new XElement("record",
                            new XElement("dateTaken", "Unknown"),
                            new XElement("question", "Unknown"),
                            new XElement("rangeStart", "Unknown"),
                            new XElement("rangeEnd", "Unknown"),
                            new XElement("op", "Unknown"),
                            new XElement("wrong", "Unknown"),
                            new XElement("skipped", "Unknown"),
                            new XElement("percent", "Unknown"))) );
            recordXML.Save(recordFilename);
            /*Take their initials (i.e. CJ) with their screen name and concat "DrillSettings.xml" */
            string drillSettingsFilename = System.IO.Path.Combine(System.Environment.CurrentDirectory, "RaptorMathDrillSettingsTest.xml");
            XDocument drillSettingsXML =
                new XDocument(
                    new XElement("StudentDrillSettings",
                        /*settings node will be pre-defined drill settings or custom drill settings*/
                        new XElement("settings",
                            new XElement("DrillNameHere",
                                new XElement("question", "Unknown"),
                                new XElement("rangeStart", "Unknown"),
                                new XElement("rangeEnd", "Unknown"),
                                new XElement("op", "Unknown")))) );
            drillSettingsXML.Save(drillSettingsFilename);

            

                /*XDocument studentXML = XDocument.Load(fileName);

                foreach (XElement student in studentXML.Root.Nodes())
                {
                    Student aStudent = new Student();
                    aStudent.LoginName = student.Element("loginName").Value;
                    aStudent.Password = student.Element("password").Value;
                    aStudent.LastLogin = student.Element("lastLogin").Value;
                    //Need studentXML filePath
                    aStudent.FilePath = student.Element("filePath").Value;
                    //Need Specific student's recordXML
                    //Need Student specific drillXML
                    aStudent.curDrill = CurrentDrillParser(student.Element("curSetting"));

                    //foreach (XElement record in student.Elements("records"))
                    //    aStudent.reportList.Add(CurrentRecordParser(record));

                    // Add to student list
                    studentList.Add(aStudent);
                }
                 * */
            //}
        }

        //TODO: figure out how to store and read things from app data
        private void InitializeDefaultAdmin(List<Admin> adminList)
        {
            Admin administrator = new Admin();
            administrator.LoginName = "Admin";
            administrator.Password = "Admin";
            administrator.LastLogin = DateTime.Now.ToString("M/d/yyyy");
            administrator.FilePath = "FilePathToStudentXMLS";
            adminList.Add(administrator);
        }
        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        // Loads student XML using filepath found in admin                  //
        //------------------------------------------------------------------//
        private void LoadStudentXML(string fileName, List<Student> studentList)
        {
            if (!FileExists(fileName))
                Environment.Exit(1);
            else
            {
                XDocument studentXML = XDocument.Load(fileName);

                foreach (XElement student in studentXML.Root.Nodes())
                {
                    Student aStudent = new Student();
                    aStudent.LoginName = student.Element("loginName").Value;
                    aStudent.LastLogin = student.Element("lastLogin").Value;
                    aStudent.RecordsPath = student.Element("recPath").Value;
                    //aStudent.DrillsPath = CurrentDrillParser(student.Element("driPath"));

                    foreach (XElement record in student.Elements("records"))
                        aStudent.reportList.Add(CurrentRecordParser(record));

                    // Add to student list
                    studentList.Add(aStudent);
                }
            }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        // Loads drill settings from XML and returns a populated drill entity//
        //------------------------------------------------------------------//
        public Drill CurrentDrillParser(XElement drillNode)
        {
            Drill newDrill = new Drill();
            newDrill.CurQuestions = drillNode.Element("question").Value;
            newDrill.CurRangeStart = drillNode.Element("rangeStart").Value;
            newDrill.CurRangeEnd = drillNode.Element("rangeEnd").Value;
            newDrill.CurOperand = drillNode.Element("op").Value;
            return newDrill;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        // Loads record from XML and returns populated records entity       //
        //------------------------------------------------------------------//
        public Record CurrentRecordParser(XElement recordNode)
        {
            Record newRecord = new Record();
            newRecord.DateTaken = recordNode.Element("dateTaken").Value;
            newRecord.Question = recordNode.Element("question").Value; 
            newRecord.RangeStart = recordNode.Element("rangeStart").Value;
            newRecord.RangeEnd = recordNode.Element("rangeEnd").Value;
            newRecord.Operation = recordNode.Element("op").Value;
            newRecord.Wrong = recordNode.Element("wrong").Value;
            newRecord.Percent = recordNode.Element("percent").Value;
            newRecord.Skipped = recordNode.Element("skipped").Value;
            
            /*//How to call Record(IEnumerable<XElement> elements)
            IEnumerable<XElement> elements = recordNode.Elements();
            Record testing = new Record(elements);
            Dictionary<string, string> recordDictionary = testing.recordDictionary;
            for (int i = 0; i < recordDictionary.Count(); i++)
            {
                Console.WriteLine(recordDictionary.ElementAt(i).Key.ToString());
                Console.WriteLine(recordDictionary.ElementAt(i).Value.ToString());
            }*/
            
            return newRecord;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        // Writes last login to XML                                         //
        //------------------------------------------------------------------//
        public void WriteLogin(string fileName, string userName, string date, bool isAdmin)
        {
            //if (isAdmin == true)
                //fileName = adminFile;

            if (!FileExists(fileName))
                Environment.Exit(1);
            else
            {
                XDocument doc = XDocument.Load(fileName);
                foreach (XElement data in doc.Root.Nodes())
                {
                    string fullName = data.Element("loginName").Value;

                    if (userName == fullName)
                    {
                        data.Element("lastLogin").Value = date;
                        break;
                    }
                }

                doc.Save(fileName);
            }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        // Writes finished session to student XML                           //
        //------------------------------------------------------------------//
        public void WriteCurrentSession(string fileName, string studentName, Drill currentDrill)
        {
            if (!FileExists(fileName))
                Environment.Exit(1);

            XDocument doc = XDocument.Load(fileName);
            foreach (XElement student in doc.Root.Nodes())
            {
                if (student.Element("loginName").Value == studentName)
                {
                    XElement records =
                        new XElement("records",
                            new XElement("dateTaken", DateTime.Now.ToString("M/d/yyyy")),
                            new XElement("question", currentDrill.CurQuestions),
                            new XElement("rangeStart", currentDrill.CurRangeStart),
                            new XElement("rangeEnd", currentDrill.CurRangeEnd),
                            new XElement("op", currentDrill.CurOperand),
                            new XElement("wrong", currentDrill.CurWrong),
                            new XElement("skipped", currentDrill.curSkipped),
                            new XElement("percent", currentDrill.curPercent));
                    
                    student.Add(records);
                    break;
                }
            }
            doc.Save(fileName);
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/27/2014                                                  //
        // Writes drill settings to XML                                     //
        //------------------------------------------------------------------//
        public void WriteDrillSettings(string stuName, string fileName, string minOperand, string maxOperand, string setSize, string operand)
        {
            if (!FileExists(fileName))
                Environment.Exit(1);

            XDocument doc = XDocument.Load(fileName);
            foreach (XElement data in doc.Root.Nodes())
            {
                string fullName = data.Element("loginName").Value;
                if (stuName == fullName)
                {
                    XElement drill = data.Element("curSetting");
                    drill.Element("question").Value = setSize;
                    drill.Element("rangeStart").Value = minOperand;
                    drill.Element("rangeEnd").Value = maxOperand;
                    drill.Element("op").Value = operand;
                    break;
                }
            }
            doc.Save(fileName);
        }
    }
}
