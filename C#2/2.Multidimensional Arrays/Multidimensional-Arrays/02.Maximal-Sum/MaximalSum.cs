using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maximal_Sum
{
    class MaximalSum
    {
        /*
            Problem 2. Maximal sum

            Write a program that reads a rectangular matrix of size N x M and
            finds in it
            the square 3 x 3 that has maximal sum of its elements.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many Rows you want: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many Cols you want: ");
            int M = int.Parse(Console.ReadLine());

            int[,] rectangularMatrix = new int[N, M];

            Console.WriteLine("Please enter elements of the array:");
            for (int i = 0; i < rectangularMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < rectangularMatrix.GetLength(1); j++)
                    {
                        rectangularMatrix[i,j]=int.Parse(Console.ReadLine());
                    }
                }

            int sum=0;
            int maximalSum=0;

            if (N >= 3 && M >= 3)
            {

                for (int row = 0; row < rectangularMatrix.GetLength(0)-2; row++)
                {
                    for (int col = 0; col < rectangularMatrix.GetLength(1)-2; col++)
                    {
                        sum = rectangularMatrix[row, col] + rectangularMatrix[row, col + 1] + rectangularMatrix[row, col + 2] + rectangularMatrix[row + 1, col] + rectangularMatrix[row + 1, col + 1] + rectangularMatrix[row + 1, col + 2]+
                           rectangularMatrix[row + 2, col] + rectangularMatrix[row + 2, col + 1] + rectangularMatrix[row + 2, col+2];
                        if (sum > maximalSum)
                        {
                            maximalSum = sum;
                        }
                    }
                    sum = 0;
                }

                Console.WriteLine("The max sum of 3x3 elements is: "+maximalSum);
            }
            else
            {
                Console.WriteLine("The matrix is too small!");
            }

        }
    }
}
