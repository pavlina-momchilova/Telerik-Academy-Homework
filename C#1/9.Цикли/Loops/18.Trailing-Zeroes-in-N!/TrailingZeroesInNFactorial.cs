using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18.Trailing_Zeroes_in_N_
{
    class TrailingZeroesInNFactorial
    {
        /*
            Problem 18.* Trailing Zeroes in N!

            Write a program that calculates with
            how many zeroes the factorial of a given
            number n has at its end.
            Your program should work well for very
            big numbers, e.g. n=100000.

         */
        static void Main()
        {
            Console.Write("Enter a number: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger number = n;
            BigInteger division = n;
            int count = 0;
            while (division > 5)
            {
                division = division / 5;
                count++;
            }
            BigInteger numberOfNules=0;
            for (int i = 1; i <= count;i++)
            {
                numberOfNules += n / (BigInteger)Math.Pow(5,i);
            }
                Console.WriteLine("number of zeros is: "+numberOfNules);
        }
    }
}
