using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Null_Values_Arithmetic
{
    class NullValuesArithmetic
    {
        /*
            Problem 12. Null Values Arithmetic

            Create a program that assigns null values to an integer and to a double variable.
            Try to print these variables at the console.
            Try to add some number or the null literal to these variables and print the result.

         */
        static void Main(string[] args)
        {
            int? integerVariable = null;
            double? doubleVariable = null;
            Console.WriteLine("This is integer with null value : " + integerVariable);
            Console.WriteLine("This is double with null value : " + doubleVariable);
            integerVariable = 1;
            doubleVariable = 2.5;
            Console.WriteLine("This is integer with value 1 : " + integerVariable);
            Console.WriteLine("This is double with value 2.5 : " + doubleVariable);
        }
    }
}
