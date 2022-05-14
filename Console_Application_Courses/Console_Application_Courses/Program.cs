using System;
using Console_Application_Courses.Enum;
using Console_Application_Courses.Managment;

namespace Console_Application_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to Course Managment application---");
            byte selection;
            do
            {
                Console.WriteLine("1.Create new group");
                Console.WriteLine("2.Show list of groups");
                Console.WriteLine("3.Edit the group");
                Console.WriteLine("4.Show list of students in Group");
                Console.WriteLine("5.Show list of all students");
                Console.WriteLine("6.Create a student");
                Console.WriteLine("7.Deleate a student");
                bool result = byte.TryParse(Console.ReadLine(), out selection);
                Console.Clear();

                switch (selection)
                {
                    case 1:
                        MenuManagment.CreateGroup();
                        break;
                    case 2:
                        MenuManagment.ShowListOfGroups();
                        break;
                    case 3:
                        MenuManagment.EditGroup();
                        break;
                    default:
                        Console.WriteLine("Somthing went wrong");
                        break;
                }
            } while (selection!=0);
        }
    }
}
