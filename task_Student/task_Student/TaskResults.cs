namespace task_Student
{
    struct VerifiedTasks
    {
        public VerifiedTasks(Student student, string verifiedTask, int mark)
        {
            FirstName = student.FirstName;
            LastName = student.LastName;
            VerifiedTask = verifiedTask;
            Mark = mark;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string VerifiedTask { get; set; }
        public int Mark { get; set; }

    }
}
