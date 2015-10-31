namespace Stack
{
    using System;

    public class Stack<T>
    {
        private const int InitialSize = 4;
        private const string StackEmptyExceptionMessage = "Cannot pop. Stack is empty!";
        private T[] elements;
        private int top;

        public Stack()
        {
            this.elements = new T[InitialSize];
            this.top = 0;
        }

        public int Length
        {
            get { return this.top; }
        }

        public void Push(params T[] values)
        {
            foreach (var value in values)
            {
                if (this.IsFull())
                {
                    this.Resize();
                }

                this.elements[this.top++] = value;
            }
        }

        public T Pop()
        {
            if (this.IsEmpty())
            {
                throw new ArgumentException(StackEmptyExceptionMessage);
            }

            return this.elements[--this.top];
        }

        private bool IsFull()
        {
            return this.elements.Length == this.top;
        }

        private bool IsEmpty()
        {
            return this.top == 0;
        }

        private void Resize()
        {
            var newElements = new T[this.elements.Length * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }
    }
}