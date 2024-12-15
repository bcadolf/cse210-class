using System.Net.NetworkInformation;

public class Circle : Shape
{
    private double _radius;
    public Circle(double rad, string color) : base(color)
    {
        _radius = rad;
    }
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}