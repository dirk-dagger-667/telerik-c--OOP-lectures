using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsAndShit
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age)
            :base(name, age)
        {

        }
        public Cat(string name, int age, bool gender)
            : base(name, age, gender)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Koteshki zvuk!");
        }
    }
}
