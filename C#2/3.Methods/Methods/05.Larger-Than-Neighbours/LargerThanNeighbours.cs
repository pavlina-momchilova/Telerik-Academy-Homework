using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Larger_Than_Neighbours
{
   public class LargerThanNeighbours
    {
        /*
            Problem 5. Larger than neighbours

            Write a method that checks if the element at given
            position in given array of integers is larger
            than its two neighbours (when such exist).
         */

        static void Main()
        {
            Console.WriteLine("Enter array elements separated by spaces:");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine("Enter position: ");
            int position = int.Parse(Console.ReadLine());
            if (LargerNumber(array, position) == true)
            {
                Console.WriteLine("The element {0} on position {1} is larger than neighbours", array[position], position);
            }
            else Console.WriteLine("The element on position {0} is NOT larger than neighbours or position doesn't exist!",position);
        }

        public static bool LargerNumber(int[] array, int position)
        {
            if (position > 0 && position < array.Length)
            {
                if (array[position] > array[position + 1] && array[position] > array[position - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
