using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double width, double height) : base(color)
    {
        _length = height;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}