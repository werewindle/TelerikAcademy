using System;
using System.Linq;

namespace Points
{
    static class Distance
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow(firstPoint.PointX - secondPoint.PointX, 2) + Math.Pow(firstPoint.PointY - secondPoint.PointY, 2) + Math.Pow(firstPoint.PointZ - secondPoint.PointZ, 2));
            return distance;
        }
    }
}
