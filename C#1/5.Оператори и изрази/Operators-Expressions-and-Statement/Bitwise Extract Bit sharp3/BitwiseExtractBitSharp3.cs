using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_Extract_Bit_sharp3
{
    class BitwiseExtractBitSharp3
    {
        /*
            Problem 11. Bitwise: Extract Bit #3

            Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
            The bits are counted from right to left, starting from bit #0.
            The result of the expression should be either 1 or 0.

         */
        static void Main(string[] args)
        {
            int position = 3;
            int[] numbres = { 5, 0, 15, 5343, 62241 };
            for (int i = 0; i < numbres.Length; i++)
            {
                int temp = 1 << position;
                int nAndTemp = (numbres[i]) & temp;
                int bit = nAndTemp >> position;
                Console.WriteLine("the number: "+numbres[i]+" in binary looks like: "+Convert.ToString(numbres[i],2)+" the third bit is: "+bit);
            }
        }
    }
}
