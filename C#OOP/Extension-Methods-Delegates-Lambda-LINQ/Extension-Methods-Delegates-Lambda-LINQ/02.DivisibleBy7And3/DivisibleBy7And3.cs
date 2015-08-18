namespace _02.DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DivisibleBy7And3
    {
        /*
            Problem 6. Divisible by 7 and 3

            Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
            Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
         */
        static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Console.WriteLine("The numbers divisible by 7 and 3 are: ");
            Console.WriteLine("With built-in extension methods and lambda expressions");
            var divisibleNums = arr.Where(x => x % 3 == 0 || x % 7 == 0);
            foreach (var number in divisibleNums)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            Console.WriteLine("With built-in extension methods and lambda expressions");
            Console.WriteLine();
            var divisibleNumsLINQ = from number in arr
                                    where number % 3 == 0 || number % 7 == 0
                                    select number;
            foreach (var number in divisibleNumsLINQ)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
        }
    }
}
