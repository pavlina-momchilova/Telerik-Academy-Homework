using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSumInArray
{
    class FindSumInArray
    {
        /*
            Problem 10. Find sum in array

            Write a program that finds in given array of integers a
            sequence of given sum S (if present).
         */
        static void Main()
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            int s = 11;
            int i = 0;
            int j = i;
            int sum = 0;
            string numbers = "";
            while (i < array.Length)
            {
                sum += array[j];
                numbers += array[j];
                numbers += ", ";
                if (sum == s)
                {
                    Console.WriteLine(numbers.Remove(numbers.Length-2));
                }
                else
                {
                    if (j == array.Length - 1)
                    {
                        i++;
                        j = i;
                        sum = 0;
                        numbers = "";
                    }
                    else
                    {
                        j++;
                    }
                }
               
            }
        }
    }
}
