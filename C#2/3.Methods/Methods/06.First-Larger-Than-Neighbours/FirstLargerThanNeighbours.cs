using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.Larger_Than_Neighbours;

namespace _06.First_Larger_Than_Neighbours
{
    class FirstLargerThanNeighbours
    {
        /*
            Problem 6. First larger than neighbours

            Write a method that returns the index of the first
            element in array that is larger than its neighbours, 
            or -1, if there’s no such element.
            Use the method from the previous exercise.
         */
        static void Main()
        {
            Console.WriteLine("Enter array elements separated by spaces:");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(FirstLargerNumber(array));
        }
        static int FirstLargerNumber(params int[] arr)
        {
            for (int i = 1; i < arr.Length-1; i++)
            {
                if (LargerThanNeighbours.LargerNumber(arr, i) == true)
                {
                    return i;
                }             
            }
            return -1;
        }
    }
}
