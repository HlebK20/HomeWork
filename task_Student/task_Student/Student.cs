using System;

namespace task_Student
{
    class Student : ITaskPerformer
    {
        static int number = 0;
        string _firstName = "FirstName";
        string _lastName = "LastName";
        string _task = "";
        const int MAX_TASK_LENGTH = 15;
        public event EventHandler<EventArguments> TaskComplited;
        public Student()
        {
            _firstName += number;
            _lastName += number;
            number++;
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
            }
        }
        public void DoTask()
        {
            String result = "";
            Random random = new Random(Convert.ToInt32(DateTime.Now));
            for(int i = 0; i < MAX_TASK_LENGTH; i++)
            {
                _task += (char)random.Next((int)'A', (int)'Z');
            }
            TaskComplited?.Invoke(this, new EventArguments(result));
        }
    }
}
