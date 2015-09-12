using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method. Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.


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
