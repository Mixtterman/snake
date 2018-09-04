using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> plist;

        public VerticalLine(int x, int ytop, int ybottom, char sym)
        {
            plist = new List<Point>();
            for (int y = ytop; y <= ybottom; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }

        public void drow()
        {
            foreach (Point p in plist)
            {
                p.draw();
            }
        }
    }
}
