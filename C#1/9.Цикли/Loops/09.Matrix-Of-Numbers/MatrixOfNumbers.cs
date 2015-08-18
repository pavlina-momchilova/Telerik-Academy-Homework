using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Matrix_Of_Numbers
{
    class MatrixOfNumbers
    {
        /*
            Problem 9. Matrix of Numbers

            Write a program that reads from the console
            a positive integer number n (1 = n = 20) and prints
            a matrix like in the examples below. Use two nested loops.
         */
        static void Main()
        {
            Console.Title = "Matrix of Numbers";
            Console.WriteLine("Enter number between 1 and 20");
            int n = int.Parse(Console.ReadLine());
            int k=0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i);
                    i++;
                }
                Console.WriteLine("");
                k++;
                i = k;
            }
        }
    }
}
