﻿using System;
using Console_Application_Courses.Enum;
using Console_Application_Courses.Models;

namespace Console_Application_Courses.Managment
{
    static class MenuManagment
    {
        public static CourseManagment courseManagment = new CourseManagment();

        public static void CreateGroup()
        {

            string isOnline;
            bool resultIsOnline = false;
            do
            {
                Console.Write("Do you want to create an online group?(Y/N) :");
                isOnline = Console.ReadLine().ToLower();


            } while (isOnline != "y" && isOnline != "n");

            if (isOnline == "y") resultIsOnline = true;
            if (isOnline == "n") resultIsOnline = false;
            Console.Clear();

            foreach (var item in System.Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)item}. {item}");
            }
            Console.Write("\nPlease choose course type:");

            object category;
            bool categoryResult = System.Enum.TryParse(typeof(Categories), Console.ReadLine(), out category);
            

            if (categoryResult)
            {
                courseManagment.CreateGroup((Categories)category,resultIsOnline);
            }

            else
            {
                Console.WriteLine("Something went wrong");
            }
        }

        public static void ShowListOfGroups()
        {
            courseManagment.ShowListOfGroups();
        }

        public static void EditGroup()
        {
            ShowListOfGroups();

            Console.Write("\nPlease enter group :");
            string oldGroup = Console.ReadLine().ToUpper();

            Console.Write("Please enter new group :");
            string newGroup = Console.ReadLine().ToUpper();

            courseManagment.EditGroup(oldGroup, newGroup);
        }

        public static void ShowListOfStudentInGroup()
        {
            ShowListOfGroups();

            Console.Write("Please enter group no:");
            string groupNo = Console.ReadLine().ToUpper();

            courseManagment.ShowAllStudentsInGroup(groupNo);
        }

        public static void ShowAllOfStudents()
        {
            courseManagment.ShowAllOfStudents();
        }

        public static void CreateStudent()
        {
            Console.Write("Please enter student's fullanme:");
            string fullName = Console.ReadLine();


            Console.Write("\nPlease enter the group you want to add to:");
            string groupNo = Console.ReadLine().ToUpper();

            Console.Clear();
            ShowListOfGroups();

            string type;
            bool typeResult = false;
            do
            {
                Console.Write("Is the student guaranteed or not?y/n");
                type = Console.ReadLine().ToLower();

            } while (type != "y" && type != "n");

            if (type == "y") typeResult = true;
            if (type == "n") typeResult = false;

            Student student = new Student(fullName, typeResult);

            courseManagment.CreateStudent(student, groupNo);
        }

        public static void DeleateStudent()
        {
            ShowAllOfStudents();

            Console.Write("\nPlease enter student's Id:");
            byte Id;
            bool resultId = byte.TryParse(Console.ReadLine(), out Id);

            Console.Write("Please enter the group you want to deleate to:");
            string groupNo = Console.ReadLine().ToUpper();

            if (resultId&&groupNo!=null)
            {
                courseManagment.DeleateStudent(Id, groupNo);
            }
            else
            {
                Console.WriteLine("please enter the correct Id and GroupNo");
            }
        }
    }
}
