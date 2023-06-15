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
            
            Console.WriteLine("Please enter five names:");
            string[] StudentNames = new string[5];

            for (int i = 0; i < 5; i++)
            {
                StudentNames[i] = Console.ReadLine();
            }

            Array.Sort(StudentNames);

            Console.WriteLine("Showing the names alphabetically.");

            foreach (var name in StudentNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
