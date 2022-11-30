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
            int numPlayers = GetPlayerCount();

            Player[] newPlayer = new Player[numPlayers];

            for (int i = 0; i < numPlayers; i++)
            {
                newPlayer[i] = new Player(i);
            }
            
            return newPlayer;
        }

        public static int GetPlayerCount()
        {
            int numPlayers = Enum.GetNames(typeof(PlayerChar)).Length;
            return numPlayers;
        }
    }
}
