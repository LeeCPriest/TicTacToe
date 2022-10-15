using System;

namespace TicTacToe
{
    internal class Player
    {
        public enum PlayerChar { X, O };
        public int GamesWon { get; set; } 

        public int[] GetMove(string PlayerName)
        {
            char input;
            int[] position =  new int[2];

            Console.Write(PlayerName + " - Please enter the Row # (1-3): ");
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

            Console.Write(PlayerName + " - Please enter the Col # (1-3): ");
            input = Console.ReadKey().KeyChar;

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
