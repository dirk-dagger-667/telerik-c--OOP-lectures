using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsAndShit
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age)
            :base(name, age)
        {

        }
        public Frog(string name, int age, bool gender)
            : base(name, age, gender)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Jabeshki zvuk!");
        }
    }
}
