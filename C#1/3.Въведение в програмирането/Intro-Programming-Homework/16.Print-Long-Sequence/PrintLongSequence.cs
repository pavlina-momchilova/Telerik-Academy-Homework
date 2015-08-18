using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Print_Long_Sequence
{
    class PrintLongSequence
    {
        /*
            Problem 16.* Print Long Sequence

            Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
            You might need to learn how to use loops in C# (search in Internet).
         */
        static void Main(string[] args)
        {
            string numbers="";
            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 == 0)
                {
                    numbers += i;
                    numbers += ", ";
                }
                else
                {
                    numbers += (-i);
                    numbers += ", ";
                }
            }
            Console.WriteLine(numbers);
        }
    }
}
