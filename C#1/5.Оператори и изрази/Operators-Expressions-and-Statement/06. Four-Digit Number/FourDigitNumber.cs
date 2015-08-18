using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Four_Digit_Number
{
    class FourDigitNumber
    {
        /*
            Problem 6. Four-Digit Number

            Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
            Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
            Prints on the console the number in reversed order: dcba (in our example 1102).
            Puts the last digit in the first position: dabc (in our example 1201).
            Exchanges the second and the third digits: acbd (in our example 2101).

            The number has always exactly 4 digits and cannot start with 0.
         */
        static void Main(string[] args)
        {
            int FourDigitNum;
            string FourDigit = "";
            Console.WriteLine("Insert four digit number");
            int sum;
            string reverse = "";
            string lastInFirst = "";
            string exchange = "";
            FourDigitNum=int.Parse(Console.ReadLine());
            if ((FourDigitNum / 1000) != 0)
            {
                FourDigit=FourDigitNum.ToString();
                sum = ((int)FourDigit[0] - '0') + ((int)FourDigit[1] - '0') + ((int)FourDigit[2] - '0') + ((int)FourDigit[3] - '0');
                Console.WriteLine("The sum is: "+sum);
                reverse += FourDigit[3];
                reverse+=FourDigit[2];
                reverse += FourDigit[1];
                reverse += FourDigit[0];
                Console.WriteLine("The reverse number is: "+reverse);
                lastInFirst += FourDigit[3];
                lastInFirst += FourDigit[0];
                lastInFirst += FourDigit[1];
                lastInFirst += FourDigit[2];
                Console.WriteLine("The Last digit in first position is: " + lastInFirst);
                exchange += FourDigit[0];
                exchange += FourDigit[2];
                exchange += FourDigit[1];
                exchange += FourDigit[3];
                Console.WriteLine("Exchange the second and the third digits is: " + exchange);
            }


        }
    }
}
