using System;
using System.Linq;
using System.Diagnostics;

class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {

        Debug.Assert(arr.Length > 0, "Array cannot be empty!");

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr.Length > 0, "Array cannot be empty!");
        Debug.Assert(startIndex <= arr.Length - 1, "start index must be smaller or equal to array's length!");
        Debug.Assert(startIndex >= 0, "start index must be greater than or equal to 0!");
        Debug.Assert(startIndex <= endIndex, "start index must be smaller than or equal to endIndex!");
        Debug.Assert(endIndex <= arr.Length - 1, "end index must be smaller or equal to array's length!");
        Debug.Assert(endIndex >= 0, "end index must be greater than or equal to 0!");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        Debug.Assert(minElementIndex != null, "min element index cannot be null!");
        Debug.Assert(minElementIndex >= 0, "min element index cannot be less than 0!");
        Debug.Assert(minElementIndex <= arr.Length - 1, "min element index cannot be more than array's length!");

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr.Length > 0, "Array cannot be empty!");
        Debug.Assert(value != null, "Value cannot be null!");

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr.Length > 0, "Array cannot be empty!");
        Debug.Assert(startIndex <= arr.Length - 1, "start index must be smaller or equal to array's length!");
        Debug.Assert(startIndex >= 0, "start index must be greater than or equal to 0!");
        Debug.Assert(startIndex <= endIndex, "start index must be smaller than or equal to endIndex!");
        Debug.Assert(endIndex <= arr.Length - 1, "end index must be smaller or equal to array's length!");
        Debug.Assert(endIndex >= 0, "end index must be greater than or equal to 0!");
        Debug.Assert(value != null, "Value cannot be null!");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}