using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.


namespace GenericListOfElements
{
    public class GenericList <T>
    {
        private int count;
        private T[] arrayOfElements;
        
        public GenericList() : this(0)
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

        public void AddElement(T element)
        {
            if (this.count == arrayOfElements.Length)
	        {
		        throw new ArgumentOutOfRangeException("Index out of range of the array!");
	        }
            this.arrayOfElements[count] = element;
            this.count++;
        }
        public T GetElementAtIndex(int index)
        {
            if (index >= arrayOfElements.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range of the array or is negative!");
            }
            else
            {
                return arrayOfElements[index]; ;
            }
        }
        public void RemoveElementAtIndex(int index)
        {
            if (index >= arrayOfElements.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range of the array or is negative!");
            }
            else
            {
                for (int i = index; i < arrayOfElements.Length; i++)
                {
                    arrayOfElements[index] = arrayOfElements[i + 1];
                }
                arrayOfElements[arrayOfElements.Length - 1] = default(T);
            }
        }
        public void InsertElementAtIndex(int index, T element)
        {
            if (index >= arrayOfElements.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range of the array or is negative");
            }
            else
            {
                arrayOfElements[index] = element;
            }
        }
        public void ClearList()
        {
            Array.Clear(arrayOfElements,0,arrayOfElements.Length);
            this.count = 0;
        }
        public int FindElementByValue(T element)
        {
            return Array.IndexOf(arrayOfElements, element);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arrayOfElements.Length; i++)
            {
                sb.Append(arrayOfElements[i].ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }

    }
}
