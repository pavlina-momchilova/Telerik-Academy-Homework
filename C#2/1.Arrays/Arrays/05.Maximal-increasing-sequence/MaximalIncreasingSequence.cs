using System;

class MaximalIncreasingSequence
{
    /*
        Problem 5. Maximal increasing sequence

        Write a program that finds the maximal increasing sequence
        in an array.
     */
    static void Main()
    {
        int[] array = { 3, 2, 3, 4, 2, 2, 4 };
        int count = 0;
        int lastCount = 0;
        string numbers = "";
        string lastNumber = "";
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] < array[i + 1])
            {
                if (lastCount == 0)
                {
                    lastNumber += array[i];
                }
                lastCount++;
                lastNumber += ", ";
                lastNumber += array[i+1];
            }
            else
            {
                lastCount = 0;
                lastNumber = "";
            }
            if (lastCount > count)
            {
                count = lastCount;
                numbers = lastNumber;
            }
        }
        Console.WriteLine(numbers);

    }
}

