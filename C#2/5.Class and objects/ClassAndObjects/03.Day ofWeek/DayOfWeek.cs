using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DayOfWeek
{
    class DayOfWeek
    {
        /*
         Problem 3. Day of week

Write a program that prints to the console which day of the week is today.
Use System.DateTime.
         */
        static void Main()
        {
            DateTime dayOfWeek = new DateTime();
            dayOfWeek = DateTime.Now;
            Console.WriteLine("Today is {0}! ",dayOfWeek.DayOfWeek);
        }
    }
}
