using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Check_a_Bit_at_Given_Position
{
    class CheckABitAtGivenPosition
    {
        /*
            Problem 13. Check a Bit at Given Position

            Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insert integer number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert position: ");
            int position = int.Parse(Console.ReadLine());
            int temp = 1 << position;
            int numberAndTemp = temp & number;
            int bit = numberAndTemp >> position;
            bool bitIsOne = false;
            if (bit == 1)
            {
                bitIsOne = true;
                Console.WriteLine("The bit in " + position + " position in number " + number + " is 1 ? - " + bitIsOne);
            }
            else
            {
                bitIsOne = false;
                Console.WriteLine("The bit in " + position + " position in number " + number + " is 1 ? - " + bitIsOne);
            }
        }
    }
}
