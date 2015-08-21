namespace BitArrayCheck
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong numb;

        public BitArray64(ulong numb)
        {
            this.Number = numb;
        }

        public ulong Number { get; set; }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }

                return (int)(this.Number >> index) & 1;
            }

            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value");
                }

                if (((int)(this.Number >> index) & 1) != value)
                {
                    this.Number ^= 1ul << index;
                }
            }
        }

        public static bool operator ==(BitArray64 n1, BitArray64 n2)
        {
            return n1.Number.Equals(n2.Number);
        }

        public static bool operator !=(BitArray64 n1, BitArray64 n2)
        {
            return !n1.Number.Equals(n2.Number);
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray64).Number);
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return this[pos];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 63; i >= 0; i--)
            {
                if (i < 63 && i % 4 == 3)
                {
                    result.Append(" ");
                }

                result.Append(this[i]);
            }

            return result.ToString();
        }
    }
}
