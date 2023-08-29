using System;
using System.Reflection;

namespace Tetris
{
    public class Square : Figure
    {
       
        public Square (int x, int y, char sym) 
        {
                       

            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y + 1, sym);
            points[2] = new Point(x+1, y+1, sym);
            points[3] = new Point(x+1, y, sym);

        }

        public override void Rotate()
        {
            foreach (Point p in points)
            {
                points[0] = new Point(p.x +1, p.y + 1, p.c);
                points[1] = new Point(p.x + 1, p.y, p.c);
                points[2] = new Point(p.x, p.y+1, p.c);
                points[3] = new Point(p.x, p.y, p.c);
            }
        }

    }
}