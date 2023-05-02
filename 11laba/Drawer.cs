using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11laba
{
    public class Drawer
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public DateTime DateOfBirthday { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string ArtDirection { get; set; } = string.Empty;
        public DateTime DateFirstPublication { get; set; }
        public string Password
        {
            get => Password;
            set => new Hashing(Password).ToHash();
        }
    }
}
