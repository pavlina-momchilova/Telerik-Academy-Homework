using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Multiplication_Sign
{
    class MultiplicationSign
    {
        /*
            Problem 4. Multiplication Sign

            Write a program that shows the sign (+, - or 0)
            of the product of three real numbers, without calculating it.
            Use a sequence of if operators.

         */
        static void Main()
        {
            Console.Title = "Multiplication Sign";
            Console.WriteLine("Enter first number a = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number c = ");
            double c = double.Parse(Console.ReadLine());
            if(a==0 || b==0 || c==0)
            {
                Console.WriteLine("0");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("Result: -");
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("Result: +");
            }
            else if (a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("Result: +");
            }
            else if (a > 0 && b < 0 && c < 0)
            {
                Console.WriteLine("Result: +");
            }
            else if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Result: -");
            }
            else if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("Result: -");
            }
            else if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("Result: -");
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Result: +");
            }
        }
    }
}
