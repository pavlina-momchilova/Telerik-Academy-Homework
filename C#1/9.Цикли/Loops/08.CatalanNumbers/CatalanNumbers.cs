using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        /*
            Problem 8. Catalan Numbers

            In combinatorics, the Catalan numbers are calculated
            by the following formula: catalan-formula
            Write a program to calculate the nth Catalan number
            by given n (1 <= n <= 100).

         */
        static void Main(string[] args)
        {
            Console.Title = "Catalan Numbers";
            Console.WriteLine("Enter n= ");
            int n=int.Parse(Console.ReadLine());
            double product = 1;
            for (double k = 2; k <= n; k++)
            {
                product = product * ((n + k) / k);
            }
            Console.WriteLine(product);
        }
    }
}
