using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Prime_Numbers
{
       
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you enter a big number you must take your time!");
            Console.WriteLine("Enter how many numbers you want to check: ");
            int n = int.Parse(Console.ReadLine());
            bool[] arr = new bool[n-2];
            int sqrt = (int)Math.Sqrt(arr.Length);
            for (int p = 2; p <sqrt; p++)
            {
                for (int j = 2; j < arr.Length; j++)
                {
                    if (arr[p])
                    {
                        break;
                    }
                    if (j % p == 0 && j != p)
                    {
                        arr[j]=true;
                    }
                    
                }
            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i]==false)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
