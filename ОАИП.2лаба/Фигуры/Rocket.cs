using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП._2лаба.Фигуры
{
    public class Rocket : Figure
    {
        private Rectangle rectangle;
        private Square square1;
        private Square square2;
        private MinePolygon polygon;
        private int n;
        private Point[] points;
        private Circle circle;
        public Rocket(int x, int y, int l, int h)
        {
            this.x = x;
            this.y = y;
            this.l = l;
            this.h = h;
            square1 = new Square(x, y + h -(h/3), l / 3 );
            square2 = new Square(x + 2*(l/3), y + h - (h / 3), l / 3);
            rectangle = new Rectangle(x, y + h - 2 *(h/3), l, h / 3);
            circle = new Circle(x + l/3, y +h - 2 *(h/3), l / 3, "");
            points = new Point[3];
            points[0] = new Point(x, y + h - 2*(h/3));
            points[1] = new Point(x + l, y + h - 2 * (h / 3));
            points[2] = new Point(x + l/2, y);
            polygon = new MinePolygon(points, n);
            n = 3; 

        }

        public Rocket()
        {
            x = 0;
            y = 0;
            l = 0;
            h = 0;
            square1 = new Square(x, y + h - (h / 3), l / 3);
            square2 = new Square(x + 2 * (l / 3), y + h - (h / 3), l / 3);
            rectangle = new Rectangle(x, y + h - 2 * (h / 3), l, h / 3);
            circle = new Circle(x + l / 3, y + h - 2 * (h / 3), l / 3, "");
            points = new Point[3];
            points[0] = new Point(x, y + h - 2 * (h / 3));
            points[1] = new Point(x + l, y + h - 2 * (h / 3));
            points[2] = new Point(x + l / 2, y);
            polygon = new MinePolygon(points, n);
            n = 3;
        }

        public override void Draw()
        {
            square1 = new Square(x, y + h - (h / 3), l / 3);
            square2 = new Square(x + 2 * (l / 3), y + h - (h / 3), l / 3);
            rectangle = new Rectangle(x, y + h - 2 * (h / 3), l, h / 3);
            circle = new Circle(x + l / 3, y + h - 2 * (h / 3), l / 3, "");
            points = new Point[3];
            points[0] = new Point(x, y + h - 2 * (h / 3));
            points[1] = new Point(x + l, y + h - 2 * (h / 3));
            points[2] = new Point(x + l / 2, y);
            polygon = new MinePolygon(points, n);
            polygon = new MinePolygon(points, n);
            Graphics.FromImage((Image)Init.bitmap);
            circle.Draw();
            square1.Draw();
            square2.Draw();
            rectangle.Draw();
            polygon.Draw();
            Init.pictureBox.Image = Init.bitmap;
        }
    }
}