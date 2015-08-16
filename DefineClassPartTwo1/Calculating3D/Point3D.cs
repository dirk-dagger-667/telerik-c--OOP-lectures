namespace Calculating3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public struct Point3D
    {
        private static readonly Point3D starting3DPoint = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public static Point3D ZeroPoint
        {
            get
            {
                return Point3D.starting3DPoint;
            }
        }

        public override string ToString()
        {
            return "X : " + X + "Y : " + Y + "Z : " + Z;
        }
    }
}
