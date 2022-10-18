using System;

namespace TicTacToe
{
    internal class Player
    {
        public int GamesWon { get; set; }
        public PlayerChar pChar { get; set; }

        public static void InitPlayers(ref Player[] player)
        {
            int i;

            player = new Player[2];

            for (i=0; i<=1; i++)
            {
                player[i] = new Player();
                player[i].pChar = (PlayerChar)i;
            }

        }

        public int[] GetMove(string PlayerName)
        {
            char input;
            int[] position =  new int[2];

            StandardMessages.EnterMove(PlayerName, "Row");
            input = Console.ReadKey().KeyChar;
            bool isNumeric = int.TryParse(input.ToString(), out int inputVal);
            
            if (isNumeric == true) // if isnumeric
            {
                if (inputVal-1 >= 0 && inputVal-1 < 3) // if 1-3
                {
                    position[0] = Convert.ToInt32(Convert.ToString(input))-1;
                }
            }
            
            Console.WriteLine("");

            StandardMessages.EnterMove(PlayerName, "Col");
            input = Console.ReadKey().KeyChar;
            isNumeric = int.TryParse(input.ToString(), out inputVal);

            if (isNumeric == true) // if isnumeric
            {
                if (inputVal-1 >= 0 && inputVal-1 < 3) // if 1-3
                {
                    position[1] = Convert.ToInt32(Convert.ToString(input)) - 1;
                }
            }

            Console.WriteLine("");

            return position;
        }
    }
}
