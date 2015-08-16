using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsAndShit
{
    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age)
            :base(name, age)
        {
            this.Gender = false;
        }
    }
}
