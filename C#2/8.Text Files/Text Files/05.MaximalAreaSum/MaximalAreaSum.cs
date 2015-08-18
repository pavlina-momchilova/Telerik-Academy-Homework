using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaximalAreaSum
{
    class MaximalAreaSum
    {
        /*
         Problem 5. Maximal area sum

Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
         */
        static void Main()
        {
            StreamReader matrix = new StreamReader(@"..\..\..\05matrix.txt");
            StreamWriter area2x2 = new StreamWriter(@"..\..\..\05Result.txt");
            using (matrix)
            {
                using (area2x2)
                {
                 int size=Convert.ToInt32(matrix.ReadLine());
                 int[,] arr = new int[size,size];
                 string line=matrix.ReadLine();
                 int index = 0;
                 int i=0;
                 int sum = 0;
                 int maxSum = 0;
                 while (line != null)
                 {
                     for (int j = 0; j < size; j++)
                     {
                         arr[i, j] = int.Parse(line[index].ToString());
                         index += 2;
                     }
                     index = 0;
                     i++;
                     line = matrix.ReadLine();
                 }
                 for (int j = 0; j < arr.GetLength(0)-1; j++)
                 {
                     for (int k = 0; k < arr.GetLength(1)-1; k++)
                     {
                         sum = arr[j, k] + arr[j, k + 1] + arr[j + 1, k] + arr[j + 1, k + 1];
                         if (sum > maxSum)
                         {
                             maxSum = sum;
                         }
                     }
                 }
                 area2x2.Write("Result: "+maxSum);
                }
            }
        }
    }
}
