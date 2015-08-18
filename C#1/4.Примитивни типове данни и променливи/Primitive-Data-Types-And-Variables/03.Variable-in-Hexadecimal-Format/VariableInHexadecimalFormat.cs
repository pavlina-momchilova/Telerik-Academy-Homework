using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Variable_in_Hexadecimal_Format
{
    class VariableInHexadecimalFormat
    {
        /*
            Problem 3. Variable in Hexadecimal Format

            Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
            Use Windows Calculator to find its hexadecimal representation.
            Print the variable and ensure that the result is 254.

         */
        static void Main(string[] args)
        {
            int hexadecimal = 0xFE;
            Console.WriteLine("the hexadecimal is FE and the result is : "+hexadecimal);
        }
    }
}
