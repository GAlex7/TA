namespace Check.Space
{
    using System;

    public struct Point3D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        private static readonly Point3D startPoint;

        public Point3D(float x, float y, float z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D StartPoint
        {
            get
            {
                return startPoint;
            }
        }

        static Point3D()
        {
            startPoint = new Point3D(0, 0, 0);
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }
    }
}
