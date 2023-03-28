using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        public bool Player1Turn { get; set; }
        public bool Player2Turn { get; set; }

        public void SwitchToPlayer2()
        {
            Player1Turn = false;
            Player2Turn = true;
        }

        public void SwitchToPlayer1()
        {
            Player1Turn = true;
            Player2Turn = false;
        }

    }
}
