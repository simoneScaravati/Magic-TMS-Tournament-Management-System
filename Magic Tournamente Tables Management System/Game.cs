using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Magic_Tournamente_Tables_Management_System.Player;
using static Magic_Tournamente_Tables_Management_System.Table;

namespace Magic_Tournamente_Tables_Management_System
{
    public class Game
    {
        public int total_rounds;
        public int current_round;
        public List<Table> table_list;
        public List<Player> player_list;

        public Game(int total_rounds)
        {
            this.total_rounds = total_rounds;
            this.current_round = 0;
            this.table_list = new List<Table>();
            this.player_list = new List<Player>();

        }
    }
}
