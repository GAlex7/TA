namespace FibonacciByMatrix
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine(PowMod(new Matrix(1, 1, 1, 0), n).Table[0, 1]);
        }

        private static Matrix PowMod(Matrix a, long p)
        {
            if (p == 1)
            {
                return a;
            }

            if (p % 2 == 1)
            {
                return new Matrix(PowMod(a, p - 1), a);
            }

            var b = PowMod(a, p / 2);

            return new Matrix(b, b);
        }
    }

    internal class Matrix
    {
        private const int Mod = 1000000007;
        public long[,] Table { get; set; }

        public Matrix(Matrix a, Matrix b)
        {
            this.Table = new long[2, 2];

            this.Table[0, 0] = a.Table[0, 0] * b.Table[0, 0] +
                               a.Table[0, 1] * b.Table[1, 0];

            this.Table[0, 1] = a.Table[0, 0] * b.Table[0, 1] +
                               a.Table[0, 1] * b.Table[1, 1];

            this.Table[1, 0] = a.Table[1, 0] * b.Table[0, 0] +
                               a.Table[1, 1] * b.Table[1, 0];

            this.Table[1, 1] = a.Table[1, 0] * b.Table[0, 1] +
                               a.Table[1, 1] * b.Table[1, 1];

            this.Table[0, 0] = this.Table[0, 0] % Mod;
            this.Table[0, 1] = this.Table[0, 1] % Mod;
            this.Table[1, 0] = this.Table[1, 0] % Mod;
            this.Table[1, 1] = this.Table[1, 1] % Mod;
        }

        public Matrix(long a00, long a01, long a10, long a11)
        {
            this.Table = new long[2, 2];

            this.Table[0, 0] = a00;
            this.Table[0, 1] = a01;
            this.Table[1, 0] = a10;
            this.Table[1, 1] = a11;
        }

    }
}
