using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public class Person
    {
        #region [- Props -]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion

        #region [- Behaviours -]

        #region [- GetFullName() -]
        public virtual void GetFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        #endregion 

        #endregion

    }
}
