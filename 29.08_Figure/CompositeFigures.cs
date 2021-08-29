using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._08_Figure
{
    public class CompositeFigures
    {
        
        Figure[] figures;
        public CompositeFigures(params Figure[] figures)
        {

            this.figures = figures;

        }
        
        public  double Area()
        {
            double area = 0;
            for (int i = 0; i < figures.Length; i++)
            {
                area += figures[i].Area();
            }
            return area;
        }
        public void PrintFigure()
        {
            Console.WriteLine($" Площадь составной фигуры {Area()}");
        }
    }
}
