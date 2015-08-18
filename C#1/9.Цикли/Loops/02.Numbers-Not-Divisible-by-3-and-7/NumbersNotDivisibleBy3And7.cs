using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers_Not_Divisible_by_3_and_7
{
    class NumbersNotDivisibleBy3And7
    {
        /*
            Problem 2. Numbers Not Divisible by 3 and 7

            Write a program that enters from the console a
            positive integer n and prints all the numbers from
            1 to n not divisible by 3 and 7, on a single line,
            separated by a space.
         */
        static void Main()
        {
            Console.Title = "Numbers from 1 to N";
            Console.WriteLine("Enter positive integer number: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 != 0 && i % 7 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("The number that you enter is wrong!");
            }
        }
    }
}
