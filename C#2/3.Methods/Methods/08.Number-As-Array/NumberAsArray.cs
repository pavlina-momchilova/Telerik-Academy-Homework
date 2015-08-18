using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.Number_As_Array
{
    class NumberAsArray
    {
        /*
            Problem 8. Number as array

            Write a method that adds two positive integer numbers
            represented as arrays of digits (each array element arr[i]
            contains a digit; the last digit is kept in arr[0]).
            Each of the numbers that will be added could have up to 10 000
            digits.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first positive integer number:");
            string firstNum = Console.ReadLine();
            Console.WriteLine("Enter second positive integer number:");
            string secondNum = Console.ReadLine();

            if (firstNum.Length > secondNum.Length)
            {
                secondNum=secondNum.PadLeft(firstNum.Length,'0');
            }
            else if(firstNum.Length < secondNum.Length)
            {
                firstNum = firstNum.PadLeft(secondNum.Length, '0');
            }
            int[] firstArr=ReverseNum(firstNum);
            int[] secondArr=ReverseNum(secondNum);
            Console.WriteLine("Result is: ");
            Console.WriteLine(String.Join("",AddNumbers(firstArr,secondArr)));
            
        }
        
        static int[] AddNumbers(int[] arr1,int[] arr2)
        {
            int ost = 0;
            List<int> Add = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (ost == 0)
                {
                    if ((arr1[i] + arr2[i]) <= 9)
                    {
                        Add.Add(arr1[i] + arr2[i]);
                    }
                    else
                    {
                        if (i == arr2.Length - 1)
                        {
                            Add.Add((arr1[i] + arr2[i]) % 10);
                            Add.Add((arr1[i] + arr2[i]) / 10);
                        }
                        else
                        {
                            Add.Add((arr1[i] + arr2[i]) % 10);
                            ost = 1;
                        }
                       
                    }
                }
                else
                {
                    if ((arr1[i] + arr2[i]+1) <= 9)
                    {
                        Add.Add(arr1[i] + arr2[i]+1);
                        ost = 0;
                    }
                    else
                    {
                        if (i == arr1.Length - 1)
                        {
                            Add.Add((arr1[i] + arr2[i] + 1) % 10);
                            Add.Add((arr1[i] + arr2[i] + 1) / 10);
                        }
                        else
                        {
                            Add.Add((arr1[i] + arr2[i] + 1) % 10);
                            ost = 1;
                        }
                    }
                }
            }
            Add.Reverse();
            return Add.ToArray();
        }
        static int[] ReverseNum(string number)
        {
            int[] arr = new int[number.Length];
            for (int i = 0; i <number.Length ; i++)
            {
                arr[i] = (char)number[number.Length - 1 - i]-'0';
            }
            return arr;
        }
    }
}
