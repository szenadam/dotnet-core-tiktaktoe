using System;

namespace DotnetCoreTikTakToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new TiKTakToe();
            game.Intro();
            game.Draw();
        }
    }

    enum Symbols
    {
        Empty = ' ', O = 'O', X = 'X'
    }

    class TiKTakToe
    {
        private char[] coordinates { get; set; }

        public TiKTakToe() {
            coordinates = new char[9] {
                (char)Symbols.Empty, (char)Symbols.Empty, (char)Symbols.Empty,
                (char)Symbols.Empty, (char)Symbols.Empty, (char)Symbols.Empty,
                (char)Symbols.Empty, (char)Symbols.Empty, (char)Symbols.Empty
            };
        }

        public void Draw()
        {
            Console.WriteLine("Player 1: X    Player 2: O\n\n");
            Console.WriteLine("   --- --- --- ");
            Console.WriteLine("3 | {0} | {1} | {2} |", coordinates[0], coordinates[1], coordinates[2]);
            Console.WriteLine("   --- --- --- ");
            Console.WriteLine("2 | {0} | {1} | {2} |", coordinates[3], coordinates[4], coordinates[5]);
            Console.WriteLine("   --- --- --- ");
            Console.WriteLine("1 | {0} | {1} | {2} |", coordinates[6], coordinates[7], coordinates[8]);
            Console.WriteLine("   --- --- --- ");
            Console.WriteLine("    a   b   c\n\n");
            Console.WriteLine("Player 1's turn!");
            Console.WriteLine("Enter coordinate: ");
        }

        public void Intro()
        {
            Console.WriteLine("Hello to a Tik-Tak-Toe Game");
            Console.WriteLine("Press enter key to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
