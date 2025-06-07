using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WordleFormGame
{
    public partial class Game : Form
    {
        private int currentRow = 0;
        private string correctWord;
        private Player currentPlayer;
        private List<string> wordsList = new List<string> { "APPLE", "HOUSE", "PLANE", "CRANE", "BRICK" };

        private List<Guess> guesses = new List<Guess>();
        private bool hasWon = false;

        public Game(Player player)
        {
            InitializeComponent();
            currentPlayer = player;
        }

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int index = random.Next(wordsList.Count);
            correctWord = wordsList[index];

            MessageBox.Show(correctWord); 
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (currentRow == 5)
            {
                MessageBox.Show("No more attempts left!");
                FinishGame(false);
                return;
            }

            string guess = "";

            for (int col = 0; col < 5; col++)
            {
                string textBoxName = $"textBox{currentRow}{col}";
                TextBox currentTextBox = this.Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;

                if (currentTextBox != null)
                    guess += currentTextBox.Text.ToUpper();
            }

            if (guess.Length != 5)
            {
                MessageBox.Show("Please fill all 5 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            guesses.Add(new Guess
            {
                Word = guess,
                AttemptNumber = currentRow + 1
            });

            for (int col = 0; col < 5; col++)
            {
                string textBoxName = $"textBox{currentRow}{col}";
                TextBox currentTextBox = this.Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;

                if (currentTextBox != null)
                {
                    char guessedChar = guess[col];
                    char correctChar = correctWord[col];

                    if (guessedChar == correctChar)
                        currentTextBox.BackColor = Color.Green;
                    else if (correctWord.Contains(guessedChar))
                        currentTextBox.BackColor = Color.Gold;
                    else
                        currentTextBox.BackColor = Color.LightGray;
                }
            }

            if (guess == correctWord)
            {
                hasWon = true;
                MessageBox.Show("You guessed the word!");
                FinishGame(true);
            }
            else
            {
                currentRow++;

                if (currentRow == 5)
                {
                    MessageBox.Show("You lost! The word was: " + correctWord);
                    FinishGame(false);
                }
            }
        }

        private void FinishGame(bool won)
        {
            currentPlayer.GamesPlayed++;

            if (won)
            {
                currentPlayer.CurrentWinStreak++;
                if (currentPlayer.CurrentWinStreak > currentPlayer.MaxWinStreak)
                    currentPlayer.MaxWinStreak = currentPlayer.CurrentWinStreak;
            }
            else
            {
                currentPlayer.CurrentWinStreak = 0;
            }

            UpdateWinPercentage(won);

            using (var db = new WordleDbContext())
            {
                var player = db.Players.Find(currentPlayer.Id);
                if (player != null)
                {
                    player.GamesPlayed = currentPlayer.GamesPlayed;
                    player.CurrentWinStreak = currentPlayer.CurrentWinStreak;
                    player.MaxWinStreak = currentPlayer.MaxWinStreak;
                    player.WinPercentage = currentPlayer.WinPercentage;

                    db.SaveChanges();
                }
            }

            ShowStats();
        }

        private void UpdateWinPercentage(bool won)
        {
            if (currentPlayer.GamesPlayed > 0)
            {
                int previousWins = (int)Math.Round(currentPlayer.WinPercentage * (currentPlayer.GamesPlayed - 1) / 100.0);
                if (won)
                    previousWins++;

                currentPlayer.WinPercentage = (int)((double)previousWins / currentPlayer.GamesPlayed * 100);
            }
        }

        private void ShowStats()
        {
            StatsForm statsForm = new StatsForm(currentPlayer, guesses);
            statsForm.Show();
            this.Hide();
        }
    }
}
