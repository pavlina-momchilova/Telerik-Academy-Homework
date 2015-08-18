namespace _1.Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ShapeTest
    {
        static void Main()
        {
            Shape[] shapes ={
                                new Triangle(5,7),
                                new Rectangle(7,8),
                                new Square(5)
                           };
            foreach (var figure in shapes)
            {
                Console.Write("The surface of the figure {0} is: ",figure.GetType().Name);
                Console.WriteLine("{0:F2}",figure.CalculateSurface());
            }
        }
    }
}
