using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Console_Application_Courses.Enum;
using Console_Application_Courses.Models;
using Group = Console_Application_Courses.Models.Group;

namespace Console_Application_Courses.Interfaces
{
    interface ICoursesManagment
    {
        public List<Group> Groups { get; }
        string CreateGroup(Categories category,bool isOnline);

        void ShowListOfGroups(string no);

        void EditGroup(string oldGroup, string newGroup);

        void ShowAllStudentsInGroup(string no);

        void ShowAllOfStudents();

        void CreateStudent(Student student, string groupNo);
        
        void DeleateStudent(Student student, string groupNo);
    }
}
