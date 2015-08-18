namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    public class CompareAdvancedMaths
    {
        public static void Main(string[] args)
        {
            int counter = 1000000;
            float numFloat = 26.5F;
            double numDouble = 26.5;
            decimal numDecimal = 26.5M;

            // square root
            Console.WriteLine("---------------Square root------------");
            Stopwatch sqrtFloatSw = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    numFloat = (float)Math.Sqrt(numFloat);
                }
            }

            sqrtFloatSw.Stop();
            Console.WriteLine("float - " + sqrtFloatSw.Elapsed);
            numFloat = 26.5F;

            Stopwatch sqrtDoubleSw = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    numDouble = Math.Sqrt(numDouble);
                }
            }

            numDouble = 26.5;
            sqrtDoubleSw.Stop();
            Console.WriteLine("double - " + sqrtDoubleSw.Elapsed);

            Stopwatch sqrtDecimalSw = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    numDecimal = (decimal)Math.Sqrt((double)numDecimal);
                }
            }

            sqrtDecimalSw.Stop();
            Console.WriteLine("decimal - " + sqrtDecimalSw.Elapsed);
            Console.WriteLine();
            numDecimal = 26.5M;

            // natural logarithm
            Console.WriteLine("---------------natural logarithm------------");
            Stopwatch nlogFloatSw = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    numFloat = (float)Math.Log(numFloat);
                }
            }

            nlogFloatSw.Stop();
            Console.WriteLine("float - " + nlogFloatSw.Elapsed);
            numFloat = 26.5F;

            Stopwatch nlogDoubleSw = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    numDouble = Math.Log(numDouble);
                }
            }

            nlogDoubleSw.Stop();
            Console.WriteLine("double - " + nlogDoubleSw.Elapsed);
            numDouble = 26.5;

            Stopwatch nlogDecimalSw = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 3; i++)
                {
                    numDecimal = (decimal)Math.Log((double)numDecimal);
                }

                numDecimal = 26.5M;
            }

            nlogDecimalSw.Stop();
            Console.WriteLine("decimal - " + nlogDecimalSw.Elapsed);
            Console.WriteLine();
            numDecimal = 26.5M;

            // sinus
            Console.WriteLine("---------------sinus------------");
            Stopwatch sinFloatSw = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    numFloat = (float)Math.Sin(numFloat);
                }
            }

            sinFloatSw.Stop();
            Console.WriteLine("float - " + sinFloatSw.Elapsed);

            Stopwatch sinDoubleSw = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    numDouble = Math.Sin(numDouble);
                }
            }

            sinDoubleSw.Stop();
            Console.WriteLine("double - " + sqrtDoubleSw.Elapsed);
            numDouble = 26.5;

            Stopwatch sinDecimalSw = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    numDecimal = (decimal)Math.Sin((double)numDecimal);
                }
            }

            sinDecimalSw.Stop();
            Console.WriteLine("decimal - " + sinDecimalSw.Elapsed);
        }
    }
}
