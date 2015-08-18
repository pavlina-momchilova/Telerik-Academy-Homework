namespace DefiningClasses2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    static class DistanceBetweenTwoPoints
    {
        /*
            Problem 3. Static class

            Write a static class with a static method to calculate the distance between two points in the 3D space.
         */
        public static double Distance(Point3D point1, Point3D point2)
        {
            double distance = 0;
            distance = Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y) + (point2.Z - point1.Z) * (point2.Z - point1.Z));
            return distance;
        }
    }
}
