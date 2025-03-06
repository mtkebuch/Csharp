using System;

namespace RegistrationFormApp
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PersonalId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string firstName, string lastName, DateTime birthDate, string personalId, string phoneNumber, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            PersonalId = personalId;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
        }
    }
}
