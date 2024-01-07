namespace FiguresUnitTests.WorkersTests;

[TestFixture]
public class FiguresWorkerTests
{
    private readonly FigureWorker _worker = FigureWorker.GetInstance();
    
    [Test]
    public void Ctor_CreatingAnotherWorker_VariablesArePointingToTheSameObject()
    {
        var worker2 = FigureWorker.GetInstance();
        
        Assert.AreSame(_worker, worker2);
    }
    
    [Test]
    public void GetSquare_IFigureObjectProvided_ReturnsSquareOfFigure()
    {
        var figure = new Circle(2);

        var square = _worker.GetSquare(figure);
        
        Assert.AreEqual(4 * Math.PI, square);
    }

    [Test]
    public void GetSquare_IRectangleFigureObjectProvided_ReturnsSquareOfFigure()
    {
        var figure = new Triangle(3, 4, 5);

        var square = _worker.GetSquare(figure);
        
        Assert.AreEqual(6, square);
    }

    [Test]
    public void IsRectangular_INonRectangleObjectProvided_ThrowsAnException()
    {
        var figure = new Circle(1);

        Assert.Throws<ArgumentException>(() => _worker.IsRectangular(figure));
    }

    [Test]
    public void IsRectangular_NonRectangleTriangleProvided_ReturnsFalse()
    {
        var figure = new Triangle(2, 3, 4);

        Assert.IsFalse(_worker.IsRectangular(figure));
    }

    [Test]
    public void IsRectangular_RectangleTriangleProvided_ReturnsTrue()
    {
        var figure = new Triangle(3, 4, 5);
        
        Assert.IsTrue(_worker.IsRectangular(figure));
    }
}
