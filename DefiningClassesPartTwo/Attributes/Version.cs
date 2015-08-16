using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
