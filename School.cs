namespace SchoolProject
{
    public abstract class School
    {
        public People Human { get; set; } // teachers and student are people
        public int UquiqueNumber { get; set; }
        public string CourseName { get; set; }
        public int CountOfClasses { get; set; }
        public int CountOfExercise { get; set; }

    }
}