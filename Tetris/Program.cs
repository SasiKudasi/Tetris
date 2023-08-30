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
            FigureGenerator figureGenerator = new FigureGenerator(20, 0, '*');

            Figure figure;

           


            while (true)
            {
                figure = figureGenerator.Generate();
                figure.Draw();


                for (int i = 0; i < 7; i++)
                {
                    Thread.Sleep(500);
                    figure.Hide();
                    figure.Moves(Direction.Down);
                    figure.Draw();
                    Thread.Sleep(500);
                }


            }
                    
            
            Console.ReadLine();
        }

    }

}
 