using System;
using System.Drawing;
using System.Windows.Forms;

namespace WordleFormGame
{
    public partial class StatsForm : Form
    {
        private Player currentPlayer;

        public StatsForm(Player player, System.Collections.Generic.List<Guess> guesses)
        {
            InitializeComponent();
            currentPlayer = player;

            SetupStatsLayout();
        }

        private void SetupStatsLayout()
        {
            this.Text = "Statistics";
            this.Size = new Size(400, 200);
            this.BackColor = Color.White;

            var statsPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 2,
                BackColor = Color.White,
                Padding = new Padding(20),
                AutoSize = true
            };

            statsPanel.ColumnStyles.Clear();
            for (int i = 0; i < 4; i++)
                statsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            statsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            statsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));

            
            Label labelPlayed = CreateStatNumberLabel(currentPlayer.GamesPlayed.ToString());
            Label labelWinPct = CreateStatNumberLabel(currentPlayer.WinPercentage.ToString("0"));
            Label labelCurrentStreak = CreateStatNumberLabel(currentPlayer.CurrentWinStreak.ToString());
            Label labelMaxStreak = CreateStatNumberLabel(currentPlayer.MaxWinStreak.ToString());

            
            Label textPlayed = CreateStatTextLabel("Played");
            Label textWinPct = CreateStatTextLabel("Win %");
            Label textCurrentStreak = CreateStatTextLabel("Current\nStreak");
            Label textMaxStreak = CreateStatTextLabel("Max\nStreak");

            
            statsPanel.Controls.Add(labelPlayed, 0, 0);
            statsPanel.Controls.Add(labelWinPct, 1, 0);
            statsPanel.Controls.Add(labelCurrentStreak, 2, 0);
            statsPanel.Controls.Add(labelMaxStreak, 3, 0);

            statsPanel.Controls.Add(textPlayed, 0, 1);
            statsPanel.Controls.Add(textWinPct, 1, 1);
            statsPanel.Controls.Add(textCurrentStreak, 2, 1);
            statsPanel.Controls.Add(textMaxStreak, 3, 1);

            this.Controls.Add(statsPanel);
        }

        private Label CreateStatNumberLabel(string text)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
        }

        private Label CreateStatTextLabel(string text)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
        }
    }
}
