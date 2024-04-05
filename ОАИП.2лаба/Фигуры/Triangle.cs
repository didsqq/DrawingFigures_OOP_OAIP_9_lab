using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП._2лаба.Фигуры
{
    internal class Triangle : Polygon
    {
        public Triangle(int x, int y, int w, int z)
          : base(x, y, w, 3, z)
        {
        }
    }
}
