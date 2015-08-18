namespace RefactorAndImproveTheCode
{
    using System;
    using System.Collections.Generic;

    public class CreateMines
    {
        public static char[,] Create()
        {
            int rows = 5;
            int columns = 10;
            char[,] gameField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int mine = random.Next(50);
                if (!mines.Contains(mine))
                {
                    mines.Add(mine);
                }
            }

            foreach (int mine in mines)
            {
                int column = mine / columns;
                int row = mine % columns;
                if (row == 0 && mine != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                gameField[column, row - 1] = '*';
            }

            return gameField;
        }
    }
}
