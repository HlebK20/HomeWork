using System;

namespace task_DEV_2._1
{
    class TaskDoneEventArgs : EventArgs
    {
        public TaskDoneEventArgs(string dataTitle, string data)
        {
            Data = data;
            DataTitle = dataTitle;
        }
        public string DataTitle { get; private set; }
        public string Data { get; private set; }
    }
}