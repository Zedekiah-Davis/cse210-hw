public class Square : IShape
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

    private double _side = 10;

    public double GetArea()
    {
        return _side * _side;
    }
}