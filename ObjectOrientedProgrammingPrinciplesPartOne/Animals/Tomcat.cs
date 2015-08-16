using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name): base(age, name, "male")
        {

        }
        public void MakeSound()
        {
            base.MakeSound();
        }
    }
}
