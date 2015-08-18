using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Spiral_Matrix
{
    class SpiralMatrix
    {
        /*
            Problem 19.** Spiral Matrix

            Write a program that reads from the console
            a positive integer number n (1 = n = 20) and prints
            a matrix holding the numbers from 1 to n*n in the
            form of square spiral like in the examples below.

         */
        static void Main(string[] args)
        {
            Console.Title = "Spiral Matrix";
            Console.WriteLine("Enter number between 1 and 20 = ");
            int n = int.Parse(Console.ReadLine());
            int[,] spiral=new int [n,n];
            int right=n-1;
            int down=n-1;
            int left=0;
            int up=0;
            int i=1;
            int row=0;
            int col=0;
            while (i <= n * n)
            {
                while (col <= right)
                {
                    if (spiral[row, col] == 0)
                    {
                        spiral[row, col] = i;
                        col++;
                        i++;
                    }
                    else
                    {
                        col++;
                    }
                }
                col--;
                while (row <= down)
                {
                    if (spiral[row, col] == 0)
                    {
                        spiral[row, col] = i;
                        row++;
                        i++;
                    }
                    else
                    {
                        row++;
                    }
                }
                row--;
                while (col >= left)
                {
                    if (spiral[row, col] == 0)
                    {
                        spiral[row, col] = i;
                        col--;
                        i++;
                    }
                    else
                    {
                        col--;
                    }
                }
                col++;
                while (row >= up)
                {
                    if (spiral[row, col] == 0)
                    {
                        spiral[row, col] = i;
                        row--;
                        i++;
                    }
                    else
                    {
                        row--;
                    }
                }
                row++;
                row++;
                col++;
                right--;
                down--;
                left++;
                up++;
            }
            for (int l = 0; l < n; l++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (spiral[l, j] <= 9)
                    {
                        Console.Write(spiral[l, j] + "   ");
                    }
                    else if (spiral[l, j] >= 9 && spiral[l, j] <= 99)
                    {
                        Console.Write(spiral[l, j] + "  ");
                    }
                    else
                    {
                        Console.Write(spiral[l, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
