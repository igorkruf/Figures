using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _29._08_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.5, b = 3.5, c = 4.5;
            Triangle tr = new Triangle("Треугольник",a, b, c);
            tr.PrintFigure();
            
            double sq = 3.2;
            Square square = new Square("Квадрат",sq);
            square.PrintFigure();

            double width = 5.2, height = 6.5;
            Rectangle rectangle = new Rectangle("Прямоугольник",width, height);
            rectangle.PrintFigure();

            double radius = 2.7;
            Circle circle = new Circle("Круг",radius);
            circle.PrintFigure();

            Figure[] figures =
            {
                tr,square,rectangle,circle
            };
            CompositeFigures figures1 = new CompositeFigures(figures);
            figures1.PrintFigure();
        }
    }
}
