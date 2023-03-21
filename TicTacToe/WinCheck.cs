using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class WinCheck
    {
        public bool CheckWin(string[,] grid, string playerSymbol)
        {
            for (int row = 0; row < 3; row++)
            {
                if (grid[row, 0] == playerSymbol && grid[row, 1] == playerSymbol && grid[row, 2] == playerSymbol)
                {
                    return true;
                }
            }

            for (int col = 0; col < 3; col++)
            {
                if (grid[0, col] == playerSymbol && grid[1, col] == playerSymbol && grid[2, col] == playerSymbol)
                {
                    return true;
                }
            }

            if (grid[0, 0] == playerSymbol && grid[1, 1] == playerSymbol && grid[2, 2] == playerSymbol)
            {
                return true;
            }

            if (grid[0, 2] == playerSymbol && grid[1, 1] == playerSymbol && grid[2, 0] == playerSymbol)
            {
                return true;
            }

            return false;
        }
        //public bool CheckWin(Field[,] grid)
        //{
        //    // Check rows
        //    for (int row = 0; row < grid.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < grid.GetLength(1) - 2; col++)
        //        {
        //            if (grid[row, col].Value != FieldValue.Empty &&
        //                grid[row, col].Value == grid[row, col + 1].Value &&
        //                grid[row, col].Value == grid[row, col + 2].Value)
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    // Check columns
        //    for (int col = 0; col < grid.GetLength(1); col++)
        //    {
        //        for (int row = 0; row < grid.GetLength(0) - 2; row++)
        //        {
        //            if (grid[row, col].Value != FieldValue.Empty &&
        //                grid[row, col].Value == grid[row + 1, col].Value &&
        //                grid[row, col].Value == grid[row + 2, col].Value)
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    // Check diagonal down-right
        //    for (int row = 0; row < grid.GetLength(0) - 2; row++)
        //    {
        //        for (int col = 0; col < grid.GetLength(1) - 2; col++)
        //        {
        //            if (grid[row, col].Value != FieldValue.Empty &&
        //                grid[row, col].Value == grid[row + 1, col + 1].Value &&
        //                grid[row, col].Value == grid[row + 2, col + 2].Value)
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    // Check diagonal up-right
        //    for (int row = grid.GetLength(0) - 1; row >= 2; row--)
        //    {
        //        for (int col = 0; col < grid.GetLength(1) - 2; col++)
        //        {
        //            if (grid[row, col].Value != FieldValue.Empty &&
        //                grid[row, col].Value == grid[row - 1, col + 1].Value &&
        //                grid[row, col].Value == grid[row - 2, col + 2].Value)
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    // No win condition found
        //    return false;
        //}

    }
}
