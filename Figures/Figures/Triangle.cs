namespace Figures.Figures;

public enum TriangleSideName
{
    SideA,
    SideB,
    SideC
}

public readonly struct TriangleSides
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public TriangleSides(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double SideA => _sideA;
    public double SideB => _sideB;
    public double SideC => _sideC;

    public TriangleSideName? CheckIfSideIsHypotenuse()
    {
        if (Math.Pow(_sideA, 2).Equals(Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2)))
            return TriangleSideName.SideA;

        if (Math.Pow(_sideB, 2).Equals(Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2)))
            return TriangleSideName.SideB;

        if (Math.Pow(_sideC, 2).Equals(Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2)))
            return TriangleSideName.SideC;

        return null;
    }

    public double GetSidesPerimeter() => _sideA + _sideB + _sideC;
}

public class Triangle : IFigure
{
    private readonly TriangleSides _sides;

    public Triangle(params double[] sides)
    {
        if (sides.Length != 3)
            throw new ArgumentOutOfRangeException(nameof(sides), "Exactly three parameters should be provided");

        _sides = new TriangleSides(sides[0], sides[1], sides[2]);
    }

    public TriangleSides Sides => _sides;

    public double GetSquare()
    {
        var hypotenuseSideName = _sides.CheckIfSideIsHypotenuse();

        if (hypotenuseSideName != null)
            return GetSquareIfRectangular(hypotenuseSideName!.Value);
        return GetSquareIfNotRectangular();
    }

    private double GetSquareIfRectangular(TriangleSideName triangleSideName)
    {
        switch (triangleSideName)
        {
            case TriangleSideName.SideA:
                return _sides.SideB * _sides.SideB / 2;
            case TriangleSideName.SideB:
                return _sides.SideA * _sides.SideC / 2;
            case TriangleSideName.SideC:
                return _sides.SideA * _sides.SideB / 2;
            default:
                return 0;
        }
    }

    private double GetSquareIfNotRectangular()
    {
        var halfPerimeter = _sides.GetSidesPerimeter() / 2;

        var powedSquare = halfPerimeter
                          * (halfPerimeter - _sides.SideA)
                          * (halfPerimeter - _sides.SideB)
                          * (halfPerimeter - _sides.SideC);
        
        return Math.Sqrt(powedSquare);
    }
}