﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tetris 
{
    internal class Program
    {
        static Figure currentFigure;
        static FigureGenerator generator;

        static void Main(string[] args)
        {
            Console.SetWindowSize(Field.Widht, Field.Height);
            Console.SetBufferSize(Field.Widht, Field.Height);
            
            generator = new FigureGenerator(Field.Widht/2, 0, Drawer.DEFAULT_SYMBOL);
            currentFigure = generator.GetNewFigure();




            while (true)
            {
                if(Console.KeyAvailable)
                {
                   var key = Console.ReadKey();
                    var result = HandleKey(currentFigure, key.Key);
                    ProcessResult(result, ref currentFigure);                

                }

            }                                          
        }

       

        public static bool ProcessResult(Result result, ref Figure currentFigure)
        {
            if (result == Result.HEAP_STRIKE || result == Result.DOWN_BORDER_STRIKE)
            {

                Field.AddFigure(currentFigure);
                Field.TryDeleteLines();
                currentFigure = generator.GetNewFigure();
                return true;
            }
            else
                return false;   
        }

        private static Result HandleKey(Figure f, ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    return f.TryMove(Direction.LEFT);
                case ConsoleKey.RightArrow:
                    return f.TryMove(Direction.RIGHT);
                case ConsoleKey.DownArrow:
                    return f.TryMove(Direction.DOWN);
                case ConsoleKey.Spacebar:
                    return f.TryRotate();
            }
            return Result.SUCCESS;
        }
    }
}
 