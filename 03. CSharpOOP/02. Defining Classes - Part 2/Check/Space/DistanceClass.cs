namespace Check.Space
{
    using System;

    using Space;

    public static class Distance
    {
        public static double CalcDist(Point3D m, Point3D n)
        {
            return Math.Sqrt(
                (m.X - n.X) * (m.X - n.X) +
                (m.Y - n.Y) * (m.Y - n.Y) +
                (m.Z - n.Z) * (m.Z - n.Z));
        }
    }
}
