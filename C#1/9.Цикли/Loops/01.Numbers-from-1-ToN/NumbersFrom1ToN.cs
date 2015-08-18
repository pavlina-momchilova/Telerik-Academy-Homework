using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers_from_1_ToN
{
    class NumbersFrom1ToN
    {
        /*
            Problem 1. Numbers from 1 to N

            Write a program that enters from the console
            a positive integer n and prints all the numbers from
            1 to n, on a single line, separated by a space.
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
                    Console.Write(i+" ");
                }
            }
            else
            {
                Console.WriteLine("The number that you enter is wrong!");
            }
        }
    }
}
