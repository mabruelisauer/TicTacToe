using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Representation
    {
        public string Content { get; }


        private Representation(string content)
        {
            Content = content;
        }

        internal void Print()
        {
            Console.Write(Content);
        }
    }
}
