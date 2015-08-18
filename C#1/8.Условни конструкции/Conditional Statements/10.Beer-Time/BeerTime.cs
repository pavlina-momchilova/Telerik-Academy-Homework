using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Beer_Time
{
    class BeerTime
    {
        /*
            Problem 10.* Beer Time

            A beer time is after 1:00 PM and before 3:00 AM.
            Write a program that enters a time in format 
            “hh:mm tt” (an hour in range [01...12], a minute
            in range [00…59] and AM / PM designator) and prints
            beer time or non-beer time according to the definition
            above or invalid time if the time cannot be parsed. Note:
            You may need to learn how to parse dates and times.

         */
        static void Main(string[] args)
        {
            Console.Write("Enter Time in format h:mm tt : ");
            string format = "h:mm tt";

            DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), format,
                    CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.Parse("03:00 AM");
            DateTime startDate = DateTime.Parse("01:00 PM");
            int Beggining=DateTime.Compare(dateTime,startDate);
            int Ending = DateTime.Compare(dateTime, endDate);
            DateTime middnight = DateTime.Parse("00:00 PM");
            int middnightTime=DateTime.Compare(dateTime,middnight);
            if (middnightTime <= 0)
            {
                if (Ending < 0 && Beggining <= 0)
                {
                    Console.WriteLine("It's beer time");
                }
                else
                {
                    Console.WriteLine("It's non-beer time");
                }
            }
            else
            {
                if (Ending > 0 && Beggining >= 0)
                {
                    Console.WriteLine("It's beer time");
                }
                else
                {
                    Console.WriteLine("It's non-beer time");
                }
            }
            
        }
    }
}
