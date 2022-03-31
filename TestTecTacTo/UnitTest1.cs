using System;
using Xunit;
using TicTacToeGameConsole;

namespace TestTecTacTo
{
    public class UnitTest1
    {
        [Fact]
        public void IsGameDraw()
        {

            char[] Draw = new char[]
           {
                'x', 'o', 'x',
                'o', 'o', 'x',
                'x', 'o', 'o'
           };

            char[] Draw2 = new char[]
            {
                'x', 'o', 'x',
                'o', 'x', 'x',
                'o', 'x', 'o'
           };           
            Assert.True(Program.IsGameDraw(Draw));
            Assert.True(Program.IsGameDraw(Draw2));

        }
        
        [Fact]
        public void CheckWinner()
        {
            
            char[] Winner = new char[]
           {
                'x', 'x', 'x',
                'o', 'o', 'x',
                'x', 'o', 'o'
           };

            char[] Winner2 = new char[]  
            {
                'x', 'o', 'x',
                'o', 'x', 'x',
                'o', 'o', 'o'
           };
            char[] Winner3 = new char[]
            {
                'x', 'o', 'x',
                'o', 'x', 'x',
                'o', 'x', 'o'
           };


            Assert.True(Program.IsGameWinner(Winner)) ;
            Assert.True(Program.IsGameWinner(Winner2));
            Assert.False(Program.IsGameWinner(Winner3));

        }
        [Fact]
        public void GetNextPlayer()
        {
            Assert.Equal(2, Program.GetNextPlayer(1));
            Assert.Equal(1, Program.GetNextPlayer(2));
        }

        [Fact]
        public void GetPlayerMarker()
        {
            Assert.Equal('O', Program.GetPlayerMarker(6));
            Assert.Equal('X', Program.GetPlayerMarker(7));

        }
    }
}
