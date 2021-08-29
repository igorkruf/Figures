using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._08_Figure
{
    public class Circle : Figure
    {
        double r;
        string name;
        public Circle(string name, double r)
        {
            this.name = name;
            this.r = r;
        }
        public override double Area()
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        public override double Perimetr()
        {
            return 2 * Math.PI*r;
        }

        public override void PrintFigure()
        {
            Console.WriteLine($" Площадь {name}а {Area()}\n Периметр {name}а {Perimetr()}\n");
        }
    }
}
