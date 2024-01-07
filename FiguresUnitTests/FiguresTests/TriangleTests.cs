namespace FiguresUnitTests.FiguresTests;

[TestFixture]
public class TriangleTests
{
    [TestCase(-1, 1, 1)]
    [TestCase(1, -1, 1)]
    [TestCase(1, 1, -1)]
    [Test]
    public void Ctor_OneSideIsNegative_ThrowsAnException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [TestCase(1)]
    [TestCase(1, 1)]
    [TestCase(1, 1, 1, 1)]
    [Test]
    public void Ctor_LessOrMoreThanThreeSidesProvided_ThrowsAnException(params double[] sides)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sides));
    }

    [Test]
    public void Ctor_ThreePositiveSidesProvided_TriangleObjIsCreated()
    {
        var triangle = new Triangle(2, 3, 4);
        
        Assert.IsNotNull(triangle);
    }

    [Test]
    public void GetSquare_NonRectangleTriangleWithSidesTwoThreeFour_ReturnsTwoPointNine()
    {
        var triangle = new Triangle(2, 3, 4);

        var actualSquare = triangle.GetSquare();
        var expectedSquare = Math.Sqrt(4.5 * 2.5 * 1.5 * .5);

        Assert.AreEqual(expectedSquare, actualSquare);
        Assert.IsFalse(triangle.IsRectangular());
    }

    [Test]
    public void GetSquare_RectangleTriangleWithSidesThreeFourFive_ReturnsSix()
    {
        var triangle = new Triangle(3, 4, 5);

        var actualSquare = triangle.GetSquare();
        
        Assert.AreEqual(6, actualSquare);
        Assert.IsTrue(triangle.IsRectangular());
    }
}