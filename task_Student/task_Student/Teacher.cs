using System;
using System.Collections.Generic;

namespace task_Student
{
    class Teacher
    {
        const int MAX_STUDENTS = 10;
        List<Student> _group;
        List<string> _taskResults;
        List<int> _marks;
        delegate void EventHandler(Student student, string str);
        public Teacher()
        {
            _group = new List<Student>();
            _taskResults = new List<string>();
            _marks = new List<int>();
        }

        void TaskCompleted(object sender, EventArguments e)
        {
            Student student = (Student)sender;
            if (!IsStudentInGroup(student))
            {
                _group.Add(student);
                _taskResults.Add(e.TaskResult);
                if (_group.Count == MAX_STUDENTS)
                {
                    CountMark();
                    PrintResults();
                }
                
            }
        }
        void CountMark()
        {
            string currentTask;
            int currentMark;
            for (int i = 0; i < _taskResults.Count; i++)
            {
                currentTask = _taskResults[i];
                currentMark = 0;
                foreach (char symbol in currentTask)
                {
                    currentMark += (int)symbol;
                }
                _marks.Add(currentMark % 10);
            }
        }
        void PrintResults()
        {
            for(int i = 0; i < MAX_STUDENTS; i++)
            {
                Console.WriteLine("Student {0} {1} sent {2}. Mark is {3}"
                    , _group[i].FirstName, _group[i].LastName, _taskResults[i], _marks[i]);
                //Console.WriteLine(_group[i].FirstName);
            }
        }
        public void TaskSubscribe(Student student)
        {
            student.TaskComplited += TaskCompleted;
        }
        bool IsStudentInGroup(Student student)
        {
            if (_group.Contains(student))
            {
                return true;
            }
            return false;
        }
    }
}
