using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Point_in_a_Circle
{
    class PointInACircle
    {
        /*
            Problem 7. Point in a Circle

            Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

         */
        static void Main(string[] args)
        {
            Console.WriteLine("insert x");
            double PointX = double.Parse(Console.ReadLine());
            Console.WriteLine(PointX);
            Console.WriteLine("insert y");
            double PointY = double.Parse(Console.ReadLine());
            Console.WriteLine(PointY);
            double CircleX = 0;
            double CircleY = 0;
            double CircleRadius = 2;
            if (((PointX - CircleX) * (PointX - CircleX) + (PointY - CircleY) * (PointY - CircleY)) <= CircleRadius * CircleRadius)
            {
                Console.WriteLine("the point is in the circle");
            }
            else
            {
                Console.WriteLine("the point is not in the circle");
            }
        }
    }
}
