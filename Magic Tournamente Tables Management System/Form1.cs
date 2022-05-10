using static Magic_Tournamente_Tables_Management_System.version;

namespace Magic_Tournamente_Tables_Management_System
{
    public partial class Form1 : Form
    {
        private Game game;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            listBoxPlayers.Items.Remove(listBoxPlayers.SelectedItem);
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
            listBoxTables.Items.Remove(listBoxTables.SelectedItem);
            listBoxTables.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveTODOToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

                //check tables
                int t = Convert.ToInt32(listBoxTables.Items.Count.ToString());
                if (t > 0)
                {
                    this.game.total_tables = t;
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

        private void buttonNextRound_Click(object sender, EventArgs e)
        {
            if (!this.game.game_started)
            {
                MessageBox.Show("Game not started!");
                return ;
            }

            if(this.game.current_round == 0)
            {
                //first round

                
            }
            else if(this.game.current_round == this.game.total_rounds)
            {
                //last round
            }
            else
            {
                //middle rounds
            }

            //MessageBox Yes or No fure surance of points
            DialogResult dialogResult = MessageBox.Show("Are you sure to continue to next round?", "Warning Next Round", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                this.game.current_round++;
                UpdateRoundsText();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
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
    }
}