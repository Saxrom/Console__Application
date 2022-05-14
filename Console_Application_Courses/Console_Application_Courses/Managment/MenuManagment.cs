using System;
using Console_Application_Courses.Enum;

namespace Console_Application_Courses.Managment
{
    static class MenuManagment
    {
        public static CourseManagment courseManagment = new CourseManagment();

        public static void CreateGroup()
        {
            Console.WriteLine("Please enter Group :");
            string no = Console.ReadLine();


            foreach (var item in System.Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)item}. {item}");
            }

            object category;
            bool categoryResult = System.Enum.TryParse(typeof(Categories), Console.ReadLine(), out category);

            courseManagment.CreateGroup((Categories)category, true);

            if (categoryResult)
            {
                Console.WriteLine(category);
            }
        }

        public static void ShowListOfGroups()
        {
            Console.WriteLine("PLease enter Group ");
            string no = Console.ReadLine();

            courseManagment.ShowListOfGroups(no);
        }

        public static void EditGroup()
        {
            Console.WriteLine("Please enter group :");
            string oldGroup = Console.ReadLine();

            Console.WriteLine("Please enter new group :");
            string newGroup = Console.ReadLine();

            courseManagment.EditGroup(oldGroup, newGroup);
        }

        public static void ShowListOfStudentInGroup()
        {

        }

        public static void ShowAllOfStudents()
        {
            courseManagment.ShowAllOfStudents();
        }
    }
}
