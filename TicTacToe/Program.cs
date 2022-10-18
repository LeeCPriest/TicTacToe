using System;
using System.Runtime.InteropServices;
using static TicTacToe.Player;

namespace TicTacToe
{
    internal class Program : StandardMessages
    {

        static void Main(string[] args)
        {
            Board board = new Board();
            Player[] player = new Player[2];
            player[0] = new Player();
            player[1] = new Player();

            bool turn = false;
            Board.gameResult gameIsOver = Board.gameResult.noResult;
            bool validMove = false;

            board.InitBoard();

            while (gameIsOver == Board.gameResult.noResult)
            {
                int[] position = null;
                int playerNum = Convert.ToInt32(turn);
                Enum.TryParse(playerNum.ToString(), out PlayerChar playerChar);

                while (validMove == false)
                {
                    position = player[playerNum].GetMove("Player " + playerChar);
                    validMove = board.AddMove(playerChar, Convert.ToInt32(turn), position);
                }

                gameIsOver = board.IsGameOver(ref player[playerNum]);

                validMove = false;
                turn = !turn;
            }

            StandardMessages.GameOver(gameIsOver);
        }
    }
}
