namespace DefiningClasses2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    

    public class Path
    {
        /*
         
         Problem 4. Path

Create a class Path to hold a sequence of points in the 3D space.
Create a static class PathStorage with static methods to save and load paths from a text file.
Use a file format of your choice.
         */
        
        public void SequenseOfPoints()
        {
            List<Point3D> Points = new List<Point3D>();
            Points.Add(new Point3D(0, 5, 1));
            Points.Add(new Point3D(4, 6, 2));
            Points.Add(new Point3D(8, 7, 3));
            Points.Add(new Point3D(2, 1, 4));
            Points.Add(new Point3D(3, 1, 1));
        }



    }
}
