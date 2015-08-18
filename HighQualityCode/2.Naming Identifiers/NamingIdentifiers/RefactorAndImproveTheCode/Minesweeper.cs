namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using RefactorAndImproveTheCode;

    public class Minesweeper
    {
        public static void Main(string[] arguments)
        {
            string command = string.Empty;
            char[,] gameField = GameField.CreateGameField();
            char[,] mines = CreateMines.Create();
            int score = 0;
            bool gameOver = false;
            int numOfPlayers = 6;
            List<Players> topPlayers = new List<Players>(numOfPlayers);
            int row = 0;
            int column = 0;
            bool win = false;
            bool restart = true;
            const int MaxOpenSquares = 35;

            do
            {
                if (restart)
                {
                    Console.WriteLine("Lets play Minesweeper. Find the empty squares while avoiding the mines. " +
                                       "\nCommand 'top' showing raiting, 'restart' begin new game, 'exit' ending the game!\nGood Luck! ");
                    GameField.GameFieldRenderer(gameField);
                    restart = false;
                }

                Console.Write("Enter which row and column you want to open: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) &&
                        row <= gameField.GetLength(0) && column <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Raiting.RaitingTopPlayer(topPlayers);
                        break;
                    case "restart":
                        gameField = GameField.CreateGameField();
                        mines = CreateMines.Create();
                        GameField.GameFieldRenderer(gameField);
                        gameOver = false;
                        restart = false;
                        break;
                    case "exit":
                        Console.WriteLine("Game Over!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                CountMinesAround.NumOfMinesAround(gameField, mines, row, column);
                                score++;
                            }

                            if (MaxOpenSquares == score)
                            {
                                win = true;
                            }
                            else
                            {
                                GameField.GameFieldRenderer(gameField);
                            }
                        }
                        else
                        {
                            gameOver = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nWrong command!\n");
                        break;
                }

                if (gameOver)
                {
                    GameField.GameFieldRenderer(mines);
                    Console.Write("\nGameOver! Your score is {0} points. " + "Enter your name: ", score);
                    string playerName = Console.ReadLine();
                    Players newPlayer = new Players(playerName, score);
                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(newPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].Score < newPlayer.Score)
                            {
                                topPlayers.Insert(i, newPlayer);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayers.Sort((Players player1, Players player2) => player2.Name.CompareTo(player1.Name));
                    topPlayers.Sort((Players palyer1, Players player2) => player2.Score.CompareTo(palyer1.Score));
                    Raiting.RaitingTopPlayer(topPlayers);

                    gameField = GameField.CreateGameField();
                    mines = CreateMines.Create();
                    score = 0;
                    gameOver = false;
                    restart = true;
                }

                if (win)
                {
                    Console.WriteLine("\nCongratulations! You Win!");
                    GameField.GameFieldRenderer(mines);
                    Console.WriteLine("Enter your name: ");
                    string nameOfWinner = Console.ReadLine();
                    Players newPlayer = new Players(nameOfWinner, score);
                    topPlayers.Add(newPlayer);
                    Raiting.RaitingTopPlayer(topPlayers);
                    gameField = GameField.CreateGameField();
                    mines = CreateMines.Create();
                    score = 0;
                    win = false;
                    restart = true;
                }
            }
            while (command != "exit");
            Console.Read();
        }
    }
}