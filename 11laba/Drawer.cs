using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11laba
{
    public class Drawer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public DateTime DateOfBirthday { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string ArtDirection { get; set; } = string.Empty;
        public DateTime DateFirstPublication { get; set; }
        public string Password {get; set;}
        public Drawer(string name, string surname, DateTime dateOfBirthday, string email, string phoneNumber, string artDirection, DateTime dateFirstPublication, string password)
        {
            Name = name;
            Surname = surname;
            DateOfBirthday = dateOfBirthday;
            Email = email;
            PhoneNumber = phoneNumber;
            ArtDirection = artDirection;
            DateFirstPublication = dateFirstPublication;
            Password = password;
        }
    }
}
