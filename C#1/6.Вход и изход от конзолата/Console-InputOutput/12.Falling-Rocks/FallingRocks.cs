using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12.Falling_Rocks
{
    //struct for elements spaceship and rocks
    struct Element
    {
        public int x;
        public int y;
        public string symbol;
        public ConsoleColor color;
    }

    class FallingRocks
    {
        /*
            Problem 12.** Falling Rocks

            Implement the "Falling Rocks" game in the text console.
            A small dwarf stays at the bottom of the screen and can
            move left and right (by the arrows keys).
            A number of rocks of different sizes and forms constantly
            fall down and you need to avoid a crash.
            Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, -
            distributed with appropriate density. The dwarf is (O).
            Ensure a constant game speed by Thread.Sleep(150).
            Implement collision detection and scoring system.

         */
        public const int playFieldWidth = 30;
        public const int playFieldHeight = 20;
        public static int liveCounter = 3;
        public static int scorePoint = 0;
        //set playfield
        public static void SettingTheConsole(int width, int height)
        {
            Console.WindowWidth = playFieldWidth;
            Console.WindowHeight = playFieldHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
        }

        //positions of the cursor
        public static void PrintOnPosition(int x, int y, string symbol,ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        //Information Panel
        public static void InfoPanel() 
        {
            int x = 0;
            int y = 1;
            PrintOnPosition(x, y,"-");
            for (int i = 0; i < playFieldWidth; i++)
            {
                PrintOnPosition(x, y,"-");
                x++;
            }
        }
        
        //Text in Info panel
        public static void InfoPanelText(int score, int lives)
        {
            PrintOnPosition(1, 0, "Score: ");
            Console.Write(scorePoint);
            PrintOnPosition(17, 0, "Lives: ");
            for (int i = 1; i <= lives; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\u2665 ");
            }
        }

        static void Main()
        {
            Console.Title = "Falling Rocks";
            //set the playfield
            SettingTheConsole(playFieldWidth, playFieldHeight);

            //remove the cursor
            Console.CursorVisible = false;

            //coordinate of the spaceShip
            Element spaceShip = new Element();
            spaceShip.x = (playFieldWidth / 2) - 1;
            spaceShip.y = playFieldHeight - 1;
            spaceShip.symbol = "(O)";
            //array with different colors
            ConsoleColor[] colorArray = { ConsoleColor.Blue, ConsoleColor.DarkGreen, ConsoleColor.Cyan, ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow };

            //random generator
            Random randomGenerator = new Random();
            
            //List with rocks
            List<Element> fallingRocks= new List<Element>();

            //The Game
            while (true)
            {
                //Create falling Rocks
                Element rock = new Element();
                
                rock.y = 2;
                rock.symbol = Convert.ToString(Convert.ToChar(Convert.ToInt32(randomGenerator.Next('\u0021', '\u002E'))));
                //+ ++ +++
                int symbolLenght = randomGenerator.Next(1, 3);
                while (symbolLenght>1)
                {
                    rock.symbol += rock.symbol;
                    symbolLenght--;
                }
                rock.x = randomGenerator.Next(0, playFieldWidth-rock.symbol.Length);
                //set color for the rocks
                rock.color = colorArray[randomGenerator.Next(0, colorArray.Length)];
                //Add rocks
                fallingRocks.Add(rock);

                //Clear the Console
                Console.Clear();

                //text in info panel
                InfoPanelText(scorePoint,liveCounter);

                //info panel
                InfoPanel();
                //move the spaceship
                while(Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow && spaceShip.x - 1 >= 0)
                    {
                        spaceShip.x--;
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow && spaceShip.x + 1 < playFieldWidth - spaceShip.symbol.Length)
                    {
                        spaceShip.x++;
                    }
                }
                //print the spaceShip
                PrintOnPosition(spaceShip.x, spaceShip.y, spaceShip.symbol);

                //moving rocks
                List<Element> newFallingRocks = new List<Element>();
                for (int index = 0; index < fallingRocks.Count; index++)
                {
                    Element oldRock = fallingRocks[index];
                    Element newRock = new Element();
                    newRock.x = oldRock.x;
                    newRock.y = oldRock.y + 1;
                    newRock.symbol = oldRock.symbol;
                    newRock.color = oldRock.color;
                    if (newRock.symbol.Length == 1)
                    {
                        if ((newRock.x == spaceShip.x && newRock.y == spaceShip.y) || (newRock.x == spaceShip.x + 1 && newRock.y == spaceShip.y) || (newRock.x == spaceShip.x + 2 && newRock.y == spaceShip.y))
                        {
                            liveCounter--;
                            if (liveCounter < 0)
                            {
                                PrintOnPosition(8, 9, "!GAME OVER!", ConsoleColor.DarkRed);
                                PrintOnPosition(5, 11, "Your score is: " + scorePoint, ConsoleColor.White);

                                Console.ReadKey();
                                Console.ReadLine();
                                Environment.Exit(0);
                            }
                        }
                    }
                    else if (newRock.symbol.Length == 2)
                    {
                        if ((newRock.x == spaceShip.x && newRock.y == spaceShip.y) || (newRock.x == spaceShip.x + 1 && newRock.y == spaceShip.y) || (newRock.x == spaceShip.x + 2 && newRock.y == spaceShip.y))
                        {
                            liveCounter--;
                            if (liveCounter < 0)
                            {
                                PrintOnPosition(8, 9, "!GAME OVER!", ConsoleColor.DarkRed);
                                PrintOnPosition(5, 11, "Your score is: " + scorePoint, ConsoleColor.White);

                                Console.ReadKey();
                                Console.ReadLine();
                                Environment.Exit(0);
                            }
                        }
                    }
                        if (newRock.y < playFieldHeight)
                        {
                            newFallingRocks.Add(newRock);
                        }
                }
                fallingRocks = newFallingRocks;
                foreach (Element fallingRock in fallingRocks)
                {
                    PrintOnPosition(fallingRock.x, fallingRock.y, fallingRock.symbol, fallingRock.color);
                    scorePoint++;
                }
                    //Slow down the game
                    Thread.Sleep(150);
            }
        }
    }
}
