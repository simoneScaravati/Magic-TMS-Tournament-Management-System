using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Tournamente_Tables_Management_System
{
    public class Player
    {
        private String _name;
        private int _score;

        public Player(string name, int score)
        {
            _name = name;
            _score = score;
        }
    }
}
