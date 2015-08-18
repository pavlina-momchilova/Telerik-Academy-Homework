using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fill_The_Matrix
{
    class FillTheMatrix
    {
        /*
            Problem 1. Fill the matrix

            Write a program that fills and prints a matrix of size (n, n)
            as shown below:
         */
        static void Main()
        {
            Console.Write("Enter Lenght of the matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            Console.WriteLine("a)");
            Console.WriteLine();
            int digit=1;
            int sum=0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col]=digit+sum;
                    sum = sum+n;
                }
                sum = 0;
                digit++;
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                    if (matrix[row, col] < 10)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("b)");
            Console.WriteLine();

            digit = 1;
            sum = 0;
            int up = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = digit + sum;
                    if (col % 2 == 0)
                    {
                        sum = sum + n + n - 1-up;
                    }
                    else
                    {
                        sum = sum+1+up;
                    }
                }
                sum = 0;
                digit++;
                up+=2;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                    if (matrix[row, col] < 10)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("c)");
            Console.WriteLine();
            
            int firstNumber=(((n*n)-n+1)/2)+1;
            int temp = n;
            int central = 0;
            int temp2=n-1;
            int left=n-central+1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == row)
                    {
                        matrix[row, col] = firstNumber;
                        firstNumber++;
                    }
                    if ( col>central)
                    {
                        matrix[row, col] = matrix[row, col - 1] + temp;
                        temp--;
                    }
                    if (col < central)
                    {
                        if (col == 0)
                        {
                            matrix[row, col] = matrix[row - 1, 0] - temp2;
                            temp2--;
                        }
                        else
                        {
                            matrix[row, col] = matrix[row, col - 1] + left;
                            left++;
                        }
                    }
                }
                
                central++;
                temp = n;
                left = n-central+1;
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                    if (matrix[row, col] < 10)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("d)");
            Console.WriteLine();

            int Row = n - 1;
            int Col = 1;

            int help = n - 1;

            for (int i = 0; i < n; i++)
            {
                matrix[i, 0] = i + 1;
            }
            int Digit = n + 1;
            while (help > 0)
            {
                int index = help;
                if (n % 2 == 0)
                {
                    if (help % 2 == 0)
                    {
                        for (int i = 0; i < index; i++)
                        {
                            matrix[Row, Col] = Digit;
                            Digit++;
                            Col--;
                        }
                        Row++;
                        Col++;
                        for (int i = 0; i < index; i++)
                        {
                            matrix[Row, Col] = Digit;
                            Digit++;
                            Row++;
                        }
                        Row--;
                        Col++;
                    }
                    else
                    {
                        for (int i = 0; i < index; i++)
                        {
                            matrix[Row, Col] = Digit;
                            Col++;
                            Digit++;
                        }
                        Row--;
                        Col--;
                        for (int i = 0; i < index; i++)
                        {
                            matrix[Row, Col] = Digit;
                            Digit++;
                            Row--;
                        }
                        Row++;
                        Col--;
                    }
                    help--;
                    index--;
                }
                else
                {
                    if (help % 2 != 0)
                    {
                        for (int i = 0; i < index; i++)
                        {
                            matrix[Row, Col] = Digit;
                            Digit++;
                            Col--;
                        }
                        Row++;
                        Col++;
                        for (int i = 0; i < index; i++)
                        {
                            matrix[Row, Col] = Digit;
                            Digit++;
                            Row++;
                        }
                        Row--;
                        Col++;
                    }
                    else
                    {
                        for (int i = 0; i < index; i++)
                        {
                            matrix[Row, Col] = Digit;
                            Col++;
                            Digit++;
                        }
                        Row--;
                        Col--;
                        for (int i = 0; i < index; i++)
                        {
                            matrix[Row, Col] = Digit;
                            Digit++;
                            Row--;
                        }
                        Row++;
                        Col--;
                    }
                    help--;
                    index--;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                    if (matrix[row, col] < 10)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
