using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.The_Biggest_of_Five_Numbers
{
    class TheBiggestOfFiveNumbers
    {
        /*
            Problem 6. The Biggest of Five Numbers

            Write a program that finds the biggest of five numbers
            by using only five if statements.

         */
        static void Main()
        {
            Console.Title = "The Biggest of Five Numbers";
            Console.WriteLine("Enter first number a = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number c = ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth number d = ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter fifth number e = ");
            double e = double.Parse(Console.ReadLine());

            double max = 0;
            if (a >= b && a >= c && a >= d && a >= e)
            {
                max = a;
            }
            else if (b >= a && b >= c && b >= d && b >= e)
            {
                max = b;
            }
            else if (c >= a && c >= b && c >= d && c >= e)
            {
                max = c;
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                max = d;
            }
            else if (e >= a && e >= b && e >= c && e >= d)
            {
                max = e;
            }
            Console.WriteLine("The biggest number is : {0}",max);
        }
    }
}
