using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DifferentShapes
{
    public abstract class Shape
    {
        private double height;
        private double width;

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The height cannot be negative or equal to 0!");
                }
                this.height = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The width cannot be negative or equal to 0!");
                }
                this.width = value;
            }
        }
        protected Shape()
        {

        }

        protected Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public abstract double CalculateSurfice();
        
    }
}
