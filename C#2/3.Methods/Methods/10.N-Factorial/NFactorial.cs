using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.N_Factorial
{
    class NFactorial
    {
        /*
            Problem 10. N Factorial

            Write a program to calculate n! for each n in the range [1..100].
         */
        static void Main()
        {
            Console.Write("Enter number in range[1...100]: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("{0}! = ",n);
            Console.WriteLine(Factorial(n));
        }
        static BigInteger Factorial(int number)
        {
            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
