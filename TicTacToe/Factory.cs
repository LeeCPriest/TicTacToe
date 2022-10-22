using System;
using System.Runtime.InteropServices;

namespace TicTacToe
{
    public static class Factory
    {
        public static IBoard CreateBoard()
        {
            return new Board();
        }

        public static IPlayer[] CreatePlayers()
        {
            int i;
            int numPlayers = Enum.GetNames(typeof(PlayerChar)).Length;

            Player[] newPlayer = new Player[numPlayers];

            for (i = 0; i < numPlayers; i++)
            {
                newPlayer[i] = new Player();
                newPlayer[i].pChar = (PlayerChar)i;
            }

            return newPlayer;
        }
    }
}
