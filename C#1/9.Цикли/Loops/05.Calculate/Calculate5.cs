using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate
{
    class Calculate5
    {
        /*
            Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

            Write a program that, for a given two integer numbers
            n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
            Use only one loop. Print the result with 5 digits after
            the decimal point.

         */

        static void Main(string[] args)
        {
            Console.Title = "Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N";
            Console.WriteLine("Enter a number for n: ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number for x: ");
            double x = double.Parse(Console.ReadLine());
            double nFactrorial = 1;
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactrorial = nFactrorial * i;
                sum +=((nFactrorial) / (Math.Pow(x, i)));
            }

            Console.WriteLine("sum is: {0:0.00000}",sum);
        }
    }
}
