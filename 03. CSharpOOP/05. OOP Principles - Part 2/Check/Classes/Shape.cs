// Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.

namespace ShapeProject.Classes
{
    public abstract class Shape
    {
        private float width;
        private float height;

        public float Width { get; set; }

        public float Height { get; set; }

        public abstract float CalculateSurface();
    }
}
