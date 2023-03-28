using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TicTacToe
{
    public class WinDrawCheck
    {
        public bool CheckWin(string[,] grid, string playerSymbol)
        {
            //Column
            if (grid[0, 0] == playerSymbol && grid[1, 0] == playerSymbol && grid[2, 0] == playerSymbol)
            {
                return true;
            }

            if (grid[0, 1] == playerSymbol && grid[1, 1] == playerSymbol && grid[2, 1] == playerSymbol)
            {
                return true;
            }

            if (grid[0, 2] == playerSymbol && grid[1, 2] == playerSymbol && grid[2, 2] == playerSymbol)
            {
                return true;
            }

            //Row
            if (grid[0, 0] == playerSymbol && grid[0, 1] == playerSymbol && grid[0, 2] == playerSymbol)
            {
                return true;
            }

            if (grid[1, 0] == playerSymbol && grid[1, 1] == playerSymbol && grid[1, 2] == playerSymbol)
            {
                return true;
            }

            if (grid[2, 0] == playerSymbol && grid[2, 1] == playerSymbol && grid[2, 2] == playerSymbol)
            {
                return true;
            }

            //Diagonal
            if (grid[0, 0] == playerSymbol )
            {
                if (grid[1, 1] == playerSymbol)
                {
                    if (grid[2, 2] == playerSymbol)
                    {
                        return true;
                    }
                }
            }

            //Diagonal 2
            if (grid[0, 2] == playerSymbol)
            {
                if (grid[1, 1] == playerSymbol)
                {
                    if (grid[2, 0] == playerSymbol)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool CheckDraw(string[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == " ")
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
