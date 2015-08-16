namespace ShapesAndShit
{
    using System;
    class Circle : Shape, IShape
    {
        public Circle(double diameter)
            : base(diameter)
        {

        }
        public override double CalcSurface()
        {
            return this.Height * this.Width * Math.PI / 4;
        }
    }
}
