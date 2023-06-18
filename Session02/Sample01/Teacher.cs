using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public class Teacher
    {
        #region [- Props -]
        public string FullName { get; set; }
        #endregion

        #region [- Behaviours -]

        #region [- SaveTeacherNames(string teacherNames) -]
        public void SaveTeacherNames(string teacherNames)
        {
            string[] TeacherNames = teacherNames.Split(',');
        }
        #endregion 

        #endregion
    }
}
