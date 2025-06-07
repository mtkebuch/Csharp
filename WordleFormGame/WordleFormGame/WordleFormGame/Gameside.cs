using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleFormGame
{
    public partial class Game : Form
    {
        private int currentRow = 0;
        string correctWord;


        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            using (var db = new WordleDBEntities())
            {
                var wordsList = db.Words.ToList();
               
                Random random = new Random(Guid.NewGuid().GetHashCode());

                int index = random.Next(wordsList.Count);
                correctWord = wordsList[index].Word1.ToUpper();

                MessageBox.Show(correctWord);
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (currentRow >= 4)
            {
                MessageBox.Show("No more attempts left!");
                return;
            }

            string guess = "";

            for (int col = 0; col < 5; col++)
            {
                string textBoxName = $"textBox{currentRow}{col}";
                TextBox currentTextBox = this.Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;

                if (currentTextBox != null)
                {
                    guess += currentTextBox.Text.ToUpper();
                }
            }

            if (guess.Length != 5)
            {
                MessageBox.Show("Please fill all 5 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int col = 0; col < 5; col++)
            {
                string textBoxName = $"textBox{currentRow}{col}";
                TextBox currentTextBox = this.Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;

                if (currentTextBox != null)
                {
                    char guessedChar = guess[col];
                    char correctChar = correctWord[col];

                    if (guessedChar == correctChar)
                    {
                        currentTextBox.BackColor = Color.Green;
                    }
                    else if (correctWord.Contains(guessedChar))
                    {
                        currentTextBox.BackColor = Color.Gold;
                    }
                    else
                    {
                        currentTextBox.BackColor = Color.LightGray;
                    }
                }
            }

            if (guess == correctWord)
            {
                MessageBox.Show("You guessed the word");
            }
            else
            {
                currentRow++; 
            }

        }

        
    }
}
