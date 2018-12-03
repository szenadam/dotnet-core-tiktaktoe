using System;
using Xunit;
using DotnetCoreTikTakToe;

namespace test
{
    public class TikTakToeTest
    {
        [Fact]
        public void Test_InitBoard()
        {
            var game = new TiKTakToe();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.Equal(0, game.board[i, j]);
                }
            }
        }

        [Fact]
        public void Test_Intro()
        {
            var game = new TiKTakToe();
            game.intro();
        }

         [Fact]
        public void Test_PrintBoard()
        {
            var game = new TiKTakToe();
            game.printBoard();
        }
    }
}
