using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Bit_Exchange__Advanced_
{
    class Program
    {
        /*
            Problem 16.** Bit Exchange (Advanced)

            Write a program that exchanges bits {p, p+1, …, p+k-1}
            with bits {q, q+1, …, q+k-1} of a given 32-bit
            unsigned integer.
            The first and the second sequence of bits
            may not overlap.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number: ");
            long number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Insert position for p: ");
            int p = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Insert position for q: ");
            int q = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Insert how many times k: ");
            int k = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The number before exchanges is : " + number);
            Console.WriteLine("The binary code of the number is: " + Convert.ToString(number, 2).PadLeft(32, '0'));
            k--;
            if (p < 0 || q < 0 || 32 - p <= k || 32 - q <= k)
            {
                Console.WriteLine("out of range");
            }
            else if (Math.Abs(p - q) < k)
            {
                Console.WriteLine("overlapping");
            }
           
            else 
            {
                while(k>0)
                {
                    long tempP = 1 << p + k;
                    long TempPAndNumber = tempP & number;
                    long PBit = TempPAndNumber >> p + k;

                    long tempQ = 1 << q + k;
                    long TempQAndNumber = tempQ & number;
                    long QBit = TempQAndNumber >> q + k;
                    if (PBit == 0)
                    {
                        int maskQ = ~(1 << q + k);
                        number = number & maskQ;
                    }
                    else
                    {
                        int maskQ = 1 << q + k;
                        number = number | maskQ;
                    }
                    if (QBit == 0)
                    {
                        int maskP = ~(1 << p + k);
                        number = number & maskP;
                    }
                    else
                    {
                        int maskP = 1 << p + k;
                        number = number | maskP;
                    }

                    k--;
                }
                Console.WriteLine("The number after exchanges is : "+number);
                Console.WriteLine("The binary code of the exchange number is: " + Convert.ToString(number, 2).PadLeft(32, '0'));
            }
        }
    }
}
