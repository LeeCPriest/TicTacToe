using System;
using static TicTacToe.Player;

namespace TicTacToe
{
    internal class Program
    {

        static void Main(string[] args)
        {
            IBoard board = Factory.CreateBoard();
            board.InitBoard();

            IPlayer[] player = Factory.CreatePlayers(2);
            
            bool turn = false;
            bool validMove = false;

            while (board.gameResult == GameResult.noResult)
            {
                int[] position = null;
                int playerNum = Convert.ToInt32(turn);

                while (validMove == false)
                {
                    position = player[playerNum].GetMove("Player " + player[playerNum].pChar.ToString());
                    validMove = board.AddMove(player[playerNum], Convert.ToInt32(turn), position);
                }

                validMove = false;
                turn = !turn;
            }

            StandardMessages.GameOver(board.gameResult);
        }
    }
}
