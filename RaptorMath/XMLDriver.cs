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
        private XMLStudentDriver XMLStudentDriver = new XMLStudentDriver();

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>XMLDriver object default constructor.</summary>
        public XMLDriver()
        {
            adminXMLPath = "Unknown";
            studentXMLPath = "Unknown";
            groupXMLPath = "Unknown";
            drillXMLPath = "Unknown";
            dataDirectory = "Unknown";
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>>XMLDriver object constructor.</summary>
        /// <param name="adminXML">Admin XML's path.</param>
        /// <param name="studentXML">Student XML's path.</param>
        /// <param name="groupXML">Group XML's path.</param>
        /// <param name="drillXML">Drill XML's path.</param>
        /// <param name="DataDirectory">Data directory.</param>
        public XMLDriver(string adminXML, string studentXML, string groupXML, string drillXML, string DataDirectory)
        {
            adminXMLPath = adminXML;
            studentXMLPath = studentXML;
            groupXMLPath = groupXML;
            drillXMLPath = drillXML;
            dataDirectory = DataDirectory;

        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Validation of Admin XML's existence.</summary>
        /// <param name="fileName">XML's file name.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool adminXMLExists(string fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                return false;
            }
            return true;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Validation of Student XML's existence.</summary>
        /// <param name="fileName">Validation of Admin XML's existence.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool studentXMLExists(string fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                return false;
            }
            return true;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Checks for, and if necessary creates, core XML files;
        /// Admin, Group, Drill.</summary>
        /// <param name="adminList">List of admin objects.</param>
        /// <param name="studentList">List of student objects.</param>
        /// <param name="groupList">List of group objects.</param>
        /// <param name="mainDrillList">List of drill objects.</param>
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

            LoadAdminXML(adminList, adminXMLPath);
            
            LoadDrillXML(mainDrillList, drillXMLPath);
            LoadGroupXML(groupList, mainDrillList, groupXMLPath);
            if (studentXMLExists(studentXMLPath))
                XMLStudentDriver.LoadStudentXML(studentList, mainDrillList, studentXMLPath);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Accessor: Student object by ID.</summary>
        /// <param name="studentID">Student's ID.</param>
        /// <param name="studentXMLPath">Student's XML file path.</param>
        /// <returns>Student object.</returns>
        public Student GetStudentWithID(int studentID, string studentXMLPath)
        {
            return XMLStudentDriver.GetStudentWithID(studentID, studentXMLPath);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Add a studet to student XML.</summary>
        /// <param name="newStudent">Student object to be added.</param>
        /// <param name="studentList">List of student objects.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool AddUserToXML(Student newStudent, List<Student> studentList)
        {
            return XMLStudentDriver.AddUserToXML(newStudent, studentList, studentXMLPath, dataDirectory);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Add an admin to admin XML.</summary>
        /// <param name="newAdmin">Admin object to be added.</param>
        /// <param name="adminList">List of admin objects.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool AddUserToXML(Admin newAdmin, List<Admin> adminList)
        {
            return AddNewAdmin(newAdmin, adminXMLPath, adminList);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Add a record to student data.</summary>
        /// <param name="student">Student object to be modified.</param>
        /// <param name="RecordToAdd">Record object to be added.</param>
        public void AddRecordToStudent(Student student, Record RecordToAdd)
        {
            XMLStudentDriver.AddRecordToStudent(student, RecordToAdd);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Creating Student XML for addition of first student.
        /// </summary>
        /// <param name="newStudentEntry">Student object to be added.</param>
        /// <param name="studentXMLPath">Student XML file path.</param>
        /// <param name="studentList">List of student objects.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool InitialCreateStudentXml(Student newStudentEntry, string studentXMLPath, List<Student> studentList)
        {
            return XMLStudentDriver.InitialCreateStudentXml(newStudentEntry, studentXMLPath, studentList);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Creating Admin XML for addition of first Admin.</summary>
        /// <param name="newAdminEntry">Admin object to be added.</param>
        /// <param name="adminXMLPath">Admin XML file path.</param>
        /// <param name="adminList">List of admin objects.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool InitialCreateAdminXml(Admin newAdminEntry, string adminXMLPath, List<Admin> adminList)
        {
            XElement newAdmin = CreateAdminNode(newAdminEntry);
                
            newAdmin.SetAttributeValue("ID", "1");
            newAdminEntry.ID = Convert.ToInt32(newAdmin.Attribute("ID").Value);

            XDocument newAdminDoc =
                new XDocument(
                    new XElement("RaptorMathAdmin", newAdmin));

            newAdminDoc.Save(adminXMLPath);
            adminList.Add(newAdminEntry);
            return true;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Default creation of Admin XML file.</summary>
        /// <param name="AdminXMLPath">Admin XML file path.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool InitialCreateAdminXml(string AdminXMLPath)
        {
            Admin DefaultAdmin = new Admin("Admin", "", "Admin", DateTime.Now.ToString("M/d/yyyy"), "RaptopMathStudents.xml");
            DefaultAdmin.ID = 1;

            XElement newAdmin = CreateAdminNode(DefaultAdmin);
            newAdmin.SetAttributeValue("ID", DefaultAdmin.ID);

            XDocument newAdminDoc =
                new XDocument(
                    new XElement("RaptorMathAdmin", newAdmin));

            newAdminDoc.Save(AdminXMLPath);
            return true;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Default creation of Group XML file.</summary>
        /// <param name="GroupXMLPath">Group XML file path.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool InitialCreateGroupXML(string GroupXMLPath)
        {
            XElement newGroup =
                new XElement("group",
                    new XElement("groupName", "Unassigned"));
            newGroup.SetAttributeValue("ID", "1");

            XDocument newGroupDoc =
                new XDocument(
                    new XElement("RaptorMathGroups", newGroup));
            newGroupDoc.Save(GroupXMLPath);
            return true;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Default creation of Drill XML file.</summary>
        /// <param name="DrillXMLPath">Drill XML file path.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool InitialCreateDrillXML(string DrillXMLPath)
        {
            Drill DrillOne = new Drill("10AddProb1to25", "10", "1", "25", "addition");
            DrillOne.ID = 1;
            XElement defaultDrillOne = CreateDrillNode(DrillOne);
            defaultDrillOne.SetAttributeValue("ID", DrillOne.ID);

            Drill DrillTwo = new Drill("10SubProb1to25", "10", "1", "25", "subtract");
            DrillTwo.ID = 2;
            XElement defaultDrillTwo = CreateDrillNode(DrillTwo);
            defaultDrillTwo.SetAttributeValue("ID", DrillTwo.ID);
            
            XDocument newDrillsDoc =
                new XDocument(
                    new XElement("RaptorMathDrills", defaultDrillOne, defaultDrillTwo));
            newDrillsDoc.Save(DrillXMLPath);
            return true;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Creating Record XML for addition of first record.
        /// </summary>
        /// <param name="RecordToAdd">Record object to added.</param>
        /// <param name="student">Student object related to record.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool InitialCreateRecordXML(Student student, Record RecordToAdd)
        {
            return XMLStudentDriver.InitialCreateRecordXML(student, RecordToAdd);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Adding a new student to Student XML.</summary>
        /// <param name="student">Student object to be added.</param>
        /// <param name="studentXMLPath">Student XML's file path.</param>
        /// <param name="studentList">List of student objects.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool AddNewStudent(Student student, string studentXMLPath, List<Student> studentList)
        {
            return XMLStudentDriver.AddNewStudent(student, studentXMLPath, studentList);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Adding a new admin to Admin XML.</summary>
        /// <param name="admin">Admin object to be added.</param>
        /// <param name="fileName">Admin XML file name.</param>
        /// <param name="adminList">List of admin objects.</param>
        /// <returns>Boolean confirmation.</returns>
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
                XElement newAdmin = CreateAdminNode(admin);
                    
                newAdmin.SetAttributeValue("ID", GetNextAvailableID(fileName, "admin"));
                admin.ID = Convert.ToInt32(newAdmin.Attribute("ID").Value);

                data.Element("RaptorMathAdmin").Add(newAdmin);
                adminList.Add(admin);
                data.Save(fileName);
                return true;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Adding a new group to Group XML. </summary>
        /// <param name="groupName">Group name.</param>
        /// <param name="groupList">List of group objects.</param>
        /// <returns>Boolean confirmation.</returns>
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Adding a new drill to Drill XML. </summary>
        /// <param name="drill">Drill name.</param>
        /// <param name="drillList">List of drill objects.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool AddNewDrill(Drill drill, List<Drill> drillList)
        {
            XDocument data = XDocument.Load(drillXMLPath);

            XElement DrillElement =
                data.Descendants("drill").Where(s => s.Element("drillName").Value == drill.DrillName).FirstOrDefault();
            if (DrillElement != null)
            {
                MessageBox.Show("A Drill with that name already exists! Please choose a different name", "Raptor Math", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                XElement newDrill = CreateDrillNode(drill);
                    
                newDrill.SetAttributeValue("ID", GetNextAvailableID(drillXMLPath, "drill"));
                drill.ID = Convert.ToInt32(newDrill.Attribute("ID").Value);

                data.Element("RaptorMathDrills").Add(newDrill);
                drillList.Add(drill);
                data.Save(drillXMLPath);
                return true;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Adding a new record to Student XML. </summary>
        /// <param name="student">Student object to be modified.</param>
        /// <param name="RecordToAdd">Record to be added.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool AddNewRecord(Student student, Record RecordToAdd)
        {
            return XMLStudentDriver.AddNewRecord(student, RecordToAdd);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Edit admin data.</summary>
        /// <param name="newPassword">New password.</param>
        /// <param name="admin">Admin object.</param>
        /// <param name="adminList">List of admin objects.</param>
        /// <returns>Boolean success confirmation.</returns>
        public bool editAdmin(string newPassword, Admin admin, List<Admin> adminList)
        {
            if (admin != null)
            {
                if (newPassword.All(char.IsLetterOrDigit))
                {
                    admin.Password = newPassword;
                    UpdateAdmin(admin, adminXMLPath);
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Edit group data.</summary>
        /// <param name="newName">New group name.</param>
        /// <param name="currentName">Current group name.</param>
        /// <param name="groupList">List of group objects.</param>
        /// <returns>Boolean success confirmation.</returns>
        public bool editGroup(string newName, string currentName, List<Group> groupList)
        {
            Group modifiedGroup = new Group();
            foreach (Group group in groupList)
            {
                if(group.Name == currentName)
                {
                    modifiedGroup.ID = group.ID;
                    modifiedGroup.Name = newName;
                    UpdateGroup(group, modifiedGroup);
                    return true;
                }
            }
            return false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Edit data in Student XML.</summary>
        /// <param name="newFName">Student's first name.</param>
        /// <param name="newLName">Student's last name.</param>
        /// <param name="selectedStudent">Student object to be modified</param>
        /// <param name="group">Group object associated with student.</param>
        /// <param name="studentList">List of student objects.</param>
        /// <returns>bool, bool</returns>
        public Tuple<bool, bool> editStudent(string newFName, string newLName, Student selectedStudent, Group group, List<Student> studentList)
        {
            return XMLStudentDriver.editStudent(newFName, newLName, selectedStudent, group, studentList, studentXMLPath, groupXMLPath, dataDirectory);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Edit data in Group XML.</summary>
        /// <param name="group">Group object to be replaced.</param>
        /// <param name="modifiedGroup">Group object to be inserted.</param>
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Update admin XML.</summary>
        /// <param name="admin">Admin object.</param>
        /// <param name="adminXMLPath">Admin XML file path.</param>
        private void UpdateAdmin(Admin admin, string adminXMLPath)
        {
            XDocument data = XDocument.Load(adminXMLPath);

            XElement adminIDElement = data.Descendants("admin").Where(adm => adm.Attribute("ID").Value.Equals(admin.ID.ToString())).FirstOrDefault();

            if (adminIDElement != null)
            {
                adminIDElement.SetElementValue("password", admin.Password);
                data.Save(adminXMLPath);
            }
        }
        
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Add a drill to Student XML.</summary>
        /// <param name="student">Student object to be modified.</param>
        /// <param name="drillToAdd">Drill object to be added.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool AddDrillToStudentXML(Student student, Drill drillToAdd)
        {
            return XMLStudentDriver.AddDrillToStudentXML(student, drillToAdd, studentXMLPath);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Add a drill to a group XML.</summary>
        /// <param name="group">Group oject to be modified.</param>
        /// <param name="drillToAdd">Drill object to be added.</param>
        /// <returns>Boolean success confirmation.</returns>
        public bool AddDrillToGroupXML(Group group, Drill drillToAdd)
        {
            XDocument data = XDocument.Load(groupXMLPath);

            XElement groupElement = data.Descendants("group").Where(grp => grp.Attribute("ID").Value.Equals(group.ID.ToString())).FirstOrDefault();
            bool isDrillAlreadyAssignedToGroup = isDrillAssignedToGroup(group, drillToAdd);
            if ((groupElement != null) && (!isDrillAlreadyAssignedToGroup))
            {
                XElement newStudentDrill = new XElement("drill", drillToAdd.ID);
                group.groupDrillList.Add(drillToAdd);

                groupElement.Add(newStudentDrill);
                data.Save(groupXMLPath);
                return true;
            }
            return false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Check if drill is already associated with a group.
        /// </summary>
        /// <param name="group">Group object to check against.</param>
        /// <param name="drill">Drill object to check for.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool isDrillAssignedToGroup(Group group, Drill drill)
        {
            foreach (Drill groupDrill in group.groupDrillList)
            {
                if (groupDrill.ID == drill.ID)
                {
                    return true;
                }
            }
            return false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Remove a drill from Group XML.</summary>
        /// <param name="group">Group object to be modified.</param>
        /// <param name="DrillToRemove">Drill object to be removed.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool RemoveDrillFromGroupXML(Group group, Drill DrillToRemove)
        {
            XDocument data = XDocument.Load(groupXMLPath);

            XElement groupElement = data.Descendants("group").Where(s => s.Attribute("ID").Value.Equals(group.ID.ToString())).FirstOrDefault();
            bool isDrillAlreadyAssignedToStudent = isDrillAssignedToGroup(group, DrillToRemove);
            if ((groupElement != null) && (isDrillAlreadyAssignedToStudent))
            {
                XElement newStudentDrill = new XElement("drill", DrillToRemove.ID);
                if (groupElement.Elements("drill") != null)
                {
                    foreach (XElement drill in groupElement.Elements("drill"))
                    {
                        if (DrillToRemove == group.groupDrillList.Where(dri => dri.ID.Equals(Convert.ToInt32(drill.Value))).FirstOrDefault())
                        {
                            drill.Remove();
                            group.groupDrillList.Remove(DrillToRemove);
                            data.Save(groupXMLPath);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Remove a drill from Student XML.</summary>
        /// <param name="student">Student object to be modified.</param>
        /// <param name="DrillToRemove">Drill object to be removed.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool RemoveDrillFromStudentXML(Student student, Drill DrillToRemove)
        {
            return XMLStudentDriver.RemoveDrillFromStudentXML(student, DrillToRemove, studentXMLPath);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Check if a drill has been assigned.</summary>
        /// <param name="student">Student object to be checked.</param>
        /// <param name="drill">Drill object to check for.</param>
        /// <returns>Boolean confirmation.</returns>
        private bool isDrillAssigned(Student student, Drill drill)
        {
            return XMLStudentDriver.isDrillAssigned(student, drill);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Search for next ID to be assigned.</summary>
        /// <param name="fileName">File name to search in.</param>
        /// <param name="itemTag">Item tag.</param>
        /// <returns>Integer</returns>
        public int GetNextAvailableID(string fileName, string itemTag)
        {
            XDocument data = XDocument.Load(fileName);

            return Convert.ToInt32(
                (from studentElements in data.Descendants(itemTag)
                 orderby Convert.ToInt32(studentElements.Attribute("ID").Value) descending
                 select studentElements.Attribute("ID").Value).FirstOrDefault()
                                   ) + 1;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Delete a student from Student XML.</summary>
        /// <param name="student">Student object to be removed.</param>
        /// <param name="studentList">List of student object.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool Delete(Student student, List<Student> studentList)
        {
            return XMLStudentDriver.Delete(student, studentList, studentXMLPath);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Delete an admin from Admin XML.</summary>
        /// <param name="admin">Admin object to be removed.</param>
        /// <param name="adminList">List of admin object.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool Delete(Admin admin, List<Admin> adminList)
        {
            XDocument data = XDocument.Load(adminXMLPath);

            XElement adminElement = data.Descendants("admin").Where(s => s.Attribute("ID").Value.Equals(admin.ID.ToString())).FirstOrDefault();
            if (adminElement != null)
            {
                adminElement.Remove();
                data.Save(adminXMLPath);
                adminList.Remove(admin);
                return true;
            }
            return false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Delete an group from an XML file.</summary>
        /// <param name="group">Group object to be deleted.</param>
        /// <param name="fileName">XML file name.</param>
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Delete an drill from an XML file.</summary>
        /// <param name="drill">Drill object to be deleted.</param>
        /// <param name="fileName">XML file name.</param>
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Load a list of students from XML to local.</summary>
        /// <param name="studentList">List of student objects to be populated.
        /// </param>
        /// <param name="mainDrillList">List of drill objects</param>
        /// <param name="fileName">XML file name.</param>
        private void LoadStudentXML(List<Student> studentList, List<Drill> mainDrillList, string fileName)
        {
            XMLStudentDriver.LoadStudentXML(studentList, mainDrillList, fileName);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Load a list of admins from XML to local.</summary>
        /// <param name="adminList">List of admin objects to be populated.
        /// </param>
        /// <param name="fileName">XML file name.</param>
        public void LoadAdminXML(List<Admin> adminList, string fileName)
        {
            XDocument adminXML = XDocument.Load(fileName);

            foreach (XElement admin in adminXML.Root.Nodes())
            {
                Admin administrator = new Admin();
                administrator.ID = Convert.ToInt32(admin.Attribute("ID").Value);
                administrator.FirstName = admin.Element("firstName").Value;
                administrator.LastName = admin.Element("lastName").Value;
                administrator.LoginName = admin.Element("loginName").Value;
                administrator.Password = admin.Element("password").Value;
                administrator.LastLogin = admin.Element("lastLogin").Value;
                administrator.FilePath = admin.Element("studentPath").Value;
                adminList.Add(administrator);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Load a list of groups from XML to local.</summary>
        /// <param name="groupList">List of group objects to be populated.
        /// </param>
        /// <param name="mainDrillList">List of drill objects</param>
        /// <param name="fileName">XML file name.</param>
        public void LoadGroupXML(List<Group> groupList, List<Drill> mainDrillList, string fileName)
        {
            XDocument groupXML = XDocument.Load(fileName);
            foreach (XElement group in groupXML.Root.Nodes())
            {
                Group Group = new Group();
                Group.ID = Convert.ToInt32(group.Attribute("ID").Value);
                Group.Name = group.Element("groupName").Value;
                if(group.Elements("drill") != null)
                {
                    foreach(XElement drill in group.Elements("drill"))
                    {
                        Drill newDrill = mainDrillList.Where(dri => dri.ID.Equals(Convert.ToInt32(drill.Value))).FirstOrDefault();
                        Group.groupDrillList.Add(newDrill);
                    }
                }
                groupList.Add(Group);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Load a list of drills from XML to local.</summary>
        /// <param name="drillList">List of drill objects to be populated.
        /// </param>
        /// <param name="fileName">XML file name.</param>
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Define first level of root in XML.</summary>
        /// <param name="XMLFile">XML file being used.</param>
        /// <returns>XElement</returns>
        private XElement FirstLevelOfRoot(XDocument XMLFile)
        {
            return XMLFile.Root;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Define second level of root in XML.</summary>
        /// <param name="RootNode">XML's root node.</param>
        /// <returns>IEnumerable<XElement></returns>
        private IEnumerable<XElement> SecondLevelOfRoot(XElement RootNode)
        {
            IEnumerable<XElement> SecondLevelChildrenQuery =
                from secondLevel in RootNode.Elements()
                select secondLevel;
            return SecondLevelChildrenQuery;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/1/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Define third level of root in XML.</summary>
        /// <param name="RootNode">XML's root node.</param>
        /// <returns>IEnumerable<XElement></returns>
        private IEnumerable<XElement> ThirdLevelOfRoot(XElement SecondLevelNode)
        {
            IEnumerable<XElement> ThirdLevelChildrenQuery =
                from ThirdLevel in SecondLevelNode.Elements()
                select ThirdLevel;
            return ThirdLevelChildrenQuery;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Add data from active session to XML.</summary>
        /// <param name="currentStudent">Student object to be modified.</param>
        /// <param name="currentDrill">Drill object to be modified.</param>
        public void WriteCurrentSession(Student currentStudent, Drill currentDrill)
        {
            XMLStudentDriver.WriteCurrentSession(currentStudent, currentDrill);
            /*
            Record RecordToAdd = new Record(currentDrill.DrillName, DateTime.Now.ToString("M/d/yyyy"), currentDrill.Questions, currentDrill.RangeStart, 
                currentDrill.RangeEnd, currentDrill.Operand, currentDrill.Wrong, currentDrill.Percent, currentDrill.Skipped);
            AddRecordToStudent(currentStudent, RecordToAdd);*/

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

                    if (userName == fullName)
                    {
                        admin.Element("lastLogin").Value = date;
                    }
                }
                admin_doc.Save(fileName);
            }
            else
            {
                XDocument student_doc = XDocument.Load(fileName);
                XElement student_root = FirstLevelOfRoot(student_doc);

                IEnumerable<XElement> students = SecondLevelOfRoot(student_root);
                foreach (XElement student in students)
                {
                    string fullName = student.Element("loginName").Value;

                    if (userName == fullName)
                    {
                        student.Element("lastLogin").Value = date;
                        break;
                    }
                }

                student_doc.Save(fileName);
            }
        }

        //------------------------------------------------------------------//
        // Kyle Bridges                                                     //
        // Date: 2/26/2014                                                  //
        // Checks if the file exists, returns bool                          //
        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Check if a file exists.</summary>
        /// <param name="fileName">File name to check for.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool FileExists(string fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                MessageBox.Show("Oops something happened to the XML, restart the program!", "Raptor Math", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Add an admin node to Admin XML.</summary>
        /// <param name="newAdmin">Admin object to be added.</param>
        /// <returns>XElement</returns>
        public XElement CreateAdminNode(Admin newAdmin)
        {
            XElement admin =
                new XElement("admin",
                    new XElement("firstName", newAdmin.FirstName),
                    new XElement("lastName", newAdmin.LastName),
                    new XElement("loginName", newAdmin.LoginName),
                    new XElement("password", newAdmin.Password),
                    new XElement("studentPath", newAdmin.FilePath),
                    new XElement("lastLogin", newAdmin.LastLogin));
            return admin;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date:                                                   //
        //------------------------------------------------------------------//
        /// <summary>Add a drill node to Drill XML.</summary>
        /// <param name="newDrill">Drill object to be added.</param>
        /// <returns>XElement</returns>
        public XElement CreateDrillNode(Drill newDrill)
        {
            XElement drill =
                new XElement("drill",
                    new XElement("drillName", newDrill.DrillName),
                    new XElement("questions", newDrill.Questions),
                    new XElement("rangeStart", newDrill.RangeStart),
                    new XElement("rangeEnd", newDrill.RangeEnd),
                    new XElement("operand", newDrill.Operand),
                    new XElement("wrong", newDrill.Wrong),
                    new XElement("skipped", newDrill.Skipped),
                    new XElement("percent", newDrill.Percent));
            return drill;
        }
    }
}
