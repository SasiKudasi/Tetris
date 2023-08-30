using System;
using System.Threading;

namespace Tetris
{
    internal class FigureGenerator
    {
        private int _x;
        private int _y;
        private char _c;

        private Figure _figure;

        private Random _random = new Random();
        public FigureGenerator(int x, int y, char c)
        {
            _x = x;
            _y = y;
            _c = c;
        }

        

        public Figure Generate()
        {
            if( _random.Next(0, 2) == 0)
            {
                _figure = new Square(_x, _y, _c);
               
                for (int i = 0; i<5; i++)
                {
                    
                    _figure.Draw();
                    Thread.Sleep(1000);
                    _figure.Hide();
                    _figure.Moves(Direction.Down);
                    _figure.Draw();
                    Thread.Sleep(1000);
                }
                return _figure;

            }
            else
            {
                _figure = new Stick(_x, _y, _c);

                for (int i = 0; i < 5; i++)
                {
                    _figure.Draw();
                    Thread.Sleep(1000);
                    _figure.Hide();
                    _figure.Moves(Direction.Down);
                    _figure.Draw();
                    Thread.Sleep(1000);
                }
                return _figure;
            }
        }
    }
}