namespace MethodPrintStatisticsInCSharp
{
    using System;

    public class Statistic
    {
        public void PrintStatistics(double[] numbers, int numberOfElements)
        {
            double max = double.MinValue, sum = 0, min = double.MaxValue;

            for (int i = 0; i < numberOfElements; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            PrintMax(max);

            for (int i = 0; i < numberOfElements; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            PrintMin(min);

            for (int i = 0; i < numberOfElements; i++)
            {
                sum += numbers[i];
            }

            double average = sum / numberOfElements;
            PrintAverage(average);
        }

        private void PrintAverage(double average)
        {
            Console.WriteLine(average);
        }

        private void PrintMin(double min)
        {
            Console.WriteLine(min);
        }

        private void PrintMax(double max)
        {
            Console.WriteLine(max);
        }
    }
}
