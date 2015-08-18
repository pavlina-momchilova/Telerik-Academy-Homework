using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circle_Perimeter_And_Area
{
    class CirclePerimeterAndArea
    {
        /*
            Problem 3. Circle Perimeter and Area

            Write a program that reads the radius r of a circle
            and prints its perimeter and area formatted with 2 digits
            after the decimal point.
         */
        static void Main(string[] args)
        {
            Console.Title = "Circle Perimeter and Area";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter radius of the circle: ");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2*Math.PI * r;
            double area = Math.PI * r * r;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The perimeter of the circle is: {0:0.00} ",perimeter);
            Console.WriteLine("The area of the circle is: {0:0.00} ",area);
        }
    }
}
