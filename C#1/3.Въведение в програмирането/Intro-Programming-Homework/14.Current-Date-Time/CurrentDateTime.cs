﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Current_Date_Time
{
    class CurrentDateTime
    {
        /*
            Problem 14.* Current Date and Time

            Create a console application that prints the current date and time. Find out how in Internet.
         */
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd  HH:mm:ss"));
        }
    }
}
