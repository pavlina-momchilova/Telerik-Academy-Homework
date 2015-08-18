using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Check_for_a_Play_Card
{
    class CheckForAPlayCard
    {
        /*
            Problem 3. Check for a Play Card

            Classical play cards use the following signs to designate the
            card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
            Write a program that enters a string and prints “yes”
            if it is a valid card sign or “no” otherwise. Examples:

         */
        static void Main()
        {
            Console.Title = "Check for a Play Card";
            Console.WriteLine("Enter card: ");
            string[] playCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string card = Console.ReadLine();
            bool isValid = false;
            for (int i = 0; i < playCards.Length; i++)
            {
                if (card == playCards[i])
                {
                    isValid = true;
                }
            }
            if (isValid == true)
            {
                Console.WriteLine("yes it's a card!");
            }
            else 
            {
                Console.WriteLine("no it's not a card!");
            }
        }
    }
}
