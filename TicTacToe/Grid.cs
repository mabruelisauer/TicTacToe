using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Grid
    {
        private readonly int _rows;
        private readonly int _columns;
        private Field[,] _table;
        public Field[,] Table { get; set; }

        public Grid(int rows)
        {
            _rows = rows;
            _columns = rows;
            CreateGrid();
        }

        public Field[,] GetGrid()
        {
            return _table;
        }

        public void CreateGrid()
        {
            _table = new Field[_rows, _columns];
            int index = 0;
            for (int i = 0; i < _table.GetLength(0); i++)
            {
                for (int j = 0; j < _table.GetLength(1); j++)
                {
                    _table[i, j] = new Field(index);
                    index++;
                }
            }
        }

        public void Print()
        {
            //Console.Clear();
            Console.WriteLine();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int i = 0;
            Console.Write("     ");
            for (i = 0; i < _table.GetLength(1); i++)
            {
                Console.Write("  " + alpha[i] + " ");
            }

            Console.WriteLine();
            Console.Write("     -");
            for (int y = 0; y < _table.GetLength(1); y++)
            {
                Console.Write("----");
            }
            Console.WriteLine("");
            for (int x = 0; x < _table.GetLength(0); x++)
            {
                Console.Write("  " + (x + 1).ToString("00") + " | ");

                for (int y = 0; y < _table.GetLength(1); y++)
                {
                    var field = _table[x, y];
                    var representation = field.GetRepresentation();
                    Console.Write(representation);
                    Console.Write(" | ");
                    //double waiting = ((3000 / _table.GetLength(0)) - 70) / _table.GetLength(0);
                    //int waitingTime = Convert.ToInt32(waiting);
                    //System.Threading.Thread.Sleep(waitingTime);
                }
                Console.WriteLine("");
                Console.Write("     -");
                for (int y = 0; y < _table.GetLength(1); y++)
                {
                    Console.Write("----");
                }
                Console.WriteLine("");
                //System.Threading.Thread.Sleep(70);
            }
        }

        internal Field GetField(Coordinate coordiante)
        {
            
            return _table[coordiante.Y, coordiante.X];
        }

        public string[,] GetRepresentationString()
        {
            string[,] representation = new string[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Field field = _table[row, col];
                    var fieldRepresentation = field.GetStringRepresentation();
                    representation[row, col] = fieldRepresentation;
                }
            }
            return representation;
        }
    }
}
