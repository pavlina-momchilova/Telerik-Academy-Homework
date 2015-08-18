using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Of_n_Numbers
{
    class SumOfNNumbers
    {
        /*
            Problem 9. Sum of n Numbers

            Write a program that enters a number n and after that
            enters more n numbers and calculates and prints their sum.
            Note: You may need to use a for-loop.

         */
        static void Main()
        {
            Console.Title = "Sum of n Numbers";
            Console.WriteLine("Enter how many numbers you want to sum: ");
            int count = int.Parse(Console.ReadLine());
            double sum = 0;
            Console.WriteLine("Enter the numbers: ");
            for (int i = 0; i < count; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
