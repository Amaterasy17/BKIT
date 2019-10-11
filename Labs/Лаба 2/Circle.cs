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
            return "Радиус круга:"+Rad.ToString() + " Площадь: "+ a.ToString();
        }

        public  void Print()
        {
           Console.WriteLine(this.ToString());
        }
    }
}
