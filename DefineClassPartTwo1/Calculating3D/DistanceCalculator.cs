namespace Calculating3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    static class DistanceCalculator
    {
        public static double CalculateDistanceBetween23DPoints(Point3D firstPoint, Point3D secondPoint)
        {
            return Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X) +
                (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y) + 
                (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));
        }

        static void Main(string[] args)
        {

        }
    }
}
