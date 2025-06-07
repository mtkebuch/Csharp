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
    public partial class Form1 : Form
    {
        WordleDBEntities db = new WordleDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (db)
            {
                bool emailExists = db.Users.Any(u => u.Email == email);

                if (emailExists)
                {
                    MessageBox.Show("Email already exists. Please choose another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User newUser = new User
                {
                    Email = email,
                    Password = password 
                };

                db.Users.Add(newUser);
                db.SaveChanges();
            }

            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = this.Location;
            loginForm.Show();
        }
    }
   }
