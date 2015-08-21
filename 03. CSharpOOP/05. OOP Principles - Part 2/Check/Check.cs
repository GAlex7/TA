namespace ShapeProject
{
    using System;

    using Classes;

    public class Check
    {
        public static void Main()
        {
            var shapesArr = new Shape[3];

            shapesArr[0] = new Triangle(4, 3);
            shapesArr[1] = new Rectangle(5, 6);
            shapesArr[2] = new Square(7);

            foreach (var shape in shapesArr)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
