using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Hexadecimal_To_Decimal_Number
{
    class HexadecimalToDecimalNumber
    {
        /*
            Problem 15. Hexadecimal to Decimal Number

            Using loops write a program that converts a
            hexadecimal integer number to its decimal form.
            The input is entered as string. The output should
            be a variable of type long.
            Do not use the built-in .NET functionality.

         */
        static void Main()
        {
            Console.Title = "Hexadecimal to Decimal Number";
            Console.WriteLine("Enter hexadecimal number: ");
            string hexadecimalNumber = Console.ReadLine();
            string hexadecimalSystem = "0123456789ABCDEF";
            int index = 0;
            int power = hexadecimalNumber.Length - 1;
            long decimalNumber = 0;
            Console.WriteLine("Decimal number is: ");
            for (int i = 0; i <= hexadecimalNumber.Length-1; i++)
            {
                for (int j = 0; j <= hexadecimalSystem.Length - 1; j++)
                {
                    if (hexadecimalNumber[i] == hexadecimalSystem[j])
                    {
                        index = j;
                        break;
                    }
                }
                decimalNumber +=index * (long)Math.Pow(16, power);
                power--;
            }
            Console.WriteLine(decimalNumber);
        }
    }
}
