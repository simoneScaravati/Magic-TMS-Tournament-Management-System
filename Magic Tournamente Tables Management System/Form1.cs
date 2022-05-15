using static Magic_Tournamente_Tables_Management_System.version;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace Magic_Tournamente_Tables_Management_System
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
            this.game = new Game(0);
            setTitleWithVersion();
        }

        private void setTitleWithVersion()
        {
            this.Text = this.Text + " - " + version.getVersionText();
        }

        public void ShufflePlayers(List<Player> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Player value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            String temp = textBoxAddPlayer.Text;

            if (temp != "")
            {
                textBoxAddPlayer.Text = "";
                listBoxPlayers.Items.Add(temp);
                this.game.player_list.Add(new Player(temp, 0));
            }else
            {
                MessageBox.Show("Player box empty");
            }
        }

        

        private void buttonRemovePlayer_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Player first!");
                return;
            }

            this.game.player_list.RemoveAll(p => p.name == listBoxPlayers.SelectedItem.ToString()); //warning: could be more with the same name (stupid thing)
            listBoxPlayers.Items.Remove(listBoxPlayers.SelectedItem);
            listBoxPlayers.Refresh();
        }

        private void buttonRemoveAllPlayer_Click(object sender, EventArgs e)
        {
            this.game.player_list.Clear();
            listBoxPlayers.Items.Clear();
            listBoxPlayers.Refresh();
        }


        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            String temp = textBoxAddTable.Text;

            if (temp != "")
            {
                textBoxAddTable.Text = "";
                listBoxTables.Items.Add(temp);
                this.game.table_list.Add(new Table(temp));
            }
            else
            {
                MessageBox.Show("Table box empty");
            }
        }

        private void buttonRemoveTable_Click(object sender, EventArgs e)
        {
            if (listBoxTables.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Table first!");
                return;
            }

            this.game.table_list.RemoveAll(t => t.id == listBoxTables.SelectedItem.ToString()); //warning: could be more with the same name (stupid thing)
            listBoxTables.Items.Remove(listBoxTables.SelectedItem);
            listBoxTables.Refresh();
        }

        private void buttonRemoveAllTable_Click(object sender, EventArgs e)
        {
            this.game.table_list.Clear();
            listBoxTables.Items.Clear();
            listBoxTables.Refresh();
        }

        

        private void dataGridViewMatching_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            string json_players = JsonConvert.SerializeObject(this.game.player_list);
            string json_data_tables = JsonConvert.SerializeObject(this.game.table_list);

            string json_data = "{ " +
                            " \"playernames\":" + json_players + "," +
                            " \"tables\":" + json_data_tables + " }";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JSON File|*.json";
            saveFileDialog1.Title = "Save Current Game settings";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, json_data);
            }
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewGame newGame = new FormNewGame(this.game); //set total_rounds here
            DialogResult res = newGame.ShowDialog();  //wait for start execution

            if (res == DialogResult.OK)
            {
                gameStart();
            }

            UpdateRoundsText();

        }

        private void UpdateRoundsText()
        {
            labelCurrentRound.Text = this.game.current_round.ToString() + " / " + this.game.total_rounds.ToString();
        }

        private void gameStart()
        { 
            if(!this.game.game_started)
            {
                //check players
                int p = Convert.ToInt32(listBoxPlayers.Items.Count.ToString());
                if (p > 0)
                {
                    this.game.total_players = p;
                }
                else
                {
                    MessageBox.Show("Too few players");
                    return;
                }

                //check tables --> doesn't count the real number insert, but it calculates the criteria
                int t = Convert.ToInt32(listBoxTables.Items.Count.ToString());
                if (t > 0)
                {
                    UpdateTotalTables();
                }
                else
                {
                    MessageBox.Show("Too few tables");
                    return;
                }

                //if everything is ok
                this.game.current_round = 0;
                this.game.game_started = true;
            }else
            {
                MessageBox.Show("Game already started, please restart the program");
            }
            

        }

        private void UpdateTotalTables()
        {
            int total_players = this.game.total_players;
            int diff = total_players / Game.PLAYERS_PER_TABLE;
            int tables = (total_players - diff) / Game.EXTRA_TABLE_PLAYERS;
            this.game.total_tables = tables;
        }

        /*IMPORTANT NOTE: for easy development, we consider that organizer already checks if table number is correct */
        private void buttonNextRound_Click(object sender, EventArgs e)
        {
            if (!this.game.game_started)
            {
                MessageBox.Show("Game not started!");
                return ;
            }

            //MessageBox Yes or No fure surance of points
            DialogResult dialogResult = MessageBox.Show("Are you sure to continue to next round?", "Warning Next Round", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (this.game.current_round == 0)
                {
                    //first round
                    List<Player> listCopy = new List<Player>(this.game.player_list); //create a copy of player list 
                    ShufflePlayers(listCopy); //randomize it
                    int n = listCopy.Count;
                    int table_counter = 0;
                    List<Table> t = this.game.table_list; //pointer for refactoring
                    UpdateTotalTables(); //check if this.game.total_tables is the same --> number of player changes is not a problem
                    while (table_counter < this.game.total_tables)
                    {
                        if (n >= Game.PLAYERS_PER_TABLE)
                        {
                            for (int i = 0; i < Game.PLAYERS_PER_TABLE; i++)
                            {
                                t[table_counter].players.Add(listCopy[listCopy.Count - 1]); //select last
                                listCopy.RemoveAt(listCopy.Count - 1); //remove player from random copy list (last index)
                            }

                            n -= Game.PLAYERS_PER_TABLE;
                            table_counter++;

                        }
                        if (n == Game.EXTRA_TABLE_PLAYERS)
                        {
                            for (int i = 0; i < Game.EXTRA_TABLE_PLAYERS; i++)
                            {
                                t[table_counter].players.Add(listCopy[listCopy.Count - 1]); //select last
                                listCopy.RemoveAt(listCopy.Count - 1); //remove player from random copy list (last index)
                            }

                            n -= Game.EXTRA_TABLE_PLAYERS;
                            table_counter++;
                        }

                    }

                    //buy counters
                    foreach (Player p in listCopy)
                    {
                        int i = this.game.player_list.FindIndex(x => x.name == p.name);
                        this.game.player_list[i].won_buy_count++;
                        this.game.player_list[i].score += Game.BUY_POINTS; 
                        // TODO check for next rounds to see if someone had already buy points (retry random?)
                    }


                }
                else if (this.game.current_round == this.game.total_rounds)
                {
                    //last round --> DO NOTHING! 
                    buttonNextRound.Enabled = false; //disable the button, game over
                    MessageBox.Show("Game Over!");

                }
                else
                {
                    //middle rounds
                }

                /* TODO update matching datagrid */
                UpdateMatching();

                /* TODO update ranking grid */
                UpdateRanking();

                //do something
                this.game.current_round++;
                UpdateRoundsText();


            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
           

        }

        private void UpdateRanking()
        {
            if (this.game.current_round != 0)
            {
                //if it's not the first round, interpret the datagrid view of matching
                foreach (Table t in this.game.table_list)
                {
                    foreach(Player p in t.players)
                    {
                        String searchValue = p.name;
                        foreach (DataGridViewRow row in dataGridViewMatching.Rows)
                        {
                            if (row.Cells["PlayerAssign"].Value.Equals(searchValue))
                            {
                                
                                DataGridViewCheckBoxCell? chkcheckingWon = row.Cells["WonRound"] as DataGridViewCheckBoxCell;

                                if (Convert.ToBoolean(chkcheckingWon.Value) == true)
                                {
                                    if(t.players.Count == Game.PLAYERS_PER_TABLE)
                                    {
                                        int i = this.game.player_list.FindIndex(x => x.name == p.name);
                                        this.game.player_list[i].won_on_big_tables_count++;
                                        this.game.player_list[i].score += Game.WINNER_POINTS;
                                    }

                                    else if (t.players.Count == Game.EXTRA_TABLE_PLAYERS)
                                    {
                                        int i = this.game.player_list.FindIndex(x => x.name == p.name);
                                        this.game.player_list[i].won_on_small_table_count++;
                                        this.game.player_list[i].score += Game.WINNER_POINTS;
                                    }

                                }

                                DataGridViewCheckBoxCell? chkcheckingTie = row.Cells["TieWon"] as DataGridViewCheckBoxCell;
                                if (Convert.ToBoolean(chkcheckingTie.Value) == true)
                                {
                                    int i = this.game.player_list.FindIndex(x => x.name == p.name);
                                    this.game.player_list[i].score += Game.TIE_POINTS;
                                }

                                break;
                            }
                        }
                    }
                    
                }
                    
            }

            dataGridViewRanking.Rows.Clear(); //every time cleans everything up, so if the players have changed it's ok
            foreach (Player p in this.game.player_list)
            {
                int rowId = dataGridViewRanking.Rows.Add();

                try
                {
                    // Grab the new row!
                    DataGridViewRow row = dataGridViewRanking.Rows[rowId];

                    row.Cells["Player"].Value = p.name;
                    row.Cells["Score"].Value = p.score;
                    row.Cells["WonOnBigTable"].Value = p.won_on_big_tables_count;
                    row.Cells["WonOnSmallTable"].Value = p.won_on_small_table_count;
                    row.Cells["Buy"].Value = p.won_buy_count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void UpdateMatching()
        {
            foreach (Table t in this.game.table_list)
            {
                foreach(Player p in t.players)
                {
                    int rowId = dataGridViewMatching.Rows.Add();

                    try
                    {
                        // Grab the new row!
                        DataGridViewRow row = dataGridViewMatching.Rows[rowId];

                        row.Cells["PlayerAssign"].Value = p.name;
                        row.Cells["TableAssign"].Value = t.id;
                        row.Cells["WonRound"].Value = false;
                        row.Cells["TieWon"].Value = false;
                        //row.Cells["BuyWon"].Value = false; //deprecated
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                
            }
            
            
        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo(); //set total_rounds here
            DialogResult res = info.ShowDialog();  //wait for start execution
        }

       


        //UNUSEFUL FUNCTIONS
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a JSON file",
                Filter = "JSON files (*.json)|*.json",
                Title = "Open JSON file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                string filePath = openFileDialog1.FileName;
                if(filePath != "")
                {
                   
                    string string_json_file = File.ReadAllText(filePath);

                    //get the players from json
                    Dictionary<string, List<Player>> retPlayer = JsonConvert.DeserializeObject<Dictionary<string, List<Player>>>(string_json_file)!;
                    if (retPlayer != null)
                    {
                        this.game.player_list.Clear();  //remove all players from game
                        listBoxPlayers.Items.Clear();   //clear the listbox

                        List<Player> list = new List<Player>();
                        bool hasValue = retPlayer.TryGetValue("playernames", out list);
                        if (hasValue)
                        {
                            foreach (Player p in list)
                            { 
                                listBoxPlayers.Items.Add(p.name);
                                this.game.player_list.Add(p);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Key not present");
                        }
                    }

                    //get the tables from json
                    Dictionary<string, List<Table>> retTables = JsonConvert.DeserializeObject<Dictionary<string, List<Table>>>(string_json_file)!;

                    if (retTables != null)
                    {
                        this.game.table_list.Clear();  //remove all players from game
                        listBoxTables.Items.Clear();   //clear the listbox

                        List<Table> list = new List<Table>();
                        bool hasValue = retTables.TryGetValue("tables", out list);
                        if (hasValue)
                        {
                            foreach (Table t in list)
                            {
                                listBoxTables.Items.Add(t.id);
                                this.game.table_list.Add(t);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Key not present");
                        }
                    }





                }
                
                
            }


            
        }

       
    }
}