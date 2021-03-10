using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOO
{

    struct Point
    {
        public Point (double x, double y)
        {
            X = x;
            Y = y;
        }

        public readonly double X;
        public readonly double Y;
    }

    class Line
    {

        private double k;
        private double l;

        public Line(double k, double l)
        {
            this.k = k;
            this.l = l;
        }

        public Point? Intersection(Line second_line)
        {
            if (k == second_line.k)
                return null;

            double x = (second_line.l - l) / (k - second_line.k);
            double y = k * x + l;

            return new Point(x, y);
           
        }
    }
}
