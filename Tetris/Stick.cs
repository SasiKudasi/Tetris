using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Stick : Figure
    {
      

        public Stick(int x, int y, char sym) 
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y+1, sym);
            points[2] = new Point(x, y+2, sym);
            points[3] = new Point(x, y+3, sym);
        }

        public override void Rotate()
        {
            foreach (Point p in points)
            {
                points[0] = new Point(p.x, p.y, p.c);
                points[1] = new Point(p.x+1, p.y , p.c);
                points[2] = new Point(p.x+2, p.y , p.c);
                points[3] = new Point(p.x+3, p.y , p.c);
            }
        }


    }
}
