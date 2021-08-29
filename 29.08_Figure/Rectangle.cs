using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._08_Figure
{
    public class Rectangle : Figure
    {
        double a, b;
        string name;
        public Rectangle(string name,double a, double b)
        {
            this.name = name;
            this.a = a;
            this.b = b;
        }
        public override double Area()
        {
            return a*b;
        }

        public override double Perimetr()
        {
            return 2 * (a + b);
        }

        public override void PrintFigure()
        {
            Console.WriteLine($" Площадь {name}а {Area()}\n Периметр {name}а {Perimetr()}\n");
        }
    }
}
