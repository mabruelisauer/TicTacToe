using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        public bool isPlayer1Turn = true;

        public string CurrentPlayer()
        {
            string currentPlayer = isPlayer1Turn ? "Player 1" : "Player 2";
            return currentPlayer;
        }
        
        public void SwitchPlayer()
        {
            isPlayer1Turn = !isPlayer1Turn;
        }
    }
}
