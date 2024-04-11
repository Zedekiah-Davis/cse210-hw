public class Rectangle : IShape
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

    private double _length = 10;

    private double _width = 15;

    public double GetArea()
    {
        return _width * _length;
    }
}