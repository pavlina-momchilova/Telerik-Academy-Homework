using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class QuickSort
{
    /*
        Problem 14. Quick sort

        Write a program that sorts an array of strings
        using the Quick sort algorithm.
     */
    static int partitition(int[] arr, int startIndex, int endIndex)
    {
        int pivot = arr[endIndex];
        int index = startIndex;
        int swap = 0;
        for (int i = startIndex; i < endIndex; i++)
        {
            if (arr[i] <= pivot)
            {
                swap = arr[i];
                arr[i]=arr[index];
                arr[index] = swap;
                index++;
            }
        }
        swap = arr[index];
        arr[index] = arr[endIndex];
        arr[endIndex] = swap;
        return index;
    }

    static void QuckSort(int[] arr, int startIndex, int endIndex)
    {
        int index = 0;
        if (startIndex < endIndex)
        {
            index = partitition(arr, startIndex, endIndex);
            QuckSort(arr, startIndex, index - 1);
            QuckSort(arr, index + 1, endIndex);
        }
    }
    static void Main(string[] args)
    {
        int[] arr = { 5, 3, 36, 4, 556, 6, 41, 2, 11, 2, 11 };
        QuckSort(arr, 0, arr.Length-1);
        Console.WriteLine(string.Join(", ", arr));
    }
}
