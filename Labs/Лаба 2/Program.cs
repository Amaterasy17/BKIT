using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square a = new Square(4);
            Circle c = new Circle(10);
            Rectangle b = new Rectangle(5, 6);
            a.Print();
            b.Print();
            c.Print();
            Console.ReadKey();
        }
    }
}
