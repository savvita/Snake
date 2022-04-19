using System;

namespace Snake
{
    internal abstract class Food : Point
    {
        protected static int minX;
        protected static int maxX;
        protected static int minY;
        protected static int maxY;

        //protected static Food food = null;

        protected Food(int width, int height) : base(0, 0)
        {
            minX = 1;
            maxX = minX + width - 2;

            minY = 1;
            maxY = minY + height - 2;
        }

        //public abstract Food GetFood(int width, int height);
    }
}
