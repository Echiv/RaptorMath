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
        private string adminFile = "RaptorMathAdmins.xml";

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
        public void LoadXML(List<Student> studentList, List<Admin> adminList)
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
                    aStudent.FilePath = student.Element("filePath").Value;
                    aStudent.curDrill = CurrentDrillParser(student.Element("curSetting"));

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
            if (isAdmin == true)
                fileName = adminFile;

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
