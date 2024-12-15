public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public Rectangle(string color, double len, double wid) : base(color)
    {
        _length = len;
        _width = wid;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}