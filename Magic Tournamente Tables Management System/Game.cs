﻿using System;
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
        const int PLAYERS_PER_TABLE = 4;
        const int EXTRA_TABLE_PLAYERS = 3;
        const int WINNER_POINTS = 3;
        const int TIE_POINTS = 1;
        const int LOSER_POINTS = 0;


        public int total_rounds;
        public int current_round;
        public bool game_started;
        public List<Table> table_list;
        public List<Player> player_list;
        public int total_players;
        public int total_tables;

        public Game(int total_rounds)
        {
            this.total_rounds = total_rounds;
            this.current_round = 0;
            this.game_started = false;
            this.table_list = new List<Table>();
            this.player_list = new List<Player>();
            this.total_players = 0;
            this.total_tables = 0;

        }
    }
}
