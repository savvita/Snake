using System;
using System.Threading;

namespace Snake
{
    internal class Game
    {
        private Snake snake;
        private readonly Board board;
        private Food food;

        readonly Random random = new Random();
         
        public Game(int width = 50, int height = 20)
        {
            snake = new Snake();
            board = new Board(width, height);
        }

        public void Start()
        {
            Console.CursorVisible = false;

            Draw.Welcome();
            Thread.Sleep(1000);

            while (true)
            {
                Draw.Menu();

                if (Int32.TryParse(Console.ReadLine(), out int ch))
                {
                    if (ch == 1)
                    {
                        Play();
                    }
                    else if (ch == 0)
                    {
                        Draw.Bye();
                        Thread.Sleep(1000);
                        break;
                    }
                }
            }
        }

        private void Play()
        {
            snake = new Snake();
            MakeGameField();

            int count = 0;

            Thread ControlThread = new Thread(Control);
            ControlThread.Start();

            while (true)
            {
                if (count > 0)
                {
                    snake.GrowUp();
                    snake.Draw();
                    count--;
                }

                snake.Move();

                if (snake.Head.IsHit(food))
                {
                    if (food is SmallFood)
                        count = 1;
                    else
                        count = 5;

                    PlaceFood();
                }

                if (snake.Head.IsHit(snake) || snake.IsHit(board))
                    break;

                Thread.Sleep(300);
            }

            Draw.GameOver();
            Thread.Sleep(1000);
        }

        private void Control(object obj)
        {
            while(true)
            {
                ConsoleKeyInfo key;

                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey();
                    snake.ChangeDirection(key);
                }

                if (snake.Head.IsHit(snake) || snake.IsHit(board))
                    break;

                Thread.Sleep(300);
            }
        }

        private void MakeGameField()
        {
            Console.Clear();

            board.Draw();
            snake.Draw();

            PlaceFood();
        }

        private void PlaceFood()
        {
            int ch = random.Next(2);
            do
            {
                if (ch == 1)
                    food = BigFood.GetFood(board.Width, board.Height);
                else
                    food = SmallFood.GetFood(board.Width, board.Height);
            } while(snake.IsHit(food));

            food.Draw();
        }
    }
}
