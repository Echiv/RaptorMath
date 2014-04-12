//==============================================================//
//					  XMLStudentDriver.cs				        //
//==============================================================//
// Program Name: RaptorMath                                     //
// Authors: Cody Jordan and Cian Carota                         //
// Purpose: This class is an XML accessor class that            //
//          specializes in manipulating student data.           //
//==============================================================//
/* 
Authors: Joshua Boone and Justine Dinh                     
Cycle 3 Changes:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace RaptorMath
{
    public class XMLStudentDriver
    {
        //XMLDriver localXMLDriver;
        public XMLStudentDriver()
        {
            
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Validation of Student XML's existence.</summary>
        /// <param name="fileName">XML's file name.</param>
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
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Accessor: Student object by ID.</summary>
        /// <param name="studentID">Student's ID.</param>
        /// <param name="studentXMLPath">Student's XML file path.</param>
        /// <returns>Student object.</returns>
        public Student GetStudentWithID(int studentID, string studentXMLPath)
        {
            XDocument Data = XDocument.Load(studentXMLPath);

            return (from student in Data.Descendants("Stu")
                    where student.Attribute("ID").Value.Equals(studentID.ToString())
                    select new Student()
                    {
                        ID = Convert.ToInt32(student.Attribute("ID").Value),
                        GroupID = Convert.ToInt32(student.Element("group").Value),
                        LoginName = student.Element("lastlogin").Value,
                        RecordsPath = student.Element("recPath").Value,
                    }).FirstOrDefault();
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Add a studet to student XML.</summary>
        /// <param name="newStudent">Student object to be added.</param>
        /// <param name="studentList">List of student objects.</param>
        /// <param name="studentXMLPath">Student XML file path.</param>
        /// <param name="dataDirectory">Data directory.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool AddUserToXML(Student newStudent, List<Student> studentList, string studentXMLPath, string dataDirectory)
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Add a record to a student in Student XML.</summary>
        /// <param name="student">Student object to be modified.</param>
        /// <param name="RecordToAdd">Record object to be added.</param>
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

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Creating Student XML for addition of first student.
        /// </summary>
        /// <param name="newStudentEntry">Student object to be added.</param>
        /// <param name="studentXMLPath">Student XML file path.</param>
        /// <param name="studentList">List of student objects.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool InitialCreateStudentXml(Student newStudentEntry, string studentXMLPath, List<Student> studentList)
        {
            XElement newStudent = CreateStudentNode(newStudentEntry);
                
            newStudent.SetAttributeValue("ID", "1");
            newStudentEntry.ID = Convert.ToInt32(newStudent.Attribute("ID").Value);

            XDocument newStudentDoc =
                new XDocument(
                    new XElement("RaptorMathStu", newStudent));
            studentList.Add(newStudentEntry);
            newStudentDoc.Save(studentXMLPath);
            return true;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Creating Record XML for addition of first record.
        /// </summary>
        /// <param name="RecordToAdd">Record object to added.</param>
        /// <param name="student">Student object related to record.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool InitialCreateRecordXML(Student student, Record RecordToAdd)
        {
            XElement newRecord = CreateRecordNode(RecordToAdd);

            newRecord.SetAttributeValue("ID", "1");
            RecordToAdd.ID = Convert.ToInt32(newRecord.Attribute("ID").Value);
            student.curRecordList.Add(RecordToAdd);

            XDocument newRecordDoc =
                new XDocument(
                    new XElement("Records", newRecord));
            newRecordDoc.Save(student.RecordsPath);
            return true;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Adding a new student to Student XML.</summary>
        /// <param name="newStudent">Student object to be added.</param>
        /// <param name="studentXMLPath">Student XML's file path.</param>
        /// <param name="studentList">List of student objects.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool AddNewStudent(Student newStudent, string studentXMLPath, List<Student> studentList)
        {
            XDocument data = XDocument.Load(studentXMLPath);

            XElement studentElement =
                data.Descendants("stu").Where(s => s.Element("loginName").Value == newStudent.LoginName).FirstOrDefault();
            if (studentElement != null)
            {
                return false;
            }
            else
            {
                XElement student = CreateStudentNode(newStudent);

                student.SetAttributeValue("ID", GetNextAvailableID(studentXMLPath, "stu"));
                newStudent.ID = Convert.ToInt32(student.Attribute("ID").Value);

                data.Element("RaptorMathStu").Add(student);
                studentList.Add(newStudent);
                data.Save(studentXMLPath);
                return true;
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Adding a new record to Student XML. </summary>
        /// <param name="student">Student object to be modified.</param>
        /// <param name="RecordToAdd">Record to be added.</param>
        /// <returns>Boolean confirmation.</returns>
        public bool AddNewRecord(Student student, Record RecordToAdd)
        {
            XDocument data = XDocument.Load(student.RecordsPath);

            XElement newRecord = CreateRecordNode(RecordToAdd);

            newRecord.SetAttributeValue("ID", GetNextAvailableID(student.RecordsPath, "record"));
            RecordToAdd.ID = Convert.ToInt32(newRecord.Attribute("ID").Value);

            data.Element("Records").Add(newRecord);
            student.curRecordList.Add(RecordToAdd);
            data.Save(student.RecordsPath);
            return true;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Edit data in Student XML.</summary>
        /// <param name="newFName">Student's first name.</param>
        /// <param name="newLName">Student's last name.</param>
        /// <param name="selectedStudent">Student object to be modified</param>
        /// <param name="group">Group object associated with student.</param>
        /// <param name="studentList">List of student objects.</param>
        /// <returns>bool, bool</returns>
        public Tuple<bool, bool> editStudent(string newFName, string newLName, Student selectedStudent, Group group, List<Student> studentList, string studentXMLPath, string groupXMLPath, string dataDirectory)
        {
            bool hasGroupChanged = false;
            bool hasStudentChanged = false;
            if (selectedStudent != null)
            {
                hasGroupChanged = compareOldAndNewStudentInfo(newFName, newLName, selectedStudent, group);
                hasStudentChanged = UpdateStudent(selectedStudent, studentXMLPath, groupXMLPath, dataDirectory);
            }
            else
            {
                MessageBox.Show("That Student could not be found", "Raptor Math", MessageBoxButtons.OK);
            }
            return Tuple.Create(hasGroupChanged, hasStudentChanged);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Check for change in data.</summary>
        /// <param name="newFName">Student's first name.</param>
        /// <param name="newLName">Student's last name.</param>
        /// <param name="selectedStudent">Student object to check.</param>
        /// <param name="newGroup">Associated group's name.</param>
        /// <returns>Boolean confirmation of change.</returns>
        public bool compareOldAndNewStudentInfo(string newFName, string newLName, Student selectedStudent, Group newGroup/*, int oldGroup*/)
        {
            bool hasGroupChanged = false;
            if ((newFName != selectedStudent.FirstName) && (newFName != string.Empty))
                selectedStudent.FirstName = newFName;
            if ((newLName != selectedStudent.LastName) && (newLName != string.Empty))
                selectedStudent.LastName = newLName;
            if (newGroup != null)
            { 
                selectedStudent.GroupID = newGroup.ID;
                hasGroupChanged = true;
            }
            else
            {
                selectedStudent.GroupID = 0;
            }
            selectedStudent.LoginName = selectedStudent.FirstName + " " + selectedStudent.LastName;
            return hasGroupChanged;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Update student data in Student XML.</summary>
        /// <param name="student">Student object to be modified.</param>
        /// <param name="studentXMLPath">Student XML file path.</param>
        /// <param name="groupXMLPath">Group XML file path.</param>
        /// <param name="dataDirectory">Data Directory.</param>
        /// <returns>Boolean confirming success.</returns>
        public bool UpdateStudent(Student student, string studentXMLPath, string groupXMLPath, string dataDirectory)
        {
            XDocument data = XDocument.Load(studentXMLPath);
            XElement studentIDElement = data.Descendants("stu").Where(stu => stu.Attribute("ID").Value.Equals(student.ID.ToString())).FirstOrDefault();
            XElement studentNameElement = data.Descendants("stu").Where(stu => stu.Element("loginName").Value.Equals(student.LoginName)).FirstOrDefault();

            XDocument groupData = XDocument.Load(groupXMLPath);
            XElement GroupElement = groupData.Descendants("group").Where(group => group.Attribute("ID").Value.Equals(student.GroupID.ToString())).FirstOrDefault();

            if ((studentIDElement != null) || (GroupElement != null))
            {
                if (studentNameElement == null)
                {
                    string oldRecordPath = student.RecordsPath;
                    string recordPath = student.LoginName.Replace(" ", "") + "Records.xml";
                    student.RecordsPath = System.IO.Path.Combine(dataDirectory, recordPath);
                    if (System.IO.File.Exists(oldRecordPath))
                    {
                        System.IO.File.Move(oldRecordPath, student.RecordsPath);
                    }
                    studentIDElement.SetElementValue("loginName", student.LoginName);
                    studentIDElement.SetElementValue("firstName", student.FirstName);
                    studentIDElement.SetElementValue("lastName", student.LastName);
                    studentIDElement.SetElementValue("recPath", student.RecordsPath);
                    if (GroupElement != null)
                        studentIDElement.SetElementValue("group", student.GroupID);
                    data.Save(studentXMLPath);
                    return true;
                }
                if (GroupElement != null)
                {
                    studentIDElement.SetElementValue("group", student.GroupID);
                    data.Save(studentXMLPath);
                    return true;
                }
                if (GroupElement == null)
                {
                    MessageBox.Show("Group name entered does not exist", "Raptor Math", MessageBoxButtons.OK);
                    return false;
                }                
            }
            
            return false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Add a drill to a student in Student XML.</summary>
        /// <param name="student">Student object to be modified</param>
        /// <param name="drillToAdd">Drill object to be added.</param>
        /// <param name="studentXMLPath">Student XML file path.</param>
        /// <returns>Boolean confirming success.</returns>
        public bool AddDrillToStudentXML(Student student, Drill drillToAdd, string studentXMLPath)
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
                return true;
            }
            return false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Remove a drill from a student in Student XML.</summary>
        /// <param name="student">Student object to be modified</param>
        /// <param name="DrillToRemove">Drill object to be removed.</param>
        /// <param name="studentXMLPath">Student XML file path.</param>
        /// <returns>Boolean confirming success.</returns>
        public bool RemoveDrillFromStudentXML(Student student, Drill DrillToRemove, string studentXMLPath)
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
                            data.Save(studentXMLPath);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Check if drill already is assigned to a particular
        /// student.</summary>
        /// <param name="student"></param>
        /// <param name="drill"></param>
        /// <returns></returns>
        public bool isDrillAssigned(Student student, Drill drill)
        {
            foreach (Drill studentDrill in student.CurDrillList)
            {
                if (studentDrill.ID == drill.ID)
                {
                    return true;
                }
            }
            return false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Delete a student's data from Student XML.</summary>
        /// <param name="student">Student object to be deleted.</param>
        /// <param name="studentList">List of student objects.</param>
        /// <param name="studentXMLPath">Student XML file path.</param>
        /// <returns>Boolean confirming success.</returns>
        public bool Delete(Student student, List<Student> studentList, string studentXMLPath)
        {
            XDocument data = XDocument.Load(studentXMLPath);

            XElement studentElement = data.Descendants("stu").Where(s => s.Attribute("ID").Value.Equals(student.ID.ToString())).FirstOrDefault();
            if (studentElement != null)
            {
                if (System.IO.File.Exists(student.RecordsPath))
                    System.IO.File.Delete(student.RecordsPath);
                studentElement.Remove();
                data.Save(studentXMLPath);
                studentList.Remove(student);
                return true;
            }
            return false;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Load a list of students from XML to local.</summary>
        /// <param name="studentList">List of student objects to be populated.
        /// </param>
        /// <param name="mainDrillList">List of drill objects</param>
        /// <param name="fileName">XML file name.</param>
        public void LoadStudentXML(List<Student> studentList, List<Drill> mainDrillList, string fileName)
        {
            XDocument studentXML = XDocument.Load(fileName);

            XElement rootNode = studentXML.Root;

            IEnumerable<XElement> StudentNodesQuery = SecondLevelOfRoot(rootNode);
            List<int> listOfDrillIDS = new List<int>();
            foreach (XElement student in StudentNodesQuery)
            {
                Student aStudent = new Student();
                aStudent.ID = Convert.ToInt32(student.Attribute("ID").Value);
                aStudent.GroupID = Convert.ToInt32(student.Element("group").Value);
                aStudent.FirstName = student.Element("firstName").Value;
                aStudent.LastName = student.Element("lastName").Value;
                aStudent.LoginName = student.Element("loginName").Value;
                aStudent.LastLogin = student.Element("lastLogin").Value;
                aStudent.RecordsPath = student.Element("recPath").Value;
                if (student.Elements("drill") != null)
                {
                    foreach (XElement drill in student.Elements("drill"))
                    {
                        Drill newDrill = mainDrillList.Where(dri => dri.ID.Equals(Convert.ToInt32(drill.Value))).FirstOrDefault();
                        aStudent.CurDrillList.Add(newDrill);
                    }
                }
                LoadStudentRecord(aStudent);
                
                studentList.Add(aStudent);
            }
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Add data from active session to XML.</summary>
        /// <param name="currentStudent">Student object to be modified.</param>
        /// <param name="currentDrill">Drill object to be modified.</param>
        public void WriteCurrentSession(Student currentStudent, Drill currentDrill)
        {
            Record RecordToAdd = new Record(currentDrill.ID, currentDrill.DrillName, DateTime.Now.ToString("M/d/yyyy"), currentDrill.Questions, currentDrill.RangeStart,
                currentDrill.RangeEnd, currentDrill.Operand, currentDrill.Wrong, currentDrill.Percent, currentDrill.Skipped);
            AddRecordToStudent(currentStudent, RecordToAdd);
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Search for next ID availabe to be assigned.</summary>
        /// <param name="fileName">XML file name.</param>
        /// <param name="itemTag">Item tag.</param>
        /// <returns>Int</returns>
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
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Define third level of root in XML.</summary>
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
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Add a record node to Record XML.</summary>
        /// <param name="RecordToAdd">Record object to be added.</param>
        /// <returns>XElement</returns>
        private XElement CreateRecordNode(Record RecordToAdd)
        {
            XElement newRecord =
                new XElement("record",
                    new XElement("drillID", RecordToAdd.DrillID),
                    new XElement("drillName", RecordToAdd.DrillName),
                    new XElement("dataTaken", RecordToAdd.DateTaken),
                    new XElement("questions", RecordToAdd.Question),
                    new XElement("rangeStart", RecordToAdd.RangeStart),
                    new XElement("rangeEnd", RecordToAdd.RangeEnd),
                    new XElement("operand", RecordToAdd.Operation),
                    new XElement("wrong", RecordToAdd.Wrong),
                    new XElement("skipped", RecordToAdd.Skipped),
                    new XElement("percent", RecordToAdd.Percent));
            return newRecord;
        }

        //------------------------------------------------------------------//
        // Authors: Cody Jordan, Cian Carota                                //
        // Date: 4/5/14                                                     //
        //------------------------------------------------------------------//
        /// <summary>Add a student node to Student XML.</summary>
        /// <param name="newStudentEntry">Student object to be added.</param>
        /// <returns>XElement</returns>
        private XElement CreateStudentNode(Student newStudentEntry)
        {
            XElement newStudent =
                new XElement("stu",
                    new XElement("group", newStudentEntry.GroupID),
                    new XElement("firstName", newStudentEntry.FirstName),
                    new XElement("lastName", newStudentEntry.LastName),
                    new XElement("loginName", newStudentEntry.LoginName),
                    new XElement("lastLogin", newStudentEntry.LastLogin),
                    new XElement("recPath", newStudentEntry.RecordsPath));
            return newStudent;
        }

        private void LoadStudentRecord(Student aStudent)
        {
            if (System.IO.File.Exists(aStudent.RecordsPath))
            {
                XDocument studentRecordsXML = XDocument.Load(aStudent.RecordsPath);
                IEnumerable<XElement> RecordsNodesQuery = SecondLevelOfRoot(studentRecordsXML.Root);

                foreach (XElement record in RecordsNodesQuery)
                {
                    Record newRecord = new Record();
                    newRecord.ID = Convert.ToInt32(record.Attribute("ID").Value);
                    newRecord.DrillID = Convert.ToInt32(record.Element("drillID").Value);
                    newRecord.DrillName = record.Element("drillName").Value;
                    newRecord.DateTaken = record.Element("dataTaken").Value;
                    newRecord.Question = record.Element("questions").Value;
                    newRecord.RangeStart = record.Element("rangeStart").Value;
                    newRecord.RangeEnd = record.Element("rangeEnd").Value;
                    newRecord.Operation = record.Element("operand").Value;
                    newRecord.Wrong = record.Element("wrong").Value;
                    newRecord.Skipped = record.Element("skipped").Value;
                    newRecord.Percent = record.Element("percent").Value;
                    aStudent.curRecordList.Add(newRecord);
                }
            }
        }
    }
}
