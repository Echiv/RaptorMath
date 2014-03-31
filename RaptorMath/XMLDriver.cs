using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace RaptorMath
{
    public class XMLDriver
    {
        public string adminXMLPath = string.Empty;
        public string studentXMLPath = string.Empty;
        public string groupXMLPath = string.Empty;
        public string drillXMLPath = string.Empty;

        public XMLDriver()
        {
            adminXMLPath = "Unknown";
            studentXMLPath = "Unknown";
            groupXMLPath = "Unknown";
            drillXMLPath = "Unknown";
        }

        public XMLDriver(string adminXML, string studentXML, string groupXML, string drillXML)
        {
            adminXMLPath = adminXML;
            studentXMLPath = studentXML;
            groupXMLPath = groupXML;
            drillXMLPath = drillXML;
        }

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
            if (!System.IO.File.Exists(fileName))
            {
                return false;
            }
            return true;
        }

        public void StartUp(List<Admin> adminList, string adminXMLPath, List<Student> studentList, string studentXMLPath, List<string> groupList, string managerDataDirectory)
        {
            //AdminXML should contain all admin information
            //Should find AdminXML in C://App Data
            if (!System.IO.File.Exists(adminXMLPath))
            {
                InitialCreateAdminXml(adminXMLPath);
            }

            Console.WriteLine("StartUP");

            if (studentXMLExists(studentXMLPath))
                LoadStudentXML(studentList, studentXMLPath, groupList);
            LoadAdminXML(adminList, adminXMLPath);
        }

        public Student GetStudentWithID(int studentID, string studentXMLPath)
        {
            XDocument Data = XDocument.Load(studentXMLPath);

            return (from student in Data.Descendants("Stu")
                    where student.Attribute("ID").Value.Equals(studentID.ToString())
                    select new Student() 
                    {
                        ID = Convert.ToInt32(student.Attribute("ID").Value),
                        Group = student.Element("group").Value,
                        LoginName = student.Element("lastlogin").Value,
                        RecordsPath = student.Element("recPath").Value,
                        DrillsPath = student.Element("driPath").Value
                    }).FirstOrDefault();
        }

        public bool AddUserToXML(Student newStudent, List<Student> studentList)
        {
            string drillPath = newStudent.LoginName.Replace(" ", "") + "DrillSettings.xml";
            string recordPath = newStudent.LoginName.Replace(" ", "") + "Records.xml";
            newStudent.RecordsPath = recordPath;
            newStudent.DrillsPath = drillPath;
           
            bool isAdded = false;
            if (!System.IO.File.Exists(studentXMLPath))
            {
                isAdded = InitialCreateStudentXml(newStudent, studentXMLPath, studentList);
            }
            else
            {
                isAdded = AddNewStudent(newStudent, studentXMLPath, studentList);
            }
            return isAdded;
        }

        public bool AddUserToXML(Admin newAdmin, List<Admin> adminList)
        {
            return AddNewAdmin(newAdmin, adminXMLPath, adminList);
        }

        public bool InitialCreateStudentXml(Student newStudentEntry, string studentXMLPath, List<Student> studentList)
        {
            MessageBox.Show("RaptorMathStu");
            XElement newStudent = 
                new XElement("stu",
                    new XElement("group", newStudentEntry.Group),
                    new XElement("loginName", newStudentEntry.LoginName),
                    new XElement("lastLogin", newStudentEntry.LastLogin),
                    new XElement("recPath", newStudentEntry.RecordsPath),
                    new XElement("driPath", newStudentEntry.DrillsPath));
            newStudent.SetAttributeValue("ID", "1");

            XDocument newStudentDoc =
                new XDocument(
                    new XElement("RaptorMathStu", newStudent));
            studentList.Add(newStudentEntry);
            newStudentDoc.Save(studentXMLPath);
            return true;
        }

        public bool InitialCreateAdminXml(string AdminXMLPath)
        {
            MessageBox.Show("RaptorMathStu");
            XElement newAdmin =
                new XElement("admin",
                    new XElement("loginName", "Admin"),
                    new XElement("password", "Admin"),
                    new XElement("studentPath", "RaptorMathStudents.xml"),
                    new XElement("lastLogin", DateTime.Now.ToString("M/d/yyyy")));
            newAdmin.SetAttributeValue("ID", "1");

            XDocument newAdminDoc =
                new XDocument(
                    new XElement("RaptorMathStu", newAdmin));

            newAdminDoc.Save(AdminXMLPath);
            return true;
        }

        public bool InitialCreateGroupXML(string GroupXMLPath)
        {
            return true;
        }

        public bool InitialCreateDrillXML(string DrillXMLPath)
        {
            return true;
        }

        public bool AddNewStudent(Student student, string studentXMLPath, List<Student> studentList)
        {
            XDocument data = XDocument.Load(studentXMLPath);
            
            XElement studentElement = 
                data.Descendants("stu").Where(s => s.Element("loginName").Value == student.LoginName).FirstOrDefault();
            if(studentElement != null)
            {
                return false;
            }
            else
            {
                XElement newStudent = 
                    new XElement ("stu",
                        new XElement("group", student.Group),
                        new XElement("loginName", student.LoginName),
                        new XElement("lastLogin", student.LastLogin),
                        new XElement("recPath", student.RecordsPath),
                        new XElement("driPath", student.DrillsPath));
                newStudent.SetAttributeValue("ID", GetNextAvailableID(studentXMLPath));

                data.Element("RaptorMathStu").Add(newStudent);
                studentList.Add(student);
                data.Save(studentXMLPath);
                return true;
            }
        }

        public bool AddNewAdmin(Admin admin, string fileName, List<Admin> adminList)
        {
            XDocument data = XDocument.Load(fileName);

            XElement AdminElement =
                data.Descendants("admin").Where(s => s.Element("loginName").Value == admin.LoginName).FirstOrDefault();
            if (AdminElement != null)
            {
                return false;
            }
            else
            {
                XElement newAdmin =
                    new XElement("admin",
                        new XElement("loginName", admin.LoginName),
                        new XElement("password", admin.Password),
                        new XElement("studentPath", admin.FilePath),
                        new XElement("lastLogin", admin.LastLogin));
                newAdmin.SetAttributeValue("ID", GetNextAvailableID(fileName));

                data.Element("RaptorMathAdmin").Add(newAdmin);
                adminList.Add(admin);
                data.Save(fileName);
                return true;
            }
        }

        public int GetNextAvailableID(string fileName)
        {
            XDocument data = XDocument.Load(fileName);

            return Convert.ToInt32(
                (from studentElements in data.Descendants("stu")
                 orderby Convert.ToInt32(studentElements.Attribute("ID").Value) descending
                 select studentElements.Attribute("ID").Value).FirstOrDefault()
                                   ) + 1;
        }

        public void Delete(Student student, string fileName)
        {
            XDocument data = XDocument.Load(fileName);

            XElement studentElement = data.Descendants("stu").Where(s => s.Attribute("ID").Value.Equals(student.ID.ToString())).FirstOrDefault();
            if (studentElement != null)
            {
                studentElement.Remove();
                data.Save(fileName);
            }
        }

        private void LoadStudentXML(List<Student> studentList, string fileName, List<String> groupList)
        {
            XDocument studentXML = XDocument.Load(fileName);

            XElement rootNode = FirstLevelOfRoot(studentXML);

            IEnumerable<XElement> StudentNodesQuery = SecondLevelOfRoot(rootNode);
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
                groupList.Add(aStudent.Group);
            }
        }

        public void LoadAdminXML(List<Admin> adminList, string fileName)
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
        
    }
}
