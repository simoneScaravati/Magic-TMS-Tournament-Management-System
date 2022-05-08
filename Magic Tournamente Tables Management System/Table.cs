using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Magic_Tournamente_Tables_Management_System.Player;

namespace Magic_Tournamente_Tables_Management_System
{
    public class Table
    {
        private String id;
        private List<Player> players;
        public Table(String id="table")
        {
            this.id = id;
            this.players = new List<Player>();
        }

        //def __init__(self, players= [], id= 'table'):
        //    self.players_list = players     # players must be a list of Player objects
        //    self.id = id

        //def __str__(self):
        //    print(f"Id: {self.id}")
        //    print(f"Number of Players: {len(self.players_list)}")
        //    print(f"Players: {self.players_list}")
        //    return ""
    }
}
