using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Formatting_Numbers
{
    class FormattingNumbers
    {
        /*
         Problem 5. Formatting Numbers

    Write a program that reads 3 numbers:
        integer a (0 <= a <= 500)
        floating-point b
        floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        The number a should be printed in hexadecimal, left aligned
        Then the number a should be printed in binary form, padded with zeroes
        The number b should be printed with 2 digits after the decimal point, right aligned
        The number c should be printed with 3 digits after the decimal point, left aligned.

         */
        static void Main(string[] args)
        {
            Console.Title = "Formatting Numbers";
            Console.Write("Enter an integer number between 0 and 500: ");
            int numberForA = int.Parse(Console.ReadLine());
            while(numberForA<0 || numberForA>500)
            {
                Console.Write("You enter  wrong number. Please enter a number between 0 and 500: ");
                numberForA = int.Parse(Console.ReadLine());
            }
            int a = numberForA; 

            
            string hexnumber = a.ToString("X");

            string aBinary = Convert.ToString(a,2).PadLeft(10,'0');
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            string bResult = b % 1 == 0 ? "{2,10}" : "{2,10:0.00}";

            Console.Write("Enter third number: ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("{0,-10}|{1,-10}|", hexnumber, aBinary);
            if (b % 1 == 0)
            {
                Console.Write("{0,10}", b);
            }
            else
            {
                Console.Write("{0,10:0.00}", b);
            }
            Console.Write("|{0,-10:0.000}|", c);
        }
    }
}
