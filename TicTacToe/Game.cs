using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        private ConsoleHelper _helper;
        private Grid _grid;
        private Player _player;
        private Field _field;
        private WinDrawCheck _winCheck;
        public int _size = 3;
        private bool isWonByX;
        private bool isWonByO;

        public bool isGameOver;

        public Game()
        {
            _helper = new ConsoleHelper();
            _grid = new Grid(_size);
            _player = new Player();
            _winCheck = new WinDrawCheck();
        }

        public void PrintGrid()
        {
            _grid.Print();
        }

        public void PrintWinnerIfWon()
        {
            if (isWonByX || isWonByO)
            {
                _helper.PrintWinner(isWonByX, isWonByO);
                isGameOver = _helper.IsGameEnded();
            }
        }

        public string GetCurrentPlayer()
        {
            return _player.CurrentPlayer();
        }

        public Field CoordinateToField(Coordinate coordinate)
        {
            Field selectedField = _grid.GetField(coordinate);
            return selectedField;
        }

        public bool IsCoordinateAvailable(Field field)
        {
            return _helper.IsFieldFree(field);
        }

        public void CaptureField(Field selectedField)
        {
            _helper.Playercheck(_player, selectedField);
        }

        public void WinCheck()
        {
            string[,] stringGrid = _grid.GetRepresentationString();
            if (_player.isPlayer1Turn)
            {

                if (_winCheck.CheckWin(stringGrid, "X")) { isWonByX = true; }
            }
            else
            {
                if (_winCheck.CheckWin(stringGrid, "O")) { isWonByO = true; }
            }
        }

        public void SwitchPlayer()
        {
            _player.SwitchPlayer();
        }

        public bool IsDraw()
        {
            string[,] stringGrid = _grid.GetRepresentationString();
            return _winCheck.CheckDraw(stringGrid) && !(isWonByX || isWonByO);
        }
    }
}
