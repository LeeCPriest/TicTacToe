﻿using System;

namespace TicTacToe
{
    internal class Player
    {

        public int[] GetMove(string PlayerName)
        {
            char input;
            int[] position =  new int[2];

            Console.Write(PlayerName + " - Please enter the Row # (1-3): ");
            input = Console.ReadKey().KeyChar;
            // if isnumeric
            // if 1-3
            position[0] = Convert.ToInt32(Convert.ToString(input))-1;

            Console.WriteLine("");

            Console.Write(PlayerName + " - Please enter the Col # (1-3): ");
            input = Console.ReadKey().KeyChar;
            // if isnumeric
            // if 1-3
            position[1] = Convert.ToInt32(Convert.ToString(input))-1;

            Console.WriteLine("");

            return position;
        }
    }
}