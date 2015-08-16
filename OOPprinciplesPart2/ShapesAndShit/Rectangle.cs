namespace ShapesAndShit
{
    using System;
    class Rectangle : Shape, IShape
    {
        public Rectangle(double width, double height)
            :base(width, height)
        {
            
        }
        public override double CalcSurface()
        {
            return this.Height * this.Width;
        }
    }
}
