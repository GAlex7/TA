namespace ShapeProject.Classes
{
    public class Rectangle : Shape
    {
        public Rectangle(float width, float height)
        {
            this.Height = height;
            this.Width = width;
        }

        public override float CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
