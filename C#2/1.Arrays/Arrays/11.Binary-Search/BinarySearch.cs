using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_Search
{
    class BinarySearch
    {
        /*
            Problem 11. Binary search

            Write a program that finds the index of given element in a sorted 
            array of integers by using the Binary search algorithm.
         */
        static void Main()
        {
            int[] arr = { 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int key = -1;

            int left = 0;
            int right = arr.Length - 1;
            int middle = 0;
            bool flag = false;
            while (left <= right)
            {
                middle = (left + right)/2;
                if (key == arr[middle])
                {
                    Console.WriteLine("The key is found on position {0}",middle);
                    flag = true;
                    break;
                }
                else if (key < arr[middle])
                {
                    right = middle-1;
                    left = 0;
                }
                else if (key > arr[middle])
                {
                    left = middle + 1;
                    right = arr.Length - 1;
                }

            }
            if (flag == false)
            {
                Console.WriteLine("The key is not found!");
            }
        }
    }
}
