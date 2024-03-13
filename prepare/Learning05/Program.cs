using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.SetColor("blue");
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle();
        rectangle.SetColor("purple");
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle();
        circle.SetColor("green");
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        List<IShape> shapes = new List<IShape>();
        shapes.Add(square);
    }
}