using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public static class Report
    {
        #region [- Showresult(List<Student> students) -]
        public static void Showresult(List<Student> students)
        {
            foreach (var Student in students)
            {
                foreach (var Grade in Student.Grades)
                {
                    if (System.Convert.ToInt32(Grade) < 10)
                    {
                        Console.WriteLine(Grade + "-" + Student.StudentName + "-" + Student.Courses);
                    }
                }
            }
        } 
        #endregion
    }
}
