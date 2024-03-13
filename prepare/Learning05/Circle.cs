using System;

public class Circle : IShape
{
    private string _color;

    public void SetColor(string color)
    {
        _color = color;
    }
    
    public string GetColor()
    {
        return _color;
    }

    private double _radius = 10;

    public double GetArea()
    {
        return 3.14 * Math.Pow(_radius,2);
    }
}