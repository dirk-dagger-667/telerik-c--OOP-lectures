using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsAndShit
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age)
            :base(name, age)
        {

        }
        public Dog(string name, int age, bool gender)
            : base(name, age, gender)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Kucheshki zvuk!");
        }
    }
}
