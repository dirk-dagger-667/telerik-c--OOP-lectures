using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsAndShit
{
    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age)
            :base(name, age)
        {

        }
    }
}
