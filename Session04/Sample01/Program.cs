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

            Employee e = new Employee();
            e.FirstName = "Fatemeh";
            e.LastName = "Rostamipour";
            //The GetFullName method changed the implementation of the base method and return the different output(but the return type is the same)
            e.GetFullName();

            Customer c = new Customer();
            c.FirstName = "Fatemeh";
            c.LastName = "Rostamipour";
            //This method implement the GetFullName method in the base class
            c.GetFullName();

            Console.ReadLine();
        }
    }
}
