using System;
namespace Console_Application_Courses.Models
{
    class Student
    {
        public string FullName;
        public string GroupNo;
        public bool Type;
        public byte Id;
        public static byte count;

        public Student(string fullname, string groupNo,byte id)
        {
            FullName = fullname;
            GroupNo = groupNo;
            Type = false;
            Id = ++count;
        }
    }
}
