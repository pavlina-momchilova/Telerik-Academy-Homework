using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Quadratic_Equation
{
    class QuadraticEquation
    {
        /*
            Problem 6. Quadratic Equation

            Write a program that reads the coefficients a, b and
            c of a quadratic equation ax2 + bx + c = 0 and solves it
            (prints its real roots).

         */
        static void Main(string[] args)
        {
            Console.Title = "Quadratic Equation";
            Console.WriteLine("Enter coefficients a, b and c of a quadratic equation");
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;
            double x1;
            double x2;
            if (discriminant > 0)
            {
                x1 = (-1*(b) - Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-1*(b) + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("x1={0}; x2={1}",x1,x2);
            }
            else if (discriminant == 0)
            {
                x1 = ((-1)*b) / (2 * a);
                Console.WriteLine("x1=x2="+x1);
            }
            else
            {
                Console.WriteLine("The quadratic equation has no real roots!");
            }
        }
    }
}
