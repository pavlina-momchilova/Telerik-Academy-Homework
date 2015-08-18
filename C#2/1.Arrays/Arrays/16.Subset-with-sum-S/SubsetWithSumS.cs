using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Subset_with_sum_S
{
    class SubsetWithSumS
    {
        /*
            Problem 16.* Subset with sum S

            We are given an array of integers and a number S.
            Write a program to find if there exists a subset of
            the elements of the array that has a sum S.
         */
        static void Main()
        {
            Console.Write("Enter how elements would have the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Insert the sum that you looking for: ");
            int S = int.Parse(Console.ReadLine());
            int sum = 0;
            int index=0;
            bool result = false;
            while (index<array.Length)
            {
                int max = array.Max();
                sum += max;
                if (sum <= S)
                {
                    if (sum == S)
                    {
                        result = true;
                        break;
                    }
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == max)
                        {
                            array[i] = 0;
                        }
                    }
                }
                else
                {
                    sum -= max;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == max)
                        {
                            array[i] = 0;
                        }
                    }
                }
                index++;
            }
            if (result == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
