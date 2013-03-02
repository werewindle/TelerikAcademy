using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Points
{
    static class PathStorage
    {
        static public void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter(@"../../Save.txt"))
            {
                foreach (var point in path.Paths)
                {
                    writer.WriteLine(point);
                }
            }
            Console.WriteLine("Path Saved");
            Console.WriteLine();
        }
        static public Path LoadPath()
        {
            Path loadPath = new Path();
            using (StreamReader reader = new StreamReader(@"../../Load.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line != string.Empty)
                    {
                        Point3D point = new Point3D();
                        string[] points = line.Split(',');
                        point.PointX = int.Parse(points[0]);
                        point.PointY = int.Parse(points[1]);
                        point.PointZ = int.Parse(points[2]);
                        loadPath.AddPoints(point);
                    }
                    line = reader.ReadLine();
                }
            }
            Console.WriteLine("Path Loaded");
            Console.WriteLine();
            return loadPath;
        }
    }
}
