using System;
using System.Runtime.InteropServices;

namespace TicTacToe
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Board board = new Board();
            Player[] player = new Player[2];
            player[0] = new Player();
            player[1] = new Player();

            bool turn = false;
            bool gameIsOver = false;
            bool validMove = false;

            board.InitBoard();

            while (gameIsOver == false)
            {
                int[] position = null;
                int playerNum = Convert.ToInt32(turn);
                Enum.TryParse(playerNum.ToString(), out Player.PlayerChar playerChar);

                while (validMove == false)
                {
                   position = player[playerNum].GetMove("Player " + playerChar);
                   validMove = board.AddMove(playerChar, Convert.ToInt32(turn), position);
                }

                gameIsOver = board.IsGameOver();

                validMove = false;
                turn = !turn;
            }

            Console.WriteLine("Game Over");
            Console.ReadLine();
        }
    }
}
