using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2
{
    
        public abstract class GeomFigure:IComparable
        {
            public abstract double Area();

        public int CompareTo(object obj)
        {
            GeomFigure a = obj as GeomFigure;
         if(this.Area()<a.Area())
            {
                return -777;
            }
          else  if (this.Area() == a.Area())
            {
                return 0;
    }
            else
            {
                return 777;
            }
        }

       
    }
   
}
