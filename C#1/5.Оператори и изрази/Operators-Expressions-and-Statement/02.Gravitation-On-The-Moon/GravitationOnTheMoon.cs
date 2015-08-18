using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Gravitation_On_The_Moon
{
    class GravitationOnTheMoon
    {
        /*
            Problem 2. Gravitation on the Moon

            The gravitational field of the Moon is approximately 17% of that on the Earth.
            Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

         */
        static void Main(string[] args)
        {
            double[] weight = {86,74.6,53.7};
            double ManOnTheMoon;
            for (int i = 0; i < weight.Length; i++)
            {
                ManOnTheMoon = weight[i]*17 / 100;
                Console.WriteLine("weight on earth is: "+weight[i]+" weight on moon would be: "+ ManOnTheMoon);
            }
        }
    }
}
