using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.Calculate7
{
    class Calculate7
    {
        /*
            In combinatorics, the number of ways to choose
            k different members out of a group of n different elements
            (also known as the number of combinations) is calculated by
            the following formula: formula For example, there are 2598960
            ways to withdraw 5 cards out of a standard deck of 52 cards.
            Your task is to write a program that calculates n! / (k! * (n-k)!)
            for given n and k (1 < k < n < 100). Try to use only two loops.

         */
        static void Main()
        {
            Console.Title = "Calculate N! / (K! * (N-K)!)";
            Console.WriteLine("Enter n between 2 and 100 : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n between 1 and n : ");
            int k = int.Parse(Console.ReadLine());

            if (1 < k && k < n && n < 100)
            {
                BigInteger nFactoriel = 1;
                BigInteger kFactoriel = 1;
                BigInteger nMinuskFactoriel=1;
                int i=1;
                BigInteger result = 0;
                while (i <= n)
                {
                    if (i <= k)
                    {
                        kFactoriel = kFactoriel * i;
                    }
                    nFactoriel = nFactoriel * i;
                    if (i<=(n - k))
                    {
                        nMinuskFactoriel = nMinuskFactoriel * i;
                    }
                    i++;
                }

                result = nFactoriel / (kFactoriel*nMinuskFactoriel);
                Console.WriteLine("The result is: "+result);
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
