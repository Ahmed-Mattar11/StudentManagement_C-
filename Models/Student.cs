namespace StudentManagement.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public Gender StudentGender { get; set; }
        public Grade StudentGrade { get; set; }
    }
}