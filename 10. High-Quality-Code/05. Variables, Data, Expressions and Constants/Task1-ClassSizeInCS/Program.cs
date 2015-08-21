using System;

public class Size
{
    private double width, height;

    public Size(double w, double h)
    {
        this.width = w;
        this.height = h;
    }

    public static Size GetRotatedSize(
        Size s, double angle)
    {
        return new Size(
            Math.Abs(Math.Cos(angle)) * s.width + Math.Abs(Math.Sin(angle)) * s.height,
            Math.Abs(Math.Sin(angle)) * s.width + Math.Abs(Math.Cos(angle)) * s.height);
    }
}