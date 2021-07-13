using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace WindowsFormsApplication1
{
        [Serializable()]    //Set this attribute to all the classes that want to serialize
    class Group : ISerializable, IComparable
    {

        private string groupId = "";
        private string groupName = "";
        private int groupSize = 0;
        private string groupGrade = "";

        //Default constructor
        public Group(string groupIDstr)
        {
            groupId = groupIDstr;
        }

        public string GroupGrade
        {
            get { return groupGrade; }
            set { groupGrade= value; }

        }

        public string GroupId
        {
            get { return groupId; }
            set { groupId = value; }
        }

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        public int GroupSize
        {
            get { return groupSize; }
            set { groupSize = value; }
        }


        //Deserialization constructor.
        public Group(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties

            GroupId = (String)info.GetValue("GroupID", typeof(string));
            GroupName = (String)info.GetValue("GroupName", typeof(string));
            
        }

        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"

            info.AddValue("GroupID", GroupId);
            info.AddValue("GroupName", GroupName);
        }

        //provide default sort order for the Department objects
        public int CompareTo(object obj)
        {
            if (obj is Group)
            {
                Group temp = (Group)obj;

                return this.groupId.CompareTo(temp.groupId);
            }

            throw new ArgumentException("object is not a Department");
        }

        // Nested class to do the sorting by DeptName
        private class sortByGroupNameHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Group group1 = (Group)a;
                Group group2 = (Group)b;
                return group1.GroupName.CompareTo(group2.GroupName);

            }
        }

        // Method to return IComparer object for sort helper.
        public static IComparer sortByGroupName()
        {
            return (IComparer)new sortByGroupNameHelper();
        }

    }
}
