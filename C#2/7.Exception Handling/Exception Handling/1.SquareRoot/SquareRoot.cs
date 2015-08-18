using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SquareRoot
{
    class SquareRoot
    {
        /*
         Problem 1. Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
         */
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Exception ex = new Exception();
                    throw ex;
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
