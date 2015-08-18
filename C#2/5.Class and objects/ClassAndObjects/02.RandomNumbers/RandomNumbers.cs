using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomNumbers
{
    class RandomNumbers
    {
        /*
         Problem 2. Random numbers

Write a program that generates and prints to the console 10 random values in the range [100, 200].
         */
        static int number;
        static void Main()
        {
            Random RandomGenerator=new Random();
            for (int i = 0; i < 10; i++)
            {
                number = RandomGenerator.Next(100, 200);
                if (i != 9)
                {
                    Console.Write(number + ", ");
                }
                else
                {
                    Console.Write(number);
                }
            }
            Console.WriteLine();
        }
    }
}
