using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.checkers
{
    public class Checker
    {

        public Color color;

        public bool isKing = false;

        public Checker(Color color)
        {
            Color = color;
        }
    }
}
