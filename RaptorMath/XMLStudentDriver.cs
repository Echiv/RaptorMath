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

        public bool studentXMLExists(string fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                return false;
            }
            return true;
        }

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

        public bool editStudent(string newFName, string newLName, Student selectedStudent, Group group, List<Student> studentList, string studentXMLPath, string groupXMLPath, string dataDirectory)
        {
            Student modifySelectedStudent = studentList.Where(stu => stu.ID.ToString().Equals(selectedStudent.ID.ToString())).FirstOrDefault();
            bool hasGroupChanged = false;
            if (selectedStudent != null)
            {
                int groupID = 0;
                if (group != null)
                {
                    groupID = group.ID;
                }
                hasGroupChanged = compareOldAndNewStudentInfo(newFName, newLName, selectedStudent, groupID);
                UpdateStudent(selectedStudent, studentXMLPath, groupXMLPath, dataDirectory);
                MessageBox.Show("The Student was successfully modified!");
            }
            else
            {
                MessageBox.Show("That Student could not be found!");
            }
            return hasGroupChanged;
        }

        public bool compareOldAndNewStudentInfo(string newFName, string newLName, Student selectedStudent, int newGroup/*, int oldGroup*/)
        {
            bool hasGroupChanged = false;
            if ((newFName != selectedStudent.FirstName) && (newFName != string.Empty))
                selectedStudent.FirstName = newFName;
            if ((newLName != selectedStudent.LastName) && (newLName != string.Empty))
                selectedStudent.LastName = newLName;
            if ((newGroup != selectedStudent.GroupID) && (newGroup != 0))
            { 
                selectedStudent.GroupID = newGroup;
                hasGroupChanged = true;
            }
            selectedStudent.LoginName = selectedStudent.FirstName + " " + selectedStudent.LastName;
            return hasGroupChanged;
        }

        public void UpdateStudent(Student student, string studentXMLPath, string groupXMLPath, string dataDirectory)
        {
            XDocument data = XDocument.Load(studentXMLPath);
            XElement studentIDElement = data.Descendants("stu").Where(stu => stu.Attribute("ID").Value.Equals(student.ID.ToString())).FirstOrDefault();
            XElement studentNameElement = data.Descendants("stu").Where(stu => stu.Element("loginName").Value.Equals(student.LoginName)).FirstOrDefault();

            XDocument groupData = XDocument.Load(groupXMLPath);
            XElement GroupElement = groupData.Descendants("group").Where(group => group.Attribute("ID").Value.Equals(student.GroupID.ToString())).FirstOrDefault();

            if ((studentIDElement != null) && (GroupElement != null))
            {
                MessageBox.Show(student.GroupID.ToString());
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
                }

                studentIDElement.SetElementValue("group", student.GroupID);
                data.Save(studentXMLPath);
            }
        }

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
            }
            return false;
        }

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
                studentList.Add(aStudent);
            }
        }

        public void WriteCurrentSession(Student currentStudent, Drill currentDrill)
        {
            Record RecordToAdd = new Record(currentDrill.ID, currentDrill.DrillName, DateTime.Now.ToString("M/d/yyyy"), currentDrill.Questions, currentDrill.RangeStart,
                currentDrill.RangeEnd, currentDrill.Operand, currentDrill.Wrong, currentDrill.Percent, currentDrill.Skipped);
            AddRecordToStudent(currentStudent, RecordToAdd);
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

        private IEnumerable<XElement> SecondLevelOfRoot(XElement RootNode)
        {
            IEnumerable<XElement> SecondLevelChildrenQuery =
                from secondLevel in RootNode.Elements()
                select secondLevel;
            return SecondLevelChildrenQuery;
        }

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
    }
}
