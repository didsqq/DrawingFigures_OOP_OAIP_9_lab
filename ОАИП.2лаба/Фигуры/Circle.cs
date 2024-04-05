using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП._2лаба.Фигуры
{
    internal class Circle : Ellipse
    {
        public Circle(int x, int y, int l, string name)
          : base(name, l, l, x, y)
        {
        }
    }
}
