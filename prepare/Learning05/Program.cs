using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Blue", 4);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Green", 7, 5);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Violet", 9);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}