using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.The_Biggest_Of_3_Numbers
{
    class TheBiggestOf3Numbers
    {
        /*
            Problem 5. The Biggest of 3 Numbers

            Write a program that finds the biggest of three numbers.

         */
        static void Main()
        {
            Console.Title = "The Biggest of 3 Numbers";
            Console.WriteLine("Enter first number a = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number c = ");
            double c = double.Parse(Console.ReadLine());

            double max=0;
            if (a > b)
            {
                max = a;
                if (a < c)
                {
                    max = c;
                }
            }
            else 
            {
                max = b;
                if (b < c)
                {
                    max = c;
                }
            }
            Console.WriteLine("The biggest number is: {0}",max);
        }
    }
}
