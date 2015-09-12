using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.
//Write a static class with a static method to calculate the distance between two points in the 3D space.
//Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.


namespace DistanceBewtweenPoints
{
    public class Path
    {
        private List<Point3D> listOfPoints = new List<Point3D>();

        public List<Point3D> ListOfPoints
        {
            get { return this.listOfPoints; }
        }

        public void AddPoint(Point3D point)
        {
            this.listOfPoints.Add(point);
        }

        public void ShowPath()
        {
            foreach(Point3D points in listOfPoints)
            {
                Console.WriteLine("{0},{1},{2}", points.X, points.Y, points.Z);
            }
        }
    }
}
