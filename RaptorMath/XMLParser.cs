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

        public bool studentXMLExists(string fileName)
        {
            if(!System.IO.File.Exists(fileName))
            {
                return false;
            }
            return true;
        }

        public void StartUp(List<Admin> adminList, string adminXMLPath, List<Student> studentList, string studentXMLPath, List<string> groupList)
        {
            //AdminXML should contain all admin information
            //Should find AdminXML in C://App Data
            if (!adminXMLExists(adminXMLPath))
                InitialCreateAdminXML(adminXMLPath);

            Console.WriteLine("StartUP");
            
            if (studentXMLExists(studentXMLPath))
                LoadStudentXML(studentList, studentXMLPath, groupList);
            LoadAdminXML(adminList, adminXMLPath);
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

        public void LoadAdminXML(List<Admin> adminList, string fileName )
        {
            XDocument adminXML = XDocument.Load(fileName);

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

        public bool InitialCreateStudentXml(string studentXMLPath, List<Student> studentList, Student newStudentEntry, List<String> groupList)
        {
            XDocument studentXML =
                new XDocument(
                    new XElement("RaptorMathStu",
                        new XElement(newStudentEntry.Group,
                            new XElement("stu",
                                new XElement("group", newStudentEntry.Group),
                                new XElement("loginName", newStudentEntry.LoginName),
                                new XElement("lastLogin", newStudentEntry.LastLogin),
                                new XElement("recPath", newStudentEntry.RecordsPath),
                                new XElement("driPath", newStudentEntry.DrillsPath)))));
            AddStudentToStudentAndGroupList(studentList, groupList, newStudentEntry);
            studentXML.Save(studentXMLPath);
            return true;
        }

        public bool AddUserToXML(string adminXMLPath, List<Admin> adminList, Admin newAdminEntry)
        {
            
            XDocument adminXML = XDocument.Load(adminXMLPath);

            XElement rootNode = FirstLevelOfRoot(adminXML);
            IEnumerable<XElement> AdminNodesQuery = SecondLevelOfRoot(rootNode);

            bool isAdded = false;

            bool AdminNotFound = isAdminNameInList(AdminNodesQuery, newAdminEntry.LoginName);
            if (!AdminNotFound)
            {
                XElement newAdmin =
                    new XElement("admin",
                                new XElement("loginName", newAdminEntry.LoginName),
                                new XElement("password", newAdminEntry.Password),
                                new XElement("path", newAdminEntry.FilePath),
                                new XElement("lastLogin", newAdminEntry.LastLogin));
                rootNode.Add(newAdmin);
                adminList.Add(newAdminEntry);
                isAdded = true;
            }
      
            adminXML.Save(adminXMLPath);
            return isAdded;
        }

        public bool AddUserToXML(string studentXMLPath, List<Student> studentList, Student newStudentEntry, List<String> groupList)
        {
            string drillPath = newStudentEntry.LoginName.Replace(" ", "") + "DrillSettings.xml";
            string recordPath = newStudentEntry.LoginName.Replace(" ", "") + "Records.xml";
            newStudentEntry.RecordsPath = recordPath;
            newStudentEntry.DrillsPath = drillPath;

            bool isAdded = false;
            if (!System.IO.File.Exists(studentXMLPath))
            {
                isAdded = InitialCreateStudentXml(studentXMLPath, studentList, newStudentEntry, groupList);
            }
            else
            {
                bool hasGroupBeenAdded = false;
                XDocument studentXML = XDocument.Load(studentXMLPath);

                XElement rootNode = FirstLevelOfRoot(studentXML);
                IEnumerable<XElement> GroupNodesQuery = SecondLevelOfRoot(rootNode);
                foreach (XElement groupNode in GroupNodesQuery)
                {
                    if (groupNode.Name == newStudentEntry.Group)
                    {
                        hasGroupBeenAdded = true;
                        IEnumerable<XElement> StudentNodesOfGroupQuery = ThirdLevelOfRoot(groupNode);
                        bool studentNotFound = isStudentNameInGroup(StudentNodesOfGroupQuery, newStudentEntry.LoginName);
                        foreach (XElement student in StudentNodesOfGroupQuery)
                        {
                            if (!studentNotFound)
                            {
                                XElement newStudent = XmlStudentWithoutGroup(newStudentEntry);
                                AddStudentToStudentAndGroupList(studentList, groupList, newStudentEntry);
                                groupNode.Add(newStudent);
                                isAdded = true;
                                break;
                            }
                            isAdded = false;
                        }
                    }
                    if (hasGroupBeenAdded == true)
                        break;
                }
                if (hasGroupBeenAdded == false)
                {
                    XElement newStudent = XmlStudentWithNewGroup(newStudentEntry);
                    AddStudentToStudentAndGroupList(studentList, groupList, newStudentEntry);
                    rootNode.Add(newStudent);
                    isAdded = true;
                }
                studentXML.Save(studentXMLPath); 
            }
            return isAdded;
        }

        private XElement XmlStudentWithoutGroup(Student student)
        {
            XElement newStudent =
                new XElement("stu",
                    new XElement("group", student.Group),
                    new XElement("loginName", student.LoginName),
                    new XElement("lastLogin", student.LastLogin),
                    new XElement("recPath", student.RecordsPath),
                    new XElement("driPath", student.DrillsPath));
            return newStudent;
        }

        private XElement XmlStudentWithNewGroup(Student student)
        {
            XElement newStudent =
                new XElement(student.Group,
                    new XElement("stu",
                        new XElement("group", student.Group),
                        new XElement("loginName", student.LoginName),
                        new XElement("lastLogin", student.LastLogin),
                        new XElement("recPath", student.RecordsPath),
                        new XElement("driPath", student.DrillsPath)));
            return newStudent;
        }

        private XElement XmlDrillSettingsWithNewDrillSet(Drill drill)
        {
            XElement newDrillSet =
                new XElement(drill.DrillSet,
                    new XElement("questions", drill.CurQuestions),
                    new XElement("rangeStart", drill.CurRangeStart),
                    new XElement("rangeEnd", drill.CurRangeEnd),
                    new XElement("operand", drill.CurOperand),
                    new XElement("wrong", drill.CurWrong),
                    new XElement("skipped", drill.CurSkipped),
                    new XElement("percent", drill.CurPercent) );
            return newDrillSet;
        }

        private XElement XmlRecords(Drill currentDrill)
        {
            XElement records =
                new XElement("records", currentDrill.DrillSet,
                    new XElement("dateTaken", DateTime.Now.ToString("M/d/yyyy")),
                    new XElement("question", currentDrill.CurQuestions),
                    new XElement("rangeStart", currentDrill.CurRangeStart),
                    new XElement("rangeEnd", currentDrill.CurRangeEnd),
                    new XElement("op", currentDrill.CurOperand),
                    new XElement("wrong", currentDrill.CurWrong),
                    new XElement("skipped", currentDrill.curSkipped),
                    new XElement("percent", currentDrill.curPercent));
            return records;
        }
        /*private XElement XmlDrillSettingsWithNewDrillSet(Drill drill)
        {
            XElement newDrillSet = 
                new XElement("questions", drill.CurQuestions,
                    new XElement("rangeStart", drill.CurRangeStart),
                    new XElement("rangeEnd", drill.CurRangeEnd),
                    new XElement("operand", drill.CurOperand),
                    new XElement("wrong", drill.CurWrong),
                    new XElement("skipped", drill.CurSkipped),
                    new XElement("percent", drill.CurPercent) );
            return newDrillSet;
        }*/

        private void AddStudentToNode(List<Student> studentList, List<String> groupList, XElement Node, XElement XMLStudentStucture, Student newStudentEntry)
        {
            Node.Add(XMLStudentStucture);
        }

        private void AddStudentToStudentAndGroupList(List<Student> studentList, List<String> groupList, Student newStudentEntry)
        {
            studentList.Add(newStudentEntry);
            groupList.Add(newStudentEntry.Group);
        }

        private XElement FirstLevelOfRoot(XDocument XMLFile)
        {
            return XMLFile.Root;
        }

        private IEnumerable<XElement> SecondLevelOfRoot(XElement RootNode)
        {
            IEnumerable<XElement> SecondLevelChildrenQuery =
                from secondLevel in RootNode.Elements()
                select secondLevel;
            return SecondLevelChildrenQuery;
        }

        private IEnumerable<XElement> ThirdLevelOfRoot(XElement SecondLevelNode)
        {
            IEnumerable<XElement> ThirdLevelChildrenQuery =
                from ThirdLevel in SecondLevelNode.Elements()
                select ThirdLevel;
            return ThirdLevelChildrenQuery;
        }

        private bool isStudentNameInGroup(IEnumerable<XElement> StudentNodesOfGroupQuery, string studentName)
        {
            foreach (XElement student in StudentNodesOfGroupQuery)
            {
                if(student.Element("loginName").Value == studentName)
                    return true;
            }
            return false;
        }

        private bool isAdminNameInList(IEnumerable<XElement> AdminNodesQuery, string AdminName)
        {
            foreach (XElement admin in AdminNodesQuery)
            {
                if (admin.Element("loginName").Value == AdminName)
                    return true;
            }
            return false;
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        // Loads student XML using filepath found in admin                  //
        //------------------------------------------------------------------//
        private void LoadStudentXML(List<Student> studentList, string fileName, List<String> groupList)
        {
            XDocument studentXML = XDocument.Load(fileName);

            XElement rootNode = FirstLevelOfRoot(studentXML);

            IEnumerable<XElement> GroupNodesQuery = SecondLevelOfRoot(rootNode);

            foreach (XElement groups in GroupNodesQuery)
            {
                IEnumerable<XElement> StudentNodesQuery = ThirdLevelOfRoot(groups);
                foreach (XElement student in StudentNodesQuery)
                {
                    Student aStudent = new Student();
                    aStudent.Group = student.Element("group").Value;
                    aStudent.LoginName = student.Element("loginName").Value;
                    aStudent.LastLogin = student.Element("lastLogin").Value;
                    aStudent.RecordsPath = student.Element("recPath").Value;
                    aStudent.DrillsPath = student.Element("driPath").Value;
                    
                    //aStudent.DrillsPath = CurrentDrillParser(student.Element("driPath"));

                    //foreach (XElement record in student.Elements("records"))
                    //    aStudent.reportList.Add(CurrentRecordParser(record));

                    // Add to student list
                   studentList.Add(aStudent);
                }
                groupList.Add(groups.Name.ToString());
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
            if (!FileExists(fileName))
                Environment.Exit(1);
            else if (isAdmin == true)
            {
                //fileName = adminFile;
                XDocument admin_doc = XDocument.Load(fileName);
                XElement admin_root = FirstLevelOfRoot(admin_doc);

                IEnumerable<XElement> admins = SecondLevelOfRoot(admin_root);
                foreach (XElement admin in admins)
                {
                    string fullName = admin.Element("loginName").Value;

                    if(userName == fullName)
                    {
                        admin.Element("lastLogin").Value = date;
                    }
                }
                admin_doc.Save(fileName);
                MessageBox.Show("HERRO PREASE!");
            }
            else
            {
                XDocument student_doc = XDocument.Load(fileName);
                XElement student_root = FirstLevelOfRoot(student_doc);

                IEnumerable<XElement> groups = SecondLevelOfRoot(student_root);
                foreach (XElement group in groups)
                {
                    IEnumerable<XElement> students = SecondLevelOfRoot(group);
                    foreach (XElement student in students)
                    {
                        string fullName = student.Element("loginName").Value;

                        if (userName == fullName)
                        {
                            student.Element("lastLogin").Value = date;
                            break;
                        }
                    }
                }
                student_doc.Save(fileName);
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
