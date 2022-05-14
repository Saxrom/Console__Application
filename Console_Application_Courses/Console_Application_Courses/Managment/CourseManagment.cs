using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Console_Application_Courses.Enum;
using Console_Application_Courses.Interfaces;

namespace Console_Application_Courses.Managment
{
    class CourseManagment : ICoursesManagment
    {
        List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;

        public void CreatGroup(string no,byte limit,Categories category)
        {
            if (limit<=0)
            {
                Console.WriteLine("Please enter valid limit");
            }
            Group group = new Group(no, limit,category);
            
        }

        public void CreatStudent()
        {
            throw new NotImplementedException();
        }

        public void DeleateStudent()
        {
            throw new NotImplementedException();
        }

        public void MakeAmendOverGroup()
        {
            throw new NotImplementedException();
        }

        public void ShowAllStudents()
        {
            throw new NotImplementedException();
        }

        public void ShowAllStudentsByGroup()
        {
            throw new NotImplementedException();
        }

        public void ShowListOFGroups()
        {
            throw new NotImplementedException();
        }
    }
}
