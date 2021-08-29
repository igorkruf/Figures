using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._08_Figure
{
    public class Square : Figure
    {
        double a;
        string name;
        public Square(string name,double a)
        {
            this.name = name;
            this.a = a;
        }
        public override double Area()
        {
            return Math.Pow(a,2);
        }

        public override double Perimetr()
        {
            return 4 * a;
        }

        public override void PrintFigure()
        {
            Console.WriteLine($" Площадь {name}а {Area()}\n Периметр {name}а {Perimetr()}\n");
        }
    }
}
