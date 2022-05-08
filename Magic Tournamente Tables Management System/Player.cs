using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Tournamente_Tables_Management_System
{
    internal class Player
    {
        private String _name;
        private String _score;

        public Player(string name, string score)
        {
            _name = name;
            _score = score;
        }
    }
}
