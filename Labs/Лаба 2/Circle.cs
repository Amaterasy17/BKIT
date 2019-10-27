using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2
{
    class Circle : GeomFigure,IPrint
    {
        public double Rad
        {
            get; set;
        }
        public override double Area()
        {
            return Math.PI * Rad * Rad;
        }
        public Circle(double R)
        {
            Rad = R;
        }
        public Circle() { }
        public override string ToString()
        {
            double a;
            a = Area();
            string output = String.Format($"{a:N3}");
            return "Радиус круга:" + Rad.ToString() + " Площадь: "+ output;
        }

        public  void Print()
        {
           Console.WriteLine(this.ToString());
        }
    }
}
