﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Digit
{
    class EnglishDigit
    {
        static string LastDigit(int number)
        {
            string numberStr = number.ToString();
            switch (numberStr[numberStr.Length - 1])
            {
                case '0': return "zero";

                case '1': return "one";

                case '2': return "two";

                case '3': return "three";

                case '4': return "four";

                case '5': return "five";

                case '6': return "six";

                case '7': return "seven";

                case '8': return "eight";

                case '9': return "nine";

                default: return "Wrong input!";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(LastDigit(number));
        }
    }
}
