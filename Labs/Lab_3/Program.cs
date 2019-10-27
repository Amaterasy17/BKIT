using System;
using Лаба_2;

using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Circle cir = new Circle(2);
            Square sq = new Square(20);
            Rectangle rec = new Rectangle(10, 5);
            list.Add(cir);
            list.Add(sq);
            list.Add(rec);
            foreach (GeomFigure i in list)
            {
                Console.WriteLine($"{i.Area():N3}"+" ");
            }
            Console.WriteLine("\n");
            List<GeomFigure> List = new List<GeomFigure>();
            List.Add(cir);
            List.Add(sq);
            List.Add(rec);
            List.Sort();
            foreach (GeomFigure i in List)
            {
                Console.WriteLine($"{i.Area():N3}");
            }
            Circle a = new Circle(0);
            Matrix <GeomFigure> matrix = new Matrix <GeomFigure>(2,2,2,a);
            matrix[0,0,0] = cir;
            matrix[0, 1, 0] = sq;
            matrix[0, 0, 1] = rec;
            Console.WriteLine(matrix.ToString());
            Console.ReadKey();
        }
    }
}
