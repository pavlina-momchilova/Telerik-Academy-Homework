using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Min__Max__Sum_and_Average_of_N_Numbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        /*
            Problem 3. Min, Max, Sum and Average of N Numbers

            Write a program that reads from the console a sequence
            of n integer numbers and returns the minimal, the maximal
            number, the sum and the average of all numbers (displayed
            with 2 digits after the decimal point).
            The input starts by the number n (alone in a line)
            followed by n lines, each holding an integer number.
            The output is like in the examples below.
         */
        static void Main()
        {
            Console.Title = "Min, Max, Sum and Average of N Numbers";
            Console.WriteLine("Enter how many number you want: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers: ");
            int[] numbers=new int[n];
            while (n > 0)
            {
                int a = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = a;             
                }
                n--; 
            }
            int min = numbers[0];
            int max = 0;
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                sum += numbers[i];
            }
            avg = (double)sum / (double)(numbers.Length);
            Console.WriteLine("min={0} max={1} sum={2} avg={3:0.00}",min,max,sum,avg);
        }
    }
}
