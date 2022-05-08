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
    }
}