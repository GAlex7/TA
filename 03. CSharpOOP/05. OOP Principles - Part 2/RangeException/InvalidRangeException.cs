namespace RangeException
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string msg, T start, T end, Exception innerEx)
            : base(string.Format("{0}\nParameter should be in range[{1}; {2}]", msg, start, end), innerEx)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string msg, T start, T end)
            : this(msg, start, end, null)
        {
        }

        public T Start
        {
            get { return this.start; }
            private set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            private set { this.end = value; }
        }
    }
}
