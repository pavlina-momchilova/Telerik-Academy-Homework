using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Float_or_Double
{
    class FloatOrDouble
    {
        /*
            Problem 2. Float or Double?

            Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
            Write a program to assign the numbers in variables and print them to ensure no precision is lost.

         */
        static void Main(string[] args)
        {
            double firstNumber = 34.567839023;
            float secondNumber = 12.345f;
            double thirdNumber = 8923.1234857;
            float fourthNumber = 3456.091f;
            Console.WriteLine("double(persicion 15-16) =   " + firstNumber);
            Console.WriteLine("float(persicion 7) =        " + secondNumber);
            Console.WriteLine("double(persicion 15-16) =   " + thirdNumber);
            Console.WriteLine("float(persicion 7) =        " + fourthNumber);
        }
    }
}
