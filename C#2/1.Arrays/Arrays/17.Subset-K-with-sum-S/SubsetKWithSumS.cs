using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Subset_K_with_sum_S
{
    class SubsetKWithSumS
    {
        /*
            Problem 17.* Subset K with sum S

            Write a program that reads three integer numbers N, K and S
            and an array of N elements from the console.
            Find in the array a subset of K elements that have sum S or indicate about its absence.
         */
        static void Main()
        {
            Console.Write("Enter how many elements you want to have your array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter how many elements you want to sum: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter the sum of the elements: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of the array: ");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            int sum = 0;
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    
                }
            }
           
        }
    }
}
