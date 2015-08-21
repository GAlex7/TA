using System;

namespace CohesionAndCoupling
{
    public static class Parallelepiped
    {
        public static double Width { get; set; }

        public static double Height { get; set; }
        
        public static double Depth { get; set; }

        public static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        public static double CalcDiagonalXYZ()
        {
            double distance = SpaceUtils.CalcDistance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        public static double CalcDiagonalXY()
        {
            double distance = SpaceUtils.CalcDistance2D(0, 0, Width, Height);
            return distance;
        }

        public static double CalcDiagonalXZ()
        {
            double distance = SpaceUtils.CalcDistance2D(0, 0, Width, Depth);
            return distance;
        }

        public static double CalcDiagonalYZ()
        {
            double distance = SpaceUtils.CalcDistance2D(0, 0, Height, Depth);
            return distance;
        }
    }
}
