namespace RefactorAndImproveTheCode
{
    public class CountMinesAround
    {
        public static char MinesAround(char[,] mines, int row, int column)
        {
            int countMines = 0;
            int rows = mines.GetLength(0);
            int columns = mines.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mines[row - 1, column] == '*')
                {
                    countMines++;
                }
            }

            if (row + 1 < rows)
            {
                if (mines[row + 1, column] == '*')
                {
                    countMines++;
                }
            }

            if (column - 1 >= 0)
            {
                if (mines[row, column - 1] == '*')
                {
                    countMines++;
                }
            }

            if (column + 1 < columns)
            {
                if (mines[row, column + 1] == '*')
                {
                    countMines++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (mines[row - 1, column - 1] == '*')
                {
                    countMines++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (mines[row - 1, column + 1] == '*')
                {
                    countMines++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (mines[row + 1, column - 1] == '*')
                {
                    countMines++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (mines[row + 1, column + 1] == '*')
                {
                    countMines++;
                }
            }

            return char.Parse(countMines.ToString());
        }

        public static void NumOfMinesAround(char[,] gameField, char[,] mines, int row, int column)
        {
            char mine = CountMinesAround.MinesAround(mines, row, column);
            mines[row, column] = mine;
            gameField[row, column] = mine;
        }
    }
}
