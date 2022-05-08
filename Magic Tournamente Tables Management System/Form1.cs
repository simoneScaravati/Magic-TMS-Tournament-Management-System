namespace Magic_Tournamente_Tables_Management_System
{
    public partial class Form1 : Form
    {
        private Game game;
        public Form1()
        {
            InitializeComponent();
            game = new Game(0);
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
                listBoxPlayers.Items.Add(temp);
                this.game.player_list.Add(new Player(temp, 0));
            }else
            {
                MessageBox.Show("Player box empty");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRemovePlayer_Click(object sender, EventArgs e)
        {
            listBoxPlayers.Items.Remove(listBoxPlayers.SelectedItem);
            listBoxPlayers.Refresh();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveTODOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewGame newGame = new FormNewGame(this.game);
            DialogResult res = newGame.ShowDialog();  //wait for start execution

            if (res == DialogResult.OK)
            {
                this.game.current_round = 1;
            }else
            {
                this.game.current_round = 0;
            }

            labelCurrentRound.Text = this.game.current_round.ToString() + " / " + this.game.total_rounds.ToString();

            //this.game.total_rounds = newGame.form2game.total_rounds; //already executed from 

        }
    }
}