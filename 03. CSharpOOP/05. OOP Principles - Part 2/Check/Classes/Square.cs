namespace ShapeProject.Classes
{
    public class Square : Shape
    {
        public Square(float a)
        {
            this.Height = a;
            this.Width = a;
        }

        public override float CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
