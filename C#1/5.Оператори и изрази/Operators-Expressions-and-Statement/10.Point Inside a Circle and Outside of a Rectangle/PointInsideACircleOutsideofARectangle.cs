using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Point_Inside_a_Circle_and_Outside_of_a_Rectangle
{
    class PointInsideACircleOutsideofARectangle
    {
        /*
            Problem 10. Point Inside a Circle & Outside of a Rectangle

            Write an expression that checks for given point (x, y) if it
            is within the circle K({1, 1}, 1.5) and out of the rectangle
            R(top=1, left=-1, width=6, height=2).

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insert PointX: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert PointY: ");
            double y = double.Parse(Console.ReadLine());
            bool isInCircle = false;
            bool isOutRectangle = false;
            double CircleX = 1;
            double CircleY = 1;
            double CircleRadius = 1.5;
            if ((x - CircleX) * (x - CircleX) + (y - CircleY) * (y - CircleY) <= CircleRadius * CircleRadius)
            {
                isInCircle = true;
            }
            else
            {
                isInCircle = false;
            }
            if (!(x >= -1 && x <= 5 && y <= 1 && y >= -1))
            {
                isOutRectangle = true;
            }
            else
            {
                isOutRectangle = false;
            }
            if (isInCircle==true && isOutRectangle==true)
            {
                Console.WriteLine("The point is in the circle and out of the rectangle");
            }
            else if(isInCircle==true&&isOutRectangle==false)
            {
                Console.WriteLine("The point is in the circle and inside of the rectangle");
            }
            else if (isInCircle == false && isOutRectangle == true)
            {
                Console.WriteLine("The point is out of the circle and in the rectangle");
            }
            else
            {
                Console.WriteLine("The point is out of the circle and out of the rectangle");

            }
        }
    }
}
