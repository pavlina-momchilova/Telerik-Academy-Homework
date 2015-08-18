using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        /*
            Problem 8. Numbers from 1 to n

            Write a program that reads an integer number n from
            the console and prints all the numbers in the interval
            [1..n], each on a single line.

            Note: You may need to use a for-loop.
         */
        static void Main()
        {
            Console.Title = "Numbers from 1 to n";
            Console.Write("Enter a number for the end of the interval: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers between [1...n] are:  ");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
