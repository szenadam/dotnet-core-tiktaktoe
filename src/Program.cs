using System;

namespace DotnetCoreTikTakToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new TiKTakToe();
            game.Intro();
            while (true)
            {
            game.Draw();
            }
        }
    }
}
