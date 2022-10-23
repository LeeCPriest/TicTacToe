using System;

namespace TicTacToe
{
    internal class Board : IBoard
    {
        private const string blankChar = "_";

        private string[,] GameBoard = new string[3, 3];

        public GameResult gameResult { get; private set; }

        public Board()
        {
            int row;
            int col;

            for (row = 0; row < 3; row++)
            {
                for (col = 0; col < 3; col++)
                {
                    GameBoard[row, col] = blankChar;
                }
            }

            gameResult = GameResult.noResult;

            DrawBoard();
        }


        public bool AddMove(IPlayer player, int value, int[] position)
        {
            bool bValidMove = false;

            if (GameBoard[position[0], position[1]] == blankChar)
            {
                GameBoard[position[0], position[1]] = player.pChar.ToString();
                DrawBoard();
                bValidMove = true;
            }
            else
            {
                bValidMove = false;
                StandardMessages.InvalidSelectionMessage();
                DrawBoard();
            }

            IsGameOver(ref player);

            return bValidMove;
        }

        private void DrawBoard()
        {
            int row;
            int col;

            Console.Clear();
            Console.WriteLine("");

            for (row = 0; row < 3; row++)
            {
                string lineText = "";

                for (col = 0; col < 3; col++)
                {
                    lineText += GameBoard[row, col] + " ";
                }

                Console.WriteLine(lineText);
            }

            Console.WriteLine("");
        }

        public void IsGameOver(ref IPlayer player)
        {
            GameResult result = GameResult.noResult;

            int row;
            int col;
            bool noMoreMoves = true;

            for (row = 0; row < 3; row++)
            {
                string rowVals = GameBoard[row, 0] + GameBoard[row, 1] + GameBoard[row, 2];
                if (rowVals == "XXX")
                {
                    result = GameResult.X_wins;
                    break;
                }
                if (rowVals == "OOO")
                {
                    result = GameResult.O_wins;
                    break;
                }
                if (rowVals.Contains(blankChar) == true) { noMoreMoves = false; } // if a blank character is found, there are available moves remaining
            }

            for (col = 0; col < 3; col++)
            {
                string rowVals = GameBoard[0, col] + GameBoard[1, col] + GameBoard[2, col];
                if (rowVals == "XXX")
                {
                    result = GameResult.X_wins;
                    break;
                }
                if (rowVals == "OOO")
                {
                    result = GameResult.O_wins;
                    break;
                }
            }

            string xVal1 = GameBoard[0, 0] + GameBoard[1, 1] + GameBoard[2, 2];
            if (xVal1 == "XXX") { result = GameResult.X_wins; }
            if (xVal1 == "OOO") { result = GameResult.O_wins; }

            string xVal2 = GameBoard[2, 0] + GameBoard[1, 1] + GameBoard[0, 2];
            if (xVal1 == "XXX") { result = GameResult.X_wins; }
            if (xVal1 == "OOO") { result = GameResult.O_wins; }

            if (result != GameResult.X_wins && result != GameResult.O_wins && noMoreMoves == true) { result = GameResult.Draw; }
            else if (result != GameResult.noResult ) 
            { player.UpdateWinCount(); }
            

            gameResult = result;
        }

        public bool PlayAgain()
        {
            string response = "";
            Console.WriteLine("");

            while (response.ToLower() != "y" && response.ToLower() != "n")
            {
                StandardMessages.PlayAgainMessage();
                response = Console.ReadLine();
            }

            if (response.ToLower() == "y") { return true; }
            else { return false; }

        }
    }
}
