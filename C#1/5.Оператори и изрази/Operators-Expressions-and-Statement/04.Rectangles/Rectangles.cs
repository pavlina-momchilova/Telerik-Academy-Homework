using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        /*
            Problem 4. Rectangles

            Write an expression that calculates rectangle’s perimeter and area by given width and height.

         */
        static void Main(string[] args)
        {
            float[] width = {3f,2.5f,5f};
            float[] height = { 4f, 3f, 5f };
            double perimeter;
            double area;
            int rectangle;
            for (int i = 0; i < width.Length; i++)
            {
                perimeter = 2 * width[i] + 2 * height[i];
                area = width[i] * height[i];
                rectangle = i+1;
                Console.WriteLine(rectangle+" "+"rectangles has width: " + width[i] + " height" + height[i] +" perimeter: "+perimeter +" area: "+ area);
            }
        }
    }
}
