using System.Collections.Generic;

namespace task_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
                students.Add(new Student());
            foreach(Student student in students)
            {
                teacher.TaskSubscribe(student);
                student.DoTask();
            }

        }
    }
}
