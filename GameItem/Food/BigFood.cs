using System;

namespace Snake
{
    internal class BigFood : Food
    {
        protected static BigFood food = null;
        private BigFood(int width, int height) : base(width, height)
        {
            minX = 2;
            maxX = minX + width - 3;

            minY = 2;
            maxY = minY + height - 3;
        }

        public static BigFood GetFood(int width, int height)
        {
            if(food == null)
                food = new BigFood(width, height);

            Random random = new Random();

            food.X = random.Next(minX, maxX);
            food.Y = random.Next(minY, maxY);

            food.Symbol = (char)2;

            return food;
        }
    }
}
