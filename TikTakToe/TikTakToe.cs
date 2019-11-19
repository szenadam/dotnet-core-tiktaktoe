using System;

namespace DotnetCoreTikTakToe
{
    public class TiKTakToe
    {
        public int[,] board { get; set; }
        public char playerOneSymbol {get; set; }
        public char playerTwoSymbol {get; set; }

        public TiKTakToe()
        {
            this.board = new int[3, 3];
            this.playerOneSymbol = 'X';
            this.playerTwoSymbol = 'O';
            this.initBoard();
        }
        public TiKTakToe(char playerOneSymbol, char playerTwoSymbol)
        {
            this.board = new int[3, 3];
            this.playerOneSymbol = playerOneSymbol;
            this.playerTwoSymbol = playerTwoSymbol;
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
                        Console.Write(playerOneSymbol + " ");
                    } else if (this.board[i,j] == 2) {
                        Console.Write(playerTwoSymbol + " ");
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

        public bool chekcWin(int playerSymbol) {
            // Horizontal
            if (this.board[0,0] == playerSymbol && this.board[0,1] == playerSymbol && this.board[0,2] == playerSymbol) return true;
            if (this.board[1,0] == playerSymbol && this.board[1,1] == playerSymbol && this.board[1,2] == playerSymbol) return true;
            if (this.board[2,0] == playerSymbol && this.board[2,1] == playerSymbol && this.board[2,2] == playerSymbol) return true;
            // Vertical
            if (this.board[0,0] == playerSymbol && this.board[1,0] == playerSymbol && this.board[2,0] == playerSymbol) return true;
            if (this.board[0,1] == playerSymbol && this.board[1,1] == playerSymbol && this.board[2,1] == playerSymbol) return true;
            if (this.board[0,2] == playerSymbol && this.board[1,2] == playerSymbol && this.board[2,2] == playerSymbol) return true;
            // Diagonal
            if (this.board[0,0] == playerSymbol && this.board[1,1] == playerSymbol && this.board[2,2] == playerSymbol) return true;
            if (this.board[0,2] == playerSymbol && this.board[1,1] == playerSymbol && this.board[2,0] == playerSymbol) return true;

            return false;
        }
    }
}
