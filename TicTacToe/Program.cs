using System;
using static TicTacToe.Player;

namespace TicTacToe
{
    internal class Program : StandardMessages
    {

        static void Main(string[] args)
        {
            Board board = new Board();
            Player[] player = null;
            InitPlayer(ref player);

            bool turn = false;
            bool validMove = false;

            board.InitBoard();

            while (board.gameResult == GameResult.noResult)
            {
                int[] position = null;
                int playerNum = Convert.ToInt32(turn);

                while (validMove == false)
                {
                    position = player[playerNum].GetMove("Player " + player[playerNum].pChar.ToString());
                    validMove = board.AddMove(player[playerNum], Convert.ToInt32(turn), position);
                }

                board.IsGameOver(ref player[playerNum]);

                validMove = false;
                turn = !turn;
            }

            StandardMessages.GameOver(board.gameResult);
        }


    }
}
