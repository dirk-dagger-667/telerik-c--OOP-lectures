using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
