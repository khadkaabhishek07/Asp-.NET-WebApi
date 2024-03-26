namespace Computing3.Models.Student
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }
        public List<Student> Students { get; set; }
    }
}
