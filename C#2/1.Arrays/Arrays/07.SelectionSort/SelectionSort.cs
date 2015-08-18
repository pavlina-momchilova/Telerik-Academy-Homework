using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SelectionSort
{
    /*
        Problem 7. Selection sort

        Sorting an array means to arrange its elements in increasing order.
        Write a program to sort an array.
        Use the Selection sort algorithm: Find the smallest element,
        move it at the first position,
        find the smallest from the rest, move it at the second position, etc.
     */
    static void Main()
    {
        int[] array = {5,4,3,2,9,1,6,9,7,2,8};
        int n=0;
        while (n < array.Length-1)
        {
            int min = array[n];
            int LastMin = array[n];
            for (int j = n; j < array.Length-1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    LastMin = array[j + 1];
                    if (LastMin < min)
                    {
                        min = LastMin;
                    }
                }
            }
            int temp = array[n];
            for (int l = n; l < array.Length; l++)
            {
                if (array[l] == min)
                {
                    array[l] = temp;
                    break;
                }
            }
            array[n] = min;
            n++;
        }



            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
    }
}
