using System;

namespace Snake
{
    internal class Food : Point
    {
        private static int minX;
        private static int maxX;
        private static int minY;
        private static int maxY;

        private static Food food = null;

        private Food(int width, int height) : base(0, 0)
        {
            minX = 1;
            maxX = minX + width - 2;

            minY = 1;
            maxY = minY + height - 2;
        }

        public static Food GetFood(int width, int height)
        {
            if(food == null)
                food = new Food(width, height);

            Random random = new Random();
            food.X = random.Next(minX, maxX);
            food.Y = random.Next(minY, maxY);

            return food;
        }
    }
}
