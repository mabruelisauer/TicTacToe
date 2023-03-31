using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Field
    {
        private Field? _right;
        private Field? _left;
        private Field? _top;
        private Field? _bottom;

        public Field? Right => _right;
        public Field? Left => _left;
        public Field? Top => _top;
        public Field? Bottom => _bottom;

        public int Index { get; }

        public bool OwnedByPlayer1 { get; private set; }
        public bool OwnedByPlayer2 { get; private set; }

        public Field(int index)
        {
            Index = index;
        }

        public string GetStringRepresentation()
        {
            if (OwnedByPlayer1)
            {
                return "X";
            }
            if (OwnedByPlayer2)
            {
                return "O";
            }
            else
            {
                return " ";
            }
        }

        public string GetRepresentation()
        {   
            if (OwnedByPlayer1)
            {
                return "X";
            }
            if (OwnedByPlayer2)
            {
                return "O";
            }
            else
            {
                return " ";
            } 
        }

        public void Player1CaptureField(Field field)
        {
            field.OwnedByPlayer1 = true;
        }
        public void Player2CaptureField(Field field)
        {
            field.OwnedByPlayer2 = true;
        }
    }
}
