
namespace DefiningClasses2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;
    static class PathStorage
    {
        /*
         
            Problem 4. Path

            Create a class Path to hold a sequence of points in the 3D space.
            Create a static class PathStorage with static methods to save and load paths from a text file.
            Use a file format of your choice.
        */
             
        
        public static void SavePath(string path, List<Point3D> SequenseOfPoints)
        {
            StreamWriter write = new StreamWriter(path);
            using (write)
            {
                foreach (Point3D p in SequenseOfPoints)
                {
                    write.WriteLine(p);
                }   
            }
        }
        public static List<Point3D> LoadFile(string path)
        {
            StreamReader read = new StreamReader(path);
            List<Point3D> loadingPoints = new List<Point3D>();
            string line = read.ReadLine();
            using (read)
            {
                string[] num = new String[3];
                while (line != null)
                {
                    num = line.Trim().Split(new char[] {' ', ',', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);
                    loadingPoints.Add(new Point3D(Convert.ToDouble(num[0]),Convert.ToDouble(num[1]),Convert.ToDouble(num[2])));
                    line = read.ReadLine();
                }
            }
            return loadingPoints;
        }
    }
}
