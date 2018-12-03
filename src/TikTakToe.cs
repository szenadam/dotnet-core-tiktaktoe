using System;

namespace DotnetCoreTikTakToe
{
    public class TiKTakToe
    {
        public int[,] coordinates { get; set; }
        public TiKTakToe()
        {
            this.coordinates = new int[3, 3];
            this.initBoard();
        }

        private void initBoard() {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.coordinates[i, j] = 0;
                }
            }
        }

        public void intro() {
            Console.Clear();
            Console.WriteLine("Tik-Tak-Toke game");
            Console.WriteLine("-----------------");
        }

        public void printBoard() {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(this.coordinates[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
