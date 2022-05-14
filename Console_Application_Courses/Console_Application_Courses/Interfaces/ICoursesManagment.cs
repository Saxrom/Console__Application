using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Console_Application_Courses.Enum;

namespace Console_Application_Courses.Interfaces
{
    interface ICoursesManagment
    {
        public List<Group> Groups { get; }

        void CreatGroup(string no, byte limit, Categories category);

        void ShowListOFGroups();

        void MakeAmendOverGroup();

        void ShowAllStudentsByGroup();

        void ShowAllStudents();

        void CreatStudent();

        void DeleateStudent();
    }
}
