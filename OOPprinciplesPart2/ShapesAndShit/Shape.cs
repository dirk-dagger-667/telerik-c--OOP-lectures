namespace ShapesAndShit
{
    using System;
    public abstract class Shape : IShape
    {
        private double width;
        private double height;

        public Shape(double diameter)
        {
            this.Height = diameter;
            this.Width = diameter;
        }
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("the width cannot be less than 0 or 0");
                }
                else
                {
                    this.width = value;
                }
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("the width cannot be less than 0 or 0");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public abstract double CalcSurface();
    }
}
