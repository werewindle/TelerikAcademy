using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Points
{
    class Path
    {
        private readonly List<Point3D> allPoints = new List<Point3D>();

        public List<Point3D> Paths
        {
            get
            {
                return this.allPoints;
            }
        }

        public void AddPoints(params Point3D[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                allPoints.Add(points[i]);
            }
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("Current Path Start----->");
            foreach (Point3D point in allPoints)
            {
                output.Append(point.ToString());
                output.AppendLine();
            }
            output.AppendLine("<---- Current Path End");
            return output.ToString();
        }
    }
}
