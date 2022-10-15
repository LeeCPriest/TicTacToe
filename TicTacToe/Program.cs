using System;
using System.Runtime.InteropServices;

namespace TicTacToe
{
    internal class Program
    {
        public enum PlayerChar { X, O };

        static void Main(string[] args)
        {
            Board board = new Board();
            Player player = new Player();
            bool turn = false;

            board.InitBoard();

            while (true)
            {
                int playerNum = Convert.ToInt32(turn);
                Enum.TryParse(playerNum.ToString(), out PlayerChar playerChar);

                int[] position = player.GetMove("Player " + playerChar);
                board.AddMove(playerChar, Convert.ToInt32(turn), position);

                turn = !turn;
            }
            

        }
    }
}
