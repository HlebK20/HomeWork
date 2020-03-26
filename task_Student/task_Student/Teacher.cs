using System;
using System.Collections.Generic;

namespace task_Student
{
    class Teacher
    {
        const int MAX_STUDENTS = 10;
        private List<Student> Group = new List<Student>();
        private List<string> TaskResults;
        delegate void EventHandler(Student student, string str);
        
        public void TaskCompleted(Student sender, string task)
        {
            Student student = (Student)sender;
            if (!IsStudentInGroup(student))
            {
                Group.Add(sender);
                if (Group.Count >= MAX_STUDENTS)
                {
                    foreach (Student stud in Group)
                    {
                        Console.WriteLine("Student {0} {1} sent {2}", stud.FirstName, stud.LastName, task);
                    }
                }
            }
        }
        bool IsStudentInGroup(Student student)
        {
            if (Group.Contains(student))
            {
                return true;
            }
            return false;
        }
    }
}
