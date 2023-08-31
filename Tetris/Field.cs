using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    static public class Field
    {
       public static int _widht = 40;
        public static int _height = 30;

        public static int Widht
        {
            get { return _widht; }
            set { 
                _widht = value;
                Console.SetWindowSize(value, Field.Height);
                Console.SetBufferSize(value, Field.Height);
            }
        }
        public static int Height
        {
            get { return _height; }
            set
            {
                _widht = value;
                Console.SetWindowSize(Field.Widht, value);
                Console.SetBufferSize(Field.Widht, value);
            }
        }


        private static bool[][] _heap;

         static Field()
        {
            _heap = new bool[Height][];
            
            for (int i = 0; i < Height; i++)
            {
                _heap[i] = new bool[Widht];
            }
        }

        public static bool CheckStrike(Point p)
        {
            return _heap[p.Y][p.X];
        }
        public static void AddFigure(Figure fig)
        {
            foreach (var p in fig.Points)
            {
                _heap[p.Y][p.X] = true;
            }
        }
    }
}
