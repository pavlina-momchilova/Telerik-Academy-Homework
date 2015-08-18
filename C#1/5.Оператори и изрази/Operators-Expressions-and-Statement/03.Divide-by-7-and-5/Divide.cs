using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Divide_by_7_and_5
{
    class Divide
    {
        /*
            Problem 3. Divide by 7 and 5

            Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

         */
        static void Main(string[] args)
        {
            int[] numbers = { 3, 0, 5, 7, 35, 140 };
            bool IsDevide = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    IsDevide = false;
                    Console.WriteLine("The number : " + numbers[i] + " is not devided by 5 and 7 => " + IsDevide);
                }
                else if (numbers[i] % 5 == 0 && numbers[i] % 7 == 0)
                {
                    IsDevide = true;
                    Console.WriteLine("The number : " + numbers[i] + " is devided by 5 and 7 => " + IsDevide);
                }
                else
                {
                    IsDevide = false;
                    Console.WriteLine("The number : " + numbers[i] + " is not devided by 5 and 7 => " + IsDevide);
                }
            }

        }
    }
}
