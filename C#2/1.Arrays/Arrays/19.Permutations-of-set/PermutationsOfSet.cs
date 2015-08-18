using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Permutations_of_set
{
    class PermutationsOfSet
    {
        static void Main()
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
           
                Permutations(arr, new int[n], 0);

        }

        private static void Permutations(int[] nums, int[] arr, int index)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(", ", arr));
                return;
            }
            for (int i = index; i < nums.Length; i++)
            {
               
                    arr[index] = nums[i];
                    Permutations(nums, arr, index + 1);       
            }
        }
    }
}
