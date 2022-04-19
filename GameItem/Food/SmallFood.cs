using System;

namespace Snake
{
    internal class SmallFood : Food
    {
        protected static SmallFood food = null;
        protected SmallFood(int width, int height) : base(width, width)
        {
            minX = 1;
            maxX = minX + width - 2;

            minY = 1;
            maxY = minY + height - 2;
        }

        public static SmallFood GetFood(int width, int height)
        {
            if(food == null)
                food = new SmallFood(width, height);

            Random random = new Random();

            food.X = random.Next(minX, maxX);
            food.Y = random.Next(minY, maxY);
            food.Symbol = (char)1;

            return food;
        }
    }
}
