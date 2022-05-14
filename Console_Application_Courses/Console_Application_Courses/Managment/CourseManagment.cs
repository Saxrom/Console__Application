using System;
using System.Collections.Generic;
using Console_Application_Courses.Enum;
using Console_Application_Courses.Interfaces;
using Console_Application_Courses.Models;

namespace Console_Application_Courses.Managment
{
    class CourseManagment : ICoursesManagment
    {
        List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;

        public string CreateGroup(Categories category,bool isOnline)
        {
            Group group = new Group(true, category);

            foreach (Group existedGroup in Groups)
            {
                if (group.No.ToLower().Trim()!=existedGroup.No.ToLower().Trim())
                {
                    _groups.Add(group);
                    return $"{group.No} successfully created";
                }
                
            }
            return$"Group can not create";
        }

        public void CreateStudent(Student student,string groupNo)
        {
            if (groupNo == null)
            {
                Console.WriteLine("Please enter valid group");
            }

            if (Groups.Count>0)
            {
                Group group = FindGroup(groupNo);

                foreach (Group existedGroup in Groups)
                {
                    if (group.Students.Count < group.Limit)
                    {
                        group.Students.Add(student);
                    }

                    else
                    {
                        Console.WriteLine("Group's limit is fulled");
                    }
                }
            }
        }

        public void DeleateStudent(Student student,string groupNo)
        {
            Group group = FindGroup(groupNo);

            if (groupNo == null)
            {
                Console.WriteLine("Please enter valid group");
            }

            if (Groups.Count==0)
            {
                _groups.Add(group);
                Console.WriteLine($"{group.No} seccessfully created");
            }

            foreach (Group existedGroup in Groups)
            {
                if (group.Students.Count < group.Limit)
                {
                    group.Students.Remove(student);
                }

                else
                {
                    Console.WriteLine("Group's limit is fulled");
                }
            }
            Console.WriteLine("Group can not created");
        }
        
        public Group FindGroup(string no)
        {
            Group group = new Group();

            foreach (Group existedGroup in Groups)
            {
                if (group.No.ToLower().Trim() != existedGroup.No.ToLower().Trim())
                {
                    return group;
                    
                }
            }
            return group;
        }


        public void EditGroup(string oldGroup,string newGroup)
        {
            if (FindGroup(newGroup)==null)
            {
                Group group = FindGroup(oldGroup);

                if (group!=null)
                {
                    group.No = oldGroup.ToUpper().Trim();
                }

                else
                {
                    Console.WriteLine("There is no group with the name you are looking for"); 
                }
            }
            else
            {
                Console.WriteLine("Such a group already exists");
            }
        }

        public void ShowAllOfStudents()
        {
            Group group = new Group();
            if (group.Students.Count>0)
            {
                foreach (Student student in group.Students)
                {
                    Console.WriteLine(student);
                }  
            }
            else
            {
                Console.WriteLine("There is no such student");
            }

        }

        public void ShowAllStudentsInGroup(string no)
        {
            Group group = FindGroup(no);

            if (group!=null)
            {
                Console.WriteLine($"There is no such grouo:{no.ToUpper()}");
            }
        }

        public void ShowListOfGroups(string no)
        {
            if (no!=null)
            {
                foreach (Group group in Groups)
                {
                    Console.WriteLine(group);
                }
            }

            else
            {
                Console.WriteLine("Please enter valid group");
            }
        }
    }
}
