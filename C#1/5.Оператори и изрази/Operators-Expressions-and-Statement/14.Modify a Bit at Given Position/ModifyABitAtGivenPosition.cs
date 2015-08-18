using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Modify_a_Bit_at_Given_Position
{
    class ModifyABitAtGivenPosition
    {
        /*
            Problem 14. Modify a Bit at Given Position

            We are given an integer number n, a bit value v (v=0 or 1) and a position p.
            Write a sequence of operators (a few lines of C# code) that modifies n to hold
            the value v at the position p from the binary representation of n while
            preserving all other bits in n.

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert a position: ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert a value: ");
            int value = int.Parse(Console.ReadLine());
            int temp = 1 << position;
            int tempAndNumber = temp & number;
            int bit = tempAndNumber >> position;
            Console.WriteLine("Before exchange: " + Convert.ToString(number,2));
            if (bit != value)
            {
                if (bit == 1)
                {
                    int newTemp = ~(1 << position);
                    int newTempAndNumber = number & newTemp;
                    Console.WriteLine("After exchange: " + Convert.ToString(newTempAndNumber, 2) + " the number is: " + newTempAndNumber);
                }
                else
                {
                    int newTemp = 1 << position;
                    int newTempAndNumber = number | newTemp;
                    Console.WriteLine("After exchange: " + Convert.ToString(newTempAndNumber, 2) + " the number is: " + newTempAndNumber);
                }
            }
            else
            {
                Console.WriteLine("After exchange: " + Convert.ToString(number, 2) + " the number is: " + number);
            }
            
        }
    }
}
