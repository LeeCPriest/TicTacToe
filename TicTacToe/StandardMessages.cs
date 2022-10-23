using System;

namespace TicTacToe
{
    internal class StandardMessages
    {
               
        public static void GameOverMessage(GameResult gameResult, IPlayer[] player)
        {
            Console.WriteLine("Game Over. Result: " + gameResult.ToString());
            Console.WriteLine("");
            Console.Write($"{player[0].PlayerName} has won {player[0].GamesWon} games.");
            Console.WriteLine("");
            Console.Write($"{player[1].PlayerName} has won {player[1].GamesWon} games.");
            Console.WriteLine("");
        }

        public static void EnterMoveMessage(IPlayer player, string RowCol)
        {
            Console.Write($"{player.PlayerName} - Please enter the {RowCol} # (1-3): ");
        }

        public static void InvalidSelectionMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Invalid selection");
        }

        public static void PlayAgainMessage()
        {
            Console.WriteLine("Would you like to play again? (Y/N)?");
        }
            
    }
}