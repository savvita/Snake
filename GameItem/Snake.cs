using System;
using System.Linq;

namespace Snake
{
    internal class Snake : Figure
    {
        Func<Point, Point> currentMove;

        public Snake()
        {
            for (int i = 0; i < 2; i++)
            {
                points.Add(new Point(5 + i, 5));
            }

            currentMove = Point.MoveRight;
        }

        public void Move()
        {
            points.First().Clear();
            points.RemoveAt(0);

            points.Add(currentMove(points.Last()));

            points.Last().Draw();
        }

        public void GrowUp()
        {
            points.Add(new Point(currentMove(points.Last())));
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
