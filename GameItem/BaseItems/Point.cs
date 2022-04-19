using System;

namespace Snake
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public char Symbol { get; set; }

        public Point(int x, int y, char symbol = (char)164)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
            Symbol = point.Symbol;
        }

        public bool IsHit(Point point)
        {
            if(this != point)
                return this.Equals(point);

            return false;
        }

        public bool IsHit(Figure figure)
        {
            return figure.IsHit(this);
        }

        public override bool Equals(object obj)
        {
            if(obj is Point)
            {
                return (obj as Point).X == X && (obj as Point).Y == Y;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return X ^ base.GetHashCode() ^ Y;
        }

        #region draws
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }

        public void Clear()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        } 
        #endregion


        #region moves
        public static Point MoveUp(Point point)
        {
            return new Point(point.X, point.Y - 1, point.Symbol);
        }

        public static Point MoveDown(Point point)
        {
            return new Point(point.X, point.Y + 1, point.Symbol);
        }

        public static Point MoveLeft(Point point)
        {
            return new Point(point.X - 1, point.Y, point.Symbol);
        }

        public static Point MoveRight(Point point)
        {
            return new Point(point.X + 1, point.Y, point.Symbol);
        } 
        #endregion
    }
}
