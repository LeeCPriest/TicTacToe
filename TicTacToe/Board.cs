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
                    GBoard[row, col] = "_";
                }
            }

            DrawBoard();
        }
        
        public void AddMove(Program.PlayerChar pChar, int value, int[] position)
        {

            GBoard[position[0], position[1]] = pChar.ToString();

            DrawBoard();
            IsGameOver();
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
            bool matchRow = false;
            string cellVal ="";
            ;

            for (row = 0; row < 3; row++)
            {
                string prevCellVal = "";

                for (col = 0; col < 3; col++)
                {
                   
                    cellVal = GBoard[row, col];

                    if (prevCellVal != "")
                    {
                        if (cellVal == prevCellVal && cellVal != "_") { matchRow = true; }
                        else { matchRow = false; }
                    }
                    prevCellVal = cellVal;
                }
                
                if (matchRow == true) {
                    gameOver = true;
                    break;
                }
            }

            return gameOver;
        }
        
    }
}
