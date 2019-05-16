using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Recursive
    {
        public void SecondSolution(int n)
        {
            string result;

            if (n > 100)
                return;

            if (n % 15 == 0)
                result = "FizzBuzz";
            else if (n % 3 == 0)
                result = "Fizz";
            else if (n % 5 == 0)
                result = "Buzz";
            else
                result = n.ToString();

            Console.WriteLine(result);
            SecondSolution(n + 1);
        }
    }
}
