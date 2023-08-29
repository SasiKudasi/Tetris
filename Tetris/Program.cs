using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40,30);



            Square s = new Square(2, 4, '*');
            s.Draw();
            Thread.Sleep(1000);
            s.Hide();
            s.Moves(Direction.Right);
            s.Draw();
            Thread.Sleep(1000);
            s.Hide();
            s.Rotate();
            s.Draw();



            Stick stick = new Stick(1, 6, '*');
            stick.Draw();
            Thread.Sleep(1000);
            stick.Hide();
            stick.Moves(Direction.Right);
            stick.Draw();
            Thread.Sleep(1000);
            stick.Hide();
            stick.Rotate();
            stick.Draw();



            Console.ReadLine();
        }

    }
}
 