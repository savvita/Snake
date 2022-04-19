namespace Snake
{
    internal class Board : Figure
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Board(int width, int height) : base()
        {
            Width = width;
            Height = height;

            for (int i = 0; i < width; i++)
            {
                points.Add(new Point(i, 0, '*'));
                points.Add(new Point(i, height - 1, '*'));
            }

            for (int i = 0; i < height; i++)
            {
                points.Add(new Point(0, i, '*'));
                points.Add(new Point(width - 1, i, '*'));
            }
        }
    }
}
