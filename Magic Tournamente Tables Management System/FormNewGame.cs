using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Tournamente_Tables_Management_System
{
    public partial class FormNewGame : Form
    {
        public int total_rounds = 0;
        public Game form2game;
        public FormNewGame(Game passed_game)
        {
            InitializeComponent();
            form2game = passed_game;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormNewGame_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonStartNewGame_Click(object sender, EventArgs e)
        {
            string str = numericUpDownRounds.Value.ToString();
            this.total_rounds = Convert.ToInt32(str);
            this.form2game.total_rounds = total_rounds;

            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }


        private void numericUpDownRounds_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
