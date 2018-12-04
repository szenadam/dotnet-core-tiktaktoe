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

        [Fact]
        public void Test_MakeStep() 
        {
            var game = new TiKTakToe();
            game.makeStep(0, 0, 1);
            Assert.Equal(1, game.board[0,0]);
        }

        [Fact]
        public void Test_CheckWin_FirstHorizontal() 
        {
            var game = new TiKTakToe();
            game.makeStep(0, 0, 1);
            game.makeStep(0, 1, 1);
            game.makeStep(0, 2, 1);
            Assert.True(game.chekcWin(1));
        }

        [Fact]
        public void Test_CheckWin_SecondHorizontal() 
        {
            var game = new TiKTakToe();
            game.makeStep(1, 0, 1);
            game.makeStep(1, 1, 1);
            game.makeStep(1, 2, 1);
            Assert.True(game.chekcWin(1));
        }

        [Fact]
        public void Test_CheckWin_ThirdHorizontal() 
        {
            var game = new TiKTakToe();
            game.makeStep(2, 0, 1);
            game.makeStep(2, 1, 1);
            game.makeStep(2, 2, 1);
            Assert.True(game.chekcWin(1));
        }

        [Fact]
        public void Test_CheckWin_FirstVertical() 
        {
            var game = new TiKTakToe();
            game.makeStep(0, 0, 1);
            game.makeStep(1, 0, 1);
            game.makeStep(2, 0, 1);
            Assert.True(game.chekcWin(1));
        }

        [Fact]
        public void Test_CheckWin_SecondVertical() 
        {
            var game = new TiKTakToe();
            game.makeStep(0, 1, 1);
            game.makeStep(1, 1, 1);
            game.makeStep(2, 1, 1);
            Assert.True(game.chekcWin(1));
        }

        [Fact]
        public void Test_CheckWin_ThirdVertical() 
        {
            var game = new TiKTakToe();
            game.makeStep(0, 2, 1);
            game.makeStep(1, 2, 1);
            game.makeStep(2, 2, 1);
            Assert.True(game.chekcWin(1));
        }
    }
}
