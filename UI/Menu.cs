
using StudentManagement.Models;
using StudentManagement.Services;
namespace StudentManagement.UI

{
    public class Menu
    {
        private readonly StudentService _service;
        public Menu(StudentService service)
        {
            _service = service;
        }
        public void AddStudentMenu()
        {
            Student student = new Student();
            student.ID = ReadStudentId();
            if (_service.SearchStudent(student.ID) != null)
            {
                Console.WriteLine("ID already exists. Please use a different ID.");
                return;
            }
            student.StudentGender = ReadGender();

            student.Name = ReadStudentName();


            int csharp = ReadGrade("C#");
            int database = ReadGrade("Database");

            student.StudentGrade = new Grade
            {
                CSharp = csharp,
                Database = database
            };

            bool added = _service.AddStudent(student);

            if (added)
            {
                Console.WriteLine("Student Added Successfully!");
            }
            else
            {
                Console.WriteLine("ID already exists. Please use a different ID.");
            }
        }
        public void SearchStudentMenu()
        {

            int id = ReadStudentId();
            Student? student = _service.SearchStudent(id);
            if (student != null)
            {
                _service.ViewStudent(student);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
        public void UpdateStudentMenu()
        {
            int id = ReadStudentId();

            Student? student = _service.SearchStudent(id);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            string name = ReadStudentName();

            Gender gender = ReadGender();

            Grade grade = new Grade
            {
                CSharp = ReadGrade("C#"),
                Database = ReadGrade("Database")
            };

            bool updated = _service.UpdateStudent(id, name, gender, grade);

            if (updated)
                Console.WriteLine("Student Updated Successfully!");
        }
        public void DeleteStudentMenu()
        {
            int id = ReadStudentId();
            bool deleted = _service.DeleteStudent(id);

            if (deleted)
                Console.WriteLine("Student Deleted Successfully!");
            else
                Console.WriteLine("Student not found.");
        }

        private int ReadStudentId()
        {

            while (true)
            {
                Console.Write("Enter the ID: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int id) && id > 0)
                {
                    return id;
                }

                Console.WriteLine("Invalid ID. Enter a valid number.");
            }
        }

        private int ReadGrade(string subject)
        {
            int grade;

            while (true)
            {
                Console.Write($"Enter {subject} Grade (0-100): ");

                if (int.TryParse(Console.ReadLine(), out grade)
                    && grade >= 0 && grade <= 100)
                {
                    return grade;
                }

                Console.WriteLine("Invalid grade. Enter a number from 0 to 100.");
            }
        }
        private Gender ReadGender()
        {
            while (true)
            {
                Console.WriteLine("Choose Gender:");
                Console.WriteLine("1. Male");
                Console.WriteLine("2. Female");
                Console.Write("Choose an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 1)
                        return Gender.Male;

                    if (choice == 2)
                        return Gender.Female;
                }

                Console.WriteLine("Invalid choice. Enter 1 or 2.");
            }
        }
        private string ReadStudentName()
        {

            while (true)
            {
                Console.Write("Enter Student Name: ");
                string? name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    return name.Trim();
                }
                Console.WriteLine("Name cannot be empty.");
            }
        }
        private void HandleChoice(string? choice)
        {
            switch (choice)
            {
                case "1":
                    AddStudentMenu();
                    break;

                case "2":
                    _service.ViewAllStudents();
                    break;

                case "3":
                    SearchStudentMenu();
                    break;

                case "4":
                    UpdateStudentMenu();
                    break;

                case "5":
                    DeleteStudentMenu();
                    break;


                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
       
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("===== Student Management =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Exit");

                Console.Write("Choose an option: ");
                string? choice = Console.ReadLine();

                if (choice == "6")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                HandleChoice(choice);
            }
        }
    }
}