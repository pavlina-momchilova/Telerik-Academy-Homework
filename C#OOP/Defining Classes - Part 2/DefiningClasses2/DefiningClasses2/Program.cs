using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> newList = new GenericList<int>(3);
            Console.WriteLine("Capacity before adding an elements: ");
            Console.WriteLine(newList.Capacity);

            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Add(4);
            newList.Add(5);
            newList.Add(6);
            newList.Add(7);
            Console.WriteLine("The list after Adding elements from 1 to 7:");
            Console.WriteLine(newList);
            Console.WriteLine("Capacity after adding an elements: ");
            Console.WriteLine(newList.Capacity);

            newList.Insert(7, 8);
            newList.Insert(8, 9);
            newList.Insert(9, 10);
            newList.Insert(10, 11);
            newList.Insert(11, 12);
            Console.WriteLine("The list after Insert elements from 8 to 12 at positions from 7 to 11:");
            Console.WriteLine(newList);
            newList.RemoveAt(2);
            newList.RemoveAt(4);
            Console.WriteLine("The list after Remove elements in positions 2 and 4:");
            Console.WriteLine(newList);
            Console.WriteLine("The min element of the list is:");
            Console.WriteLine(newList.Min());
            Console.WriteLine("The max element of the list is:");
            Console.WriteLine(newList.Max());
            Console.WriteLine("The list after clear method:");
            newList.Clear();
            Console.WriteLine(newList);
            Console.WriteLine();
            
            Matrix<int> matrix1 = new Matrix<int>(3,3);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[0, 2] = 3;
            matrix1[1, 0] = 4;
            matrix1[1, 1] = 5;
            matrix1[1, 2] = 0;
            matrix1[2, 0] = 7;
            matrix1[2, 1] = 8;
            matrix1[2, 2] = 9;

            Matrix<int> matrix2 = new Matrix<int>(3, 3);
            matrix2[0, 0] = 1;
            matrix2[0, 1] = 2;
            matrix2[0, 2] = 3;
            matrix2[1, 0] = 4;
            matrix2[1, 1] = 5;
            matrix2[1, 2] = 6;
            matrix2[2, 0] = 7;
            matrix2[2, 1] = 8;
            matrix2[2, 2] = 9;
            Console.WriteLine("The sum of the matrix \n{0} \nand matrix \n{1} \nis:",matrix1,matrix2);
            Console.WriteLine(matrix1 + matrix2);
            Console.WriteLine("The division of the matrix \n{0} \nand matrix \n{1} \nis:", matrix1, matrix2);
            Console.WriteLine(matrix1 - matrix2);
            Console.WriteLine("The Product of the matrix \n{0} \nand matrix \n{1} \nis:", matrix1, matrix2);
            Console.WriteLine(matrix1 * matrix2);
            Console.WriteLine("Operator True for the matrix:");
            if (matrix1)
            {
                Console.WriteLine("The matrix: \n{0} \n has NO ZERO elements!",matrix1);
            }
            else
            {
                Console.WriteLine("The matrix:\n{0} \n HAS ZERO elements!",matrix1);
            }
            if (matrix2)
            {
                Console.WriteLine("The matrix:\n{0} \n has NO ZERO elements!",matrix2);
            }
            else
            {
                Console.WriteLine("The matrix: \n{0} \n HAS ZERO elements!",matrix2);
            }
        }
    }
}
