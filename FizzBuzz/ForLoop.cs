using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class ForLoop
    {
        public bool FirstSolution(int n)
        {

            string result;

            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                    result = "FizzBuzz";
                else if (i % 3 == 0)
                    result = "Fizz";
                else if (i % 5 == 0)
                    result = "Buzz";
                else
                    result = i.ToString();

                Console.WriteLine(result);
            }
            return false;
        }
    }
}
