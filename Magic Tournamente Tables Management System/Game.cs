using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Magic_Tournamente_Tables_Management_System.Player;
using static Magic_Tournamente_Tables_Management_System.Table;

namespace Magic_Tournamente_Tables_Management_System
{
    internal class Game
    {
        private int total_rounds;
        private int current_round;
        private List<Table> table_list;
        private List<Player> player_list;

        public Game(int total_rounds)
        {
            this.total_rounds = total_rounds;
            this.current_round = 0;
            this.table_list = new List<Table>();
            this.player_list = new List<Player>();

        }
    }
}
