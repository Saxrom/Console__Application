using System;
namespace Console_Application_Courses.Models
{
    class Student
    {
        public string Name;
        public string Surname;
        public string GroupNo;
        public bool Type;

        public Student(string name, string surname, string groupno)
        {
            Name = name;
            Surname = surname;
            GroupNo = groupno;
            Type = false;
        }

        public string FullName()
        {
            return $"{Name}+{ Surname}";
        }
    }
}
