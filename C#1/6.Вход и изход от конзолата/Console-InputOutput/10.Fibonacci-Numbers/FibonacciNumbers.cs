using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        /*
            Problem 10. Fibonacci Numbers

            Write a program that reads a number n
            and prints on the console the first n members
            of the Fibonacci sequence (at a single line,
            separated by comma and space - ,) :
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

            Note: You may need to learn how to use loops.
         */
        static void Main()
        {
            Console.Title = "Fibonacci Numbers";
            Console.WriteLine("Enter how many fibonacci numbers you want: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("the fibonacci Numbers are: ");
            int firstNumber = 0;
            int secondNumber = 1;
            if (count == 1)
            {
                Console.WriteLine(firstNumber);
            }
            else if (count == 2)
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
                for (int i = 0; i < count - 2; i++)
                {
                    int fibonacciNumbers = secondNumber + firstNumber;
                    Console.WriteLine(fibonacciNumbers);
                    firstNumber = secondNumber;
                    secondNumber = fibonacciNumbers;
                }
            }
           
        }
    }
}
