using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.N_Factorial_Second_Solution
{
    class NFactorialSecondSolution
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> mult = new List<int>();
            while (n > 0)
            {
                int[] arr1 = NumberAsArr(n);
                n--;
                int[] arr2 = NumberAsArr(n);
                int[] finalArr = Multiplication(arr1, arr2);
                n--;
            }
            Console.WriteLine(String.Join("0",finalArr));
        }
        static int[] NumberAsArr(int number)
        {
            string numberAsStr = number.ToString();
            int[] arr1 = new int[numberAsStr.Length];
            for (int i = 0; i < numberAsStr.Length; i++)
            {
                arr1[i] = (char)numberAsStr[i]-'0';
            }
            return arr1;
        }
        static int[] Reverse(int[] array)
        {
            int[] arrReverse = new int[array.Length];
            int j = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                arrReverse[i] = array[j];
                j--;
            }
            return arrReverse;
        }
        static int[] Multiplication(int[] arr1, int[] arr2)
        {
            arr1 = Reverse(arr1);
            arr2 = Reverse(arr2);
            int[] multiplication = new int[arr1.Length + arr2.Length - 1];
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    multiplication[i + j] += arr1[i] * arr2[j];
                }

            }

            multiplication = Reverse(multiplication);
            return multiplication;
        }
    }
}
