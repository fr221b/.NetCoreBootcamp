using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public class Student
    {
        
        #region [- Props -]
        public string StudentName { get; set; }
        public string[] Grades { get; set; }
        public string[] Courses { get; set; }
        #endregion

        #region [- Behaviours -]

        #region [- PrintTheGrades(string gardes,string courses) -]
        public void PrintTheGrades(string gardes,string courses)
        {
            Grades = gardes.Split(',');
            Courses = courses.Split(',');
            var result = Courses.Zip(Grades, (c, g) => c +": "+ g );
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
        } 
        #endregion

        #endregion
    }
}
