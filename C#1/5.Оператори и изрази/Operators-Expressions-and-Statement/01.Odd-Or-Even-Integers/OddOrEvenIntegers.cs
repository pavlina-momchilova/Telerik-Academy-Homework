using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Or_Even_Integers
{
    class OddOrEvenIntegers
    {
        /*
            Problem 1. Odd or Even Integers

            Write an expression that checks if given integer is odd or even.

         */
        static void Main(string[] args)
        {
            bool IsItOdd = true;
            int[] numbers = { 3, 2, -2, -1, 0 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]== 0)
                {
                    IsItOdd = false;
                    Console.WriteLine(IsItOdd + " 0 is neither odd neither even!");
                }

                else if (numbers[i] % 2 == 0)
                {
                    IsItOdd = true;
                    Console.WriteLine(IsItOdd + " => The number: " + numbers[i] + " is even!");
                }
                else
                {
                    IsItOdd = false;
                    Console.WriteLine(IsItOdd + " => The number: " + numbers[i] + " is odd!");
                }
            } 
        }
    }
}
