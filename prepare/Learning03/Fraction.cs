using System.Dynamic;
using System.IO.Compression;
using System.Reflection.Metadata.Ecma335;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetTop()
    {
        Console.WriteLine(_top);
    }
    public int SetTop(int top)
    {
        int num = top;
        return num;
    }
    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }
    public int SetBottom(int bottom)
    {
        int num = bottom;
        return num;
    }

    public string DisplayFraction()
    {
        string fracText = $"{_top}/{_bottom}";
        return fracText;
    }
    public double DisplayDecimal()
    {
        return (double)_top / (double)_bottom;
    }




}