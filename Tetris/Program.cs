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

           

            Square s = new Square(2, 4, '*');
            s.Draw();
            s.Hide();
            s.Moves(Direction.Right);            
            s.Draw();

            //Stick stick = new Stick(1, 6, '*');
            //stick.Draw();
            
            

            Console.ReadLine();
        }

    }
}
 