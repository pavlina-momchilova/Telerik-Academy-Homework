using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TriangleSurface
{
    class TriangleSurface
    {
        /*
         Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
         */
       
        static void Main()
        {
            Console.WriteLine("Calculate surface of a triangle by given: ");
            Console.WriteLine("1.Side and an altitude to it");
            Console.WriteLine("2.Three sides");
            Console.WriteLine("3.Two sides and an angle between them");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter side of the triangle: ");
                double side = double.Parse(Console.ReadLine());
                Console.Write("Enter altitude of the triangle: ");
                double altitude = double.Parse(Console.ReadLine());
                Console.WriteLine("The surface of the triangle is {0}",surfaceBySideAndAltitude(side,altitude));
            }
            else if(choice==2)
            {
                Console.Write("Enter first side of the triangle: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Enter second side of the triangle: ");
                double side2 = double.Parse(Console.ReadLine());
                Console.Write("Enter third side of the triangle: ");
                double side3 = double.Parse(Console.ReadLine());
                Console.WriteLine("The surface of the triangle is {0}", surfaceByThreeSides(side1, side2, side3));
            }
            else if(choice==3)
            {
                Console.Write("Enter first side of the triangle: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Enter second side of the triangle: ");
                double side2 = double.Parse(Console.ReadLine());
                Console.Write("Enter angle of the triangle: ");
                double angle = double.Parse(Console.ReadLine());
                Console.WriteLine("The surface of the triangle is {0}", surfaceByTwoSidesAndAnAngle(side1, side2, angle));
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
        static double surfaceBySideAndAltitude(double side, double altitude)
        {
            double surface = (side * altitude) / 2;
            return surface;
        }
        static double surfaceByThreeSides(double side1, double side2, double side3)
        {
            double poluperimetar=(side1+side2+side3)/2;
            double surface = Math.Sqrt(poluperimetar * (poluperimetar - side1) * (poluperimetar - side2) * (poluperimetar - side3));
            return surface;
        }
        static double surfaceByTwoSidesAndAnAngle(double side1, double side2, double angle)
        {
            double surface = (side1 * side2 * Math.Sin(angle))/2;
            return surface;
        }
    }
}
