using System;
using System.Collections.Generic;
using System.Linq;

class MaximalKSum
{
    /*
        Problem 6. Maximal K sum

        Write a program that reads two integer numbers N and K and
        an array of N elements from the console.
        Find in the array those K elements that have maximal sum.
     */
    static void Main()
    {
        Console.Title = "Maximal K sum";

        Console.Write("Enter Lenght of the array: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter sum of how many numbers: ");
        int K = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the numbers of the array: ");
        int[] array = new int[N];
        List<int> numbers = new List<int>();
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            numbers.Add(array[i]);
        }
        int maxNumbers=0;
        int l = 0;
        int sum = 0;
        while (K > 0)
        {
            maxNumbers = numbers.Max();
                while (l < numbers.Count)
                {
                    if (numbers[l] == maxNumbers)
                    {
                        sum += numbers[l];
                        numbers.Remove(numbers[l]);
                        break;
                    }
                    l++;
                }
                l = 0;
            K--;
        }
        Console.WriteLine("The maximal sum of K elements in the array is: "+sum);
    }
}
