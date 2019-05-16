using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop ");
            ForLoop First = new ForLoop();
            First.FirstSolution(100);

            Console.WriteLine("\nRecursive ");
            Recursive Second = new Recursive();
            Second.SecondSolution(1);
        }
    }
}
