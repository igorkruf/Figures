using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._08_Figure
{
    public class Triangle : Figure
    {
        double a, b, c;
        string name;
        public Triangle (string name,double a, double b, double c) 
        {
            this.name = name;
            this.a = a;
            this.b = b;
            this.c = c;
        } 

        public override double Perimetr()
        {
            return a + b + c;
        }

        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt((p * (p - a )* (p - b) * (p - c)));
        }
        public override void PrintFigure()
        {
            Console.WriteLine($" Площадь {name}а {Area()}\n Периметр {name}а {Perimetr()}\n");
        }
    }
}
