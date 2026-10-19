using StudentManagement.Models;

namespace StudentManagement.Services
{
    public class StudentService
    {
        private readonly List<Student> _students = new();
        public bool AddStudent(Student student)
        {
            if (SearchStudent(student.ID) != null)
            {
                return false;
            }

            _students.Add(student);
            return true;
        }
        public void ViewAllStudents()
        {
            if (_students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (Student student in _students)
            {
                ViewStudent(student);
                Console.WriteLine("----------------------");
            }
        }
        public void ViewStudent(Student student)
        {
            Console.WriteLine($"ID: {student.ID}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Gender: {student.StudentGender}");
            Console.WriteLine($"C# Grade: {student.StudentGrade.CSharp}");
            Console.WriteLine($"Database Grade: {student.StudentGrade.Database}");
        }
        public Student? SearchStudent(int id)
        {
            foreach (Student student in _students)
            {
                if(student.ID==id)
                {
                    return student;
                }

            }
            return null;
        }
        public bool UpdateStudent(int id, string name, Gender gender, Grade grade)
        {
            Student? student = SearchStudent(id);

            if (student == null)
                return false;

            student.Name = name;
            student.StudentGender = gender;
            student.StudentGrade = grade;

            return true;
        }
        public bool DeleteStudent(int id)
        {
            Student? student = SearchStudent(id);

            if (student == null)
                return false;

           _students.Remove(student);
            return true;
        }
    }
}