using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public class Course
    {
        #region [- Ctor -]
        public Course(Teacher teacher)
        {
            TeacherName = teacher.FullName;
        } 
        #endregion

        #region [- Props -]
        public string Name { get; set; }
        public string TeacherName { get; set; }
        #endregion

        #region [- Behaviours -]

        #region [- SaveCoursenames(string courseNames) -]
        public void SaveCoursenames(string courseNames)
        {
            string[] CourseNames = courseNames.Split(',');
        }
        #endregion 

        #endregion
    }
}
