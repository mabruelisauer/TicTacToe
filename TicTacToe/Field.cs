using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TicTacToe.Representation;

namespace TicTacToe
{
    internal class Field
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

        public Field(int index)
        {
            Index = index;
        }

        public Representation GetRepresentation()
        {
            return " ";
        }
    }
}
