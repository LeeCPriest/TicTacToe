using System.Runtime.InteropServices;

namespace TicTacToe
{
    public static class Factory
    {
        public static IBoard CreateBoard()
        {
            return new Board();
        }

        public static IPlayer[] CreatePlayers(int numPlayers)
        {
            int i;

            Player[] newPlayer = new Player[numPlayers];

            for (i = 0; i <= 1; i++)
            {
                newPlayer[i] = new Player();
                newPlayer[i].pChar = (PlayerChar)i;
            }

            return newPlayer;
        }
    }
}
