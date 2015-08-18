using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_Array
{
    class SortingArray
    {
        /*
            Problem 9. Sorting array

            Write a method that return the maximal element in a portion
            of array of integers starting at given index.
            Using it write another method that sorts an array in ascending 
            / descending order.
         */
        static void Main()
        {
            Console.WriteLine("Enter elements of your array separated by space: ");
            int[] array=Array.ConvertAll(Console.ReadLine().Trim().Split(),int.Parse);
            Console.WriteLine("Sorted array is: ");
            Console.WriteLine(String.Join(", ",Sort(array)));
        }
        static int MaxNumber(int startIndex, int[] arr)
        {
            int max = startIndex;
            int finalMax = startIndex;
            for (int i = startIndex; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    max = i;
                    if (arr[max] > arr[finalMax])
                    {
                        finalMax = max;
                    }
                }
                else
                {
                    max = i + 1;
                    if (arr[max] > arr[finalMax])
                    {
                        finalMax = max;
                    }
                }
            }
           
            return finalMax;
        }
        static int[] Sort(int[] arr)
        {
            int maxElement = 0;
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                maxElement = MaxNumber(i, arr);
                temp = arr[i];
                arr[i] = arr[maxElement];
                arr[maxElement] = temp;
                maxElement = 0;
            }
            return arr;
        }
    }
}
