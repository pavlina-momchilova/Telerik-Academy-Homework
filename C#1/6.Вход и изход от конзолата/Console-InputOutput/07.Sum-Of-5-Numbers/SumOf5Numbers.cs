using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Of_5_Numbers
{
    class SumOf5Numbers
    {
        /*
            Problem 7. Sum of 5 Numbers

            Write a program that enters 5 numbers 
            (given in a single line, separated by a space),
            calculates and prints their sum.

         */
        static void Main(string[] args)
        {
            Console.Title = "Sum of 5 Numbers";
            Console.Write("Enter 5 numbers splited by space: ");
            string numbers = Console.ReadLine();
            string[] SplitedNumbers = numbers.Split(' ');
            double[] NumbersInDouble = new double[SplitedNumbers.Length];
            for (int i = 0; i < 5; i++)
            {
                NumbersInDouble[i] = Convert.ToDouble(SplitedNumbers[i]);
            }
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += NumbersInDouble[i];
            }
            Console.WriteLine(sum);
        }
    }
}
