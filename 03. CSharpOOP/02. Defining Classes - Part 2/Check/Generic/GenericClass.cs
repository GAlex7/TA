namespace Check.Generic
{
    using System;
    using System.Collections.Generic;

    class GenericList<T>
    {
        private int capacity = 4;
        private int count = -1;
        private T[] elements;

        public GenericList()
        {
            this.elements = new T[Capacity];
        }

        public int Capacity
        {
            get
            {
                return this.elements.Length;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(T newElement)
        {
            if (this.Count + 1 > Capacity)
            {
                IncreaseCapacity();
                elements[Count] = newElement;
            }
            else
            {
                elements[Count] = newElement;
            }
            this.count++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index > Count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                elements[index] = default(T);
            }
            this.count--;
        }

        public void Insert(T newElement, int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index > this.Count - 1)
            {
                IncreaseCapacity();
            }
            for (int i = this.elements.Length; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = newElement;
            this.count++;
        }

        public void Clear()
        {
            this.elements = new T[Capacity];
        }

        public int Find(T element)
        {
            int index = -1;
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        // Indexer declaration
        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }
            set
            {
                this.elements[index] = value;
            }
        }

        public override string ToString()
        {
            return String.Join("; ", this.elements);
        }

        private void IncreaseCapacity()
        {
            var newList = new T[this.Capacity * 2];
            for (int i = 0; i < this.Capacity; i++)
            {
                newList[i] = this.elements[i];
            }
            this.capacity *= 2;
            this.elements = newList;
        }

    }
}
