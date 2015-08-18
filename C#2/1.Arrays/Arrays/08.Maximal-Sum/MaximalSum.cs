using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    /*
        Problem 8. Maximal sum

        Write a program that finds the sequence of maximal sum in given array.
     */
    static void Main()
    {
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int sum = 0;
        int maxSum=0;
        int i = 0;
        int j = i ;
        string elements = "";
        string maxSumElements = "";
        while (i != array.Length-1)
        {
            sum+=array[j];
            elements += array[j];
            elements += ", "; 
            if (sum > maxSum)
            {
                maxSum = sum;
                maxSumElements = elements;
            }
            j++;
            if (j == array.Length - 1)
            {
                i++;
                j = i;
                sum = 0;
                elements = "";
            }
        }
        Console.WriteLine("The maximal sum is: "+maxSum);
        Console.WriteLine("The sequence of elements is: "+maxSumElements.Remove(maxSumElements.Length-2));
    }
}

