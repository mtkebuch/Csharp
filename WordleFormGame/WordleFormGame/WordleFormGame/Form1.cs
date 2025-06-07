using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WordleFormGame
{
    public partial class Form1 : Form
    {
        
        WordleDbContext db = new WordleDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (ValidateInputs(email, password))
            {
                RegisterPlayer(email, password);
            }
        }

        private bool ValidateInputs(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || !chkTerms.Checked)
            {
                MessageBox.Show("All fields are required. Please fill in the email, password, and accept the terms.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            if (db.Players.Any(p => p.Email == email))
            {
                MessageBox.Show("Email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (password.Length < 6 || !Regex.IsMatch(password, @"\d") || !Regex.IsMatch(password, @"[a-zA-Z]"))
            {
                MessageBox.Show("Weak password. Must contain letters and numbers, min 6 chars.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void RegisterPlayer(string email, string password)
        {
            var player = new Player
            {
                Email = email,
                Password = password,
                GamesPlayed = 0,
                WinPercentage = 0,
                MaxWinStreak = 0,
                CurrentWinStreak = 0
            };

            db.Players.Add(player);
            db.SaveChanges();

            MessageBox.Show("Registration successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
