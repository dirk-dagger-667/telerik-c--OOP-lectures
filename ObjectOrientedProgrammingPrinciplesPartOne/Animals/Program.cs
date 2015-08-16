using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        private static IEnumerable<Tuple<string, double>> GetAverageAges(Animal[] animals)
        {
            var averageAges =
                from animal in animals
                group animal by animal.GetType() into animalType
                select new Tuple<string, double>(animalType.Key.Name, animalType.Average(a => a.Age));

            return averageAges;
        }

        static void Main(string[] args)
        {
            var noisyCreatures = new ISound[]
        {
            new Dog(5, "Rex", "male"),
            new Frog(49, "Kermit", "male"),
            new Dog(15, "Stella", "female"),
            new Tomcat(8, "Hoho"),
            new Kitten(5, "Cleopatra"),
            new Dog(3, "Ceaser", "male"),
            new Kitten(6, "Joro"),
            new Tomcat(7, "Borko"),
            new Dog(13,"Sharo", "male")
        };
            var animals = new Animal[]
        {
            new Dog(5, "Rex", "male"),
            new Frog(49, "Kermit", "male"),
            new Dog(15, "Stella", "female"),
            new Tomcat(8, "Hoho"),
            new Kitten(5, "Cleopatra"),
            new Dog(3, "Ceaser", "male"),
            new Kitten(6, "Joro"),
            new Tomcat(7, "Borko"),
            new Dog(13,"Sharo", "male")
        };

            foreach (var noisyCreature in noisyCreatures)
            {
                noisyCreature.MakeSound();
            }

            var averageAges = GetAverageAges(animals);
            foreach (var item in averageAges)
            {
                Console.WriteLine(item.Item1 + " " + item.Item2);
            }
        }
    }
}
