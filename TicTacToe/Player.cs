using System;

namespace TicTacToe
{
    internal class Player : IPlayer
    {
        public int GamesWon { get; set; }
        public PlayerChar pChar { get; set; }

        public int[] GetMove(string PlayerName)
        {
            char input;
            int[] position = new int[2];

            StandardMessages.EnterMove(PlayerName, "Row");
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

            StandardMessages.EnterMove(PlayerName, "Col");
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
    }
}
