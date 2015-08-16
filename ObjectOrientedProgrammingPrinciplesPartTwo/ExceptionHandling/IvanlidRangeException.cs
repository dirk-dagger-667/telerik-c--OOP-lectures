using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class InvalidRangeException<T> : ArgumentOutOfRangeException
    {
        private T startOfRange;
        private T endOfRange;

        public T StartOfRange
        {
            get { return this.startOfRange; }
        }
        public T EndOfRange
        {
            get { return this.endOfRange; }
        }

        public InvalidRangeException(string msg, T startOfRange, T endOfRange) : base(msg)
        {
            this.startOfRange = startOfRange;
            this.endOfRange = endOfRange;
        }
    }
}
