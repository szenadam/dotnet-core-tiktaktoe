using System;

namespace DotnetCoreTikTakToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new TiKTakToe();
            game.intro();
            game.printBoard();

            int x, y;

            while (true)
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                game.makeStep(x,y, 1);
                game.printBoard();
            }
        }
    }
}
