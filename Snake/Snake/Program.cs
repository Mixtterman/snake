using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,1,'*');  
            p1.draw();

            Point p2 = new Point(1,2,'#');
            p2.draw();

            HorizontalLine line1 = new HorizontalLine(5, 30, 8, '@' );
            line1.drow();

            VerticalLine line2 = new VerticalLine(1, 8, 25, '*');
            line2.drow();

            Console.ReadLine();
        }
    }
}
