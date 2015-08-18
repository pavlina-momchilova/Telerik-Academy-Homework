namespace IncreasingAbsoluteDifferences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindingAbsoluteDiffrences
    {
        public static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<long> nums1 = new List<long>();
            List<string> nums2 = new List<string>();
            List<long> nums = new List<long>();
            List<bool> result = new List<bool>();

            while (t > 0)
            {
                string seq = Console.ReadLine();
                nums2 = seq.Split(' ').ToList();

                for (int i = 0; i < nums2.Count; i++)
                {
                    nums.Add(Convert.ToInt64(nums2[i]));
                }

                nums1 = AbsoluteDifferences.FindingAbsoluteDifference(nums);
                result.Add(AbsoluteDifferences.IncreasingSequence(nums1));
                nums1.RemoveRange(0, nums1.Count);
                nums.RemoveRange(0, nums.Count);
                t--;
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
