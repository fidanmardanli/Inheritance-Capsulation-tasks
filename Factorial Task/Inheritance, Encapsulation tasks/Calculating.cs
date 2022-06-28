using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inheritance__Encapsulation_tasks;
using System.Threading.Tasks;

namespace Inheritance__Encapsulation_tasks
{
    public class Calculating
    {
        public static int FindingFactorial(int number)
        {
            int i;
            int fact = 1;


            if (number % 2 == 0)
            {
                for (i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                Console.Write("Factorial of " + number + " is: " + fact);
                return number;
                
            }
            else
            {
                Console.WriteLine(number + "is not even number");
                return number;
            }

        }

    }
}
