using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
namespace GenericList
{
    public class GenericList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        const int DefaultCapacity = 4;
        private int currentCapacity = DefaultCapacity;
        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
        }

        public GenericList()
            : this(DefaultCapacity)
        {
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.currentCapacity;
            }
        }

        // add element
        public void Add(T element)
        {
            if (this.count >= this.elements.Length)
            {
                DoubleCapacity();
            }
            this.elements[count] = element;
            this.count++;
        }

        // indexer
        public T this[int index]
        {
            get
            {
                if (index >= this.count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = this.elements[index];
                return result;
            }

            set
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                this.elements[index] = value;
            }
        }

        // inserting element at given position
        public void Insert(int index, T element)
        {
            if (index >= this.count)
            {
                throw new IndexOutOfRangeException(
                    "Index must be within the bounds of the List.");
            }

            if (this.count == this.Capacity)
            {
                DoubleCapacity();
            }

            for (int i = this.count; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = element;
            this.count++;
        }

        // removing element by index
        public void RemoveAt(int index)
        {
            if (index >= this.count)
            {
                throw new IndexOutOfRangeException(
                    "Index must be within the bounds of the List.");
            }

            for (int i = index; i < count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[count - 1] = default(T);
            count--;
        }

        // clearing the list
        public void Clear()
        {
            this.count = 0;
            this.currentCapacity = DefaultCapacity;
            this.elements = new T[this.currentCapacity];
        }

        // finding element by its value
        public int IndexOf(T value)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(value) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        // ToString()
        public override string ToString()
        {
            var result = new StringBuilder();

            for (int i = 0; i < this.count - 1; i++)
            {
                string r = "Element " + i + " = " + this.elements[i];
                result.AppendLine(r);
            }
            return result.ToString();
        }

        // Min<T>, Max<T>
        public T Min()
        {
            var min = this[1];
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(min) == -1)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            var max = this[1];
            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].CompareTo(max) == 1)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }

        // Helper Methods
        private void DoubleCapacity()
        {
            this.currentCapacity *= 2;

            var temp = new T[this.currentCapacity];

            Array.Copy(this.elements, temp, this.count);

            //elements = new T[temp.Length];
            this.elements = temp;
            //Array.Copy(temp, this.elements, this.count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.count; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}