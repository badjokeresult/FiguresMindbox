namespace Figures.Figures;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double Radius => _radius;

    public double GetSquare() => Math.PI * _radius * _radius;
}
