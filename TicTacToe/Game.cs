using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game
    {
        private Grid _grid;
        private int _size = 3;

        public Game()
        {
            _grid = new Grid(_size);
        }

        public void Start()
        {
            bool isGameOver = false;
            _grid.PrintGrid();
            Console.WriteLine("This is TicTacToe");
        }
    }
}
