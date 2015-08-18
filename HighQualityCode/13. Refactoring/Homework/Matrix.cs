namespace RotatingWalkInMatrix
{
    using System;
    using System.Text;

    public class Matrix
    {
        private const int DirectionsCount = 8;
        private int size;
        private int[,] matrix;
        private int row = 0;
        private int column = 0;

        public Matrix(int size)
        {
            this.Size = size;
            this.matrix = new int[this.Size, this.Size];
            this.FindAvailableCell();
            this.FillCell();
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Matrix size must be more or equal to 1 and less or equal to 100!");
                }

                this.size = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringMatrix = new StringBuilder();

            for (int row = 0; row < this.Size; row++)
            {
                for (int column = 0; column < this.Size; column++)
                {
                    stringMatrix.AppendFormat("{0,3}", this.matrix[row, column]);
                }

                stringMatrix.Append("\n");
            }

            return stringMatrix.ToString();
        }

        private void Directions(ref int dirRow, ref int dirColumn)
        {
            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionColumn = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirection = 0;

            for (int index = 0; index < DirectionsCount; index++)
            {
                if (directionRow[index] == dirRow && directionColumn[index] == dirColumn)
                {
                    currentDirection = index;
                    break;
                }
            }

            if (currentDirection == DirectionsCount - 1)
            {
                dirRow = directionRow[0];
                dirColumn = directionColumn[0];
                return;
            }

            dirRow = directionRow[currentDirection + 1];
            dirColumn = directionColumn[currentDirection + 1];
        }

        private void FindAvailableCell()
        {
            this.row = 0;
            this.column = 0;
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    if (this.matrix[i, j] == 0)
                    {
                        this.row = i;
                        this.column = j;
                        return;
                    }
                }
            }
        }

        private bool IsInRange(int value)
        {
            if (value >= this.Size || value < 0)
            {
                return false;
            }

            return true;
        }

        private bool IsCellAvailable(int row, int column)
        {
            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionColumn = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < DirectionsCount; i++)
            {
                int nextRow = row + directionRow[i];
                int nextColumn = column + directionColumn[i];

                if (!this.IsInRange(nextColumn))
                {
                    directionColumn[i] = 0;
                }

                if (!this.IsInRange(nextRow))
                {
                    directionRow[i] = 0;
                }
            }

            for (int j = 0; j < DirectionsCount; j++)
            {
                int nextRow = row + directionRow[j];
                int nextColumn = column + directionColumn[j];

                if (this.matrix[nextRow, nextColumn] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void FillCell()
        {
            int directionRow = 1;
            int directionColumn = 1;
            int cellValue = 1;

            while (true)
            {
                this.matrix[this.row, this.column] = cellValue;

                if (!this.IsCellAvailable(this.row, this.column))
                {
                    this.FindAvailableCell();
                    if (this.IsCellAvailable(this.row, this.column))
                    {
                        cellValue++;
                        this.matrix[this.row, this.column] = cellValue;
                        directionRow = 1;
                        directionColumn = 1;
                    }
                    else
                    {
                        break;
                    }
                }

                int nextRow = this.row + directionRow;
                int nextColumn = this.column + directionColumn;

                if (!this.IsInRange(nextRow) || !this.IsInRange(nextColumn) || this.matrix[nextRow, nextColumn] != 0)
                {
                    while (!this.IsInRange(nextRow) || !this.IsInRange(nextColumn) || this.matrix[nextRow, nextColumn] != 0)
                    {
                        this.Directions(ref directionRow, ref directionColumn);

                        nextRow = this.row + directionRow;
                        nextColumn = this.column + directionColumn;
                    }
                }

                this.row += directionRow;
                this.column += directionColumn;
                cellValue++;
            }
        }
    }
}
