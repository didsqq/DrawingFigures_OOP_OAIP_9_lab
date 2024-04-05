using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ОАИП._2лаба.Фигуры;

namespace ОАИП._2лаба
{
    internal class ShapeContainer
    {
        public static List<Figure> figureList = new List<Figure>();
        public static List<Figure> figureListRPN = new List<Figure>();
        public static void AddFigure(Figure figure)
        {
            figureList.Add(figure);
        }
        public static void AddFigureRPN(Figure figure)
        {
            figureListRPN.Add(figure);
        }
    }
}
