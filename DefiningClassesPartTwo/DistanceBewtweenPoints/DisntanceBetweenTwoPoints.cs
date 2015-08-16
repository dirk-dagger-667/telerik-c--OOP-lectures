using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBewtweenPoints
{
    public static class DisntanceBetweenTwoPoints
    {
        public static void CalcDistance(Point3D point1, Point3D point2)
        {
            double distance = Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y) + (point2.Z - point1.Z) * (point2.Z - point1.Z));
            Console.WriteLine(distance);
        }
    }
}
