using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [Version(1.4)]
    class SampleClass
    {
        static void Main(string[] args)
        {
            Type type = typeof(SampleClass);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attributes)
	        {
		        Console.WriteLine("the version is : {0}", item.Version);   
	        }
        }
    }
}
