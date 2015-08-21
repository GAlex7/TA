namespace ShapeProject.Classes
{
    public class Triangle : Shape
    {
        public Triangle(float triangeBase, float height)
        {
            this.Width = triangeBase;
            this.Height = height;
        }

        public override float CalculateSurface()
        {
            return this.Width * this.Height / 2;
        }
    }
}
