using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReverseString
{
    class ReverseString
    {
        /*
         Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
         */
        static void Main()
        {
            Console.WriteLine("Enter a string to reverse");
            string ToReverse = Console.ReadLine();
            string result=String.Empty;
            for (int i = ToReverse.Length-1; i >= 0; i--)
            {
                result=String.Concat(result, ToReverse[i]);
            }
            Console.WriteLine(result);
        }
    }
}
