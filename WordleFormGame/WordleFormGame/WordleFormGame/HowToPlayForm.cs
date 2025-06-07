using System;
using System.Windows.Forms;

namespace WordleFormGame
{
    public partial class HowToPlayForm : Form
    {
        private Player currentPlayer;

        public HowToPlayForm(Player player)
        {
            InitializeComponent();
            currentPlayer = player;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game gameForm = new Game(currentPlayer);
            gameForm.Show();
        }

      
    }
}
