using System;

class Program
{
    /*
        Problem 4. Maximal sequence

        Write a program that finds the maximal
        sequence of equal elements in an array.
     */
    static void Main()
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int count = 0;
        int lastCount = 0;
        int number = 0;
        int lastNumber = 0;

        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] == array[i + 1])
            {
                if (lastCount == 1)
                {
                    lastCount += 2;
                }
                else
                {
                    lastCount++;
                }
                lastNumber = array[i];
            }
            else
            {
                lastCount=0;
                lastNumber = 0;
            }
            if (lastCount > count)
            {
                count = lastCount;
                number = lastNumber;
            }
        }
        for (int i = 0; i < count; i++)
        {
            if (i == 0)
            {
                Console.Write("{");
            }
            Console.Write(number);
            if (i != count - 1)
            {
                Console.Write(",");
            }
            if (i == count - 1)
            {
                Console.Write("}");
                Console.WriteLine();
            }
        }
    }
}

