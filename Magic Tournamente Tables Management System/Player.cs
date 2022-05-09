using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Tournamente_Tables_Management_System
{
    public class Player
    {
        public String _name;
        public int _score;
        public int won_buy_count;
        public int won_on_small_table_count;
        public int won_on_big_tables_count;

        public Player(string name, int score)
        {
            _name = name;
            _score = score;
            won_buy_count = 0;
            won_on_small_table_count = 0;   
            won_on_big_tables_count = 0;   
        }
    }
}
