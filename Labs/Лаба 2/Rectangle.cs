using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2
{
    public class Rectangle : GeomFigure,IPrint
    {

        public double L
        { get; set; }
        public double H { get; set; }
        public override double Area()
        {
            return L * H;
        }
        public Rectangle(double l, double h)
        {
            L = l;
            H = h;
        }
        public Rectangle()
        {

        }
        public override string ToString()
        {
            double a = Area();
            return "Длина: " + L.ToString() + " Высота: " + H.ToString() + " Площадь: " + a.ToString();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
