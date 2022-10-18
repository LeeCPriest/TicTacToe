using System;

namespace TicTacToe
{
    internal class Board
    {
        private const string blankChar = "_";

        private string[,] GameBoard = new string[3,3];

        public enum gameResult { noResult, X_wins, O_wins, Draw }

        public void InitBoard()
        {
            int row;
            int col;

            for (row = 0; row < 3; row++)
            {
                for (col = 0; col < 3; col++)
                {
                    GameBoard[row,col] = blankChar;
                }
            }

            DrawBoard();
        }
        
        public bool AddMove(Player.PlayerChar pChar, int value, int[] position)
        {
            bool bValidMove =  false;

            if (GameBoard[position[0], position[1]] == blankChar)
            {
                GameBoard[position[0], position[1]] = pChar.ToString();
                DrawBoard();
                bValidMove = true;
            }
            else 
            { 
                bValidMove = false;
                StandardMessages.InvalidSelection();
                DrawBoard();
            }

            return bValidMove;
        } 
        
        void DrawBoard()
        {
            int row;
            int col;

            Console.Clear();
            Console.WriteLine("");

            for(row = 0; row < 3; row++)
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

        public gameResult IsGameOver(ref Player player)
        {
            gameResult result = gameResult.noResult;

            int row;
            int col;
            bool noMoreMoves = true;

            for (row = 0; row < 3; row++)
            {
                string rowVals = GameBoard[row, 0] + GameBoard[row, 1] + GameBoard[row, 2];
                if (rowVals == "XXX" )
                {
                    result = gameResult.X_wins;
                    break;
                }
                if (rowVals == "OOO")
                {
                    result = gameResult.O_wins;
                    break;
                }
                if (rowVals.Contains(blankChar) == true) { noMoreMoves = false; } // if a blank character is found, there are available moves remaining
            }

            for (col = 0; col < 3; col++)
            {
                string rowVals = GameBoard[0, col] + GameBoard[1, col] + GameBoard[2, col];
                if (rowVals == "XXX" )
                {
                    result = gameResult.X_wins;
                    break;
                }
                if (rowVals == "OOO")
                {
                    result = gameResult.O_wins;
                    break;
                }
            }

            string xVal1 = GameBoard[0, 0] + GameBoard[1, 1] + GameBoard[2, 2];
            if (xVal1 == "XXX") { result = gameResult.X_wins; }
            if (xVal1 == "OOO") { result = gameResult.O_wins; }

            string xVal2 = GameBoard[2, 0] + GameBoard[1, 1] + GameBoard[0, 2];
            if (xVal1 == "XXX") { result = gameResult.X_wins; }
            if (xVal1 == "OOO") { result = gameResult.O_wins; }

            if (noMoreMoves == true) { result = gameResult.Draw; }

            return result;
        }
        
    }
}
