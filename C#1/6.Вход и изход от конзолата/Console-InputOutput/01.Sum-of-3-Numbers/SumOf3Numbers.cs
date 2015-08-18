using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_of_3_Numbers
{
    class SumOf3Numbers
    {
        /*
            Problem 1. Sum of 3 Numbers

            Write a program that reads 3 real numbers from the console and prints their sum.
         */
        static void Main()
        {
            Console.Title = "Sum of 3 Numbers";
            Console.Write("Insert a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Insert b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Insert c = ");
            double c = double.Parse(Console.ReadLine());
            double sum = a + b + c;
            Console.WriteLine("{0} + {1} + {2} = {3}",a,b,c,sum);
        }
    }
}
