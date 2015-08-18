using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Extract_Bit_from_Integer
{
    class ExtractBitFromInteger
    {
        /*
            Problem 12. Extract Bit from Integer

            Write an expression that extracts from given integer n the value of given bit at index p.

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insert positive number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert position: ");
            int position = int.Parse(Console.ReadLine());
            int temp = 1 << position;
            int numberAndTemp = temp & number;
            int bit = numberAndTemp >> position;
            Console.WriteLine("the number in binary looks like: "+Convert.ToString(number,2)+" And the third bit is: "+ bit);

        }
    }
}
