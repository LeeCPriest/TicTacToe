using System;

namespace TicTacToe
{
    internal class Player : IPlayer
    {
        public int GamesWon { get; set; }

        public PlayerChar pChar { get; private set; }

        public string PlayerName { get; private set; }

        public Player(int playerNum)
        {
            pChar = (PlayerChar)playerNum;
            PlayerName = "Player " + pChar.ToString();
        }


        public int[] GetMove()
        {
            char input;
            int numPlayers = Factory.GetPlayerCount();
            int[] position = new int[numPlayers];

            StandardMessages.EnterMoveMessage(this, "Row");
            input = Console.ReadKey().KeyChar;
            bool isNumeric = int.TryParse(input.ToString(), out int inputVal);

            if (isNumeric == true) // if isnumeric
            {
                if (inputVal - 1 >= 0 && inputVal - 1 < 3) // if 1-3
                {
                    position[0] = Convert.ToInt32(Convert.ToString(input)) - 1;
                }
            }

            Console.WriteLine("");

            StandardMessages.EnterMoveMessage(this, "Col");
            input = Console.ReadKey().KeyChar;
            isNumeric = int.TryParse(input.ToString(), out inputVal);

            if (isNumeric == true) // if isnumeric
            {
                if (inputVal - 1 >= 0 && inputVal - 1 < 3) // if 1-3
                {
                    position[1] = Convert.ToInt32(Convert.ToString(input)) - 1;
                }
            }

            Console.WriteLine("");

            return position;
        }

        public void UpdateWinCount()
        {
            GamesWon += 1;
        }
    }
}
