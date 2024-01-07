// See https://aka.ms/new-console-template for more information

using Figures.Figures;
using Figures.Workers;

// Setting variables
IFigure nonRectangleTriangleFigure = new Triangle(2, 3, 4);
IFigure rectangleTriangleFigure = new Triangle(3, 4, 5);
IFigure circleFigure = new Circle(5);

// Setting workers
var figureWorker = FigureWorker.GetInstance();

// Calculating squares
Console.WriteLine($"Non-rectangle triangle square : {figureWorker.GetSquare(nonRectangleTriangleFigure)}");
Console.WriteLine($"Rectangle triangle square : {figureWorker.GetSquare(rectangleTriangleFigure)}");
Console.WriteLine($"Circle square : {figureWorker.GetSquare(circleFigure)}");
