using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Random_Numbers_in_Given_Range
{
    class RandomNumbersInGivenRange
    {
        /*
            Problem 11. Random Numbers in Given Range

            Write a program that enters 3 integers n,
            min and max (min != max) and prints n random
            numbers in the range [min...max].

         */
        static void Main()
        {
            Console.Title = "Random Numbers in Given Range";
            Console.WriteLine("Enter how many numbers n= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter interval min= ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("max= ");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Your random numbers between {0} and {1} are:", min, max);
            Random randomNumber = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ",randomNumber.Next(min, max+1));
            }
            Console.WriteLine();
        }
    }
}
