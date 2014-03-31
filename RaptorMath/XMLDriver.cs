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

        public void StartUp(List<Admin> adminList, List<Student> studentList, List<Group> groupList, List<Drill> mainDrillList)
        {
            //AdminXML should contain all admin information
            //Should find AdminXML in C://App Data
            if (!System.IO.File.Exists(adminXMLPath))
            {
                InitialCreateAdminXml(adminXMLPath);
            }
            if (!System.IO.File.Exists(groupXMLPath))
            {
                InitialCreateGroupXML(groupXMLPath);
            }
            if (!System.IO.File.Exists(drillXMLPath))
            {
                InitialCreateDrillXML(drillXMLPath);
            }

            Console.WriteLine("StartUP");
            Console.WriteLine(adminXMLPath);
            Console.WriteLine(groupXMLPath);
            Console.WriteLine(drillXMLPath);
            Console.WriteLine(studentXMLPath);


            if (studentXMLExists(studentXMLPath))
                LoadStudentXML(studentList, studentXMLPath);
            LoadAdminXML(adminList, adminXMLPath);
            LoadGroupXML(groupList, groupXMLPath);
            LoadDrillXML(mainDrillList, drillXMLPath);
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
            bool isAdded = AddNewAdmin(newAdmin, adminXMLPath, adminList);
            return isAdded;
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
            MessageBox.Show("RaptorMathAdmin");
            XElement newAdmin =
                new XElement("admin",
                    new XElement("loginName", "Admin"),
                    new XElement("password", "Admin"),
                    new XElement("studentPath", "RaptorMathStudents.xml"),
                    new XElement("lastLogin", DateTime.Now.ToString("M/d/yyyy")));
            newAdmin.SetAttributeValue("ID", "1");

            XDocument newAdminDoc =
                new XDocument(
                    new XElement("RaptorMathAdmin", newAdmin));

            newAdminDoc.Save(AdminXMLPath);
            return true;
        }

        public bool InitialCreateGroupXML(string GroupXMLPath)
        {
            XElement newGroup =
                new XElement("group",
                    new XElement("groupName", "unassigned"));
            newGroup.SetAttributeValue("ID", "1");

            XDocument newGroupDoc =
                new XDocument(
                    new XElement("RaptorMathGroups", newGroup));
            newGroupDoc.Save(GroupXMLPath);
            return true;
        }

        public bool InitialCreateDrillXML(string DrillXMLPath)
        {
            XElement defaultDrillOne =
                new XElement("drill",
                    new XElement("drillName", "10AdditionProblems1to25"),
                    new XElement("questions", "10"),
                    new XElement("rangeStart", "1"),
                    new XElement("rangeEnd", "25"),
                    new XElement("operand", "addition"),
                    new XElement("wrong", "unknown"),
                    new XElement("skipped", "unknown"),
                    new XElement("percent", "unknown"));
            defaultDrillOne.SetAttributeValue("ID", "1");

            XElement defaultDrillTwo =
                new XElement("drill",
                    new XElement("drillName", "10SubtractionProblems1to25"),
                    new XElement("questions", "10"),
                    new XElement("rangeStart", "1"),
                    new XElement("rangeEnd", "25"),
                    new XElement("operand", "subtract"),
                    new XElement("wrong", "unknown"),
                    new XElement("skipped", "unknown"),
                    new XElement("percent", "unknown"));
            defaultDrillTwo.SetAttributeValue("ID", "2");

            XDocument newDrillsDoc =
                new XDocument(
                    new XElement("RaptorMathDrills", defaultDrillOne, defaultDrillTwo));
            newDrillsDoc.Save(DrillXMLPath);
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

        private void LoadStudentXML(List<Student> studentList, string fileName)
        {
            XDocument studentXML = XDocument.Load(fileName);

            XElement rootNode = FirstLevelOfRoot(studentXML);

            IEnumerable<XElement> StudentNodesQuery = SecondLevelOfRoot(rootNode);
            foreach (XElement student in StudentNodesQuery)
            {
                Student aStudent = new Student();
                aStudent.ID = Convert.ToInt32(student.Attribute("ID").Value);
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
                administrator.FilePath = admin.Element("studentPath").Value;
                adminList.Add(administrator);
            }
        }

        public void LoadGroupXML(List<Group> groupList, string fileName)
        {
            XDocument groupXML = XDocument.Load(fileName);

            foreach (XElement group in groupXML.Root.Nodes())
            {
                Group Group = new Group();
                Group.ID = Convert.ToInt32(group.Attribute("ID").Value);
                Group.Name = group.Element("groupName").Value;
                groupList.Add(Group);
            }
        }

        public void LoadDrillXML(List<Drill> drillList, string fileName)
        {
            XDocument drillXML = XDocument.Load(fileName);

            foreach (XElement drill in drillXML.Root.Nodes())
            {
                Drill Drill = new Drill();
                Drill.ID = Convert.ToInt32(drill.Attribute("ID").Value);
                Drill.DrillName = drill.Element("drillName").Value;
                Drill.Questions = drill.Element("questions").Value;
                Drill.RangeStart = drill.Element("rangeStart").Value;
                Drill.RangeEnd = drill.Element("rangeEnd").Value;
                Drill.Operand = drill.Element("operand").Value;
                Drill.Wrong = drill.Element("wrong").Value;
                Drill.Skipped = drill.Element("skipped").Value;
                Drill.Percent = drill.Element("percent").Value;
                drillList.Add(Drill);
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
