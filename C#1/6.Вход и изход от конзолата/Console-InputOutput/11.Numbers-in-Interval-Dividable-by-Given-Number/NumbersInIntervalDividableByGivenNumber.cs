using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Numbers_in_Interval_Dividable_by_Given_Number
{
    class NumbersInIntervalDividableByGivenNumber
    {
        /*
            Problem 11.* Numbers in Interval Dividable by Given Number

            Write a program that reads two positive integer numbers and
            prints how many numbers p exist between them such that the
            reminder of the division by 5 is 0.

         */
        static void Main()
        {
            Console.Title = "Numbers in Interval Dividable by Given Number";
            Console.Write("Enter beginning of the interval: ");
            uint start = uint.Parse(Console.ReadLine());
            Console.Write("Enter the end of the interval: ");
            uint end = uint.Parse(Console.ReadLine());
            int count = 0;
            string numbers = "";
            for (uint i = start; i <=end; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                    numbers +=i;
                    numbers += ", ";
                }
            }
            Console.WriteLine("The numbers between {0} and {1} devided by 5 are: {2} and they are {3}",start,end,count,numbers.Remove(numbers.Length-2));
        }
    }
}
