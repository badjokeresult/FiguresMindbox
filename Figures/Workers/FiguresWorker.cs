using Figures.Figures;

namespace Figures.Workers;

public class FigureWorker
{
    private readonly IFigure _figure;

    public FigureWorker(IFigure figure)
    {
        _figure = figure;
    }

    public double GetSquare() => _figure.GetSquare();
}