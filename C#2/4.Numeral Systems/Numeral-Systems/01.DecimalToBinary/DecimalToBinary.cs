using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DecimalToBinary
{
    class DecimalToBinary
    {
        /*
            Problem 1. Decimal to binary

            Write a program to convert decimal numbers to their binary representation.
         */
        static void Main()
        {
            Console.Write("The number int Decimal: ");
            int number = int.Parse(Console.ReadLine());
            int remainder = number;
            string NumInbinary = "";
            while (number > 0)
            {
                remainder = number % 2;
                NumInbinary += remainder;
                number = number / 2;
            }
            string result = "";
            for (int i = NumInbinary.Length-1; i >=0; i--)
            {
                result += NumInbinary[i];
            }
            Console.WriteLine("The number in Binary is: {0}",result);
        }
    }
}
