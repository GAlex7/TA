namespace Labirint
{
    public class Point
    {
        public Point(int r = 0, int c = 0)
        {
            this.Row = r;
            this.Col = c;
        }

        public int Row { get; set; }

        public int Col { get; set; }
    }
}
