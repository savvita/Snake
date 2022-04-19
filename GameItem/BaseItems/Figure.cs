using System.Collections.Generic;

namespace Snake
{
    internal abstract class Figure
    {
        public Figure()
        {
            Points = new List<Point>();
        }

        protected List<Point> Points { get; set ; }

        public void Draw()
        {
            for (int i = 0; i < Points.Count; i++)
                Points[i].Draw();
        }

        public bool IsHit(Point point)
        {
            for (int i = 0; i < Points.Count; i++)
                if (Points[i] != point && Points[i].Equals(point))
                    return true;

            return false;
        }
        
        public bool IsHit(Figure figure)
        {
            for (int i = 0; i < Points.Count; i++)
                if (figure.IsHit(Points[i]))
                    return true;

            return false;
        }
    }
}
