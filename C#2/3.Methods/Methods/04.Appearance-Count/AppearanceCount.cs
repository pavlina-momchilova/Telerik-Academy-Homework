using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_Count
{
    class AppearanceCount
    {
        /*
            Problem 4. Appearance count

            Write a method that counts how many times given number appears in given array.
            Write a test program to check if the method is workings correctly.
         */
        static int Appearance(int[] arr, int number)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int index = 0;
            Console.Write("Enter Length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter elements of teh array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("arr[{0}] = ",index);
                array[i] = int.Parse(Console.ReadLine());
                index++;
            }
            Console.Write("Enter a number: ");
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine( "The number appears: {0}  times",Appearance(array, number) ); 
        }
    }
}
