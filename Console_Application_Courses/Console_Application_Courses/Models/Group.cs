using System;
using Console_Application_Courses.Enum;

namespace Console_Application_Courses.Models
{
    class Group 
    {
        public string No;
        public bool IsOnline;
        public byte Limit;
        public Categories Category;
        public Student[] Students;
        public static byte count;


        public Group()
        {
            count = 10;
        }

        public Group(string No,byte limit,Categories category,Student[] student)
        {
            switch (Category)
            {
                case Categories.Programming:
                    No = $"PR" + count;
                    break;
                case Categories.Design:
                    No = $"DN" + count;
                    break;
                case Categories.System_administration:
                    No = $"SA" + count;
                    break;
                default:
                    break;
            }
            count++;
            Category = category;
            Students = student;
        }
    }
}
