using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2
{
    public class Square : Rectangle,IPrint
    {
        public override double Area()
        {
            return L * L;
        }
        public Square(double l)
        {
            L = l;
            H = l;
        }
        public override string ToString()
        {
            double a = Area();
            return "Длина стороны квадрата: " + L.ToString() + " Площадь: " + a.ToString() ;
        }
        public new void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
