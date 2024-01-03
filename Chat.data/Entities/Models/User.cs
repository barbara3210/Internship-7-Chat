using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.data.Entities.Models
{
    public class User
    {
        public User(string firstName, string lastName,string email,string pass)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PasswordHash = pass;


        }
        public User( string email, string pass)
        {
            
            Email = email;
            PasswordHash = pass;


        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool IsAdmin { get; set; }

 }
}
