using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BinarySearch
{
    class BinarySearch
    {
        /*
            Problem 4. Binary search

            Write a program, that reads from the console an array
            of N integers and an integer K, sorts the array
            and using the method Array.BinSearch() finds the 
            largest number in the array which is ≤ K.
         */
        static void Main(string[] args)
        {
            Console.Write("How many elements would have your array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
               
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());
          
            Array.Sort(arr);
            if (k < arr[0])
            {
                Console.WriteLine("There is no such number");
            }
            else
            {
                int indexOfK = Array.BinarySearch(arr, k);
                if (indexOfK >= 0 && indexOfK < arr.Length)
                {
                    Console.WriteLine("The largest number in the array which is <=k is: " + k);
                }
                else
                {
                    indexOfK = indexOfK * (-1) - 1;
                    if (indexOfK > arr.Length)
                    {
                        Console.WriteLine("The largest number in the array which is <=k is: " + arr[arr.Length - 1]);
                    }
                    else
                    {
                        Console.WriteLine("The largest number in the array which is <=k is: " + arr[indexOfK - 1]);
                    }

                }
            }
            
        }
    }
}
