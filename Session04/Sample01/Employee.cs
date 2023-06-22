using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public class Employee : Person
    {
        #region [- Behaviours -]

        #region [- GetFullName() -]
        public override void GetFullName()
        {
            Console.WriteLine(LastName);
        }
        #endregion 

        #endregion
    }
}
