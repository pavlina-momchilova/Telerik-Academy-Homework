using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Number_Comparer
{
    class NumberComparer
    {
        /*
            Problem 4. Number Comparer

            Write a program that gets two numbers from
            the console and prints the greater of them.
            Try to implement this without if statements.
         */
        static void Main(string[] args)
        {
            Console.Title = "Number Comparer";
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            double greater = a > b ? a : b;
            Console.WriteLine("The greater number is: " + greater);
        }
    }
}
