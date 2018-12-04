using System;

namespace DotnetCoreTikTakToe
{
    public class TiKTakToe
    {
        public int[,] board { get; set; }
        public TiKTakToe()
        {
            this.board = new int[3, 3];
            this.initBoard();
        }

        public void initBoard() {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.board[i, j] = 0;
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
                    if (this.board[i,j] == 1) {
                        Console.Write("X ");
                    } else if (this.board[i,j] == 1) {
                        Console.Write("O ");
                    } else {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void makeStep(int x, int y, int value) {
            this.board[x,y] = value;
        }
    }
}
