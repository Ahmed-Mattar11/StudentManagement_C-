using StudentManagement.Services;
using StudentManagement.UI;

namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService service = new StudentService();

            Menu menu = new Menu(service);

            menu.Show();
        }
    }
}