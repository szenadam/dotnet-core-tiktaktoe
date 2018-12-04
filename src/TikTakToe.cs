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

        private void initBoard() {
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
                    } else if (this.board[i,j] == 2) {
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

        public bool chekcWin() {
            // Horizontal
            if (this.board[0,0] == 0 && this.board[0,1] == 0 && this.board[0,2] == 0) return true;
            if (this.board[1,0] == 0 && this.board[1,1] == 0 && this.board[1,2] == 0) return true;
            if (this.board[2,0] == 0 && this.board[2,1] == 0 && this.board[2,2] == 0) return true;
            // Vertical
            if (this.board[0,0] == 0 && this.board[1,0] == 0 && this.board[2,0] == 0) return true;
            if (this.board[0,1] == 0 && this.board[1,1] == 0 && this.board[2,1] == 0) return true;
            if (this.board[0,2] == 0 && this.board[1,2] == 0 && this.board[2,2] == 0) return true;
            // Diagonal
            if (this.board[0,0] == 0 && this.board[1,1] == 0 && this.board[2,2] == 0) return true;
            if (this.board[0,2] == 0 && this.board[1,1] == 0 && this.board[2,0] == 0) return true;

            return false;
        }
    }
}
