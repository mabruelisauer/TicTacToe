using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game
    {
        private ConsoleHelper _helper;
        private Grid _grid;
        private Player _player;
        private Field _field;
        private int _size = 3;

        public Game()
        {
            _helper = new ConsoleHelper();
            _grid = new Grid(_size);
            _player = new Player();
        }

        public void Start()
        {
            bool isGameOver = false;
            _player.Player1Turn = true;
            while (!isGameOver) {
                _grid.PrintGrid();
                Console.WriteLine("Select a field you would like to claim by entering it's coordinates. For example: 1A for the first field.");
                Field selectedField;
                
                do
                {
                    var coordinate = ConsoleHelper.GetCoordinate(_size);
                    if (coordinate == null)
                    {
                        return;
                    }
                    selectedField = _grid.GetField(coordinate);
                } while (!_helper.IsFieldFree(selectedField));
                
                _helper.Playercheck(_player, selectedField);

                if (_player.Player1Turn)
                {
                    _player.Player1Turn = false;
                    _player.Player2Turn = true;
                }
                else
                {
                    _player.Player1Turn = true;
                    _player.Player2Turn = false;
                }
            }
        }
    }
}
