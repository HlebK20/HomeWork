using System;
using System.Collections.Generic;
using System.Text;

namespace task_Student
{
    class EventArguments
    {
        public EventArguments(string result)
        {
            TaskResult = result;
        }
        public string TaskResult { get; private set; }
    }
}
