﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Figure 
    {
        

      protected  Point[] points = new Point[4];

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }


        public void Hide()
        {
            foreach(Point p in points)
            {
                p.Hide();
            }
        }

        public void Moves (Direction direction)
        {
            foreach(Point p in points)
            {
                p.Moves(direction);
            }
        }
        public virtual void Rotate()
        {
            foreach (Point p in points)
            {
                p.Rotate();
            }
        }

    }
}
