using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class ConsoleHelper
    {
        Undo undo = new Undo();
        Grid grid { get; set; }

        

        
        public void Playercheck(Player player, Field field)
        {
            if (player.isPlayer1Turn)
            {
                field.Player1CaptureField(field);
                undo.Push(field);
            }
            else
            {
                field.Player2CaptureField(field);
                undo.Push(field);
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
                undo.Pop();
                return false;
            }
        }
    }
}
