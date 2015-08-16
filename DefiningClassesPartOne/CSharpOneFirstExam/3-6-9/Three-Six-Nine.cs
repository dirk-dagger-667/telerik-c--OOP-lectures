using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace ThreeSixNine
{
    class ThreeSixNine
    {
        static void Main(string[] args)
        {

            long variableA = long.Parse(Console.ReadLine());
            long variableB = long.Parse(Console.ReadLine());
            long variableC = long.Parse(Console.ReadLine());
            BigInteger resultR = new BigInteger();
            resultR = 0;
            if (variableB == 3)
            {
                resultR = variableA + variableC;
            }

            else if (variableB == 6)
            {
                resultR = variableA * variableC;
            }

            else if (variableB == 9)
            {
                resultR = variableA % variableC;
            }

            if (resultR % 3 == 0)
            {
                Console.WriteLine(resultR / 3);
            }

            else
            {
                Console.WriteLine(resultR % 3);
            }

            Console.WriteLine(resultR);
        }
    }
}
