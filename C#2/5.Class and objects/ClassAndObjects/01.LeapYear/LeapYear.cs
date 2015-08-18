using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LeapYear
{
    class LeapYear
    {
        /*
         Problem 1. Leap year

Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.
         */
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            bool isLeap=DateTime.IsLeapYear(year);
            if (isLeap == true)
            {
                Console.WriteLine("the year is leap");
            }
            else
            {
                Console.WriteLine("the year is not leap");
            }
        }
    }
}
