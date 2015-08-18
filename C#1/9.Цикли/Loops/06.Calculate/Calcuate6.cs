using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate
{
    class Calcuate6
    {
        /*
            Problem 6. Calculate N! / K!

            Write a program that calculates n! / k!
            for given n and k (1 < k < n < 100).
            Use only one loop.

         */
        static void Main(string[] args)
        {
            Console.Title = "Calculate N! / K!";
            Console.WriteLine("Enter n between 2 and 100:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter k between 1 and n:");
            int k = int.Parse(Console.ReadLine());

            int nFactoriel = 1;
            int kFactoriel = 1;
            int i=1;
            int result = 0;
            if (1 < k && k < n && n < 100)
            {
                while (i<=n)
                {
                    if (i <= k)
                    {
                        kFactoriel = kFactoriel * i;
                    }
                    nFactoriel = nFactoriel * i;
                    i++;
                }
                result = nFactoriel / kFactoriel;
                Console.WriteLine("The result is: {0}",result);
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
