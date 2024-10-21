using System;

namespace areaShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Square sqShape = new Square("Blue", 5);
            shapes.Add(sqShape);

            Rectangle recShape = new Rectangle("Red", 6, 8);
            shapes.Add(recShape);

            Circle cirShape = new Circle("Pink", 3);
            shapes.Add(cirShape);


            DiplayShapeInformation(sqShape);
            DiplayShapeInformation(recShape);
            DiplayShapeInformation(cirShape);
        }

        public static void DiplayShapeInformation(Shape shape)
        {
            double area = shape.GetArea();
            Console.WriteLine($"{shape.GetColor()} shape's area is: {area}.");

        }
    }
}