using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("Red", 2);
        shapes.Add(s1);
        Circle c1 = new Circle("Blue", 3);
        shapes.Add(c1);
        Rectangle r1 = new Rectangle("Green", 4, 5);
        shapes.Add(r1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea()}");
        }
    }
}