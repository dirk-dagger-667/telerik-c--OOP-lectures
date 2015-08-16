﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBewtweenPoints
{
    public struct Point3D
    {
        private static readonly Point3D point0 = new Point3D(0.0d, 0.0d, 0.0d);
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point3D Point0
        {
            get { return point0; }
        }
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("X : " + X + "\nY : " + Y + "\nZ : " + Z);
            return sb.ToString();
        }
    }
}
