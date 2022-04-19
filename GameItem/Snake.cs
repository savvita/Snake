using System;
using System.Linq;

namespace Snake
{
    internal class Snake : Figure
    {
        Func<Point, Point> currentMove;

        public Point Head
        {
            get { return Points.Last(); }
        }

        public Snake()
        {
            for (int i = 0; i < 2; i++)
            {
                Points.Add(new Point(5 + i, 5));
            }

            currentMove = Point.MoveRight;
        }

        public void Move()
        {
            Points.First().Clear();
            Points.RemoveAt(0);

            Points.Add(currentMove(Points.Last()));

            Points.Last().Draw();
        }

        public void GrowUp()
        {
            Points.Add(new Point(currentMove(Points.Last())));
        }

        public void ChangeDirection(ConsoleKeyInfo keyInfo)
        {
            switch(keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    if(currentMove!= Point.MoveRight)
                        currentMove = Point.MoveLeft;

                    break;

                case ConsoleKey.RightArrow:
                    if (currentMove != Point.MoveLeft)
                        currentMove = Point.MoveRight;

                    break;

                case ConsoleKey.UpArrow:
                    if (currentMove != Point.MoveDown)
                        currentMove = Point.MoveUp;

                    break;

                case ConsoleKey.DownArrow:
                    if (currentMove != Point.MoveUp)
                        currentMove = Point.MoveDown;

                    break;
            }
        }

    }
}
