using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Binary_to_Decimal_Number
{
    class BinaryToDecimalNumber
    {
        /*
            Problem 13. Binary to Decimal Number

            Using loops write a program that converts
            a binary integer number to its decimal form.
            The input is entered as string. The output 
            should be a variable of type long.
            Do not use the built-in .NET functionality.

         */
        static void Main()
        {
            Console.Title = "Binary to Decimal Number";
            Console.Write("Enter a binary number: ");
            string BinaryNumber = Console.ReadLine();
            long DecimalNumber=0;
            int Power = BinaryNumber.Length - 1;
            Console.Write("Your decimal number is: ");
            for (int i = 0; i < BinaryNumber.Length; i++)
            {
                int BinaryDigit = (int)(BinaryNumber[i] - '0');

                DecimalNumber += BinaryDigit * ((int)Math.Pow(2, Power));
                Power--;
            }
            Console.WriteLine(DecimalNumber);
        }
    }
}
