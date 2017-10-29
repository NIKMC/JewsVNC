using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuceVNC
{
    class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Organization { get; set; }
        public string ConfirmPassword { get; set; }
        public User(string login, string password, string email, string organization, string confirmPassword)
        {
            this.Login = login;
            this.Password = password;
            this.Email = email;
            this.Organization = organization;
            this.ConfirmPassword = confirmPassword;
        }
        public User()
        {        }
    }
}
