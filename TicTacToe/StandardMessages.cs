using System;

namespace TicTacToe
{
    internal class StandardMessages
    {
               
        public static void GameOver(Board.gameResult gameIsOver)
        {
            Console.WriteLine("Game Over. Result: " + gameIsOver.ToString());
            Console.ReadLine();
        }

        public static void EnterMove(string PlayerName, string RowCol)
        {
            Console.Write($"{PlayerName} - Please enter the {RowCol} # (1-3): ");
        }

        public static void InvalidSelection()
        {
            Console.WriteLine("");
            Console.WriteLine("Invalid selection");
        }
    }
}