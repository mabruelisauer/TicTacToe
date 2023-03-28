using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class ConsoleHelper
    {
        public static Coordinate GetCoordinate(int gridSize)
        {
            bool isValid;
            Coordinate coordinate;
            do
            {
                string input = Console.ReadLine();
                if (input == "ende")
                {
                    return null;
                }
                if (input == "neu")
                {
                    Program.Game();
                    return null;
                }
                (isValid, coordinate) = Coordinate.TryCreateCoordinate(input, gridSize);
                if (!isValid)
                {
                    Console.WriteLine("This is not a valid field, please write a valid Field");
                }
            } while (!isValid);
            return coordinate;
        }

        
        public void Playercheck(Player player, Field field)
        {
            if (player.Player1Turn)
            {
                field.Player1CaptureField(field);
            }
            if (player.Player2Turn)
            {
                field.Player2CaptureField(field);
            }
        }

        public bool IsFieldFree(Field field)
        {
            if (field.OwnedByPlayer1 || field.OwnedByPlayer2)
            {
                return false;
            }
            else return true;
        }

        public void PrintWinner(bool player1, bool player2)
        {
            if (player1) { Console.WriteLine("Player 1 has won the game!"); }
            else { Console.WriteLine("Player 2 has won the game!"); }
        }

        public bool IsGameEnded()
        {
            string input;
            do
            {
                Console.WriteLine("Write 'gg' to end the game or write 'undo' to to undo the last move.");
                input = Console.ReadLine();

            } while (input != "undo" && input != "gg");

            if (input == "gg")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
