using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40,30);

            Figure[] figures = new Figure[2];
            figures[0] = new Square(2, 4, '*');
            figures[1] = new Stick(1, 6, '*');


            Square s = new Square(2, 4, '*');
            s.Draw();

            Stick stick = new Stick(1, 6, '*');
            stick.Draw();

            Console.ReadLine();
        }

    }
}
 