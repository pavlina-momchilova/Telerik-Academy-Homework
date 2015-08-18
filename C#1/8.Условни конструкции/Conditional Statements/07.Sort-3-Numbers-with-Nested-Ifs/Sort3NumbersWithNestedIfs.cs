using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort_3_Numbers_with_Nested_Ifs
{
    class Sort3NumbersWithNestedIfs
    {
        /*
         
            Problem 7. Sort 3 Numbers with Nested Ifs

            Write a program that enters 3 real numbers and prints
            them sorted in descending order.
            Use nested if statements.

            Note: Don’t use arrays and the built-in sorting functionality.
         */
        static void Main(string[] args)
        {
            Console.Title = "Sort 3 Numbers with Nested Ifs";
            Console.WriteLine("Enter first number a = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number c = ");
            double c = double.Parse(Console.ReadLine());
            double max = 0;
            string sortedNumbers = "";
            if (a > b)
            {
                max = a;

                if (c > a)
                {
                    max = c;
                    sortedNumbers += max;
                    sortedNumbers += " ";
                    sortedNumbers += a;
                    sortedNumbers += " ";
                    sortedNumbers += b;
                }
                else if (b > c)
                {
                    sortedNumbers += max;
                    sortedNumbers += " ";
                    sortedNumbers += b;
                    sortedNumbers += " ";
                    sortedNumbers += c;
                }
                else 
                {
                    sortedNumbers += max;
                    sortedNumbers += " ";
                    sortedNumbers += c;
                    sortedNumbers += " ";
                    sortedNumbers += b;
                }
            }
            else
            {
                max = b;
                if (c > b)
                {
                    max = c;
                    sortedNumbers += max;
                    sortedNumbers += " ";
                    sortedNumbers += b;
                    sortedNumbers += " ";
                    sortedNumbers += a;
                }
                else if (a > c)
                {
                    sortedNumbers += max;
                    sortedNumbers += " ";
                    sortedNumbers += a;
                    sortedNumbers += " ";
                    sortedNumbers += c;
                }
                else
                {
                    sortedNumbers += max;
                    sortedNumbers += " ";
                    sortedNumbers += c;
                    sortedNumbers += " ";
                    sortedNumbers += a;
                }
            }
            Console.WriteLine(sortedNumbers);
        }
    }
}
