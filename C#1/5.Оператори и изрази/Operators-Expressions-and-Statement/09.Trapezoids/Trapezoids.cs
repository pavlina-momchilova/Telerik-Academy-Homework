using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Trapezoids
    {
        /*
            Problem 9. Trapezoids

            Write an expression that calculates trapezoid's area by given
            sides a and b and height h.

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Inser first side a= ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Inser second side b= ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Inser height h= ");
            double h = double.Parse(Console.ReadLine());
            double area;
            area = ((a + b) * h) / 2;
            Console.WriteLine("the area is: "+area);
        }
    }
}
