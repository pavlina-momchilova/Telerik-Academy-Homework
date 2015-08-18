namespace RefactorAndImproveTheCode
{
    using System;
    using System.Collections.Generic;

    public class Raiting
    {
        public static void RaitingTopPlayer(List<Players> player)
        {
            Console.WriteLine("\nScore:");
            if (player.Count > 0)
            {
                for (int i = 0; i < player.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} score", i + 1, player[i].Name, player[i].Score);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There is no players!\n");
            }
        }
    }
}
