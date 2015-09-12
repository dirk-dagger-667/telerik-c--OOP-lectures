using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11). Apply the version attribute to a sample class and display its version at runtime.


namespace Attributes
{
[AttributeUsage(AttributeTargets.Struct |
                AttributeTargets.Class |
                AttributeTargets.Method |
                AttributeTargets.Interface |
                AttributeTargets.Enum, AllowMultiple = true)]
    public class VersionAttribute : System.Attribute
    {
        private double version;

        public VersionAttribute(double version)
        {
            this.version = version;
        }

        public double Version
        {
            get { return this.version; }
            set { this.version = value; }
        }
    }
}
