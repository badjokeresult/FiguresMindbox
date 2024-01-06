// See https://aka.ms/new-console-template for more information

using Figures.Figures;
using Figures.Workers;

// Setting variables
IFigure nonRectangleTriangleFigure = new Triangle(2, 3, 4);
IFigure rectangleTriangleFigure = new Triangle(3, 4, 5);
IFigure circleFigure = new Circle(5);

// Setting workers
var nonRectangleTriangleWorker = new FigureWorker(nonRectangleTriangleFigure);
var rectangleTriangleWorker = new FigureWorker(rectangleTriangleFigure);
var circleWorker = new FigureWorker(circleFigure);

// Calculating squares
Console.WriteLine($"Non-rectangle triangle square : {nonRectangleTriangleWorker.GetSquare()}");
Console.WriteLine($"Rectangle triangle square : {rectangleTriangleWorker.GetSquare()}");
Console.WriteLine($"Circle square : {circleWorker.GetSquare()}");
