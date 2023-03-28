using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class ConsoleHelper
    {
        public int ReadInt(int min, string instructionMessage = "")
        {
            string? input;
            int n;
            bool criteria;
            while (criteria = (!Int32.TryParse(input = Console.ReadLine(), out n) || n < min))
            {
                if (instructionMessage == "" || criteria) { instructionMessage = $"{input} is an invalid number.\nPlease enter a valid number: "; }
                Console.Write(instructionMessage);
            }
            return n;
        }
        public int ReadIntMax(int min, int max, string instructionMessage = "")
        {
            string? input;
            int n;
            bool criteria;
            while (criteria = (!Int32.TryParse(input = Console.ReadLine(), out n) || n < min || n >= max))
            {
                if (instructionMessage == "" || criteria) { instructionMessage = $"{input} is an invalid number.\nPlease enter a valid number ({min} - {max - 1}): "; }
                Console.Write(instructionMessage);
            }
            return n;
        }

        public static Coordinate GetCoordinate(int gridSize)
        {
            //// splits the user's input apart and stores it into an array
            //char[] input = Console.ReadLine().ToCharArray();
            //return input;

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
                    Console.WriteLine("Please write a valid input");
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
    }
}
