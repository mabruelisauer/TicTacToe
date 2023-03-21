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
        private WinCheck _winCheck;
        private int _size = 3;
        private bool isWonByX;
        private bool isWonByO;

        public Game()
        {
            _helper = new ConsoleHelper();
            _grid = new Grid(_size);
            _player = new Player();
            _winCheck = new WinCheck();
        }

        public void Start()
        {
            bool isGameOver = false;
            _player.Player1Turn = true;
            while (!isGameOver) {
                _grid.PrintGrid();

                if ( isWonByX || isWonByO ) 
                {
                    _helper.PrintWinner(isWonByX, isWonByO);
                    isGameOver = _helper.IsGameEnded();
                }
                if ( !isGameOver )
                {
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
                }



                if (_player.Player1Turn)
                {
                    string[,] stringGrid = _grid.GetRepresentationString();
                    if(_winCheck.CheckWin(stringGrid, "X")) { isWonByX = true; }
                    _player.Player1Turn = false;
                    _player.Player2Turn = true;
                }
                else
                {
                    string[,] stringGrid = _grid.GetRepresentationString();
                    if (_winCheck.CheckWin(stringGrid, "O")) { isWonByO = true; }
                    _player.Player1Turn = true;
                    _player.Player2Turn = false;
                }
            }
        }
    }
}
