using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Decimal_To_Binary_Number
{
    class DecimalToBinaryNumber
    {
        /*
            Problem 14. Decimal to Binary Number

            Using loops write a program that converts an
            integer number to its binary representation.
            The input is entered as long. The output should
            be a variable of type string.
            Do not use the built-in .NET functionality.

         */
        static void Main()
        {
            Console.Title = "Decimal to Binary Number";
            Console.Write("Enter your Decimal number: ");
            long DecimalNumber = long.Parse(Console.ReadLine());
            string Binary = "";
            string BinaryNumber = "";
            long Division=DecimalNumber;
            long Remainder;
            Console.Write("Your Binary number is:  ");
            while (Division > 0)
            {
                Remainder = Division % 2;
                Binary += Remainder;
                Division = Division / 2;
            }

            for (int i=Binary.Length-1;i>=0;i--)
            {
                BinaryNumber += Binary[i];   
            }
                Console.WriteLine(BinaryNumber);
        }
    }
}
