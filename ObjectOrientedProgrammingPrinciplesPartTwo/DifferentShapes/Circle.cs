using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DifferentShapes
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Raduis cannot be less than or equal to 0!");
            }
            this.Height = radius;
            this.Width = radius;
        }

        public override double CalculateSurfice()
        {
            return Math.PI * this.Height * this.Width;
        }
    }
}
