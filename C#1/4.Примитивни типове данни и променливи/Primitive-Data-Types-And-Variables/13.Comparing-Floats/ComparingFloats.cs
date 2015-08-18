using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Comparing_Floats
{
    class ComparingFloats
    {
        /*
            Problem 13.* Comparing Floats

            Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

            Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
            Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
         */
        static void Main(string[] args)
        {
            decimal a = 4.999999M;
            decimal b = 4.999998M;
            decimal esp = 0.000001M;
            decimal c = a-b;
            bool result = true;
            if (c < esp)
            {
                Console.WriteLine("Number a=" + a + " Number b=" + b  );
                Console.WriteLine(" Equal(with precision eps=0.000001):" + result);
                Console.WriteLine(" Explanation : The difference " + c + "< eps");
            }
            else if (c == esp)
            {
                result = false;
                Console.WriteLine("Number a=" + a + " Number b=" + b); 
                Console.WriteLine(" Equal(with precision eps=0.000001):" + result);
                Console.WriteLine(" Explanation : Border case.The difference " + c + "== eps. We consider the numbers are different");
            }
            else
            {
                result = false;
                Console.WriteLine("Number a=" + a + " Number b=" + b);
                Console.WriteLine(" Equal(with precision eps=0.000001):" + result);
                Console.WriteLine(" Explanation : The difference of" + c + " is too big (> eps)");
            }

        }
    }
}
