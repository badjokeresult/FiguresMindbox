using Figures.Figures;

namespace Figures.Workers;

public class FigureWorker
{
    private static readonly Lazy<FigureWorker> _figureWorker =
        new Lazy<FigureWorker>(() => new FigureWorker());

    public double GetSquare(IFigure figure) => figure.GetSquare();

    public bool IsRectangular(IFigure figure)
    {
        if (figure is IRectangleFigure rectangleFigure)
            return rectangleFigure.IsRectangular();
        throw new ArgumentException("This type of object cannot be rectangle or not", nameof(figure));
    }

    public static FigureWorker GetInstance() => _figureWorker.Value;
}