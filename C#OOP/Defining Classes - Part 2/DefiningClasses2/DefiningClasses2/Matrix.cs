
namespace DefiningClasses2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Matrix<T>
    {
        private T[,] matrix;
        private int col;
        private int row;

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.matrix = new T[Row, Col];
        }

        public int Row
        {
            get
            {
                return this.row;
            }
            set
            {
                this.row = value;
            }

        }
        public int Col
        {
            get
            {
                return this.col;
            }
            set
            {
                this.col = value;
            }

        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }
      
        public static Matrix<T> operator + (Matrix<T> mat1, Matrix<T> mat2)
        {
            if (mat1.Row != mat2.Row || mat1.Col != mat2.Col)
            {
                throw new InvalidOperationException("The matrix must be the same type!");
            }
            else
            {
                Matrix<T> matr3=new Matrix<T>(mat1.Row, mat1.Col);
                for (int i = 0; i < mat1.Row; i++)
			    {	 
                    for (int j = 0; j < mat1.Col; j++)
			        {
                        matr3[i,j]=(dynamic)mat1[i,j] + mat2[i,j];
			        }
			    }
                return matr3;
            }
        }

        public static Matrix<T> operator -(Matrix<T> mat1, Matrix<T> mat2)
        {
            if (mat1.Row != mat2.Row || mat1.Col != mat2.Col)
            {
                throw new InvalidOperationException("The matrix must be the same type!");
            }
            else
            {
                Matrix<T> matr3 = new Matrix<T>(mat1.Row, mat1.Col);
                for (int i = 0; i < matr3.Row; i++)
                {
                    for (int j = 0; j < matr3.Col; j++)
                    {
                        matr3[i, j] = (dynamic)mat1[i, j] - (dynamic)mat2[i, j];
                    }
                }
                return matr3;
            }
        }

        public static Matrix<T> operator *(Matrix<T> mat1, Matrix<T> mat2)
        {
            if (mat1.Col != mat2.Row)
            {
                throw new InvalidOperationException("The matrix1 must have the same size of rows as cols of matrix 2!");
            }
            else
            {
                Matrix<T> matr3 = new Matrix<T>(mat1.Row, mat1.Col);
                for (int i = 0; i < matr3.Row; i++)
                {
                    for (int j = 0; j < matr3.Col; j++)
                    {
                        for (int index = 0; index < matr3.Col; index++)
                        {
                            matr3[i, j] += (dynamic)mat1[i, index] * (dynamic)mat2[index, j];
                        }
                    }
                }
                return matr3;
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Row; row++)
            {
                for (int col = 0; col < matrix.Col; col++)
                {
                    if (matrix[row, col] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Row; row++)
            {
                for (int col = 0; col < matrix.Col; col++)
                {
                    if (matrix[row, col] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    result.Append(this.matrix[i, j]);
                    result.Append("     ");
                }
                result.AppendLine();
            }

            return result.ToString();
        }

    }
}
