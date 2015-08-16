using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGrowFinction
{
    public class GenericList<T>
        where T : IComparable
    {
        private int count;
        private T[] arrayOfElements;

        public GenericList()
            : this(0)
        {
        }

        public GenericList(int length)
        {
            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException("The length cannot be 0 or negitive number!");
            }
            this.arrayOfElements = new T[length];
        }

        public void AutoGrow()
        {
            T[] copyArrayOfElements = (T[])arrayOfElements.Clone();
            this.arrayOfElements = new T[2*copyArrayOfElements.Length];
            for (int i = 0; i < copyArrayOfElements.Length; i++)
            {
                this.arrayOfElements[i] = copyArrayOfElements[i];
            }
            this.count = copyArrayOfElements.Length;
        }
        public void AddElement(T element)
        {
            if (this.count == arrayOfElements.Length)
            {
                AutoGrow();
            }
            this.arrayOfElements[count] = element;
            this.count++;
        }
        public T GetElementAtIndex(int index)
        {
            if (index >= this.arrayOfElements.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range of the array or is negative!");
            }
            else
            {
                return this.arrayOfElements[index]; ;
            }
        }
        public void RemoveElementAtIndex(int index)
        {
            if (index >= this.arrayOfElements.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range of the array or is negative!");
            }
            else
            {
                if (this.count >= index)
                {
                    this.count--;
                }
                for (int i = index; i < this.arrayOfElements.Length; i++)
                {
                    this.arrayOfElements[index] = this.arrayOfElements[i + 1];
                }
                this.arrayOfElements[this.arrayOfElements.Length - 1] = default(T);
            }
        }
        public void InsertElementAtIndex(int index, T element)
        {
            if (index >= this.arrayOfElements.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range of the array or is negative");
            }
            else
            {
                this.arrayOfElements[index] = element;
                this.count++;
            }
        }
        public void ClearList()
        {
            Array.Clear(this.arrayOfElements, 0, this.arrayOfElements.Length);
            this.count = 0;
        }
        public int FindElementByValue(T element)
        {
            return Array.IndexOf(this.arrayOfElements, element);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.arrayOfElements.Length; i++)
            {
                sb.Append(this.arrayOfElements[i].ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }
        public T Min<T>()
            where T : IComparable
        {
            dynamic min = this.arrayOfElements[0];
            for (int i = 0; i < this.arrayOfElements.Length; i++)
            {
                for (int j = i; j < this.arrayOfElements.Length; j++)
                {
                    if (this.arrayOfElements[i].CompareTo(min) >= 0)
                    {
                        min = this.arrayOfElements[i];
                    }
                }
            }
            return min;
        }
        public T Max<T>()
            where T : IComparable
        {
            dynamic max = this.arrayOfElements[0];
            for (int i = 0; i < this.arrayOfElements.Length; i++)
            {
                for (int j = i; j < this.arrayOfElements.Length; j++)
                {
                    if (this.arrayOfElements[i].CompareTo(max) <= 0)
                    {
                        max = this.arrayOfElements[i];
                    }
                }
            }
            return max;
        }
    }
}
