namespace Stools
{
    using System;

    public class Program
    {
        internal class Stool
        {
            public Stool(int x, int y, int z)
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }

            public int X { get; set; }

            public int Y { get; set; }

            public int Z { get; set; }
        }

        private static Stool[] stools;
        private static int[,,] memo;
        private static int n;

        public static void Main()
        {
            n = int.Parse(Console.ReadLine());
            memo = new int[1 << n, n, 3];
            stools = new Stool[n];

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                stools[i] = new Stool(int.Parse(line[0]), int.Parse(line[1]), int.Parse(line[2]));
            }

            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result = Math.Max(result, MaxHeight((1 << n) - 1, i, 0));
                result = Math.Max(result, MaxHeight((1 << n) - 1, i, 1));
                result = Math.Max(result, MaxHeight((1 << n) - 1, i, 2));
            }

            Console.WriteLine(result);
        }

        private static int MaxHeight(int used, int top, int side)
        {
            if (memo[used, top, side] != 0)
            {
                return memo[used, top, side];
            }

            if (used == (1 << top))
            {
                switch (side)
                {
                    case 0: return stools[top].X;
                    case 1: return stools[top].Y;
                    case 2: return stools[top].Z;
                }
            }

            int sizeX = 0, sizeY = 0, sizeH = 0;
            switch (side)
            {
                case 0:
                    {
                        sizeX = stools[top].Y;
                        sizeY = stools[top].Z;
                        sizeH = stools[top].X;
                        break;
                    }
                case 1:
                    {
                        sizeX = stools[top].X;
                        sizeY = stools[top].Z;
                        sizeH = stools[top].Y;
                        break;
                    }
                case 2:
                    {
                        sizeX = stools[top].Y;
                        sizeY = stools[top].X;
                        sizeH = stools[top].Z;
                        break;
                    }
            }

            var fromStools = used ^ (1 << top);
            var result = sizeH;

            for (int i = 0; i < n; i++)
            {
                if (((fromStools >> i) & 1) == 1)
                {
                    if ((stools[i].Y >= sizeX && stools[i].Z >= sizeY) ||
                        (stools[i].Z >= sizeX && stools[i].Y >= sizeY))
                    {
                        result = Math.Max(result, MaxHeight(fromStools, i, 0) + sizeH);
                    }

                    // if is cube
                    if (stools[i].X == stools[i].Y && stools[i].Y == stools[i].Z)
                    {
                        continue;
                    }

                    if ((stools[i].X >= sizeX && stools[i].Z >= sizeY) ||
                        (stools[i].Z >= sizeX && stools[i].X >= sizeY))
                    {
                        result = Math.Max(result, MaxHeight(fromStools, i, 1) + sizeH);
                    }

                    if ((stools[i].Y >= sizeX && stools[i].X >= sizeY) ||
                        (stools[i].X >= sizeX && stools[i].Y >= sizeY))
                    {
                        result = Math.Max(result, MaxHeight(fromStools, i, 2) + sizeH);
                    }
                }
            }

            memo[used, top, side] = result;
            return result;
        }
    }
}
