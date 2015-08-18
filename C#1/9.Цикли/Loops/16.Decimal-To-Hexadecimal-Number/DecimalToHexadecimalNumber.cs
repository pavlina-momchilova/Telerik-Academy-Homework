using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Decimal_To_Hexadecimal_Number
{
    class DecimalToHexadecimalNumber
    {
        /*
            Problem 16. Decimal to Hexadecimal Number

            Using loops write a program that converts an
            integer number to its hexadecimal representation.
            The input is entered as long. The output should
            be a variable of type string.
            Do not use the built-in .NET functionality.

         */
        static void Main()
        {
            Console.Title = "Decimal to Hexadecimal Number";
            Console.WriteLine("Enter decimal number: ");
            long DecimalNumber = long.Parse(Console.ReadLine());
            long divisor = DecimalNumber;
            long reminder = 0;
            string hexadecimalSystem = "0123456789ABCDEF";
            string indexOfhex = "";
            while (divisor > 0)
            {
                reminder = divisor % 16;
                divisor = divisor / 16;
                indexOfhex += reminder+" ";
            }
            string[] ArrIndexOfhex = indexOfhex.Split(' ');
            List<string> oppositeList = new List<string>();

            int oppositeIndex = ArrIndexOfhex.Length - 1;
            for (int i = 0; i < ArrIndexOfhex.Length; i++)
            {
                oppositeList.Add(ArrIndexOfhex[oppositeIndex]);
                oppositeIndex--;
            }
            Console.WriteLine("hexadecimal number is: ");
            string hexadecimalNumber="";
            for (int i = 0; i <= oppositeList.Count - 1; i++)
            {
                for (int j = 0; j <= hexadecimalSystem.Length- 1; j++)
                {
                    if (oppositeList[i]==j.ToString())
                    {
                        hexadecimalNumber += hexadecimalSystem[j];
                        break;
                    }
                }
            }
            Console.WriteLine(hexadecimalNumber);
        }
    }
}
