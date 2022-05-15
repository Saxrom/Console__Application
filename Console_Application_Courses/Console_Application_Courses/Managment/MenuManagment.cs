using System;
using Console_Application_Courses.Enum;
using Console_Application_Courses.Models;

namespace Console_Application_Courses.Managment
{
    static class MenuManagment
    {
        public static CourseManagment courseManagment = new CourseManagment();

        public static void CreateGroup()
        {
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
            courseManagment.ShowListOfGroups();
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
            Console.WriteLine("Please enter group no");
            string groupNo = Console.ReadLine();

            courseManagment.ShowAllStudentsInGroup(groupNo);
        }

        public static void ShowAllOfStudents()
        {
            courseManagment.ShowAllOfStudents();
        }

        public static void CreateStudent()
        {
            Console.WriteLine("Please enter student's fullanme");
            string fullName = Console.ReadLine();
            bool type = true;

            Console.WriteLine("Please enter the group you want to add to");
            string groupNo = Console.ReadLine();

            Student student = new Student(fullName, type);

            courseManagment.CreateStudent(student, groupNo);
        }

        public static void DeleateStudent()
        {
            Console.WriteLine("Please enter student's fullanme");
            string fullName = Console.ReadLine();
            bool type = true;

            Console.WriteLine("Please enter the group you want to add to");
            string groupNo = Console.ReadLine();

            Student student = new Student(fullName, type);

            courseManagment.CreateStudent(student, groupNo);
        }
    }
}
