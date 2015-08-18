using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Calculate_GCD
{
    class CalculateGCD
    {
        /*
            Problem 17.* Calculate GCD

            Write a program that calculates the greatest common
            divisor (GCD) of given two integers a and b.
            Use the Euclidean algorithm (find it in Internet).

         */
        static void Main()
        {
            Console.Title = "Calculate GCD";
            Console.WriteLine("Enter first number a= ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number b= ");
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                int c = Math.Abs(a);
                a = Math.Abs(b);
                b = c;
            }
            if (a < 0)
            {
                a = Math.Abs(a);
            }
            if (b < 0)
            {
                b = Math.Abs(b);
            }
            int Reminder = a % b;
            a = b;
            b = Reminder;
            if (Reminder > 0)
            {
                while (a % Reminder > 0)
                {
                    Reminder = a % Reminder;
                    a = b;
                    b = Reminder;
                }
            }
            else 
            {
                Reminder = a;
            }
            Console.WriteLine("GCD using Euclidean: " + Reminder);

        }
    }
}
