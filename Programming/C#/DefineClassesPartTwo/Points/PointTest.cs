using System;
using System.Linq;


namespace Points
{
    
//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.
//Write a static class with a static method to calculate the distance between two points in the 3D space.
//Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.

    class PointTest
    {
        static void Main(string[] args)
        {
            Point3D blankPoint = Point3D.BlankPoint; //Add zero point
            //Add some points
            Point3D firstPoint = new Point3D(12, 15, 16); 
            Point3D secondPoint = new Point3D(10, 2, 13);
            //Test to string
            Console.WriteLine(firstPoint);
            Console.WriteLine(blankPoint);
            //Add third point
            Point3D thirdPoint = new Point3D(2, 2, 2);
            //Calculate and print distance
            double dist = Distance.CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine("Distance: "+ dist);
            //Test Path
            Path testPath = new Path();
            //Test add path method
            testPath.AddPoints(firstPoint,secondPoint,thirdPoint);
            //test pathstorage save and load methods
            PathStorage.SavePath(testPath);
            Path loaded = PathStorage.LoadPath();
            Console.WriteLine(loaded);
        }
    }
}
