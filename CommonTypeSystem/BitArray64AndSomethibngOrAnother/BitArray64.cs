using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace BitArray64AndSomethibngOrAnother
{
    public class BitArray64 : IEnumerable<int>
    {
        private ulong value64Bits;

        public ulong Value64Bits
        {
            get { return this.value64Bits; }
            set { this.value64Bits = value; }
        }

        public BitArray64(ulong number)
        {
            this.value64Bits = number;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("The index should be between the values of 0 and 63 included!");
                }
                else
                {
                    return (value64Bits & ((ulong)1 << index)) != 0 ? 1 : 0;
                }
            }
            set
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("The index should be between the values of 0 and 63 included!");
                }
                if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException("The value should be either 1 or 0 as requiered by the bit operations!");
                }
                if (value == 0)
                {
                    this.value64Bits = this.value64Bits | ((ulong)1 << index);
                }
                else
                {
                    this.value64Bits = this.value64Bits | (~((ulong)1 << index));
                }
            }
        }

        public override bool Equals(object obj)
        {
 	        BitArray64 newBitValue = obj as BitArray64;

            if (newBitValue == null)
            {
                return false;
            }
            if (this.Value64Bits != newBitValue.Value64Bits)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public override int GetHashCode()
        {
            return this.Value64Bits.GetHashCode();
        }

        public static bool operator ==(BitArray64 value1, BitArray64 value2)
        {
            return (BitArray64.Equals(value1, value2));
        }
        public static bool operator !=(BitArray64 value1, BitArray64 value2)
        {
            return (!(BitArray64.Equals(value1, value2)));
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
