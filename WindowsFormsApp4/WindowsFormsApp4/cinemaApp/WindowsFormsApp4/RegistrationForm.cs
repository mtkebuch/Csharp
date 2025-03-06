using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RegistrationFormApp
{
    public partial class RegistrationForm : Form
    {
        private const string FilePath = "users.txt";

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool hasErrors = false;

            
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                errorProvider.SetError(txtFirstName, "First name is required.");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                errorProvider.SetError(txtLastName, "Last name is required.");
                hasErrors = true;
            }

            if (dtpBirthDate.Value == null || dtpBirthDate.Value == DateTime.MinValue)
            {
                errorProvider.SetError(dtpBirthDate, "Birth date is required.");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(txtPersonalId.Text))
            {
                errorProvider.SetError(txtPersonalId, "Personal ID is required.");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(txtPhoneNumber.Text) || txtPhoneNumber.Text.Length != 9 || !txtPhoneNumber.Text.All(char.IsDigit))
            {
                errorProvider.SetError(txtPhoneNumber, "Phone number must be exactly 9 digits.");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                errorProvider.SetError(txtEmail, "Valid email is required.");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text.Length < 6)
            {
                errorProvider.SetError(txtPassword, "Password must be at least 6 characters.");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errorProvider.SetError(txtConfirmPassword, "Please confirm your password.");
                hasErrors = true;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider.SetError(txtConfirmPassword, "Passwords do not match.");
                hasErrors = true;
            }

            if (hasErrors)
            {
                return;
            }

            errorProvider.Clear();

            
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            DateTime birthDate = dtpBirthDate.Value;
            string personalId = txtPersonalId.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            User newUser = new User(firstName, lastName, birthDate, personalId, phoneNumber, email, password);

            
            SaveUserToFile(newUser);

            MessageBox.Show("Registration successful!");

            this.Hide();
            MovieForm movieForm = new MovieForm();
            movieForm.Show();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            
            LoadUsersFromFile();
        }

        private void lblPersonalId_Click(object sender, EventArgs e)
        {
        }

        private void SaveUserToFile(User user)
        {
            string userData = $"{user.FirstName},{user.LastName},{user.BirthDate.ToShortDateString()},{user.PersonalId},{user.PhoneNumber},{user.Email},{user.Password}";
            File.AppendAllText(FilePath, userData + Environment.NewLine);
        }

        private void LoadUsersFromFile()
        {
            if (File.Exists(FilePath))
            {
                string[] userLines = File.ReadAllLines(FilePath);
                foreach (string line in userLines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 7)
                    {
                        string firstName = parts[0];
                        string lastName = parts[1];
                        string birthDate = parts[2];
                        string personalId = parts[3];
                        string phoneNumber = parts[4];
                        string email = parts[5];
                        string password = parts[6];

                        Console.WriteLine($"Loaded User: {firstName} {lastName}, Email: {email}");
                    }
                }
            }
        }
    }
}
