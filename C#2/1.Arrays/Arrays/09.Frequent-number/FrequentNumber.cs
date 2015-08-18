using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FrequentNumber
{
    /*
        Problem 9. Frequent number

        Write a program that finds the most frequent number in an array.
     */
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        List<int> numbers = new List<int>();
        int number = 0;
        int FrequentNumber = 0;
        string MoreFrequentNumber = "";
        int count = 0;
        int maxCount=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (numbers.Contains(array[i]) == false)
            {
                numbers.Add(array[i]);
                number = array[i];
                for (int j = 0; j < array.Length; j++)
                {
                    if (number == array[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    FrequentNumber= number;
                }
                else if (count == maxCount)
                {
                    MoreFrequentNumber += number;
                }
                count = 0;
            }
        }
        Console.Write("{0}",FrequentNumber);
        if (MoreFrequentNumber != "")
        {
            Console.Write(",");
            Console.Write(" {0}({1} times)", MoreFrequentNumber, maxCount);
            Console.WriteLine();
        }
        else
        {
            Console.Write("({0} times)",maxCount);
            Console.WriteLine();
        }
    }
}

