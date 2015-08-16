using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new Shape[]
            {
                new Rectangle(12,1.6),
                new Circle(13.56),
                new Triangle(6,17.4)
            };

            foreach (var item in shapes)
            {
                Console.WriteLine(item.CalculateSurfice());
            }
        }
    }
}
