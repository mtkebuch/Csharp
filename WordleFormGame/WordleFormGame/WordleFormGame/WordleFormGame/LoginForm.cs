using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleFormGame
{
    public partial class LoginForm : Form
    {
        WordleDBEntities db = new WordleDBEntities();   

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool emailExists = CheckEmailInDatabase(email);

            if (!emailExists)
            {
                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                this.Hide();
                Game newForm = new Game();
                newForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while opening the Game form: " + ex.Message);
            }
        }

        private bool CheckEmailInDatabase(string email)
        {
            using (db)
            {
                return db.Users.Any(u => u.Email == email);
            }
        }

    }
}
