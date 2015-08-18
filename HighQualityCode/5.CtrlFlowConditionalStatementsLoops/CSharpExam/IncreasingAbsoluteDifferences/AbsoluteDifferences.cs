namespace IncreasingAbsoluteDifferences
{
    using System.Collections.Generic;

    public class AbsoluteDifferences
    {
        public static List<long> FindingAbsoluteDifference(List<long> list)
        {
            List<long> nums = new List<long>();

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    long number = list[i] - list[i + 1];
                    nums.Add(number);
                }
                else
                {
                    long number = list[i + 1] - list[i];
                    nums.Add(number);
                }
            }

            return nums;
        }

        public static bool IncreasingSequence(List<long> list)
        {
            bool increase = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (i > i + 1)
                {
                    increase = false;
                }
            }

            bool bigger = true;

            if (increase == true)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if ((list[i + 1] - list[i]) != 1 && (list[i + 1] - list[i]) != 0)
                    {
                        bigger = false;
                    }
                }
            }

            bool result = false;

            if (bigger == true && increase == true)
            {
                result = true;
            }

            return result;
        }
    }
}
