using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class GameUI
    {
        private Game game = new Game();
        public void StartGame()
        {

            while (!game.isGameOver)
            {
                game.PrintGrid();
                game.PrintWinnerIfWon();

                if (!game.isGameOver)
                {
                    game.PrintGrid();
                    string CurrentPlayer = game.GetCurrentPlayer();
                    Console.WriteLine($"{CurrentPlayer}: select a field you would like to claim by entering it's coordinates. For example: 1A for the first field.");

                    Field selectedField;

                    do
                    {
                        var coordinate = ConsoleHelper.GetCoordinate(game._size);
                        if (coordinate == null)
                        {
                            return;
                        }
                        if(game.IsCoordinateAvailable(selectedField = game.CoordinateToField(coordinate)))
                        {
                            break;
                        }

                        Console.WriteLine("This Field is already in use, please choose another one");

                    } while (true);

                    game.CaptureField(selectedField);
                }


                game.WinCheck();

                game.SwitchPlayer();

                if (game.IsDraw())
                {
                    game.PrintGrid();
                    Console.WriteLine("Draw!");
                    return;
                }
            }

        }
    }
}
