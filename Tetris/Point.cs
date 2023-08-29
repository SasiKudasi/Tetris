using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Point
    {
       public int x;
       public int y;
       public char c;

      public  void Draw()
        {
            Console.SetCursorPosition(x, y);

            Console.Write(c);
        }

        internal void Moves(Direction direction)
        {
            switch(direction)
            {
                case Direction.Down:
                    
                    y += 5;
                    break;
                case Direction.Left: 
                    x -= 5;
                    break;
                case Direction.Right:
                    x += 5;
                    break;

            }
        }

        internal void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");           

        }

        public virtual void Rotate()
        {
            x -= 1; 
            y += 1;
        }

        public Point(int a, int b, char sym)
        {
            x = a;
            y = b; 
            c = sym;
        }

        public Point() { }
       

    }
}
