using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.FullName = "Fatemeh";
            Course course = new Course(teacher);
            course.Name = "Math";
            Student student = new Student();
            student.PrintTheGrades("19.2,3","Math,Chemistry");
            List<Student> students = new List<Student>();
            students.Add(student);
            Report.Showresult(students);
            Console.ReadLine();
        }
    }
}
