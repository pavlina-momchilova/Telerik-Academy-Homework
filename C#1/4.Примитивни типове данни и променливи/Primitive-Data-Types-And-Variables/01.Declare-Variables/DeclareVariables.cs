using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Declare_Variables
{
    class DeclareVariables
    {
        /*
            Problem 1. Declare Variables

            Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
            Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

            Submit the source code of your Visual Studio project as part of your homework submission.
         */
        static void Main(string[] args)
        {
            sbyte firstNumber = -115;
            byte secondNumber = 97;
            short thirdNumber = -10000;
            ushort fourthNumber = 52130;
            uint fifthNumber = 4825932;
            Console.WriteLine("number with type sbyte(-128 to 127) =         " + firstNumber);
            Console.WriteLine("number with type byte(0 to 255) =             " + secondNumber);
            Console.WriteLine("number with type short(-32,768 to 32,767) =   " + thirdNumber);
            Console.WriteLine("number with type ushort(0 to 65,535) =        " + fourthNumber);
            Console.WriteLine("number with type uint(0 to 4,294,967,295) =   " + fifthNumber);
        }
    }
}
