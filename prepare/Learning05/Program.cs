using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        
        square.SetColor("blue");
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
    }
}