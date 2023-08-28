using System.Reflection;

namespace Tetris
{
    public class Square
    {
        Point[][] points = new Point[2][];
        public Square (int x, int y, char sym) 
        {
            
            points[0] = new Point[2];
            points[1] = new Point[2];


            points[0][0] = new Point(x, y, sym);
            points[0][1] = new Point(x, y + 1, sym);
            points[1][1] = new Point(x+1, y+1, sym);
            points[1][0] = new Point(x+1, y, sym);

        }

        public void Draw()
        {
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = 0; j < points[i].Length; j++)
                {
                    points[i][j].Draw();
                }
            }
        }
    }
}