using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Print_a_Deck_of_52_Cards
{
    class PrintADeckOf52Cards
    {
        /*
            Problem 4. Print a Deck of 52 Cards

            Write a program that generates and prints
            all possible cards from a standard deck of 52 cards
            (without the jokers). The cards should be printed using
            the classical notation (like 5 of spades, A of hearts, 9
            of clubs; and K of diamonds).
            The card faces should start from 2 to A.
            Print each card face in its four possible suits:
            clubs, diamonds, hearts and spades. Use 2 nested
            for-loops and a switch-case statement.
         */
        static void Main()
        {
            Console.Title = "Print a Deck of 52 Cards";
            string[] cards={"2","3","4","5","6","7","8","9","10","J","Q","K","A",};
            char[] type = { '\u2660','\u2665','\u2666','\u2663' };
            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = 0; j < type.Length;j++)
                {
                    switch (cards[i])
                    {
                        case "2": Console.Write(cards[i] + type[j]);
                            break;
                        case "3": Console.Write(cards[i] + type[j]);
                            break;
                        case "4": Console.Write(cards[i] + type[j]);
                            break;
                        case "5": Console.Write(cards[i] + type[j]);
                            break;
                        case "6": Console.Write(cards[i] + type[j]);
                            break;
                        case "7": Console.Write(cards[i] + type[j]);
                            break;
                        case "8": Console.Write(cards[i] + type[j]);
                            break;
                        case "9": Console.Write(cards[i] + type[j]);
                            break;
                        case "10": Console.Write(cards[i] + type[j]);
                            break;
                        case "J": Console.Write(cards[i] + type[j]);
                            break;
                        case "Q": Console.Write(cards[i] + type[j]);
                            break;
                        case "K": Console.Write(cards[i] + type[j]);
                            break;
                        case "A": Console.Write(cards[i] + type[j]);
                            break;
                    }
                    if(j!=3)
                    {
                        Console.Write(" ,");
                    }
                }
                
                Console.WriteLine("\n");
            }
        }
    }
}
