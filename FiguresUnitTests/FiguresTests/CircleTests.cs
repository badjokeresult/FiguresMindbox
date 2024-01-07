namespace FiguresUnitTests.FiguresTests;

[TestFixture]
public class CircleTests
{
    [Test]
    public void Ctor_RadiusIsLessThanZero_ThrowsAnException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }

    [TestCase(0)]
    [TestCase(1)]
    [Test]
    public void Ctor_RadiusIsEqualOrMoreThanZero_CircleObjIsCreated(double radius)
    {
        var circle = new Circle(radius);
        
        Assert.IsNotNull(circle);
    }

    [Test]
    public void GetSquare_RadiusIsEqualToFive_ReturnsCircleSquare()
    {
        var circle = new Circle(5);

        var square = circle.GetSquare();
        
        Assert.AreEqual(Math.PI * 25, square);
    }
}
