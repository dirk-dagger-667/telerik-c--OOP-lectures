using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Cat : Animal, ISound
    {
        public Cat(int age, string name, string sex): base(age, name, sex)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("Myauuuuuuuuuu!!!");
        }
    }
}
