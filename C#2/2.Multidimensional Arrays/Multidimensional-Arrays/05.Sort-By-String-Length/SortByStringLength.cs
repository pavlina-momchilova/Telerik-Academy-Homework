using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_By_String_Length
{
    class SortByStringLength
    {
        /*
            Problem 5. Sort by string length

            You are given an array of strings. Write a method that sorts the
            array by the length of its elements (the number of characters composing them).
         */
        static void Main(string[] args)
        {
            Console.Write("Enter how many elements you want to have your array: ");
            int N = int.Parse(Console.ReadLine());
            string[] array = new string[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = Console.ReadLine();
            }
            SortStrings(array);

        }
        static void SortStrings(string[] arr)
        {
            List<string> unsortedList = new List<string>();
            List<string> sortedList = new List<string>();
            string min = "";
            string finalMin = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                unsortedList.Add(arr[i]);
            }
            int j = 0;
            while (j < arr.Length-1)
            {
                for (int i = 0; i < unsortedList.Count-1; i++)
                {
                    if (unsortedList[i].Length < unsortedList[i + 1].Length)
                    {
                        min = unsortedList[i];
                        if (finalMin.Length > min.Length)
                        {
                            finalMin = min;
                        }
                    }
                    else
                    {
                        min = unsortedList[i+1];
                        if (finalMin.Length > min.Length)
                        {
                            finalMin = min;
                        }
                    }
                }
                sortedList.Add(finalMin);
                unsortedList.Remove(finalMin);
                min = "";
                finalMin = unsortedList[0];
                j++;
            }
            sortedList.Add(unsortedList[0]);    
            
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.Write(sortedList[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
