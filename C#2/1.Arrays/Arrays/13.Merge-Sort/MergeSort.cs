using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MergeSort
{
    /*
        Problem 13.* Merge sort

        Write a program that sorts an array of integers using the Merge sort algorithm.
     */
    static void MergeSortAlg(int[] array)
    {
        if (array.Length < 2)
        {
            return;
        }
        int middle = array.Length / 2;
        int[] Left = new int[middle];
        int[] right = new int[array.Length - middle];
        for (int i = 0; i < middle; i++)
        {
            Left[i] = array[i];
        }
        for (int i = middle; i < array.Length; i++)
        {
            right[i-middle] = array[i];    
        }
        MergeSortAlg(Left);
        MergeSortAlg(right);
        Merge(Left, right, array);
    }

    static void Merge(int[] Left, int[] right, int[] array)
    {
        int i = 0;
        int j = 0;
        int k = 0;
        while (i < Left.Length && j < right.Length)
        {
            if (Left[i] < right[j])
            {
                array[k] = Left[i];
                i++;
            }
            else
            {
                array[k] = right[j];
                j++;
            }
            k++;
        }
        while (i < Left.Length)
        {
            array[k] = Left[i];
            i++;
            k++;
        }
        while (j < right.Length)
        {
            array[k] = right[j];
            j++;
            k++;
        }
    }

    static void Main()
    {
        int[] arr = { 2, 4, 1, 6, 8, 5, 3, 7 };
        MergeSortAlg(arr);
        Console.Write("Sorted array is: ");
        for (int i = 0; i < arr.Length; i++)
        {

            Console.Write(arr[i]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

