using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Third_Digit_is_7
{
    class ThirdDigitIs7
    {
        /*
            Problem 5. Third Digit is 7?

            Write an expression that checks for given integer if its third digit from right-to-left is 7.

         */
        static void Main(string[] args)
        {
            int[] numbers = { 5, 701, 9703, 877, 777877, 9999799 };
            bool IsSeven = false;
            string ThirdDigit="";
            for (int i = 0; i < numbers.Length; i++)
            {
                ThirdDigit+=numbers[i] / 100;
                if (ThirdDigit[ThirdDigit.Length-1] == '7')
                {
                    IsSeven = true;
                    Console.WriteLine("Third digit from right to left is 7 => "+IsSeven);
                }
                else
                {
                    IsSeven = false;
                    Console.WriteLine("Third digit from right to left is not 7 => " + IsSeven);
                }
            
            }
            //Console.WriteLine(9999799 / 100);
           
            //Console.WriteLine(num = (num=num / 100));
        }
    }
}
