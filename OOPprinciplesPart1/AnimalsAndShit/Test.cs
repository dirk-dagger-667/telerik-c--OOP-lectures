using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndShit
{
    class Test
    {
        static void Main(string[] args)
        {
            var dogs = new Dog[]{
            new Dog("Sharo", 12),
            new Dog("Sharo", 8, false),
            new Dog("Sharo", 5),
            new Dog("Sharo", 1),
            new Dog("Sharo", 2)
            };

            var frogs = new Frog[]{
            new Frog("Sharo", 12),
            new Frog("Sharo", 8, false),
            new Frog("Sharo", 5),
            new Frog("Sharo", 1),
            new Frog("Sharo", 2)
            };

            var cats = new Cat[]{
            new Cat("Sharo", 12),
            new Kitten("Sharo", 8),
            new Tomcat("Sharo", 5),
            new Cat("Sharo", 1),
            new Cat("Sharo", 2)
            };


        }
    }
}
