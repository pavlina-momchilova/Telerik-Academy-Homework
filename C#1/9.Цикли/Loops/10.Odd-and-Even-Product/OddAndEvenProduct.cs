using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Odd_and_Even_Product
{
    class OddAndEvenProduct
    {
        /*
            Problem 10. Odd and Even Product

            You are given n integers (given in a single line,
            separated by a space).
            Write a program that checks whether the product of
            the odd elements is equal to the product of the even elements.
            Elements are counted from 1 to n, so the first element
            is odd, the second is even, etc.

         */
        static void Main()
        {
            Console.Title = "Odd and Even Product";
            Console.WriteLine("Enter n integer number on a single line: ");
            string numbers = Console.ReadLine();
            string[] number = (numbers.Split(' '));
            int ProductOdd = 1;
            int ProductEven = 1;
            for (int i = 0; i <= number.Length-1; i++)
            {
                if (i % 2 == 0)
                {
                    ProductEven = ProductEven * Convert.ToInt32(number[i]);
                }
                else
                {
                    ProductOdd = ProductOdd * Convert.ToInt32(number[i]);
                }
            }
            if (number.Length > 1)
            {
                Console.WriteLine("Product of all numbers of even position is: " + ProductEven);
                Console.WriteLine("Product of all numbers of odd position is: " + ProductOdd);
                if (ProductEven == ProductOdd)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine("no! because there is just one number");
            }
            
           
        }
    }
}
