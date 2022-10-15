using System;

namespace TicTacToe
{
    internal class Board
    {
        private string[,] GBoard = new string[3,3];
        public enum position { Row, Col };

        public void InitBoard()
        {
            int row;
            int col;

            for (row = 0; row < 3; row++)
            {
                for (col = 0; col < 3; col++)
                {
                    GBoard[row,col] = "_";
                }
            }

            DrawBoard();
        }
        
        public bool AddMove(Player.PlayerChar pChar, int value, int[] position)
        {
            bool bValidMove =  false;

            if (GBoard[position[0], position[1]] == "_")
            {
                GBoard[position[0], position[1]] = pChar.ToString();
                DrawBoard();
                bValidMove = true;
            }
            else 
            { 
                bValidMove = false;
                Console.WriteLine("");
                Console.WriteLine("Invalid selection");
                Console.WriteLine("");
            }

            return bValidMove;
        } 
        
        void DrawBoard()
        {
            int row;
            int col;

            Console.WriteLine("");

            for(row = 0; row < 3; row++)
            {
                string lineText = "";

                for (col = 0; col < 3; col++)
                {
                    lineText += GBoard[row, col] + " ";
                }
                                
;               Console.WriteLine(lineText);
            }

            Console.WriteLine("");
        }

        public bool IsGameOver()
        {
            bool gameOver = false;

            int row;
            int col;
                        
            for (row = 0; row < 3; row++)
            {
                string rowVals = GBoard[row, 0] + GBoard[row, 1] + GBoard[row, 2];
                if (rowVals == "XXX" || rowVals == "OOO")
                {
                    gameOver = true;
                    break;
                }
            }

            for (col = 0; col < 3; col++)
            {
                string rowVals = GBoard[0, col] + GBoard[1, col] + GBoard[2, col];
                if (rowVals == "XXX" || rowVals == "OOO")
                {
                    gameOver = true;
                    break;
                }
            }

            string xVal1 = GBoard[0, 0] + GBoard[1, 1] + GBoard[2, 2];
            if (xVal1 == "XXX" || xVal1 == "OOO") { gameOver = true; }

            string xVal2 = GBoard[2, 0] + GBoard[1, 1] + GBoard[0, 2];
            if (xVal2 == "XXX" || xVal2 == "OOO") { gameOver = true; }

            bool noMoreMoves = true;

            for (row = 0; row < 3; row++)
            {
                for (col = 0; col < 3; col++)
                {
                    if (GBoard[row,col] == "_" ) { noMoreMoves = false; }
                }
            }

            if (noMoreMoves == true) { gameOver = true; }

            return gameOver;
        }
        
    }
}
