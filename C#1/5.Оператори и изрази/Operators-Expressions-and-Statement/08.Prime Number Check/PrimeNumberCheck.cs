using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Prime_Number_Check
{
    class PrimeNumberCheck
    {
        /*
            Problem 8. Prime Number Check

            Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

         */
        static void Main(string[] args)
        {
            bool isPrime = false;
            int n = int.Parse(Console.ReadLine());
            if (n == 0 || n == 1)
            {
                Console.WriteLine("The number is not prime");
            }
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                    }
                    else
                    {
                        isPrime = true;
                    }
                }
            }
            if(isPrime==true)
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("The number is not prime");
            }
            
        }
    }
}
