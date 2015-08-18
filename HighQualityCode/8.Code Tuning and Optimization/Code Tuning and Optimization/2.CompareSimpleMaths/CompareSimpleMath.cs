namespace _2.CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public class CompareSimpleMath
    {
        public static void Main(string[] args)
        {
            int counter = 100000;
            int addTenInt = 0;
            int subtractTenInt = 0;
            int incrementInt = 0;
            int multiplyInt = 1;
            int divideInt = 10000;

            long addTenLong = 9223372036854775000;
            long subtractTenLong = 9223372036854775000;
            long incrementLong = 9223372036854775000;
            long multiplyLong = 922337203;
            long divideLong = 9223372036854775000;

            float addTenFloat = 10.5F;
            float subtractTenFloat = 10.5F;
            float incrementFloat = 10.5F;
            float multiplyFloat = 10.5F;
            float divideFloat = 10.5F;

            double addTenDouble = 10.556835654453;
            double subtractTenDouble = 10.52545315;
            double incrementDouble = 10.575465645;
            double multiplyDouble = 10.5456132;
            double divideDouble = 10.55644565;

            decimal addTenDecimal = 10.5555566M;
            decimal subtractTenDecimal = 10.52545315M;
            decimal incrementDecimal = 10.575465645M;
            decimal multiplyDecimal = 10.5456132M;
            decimal divideDecimal = 10.55644565M;

            // integers
            Console.WriteLine("---------------Integers------------");
            Console.WriteLine("- adding ten integers:");
            Stopwatch swatAddInt = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    addTenInt += i;
                }
            }

            swatAddInt.Stop();
            Console.WriteLine(swatAddInt.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- subtracting ten integers:");
            Stopwatch swatSubtractInt = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    subtractTenInt -= i;
                }
            }

            swatSubtractInt.Stop();
            Console.WriteLine(swatSubtractInt.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- incrementing ten times:");
            Stopwatch swatIncrementInt = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    incrementInt++;
                }
            }

            swatIncrementInt.Stop();
            Console.WriteLine(swatIncrementInt.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- multiplying ten integers:");
            Stopwatch swatMultiplyInt = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    multiplyInt *= i;
                }
            }

            swatMultiplyInt.Stop();
            Console.WriteLine(swatMultiplyInt.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- dividing ten integers:");
            Stopwatch swatDevideInt = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 1; i < 10; i++)
                {
                    divideInt /= 2;
                }
            }

            swatDevideInt.Stop();
            Console.WriteLine(swatDevideInt.Elapsed);
            Console.WriteLine();

            // Long
            Console.WriteLine("---------------Long------------");
            Console.WriteLine("- adding ten Long nums:");
            Stopwatch swatAddLong = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    addTenLong += i;
                }
            }

            swatAddLong.Stop();
            Console.WriteLine(swatAddLong.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- subtracting ten Long nums:");
            Stopwatch swatSubtractLong = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    subtractTenLong -= i;
                }
            }

            swatSubtractLong.Stop();
            Console.WriteLine(swatSubtractLong.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- incrementing ten times:");
            Stopwatch swatIncrementLong = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    incrementLong++;
                }
            }

            swatIncrementLong.Stop();
            Console.WriteLine(swatIncrementLong.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- multiplying ten Long nums:");
            Stopwatch swatMultiplyLong = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    multiplyLong *= i;
                }
            }

            swatMultiplyInt.Stop();
            Console.WriteLine(swatMultiplyInt.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- dividing ten Long nums:");
            Stopwatch swatDevideLong = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 1; i < 10; i++)
                {
                    divideLong /= 2;
                }
            }

            swatDevideLong.Stop();
            Console.WriteLine(swatDevideLong.Elapsed);
            Console.WriteLine();

            // Floats
            Console.WriteLine("---------------Floats------------");
            Console.WriteLine("- adding ten Float nums:");
            Stopwatch swatAddFloat = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    addTenFloat += i;
                }
            }

            swatAddFloat.Stop();
            Console.WriteLine(swatAddFloat.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- subtracting ten Float nums:");
            Stopwatch swatSubtractFloat = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    subtractTenFloat -= i;
                }
            }

            swatSubtractFloat.Stop();
            Console.WriteLine(swatSubtractFloat.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- incrementing ten times:");
            Stopwatch swatIncrementFloat = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    incrementFloat++;
                }
            }

            swatIncrementFloat.Stop();
            Console.WriteLine(swatIncrementFloat.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- multiplying ten Float nums:");
            Stopwatch swatMultiplyFloat = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    multiplyFloat *= i;
                }
            }

            swatMultiplyFloat.Stop();
            Console.WriteLine(swatMultiplyFloat.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- dividing ten Float nums:");
            Stopwatch swatDevideFloat = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 1; i < 10; i++)
                {
                    divideFloat /= 0.5F;
                }
            }

            swatDevideFloat.Stop();
            Console.WriteLine(swatDevideFloat.Elapsed);
            Console.WriteLine();

            // Double
            Console.WriteLine("---------------Doubles------------");
            Console.WriteLine("- adding ten Double nums:");
            Stopwatch swatAddDouble = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    addTenDouble += i;
                }
            }

            swatAddDouble.Stop();
            Console.WriteLine(swatAddDouble.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- subtracting ten Double nums:");
            Stopwatch swatSubtractDouble = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    subtractTenDouble -= i;
                }
            }

            swatSubtractDouble.Stop();
            Console.WriteLine(swatSubtractDouble.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- incrementing ten times:");
            Stopwatch swatIncrementDouble = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    incrementDouble++;
                }
            }

            swatIncrementDouble.Stop();
            Console.WriteLine(swatIncrementDouble.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- multiplying ten Double nums:");
            Stopwatch swatMultiplyDouble = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    multiplyDouble *= i;
                }
            }

            swatMultiplyDouble.Stop();
            Console.WriteLine(swatMultiplyDouble.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- dividing ten Double nums:");
            Stopwatch swatDevideDouble = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 1; i < 10; i++)
                {
                    divideDouble /= 0.5F;
                }
            }

            swatDevideDouble.Stop();
            Console.WriteLine(swatDevideDouble.Elapsed);
            Console.WriteLine();

            // Decimal
            Console.WriteLine("---------------Decimal------------");
            Console.WriteLine("- adding ten Decimal nums:");
            Stopwatch swatAddDecimal = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    addTenDecimal += i;
                }
            }

            swatAddDecimal.Stop();
            Console.WriteLine(swatAddDecimal.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- subtracting ten Decimal nums:");
            Stopwatch swatSubtractDecimal = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    subtractTenDecimal -= i;
                }
            }

            swatSubtractDecimal.Stop();
            Console.WriteLine(swatSubtractDecimal.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- incrementing ten times:");
            Stopwatch swatIncrementDecimal = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    incrementDecimal++;
                }
            }

            swatIncrementDecimal.Stop();
            Console.WriteLine(swatIncrementDecimal.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- multiplying ten Decimal nums:");
            Stopwatch swatMultiplyDecimal = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 0; i < 10; i++)
                {
                    multiplyDecimal *= i;
                }
            }

            swatMultiplyDecimal.Stop();
            Console.WriteLine(swatMultiplyDecimal.Elapsed);

            Console.WriteLine();
            Console.WriteLine("- dividing ten Decimal nums:");
            Stopwatch swatDevideDecimal = Stopwatch.StartNew();
            for (int times = 0; times < counter; times++)
            {
                for (int i = 1; i < 10; i++)
                {
                    divideDecimal /= 2;
                }
            }

            swatDevideDecimal.Stop();
            Console.WriteLine(swatDevideDecimal.Elapsed);
            Console.WriteLine();
        }
    }
}
