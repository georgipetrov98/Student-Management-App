using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;

namespace WindowsFormsApplication1
{
    [Serializable()]    //Set this attribute to all the classes that want to serialize
    public class Student : ISerializable, IComparable
    {
        private string studentId;
        private string studentFName = "";
        private string studentLName = "";
        private Boolean studentStatus = false;
        private string groupId = "";
        private string studentGrade = "";
        //Default constructor
        public Student(string studentIDnum)
        {
            studentId = studentIDnum;
        }

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }

        }

        public string StudentGrade        {
            get { return studentGrade; }
            set { studentGrade = value; }

        }


        public string StudentFName
        {
            get { return studentFName; }
            set { studentFName = value; }
        }

        public string StudentLName
        {
            get { return studentLName; }
            set { studentLName = value; }
        }

        public Boolean StudentStatus
        {
            get { return studentStatus; }
            set { studentStatus = value; }
        }

        public string GroupId
        {
            get { return groupId; }
            set { groupId = value; }
        }

        //Deserialization constructor.
        public Student(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            StudentId = (String)info.GetValue("StudentId", typeof(string));
            StudentFName = (String)info.GetValue("StudentFName", typeof(string));
            StudentLName = (String)info.GetValue("StudentLName", typeof(string));
            StudentStatus = (Boolean)info.GetValue("StudentStatus", typeof(Boolean));
            GroupId = (String)info.GetValue("GroupID", typeof(string));
        }

        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"
            info.AddValue("StudentId", StudentId);
            info.AddValue("StudentFName", StudentFName);
            info.AddValue("StudentLName", StudentLName);
            info.AddValue("StudentStatus", StudentStatus);
            info.AddValue("GroupID", GroupId);
        }

        //provide default sort order for the Employee names
        public int CompareTo(object obj)
        {
            if (obj is Student student)
            {
                string fullNameStudent1 = this.studentFName + this.studentLName;
                string fullNameStudent2 = student.studentFName + student.studentLName;

                return fullNameStudent1.CompareTo(fullNameStudent2);
            }

            throw new ArgumentException("object is not a Student");
        }

        // Nested class to do the sorting by EmpId
        private class sortByStudentIDHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Student student1 = (Student)a;
                Student student2 = (Student)b;
                return Int32.Parse(student1.StudentId).CompareTo(Int32.Parse(student2.StudentId));
            }
        }

        // Method to return IComparer object for sort helper.
        public static IComparer sortByStudentID()
        {
            return new sortByStudentIDHelper();
        }

    }

}
