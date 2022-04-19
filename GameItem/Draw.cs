using System;

namespace Snake
{
    internal static class Draw
    {
        public static void GameOver()
        {
            Console.Clear();

            Console.SetCursorPosition(0, 0);

            Console.WriteLine(@"  _____         ___         __   ___      ______");
            Console.WriteLine(@"/  ____|       /   |       /  | /   |    |  ____|");
            Console.WriteLine(@"| |           / /| |      /   |/ /| |    | |___");
            Console.WriteLine(@"| |   _      / /_| |     / /|   / | |    |  ___|");
            Console.WriteLine(@"| |__| |    /  __  |    / / |__/  | |    | |____");
            Console.WriteLine(@"\_____/    /_/   |_|   /_/        |_|    |______|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"  ____         _     _      ______       ____");
            Console.WriteLine(@" / __ \       | |   / /    |  ____|     |  __ \");
            Console.WriteLine(@"| |  | |      | |  / /     | |___       | |__| |  ");
            Console.WriteLine(@"| |  | |      | | / /      |  ___|      |  _  / ");
            Console.WriteLine(@"| |__| |      | |/ /       | |____      | | \ \");
            Console.WriteLine(@" \____/       |___/        |______|     |_|  \_\");
        }

        public static void Welcome()
        {
            Console.Clear();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine(@"  _____     ___     _        ___     _   _     ______");
            Console.WriteLine(@"/  ____|   |   \   | |      /   |   | | / /   |  ____|");
            Console.WriteLine(@"| |____    | |\ \  | |     / /| |   | |/ /    | |___");
            Console.WriteLine(@"\____  |   | | \ \ | |    / /_| |   |   |     |  ___|");
            Console.WriteLine(@" ____| |   | |  \ \| |   /  __  |   | |\ \    | |____");
            Console.WriteLine(@"|______/   |_|   \___|  /_/   |_|   |_| \_\   |______|");
        }

        public static void Bye()
        {
            Console.Clear();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine(@" ______     _     _     ______     _ ");
            Console.WriteLine(@"|  __  \   | |   | |   |  ____|   | |");
            Console.WriteLine(@"| |__| /   | |___| |   | |___     | |");
            Console.WriteLine(@"|  __  \   |_____  |   |  ___|    |_|");
            Console.WriteLine(@"| |__| |    _____| |   | |____     _ ");
            Console.WriteLine(@"|______/   |_______|   |______|   |_|");
        }

        public static void Menu()
        {
            Console.Clear();

            Console.SetCursorPosition(0, 0);

            Console.WriteLine(@"  ___              _____    _______       ___     ____      _______");
            Console.WriteLine(@" /   |           /  ____|  |__   __|     /   |   |  __ \   |__   __|");
            Console.WriteLine(@"/_/| |   ____    | |____      | |       / /| |   | |__| |     | |");
            Console.WriteLine(@"   | |  |____|   \____  |     | |      / /_| |   |  _  /      | |");
            Console.WriteLine(@"   | |            ____| |     | |     /  __  |   | | \ \      | |");
            Console.WriteLine(@"   |_|           |______/     |_|    /_/   |_|   |_|  \_\     |_|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"  ___             ______    __    __     _     _______");
            Console.WriteLine(@" / _ \           |  ____|   \ \  / /    | |   |__   __|");
            Console.WriteLine(@"| / \ |  ____    | |___      \ \/ /     | |      | |");
            Console.WriteLine(@"| | | | |____|   |  ___|      |  |      | |      | |");
            Console.WriteLine(@"| \_/ |          | |____     / /\ \     | |      | |");
            Console.WriteLine(@" \___/           |______|   /_/  \_\    |_|      |_|");
        }
    }
}
