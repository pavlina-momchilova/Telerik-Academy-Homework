using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Print_a_Sequence
{
    class Program
    {
        /*
            Problem 9. Print a Sequence

            Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
         */
        static void Main(string[] args)
        {
            for (int i = 2; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
