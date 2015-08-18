using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumIntegers
{
    class SumIntegers
    {
        /*
         Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
         */
        static int Sum(string numbers)
        {
            int sum = 0;
            string[] arr = numbers.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                sum += Convert.ToInt32(arr[i]);
            }
            return sum;
        }
        static void Main()
        {
            Console.Write("Enter number separated by space: ");
            string numbers = Console.ReadLine();
            Console.WriteLine("The sum of the numbers is: "+Sum(numbers));
        }
    }
}
