using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Bits_Exchange
{
    class BitsExchange
    {
        /*
            Problem 15.* Bits Exchange

            Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number: ");
            long number = uint.Parse(Console.ReadLine());
            Console.WriteLine("The number befor exchange is : "+number);
            Console.WriteLine("The binary code is : " + Convert.ToString(number, 2).PadLeft(32, '0'));
            long tempForBit3 = 1 << 3;
            long tempForBit3AndNumber = tempForBit3 & number;
            long ThirdBit = tempForBit3AndNumber >> 3;

            long tempForBit4 = 1 << 4;
            long tempForBit4AndNumber = tempForBit4 & number;
            long FourthBit = tempForBit4AndNumber >> 4;

            long tempForBit5 = 1 << 5;
            long tempForBit5AndNumber = number & tempForBit5;
            long fifthBit = tempForBit5AndNumber >>5;

            long tempForBit24 = 1 << 24;
            long tempForBit24AndNumber = tempForBit24 & number ;
            long TwentyFourthBit = tempForBit24AndNumber >> 24;

            long tempForBit25 = 1 << 25;
            long tempForBit25AndNumber = tempForBit25 & number;
            long TwentyFifthBit = tempForBit25AndNumber >> 25;

            long tempForBit26 = 1 << 26;
            long tempForBit26AndNumber = tempForBit26 & number;
            long TwentySixthBit = tempForBit26AndNumber >> 3;
            
            long newNumber;

            if (ThirdBit == 0)
            {
                long mask24 = ~(1 << 24);
                newNumber = number & mask24;
            }
            else
            {
                long mask24 = 1 << 24;
                newNumber = number | mask24;
            }

            if (FourthBit == 0)
            {
                long mask25 = ~(1 << 25);
                newNumber = newNumber & mask25;
            }
            else
            {
                long mask25 = 1 << 25;
                newNumber = newNumber | mask25;
            }

            if (fifthBit == 0)
            {
                long mask26 = ~(1 << 26);
                newNumber = newNumber & mask26;
            }
            else
            {
                long mask26 = 1 << 26;
                newNumber = newNumber | mask26;
            }

            if (TwentySixthBit == 0)
            {
                long mask5 = ~(1 << 5);
                newNumber = newNumber & mask5;
            }
            else
            {
                long mask5 = 1 << 5;
                newNumber = newNumber | mask5;
            }

            if (TwentyFourthBit == 0)
            {
                long mask3 = ~(1 << 3);
                newNumber = newNumber & mask3;
            }
            else
            {
                long mask3 = 1 << 3;
                newNumber = newNumber | mask3;
            }

            if (TwentyFifthBit == 0)
            {
                long mask4 = ~(1 << 4);
                newNumber = newNumber & mask4;
            }
            else
            {
                long mask4 = 1 << 4;
                newNumber = newNumber | mask4;
            }
            Console.WriteLine("The number after exchange is : " + newNumber);
            Console.WriteLine("The binary code is :   "+ Convert.ToString(newNumber,2).PadLeft(32, '0'));
        }
    }
}
