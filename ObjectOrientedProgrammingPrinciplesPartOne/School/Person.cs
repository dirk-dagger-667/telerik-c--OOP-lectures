using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set 
            {
                if (value.Length == 0)
                {
                    throw new ArgumentNullException("The name of a person cannot be null!");
                }
            }
        }
    }
}
