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

            if (Groups.Count==0)
            {
                _groups.Add(group);
                Console.WriteLine($"{group.No} successfully created");
            }
            else
            {
                foreach (Group existedGroup in Groups)
                {
                    if (group.No.ToLower().Trim() != existedGroup.No.ToLower().Trim())
                    {
                        _groups.Add(group);
                        Console.WriteLine($"{group.No} successfully created");
                    }
                }
            }
            return$"Group can not create";

        }

        public string CreateStudent(Student student,string groupNo)
        {
            if (Groups.Count>0)
            {
                Group group = FindGroup(groupNo);

                if (groupNo == null)
                {
                    return $"Please enter valid group";
                }

                else
                {
                    foreach (Group existedGroup in Groups)
                    {
                        if (existedGroup.Students.Count < group.Limit)
                        {
                            group.Students.Add(student);
                            Console.WriteLine($"{student} successfully created");
                        }
                        else
                        {
                            Console.WriteLine("Group's limit is fulled");
                        }
                    }
                }
            }
            return $"This is there is already such a student";
        }

        public string DeleateStudent(byte id,string groupNo)
        {
            Group group = FindGroup(groupNo);

            if (group != null || id != 0)
            {
                foreach (Student student in group.Students)
                {
                    group.Students.Remove(student);
                    Console.WriteLine($"{student.FullName} was remowed from the group");
                }
                return $"there is no such student";
            }

            else
            {
                Console.WriteLine($"Please check if you have led the group and id correctly");
                ShowListOfGroups();
            }
            return null;
        }

        public Group FindGroup(string no)
        {
            foreach (Group existedGroup in Groups)
            {
                if (no.ToLower().Trim() == existedGroup.No.ToLower().Trim()) return existedGroup;
                
            }
            return null;
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
            if (Groups.Count>0)
            {
                if (Student.count==0)
                {
                    Console.WriteLine("Student didn't created");
                }

                foreach (Group group in Groups)
                {
                    foreach (Student stu in group.Students)
                    {
                        Console.WriteLine($"{stu} Group:{group.No}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Group didn't created");
            }


        }

        public void ShowAllStudentsInGroup(string groupNo)
        {
            Group group = FindGroup(groupNo);

            if (group!=null)
            {
                foreach (Student student in group.Students)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Please enter valid group no");
            }
        }

        public void ShowListOfGroups()
        {
            if (Groups.Count>0)
            {
                foreach (Group group in Groups)
                {
                    Console.WriteLine(group);
                }
            }
            else
            {
                Console.WriteLine("There are no groups");
            }
        }
    }
}
