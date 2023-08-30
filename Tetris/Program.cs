using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            FigureGenerator figureGenerator = new FigureGenerator(20, 0, '*');

            Figure currentFigure = figureGenerator.Generate();
                      

            while (true)
            {
                if(Console.KeyAvailable)
                {
                   var key = Console.ReadKey();
                   HandleKey(currentFigure, key);
                }

            }                                          
        }

        private static void HandleKey(Figure currentFigure, ConsoleKeyInfo key)
        {
           switch( key.Key)
            {
                case ConsoleKey.LeftArrow:
                    currentFigure.Moves(Direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    currentFigure.Moves(Direction.Right);
                    break;
                case ConsoleKey.DownArrow:
                    currentFigure.Moves(Direction.Down);
                    break;
            }
        }
    }

}
 