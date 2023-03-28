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
            for (int column = 0; column < 3; column++)
            {
                if (grid[0, column] == playerSymbol && grid[1, column] == playerSymbol && grid[2, column] == playerSymbol)
                {
                    return true;
                }
            }

            for (int row = 0; row < 3; row++)
            {
                if (grid[row, 0] == playerSymbol && grid[row, 1] == playerSymbol && grid[row, 2] == playerSymbol)
                {
                    return true;
                }
            }

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
        //public bool CheckWin(Field[,] grid)
        //{
        //    // Check rows
        //    for (int row = 0; row < grid.GetLength(0); row++)
        //    {
        //        for (int column = 0; column < grid.GetLength(1) - 2; column++)
        //        {
        //            if (grid[row, column].Value != FieldValue.Empty &&
        //                grid[row, column].Value == grid[row, column + 1].Value &&
        //                grid[row, column].Value == grid[row, column + 2].Value)
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    // Check columns
        //    for (int column = 0; column < grid.GetLength(1); column++)
        //    {
        //        for (int row = 0; row < grid.GetLength(0) - 2; row++)
        //        {
        //            if (grid[row, column].Value != FieldValue.Empty &&
        //                grid[row, column].Value == grid[row + 1, column].Value &&
        //                grid[row, column].Value == grid[row + 2, column].Value)
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    // Check diagonal down-right
        //    for (int row = 0; row < grid.GetLength(0) - 2; row++)
        //    {
        //        for (int column = 0; column < grid.GetLength(1) - 2; column++)
        //        {
        //            if (grid[row, column].Value != FieldValue.Empty &&
        //                grid[row, column].Value == grid[row + 1, column + 1].Value &&
        //                grid[row, column].Value == grid[row + 2, column + 2].Value)
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    // Check diagonal up-right
        //    for (int row = grid.GetLength(0) - 1; row >= 2; row--)
        //    {
        //        for (int column = 0; column < grid.GetLength(1) - 2; column++)
        //        {
        //            if (grid[row, column].Value != FieldValue.Empty &&
        //                grid[row, column].Value == grid[row - 1, column + 1].Value &&
        //                grid[row, column].Value == grid[row - 2, column + 2].Value)
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
