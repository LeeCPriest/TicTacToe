using System;
using static TicTacToe.Player;

namespace TicTacToe
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool playGame = true;
            bool turn = false;

            IPlayer[] player = Factory.CreatePlayers();

            while ( playGame == true)
            {
                IBoard board = Factory.CreateBoard();
                
                bool validMove = false;
                int playerNum = Convert.ToInt32(turn);

                while (board.gameResult == GameResult.noResult)
                {
                    int[] position = null;
                    playerNum = Convert.ToInt32(turn);

                    while (validMove == false)
                    {
                        position = player[playerNum].GetMove();
                        validMove = board.AddMove(player[playerNum], Convert.ToInt32(turn), position);
                    }

                    validMove = false;
                    turn = !turn;
                }

                StandardMessages.GameOverMessage(board.gameResult, player);

                playGame = board.PlayAgain();
            }
        }
    }
}
