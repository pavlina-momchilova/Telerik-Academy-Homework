using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exchange_If_Greater
{
    class ExchangeIfGreater
    {
        /*
            Problem 1. Exchange If Greater

            Write an if-statement that takes two double variables a and b
            and exchanges their values if the first one is greater than the second one.
            As a result print the values a and b, separated by a space.

         */
        static void Main(string[] args)
        {
            Console.Title = "Exchange If Greater";
            Console.Write("Enter first double variabe a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second double variabe b = ");
            double b = double.Parse(Console.ReadLine());
            double c = a;
            if (a > b)
            {
                a = b;
                b = c;
                Console.WriteLine("{0} {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} {1}",a,b);
            }
        }
    }
}
