namespace ShapesAndShit
{
    using System;
    class Triangle : Shape, IShape
    {
        public Triangle(double width, double height)
            :base(width, height)
        {
            
        }
        public override double CalcSurface()
        {
            return this.Height * this.Width / 2;
        }
    }
}
