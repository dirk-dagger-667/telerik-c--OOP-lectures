using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOwnTypeListOfSorts
{
    public class AListOfSort<T>
    {
        private T[] memoryOfItems;
        private int initialSize = 8;
        private int i = 0;

        public int Count 
        {
            get
            {
                return this.i;
            }
        }
        public T this[int indexer]
        {
            get
            {
                if (indexer >= 0 && indexer <= this.i)
                {
                    return this.memoryOfItems[indexer];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (indexer < 0 || indexer > this.i)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    this.memoryOfItems[indexer] = value;
                }
            }
        }

        public AListOfSort()
        {
            this.memoryOfItems = new T[initialSize];
        }

        public AListOfSort(int newSize) : this()
        {
            this.memoryOfItems = new T[newSize];
        }

        public void Add(T item)
        {
            if (i == memoryOfItems.Length)
            {
                Resize();    
            }
            memoryOfItems[i] = item;
            i++;
        }

        public void Remove(int index)
        {
            if (index < 0 && index > this.i)
            {
                for (int j = index; j < this.Count; j++)
                {
                    this.memoryOfItems[j] = this.memoryOfItems[j + 1];
                }

                this.memoryOfItems[this.Count] = default(T);
                this.i--;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void AddAtIndex(int index, T item)
        {
            if (index < 0 && index > this.i)
            {
                for (int j = index; j < this.Count; j++)
                {
                    this.memoryOfItems[j + 1] = this.memoryOfItems[j];
                }

                this.memoryOfItems[index] = item;
                this.i++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int FindIndex(T item)
        {
            for (int j = 0; j < this.Count; j++)
            {
                if (this.memoryOfItems[j].Equals(item))
                {
                    return j;
                }
            }

            return -1;
        }

        private void Resize()
        {
            T[] newArrayOfItems = new T[2 * initialSize];
            int counter = 0;

            for (int i = newArrayOfItems.Length/2 - this.memoryOfItems.Length/2;
                i < this.memoryOfItems.Length + (newArrayOfItems.Length/2 - this.memoryOfItems.Length/2); i++)
            {
                newArrayOfItems[i] = this.memoryOfItems[counter];
                counter++;
            }
        }

        public void Clear()
        {
            for (int j = 0; j < this.Count; j++)
            {
                this.memoryOfItems[j] = default(T);
            }

            this.i = 0;
        }

        public override string ToString()
        {
            StringBuilder printed = new StringBuilder();

            for (int j = 0; j < this.Count; j++)
            {
                printed.Append(this.memoryOfItems[j].ToString() + "\r\n");
            }

            return printed.ToString();
        }

        public T Min()
        {
            return this.memoryOfItems.Min();
        }

        public T Max()
        {
            return this.memoryOfItems.Max();
        }
    }
}
