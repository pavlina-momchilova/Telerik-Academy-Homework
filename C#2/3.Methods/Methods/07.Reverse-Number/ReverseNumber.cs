using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_Number
{
    class ReverseNumber
    {
        /*
            Problem 7. Reverse number

            Write a method that reverses the digits of given decimal number.
         */
        static void Main()
        {
            Console.WriteLine("Enter decimal number: ");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Reversed number is: ");
            Console.WriteLine(Reverse(number));

        }
        static decimal Reverse(decimal number)
        {
            string toReverse = number.ToString();
            string ReversedNum = "";
            for (int i = toReverse.Length - 1; i >= 0; i--)
            {
                ReversedNum+=toReverse[i];
            }
            return Convert.ToDecimal(ReversedNum);
        }
    }
}
