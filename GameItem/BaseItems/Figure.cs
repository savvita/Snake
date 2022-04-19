using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    internal abstract class Figure
    {
        protected List<Point> points;

        public Point Head
        {
            get { return points.Last(); }
        }

        public Figure()
        {
            points = new List<Point>();
        }

        public void Draw()
        {
            foreach (Point point in points)
                point.Draw();
        }

        public bool IsHit(Point point)
        {
            foreach(Point _point in points)
                if(_point != point && _point.Equals(point))
                    return true;

            return false;
        }
        
        public bool IsHit(Figure figure)
        {
            foreach(Point _point in points)
                if(figure.IsHit(_point))
                    return true;

            return false;
        }
    }
}
