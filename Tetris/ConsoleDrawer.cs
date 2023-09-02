using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class ConsoleDrawer : IDrawer
    {
       public const char DEFAULT_SYMBOL = '*';
        public void DrawPoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('*');
            Console.SetCursorPosition(0, 0);
        }

        public void HidePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
            Console.SetCursorPosition(0, 0);
        }

        public void InitField()
        {
            Console.SetWindowSize(Field.Widht, Field.Height);
            Console.SetBufferSize(Field.Widht, Field.Height);
        }

        public void WriteGameOver()
        {
            {
                Console.SetCursorPosition(Field.Widht / 2 - 8, Field.Height / 2);
                Console.WriteLine(" G A M E O V E R");
            }
        }
    }
}
