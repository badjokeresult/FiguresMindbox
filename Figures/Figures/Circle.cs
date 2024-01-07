using System;

namespace Figures.Figures;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius < 0)
            throw new ArgumentException(nameof(radius), "Radius cannot be less than zero");
        
        _radius = radius;
    }

    public double Radius => _radius;

    public double GetSquare() => Math.PI * _radius * _radius;
}
