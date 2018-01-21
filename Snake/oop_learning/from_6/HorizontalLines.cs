using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_learning
{
    class HorizontalLines
    {
        List<Point> pList;

        public HorizontalLines()
        {
            pList = new List<Point>();
            Point p1 = new Point(4, 4, '*');
            Point p2 = new Point(4, 5, '*');
            Point p3 = new Point(4, 6, '*');
        }
    }
}
