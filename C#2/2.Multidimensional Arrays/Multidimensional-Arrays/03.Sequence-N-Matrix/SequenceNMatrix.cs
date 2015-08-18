using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sequence_N_Matrix
{
    class SequenceNMatrix
    {
        /*
            Problem 3. Sequence n matrix

            We are given a matrix of strings of size N x M. 
            Sequences in the matrix we define as sets of several
            neighbour elements located on the same line, column or diagonal.
            Write a program that finds the longest sequence of equal strings
            in the matrix.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many Rows you want: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many Cols you want: ");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter text elements: ");

            string[,] matrix = new string[N, M];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
             for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }   
            }

           int count = 0;
            int longestSeq = 0;
            string result = "";
            string finalResult="";
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    bool areEqualLine = String.Equals(matrix[row, col], matrix[row, col + 1], StringComparison.Ordinal);
                    if (areEqualLine == true)
                    {
                        if (count == 0)
                        {
                            count=2;
                            result += matrix[row, col];
                            result += ", ";
                            result += matrix[row, col + 1];
                        }
                        else
                        {
                            count++;
                            result += ", ";
                            result += matrix[row, col];
                        }
                        if (count > longestSeq)
                        {
                            longestSeq = count;
                            finalResult = result;
                        }
                    }
                    else
                    {
                        count = 0;
                        result = "";
                    }
                  
                }
            }


            int Col = 0;
            int CountCol = 0;
            int MaxCount = 0;
            string resultCol = "";
            string finalResultCol = "";
            while (Col <= matrix.GetLength(1)-1)
            {
                for (int Row = 0; Row < matrix.GetLength(0) - 1; Row++)
                {
                    bool areEqualCol = String.Equals(matrix[Row, Col], matrix[Row + 1, Col], StringComparison.Ordinal);
                    if (areEqualCol == true)
                    {
                        if (CountCol == 0)
                        {
                            CountCol = 2;
                            resultCol += matrix[Row, Col];
                            resultCol += ", ";
                            resultCol += matrix[Row + 1, Col];
                        }
                        else
                        {
                            CountCol++;
                            resultCol += ", ";
                            resultCol += matrix[Row, Col];
                        }
                        if (CountCol > MaxCount)
                        {
                            MaxCount = CountCol;
                            finalResultCol = resultCol;
                        }
                    }
                    else
                    {
                        CountCol = 0;
                        resultCol = "";
                    }
                }
                Col++;
            }
            

            int CountD = 0;
            int MaxCountD = 0;
            string resultD = "";
            string FinResultD = "";
                for (int i = 0; i < matrix.GetLength(0)-1; i++)
                {
                    bool areEqualD = String.Equals(matrix[i, i], matrix[i + 1, i + 1], StringComparison.Ordinal);
                    if (areEqualD == true)
                    {
                        if (CountD == 0)
                        {
                            CountD = 2;
                            resultD += matrix[i, i];
                            resultD += ", ";
                            resultD += matrix[i + 1, i + 1];
                        }
                        else
                        {
                            CountD++;
                            resultD += ", ";
                            resultD += matrix[i, i];
                        }
                        if (CountD > MaxCountD)
                        {
                            MaxCountD = CountD;
                            FinResultD = resultD;
                        }
                    }
                    else
                    {
                        CountD = 0;
                        resultD = "";
                    }
                }
            int max=0;
                if (longestSeq > MaxCount)
                {
                    if (longestSeq > MaxCountD)
                    {
                        max = longestSeq;
                        Console.WriteLine(finalResult);
                    }
                    else
                    {
                        max = MaxCountD;
                        Console.WriteLine(FinResultD);
                    }
                }
                else
                {
                    if (MaxCount > MaxCountD)
                    {
                        max = MaxCount;
                        Console.WriteLine(finalResultCol);
                    }
                    else
                    {
                        max = MaxCountD;
                        Console.WriteLine(FinResultD);
                    }
                }
        }

    }
}
