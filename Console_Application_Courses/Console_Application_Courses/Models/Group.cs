using System;
using System.Collections.Generic;
using Console_Application_Courses.Enum;

namespace Console_Application_Courses.Models
{
    class Group
    {
        public string No;
        public bool IsOnline;
        public  byte Limit;
        public Categories Category;
        public List<Student> Students = new List<Student>();
        public static byte count;


        public Group()
        {
            count = 10;
        }

        public Group(bool isOnline
            ,Categories category)
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
            IsOnline = false;
            if (!IsOnline)
            {
                Limit = 10;
            }
            else
            {
                Limit = 15;
            }
            Students = new List<Student>();
        }
    }
}
