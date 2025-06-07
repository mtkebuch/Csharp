using System;
using System.Linq;
using System.Windows.Forms;

namespace WordleFormGame
{
    public partial class LoginForm : Form
    {
        
        WordleDbContext db = new WordleDbContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
                txtEmail.Focus();
                return;
            }

            
            Player player = db.Players.FirstOrDefault(p => p.Email == email);

            if (player == null)
            {
                MessageBox.Show("Email does not exist. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
                txtEmail.Focus();
                return;
            }

            try
            {
                this.Hide();
                HowToPlayForm howToPlayForm = new HowToPlayForm(player); 
                howToPlayForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while opening the How To Play form: " + ex.Message);
            }
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool CheckEmailInDatabase(string email)
        {
            
            return db.Players.Any(p => p.Email == email);
        }
    }
}
