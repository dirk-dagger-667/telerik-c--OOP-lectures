using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DifferentShapes
{
    public class Triangle : Shape
    {
        public Triangle(double heigth, double width): base(heigth, width)
        {

        }

        public override double CalculateSurfice()
        {
            return this.Height * this.Width / 2;
        }
    }
}
