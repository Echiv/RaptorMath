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
        public string dataDirectory = string.Empty;

        public XMLDriver()
        {
            adminXMLPath = "Unknown";
            studentXMLPath = "Unknown";
            groupXMLPath = "Unknown";
            drillXMLPath = "Unknown";
            dataDirectory = "Unknown";
        }

        public XMLDriver(string adminXML, string studentXML, string groupXML, string drillXML, string DataDirectory)
        {
            adminXMLPath = adminXML;
            studentXMLPath = studentXML;
            groupXMLPath = groupXML;
            drillXMLPath = drillXML;
            dataDirectory = DataDirectory;

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

            LoadAdminXML(adminList, adminXMLPath);
            LoadGroupXML(groupList, groupXMLPath);
            LoadDrillXML(mainDrillList, drillXMLPath);
            if (studentXMLExists(studentXMLPath))
                LoadStudentXML(studentList, mainDrillList, studentXMLPath);
            

            foreach (Drill drill in mainDrillList)
            {
                //Console.WriteLine(drill.DrillName);
                //Console.WriteLine(drill.ID);
            }
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
                    }).FirstOrDefault();
        }

        public bool AddUserToXML(Student newStudent, List<Student> studentList)
        {
            string recordPath = newStudent.LoginName.Replace(" ", "") + "Records.xml";
            newStudent.RecordsPath = System.IO.Path.Combine(dataDirectory, recordPath);
           
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
            bool isAdded = false;
            if (!System.IO.File.Exists(adminXMLPath))
            {
                isAdded = InitialCreateAdminXml(newAdmin, adminXMLPath, adminList);
            }
            else
            {
                isAdded = AddNewAdmin(newAdmin, adminXMLPath, adminList);
            }
            return isAdded;
        }

        public void AddRecordToStudent(Student student, Record RecordToAdd)
        {
            if (!System.IO.File.Exists(student.RecordsPath))
            {
                InitialCreateRecordXML(student, RecordToAdd);
            }
            else
            {
                AddNewRecord(student, RecordToAdd);
            }
        }

        public bool InitialCreateStudentXml(Student newStudentEntry, string studentXMLPath, List<Student> studentList)
        {
            MessageBox.Show("RaptorMathStu");
            XElement newStudent =
                new XElement("stu",
                    new XElement("group", newStudentEntry.Group),
                    new XElement("loginName", newStudentEntry.LoginName),
                    new XElement("lastLogin", newStudentEntry.LastLogin),
                    new XElement("recPath", newStudentEntry.RecordsPath));
            newStudent.SetAttributeValue("ID", "1");
            newStudentEntry.ID = Convert.ToInt32(newStudent.Attribute("ID").Value);

            XDocument newStudentDoc =
                new XDocument(
                    new XElement("RaptorMathStu", newStudent));
            studentList.Add(newStudentEntry);
            newStudentDoc.Save(studentXMLPath);
            return true;
        }

        public bool InitialCreateAdminXml(Admin newAdminEntry, string adminXMLPath, List<Admin> adminList)
        {
            XElement newAdmin =
                new XElement("admin",
                    new XElement("loginName", newAdminEntry.LoginName),
                    new XElement("password", newAdminEntry.Password),
                    new XElement("studentPath", newAdminEntry.FilePath),
                    new XElement("lastLogin", newAdminEntry.LastLogin));
            newAdmin.SetAttributeValue("ID", "1");
            newAdminEntry.ID = Convert.ToInt32(newAdmin.Attribute("ID").Value);

            XDocument newAdminDoc =
                new XDocument(
                    new XElement("RaptorMathAdmin", newAdmin));

            newAdminDoc.Save(adminXMLPath);
            adminList.Add(newAdminEntry);
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
                    new XElement("wrong", "0"),
                    new XElement("skipped", "0"),
                    new XElement("percent", "0"));
            defaultDrillOne.SetAttributeValue("ID", "1");

            XElement defaultDrillTwo =
                new XElement("drill",
                    new XElement("drillName", "10SubtractionProblems1to25"),
                    new XElement("questions", "10"),
                    new XElement("rangeStart", "1"),
                    new XElement("rangeEnd", "25"),
                    new XElement("operand", "subtract"),
                    new XElement("wrong", "0"),
                    new XElement("skipped", "0"),
                    new XElement("percent", "0"));
            defaultDrillTwo.SetAttributeValue("ID", "2");

            XDocument newDrillsDoc =
                new XDocument(
                    new XElement("RaptorMathDrills", defaultDrillOne, defaultDrillTwo));
            newDrillsDoc.Save(DrillXMLPath);
            return true;
        }

        public bool InitialCreateRecordXML(Student student, Record RecordToAdd)
        {
            XElement newRecord =
                new XElement("record",
                    new XElement("drillName", RecordToAdd.DrillName),
                    new XElement("dataTaken", RecordToAdd.DateTaken),
                    new XElement("questions", RecordToAdd.Question),
                    new XElement("rangeStart", RecordToAdd.RangeStart),
                    new XElement("rangeEnd", RecordToAdd.RangeEnd),
                    new XElement("operand", RecordToAdd.Operation),
                    new XElement("wrong", RecordToAdd.Wrong),
                    new XElement("skipped", RecordToAdd.Skipped),
                    new XElement("percent", RecordToAdd.Percent));
            newRecord.SetAttributeValue("ID", "1");
            RecordToAdd.ID = Convert.ToInt32(newRecord.Attribute("ID").Value);
            student.curRecordList.Add(RecordToAdd);

            XDocument newRecordDoc =
                new XDocument(
                    new XElement("Records", newRecord));
            newRecordDoc.Save(student.RecordsPath);
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
                    new XElement("stu",
                        new XElement("group", student.Group),
                        new XElement("loginName", student.LoginName),
                        new XElement("lastLogin", student.LastLogin),
                        new XElement("recPath", student.RecordsPath));
                newStudent.SetAttributeValue("ID", GetNextAvailableID(studentXMLPath, "stu"));
                student.ID = Convert.ToInt32(newStudent.Attribute("ID").Value);

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
                newAdmin.SetAttributeValue("ID", GetNextAvailableID(fileName, "admin"));
                admin.ID = Convert.ToInt32(newAdmin.Attribute("ID").Value);

                data.Element("RaptorMathAdmin").Add(newAdmin);
                adminList.Add(admin);
                data.Save(fileName);
                return true;
            }
        }

        public bool AddNewGroup(string groupName, List<Group> groupList)
        {
            Group group = new Group();
            group.Name = groupName;
            XDocument data = XDocument.Load(groupXMLPath);
            
            XElement GroupElement =
                data.Descendants("group").Where(s => s.Element("groupName").Value == group.Name).FirstOrDefault();
            if (GroupElement != null)
            {
                return false;
            }
            else
            {
                XElement newGroup =
                    new XElement("group",
                        new XElement("groupName", group.Name));
                newGroup.SetAttributeValue("ID", GetNextAvailableID(groupXMLPath, "group"));
                group.ID = Convert.ToInt32(newGroup.Attribute("ID").Value);

                data.Element("RaptorMathGroups").Add(newGroup);
                groupList.Add(group);
                data.Save(groupXMLPath);
                return true;
            }
        }

        public bool AddNewDrill(Drill drill, List<Drill> drillList)
        {
            XDocument data = XDocument.Load(drillXMLPath);

            XElement DrillElement =
                data.Descendants("drill").Where(s => s.Element("drillName").Value == drill.DrillName).FirstOrDefault();
            if (DrillElement != null)
            {
                return false;
            }
            else
            {
                XElement newDrill =
                    new XElement("drill",
                        new XElement("drillName", drill.DrillName),
                        new XElement("questions", drill.Questions),
                        new XElement("rangeStart", drill.RangeStart),
                        new XElement("rangeEnd", drill.RangeEnd),
                        new XElement("operand", drill.Operand),
                        new XElement("wrong", drill.Wrong),
                        new XElement("skipped", drill.Skipped),
                        new XElement("percent", drill.Percent));
                newDrill.SetAttributeValue("ID", GetNextAvailableID(drillXMLPath, "drill"));
                drill.ID = Convert.ToInt32(newDrill.Attribute("ID").Value);

                data.Element("RaptorMathDrills").Add(newDrill);
                drillList.Add(drill);
                data.Save(drillXMLPath);
                return true;
            }
        }

        public bool AddNewRecord(Student student, Record RecordToAdd)
        {
            XDocument data = XDocument.Load(student.RecordsPath);

                XElement newRecord =
                new XElement("record",
                    new XElement("drillName", RecordToAdd.DrillName),
                    new XElement("dataTaken", RecordToAdd.DateTaken),
                    new XElement("questions", RecordToAdd.Question),
                    new XElement("rangeStart", RecordToAdd.RangeStart),
                    new XElement("rangeEnd", RecordToAdd.RangeEnd),
                    new XElement("operand", RecordToAdd.Operation),
                    new XElement("wrong", RecordToAdd.Wrong),
                    new XElement("skipped", RecordToAdd.Skipped),
                    new XElement("percent", RecordToAdd.Percent));
                newRecord.SetAttributeValue("ID", GetNextAvailableID(student.RecordsPath, "record"));
                RecordToAdd.ID = Convert.ToInt32(newRecord.Attribute("ID").Value);

                data.Element("Records").Add(newRecord);
                student.curRecordList.Add(RecordToAdd);
                data.Save(student.RecordsPath);
                return true;
        }

        public void editGroup(string newName, string currentName, List<Group> groupList)
        {
            Group modifiedGroup = new Group();
            foreach (Group group in groupList)
            {
                if(group.Name == currentName)
                {
                    modifiedGroup.ID = group.ID;
                    modifiedGroup.Name = newName;
                    UpdateGroup(group, modifiedGroup);
                    break;
                }
            }
        }

        public void editStudent(string newName, string currentName, string newGroup, List<Student> studentList)
        {
            Student modifiedStudent = new Student();
            foreach (Student student in studentList)
            {
                if(student.LoginName == currentName)
                {
                    MessageBox.Show(student.curDrillList.Count.ToString());
                    modifiedStudent = compareOldAndNewStudentInfo(newName, currentName, newGroup, student.Group);
                    modifiedStudent.ID = student.ID;
                    UpdateStudent(student, modifiedStudent);
                }
            }
        }

        private Student compareOldAndNewStudentInfo(string newName, string currentName, string newGroup, string oldGroup)
        {
            Student newStudent = new Student();
            if ((newName == currentName) || (newName == string.Empty))
                newStudent.LoginName = currentName;
            else
                newStudent.LoginName = newName;

            if ((newGroup == oldGroup) || (newGroup == string.Empty))
                newStudent.Group = oldGroup;
            else
                newStudent.Group = newGroup;
            return newStudent;
        }

        private void UpdateGroup(Group group, Group modifiedGroup)
        {
            XDocument data = XDocument.Load(groupXMLPath);

            XElement groupIDElement =
                data.Descendants("group").Where(grp => grp.Attribute("ID").Value.Equals(modifiedGroup.ID.ToString())).FirstOrDefault();
            XElement groupNameElement =
                data.Descendants("group").Where(grp => grp.Element("groupName").Value.Equals(modifiedGroup.Name)).FirstOrDefault();

            if ((groupIDElement != null) && (groupNameElement == null))
            {
                groupIDElement.SetElementValue("groupName", modifiedGroup.Name);
                group.ID = modifiedGroup.ID;
                group.Name = modifiedGroup.Name;
                data.Save(groupXMLPath);
            }
        }

        private void UpdateStudent(Student student, Student modifiedStudent)
        {
            XDocument data = XDocument.Load(studentXMLPath);

            XElement studentIDElement =
                data.Descendants("stu").Where(stu => stu.Attribute("ID").Value.Equals(modifiedStudent.ID.ToString())).FirstOrDefault();
            XElement studentNameElement =
                data.Descendants("stu").Where(stu => stu.Element("loginName").Value.Equals(modifiedStudent.LoginName)).FirstOrDefault();

            XDocument groupData = XDocument.Load(groupXMLPath);
            XElement GroupElement =
                groupData.Descendants("group").Where(group => group.Element("groupName").Value.Equals(modifiedStudent.Group)).FirstOrDefault();

            if ((studentIDElement != null) && (studentNameElement == null) && (GroupElement != null))
            {
                studentIDElement.SetElementValue("loginName", modifiedStudent.LoginName);
                studentIDElement.SetElementValue("group", modifiedStudent.Group);
                student.ID = modifiedStudent.ID;
                student.LoginName = modifiedStudent.LoginName;
                student.Group = modifiedStudent.Group;
                data.Save(studentXMLPath);
            }
        }

        

        public void AddDrillToStudentXML(Student student, Drill drillToAdd)
        {
            XDocument data = XDocument.Load(studentXMLPath);

            XElement studentElement = data.Descendants("stu").Where(s => s.Attribute("ID").Value.Equals(student.ID.ToString())).FirstOrDefault();
            bool isDrillAlreadyAssignedToStudent = isDrillAssigned(student, drillToAdd);
            if ((studentElement != null) && (!isDrillAlreadyAssignedToStudent))
            {
                XElement newStudentDrill = new XElement("drill", drillToAdd.ID);
                student.curDrillList.Add(drillToAdd);

                studentElement.Add(newStudentDrill);
                data.Save(studentXMLPath);
            }
        }

        public void RemoveDrillFromStudentXML(Student student, Drill DrillToRemove)
        {
            XDocument data = XDocument.Load(studentXMLPath);

            XElement studentElement = data.Descendants("stu").Where(s => s.Attribute("ID").Value.Equals(student.ID.ToString())).FirstOrDefault();
            bool isDrillAlreadyAssignedToStudent = isDrillAssigned(student, DrillToRemove);
            if ((studentElement != null) && (isDrillAlreadyAssignedToStudent))
            {
                XElement newStudentDrill = new XElement("drill", DrillToRemove.ID);
                if (studentElement.Elements("drill") != null)
                {
                    foreach (XElement drill in studentElement.Elements("drill"))
                    {
                        if (DrillToRemove == student.curDrillList.Where(dri => dri.ID.Equals(Convert.ToInt32(drill.Value))).FirstOrDefault())
                        {
                            drill.Remove();
                            student.curDrillList.Remove(DrillToRemove);
                            break;
                        }  

                    }
                }
                data.Save(studentXMLPath);
            }
        }

        private bool isDrillAssigned(Student student, Drill drill)
        {
            foreach (Drill studentDrill in student.CurDrillList)
            {
                if(studentDrill.ID == drill.ID)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetNextAvailableID(string fileName, string itemTag)
        {
            XDocument data = XDocument.Load(fileName);

            return Convert.ToInt32(
                (from studentElements in data.Descendants(itemTag)
                 orderby Convert.ToInt32(studentElements.Attribute("ID").Value) descending
                 select studentElements.Attribute("ID").Value).FirstOrDefault()
                                   ) + 1;
        }

        public bool Delete(Student student, List<Student> studentList)
        {
            XDocument data = XDocument.Load(studentXMLPath);

            XElement studentElement = data.Descendants("stu").Where(s => s.Attribute("ID").Value.Equals(student.ID.ToString())).FirstOrDefault();
            if (studentElement != null)
            { 
                studentElement.Remove();
                data.Save(studentXMLPath);
                studentList.Remove(student);
            }
            return false;
        }

        public void Delete(Admin admin, List<Admin> adminList)
        {
            XDocument data = XDocument.Load(adminXMLPath);

            XElement adminElement = data.Descendants("admin").Where(s => s.Attribute("ID").Value.Equals(admin.ID.ToString())).FirstOrDefault();
            if (adminElement != null)
            {
                adminElement.Remove();
                data.Save(adminXMLPath);
                adminList.Remove(admin);
            }
        }

        public void Delete(Group group, string fileName)
        {
            XDocument data = XDocument.Load(fileName);

            XElement groupElement = data.Descendants("group").Where(s => s.Attribute("ID").Value.Equals(group.ID.ToString())).FirstOrDefault();
            if (groupElement != null)
            {
                groupElement.Remove();
                data.Save(fileName);
            }
        }

        public void Delete(Drill drill, string fileName)
        {
            XDocument data = XDocument.Load(fileName);

            XElement drillElement = data.Descendants("drill").Where(s => s.Attribute("ID").Value.Equals(drill.ID.ToString())).FirstOrDefault();
            if (drillElement != null)
            {
                drillElement.Remove();
                data.Save(fileName);
            }
        }

        private void LoadStudentXML(List<Student> studentList, List<Drill> mainDrillList, string fileName)
        {
            Console.WriteLine("LoadStudent");
            XDocument studentXML = XDocument.Load(fileName);

            XElement rootNode = FirstLevelOfRoot(studentXML);

            IEnumerable<XElement> StudentNodesQuery = SecondLevelOfRoot(rootNode);
            List<int> listOfDrillIDS = new List<int>();
            foreach (XElement student in StudentNodesQuery)
            {
                Student aStudent = new Student();
                aStudent.ID = Convert.ToInt32(student.Attribute("ID").Value);
                aStudent.Group = student.Element("group").Value;
                aStudent.LoginName = student.Element("loginName").Value;
                aStudent.LastLogin = student.Element("lastLogin").Value;
                aStudent.RecordsPath = student.Element("recPath").Value;
                Console.WriteLine(aStudent.RecordsPath);
                //aStudent.DrillsPath = CurrentDrillParser(student.Element("driPath"));
                if (student.Elements("drill") != null)
                {
                    foreach (XElement drill in student.Elements("drill"))
                    {
                        Drill newDrill = mainDrillList.Where(dri => dri.ID.Equals(Convert.ToInt32(drill.Value))).FirstOrDefault();
                        aStudent.CurDrillList.Add(newDrill);
                    }
                }
                //MessageBox.Show(aStudent.curDrillList.Count.ToString());
                // Add to student list
                studentList.Add(aStudent);
            }
        }

        public void LoadAdminXML(List<Admin> adminList, string fileName)
        {
            Console.WriteLine("LoadAdmin");
            XDocument adminXML = XDocument.Load(fileName);

            foreach (XElement admin in adminXML.Root.Nodes())
            {
                Admin administrator = new Admin();
                administrator.ID = Convert.ToInt32(admin.Attribute("ID").Value);
                administrator.LoginName = admin.Element("loginName").Value;
                administrator.Password = admin.Element("password").Value;
                administrator.LastLogin = admin.Element("lastLogin").Value;
                administrator.FilePath = admin.Element("studentPath").Value;
                adminList.Add(administrator);
            }
            Console.WriteLine("LoadAdmin");
        }

        public void LoadGroupXML(List<Group> groupList, string fileName)
        {
            Console.WriteLine("LoadGroup");
            XDocument groupXML = XDocument.Load(fileName);
            Console.WriteLine("XDocLoadGroup");
            foreach (XElement group in groupXML.Root.Nodes())
            {
                Console.WriteLine("BeforeInForEachLoop");
                Group Group = new Group();
                Console.WriteLine("GROUP");
                Group.ID = Convert.ToInt32(group.Attribute("ID").Value);
                Console.WriteLine("IDCONVERT");
                Group.Name = group.Element("groupName").Value;
                Console.WriteLine("groupNAME");
                groupList.Add(Group);
                Console.WriteLine("AfterInForEachLoop");
            }
            Console.WriteLine("AfterLoadGroup");
        }

        public void LoadDrillXML(List<Drill> drillList, string fileName)
        {
            Console.WriteLine("LoadDrill");
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
        
        public void WriteCurrentSession(Student currentStudent, Drill currentDrill)
        {
            Record RecordToAdd = new Record(currentDrill.DrillName, DateTime.Now.ToString("M/d/yyyy"), currentDrill.Questions, currentDrill.RangeStart, 
                currentDrill.RangeEnd, currentDrill.Operand, currentDrill.Wrong, currentDrill.Percent, currentDrill.Skipped);
            AddRecordToStudent(currentStudent, RecordToAdd);
            
        }
    }
}
