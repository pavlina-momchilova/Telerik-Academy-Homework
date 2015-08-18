using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_Calculations
{
    class IntegerCalculations
    {
        /*
            Problem 14. Integer calculations

            Write methods to calculate minimum, maximum, average,
            sum and product of given set of integer numbers.
            Use variable number of arguments.
         */
        static void Main()
        {
            Console.WriteLine("Enter elements of the array separated by space: ");
            decimal[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(), decimal.Parse);
            Console.WriteLine("Min = "+Minimum(array));
            Console.WriteLine("Max = "+Maximum(array));
            Console.WriteLine("Average = "+Average(array));
            Console.WriteLine("Sum = "+Sum(array));
            Console.WriteLine("Product = "+Product(array));
        }

        static decimal Minimum(params decimal[] numbers)
        {
            decimal min = numbers[0];
            decimal finalMin = numbers[0];
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    min = numbers[i];
                    if (min < finalMin)
                    {
                        finalMin = min;
                    }
                }
                else
                {
                    min = numbers[i+1];
                    if (min < finalMin)
                    {
                        finalMin = min;
                    } 
                }
            }
            return finalMin;
        }
        static decimal Maximum(params decimal[] numbers)
        {
            decimal max = numbers[0];
            decimal finalMax = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    max = numbers[i];
                    if (max > finalMax)
                    {
                        finalMax = max;
                    }
                }
                else
                {
                    max = numbers[i+1];
                    if (max > finalMax)
                    {
                        finalMax = max;
                    }
                }
            }
            return finalMax;
        }
        static decimal Average(params decimal[] numbers)
        {
            decimal sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum/numbers.Length;
        }
        static decimal Sum(params decimal[] numbers)
        {
            decimal sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static decimal Product(params decimal[] numbers)
        {
            decimal product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }
    }
}
