using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Tetris 
{
    internal class Program
    {
        static Figure currentFigure;
        static FigureGenerator generator;
        private static System.Timers.Timer aTimer;
        private static Object _lockObject = new Object();
        static void Main(string[] args)
        {
            
          DrowerProvider.Drawer.InitField();
            
            generator = new FigureGenerator(Field.Widht/2, 0);
            currentFigure = generator.GetNewFigure();

            SetTimer();





            while (true)
            {
                if(Console.KeyAvailable)
                {
                   var key = Console.ReadKey();

                    Monitor.Enter(_lockObject);
                    var result = HandleKey(currentFigure, key.Key);
                    ProcessResult(result, ref currentFigure);
                    Monitor.Exit(_lockObject);
                    
                }

            }  
            
        }
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Monitor.Enter(_lockObject);
            var result =  currentFigure.TryMove(Direction.DOWN);
            ProcessResult(result, ref currentFigure);
            Monitor.Exit(_lockObject);
        }


        public static bool ProcessResult(Result result, ref Figure currentFigure)
        {
            if (result == Result.HEAP_STRIKE || result == Result.DOWN_BORDER_STRIKE)
            {

                Field.AddFigure(currentFigure);
                Field.TryDeleteLines();

                if(currentFigure.IsOnTop())
                {
                    DrowerProvider.Drawer.WriteGameOver();
                    aTimer.Elapsed -= OnTimedEvent;

                    return true;
                }
                currentFigure = generator.GetNewFigure();
                return true;
            }
            else
                return false;   
        }

        private static void WriteGameOver()
        {
            Console.SetCursorPosition(Field.Widht / 2 - 8, Field.Height / 2);
            Console.WriteLine(" G A M E O V E R");
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
 